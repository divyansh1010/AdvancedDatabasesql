-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\mgs_ex_starts\create_my_guitar_shop.sql
-- mysql -u root -p < C:\mysql\DSA02Task1.sql > C:\mysql\DSA02Task1.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'PROG2220: Section 2';
SELECT '' AS 'Assignment 2: Task 1';

SELECT SYSDATE() AS 'Current System Date';

USE my_guitar_shop;


-- Q1 --
SELECT '' AS '*** Task 1, Q1.  MGS Exercise 4-1 [5 points]';
SELECT category_name, product_name, list_price FROM categories JOIN products
ON categories.category_id = products.category_id
ORDER BY category_name, product_name ASC;

-- Q2 --
SELECT '' AS '*** Task 1, Q2.  MGS Exercise 4-2 [5 points]';
SELECT first_name, last_name, line1, city, zip_code
FROM customers JOIN addresses
ON customers.customer_id = addresses.customer_id
WHERE customers.email_address = 'allan.sherwood@yahoo.com';

-- Q3 --
SELECT '' AS '*** Task 1, Q3.  MGS Exercise 4-4 [5 points]';
SELECT c.last_name, c.first_name, o.order_date, p.product_name, i.item_price, i.discount_amount, i.quantity
FROM customers AS c, orders AS o, order_items AS i, products AS p
WHERE c.customer_id = o.customer_id
AND p.product_id = i.product_id
ORDER BY c.last_name, o.order_date, p.product_name;
-- Q4 --
SELECT '' AS '*** Task 1, Q4.  MGS Exercise 4-5 [5 points]';
SELECT p1.product_id,
p1.product_name,
p1.list_price
FROM products AS p1
JOIN products AS p2 ON
p1.product_id<> p2.product_id
AND
p1.list_price = p2.list_price
ORDER BY p1.product_name;
-- Q5 --
SELECT '' AS '*** Task 1, Q5.  MGS Exercise 4-7 [5 points]';
SELECT 'NOT SHIPPED' AS ship_status, order_id, order_date
FROM orders
WHERE ship_date IS NULL
UNION
SELECT 'SHIPPED' AS ship_status, order_id, order_date
FROM orders
WHERE ship_date IS NOT NULL;