
/* For this exercise, we will clean a dataset of flights to Atlanta international airport (similar to the dataset you previously normalized). */

--Before we begin, use the following script to create a temporary copy of this table in your schema.
CREATE TEMPORARY TABLE ATL_FLIGHTS_TEMP
AS (SELECT * FROM CIS655_MAIN.FLIGHTS_SCHEMA.ATL_FLIGHTS_ETL);

SELECT * FROM ATL_FLIGHTS_TEMP;

/* PART 1: CLEANING OUR DATA */

/* 1(a): Let's start by adding an 'AIRLINE' column to our data. ALL of the flights in this dataset are Delta flights - so you can simply add a new AIRLINE column, then populate it with the word 'Delta'. */

ALTER table atl_flights_temp ADD airline varchar;

UPDATE atl_flights_temp
SET airline = 'Delta' 
WHERE airline_code = 'DL';

-- OR YOU CAN DO THIS...
ALTER TABLE atl_flights_temp
ADD airline varchar AS 'Delta';


/* 1(b): Let's now move on to calculating the duration of each flight, in minutes. This should be based on the departure and actual arrival  */

ALTER TABLE atl_flights_temp
ADD duration float;

UPDATE atl_flights_temp
SET duration = timediff('minutes', departure, actual_arrival);

/* 1(c): Repeat the prior step to create an ARRIVAL_DELAY column, which should be the number of minutes between each flight's actual and scheduled delays. */

ALTER TABLE atl_flights_temp
ADD arrival_delay float;

UPDATE atl_flights_temp
SET arrival_delay = timediff('minutes', scheduled_arrival, actual_arrival);

-- OVERWRITE NEGATIVE DELAYS WITH ZERO
UPDATE atl_flights_temp
SET arrival_delay = 0
WHERE arrival_delay < 0;

SELECT * FROM ATL_FLIGHTS_TEMP;

/* 1(d): Note that, last time we analyzed this data, we specified 'airline code' and 'flight number' as a composite primary key (because multiple airlines could reuse flight numbers).
But it's more common to store a flight number as a combination of the airline and number - e.g., "DL 1500". Let's add a 'full_flight_num' column that does this. */

ALTER TABLE atl_flights_temp
ADD full_flight_num VARCHAR(10);

UPDATE atl_flights_temp
SET full_flight_num = airline_code || ' ' || flight_num;

-- OR YOU CAN DO THIS
ALTER TABLE atl_flights_temp DROP full_flight_num;

ALTER TABLE atl_flights_temp
ADD full_flight_num VARCHAR(10) AS (airline_code || ' ' || flight_num);

SELECT * FROM ATL_FLIGHTS_TEMP;

/* 1(e): Finally, let's practice a DELETE statement inside a transaction. Delete all flights from the month of December. Compare this behavior with TRUNCATE.*/

begin;

DELETE FROM atl_flights_temp
WHERE month(date) = 8;

rollback;

/* PART 2: MIGRATING CLEANED DATA INTO A NEW TABLE */
--Finally, create a new table with only the following columns, and migrate your cleaned data into it:
   --Date
   --Airline
   --Full flight num
   --Origin
   --Departure
   --Flight duration
   --Arrival delay
--NOTE: It's best to use a different name for your new table compared with your temp table. Snowflake will allow duplicate names, but it will 'mask' the permanent table behind the temporary table (meaning you can't edit it properly).

CREATE TABLE ATL_FLIGHTS_CLEAN (
	DATE DATE,
    FULL_FLIGHT_NUM VARCHAR(10),
    AIRLINE VARCHAR(16777216),
    ORIGIN VARCHAR(16777216),
	DEPARTURE TIME(9),
	DURATION FLOAT,
	ARRIVAL_DELAY FLOAT,
    PRIMARY KEY (DATE, FULL_FLIGHT_NUM)
);

INSERT INTO ATL_FLIGHTS_CLEAN
SELECT DATE, FULL_FLIGHT_NUM, AIRLINE, ORIGIN, 
DEPARTURE, DURATION, ARRIVAL_DELAY FROM atl_flights_temp;

-- OR YOU COULD DO THIS...

CREATE TABLE ATL_FLIGHTS_CLEAN
AS (SELECT DATE, FULL_FLIGHT_NUM, AIRLINE, ORIGIN, 
DEPARTURE, DURATION, ARRIVAL_DELAY FROM atl_flights_temp);

SELECT * FROM ATL_FLIGHTS_CLEAN;

