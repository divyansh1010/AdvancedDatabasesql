-- If MySQL is not started, run Services and run MySQL57 service

-- cd "C:\Program Files\MySQL\MySQL Server 5.7\bin"
-- mysql -u root -p < C:\mysql\db_setup\create_databases.sql
-- mysql -u root -p < C:\mysql\DSA03Task1.sql > C:\mysql\DSA03Task1.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP 3002: Section 1';
SELECT '' AS 'Assignment 3: Task 1';

SELECT SYSDATE() AS 'Current System Date';

USE ap;
SET FOREIGN_KEY_CHECKS=0;

-- Q1 --
SELECT '' AS '*** Task 1, Q1.  Exercise 5-04 [2 points]';
INSERT INTO invoices (invoice_id  , vendor_id , invoice_number, invoice_date, invoice_total , payment_total, credit_total, terms_id, invoice_due_date, payment_date)  
VALUES(115 , 32, 'AX-014-027', '2014-08-01', '434.58','0.0', '0.00', 2, '2014-08-31', NULL);
SELECT ROW_COUNT();

-- Q2 --
SELECT '' AS '*** Task 1, Q2.  Exercise 5-05 [2 points]';
INSERT INTO invoice_line_items (invoice_id, invoice_sequence, account_number, line_item_amount, line_item_description)
VALUES (115,1, 160,'180.23', 'Hard drive'),
	(116,2, 527, '254.35', 'Exchange Server Update');
   SELECT ROW_COUNT(); 
-- Q3 --
SELECT '' AS '*** Task 1, Q3.  Exercise 5-06 [2 points]';
UPDATE invoices
SET credit_total = 0.1 * (invoice_total), payment_total = invoice_total - credit_total
WHERE vendor_id = 32;
SELECT ROW_COUNT();
-- Q4 --
SELECT '' AS '*** Task 1, Q4.  Exercise 5-09 [4 points]';
DELETE FROM invoices
WHERE invoice_id = 115;
SELECT ROW_COUNT();

DELETE FROM invoice_line_items 
WHERE invoice_sequence = 1 AND invoice_sequence = 2;
SELECT ROW_COUNT();