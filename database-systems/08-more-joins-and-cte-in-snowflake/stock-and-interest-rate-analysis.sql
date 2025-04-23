/* For this exercise, we will calculate a monthly total of the 'big five' tech stock prices, and then append those averages to a dataset of monthly U.S. interest rates (i.e., the federal runds rate). The resulting query will let us see how U.S. tech stock prices have moved in line with the overall economy over the past few years. */

/* PART 1: Grouping our stock data by month */

/* 1(a): We want to aggregate our stock prices at the monthly level (since that is the level of our interest rate data). 
Instead of just averaging the price across all fives stocks within each month, let's compute the total market capitalization for each stick (price * volume), compute the total market capitalization across all five stocks for each day, then average
that monthly market capitalization at the monthly level. In short:
 -- Calculate volme * price for each stock
 -- Compute total market cap across all five stocks, for each date
 -- Compute average total market cap at monthly level.

 To start, JUST run a simple SELECT statement that also adds a market capitalization column (close * volume)
*/

SELECT *, (close * volume) as market_cap FROM tech_stocks;


/* 1(b): Now, edit your query in 1(a) to find the total (sum) of market cap across all stocks for each day. */

SELECT date, round(sum(close * volume)) as daily_market_cap FROM tech_stocks
GROUP BY date;


/* 1(c): We now need to group the above query by month. We can get the month-year part of a date using 
Snowflake's DATE_TRUNC() function - e.g., DATE_TRUNC('month', date). Note that you could also compute separate MONTH() and YEAR() columns and group by these, if you want.

Save the query from 1(b) as a CTE, then use your main query to average the total market cap by month.
*/

WITH cte_daily AS(
SELECT date, round(sum(close * volume)) as daily_market_cap FROM tech_stocks
GROUP BY date
)

SELECT date_trunc('month', date) as month_year,
AVG(daily_market_cap) as month_market_cap FROM cte_daily
GROUP BY month_year;


/* PART 2: Appending total tech stock market cap to interest rate date */

/* 2(a): Let's start by selecting all columns and rows from our 'fed_funds' table. */

SELECT * FROM fed_funds;


/* 2(b): Let's store our query from 1(c) as a CTE, and join it to our interest rate data with a simple INNER JOIN. */

WITH cte_daily AS(
SELECT date, round(sum(close * volume)) as daily_market_cap FROM tech_stocks
GROUP BY date
),

cte_tech_stocks AS(
SELECT date_trunc('month', date) as month_year,
AVG(daily_market_cap) as month_market_cap FROM cte_daily
GROUP BY month_year
)

SELECT * FROM fed_funds 
INNER JOIN cte_tech_stocks
ON fed_funds.date = cte_tech_stocks.month_year ;

/* 2(c): Note how many rows are in your INNER JOINed table. How many rows do you get with the following join types?
--INNER: 60
--LEFT: 830
--RIGHT: 61
--FULL: 831

Note: You can calculate the FULL JOIN total with FULL = LEFT + (RIGHT - INNER)
*/


/* 2(d): Let's practice our WHERE versus HAVING skills. Edit your query from 2(c) to accomplish the following:
 -- Change it back to an INNER join, so that we only get months with full data
 -- Remove GOOG (Google) from your tech market capitalization index
 -- Filter the final query to years 2020 - present.
*/

WITH cte_daily AS(
SELECT date, round(sum(close * volume)) as daily_market_cap FROM tech_stocks -- GOOG is last seen in this table
WHERE ticker != 'GOOG'
GROUP BY date
),

cte_tech_stocks AS(
SELECT date_trunc('month', date) as month_year,
AVG(daily_market_cap) as month_market_cap FROM cte_daily
GROUP BY month_year
)

SELECT date, interest_rate, month_market_cap FROM fed_funds 
INNER JOIN cte_tech_stocks
ON fed_funds.date = cte_tech_stocks.month_year
WHERE year(date) >= 2020;


/* 2(e): Remove the WHERE statements from your previous query. Move your main query to a CTE, and use the CORR() function to compute the correlation between interest rates and tech stock market cap separately for each year.
Save your result as a new 'view' when you're done. */

WITH cte_daily AS(
SELECT date, round(sum(close * volume)) as daily_market_cap FROM tech_stocks -- GOOG is last seen in this table
GROUP BY date
),

cte_tech_stocks AS(
SELECT date_trunc('month', date) as month_year,
AVG(daily_market_cap) as month_market_cap FROM cte_daily
GROUP BY month_year
),

cte_interest_stock_joined AS (
SELECT date, interest_rate, month_market_cap FROM fed_funds 
INNER JOIN cte_tech_stocks
ON fed_funds.date = cte_tech_stocks.month_year
)

SELECT year(date) as year, 
corr(interest_rate, month_market_cap) as rate_stock_r 
FROM cte_interest_stock_joined
GROUP BY year;

