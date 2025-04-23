/*
For today's self-guided exercise, we will use JOINs and CTEs to gather data about exchange rates between countries. This will require some more advanced JOIN syntax than the last exercise!

We will be using the 'exchange_rates' table in the CIS655_MAIN.FINANCE schema.

The result of this exercise will be a single (fairly complex) query, which will provide a list of country pairs along with the exchange rates between. Follow the instructions below to 'build up' to this query!

NOTE: Please feel free to call me over if you aren't sure about any of your queries! This exercise will get complex pretty quickly, so make
sure you feel confident about each query part before moving on!
*/


/* PART 1: Computing average exchange rates. */

/* 1(a): The 'exchange_rates' table has a list of countries and their exchange rates with the US dollars. The table has exchange rates from 2018 to 2022, but for simplicity,
we will only deal with the average exchange rate for each country across these years.

Type a query that selects each country's name and its average exchange rate with the US dollar from 2018 - 2022. Call this column 'avg_exchange_USD'. */

SELECT COUNTRY_NAME, ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME;

/* 1(b): This averaged table you just created is the exchange rate table we will use moving forward. Move your query from 1(a) to a CTE, and alias it as 'exchange_rates_avg'. In the main query, just type SELECT * FROM exchange_rates_avg to make sure it worked. */

WITH exchange_rates_avg AS(
SELECT COUNTRY_NAME, ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
) --< -- CTE

SELECT * FROM exchange_rates_avg; --<-- Main query (SELECT * from your CTE)

/* PART 2: Creating all possible pairs of countries. */

/* 2(a): We would like to create a table of all possible exchange rates between countries. To start doing this, 
we need to create a small table that lists out all possible country pairs. This can be done with a cross join! (or, just the default behavior of JOIN without specifying on / using).

Copy/paste your query from 1(b), which defines 'exchange_rate_avg' as a list of countries' average exchange rates with the US dollar. Type a CROSS JOIN statement that does the following:
 
 -- Joins the exchange_rates_avg table TO ITSELF. To do this, you'll need to create two separate aliases - you'll choose an alias for the 'left' version of the table (e.g., 'e1') and another alias for the 'right' version of the table.
 
 -- In the SELECT clause, only select the name of each country. Alias the first country name as 'country1_name', and the second country name as 'country2_name'.
 
 Your table should have 70.8k rows, each of which is a pairing between two countries! Make sure your columns are aliased to 'country1_name' and 'country2_name'.
 Note that you can start with a SELECT *, make sure you get the proper row count, and then edit your SELECT statement to only include the name of each country.
 */


WITH exchange_rates_avg AS( --<-- your CTE defining 'exchange_rates_avg'
SELECT COUNTRY_NAME, ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
)

SELECT e1.COUNTRY_NAME AS country1_name,
e2.COUNTRY_NAME AS country2_name-- <-- select the country_name column twice, once from the 'first version' of the table (e1), and once from the 'second version' of the table (e2)

FROM exchange_rates_avg e1
CROSS JOIN exchange_rates_avg e2; --<-- join 'exchange_rates_avg' to itself, using the JOIN clause provided above.

/* 2(b): You may have noticed from your previous query that, due to the nature of CROSS JOINs, we have some rows where a country is 'paired' with itself
(e.g., Aruba-Aruba). That's not very helpful for our purposes - so add a WHERE statement to remove these rows. The result will have 70.5k rows. */

WITH exchange_rates_avg AS( --<-- your CTE defining 'exchange_rates_avg'
SELECT COUNTRY_NAME, ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
)

SELECT e1.COUNTRY_NAME AS country1_name,
e2.COUNTRY_NAME AS country2_name-- <-- select the country_name column twice, once from the 'first version' of the table (e1), and once from the 'second version' of the table (e2)

FROM exchange_rates_avg e1
CROSS JOIN exchange_rates_avg e2
WHERE e1.COUNTRY_NAME <> e2.COUNTRY_NAME;

/* PART 3: Calculating exchange rates between countries. */

/* 3(a): In addition to each country's name and code, we need to know the exchange rate between its currency and the US dollar (we'll eventually use these values
to calculate exchange rates between country pairs). Add the exchange rates for both countries (i.e., 'country 1' and 'country 2')
to your SELECT statement. You'll probably want to alias your columns - something like 'rate1_USD' and 'rate2_USD'.  */

WITH exchange_rates_avg AS( --<-- your CTE defining 'exchange_rates_avg'
SELECT
COUNTRY_NAME,
ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
)

SELECT 
e1.COUNTRY_NAME AS country1_name,
e1.avg_exchange_USD AS rate1_USD,
e2.COUNTRY_NAME AS country2_name,
e2.avg_exchange_USD AS rate2_USD-- <-- select the country_name column twice, once from the 'first version' of the table (e1), and once from the 'second version' of the table (e2)

FROM exchange_rates_avg e1
CROSS JOIN exchange_rates_avg e2
WHERE e1.COUNTRY_NAME <> e2.COUNTRY_NAME;



/* 3(b): You may have noticed we have some 'NULL' exchange rates (either if the data are missing, or if the 'country' is actually a group
of countries, such as 'advanced economies' or 'world'. We also have some zero exchange rates (mainly for countries experiencing 
some level of economic distress, for which data may not be available). We can remove both of these cases by filtering for exchange rates greater than zero - 
type out a WHERE statement to implement this criterion. Your result will have 43.1k rows. */

WITH exchange_rates_avg AS( --<-- your CTE defining 'exchange_rates_avg'
SELECT
COUNTRY_NAME,
ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
)

