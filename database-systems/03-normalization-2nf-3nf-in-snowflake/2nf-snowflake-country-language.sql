/* Today, we will map the functional dependencies for the un-normalized dataset, 'country_languages'. We will then practice
restructuring this database in your own schemas, and populating it with data. */

/* 1. Use the space below to write out all functional dependencies in the dataset. Start by identifying the dataset's primary key columns. */
    --Use this code to view a snapshot of the dataset

DROP TABLE CLOUD_SERVICES;
DROP TABLE INSTANCE;
DROP TABLE ORGANIZATIONS;
DROP TABLE USERS;
DROP TABLE USERS_HAS_INSTANCE;
    
select * from country_languages;
    /* PK columns: */
    -- Primary Keys: COUNTRYCODE, LANGUAGES
    SELECT DISTINCT COUNTRYCODE, LANGUAGE FROM COUNTRY_LANGUAGES; -- you can test out primary keys and see changes in # of rows
    SELECT DISTINCT COUNTRYCODE FROM COUNTRY_LANGUAGES;

     /* Partial key dependencies:*/\
     -- COUNTRYCODE --> COUNTRYNAME, CONTINENT, REGION, SURFACEAREA, POPULATION,  
     --                 GNP, CAPITALCITY, CAPITALNAME, CAPITAL DISTRICT, CAPITALPOPULATION
     -- LANGUAGE --> Nothing!!!
     -- COUNTRYCODE, LANGUAGE --> ISOFFICIAL, PERCENTAGE


      /* Full key dependencies: */
      

--NOTE: That this differs a bit from the 'typical' structure of dependencies for our quiz - normally, you will have two partial key dependencies (rather than one of the partial key dependencies being empty)

/* 2. Which tables will the 2NF version of our database have, and which columns will go in each table? */

    -- Country Table (countrycode, countryname, region, ...)
    -- Country-Language Table (countrycode, language, isofficial, percentage)
    -- (Optional: Single column LANGUAGE Table)

/* 3. Now, edit the CREATE TABLE statement from the country_languages table (which you can get from 'View definition') to create two normalized tables. */
        --NOTE: Make sure all of your statements specify their primary key and foreign keys!

    -- C&P'd from COUNTRY_LANGUAGES "View Definition"
   create or replace TABLE CIS655_MAIN.WORLD.COUNTRY_LANGUAGES (
	COUNTRYCODE VARCHAR(16777216),
	LANGUAGE VARCHAR(16777216),
	ISOFFICIAL BOOLEAN,
	PERCENTAGE NUMBER(38,1),
	COUNTRYNAME VARCHAR(16777216),
	CONTINENT VARCHAR(16777216),
	REGION VARCHAR(16777216),
	SURFACEAREA NUMBER(38,2),
	COUNTRYPOPULATION NUMBER(38,0),
	GNP NUMBER(38,2),
	CAPITALCITYID NUMBER(38,0),
	CAPITALNAME VARCHAR(16777216),
	CAPITALDISTRICT VARCHAR(16777216),
	CAPITALPOPULATION NUMBER(38,0)
);

    -- COUNTRY TABLE
    create or replace TABLE COUNTRY_2NF (
	COUNTRYCODE VARCHAR(16777216),
	COUNTRYNAME VARCHAR(16777216),
	CONTINENT VARCHAR(16777216),
	REGION VARCHAR(16777216),
	SURFACEAREA NUMBER(38,2),
	COUNTRYPOPULATION NUMBER(38,0),
	GNP NUMBER(38,2),
	CAPITALCITYID NUMBER(38,0),
	CAPITALNAME VARCHAR(16777216),
	CAPITALDISTRICT VARCHAR(16777216),
	CAPITALPOPULATION NUMBER(38,0),
    PRIMARY KEY (COUNTRYCODE)    
);

    -- COUNTRY-LANGUAGES
    create or replace TABLE COUNTRY_LANGUAGES_2NF (
	COUNTRYCODE VARCHAR(16777216),
    LANGUAGE VARCHAR(16777216),
	ISOFFICIAL BOOLEAN,
	PERCENTAGE NUMBER(38,1),
    PRIMARY KEY (COUNTRYCODE, LANGUAGE)
);   

/* 4. Finally, use SELECT DISTINCT to populate each of these tables with data. */
BEGIN;

-- INSERT DATA INTO TABLES (Used "Add Columns in Editor" from Table Options)
INSERT INTO COUNTRY_2NF
SELECT DISTINCT COUNTRYCODE, COUNTRYNAME, CONTINENT, REGION, SURFACEAREA, -- DISTINCT removes duplicate rows
COUNTRYPOPULATION, GNP, CAPITALCITYID, CAPITALNAME, CAPITALDISTRICT, CAPITALPOPULATION
FROM CIS655_MAIN.WORLD.COUNTRY_LANGUAGES;

INSERT INTO COUNTRY_LANGUAGES_2NF
SELECT DISTINCT COUNTRYCODE, LANGUAGE, ISOFFICIAL, PERCENTAGE
FROM CIS655_MAIN.WORLD.COUNTRY_LANGUAGES;

COMMIT;
ROLLBACK;

