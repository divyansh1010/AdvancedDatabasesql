
-- mysql -u root -p < C:\mysql\db_setup\school.sql
-- mysql -u root -p < C:\mysql\DSPTask1.sql > C:\mysql\DSPTask1.out

SELECT '' AS 'Divyansh Sharma';
SELECT '' AS 'COMP 3002: Section 1';
SELECT '' AS 'Project: Task 1';
SET SQL_SAFE_UPDATES = 0;
SELECT SYSDATE() AS 'Current System Date';

SELECT '' AS ' Task 1, P1. [3 points]';
SHOW DATABASES ;
USE mysql;
SHOW TABLES;

SELECT '' AS ' Task 1, P2. [3 points]';
DROP DATABASE IF EXISTS school;
CREATE DATABASE school;
USE school;

SELECT '' AS ' Task 1, P3. [8 points]';
CREATE TABLE student
(
StudentId INT NOT NULL AUTO_INCREMENT, 
  FirstName                     VARCHAR(50)    NOT NULL      ,
  LastName                      VARCHAR(50)    NOT NULL ,
  Email                         VARCHAR(255)   NOT NULL      UNIQUE,
  CellPhone                     VARCHAR(12)    NOT NULL,
  Major                         VARCHAR(50) ,
  GPA                           DOUBLE,
  StartDate                     Date,
   PRIMARY KEY(StudentId)
);
SELECT '' AS ' Task 1, P4. [2 points]';
DESCRIBE student;

SELECT '' AS ' Task 1, P5. [9 points]';
INSERT INTO school.student values (1,'John','Doe','johndoe@smiley.edu','408-333-3456','CIS',2.8,'2004-09-22');
INSERT INTO school.student values (2,'Mary','Chin','mchin@qmail.com','408-204-1234','Biology',3.3,'2003-06-22');
INSERT INTO school.student values (3,'Sadish', 'Pamel', 'sadi@univ_ab.edu', '415-204-1234', 'CIS', 3.9 ,' 2003-06-22');


SELECT '' AS ' Task 1, P6. [2 points]';
SHOW COLUMNS FROM student;
SHOW INDEXES in student;
SHOW FIELDS IN student;


SELECT '' AS ' Task 1, P7. [6 points]';
SELECT * FROM student;
SELECT FirstName, LastName FROM student;
SELECT FirstName, LastName, major FROM student;
SELECT CellPhone, Email FROM student;
SELECT DISTINCT major FROM student;
SELECT * FROM student
ORDER BY RAND()
LIMIT 2;

SELECT '' AS ' Task 1, P8. [6 points]';
SELECT * FROM student
WHERE GPA > 3.0;
SELECT * FROM student
WHERE GPA > 3.0 AND GPA < 4.0;
SELECT * FROM student
WHERE CellPhone LIKE '408%';
SELECT * FROM student
WHERE StartDate LIKE '2003%';
SELECT FirstName, LastName FROM student
WHERE major = 'CIS' AND GPA > 3.5;
SELECT FirstName, Email FROM student
WHERE Email LIKE '%.com';

SELECT '' AS ' Task 1, P9. [6 points]';
INSERT INTO school.student VALUES
(4,'Divyansh', 'Sharma', 'divyansh123@gmail.com', '437-825-9564', 'Chemistry', 3.8 ,' 2016-09-22');
SELECT * FROM student
WHERE FirstName = 'Divyansh';
SELECT * FROM student ORDER BY LastName ASC, LastName DESC;
SELECT * FROM student ORDER BY GPA DESC;

SELECT '' AS ' Task 1, P10. [2 points]';
UPDATE student
SET CellPhone = '650-123-4563'
WHERE FirstName = 'Mary';

SELECT '' AS ' Task 1, P11. [3 points]';
SELECT SYSDATE() AS 'Current System Date';
SELECT COUNT(*) AS 'INSERT: rows affected' FROM student;
SELECT AVG(GPA) AS 'Average GPA of all students'
FROM student;