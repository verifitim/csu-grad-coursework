/* Today, we'll deal with daily stock price data from the 'big five' tech companies (Amazon, Apple, Google, Meta, Microsoft),
and use grouping to compute financial metrics for each stock and for each week during the year. */

--PART 1: Grouping by stock ticker
select * from cis655_main.finance.tech_stocks;

/* 1(a): Let's check see how many data points we have for each stock (use COUNT(*) for this). */

SELECT ticker, COUNT(*) AS num_days -- or COUNT(date)
FROM cis655_main.finance.tech_stocks
GROUP BY ticker;

/* 1(b): What if we also wanted to see the earliest and latest date for each stock, in addition to the number of days? */

SELECT ticker, COUNT(date) AS num_days,
MIN(date) as first_date,
MAX(date) as last_date,
FROM cis655_main.finance.tech_stocks
GROUP BY ticker;

/* 1(c): What's the average stock price for each ticker in our table? Let's use the 'close' price when computing the average. */

SELECT ticker, AVG(close)
FROM cis655_main.finance.tech_stocks
GROUP BY ticker;

/* 1(d): To clean this query up a bit, we can alias the grouped column (just like any other column), and can even round it to two decimal places. */

SELECT ticker, ROUND(AVG(close), 2) as avg_price
FROM cis655_main.finance.tech_stocks
GROUP BY ticker;

/*1(e): Another important measure of stock performance is volatility, which is simply the standard deviation of the stock's price. What's the average volatility
for each stock? Round to two decimal places and alias the new column as 'volatility'. */

SELECT ticker,
ROUND(AVG(close), 2) as avg_price,
ROUND(STDDEV(close), 2) as volatility
FROM cis655_main.finance.tech_stocks
GROUP BY ticker;

/* 1(f): It can be hard to interpret volatility when the stocks' average prices differ so much (a $10 swing on a $50 stock is a bigger deal than a $10 swing
on a $500 stock). Let's divide volatility by the average stock price, and call this 'coef_variation' (i.e., coefficient of variation). */

SELECT ticker,
ROUND(AVG(close), 2) as avg_price,
ROUND(STDDEV(close), 2) as volatility,
ROUND(volatility/avg_price, 3) as coef_variation
FROM cis655_main.finance.tech_stocks
GROUP BY ticker;

--PART 2: GROUPING BY YEAR
/* 2(a): Let's say we want to see how much data we have for each year. Write a query that returns the number of distinct weeks of data for each year. Call this column 'num_weeks'. */

SELECT YEAR(date) as year,
COUNT(DISTINCT WEEK(date)) as num_weeks
FROM cis655_main.finance.tech_stocks
GROUP BY year; -- alias from above 

/* 2(b): We only seem to have 'full years' of data for 2019 - 2022. What if we wanted to return the same query, but filtered only to these years? You can do this two ways - with WHERE and HAVING. */

SELECT YEAR(date) as year,
COUNT(DISTINCT WEEK(date)) as num_weeks
FROM cis655_main.finance.tech_stocks
WHERE year BETWEEN 2019 AND 2022 -- removes dates before grouping
GROUP BY year;

SELECT YEAR(date) as year,
COUNT(DISTINCT WEEK(date)) as num_weeks
FROM cis655_main.finance.tech_stocks
GROUP BY year
HAVING year BETWEEN 2019 AND 2022; -- removes dates after grouping

/* 2(c): What if we wanted to filter to these years (2019-2022) without explicitly hard-coding them? We could filter to any stock/year combination with at least 52 distinct weeks of data. Do this using a HAVING statement. */

SELECT YEAR(date) as year,
COUNT(DISTINCT WEEK(date)) as num_weeks
FROM cis655_main.finance.tech_stocks
GROUP BY year
HAVING num_weeks >= 52; -- this had to be done after grouping!

/* 2(d): Finally, what if you wanted to filter the original dataset to these years? That is, you want to check how many weeks of data are present for each year, identify the years with full data, and filter the original dataframe based on this?
There are a couple of ways to do this, but an easy way is to use a subquery! I've provided the subquery below - note that it looks a bit different from 2(c), because we only need the 'year' column, and therefore need to compute the aggregator function
in the HAVING statement.
*/
select year(date) from cis655_main.finance.tech_stocks group by year(date) having count(distinct week(date)) >= 52;

-- FILETERED ORIGINAL DATA
select * from cis655_main.finance.tech_stocks
where YEAR(date) IN(
select year(date) from cis655_main.finance.tech_stocks group by year(date) having count(distinct week(date)) >= 52
);
