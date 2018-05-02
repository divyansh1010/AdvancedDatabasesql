-- mysql -u root -p < C:\mysql\db_setup\swexpert.sql --
-- mysql -u root -p < C:\mysql\DSA04Task3.sql > C:\mysql\DSA04Task3.out --
-- mysql -u root -p --force < C:\mysql\DSA04Task3.sql 1> C:\mysql\DSA04Task3.out 2> C:\mysql\DSA04Task3.err --

SELECT '' AS 'Divyansh Sharma';

SELECT '' AS 'COMP 3002 Section 2';

SELECT '' AS 'Assignment 4: Task 2';



SELECT SYSDATE() AS 'Current System Date';
USE swexpert;

SELECT '';
SELECT '' AS ' Task 3, Q1. SWE Exercise 1 [4 points] ';

ALTER TABLE project_consultant
ADD total_days INT DEFAULT 0;

UPDATE project_consultant
SET total_days = DATEDIFF(roll_off_date, roll_on_date);

SELECT ROW_COUNT() AS 'UPDATE: rows affected';
SELECT '';

SELECT *
FROM project_consultant;

ALTER TABLE project_consultant
DROP COLUMN total_days;

SELECT '';
SELECT '' AS 'Task 3, Q2. SWE Exercise 2 [4 points]';

DROP TABLE IF EXISTS evaluation_audit;

CREATE TABLE evaluation_audit
(
	audit_id 	INT		PRIMARY KEY		AUTO_INCREMENT,
	audit_e_id	INT		NOT NULL,
	audit_score	INT,
	audit_user	VARCHAR(20)		
);

INSERT INTO evaluation_audit
	(audit_id, audit_e_id, audit_score, audit_user)
VALUES (DEFAULT, 100, 90, NULL);

SELECT ROW_COUNT() AS 'INSERT: rows affected';
SELECT '';

SELECT *
FROM evaluation_audit;

    
SELECT '';
SELECT '' AS 'Task 3, Q3. SWE Exercise 3 [5 points]';

ALTER TABLE evaluation_audit
MODIFY audit_user VARCHAR(20) NOT NULL;

ALTER TABLE evaluation_audit
ADD audit_date DATETIME;

INSERT INTO evaluation_audit 
	(audit_e_id, audit_score, audit_user, audit_date)
VALUES (100, 95, USER(), SYSDATE());

SELECT ROW_COUNT() AS 'INSERT: rows affected';
SELECT '';

SELECT *
FROM evaluation_audit;

INSERT INTO evaluation_audit
	(audit_e_id, audit_score, audit_user, audit_date)
VALUES (100, 99, NULL, NULL);

SELECT '';
SELECT ROW_COUNT() AS 'INSERT: rows affected. Negative testing so see DSA04Task3.err';

SELECT '';
SELECT '' AS 'Task 2, Q3. SWE Exercise 4 [1 point]';

INSERT INTO project_skill (p_id, skill_id)
VALUES (1, NULL);

SELECT ROW_COUNT() AS 'INSERT: rows affected. Negative testing so see DSA04Task3.err';


SELECT '';
SELECT '' AS 'Task 2, Q3. SWE Exercise 5 [2 points]';

DELETE FROM consultant
WHERE c_id = 103;

SELECT ROW_COUNT() AS 'DELETE: rows affected. Negative testing so see DSA04Task3.err';

