/* We're going to use the new window functions we learned today to identify countries with above-average or below-average currency appreciation, 
relative to the US dollar. 

Our goal for today is pretty simple - we want to compute each country's currency appreciation (relative to the US dollar) between 2018 and 2022,
rank countries' degree of currency appreciation, then identify which countries had 'above median' or 'below median' appreciation. */

select * from exchange_rates;

/* PART 1: IDENTIFYING COUNTRIES WITH NON-MISSING EXCHANGE RATE DATA */
/* 1(a): Our dataset extends from 2018 - 2022, so we would like to only deal with countries with all five years of exchange rate data. In a SELECT statement, write a COUNT-based window function that computes the number of non-missing
exchange rates for each country. Sort the result by country_name. */

select *,
COUNT(exchange_local_usd)
OVER(PARTITION BY country_code) AS num_years
FROM exchange_rates
ORDER BY country_code;

--Note - this requires that you count over the exchange rate column, rather than using COUNT(*), because COUNT(*) will still count null values.

/* 1(b): Add a WHERE statement to filter only to countries with 5 years of data. */

with cte_num_years as(
select *, -- <-- You have to put 1a) in a CTE because WHERE statements evaluate before window fn's
COUNT(exchange_local_usd)
OVER(PARTITION BY country_code) AS num_years
FROM exchange_rates
ORDER BY country_code
)
select *,
FROM cte_num_years
WHERE num_years = 5
ORDER BY country_code, year;

/* 1(c): Whoops! Looks like Snowflake is finally being picky about where else in a SQL clause we can use our aliased columns. This behavior is the same as other programs, like MYSQL - window functions cannot be used in WHERE statements
in the same query. To get around this, we can save our table (with the window function) as a CTE, then use WHERE in the main query. */

-- See above

/* 1(d): Note - how is the result above different from the query below?

Lost the year level granularity because of grouping.
*/

select country_name, count(exchange_local_USD) as num_data_points, avg(exchange_local_USD)
from exchange_rates
group by country_name
having num_data_points = 5;

/* PART 2: COMPUTING CHANGES IN EXCHANGE RATES */

/* 2(a): In our main query, let's add a column that gives each each country's first exchange rate (from 2018). */

with cte_num_years as(
select *, -- <-- You have to put 1a) in a CTE because WHERE statements evaluate before window fn's
COUNT(exchange_local_usd)
OVER(PARTITION BY country_code) AS num_years
FROM exchange_rates
ORDER BY country_code
)
select *, 
FIRST_VALUE(exchange_local_usd) OVER(PARTITION BY country_code ORDER BY year) as rate_2018
FROM cte_num_years
WHERE num_years = 5
ORDER BY country_code, year;


/* 2(b): Let's store that main query as a CTE, then in our main query, compute the percentage in appreciation between each year's exchange rate
and the 2018 exchange rate (i.e., exchange_local_USD / rate_2018). */

with cte_num_years as(
select *, -- <-- You have to put 1a) in a CTE because WHERE statements evaluate before window fn's
COUNT(exchange_local_usd)
OVER(PARTITION BY country_code) AS num_years
FROM exchange_rates
ORDER BY country_code
),
cte_rate_2018 as( --<-- Don't need to do "with" for 2nd CTE
select *, 
FIRST_VALUE(exchange_local_usd) OVER(PARTITION BY country_code ORDER BY year) as rate_2018
FROM cte_num_years
WHERE num_years = 5
ORDER BY country_code, year
)
select *, rate_2018/exchange_local_usd as apprec_2018
from cte_rate_2018
ORDER BY country_name, year;
;


/* 2(c): Let's filter our results to 2022, and also filter out dollarized economies (economies whose exchange rate with the USD is 1). */

with cte_num_years as(
select *, -- <-- You have to put 1a) in a CTE because WHERE statements evaluate before window fn's
COUNT(exchange_local_usd)
OVER(PARTITION BY country_code) AS num_years
FROM exchange_rates
ORDER BY country_code
),
cte_rate_2018 as( --<-- Don't need to do "with" for 2nd CTE
select *, 
FIRST_VALUE(exchange_local_usd) OVER(PARTITION BY country_code ORDER BY year) as rate_2018
FROM cte_num_years
WHERE num_years = 5
ORDER BY country_code, year
)
select *, rate_2018/exchange_local_usd as apprec_2018
from cte_rate_2018
WHERE year = 2022 AND apprec_2018 != 1
ORDER BY country_name, year
;


/* PART 3: RANKING COUNTRIES' APPRECIATION */

/* 3(a): We want to rank countries by their currency appreciation since 2018. We want low ranks (i.e., the '#1 spot') to go to countries with HIGH appreciation.
Let's add a simple ranking with the RANK() function. */

with cte_num_years as(
select *, -- <-- You have to put 1a) in a CTE because WHERE statements evaluate before window fn's
COUNT(exchange_local_usd)
OVER(PARTITION BY country_code) AS num_years
FROM exchange_rates
ORDER BY country_code
),
cte_rate_2018 as( --<-- Don't need to do "with" for 2nd CTE
select *, 
FIRST_VALUE(exchange_local_usd) OVER(PARTITION BY country_code ORDER BY year) as rate_2018
FROM cte_num_years
WHERE num_years = 5
ORDER BY country_code, year
)
select *, rate_2018/exchange_local_usd as apprec_2018,
RANK() OVER(ORDER BY apprec_2018 DESC) as rank_2018
from cte_rate_2018
WHERE year = 2022 AND apprec_2018 != 1
ORDER BY rank_2018
;



--Note: WHERE statements will evaluate before SELECT statements, meaning that only the rows that are kept from the WHERE statement will be ranked (i.e., you won't have 'missing ranks' that were filtered out)



/* 3(b): Finally, let's add DENSE_RANK and PERCENT_RANK columns that use this window. */

with cte_num_years as(
select *, -- <-- You have to put 1a) in a CTE because WHERE statements evaluate before window fn's
COUNT(exchange_local_usd)
OVER(PARTITION BY country_code) AS num_years
FROM exchange_rates
ORDER BY country_code
),
cte_rate_2018 as( --<-- Don't need to do "with" for 2nd CTE
select *, 
FIRST_VALUE(exchange_local_usd) OVER(PARTITION BY country_code ORDER BY year) as rate_2018
FROM cte_num_years
WHERE num_years = 5
ORDER BY country_code, year
)
select *, rate_2018/exchange_local_usd as apprec_2018,
RANK() OVER(ORDER BY apprec_2018 DESC) as rank_2018,
DENSE_RANK() OVER(ORDER BY apprec_2018 DESC) as dense_rank_2018,
PERCENT_RANK() OVER(ORDER BY apprec_2018) as percent_rank_2018
from cte_rate_2018
WHERE year = 2022 AND apprec_2018 != 1
ORDER BY rank_2018
;
