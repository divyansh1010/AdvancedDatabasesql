SELECT '';
SELECT '' AS '*** Question E1 [6 Marks] ***';
CREATE USER 'ray'@'localhost' IDENTIFIED BY 'temp';
GRANT ALL PRIVILEGES ON AP.* TO 'ray'@'localhost' WITH GRANT OPTION;
CREATE USER 'ray'@'%' IDENTIFIED BY 'temp';
GRANT ALL PRIVILEGES ON AP.* TO 'ray'@'%' WITH GRANT OPTION;

CREATE USER 'ray'@'localhost' IDENTIFIED BY 'temp';
GRANT SELECT, DELETE, UPDATE ON invoices.* TO 'ray'@'localhost' WITH GRANT OPTION;

CREATE USER 'ray'@'localhost' IDENTIFIED BY 'temp';
GRANT SELECT, INSERT ON invoices.* TO 'ray'@'localhost' WITH GRANT OPTION;