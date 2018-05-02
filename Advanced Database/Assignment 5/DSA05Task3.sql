-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\db_setup\create_my_guitar_shop.sql
-- mysql -u root -p < C:\mysql\DSA05Task3.sql > C:\mysql\DSA05Task3.out
SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP 3002: Section 2';
SELECT '' AS 'Assignment 5: Task 3';

SELECT SYSDATE() AS 'Current System Date';
USE my_guitar_shop;

SELECT '';
SELECT '' AS 'Task 3, Q1. MGS Exercise 12-3 [5 points]';

CREATE OR REPLACE VIEW order_item_products AS
	SELECT o.order_id, order_date, tax_amount, ship_date,
		item_price, discount_amount, 
		item_price - discount_amount AS final_price,
		quantity,
		(item_price - discount_amount) * quantity AS item_total,
		product_name
	FROM orders o 
		JOIN order_items i
			ON o.order_id = i.order_id
		JOIN products p
			ON i.product_id = p.product_id;

SELECT '';
SELECT '' AS 'Task 3, Q2. MGS Exercise 12-4 [3 points]';

SELECT order_id, product_name, item_total
FROM order_item_products
ORDER BY item_total DESC, order_id;

SELECT '';
SELECT '' AS 'Task 3, Q3. MGS Exercise 12-5 [4 points]';

CREATE OR REPLACE VIEW product_summary AS
	SELECT product_name,
		COUNT(product_name) AS order_count,
		SUM(item_total) AS order_total
	FROM order_item_products
	GROUP BY product_name;

SELECT '';
SELECT '' AS 'Task 3, Q4. MGS Exercise 12-6 [3 points]';

SELECT product_name, order_total
FROM product_summary
ORDER BY order_total DESC
LIMIT 5;