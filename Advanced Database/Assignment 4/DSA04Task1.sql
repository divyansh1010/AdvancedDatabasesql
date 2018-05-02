-- mysql -u root -p < C:\mysql\db_setup\create_my_guitar_shop.sql --
-- mysql -u root -p < C:\mysql\DSA04Task1.sql > C:\mysql\DSA04Task1.out --
SELECT '' AS 'Divyansh Sharma';

SELECT '' AS 'COMP 3002 Section 2';

SELECT '' AS 'Assignment 4: Task 1';



SELECT SYSDATE() AS 'Current System Date';



USE my_guitar_shop;



SELECT '';
SELECT '' AS 'Task 1, Q1. MGS Exercise 6-1 [3 points]';
SELECT COUNT(*) AS order_count,
SUM(tax_amount) as tax_total
FROM orders;


SELECT '';
SELECT '' AS 'Task 1, Q2. MGS Exercise 6-2 [4 points] ';
SELECT category_name, 
MAX(list_price) AS most_expensive_product,
COUNT(*) AS product_count
FROM categories  JOIN products 
ON categories.category_id = products.category_id
GROUP BY category_name
ORDER BY product_count DESC;



SELECT '';
SELECT '' AS ' Task 1, Q3. MGS Exercise 6-6 [3 points] ';
SELECT product_name,
SUM((list_price - discount_amount) * quantity) AS product_total
FROM order_items o JOIN products p
ON o.product_id = p.product_id
GROUP BY product_name WITH ROLLUP;

SELECT '';
SELECT '' AS 'Task 1, Q4. MGS Exercise 7-3 [3 points]';
SELECT category_name
FROM categories 
WHERE NOT EXISTS 
(SELECT *
FROM products 
WHERE categories.category_id = products.category_id);
