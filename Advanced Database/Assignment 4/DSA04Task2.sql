-- mysql -u root -p < C:\mysql\db_setup\swexpert.sql --
-- mysql -u root -p < C:\mysql\DSA04Task2.sql > C:\mysql\DSA04Task2.out --
SELECT '' AS 'Divyansh Sharma';

SELECT '' AS 'COMP 3002 Section 2';

SELECT '' AS 'Assignment 4: Task 2';



SELECT SYSDATE() AS 'Current System Date';
USE swexpert;

SELECT '';
SELECT '' AS 'Task 2, Q1. SWE Exercise 1 [2 points]';
SELECT ROUND(AVG(score), 1) AS average_score
FROM evaluation
WHERE evaluatee_id = 105;

SELECT '';
SELECT '' AS 'Task 2, Q2. SWE Exercise 2 [2 points]';

SELECT COUNT(*) AS certified_count
FROM consultant_skill
WHERE skill_id = 1 AND certification = 'Y';

SELECT '';
SELECT '' AS 'Task 2, Q3. SWE Exercise 3 [4 points]';
SELECT DISTINCT c_first, c_last
FROM consultant c JOIN project_consultant pc 
	ON c.c_id = pc.c_id
WHERE EXISTS 
(SELECT 1
FROM project_consultant p_c JOIN consultant con 
ON p_c.c_id = con.c_id
WHERE con.c_first = 'Mark' AND
con.c_last = 'Myers' AND
p_c.p_id = pc.p_id)
ORDER BY c.c_id;

SELECT '';
SELECT '' AS ' Task 2, Q4. SWE Exercise 4 [5 points] ';
SELECT p_id, project_name
FROM project JOIN evaluation
USING (p_id)
UNION
SELECT p_id, project_name
FROM project
WHERE mgr_id IN (
SELECT c_id
FROM consultant
WHERE c_last LIKE "Z%");
