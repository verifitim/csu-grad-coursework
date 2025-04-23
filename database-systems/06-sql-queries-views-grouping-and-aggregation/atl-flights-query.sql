/*
Imagine you are conducting data analysis on behalf of American Airlines and Alaska Airlines (these two airlines have a 
strong partnership in the U.S., and so they've partnered together for market research purposes). These airlines are hoping
to boost their operations at Atlanta International Airport (ATL), which is largely dominated by Delta. The airlines are hoping to 
examine instances of delayed flights into ATL from competitor airlines, so they can identify opportunities to advertise
their own on-time performance (which is a bit of a stretch, if you've ever flown American Airlines).

The companies want you to query the following data from our 'flights' table, which includes data on flights into ATL from 2021.
The flights in your query should meet ALL of the following criteria:
 - Occur during the summer months (June, July, August) - this is the travel season that the airlines are most interested in
 - Be operated by competitor airlines (i.e., NOT American or Alaska flights)
 - Be 'severely delayed' - i.e., be delayed longer than the average delay for all ATL flights
 - Have originated in a destination that American or Alaska airlines serves from ATL
 - The resulting query should be sorted by airline (alphabetical), then by delay (from longest to shortest)

 In the steps below, we will build this (fairly complex) query step-by-step.
*/

--1. Let's start with the first criteria - flights during the summer months (June, July, August). Query just these flights.
select * from cis655_main.flights_schema.atl_flights_query
WHERE month BETWEEN 6 AND 8; 

-- Could also do...
-- month(date) BETWEEN 6 AND 8
-- month(date) IN (6,7,8)
-- date BETWEEN date('2021-06-01') AND date('2021-08-01')


--2. Let's add our next criteria - flights NOT from Alaska Airlines or American Airlines

select * from cis655_main.flights_schema.atl_flights_query
WHERE month BETWEEN 6 AND 8
AND airline NOT IN ('Alaska', 'American'); -- or >>> lower(airline) NOT LIKE 'a%'

--3. What is another way to accomplish this query?

select * from cis655_main.flights_schema.atl_flights_query
WHERE month BETWEEN 6 AND 8
AND lower(airline) NOT LIKE 'a%';

--4. Let's add our next criteria - that the flights are delayed more than average. How would we find the average flight delay?

SELECT AVG(arrival_delay) from cis655_main.flights_schema.atl_flights_query;
 
--5. The average delay in the query above doesn't seem quite right....we might need to filter only to flights that are ACTUALLY delayed

SELECT AVG(arrival_delay) from cis655_main.flights_schema.atl_flights_query WHERE arrival_delay > 0;

--6. Now, let's incorporate the result of that query into our WHERE statement, to filter to flights that were delayed by more than average. This is called a 'sub query'.

select * from cis655_main.flights_schema.atl_flights_query
WHERE month BETWEEN 6 AND 8
AND airline NOT IN ('Alaska', 'American')
AND arrival_delay >= (
SELECT AVG(arrival_delay) from cis655_main.flights_schema.atl_flights_query WHERE arrival_delay > 0 -- This is 32.7minutes the avg delayed duration
);


--7. Finally, we need to filter to 'origin' airports that Alaska and American actually serve. How could we build a SQL query to generate a list of these airports?

SELECT DISTINCT origin from cis655_main.flights_schema.atl_flights_query
WHERE airline IN ('Alaska', 'American');

--8. Let's use a subquery to incorporate this list into our main query! We want to filter to flights from one of these airports.

select * from cis655_main.flights_schema.atl_flights_query
WHERE month BETWEEN 6 AND 8
AND airline NOT IN ('Alaska', 'American')
AND arrival_delay >= ( --Sub Query
SELECT AVG(arrival_delay) from cis655_main.flights_schema.atl_flights_query WHERE arrival_delay > 0 -- This is 32.7minutes the avg delayed duration
)
AND origin IN ( --Sub Query
SELECT DISTINCT origin from cis655_main.flights_schema.atl_flights_query
WHERE airline IN ('Alaska', 'American')
);

--9. Finally, let's create a VIEW (in your own schema) called "competitor_delayed_flights", which analysts can use to easily view this data at a later time.

CREATE VIEW competitor_delayed_flights AS
SELECT * from cis655_main.flights_schema.atl_flights_query
WHERE month BETWEEN 6 AND 8
AND airline NOT IN ('Alaska', 'American')
AND arrival_delay >= ( --Sub Query
SELECT AVG(arrival_delay) from cis655_main.flights_schema.atl_flights_query WHERE arrival_delay > 0 -- This is 32.7minutes the avg delayed duration
)
AND origin IN ( --Sub Query
SELECT DISTINCT origin from cis655_main.flights_schema.atl_flights_query
WHERE airline IN ('Alaska', 'American')
);
