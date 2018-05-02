-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\db_setup\swexpert.sql
-- mysql -u root -p < C:\mysql\DSA05Task2.sql > C:\mysql\DSA05Task2.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP 3002: Section 2';
SELECT '' AS 'Assignment 5: Task 2';

SELECT SYSDATE() AS 'Current System Date';
USE swexpert;
SELECT '';
SELECT '' AS 'Task 2, Q1. SWE Exercise 1 [5 points]';

SELECT ROUND(AVG(score), 2) AS average
FROM evaluation JOIN consultant
	ON evaluatee_id = c_id
WHERE CONCAT_WS(" ", c_first, c_last) = "Janet Park";

SELECT '';
SELECT '' AS 'Task 2, Q2. SWE Exercise 2 [5 points]';

SELECT RPAD(p_id, 4, " ") AS p_id,
	RPAD(c_id, 4, " ") AS c_id,
	LPAD(TRUNCATE(DATEDIFF(roll_off_date, roll_on_date) / 30.4, 0), 6, " ") AS months
FROM project_consultant;

SELECT '';
SELECT '' AS 'Task 2, Q3. SWE Exercise 3 [5 points]';

SELECT LPAD(c.c_id, 4, " ") AS c_id,
	RPAD(CONCAT_WS(", ", c_last, c_first), 20, " ") AS consultant_full_name,
	LPAD(skill_id, 8, " ") AS skill_id,
	CASE certification
		WHEN "Y" THEN RPAD("Certified", 13, " ") 
		WHEN "N" THEN RPAD("Not Certified", 13, " ")
		ELSE RPAD("Unknown", 13, " ")
	END AS certification
FROM consultant c JOIN consultant_skill cs
	ON c.c_id = cs.c_id;