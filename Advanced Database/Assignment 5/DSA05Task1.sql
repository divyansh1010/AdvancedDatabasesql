-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\db_setup\create_my_guitar_shop.sql
-- mysql -u root -p < C:\mysql\DSA05Task1.sql > C:\mysql\DSA05Task1.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP 3002: Section 2';
SELECT '' AS 'Assignment 5: Task 1';

SELECT SYSDATE() AS 'Current System Date';
USE my_guitar_shop;

SELECT '';
SELECT '' AS 'Task 1, Q1. MGS Exercise 9-1 [5 points] ';

SELECT FORMAT(list_price, 2) AS price_format,
	CAST(discount_percent AS SIGNED) AS discount_cast,
	ROUND(list_price * (discount_percent / 100), 2) AS discount_amount,
	RIGHT(CAST(date_added AS DATE), 5) AS month_day_added
FROM products;

SELECT '';
SELECT '' AS 'Task 1, Q2. MGS Exercise 9-2 [5 points]';

SELECT order_date,
	DATE_FORMAT(order_date, "%Y") AS order_year,
	DATE_FORMAT(order_date, "%b-%d-%Y") AS order_date_formatted,
	DATE_FORMAT(order_date, "%l:%i %p") AS order_time,
	DATE_FORMAT(order_date, "%m/%d/%y %H:%i") AS order_datetime
FROM orders;

SELECT '';
SELECT '' AS 'Task 1, Q3. MGS Exercise 9-3 [5 points]';

SELECT card_number,
	LENGTH(card_number) AS card_number_length,
	RIGHT(card_number, 4) AS last_four_digits,
	LPAD(RIGHT(card_number, 4), 19, "XXXX-") AS formatted_number
FROM orders;

SELECT '';
SELECT '' AS 'Task 1, Q4. MGS Exercise 9-4 [5 points]';

SELECT order_id,
	order_date,
	DATE_ADD(order_date, INTERVAL 2 DAY) AS est_ship_date,
	IFNULL(ship_date, 'Not Shipped') AS ship_date,
	DATEDIFF(ship_date, order_date) AS days_to_ship
FROM orders
WHERE order_date >= '2012-04-01' AND order_date < '2014-05-01';