SELECT 
e1.COUNTRY_NAME AS country1_name,
e1.avg_exchange_USD AS rate1_USD,
e2.COUNTRY_NAME AS country2_name,
e2.avg_exchange_USD AS rate2_USD-- <-- select the country_name column twice, once from the 'first version' of the table (e1), and once from the 'second version' of the table (e2)

FROM exchange_rates_avg e1
CROSS JOIN exchange_rates_avg e2
WHERE
e1.COUNTRY_NAME <> e2.COUNTRY_NAME 
AND e1.avg_exchange_USD > 0
AND e2.avg_exchange_USD > 0;

/* 3(c): Finally, we may want to go back and only include countries with five years of non-missing exchange rate date (2018 - 2022). See if you can figure out how to do this! Hint - you can go back to your original CTE,
count the number of exchange rate data points for each country, and filter based on that. Your result will have 36.3k rows. */

WITH exchange_rates_avg AS( --<-- your CTE defining 'exchange_rates_avg'
SELECT
COUNTRY_NAME,
ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
HAVING COUNT(EXCHANGE_LOCAL_USD) = 5
)

SELECT 
e1.COUNTRY_NAME AS country1_name,
e1.avg_exchange_USD AS rate1_USD,
e2.COUNTRY_NAME AS country2_name,
e2.avg_exchange_USD AS rate2_USD-- <-- select the country_name column twice, once from the 'first version' of the table (e1), and once from the 'second version' of the table (e2)

FROM exchange_rates_avg e1
CROSS JOIN exchange_rates_avg e2
WHERE
e1.COUNTRY_NAME <> e2.COUNTRY_NAME 
AND e1.avg_exchange_USD > 0
AND e2.avg_exchange_USD > 0;


/* 3(d): Now, we'll calculate exchange rates for all country pairs. This requires a bit of mathematical thinking:
If country 1's currency has an exchange rate of 10 to the dollar, and country 2's currency has an exchange rate of 5 to the dollar,
then the exchange rate between country 1 and country 2 is 10 / 5 = 2 (i.e., it takes two units of country 1's currency to buy one unit of country 2's currency).

So, in your SELECT statement, create a new calculated field in which you compute the exchange rate between country 1 and country 2 by dividing country 1's USD exchange rate with country 2's. Alias this column something like 'local_exchange_rate'.
*/

WITH exchange_rates_avg AS(
SELECT
COUNTRY_NAME,
ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
HAVING COUNT(EXCHANGE_LOCAL_USD) = 5
)

SELECT 
e1.COUNTRY_NAME AS country1_name,
e1.avg_exchange_USD AS rate1_USD,
e2.COUNTRY_NAME AS country2_name,
e2.avg_exchange_USD AS rate2_USD,
ROUND(rate1_USD / rate2_USD,2) AS local_exchange_rate

FROM exchange_rates_avg e1
CROSS JOIN exchange_rates_avg e2
WHERE
e1.COUNTRY_NAME <> e2.COUNTRY_NAME 
AND e1.avg_exchange_USD > 0
AND e2.avg_exchange_USD > 0;

/* PART 4: Practicing stored functions */

/* 4(a): Let's say that you want to add a 'country pair' column, which is simply a concatenation of your two country names, separated by a hyphen (e.g., Aruba-Afghanistan). We know that the concatenation operator is ||, but
let's do this with a custom function instead. Below is some starter code for a 'custom_concat' function, which takes two arguments (country1 and country2), and a string representing the delimiter between them ('-', ' ', '_', etc.).
Finish the function, then use it to add a 'country_pair' column to your SELECT statement, which will concatenate the two country names in each row, separated by a hyphen. */

 --Note: Replace 'your_schema' with your schema name; you don't have permission to create functions inside the CIS655_MAIN database, so we will create it in your schema

create or replace function cis655_student.GIRAFFE_SCHEMA.custom_concat(text1 VARCHAR, text2 VARCHAR)
returns varchar
language SQL
AS
$$
text1 || '-' || text2
$$;

--Copy/paste your 3(d) query below, and add a 'country_pair' column using the function above. Note: When typing the function name, use CIS655_STUDENT.YOUR_SCHEMA.function_name(), because you need to call the function from your schema. Alternatively, you could switch to your own schema
--and use CIS655_MAIN.FINANCE when referring to the exchange_rates table.

WITH exchange_rates_avg AS(
SELECT
COUNTRY_NAME,
ROUND(AVG(EXCHANGE_LOCAL_USD),2) as avg_exchange_USD
FROM CIS655_MAIN.FINANCE.exchange_rates
WHERE YEAR BETWEEN 2018 AND 2022
GROUP BY COUNTRY_NAME
HAVING COUNT(EXCHANGE_LOCAL_USD) = 5
)

SELECT 
e1.COUNTRY_NAME AS country1_name,
e1.avg_exchange_USD AS rate1_USD,
e2.COUNTRY_NAME AS country2_name,
e2.avg_exchange_USD AS rate2_USD,
ROUND(rate1_USD / rate2_USD,2) AS local_exchange_rate,
cis655_student.GIRAFFE_SCHEMA.custom_concat(country1_name,country2_name) AS country_pair

FROM exchange_rates_avg e1
CROSS JOIN exchange_rates_avg e2
WHERE
e1.COUNTRY_NAME <> e2.COUNTRY_NAME 
AND e1.avg_exchange_USD > 0
AND e2.avg_exchange_USD > 0;

