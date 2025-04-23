/* For this exercise, we will use the 'world_emissions' schema to compare world cities in terms of their annual CO2 emissions.

Unfortuantely, we don't have city-level estimates of annual CO2 emissions - so we will need to estimate these values based
on city population, country population, and country emissions. Because these values all lives in different tables, this will involved some 'joins' - and a pretty complex SQL query! */

/* PART 1: Joining country and city information. */

/* 1(a): We're going to estimate the annual CO2 emissions for all cities in the 'city' table.
To do this, we will want to query the name and population for each city. Write a simple query that pulls these columns from 'city'. */

SELECT NAME, POPULATION FROM CITIES;


/* 1(b): Now, use a 'join' to add the same information (name and population) for each city's country (from the 'country' table).
 */

SELECT cities.NAME, cities.POPULATION, countries.NAME, countries.POPULATION
FROM cities JOIN countries
USING(countrycode);

SELECT cit.NAME, cit.POPULATION, c.NAME, c.POPULATION
FROM cities as cit JOIN countries as c
USING(countrycode);

 
/* 1(c): As you saw in the last query, both the 'city' and 'country' tables have 'Name' and 'Population' columns. It's not best practice 
to have repeated columns names in the same table - so use an alias each column that makes it easier to tell them apart (e.g., 'CityName',
'CountryPopulation'). */

SELECT cities.NAME as cityName, cities.POPULATION as cityPop, 
countries.NAME as countryName, countries.POPULATION as countryPop
FROM cities JOIN countries
USING(countrycode);
 

/* PART 2: Joining country emission information */

/* 2(a): We don't have city-level emission data, so we will estimate it based on each city's proportion of its total country population and
country-level emissions. Copy/paste your query from 1(c), and modify it by joining each country's total CO2 emissions (in tons) from
the 'emissions' table (note that your row count will INCREASE when you do this - we'll cover that in the next section). */

SELECT cities.NAME as cityName, cities.POPULATION as cityPop, 
countries.NAME as countryName, countries.POPULATION as countryPop,
emissions.CO2_TONS_TOTAL as country_co2 -- <-- Added this
FROM cities 
JOIN countries USING(countrycode)
JOIN emissions USING(countrycode); -- <-- Added this

/* 2(b): Notice that your row count INCREASED when you added in the 'emissions' table. If you investigate the emissions table,
you'll see that it has multiple years of data - which means multiple rows for each country. You can fix this by adding a WHERE statement
to filter your join result to a certain year (yes, you can use WHERE to filter on a column that doesn't appear in your final query).
 */

SELECT cities.NAME as cityName, cities.POPULATION as cityPop, 
countries.NAME as countryName, countries.POPULATION as countryPop,
emissions.CO2_TONS_TOTAL as country_co2 -- <-- Added this
FROM cities
JOIN countries USING(countrycode)
JOIN emissions USING(countrycode)
WHERE emissions.YEAR = 2020 ; -- <-- Added this (Don't need to specify emissions because emissions is the only table that has a year column)

SELECT cities.NAME as cityName, cities.POPULATION as cityPop, 
countries.NAME as countryName, countries.POPULATION as countryPop,
emissions.CO2_TONS_TOTAL as country_co2, year -- <-- Added this
FROM cities
JOIN countries USING(countrycode)
JOIN emissions USING(countrycode)
WHERE emissions.YEAR = 2020 ;

/* PART 3: Estimating city-level emissions. */

/* 3(a): We are almost done! We just need to use our new, joined data table to estimate city-level emissions.

Add one new calculated column to your SELECT statement, called 'EstimatedCityCO2'.
You will calculate this field by multiplying each city's proportion of countrywide population by the country's CO2 emissions.

So, if a city has 1 million people, and its country has 10 million people and 200,000 tons of CO2 emissions,
we would estimate (1 million / 10 million) * 200,000 as its city-specific CO2 emissions
*/

SELECT cities.NAME as cityName, cities.POPULATION as cityPop, 
countries.NAME as countryName, countries.POPULATION as countryPop,
emissions.CO2_TONS_TOTAL as country_co2,
cityPop / countryPop * country_co2 as city_est_co2 -- <-- Added this
FROM cities
JOIN countries USING(countrycode)
JOIN emissions USING(countrycode)
WHERE emissions.YEAR = 2020 ;

--Note that this is just a crude estimate we've computed - though some of these results are pretty close to estimates from this link (if you're interested):
--https://www.weforum.org/agenda/2018/07/these-are-the-cities-with-the-biggest-carbon-footprints/
