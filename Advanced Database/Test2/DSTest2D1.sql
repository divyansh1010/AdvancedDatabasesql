SELECT '';
SELECT '' AS '*** Question D1 [6 Marks] ***';

USE AP;

DROP PROCEDURE IF EXISTS insert_glacount;

DELIMITER //

CREATE PROCEDURE insert_glacount()
BEGIN
    DECLARE factor10 INT;
    DECLARE factor20 INT;
    DECLARE counter INT;
    DECLARE result VARCHAR(50);

    SET factor10 = 10;
    SET factor20 = 20;
    SET counter = 1;
    SET result = 'Common factors are';

    WHILE (counter <= factor10/2) DO

        IF (factor10 % counter = 0 AND factor20 % counter = 0) THEN
            SET result = CONCAT(result, counter, ' ');
        END IF;

       SET counter = counter+1;
    END WHILE;

    SELECT result AS message;
END //

DELIMITER ;

CALL insert_glacount();