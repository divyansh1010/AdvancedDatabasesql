USE swexpert;
-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\MySQL\swexpert\swexpert.sql
-- mysql -u root -p < C:\mysql\DSA03Task3.sql > C:\mysql\DSA03Task3.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP 3002: Section 2';
SELECT '' AS 'Assignment 3: Task 3';

SELECT SYSDATE() AS 'Current System Date';

USE swexpert;
SET FOREIGN_KEY_CHECKS=0;

-- Q1 --
SELECT '' AS '*** Task 3, Q1.   SWE Exercise 1 [2 points]';
INSERT INTO consultant (c_id, c_last, c_first, c_mi, c_add, c_city, c_state, c_zip, c_phone, c_email)
VALUES(106,'Sharma', 'Divyansh', 'Shekhar', '25 Oaklea Boulevard', 'Brampton', 'Onatario', 'L4K3H9','4325534738','div121@gmail.com');
SELECT ROW_COUNT();
-- Q2 --
SELECT '' AS '*** Task 3, Q2.   SWE Exercise 2 [2 points]';
INSERT INTO client (client_id, client_name, contact_last, contact_first, contact_phone)
VALUES(17, 'City of Barrie', 'Jaworsky', 'Dave', '7058861550');
SELECT ROW_COUNT();
-- Q3 --
SELECT '' AS '*** Task 3, Q3.   SWE Exercise 3 [3 points]';
INSERT INTO project (p_id, project_name, parent_p_id)
VALUES(88, 'ION Rapid Transit', NULL);
SELECT ROW_COUNT();
-- Q4 --
SELECT '' AS '*** Task 3, Q4.   SWE Exercise 4 [3 points]';
Update project
SET project_name = 'New Project'
WHERE parent_p_id = NULL;
Update project
SET parent_p_id = 0
WHERE p_id = 88;
SELECT ROW_COUNT();