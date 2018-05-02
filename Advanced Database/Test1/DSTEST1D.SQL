-- cd C:\xampp\mysql\bin
-- mysql -u root -p < C:\mysql\db_setup\create_databases.sql
-- mysql -u root -p < C:\mysql\db_setup\create_my_guitar_shop.sql
-- mysql -u root -p < C:\mysql\db_setup\swexpert.sql
-- mysql -u root -p < C:\mysql\DSTest1D.sql > C:\mysql\DSTest1D.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP3002: Section 02';
SELECT '' AS 'Midterm Version D';

SELECT SYSDATE() AS 'Current System Date';

	
    
SELECT '';
SELECT '' AS '*** Question A1 [1 Point] ***';

USE swexpert;



SELECT '';
SELECT '' AS '*** Question A2 [2 Points] ***';
INSERT INTO client (client_id, client_name, contact_first, contact_last)
VALUES(605, 'Communitech', 'Divyansh', 'Sharma');

SELECT ROW_COUNT();


SELECT '';
SELECT '' AS '*** Question A3 [5 Points] ***';

	SELECT * FROM client;
    SELECT * FROM consultant;

SELECT '';
SELECT '' AS '*** Question A4 [4 Points] ***';

SELECT c_first, c_last, p_id,  project_name FROM consultant  JOIN project
 WHERE parent_p_id IS NULL;
	
SELECT '';
SELECT '' AS '*** Question A5 [5 Points] ***';


SELECT DATE_FORMAT(c.roll_on_date, '%m-%Y') AS 'mm-yyyy', DATE_FORMAT(c.roll_off_date, '%m-%Y') AS 'mm-yyyy', p.p_id, p.project_name, ct.c_id, ct.c_last
FROM project_consultant AS c, project AS p, consultant AS ct
WHERE roll_off_date BETWEEN '2011-01-01' AND '2011-10-31'; 
SELECT ROW_COUNT();


SELECT '';
SELECT '' AS '*** Question A6 [1 Point] ***';

DELETE FROM client
WHERE client_id = 605;
SELECT ROW_COUNT();

SELECT '';
SELECT '' AS '*** Question B1 [1 Point]***';
USE my_guitar_shop;


SET SQL_SAFE_UPDATES = 0;
SELECT '';
SELECT '' AS '*** Question B2 [4 Points] ***';

SELECT order_id, ship_amount, card_type, card_number, card_expires FROM orders
WHERE ship_address_id = billing_address_id
ORDER BY card_type;
SELECT ROW_COUNT();

SELECT '';
SELECT '' AS '***  Question B3 [2 Points] ***';
SELECT product_id, product_name, description FROM products
WHERE description LIKE '%bass%';

SELECT ROW_COUNT();
SELECT '';
SELECT '' AS '*** Question B4 [3 Points] ***';

INSERT INTO administrators (admin_id, email_address, password, first_name, last_name)
VALUES (100, 'barryz@gmail.com', '','Divyansh', 'Sharma');
SELECT ROW_COUNT();




SELECT '';
SELECT '' AS '*** Question B5 [3 Points] ***';  

UPDATE administrators
SET first_name = 'Barry', last_name = 'Zimmer', password = 'password1'
WHERE email_address = 'barryz@gmail.com';
SELECT ROW_COUNT();



SELECT '';
SELECT '' AS '*** Question B6 [1 Point] ***';

SELECT * FROM administrators
WHERE admin_id = 100;
SELECT ROW_COUNT();



SELECT '';
SELECT '' AS '*** Question B7 [4 Points] ***';

SELECT CONCAT(administrators.first_name, "," ,administrators.last_name) AS FULL_NAME, administrators.email_address AS EMAIL_ADDRESS, SUBSTRING(customers.password, 1,5) AS ADMIN_PWD, SUBSTRING(administrators.password, 1,5) AS CUSTOMER_PWD
FROM customers JOIN administrators
WHERE customers.email_address =administrators.email_address;
SELECT ROW_COUNT();





SELECT '';
SELECT '' AS '*** Question B8 [1 Point] ***';

DELETE FROM administrators
WHERE admin_id =100;

SELECT ROW_COUNT();

SELECT '';
SELECT '' AS '*** Question C1 [1 Point] ***';

USE ap;

SELECT '' AS '*** Question C2 [2 Points] ***';


SELECT * FROM general_ledger_accounts
WHERE account_description= 'Accounting';
SELECT ROW_COUNT();

SELECT '';
SELECT '' AS '*** Question C3 [3 Point] ***';

SELECT vendor_id, vendor_name  FROM vendors
WHERE vendor_phone IS NULL
ORDER BY vendor_name ASC;
SELECT ROW_COUNT();


SELECT '';
SELECT '' AS '*** Question C4 [4 Points] ***';


SELECT c1.vendor_id, c1.last_name, c1.first_name 
FROM vendor_contacts AS c1
JOIN vendor_contacts AS c2 ON
c1.vendor_id = c2.vendor_id
WHERE c1.last_name = 'M%';
SELECT ROW_COUNT();
					
SELECT '';
SELECT '' AS '***  Question C5 [3 Points] ***';

SELECT invoice_number, invoice_total, payment_total, credit_total FROM invoices
WHERE payment_total BETWEEN '2000' AND '3000';
SELECT ROW_COUNT();	

