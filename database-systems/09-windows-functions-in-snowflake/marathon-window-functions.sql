
/* For this exercise, we will imagine that our race organizer client wants to start a personalized email campaign in which they congratulate runners on their recent finish times. Specifically, the organizer would like to identify when runners have made certain accomplishments, like a personal best time, running their first race in awhile, or running a certain distance for the first time. Today, we will add calculated columns to the 'runner_race' table to identify the following:
 - Instances where runners ran their first race of a given distance
 - Instances where runners ran their first race after not having run for over six months
 - Instances where runners ran a personal best time for a given distance
 - Instances where runners placed in the top 10% of finishers
 - Instances where runners improved on their previous race time by at least 5%
*/

/* 1. Let's start by selecting all columns from runner_race, along with the following columns:
 - Race distance
 - Race event date
 - Runner age
 - Runner gender */

SELECT runner_race.*, 
distance, 
event_date 
FROM runner_race
JOIN races USING(race_id)
JOIN race_events ON races.race_event_id = race_events.event_id;

/* 2. Let's start by creating a new column, called 'first_distance', which indicates whether a given race was a runner's first time attempting that distance.
To keep our main query clean, let's save our query from (1) as a CTE.
*/

WITH cte_rr AS(
SELECT runner_race.*, 
distance, 
event_date 
FROM runner_race
JOIN races USING(race_id)
JOIN race_events 
ON races.race_event_id = race_events.event_id)

SELECT *, 
ROW_NUMBER() OVER(PARTITION BY runner_id, distance ORDER BY event_date)= 1 AS first_dist
FROM cte_rr;

/* 3. Now, let's identify cases where runners 'came back' after more than six months of not having run (regardless of race distance). We can calculate this by first calculating the difference between each runner's event date and their most recent (lagged) event date. */

WITH cte_rr AS(
SELECT runner_race.*, distance, event_date FROM runner_race
JOIN races USING(race_id)
JOIN race_events ON races.race_event_id = race_events.event_id)

SELECT *, 
ROW_NUMBER() OVER(PARTITION BY runner_id, distance ORDER BY event_date)= 1 AS first_dist, 
LAG(event_date) OVER(PARTITION BY runner_id ORDER BY event_date) as prev_event_date,
DATEDIFF('day',prev_event_date, event_date) > 180 as six_month_gap
FROM cte_rr;

/* 4. Now, let's identify any race where a runner's finish time was their personal best at that distance (up to that point). */

WITH cte_rr AS(
SELECT runner_race.*, distance, event_date FROM runner_race
JOIN races USING(race_id)
JOIN race_events ON races.race_event_id = race_events.event_id)

SELECT *,
ROW_NUMBER() OVER(PARTITION BY runner_id, distance ORDER BY event_date)= 1 AS first_dist, 
LAG(event_date) OVER(PARTITION BY runner_id ORDER BY event_date) as prev_event_date,
DATEDIFF('day',prev_event_date, event_date) > 180 as six_month_gap,
MIN(finish_time) OVER(PARTITION BY runner_id, distance ORDER BY event_date) as personal_best,
finish_time = personal_best AS is_personal_best
FROM cte_rr;

/* 5. Now, let's add some columns identifying how each runner placed within each race! This means we'll be partitioning over the race, rather than the runner! Let's add a column for the runner's finish position, and an indicator for whether they finished in the top 10 percent of runners in that race. */

WITH cte_rr AS(
SELECT runner_race.*, distance, event_date FROM runner_race
JOIN races USING(race_id)
JOIN race_events ON races.race_event_id = race_events.event_id)

SELECT *,
ROW_NUMBER() OVER(PARTITION BY runner_id, distance ORDER BY event_date)= 1 AS first_dist, 
LAG(event_date) OVER(PARTITION BY runner_id ORDER BY event_date) as prev_event_date,
DATEDIFF('day',prev_event_date, event_date) > 180 as six_month_gap,
MIN(finish_time) OVER(PARTITION BY runner_id, distance ORDER BY event_date) as personal_best,
finish_time = personal_best AS is_personal_best,
RANK() OVER(PARTITION BY race_id ORDER BY finish_time) as race_rank,
PERCENT_RANK() OVER(PARTITION BY race_id ORDER BY finish_time) <= 0.1 as top_ten_percent
FROM cte_rr ORDER BY race_id, race_rank;

/* 6. Finally, let's identify runners who improved on their previous race time (at the same distance) by at least 5%. */

WITH cte_rr AS(
SELECT runner_race.*, distance, event_date FROM runner_race
JOIN races USING(race_id)
JOIN race_events ON races.race_event_id = race_events.event_id)

SELECT *,
ROW_NUMBER() OVER(PARTITION BY runner_id, distance ORDER BY event_date)= 1 AS first_dist, 
LAG(event_date) OVER(PARTITION BY runner_id ORDER BY event_date) as prev_event_date,
DATEDIFF('day',prev_event_date, event_date) > 180 as six_month_gap,
MIN(finish_time) OVER(PARTITION BY runner_id, distance ORDER BY event_date) as personal_best,
finish_time = personal_best AS is_personal_best,
RANK() OVER(PARTITION BY race_id ORDER BY finish_time) as race_rank,
PERCENT_RANK() OVER(PARTITION BY race_id ORDER BY finish_time) <= 0.1 as top_ten_percent,
LAG(finish_time) OVER(PARTITION BY runner_id, distance ORDER BY event_date) as prev_time,
finish_time <= 0.95 * prev_time AS improved_5percent
FROM cte_rr;
