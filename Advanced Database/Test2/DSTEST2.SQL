-- cd C:\xampp\mysql\bin
-- mysql -u root -p < C:\mysql\db_setup\create_my_guitar_shop.sql
-- mysql -u root -p < C:\mysql\db_setup\swexpert.sql
-- mysql -u root -p --force < C:\mysql\DSTest2.sql 1> C:\mysql\DSTest2.out 2> C:\mysql\DSTest2.err

SELECT '' AS 'your name';
SELECT '' AS 'COMP3002: Section 02';
SELECT '' AS 'Test 2';

SELECT NOW() AS 'Current System Date and Time';


SELECT '';
SELECT '' AS '*** Question A1 [1 Mark] ***';

USE my_guitar_shop;

SELECT '';
SELECT '' AS '*** Question A2 [2 Marks] ***';

SELECT order_id, order_date FROM orders
WHERE order_date > ' 14:00:00';

SELECT '';
SELECT '' AS '*** Question A3 [5 Marks] ***';

SELECT ROUND(AVG(orders.ship_amount)) AS 'Average Shipping Amount', c.customer_id, last_name, COUNT(order_id) AS 'Sales Orders'
FROM customers c JOIN orders
	ON c.customer_id = orders.customer_id
    WHERE orders.ship_amount > '5';


SELECT '';
SELECT '' AS '*** Question A4 [4 Marks] ***';

SELECT DISTINCT c.email_address, a.email_address
FROM customers c JOIN administrators a
	ON c.customer_id = a.admin_id
WHERE EXISTS 
(SELECT 1
FROM customers c JOIN administrators a 
ON c.customer_id = a.admin_id
WHERE c.customer_id  IS NULL);
	
SELECT '';
SELECT '' AS '*** Question A5 [4 Marks] ***';

CREATE VIEW all_email_address
AS SELECT customers.email_address
FROM customers;

SELECT '';
SELECT '' AS '*** Question A6 [3 Marks] ***';



SELECT '';
SELECT '' AS '*** Question A7 [1 Mark] ***';
	
DROP VIEW all_email_address;

SELECT '';
SELECT '' AS '*** Question B1 [1 Mark] ***';

USE swexpert;

SELECT '';
SELECT '' AS '*** Question B2 [2 Marks] ***';
SELECT * 
FROM skill 
WHERE skill_description IS NOT NULL;


SELECT '';
SELECT '' AS '*** Question B3 [3 Marks] ***';

INSERT INTO skill (skill_id, skill_description)
VALUES (88, NULL);



SELECT ROW_COUNT() AS 'INSERT: rows affected. Negative testing so see DSTest4.err';

SELECT '';
SELECT '' AS '*** Question B4 [1 Mark] ***';
	
INSERT INTO skill (skill_id, skill_description)
VALUES (99, 'Mobile App Dev');
SELECT ROW_COUNT() AS 'INSERT: rows affected';

SELECT '';
SELECT '' AS '*** Question B5 [2 Marks] ***';

SELECT * FROM skill;
SELECT
    skill_description, (CONCAT( skill_id), 100) FROM skill;
    

SELECT '';
SELECT '' AS '*** Question B6 [4 Marks] ***';



SELECT '';
SELECT '' AS '*** Question B7 [2 Marks] ***';

DELETE FROM skill
WHERE skill_id = 7 AND skill_id = 9;

SELECT ROW_COUNT() AS 'DELETE: rows affected. Negative testing so see DSTest2.err';

SELECT '';
SELECT '' AS '*** Question C1 [1 Mark] ***';
DROP DATABASE IF EXISTS my_db;
Create DATABASE my_db;

SELECT '';
SELECT '' AS '*** Question C2 [1 Mark] ***';
USE my_db;


SELECT '';
SELECT '' AS '*** Question C3 [4 Marks] ***';

CREATE TABLE my_events (
  e_id           INT            PRIMARY KEY   AUTO_INCREMENT,
  
  
  e_date      DATE,
  description          VARCHAR(30)   NOT NULL
);

SELECT '';
SELECT '' AS '*** Question C4 [3 Marks] ***';
INSERT INTO my_events (e_id, e_date, description) VALUES
(1, '2018-03-31', 'Job offer'),
(2, '2018-04-25', 'Final Exam Completed');



SELECT '';
SELECT '' AS '*** Question C5 [4 Marks] ***';

SELECT * FROM my_events;
ALTER TABLE my_events
ADD num_days INT NOT NULL;
SELECT * FROM my_events;

SELECT '';
SELECT '' AS '*** Question C6 [1 Mark] ***';

DROP table my_events;

SELECT '';
SELECT '' AS '*** Question C7 [1 Mark] ***';  

DROP DATABASE my_db;
