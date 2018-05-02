-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\MySQL\swexpert\swexpert.sql
-- mysql -u root -p < C:\mysql\DSA02Task2.sql > C:\mysql\DSA02Task2.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'PROG2220: Section 2';
SELECT '' AS 'Assignment 2: Task 2';

SELECT SYSDATE() AS 'Current System Date';

USE swexpert;
-- Q1 --
SELECT '' AS '*** Task 2, Q1.  SWE Exercise 1[2 points]';
SELECT CONCAT(c_last, "," ,c_first) AS Full_Name, c_city
FROM consultant
ORDER BY c_city ASC;

-- Q2 --
SELECT '' AS '*** Task 2, Q2.  SWE Exercise 2[2 points]';
SELECT p_id, project_name
FROM project WHERE parent_p_id IS NOT NULL;

-- Q3 --
SELECT '' AS '*** Task 2, Q3.  SWE Exercise 3[4 points]';
SELECT p1.p_id, p1.project_name, p1.parent_p_id 
FROM project AS p1
JOIN project AS p2 ON
p1.p_id = p2.p_id;

-- Q4 --
SELECT '' AS '*** Task 2, Q4.  SWE Exercise 4[3 points]';
SELECT c_id, skill_id, certification 
FROM consultant_skill
WHERE certification = 'Y'
ORDER BY skill_id, c_id;

-- Q5 --
SELECT '' AS '*** Task 2, Q5.  SWE Exercise 5[4 points]';
SELECT p.c_id, p.c_last, p.c_first, c.c_id, c.skill_id, c.certification
FROM consultant AS p, consultant_skill AS c
WHERE p.c_id = c.c_id
AND c.certification = 'Y'
ORDER BY c.skill_id, c.c_id;
