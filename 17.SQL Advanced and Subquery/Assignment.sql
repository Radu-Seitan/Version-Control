CREATE TABLE BooksForSale
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR(100) NOT NULL,
	DateOfPublishing DATE CHECK (DateOfPublishing < GetDate()),
	Price INT
)

CREATE TABLE GreatBooks
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR(100) NOT NULL,
	DateOfPublishing DATE CHECK (DateOfPublishing < GetDate())
)


INSERT INTO GreatBooks (Title, DateOfPublishing) VALUES 
	('A Game of Thrones', '08/01/1996'),
	('A Clash of Kings', '04/02/1999'),
	('Lord of the Rings', '08/01/1996'),
	('A Storm of Swords', '08/08/2000'),
	('A Feast for Crows', '01/01/2005'),
	('A Dance with Dragons', '07/12/2011')

--INSERT SELECT
SET IDENTITY_INSERT BooksForSale ON
INSERT INTO BooksForSale (Id, Title, DateOfPublishing)

(SELECT Id, Title, DateOfPublishing 
FROM GreatBooks)

SELECT * FROM BooksForSale

--UPDATE BASED ON JOIN

UPDATE B 
	SET B.Price = B.Id * 10.75
FROM GreatBooks AS GB
	FULL OUTER JOIN BooksForSale AS B
		ON B.ID = GB.Id

SELECT * FROM BooksForSale

--DELETE BASED ON JOIN
SET IDENTITY_INSERT BooksForSale Off
INSERT INTO BooksForSale (Title, DateOfPublishing, Price)
VALUES ('Pas cu pas', '12/01/2014', 30)

DELETE FROM BooksForSale
WHERE Id in (
	SELECT BooksForSale.Id
	FROM BooksForSale
	LEFT JOIN GreatBooks
	ON BooksForSale.Id = GreatBooks.Id
	WHERE GreatBooks.Id IS NULL
)


SELECT * FROM BooksForSale

--CORRELATED SUBQUERY IN WHERE
SELECT Title, Price 

FROM BooksForSale 
WHERE Price > (
	SELECT SUM(Price / Id - 1)
	FROM BooksForSale
)

--QUERIES WITH NOT IN
INSERT INTO BooksForSale (Title, DateOfPublishing, Price)
VALUES ('Pas cu pas', '12/01/2014', 30)

SELECT * FROM BooksForSale

SELECT * FROM BooksForSale WHERE Id NOT IN (SELECT Id FROM GreatBooks);

--GROUPING QUERIES WITH HAVING
SELECT AVG(Price) AS AveragePrice, YEAR(DateOfPublishing) AS Year
FROM BooksForSale
GROUP BY YEAR(DateOfPublishing)
 
 --CASE
 SELECT Id,Title,DateOfPublishing,

 CASE 1 + (year(DateOfPublishing) - 1) / 100

 WHEN 20 THEN Price * 0.8
 WHEN 21 THEN Price * 1.2 ELSE Price

 END AS 'Price'
 
 FROM BooksForSale

--TRUNCATE

TRUNCATE TABLE BooksForSale

