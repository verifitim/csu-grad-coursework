
/* Today, we will be copying 'courses' data from our class schema into our own schemas, then performing some data cleaning steps.
Note that some of these steps are very similar to those that will be required for Milestone 2 - so, I'd advise referencing this exercise from time to time
as you work on the next milestone! */



/* PART 1: COPYING 'COURSES' DATA INTO OUR OWN SCHEMA */
--1(a): Follow the instructor to copy the CIS655_MAIN.COURSES_SCHEMA.COURSES table into your own schema. Make this a TEMPORARY table. Now that we have learned how to use CREATE and INSERT syntax, we'll learn a shortcut for copying a table's structure and data at the same time.

CREATE OR REPLACE TEMPORARY TABLE courses_temp as (select * from cis655_main.courses_schema.courses);

--After we load this into your schema, we'll be performing some data cleaning steps. Some possible 'workflows' for this include:
    -- Creating a TEMPORARY TABLE, cleaning the data within that table, then moving the data (only the columns we need) to a 'final' courses table. This allows us to leave unnecessary/extra columns in the TEMPORARY table.
    -- Cleaning the data 'in place', i.e., directly within the table that we just created. This requires us to be a bit more careful, because we will have to 'write over' data rather than housing cleaned data in new columns.
--We'll be using the first approach today, but you can use either for your milestone. 

/* PART 2: DATA CLEANING */
--2(a): We'd like to create a 'course code' column, which is a combination of 'Department' and 'Course_Number' (separated by a space). Create a new column and populated it accordingly.

SELECT * FROM courses_temp;

ALTER TABLE courses_temp
ADD course_code VARCHAR(10);

UPDATE courses_temp
SET course_code = DEPARTMENT || ' ' || COURSE_NUMBER;

--We are populating a NEW column with these values, which means that if you mess up, you can just re-run the code. If we were overwriting an existing column, we'd want to wrap this in a transaction so we could 'undo' the update if needed.

--2(b): We'd like to change the 'Days' values to M/W (for Mon/Wed courses) and T/Th (for Tues/Thurs) courses. Let's try updating this in place, but inside a transaction.
begin;

UPDATE courses_temp
SET days = 'M/W'
WHERE days = 'Mon/Wed';

UPDATE courses_temp
SET days = 'T/TH'
WHERE days = 'Tues/Thurs';

--Note: Once you run this statement once, the values will be changed, and your 'WHERE' conditions won't work again. So, if you need to redo this statement, you'll want to ROLLBACK the transaction.
select * from courses_temp;

rollback;
commit;

--Note: You could also create a 'days_cleaned' column with ALTER...ADD, and populate this column with your cleaned values. The risk is- when you go to create your final table, be sure to select THAT column, not the original!

--2(c): Finally, let's replace the 'duration' column (in minutes) with HOURS and MINUTES columns (note - you will need to do something similar for the marathon milestone!)

ALTER TABLE courses_temp
ADD hours INT, minutes INT;

UPDATE courses_temp
SET hours = FLOOR(duration / 60);

UPDATE courses_temp
SET minutes = MOD(duration, 60);

-- OR YOU CAN USE THIS

UPDATE courses_temp
SET minutes = duration - hours*60;

/*  PART 3: CREATING A FINAL TABLE */
--3(a): The temporary table we've been working in has two problems: (1) it's temporary! and (2) it contains a mixture of 'old' (not cleaned) and 'new' (cleaned) columns
--Let's create a 'courses_cleaned' table in our schema, with the following column structure:

--course_code VARCHAR(10) - set this as the PK
--building VARCHAR(10)
--days VARCHAR(10)
--capacity INT
--hours INT
--minutes INT

create TABLE courses_cleaned (
	COURSE_CODE VARCHAR(10) PRIMARY KEY,
    BUILDING VARCHAR(10),
	DAYS VARCHAR(10),
	CAPACITY INT,
	HOURS INT,
	MINUTES INT
);

--3(b): Finally, insert data into this table, using only the columns you need from your temporary courses table.

INSERT INTO courses_cleaned
SELECT COURSE_CODE, BUILDING, DAYS, CAPACITY, HOURS, MINUTES
FROM courses_temp;


select * from courses_cleaned;