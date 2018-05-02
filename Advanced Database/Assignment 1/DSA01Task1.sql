-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\db_setup\create_databases.sql
-- mysql -u root -p < C:\mysql\DSA01Task1.sql > C:\mysql\DSA01Task1.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'PROG2220: Section 2';
SELECT '' AS 'Assignment 1: Task 1';

SELECT SYSDATE() AS 'Current System Date';

USE ap;


-- Q1 --
SELECT '' AS '*** Task 1, Q1. Textbook Exercise 3-06';
SELECT vendor_name, vendor_contact_last_name, vendor_contact_first_name 
FROM vendors
ORDER BY vendor_contact_last_name , vendor_contact_first_name ASC  
LIMIT 10;


-- Q2 --
SELECT '' AS '*** Task 1, Q2. Textbook Exercise 3-07';
SELECT CONCAT(vendor_contact_last_name,", " ,vendor_contact_first_name) AS Full_name 
FROM vendors
WHERE vendor_contact_last_name LIKE 'A%'
OR vendor_contact_last_name LIKE 'B%'
OR vendor_contact_last_name LIKE 'C%'
OR vendor_contact_last_name LIKE 'E%'
ORDER BY vendor_contact_last_name, vendor_contact_first_name;

-- Q3--
SELECT '' AS '*** Task 1, Q3. Textbook Exercise 3-08';

SELECT invoice_due_date AS 'Due Date' ,invoice_total 'Invoice Total' ,invoice_total / 10 AS '10%' ,invoice_total * 1.1 AS 'Plus 10%'
FROM invoices WHERE invoice_total >= 500 AND invoice_total <= 1000 ORDER BY invoice_due_date DESC;

-- Q4 --
SELECT '' AS '*** Task 1, Q4. Textbook Exercise 3-09';
SELECT invoice_number AS 'invoice_number', invoice_total AS 'invoice_total', payment_total + credit_total AS 'payment_credit_total', invoice_total - (payment_total + credit_total) AS 'balance_due'
FROM invoices WHERE invoice_total - (payment_total + credit_total) > 50 ORDER BY balance_due DESC
LIMIT 5 ;

-- Q5 --
SELECT '' AS '*** Task 1, Q5. Textbook Exercise 3-10';

SELECT invoice_number AS 'invoice_number', invoice_date AS 'invoice_date', invoice_total - (payment_total + credit_total) AS 'balance_due', payment_date AS 'payment-date'
FROM invoices WHERE payment_date IS NULL ;

-- Q6 --
SELECT '' AS '*** Task 1, Q6. Textbook Exercise 3-011';

SELECT CURRENT_DATE, DATE_FORMAT(CURRENT_DATE, '%m-%d-%Y') AS 'mm-dd-yyyy';

-- Q7 --

SELECT '' AS '*** Task 1, Q7. Textbook Exercise 3-012';

SELECT 50000 AS starting_principle, (0.065 * 50000) AS interest, 50000 + (0.065 * 50000) AS principle_plus_interest
;

SELECT * FROM vendors;
SELECT * FROM invoices;