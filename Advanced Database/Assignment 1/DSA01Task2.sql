-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\mgs_ex_starts\create_my_guitar_shop.sql
-- mysql -u root -p < C:\mysql\DSA01Task2.sql > C:\mysql\DSA01Task2.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'PROG2220: Section 2';
SELECT '' AS 'Assignment 1: Task 2';

SELECT SYSDATE() AS 'Current System Date';

USE my_guitar_shop;


-- Q1 --
SELECT '' AS '*** Task 2, Q1. MGS Exercise 3-01';

SELECT product_code, product_name, list_price, discount_percent
FROM products
ORDER BY list_price DESC;

SELECT '' AS '*** Task 2, Q2. MGS Exercise 3-03';

SELECT product_name, list_price, date_added
FROM products
WHERE list_price > 500 AND list_price < 2000
ORDER BY date_added DESC;

SELECT '' AS '*** Task 2, Q3. MGS Exercise 3-05';
SELECT item_id, item_price, discount_amount, item_price * quantity AS 'price_total',
 discount_amount * quantity AS 'discount_total', 
(item_price - discount_amount) * quantity AS 'item_total'
FROM order_items
WHERE (item_price - discount_amount) * quantity > 500
ORDER BY (item_price - discount_amount) * quantity DESC;

SELECT '' AS '*** Task 2, Q4. MGS Exercise 3-06';
SELECT order_id, order_date, ship_date FROM orders
WHERE ship_date IS NULL;

SELECT '' AS '*** Task 2, Q5. MGS Exercise 3-08';
SELECT 100 AS Price , 0.07 AS tax_rate, (100 * 0.07) AS tax_amount, (100) + (100 * 0.07) AS total;

