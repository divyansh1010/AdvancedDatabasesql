USE my_guitar_shop;

-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\mgs_ex_starts\create_my_guitar_shop.sql
-- mysql -u root -p < C:\mysql\DSA03Task2.sql > C:\mysql\DSA03Task2.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP 3002: Section 2';
SELECT '' AS 'Assignment 2: Task 2';

SELECT SYSDATE() AS 'Current System Date';

USE my_guitar_shop;


-- Q1 --
SELECT '' AS '*** Task 2, Q1.  MGS Exercise 5-1 [8 points]';
INSERT INTO categories (category_name)
VALUE
('Wind');
SELECT ROW_COUNT();

UPDATE categories
SET category_name = 'String'
WHERE category_id = 5;
SELECT ROW_COUNT();

DELETE FROM categories
WHERE category_id = 5;
SELECT ROW_COUNT();
-- Q2 --
SELECT '' AS '*** Task 2, Q2.  MGS Exercise 5-4 [8 points]';
INSERT INTO products (product_id, category_id, product_code, product_name, description, list_price, discount_percent ,date_added) 
VALUES(product_id, 4,'dgx_640','Yamaha DGX 640 Digital Piano','This is the Yamaha DGX 640 Digital Piano with 88 keys.',845.95,10,SYSDATE());
SELECT ROW_COUNT();
-- Q3 --
SELECT '' AS '*** Task 2, Q2.  MGS Exercise 5-7 [6 points]';
INSERT INTO customers (email_address, password, first_name, last_name)
VALUES('divyanshsharma@georgianc.on.ca', '', 'Divyansh', 'Sharma');
SELECT ROW_COUNT();

UPDATE customers
SET password = 's3cr3t'
WHERE email_address = 'divyanshsharma@georgianc.on.ca';
SELECT ROW_COUNT();