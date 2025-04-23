/* For this exercise, you will begin using the 'marathon_db' schema, which is the final database you will use for your last project milestone. Today, you will complete a small task with just a few tables (which you dealt with during milestone 2):
 - RUNNERS (info about each runner)
 - RACES (info about each race)
 - RUNNER_RACE (finish time data for each runner/race combination)

You will pracice grouping AND joining together in this exercise. Specifically, we'll look at finding the number of races each runner participated in, along with their average race finish times, and joining that information to the runners table. */

/* PART 1: Finding runners' number of races and average marathon finish times */

/* 1(a): Type out a GROUP BY statement to compute the number of races each runner participated in, using the RUNNER_RACE table. Your query should produce each runner's ID, and the number of races they ran in (call this column 'num_races'). Remember, if a runner has four entries in the runner_race table, that means they participated in four races. Your result should have 92.2k rows. */

SELECT RUNNER_ID, 
COUNT(RUNNER_ID) as num_races FROM RUNNER_RACE
GROUP BY RUNNER_ID;

/* 1(b): Now, we will try to calculate each runner's fastest MARATHON finish time. This is a bit tricky, because RUNNER_RACE only has runners' finish times, not the distance of each race. However, we can join RACES to RUNNER_RACE to get this information.

To start, type out a query that joins information about each race (name, distance, etc.) to the runner_race table. So, each row will consist of a runner's finsih time in a given race, along with all other information about that race. 
You can just select all columns from both tables for now. Remember to use ON or USING so that each runner's finish time is paired with the correct race information! */

SELECT *
FROM RUNNER_RACE
JOIN RACES USING(RACE_ID);


/* 1(c): Now, you will edit the query from 1(b) to find the minimum marathon finish time for each runner. To accomplish this, you will need to:
   - Replace the * with a statement that will select each runner_id and their minimum finish time (similar to 1(a), but calculating each runner's min finish time rather than the number of races). Call your minimum finish time column 'min_marathon_time'
   - Add a GROUP BY clause at the end, to group by runner
   - Add a WHERE statement (between the JOIN/USING clause and the GROUP BY clause) to filter to marathons only

Your final query should have 51.6k rows (one for each runner that participated in a marathon). The minimum finish time in the entire
dataset should be 131 minutes.
   */

SELECT runner_id,
MIN(FINISH_TIME) as min_marathon_finish_time
FROM RUNNER_RACE
JOIN RACES USING(RACE_ID)
WHERE DISTANCE = 'Marathon'
GROUP BY runner_id;

/* PART 2: JOINING RACE PARTICIPATION INFO TO RUNNER TABLE */

/* 2(a): We would now like to join your result from 1(a) (number of races per runner) to the runners table. 
There are multiple ways to do this (see the note below if you're interested), but we will do this by using the 1(a) result as a 'subquery' - basically, a query whose result we will reference in another query. 

Follow the instructions below to edit the query in such a way that 'num_races' will be joined to the RUNNERS table.
*/

SELECT * -- <-- leave this as-is; this will select all columns from RUNNERS and your 1(a) query
FROM runners
JOIN (  
SELECT RUNNER_ID, 
COUNT(RUNNER_ID) as num_races FROM RUNNER_RACE
GROUP BY RUNNER_ID
) as race_data -- <-- fill the parenthese with your query from 1(a). Be sure to keep the parentheses! Note that this query is being aliased as 'race_data' you can use this name to refer to that query/table in the SELECT statement is needed
USING (RUNNER_ID); -- <--Fill the parentheses with the column that will join 'runners' and your 1(a) query


--Note there are multiple ways to accomplish this step. You could start by joining runner_race to runners, and THEN summarizing the number of races for each runner. Or, you could save your grouped 'number of races per runner' query as a view, and then join it to RUNNERS. Finally, you could save your grouped result as a 'common table expression' that precedes the JOIN query - we'll learn this next week!

/* 2(b): Let's also join your query from 1(c) (minimum marathon finish time for each runner).

Copy/paste your query from 2(a), and add another JOIN/USING clause (after your existing JOIN and USING clauses) that will join your query result from 1(c), using the same subquery structure as in the previous question. You can still select all columns (*) from the three tables.

Note that we have to compute each runner's 'number of races' and 'minimum marathon finish' in separate queries; if we had computed both of these quantities in the same query, the COUNT() function would only count the number of marathons for each person, not the total number of races.

Your final query will have 51.6k rows - one for each runner that has participated in at least one marathon. If you wanted to keep all of your runner records, even those without a 'minimum marathon finish time', you could use a LEFT JOIN for that - we will cover those next week.
*/

SELECT * 
FROM runners

JOIN (  
SELECT RUNNER_ID, 
COUNT(RUNNER_ID) as num_races FROM RUNNER_RACE
GROUP BY RUNNER_ID
) as race_data 
USING (RUNNER_ID)

JOIN(
SELECT runner_id,
MIN(FINISH_TIME) as min_marathon_finish_time FROM RUNNER_RACE
JOIN RACES USING(RACE_ID)
WHERE DISTANCE = 'Marathon'
GROUP BY runner_id
) as finish_time_data
USING (RUNNER_ID); 



