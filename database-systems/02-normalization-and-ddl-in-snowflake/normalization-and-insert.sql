--Today, we will practice looking at (and inserting) data in Snowflake.

--1. First, select all rows/columns from the 'country_languages' table in the CIS655_MAIN.WORLD schema
SELECT * FROM country_languages LIMIT 10;

--Before moving on, try using the left-hand database menu to gather some information about the table without querying it (number of rows, column structure, etc.)

/* 2. We're going to create a 'copy' of this table in your own schema, and populate it with the first 10 rows from the version in the WORLD schema. You can think of this as 'migrating' data from one database to another.
To get started, copy the SQL CREATE statement for the COUNTRY_LANGUAGE table, and place it below.
*/
--- This won't work because I don't have priveleges in the CIS655 schema
create TABLE CIS655_MAIN.WORLD.COUNTRY_LANGUAGES (
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

--Notice how if you run the code above, it says you have 'insufficient privileges' to operate on the WORLD schema (which is true - your roles aren't allowed to create tables in CIS655_MAIN)

/* 3. Switch to your 'animal' role (badger, zebra, etc.), and choose your schema as part of your worksheet context. Copy the CREATE statement below, and replace the database path with CIS655_STUDENT.[your role] */

create TABLE CIS655_STUDENT.GIRAFFE_SCHEMA.COUNTRY_LANGUAGES (
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


--4. Now, run the code, and see if it created a new table in your schema! Use SELECT * to query all rows/columns from this table (note: the table will be empty, but you should still see the column structure)

--5. Let's populate this table with the first 10 rows of the version from CIS655_MAIN. We will run this statement inside a 'transaction'; you will BEGIN the transaction, run the statement, make sure everything looks the way you want it to, then COMMIT the transaction
BEGIN;

--INSERT statement to copy first 10 rows from CIS655_MAIN version into your schema

INSERT INTO CIS655_STUDENT.GIRAFFE_SCHEMA.COUNTRY_LANGUAGES
SELECT * FROM CIS655_MAIN.WORLD.COUNTRY_LANGUAGES LIMIT 10;

--TRUNCATE TABLE CIS655_STUDENT.GIRAFFE_SCHEMA.COUNTRY_LANGUAGES; -- Clears out table

--Type SELECT * .... to see if it worked!
SELECT * FROM cis655_student.giraffe_schema.country_languages;

rollback;
commit;

