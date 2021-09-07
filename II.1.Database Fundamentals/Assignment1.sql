CREATE TABLE Books
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Title VARCHAR(100) NOT NULL,
	DateOfPublishing DATE CHECK (DateOfPublishing < GetDate())
)

CREATE TABLE Authors
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL
)

CREATE TABLE AuthorBook
(
	AuthorId INT,
	BookId INT
	CONSTRAINT PK_Book_Author1 PRIMARY KEY(AuthorId, BookId),
	CONSTRAINT FK_Book1
		FOREIGN KEY (BookId) REFERENCES Books (ID)
			ON UPDATE CASCADE
			ON DELETE CASCADE,
	CONSTRAINT FK_Author1
		FOREIGN KEY (AuthorId) REFERENCES Authors (Id)
			ON UPDATE CASCADE
			ON DELETE CASCADE
)

INSERT INTO Books (Title, DateOfPublishing) VALUES 
	('A Game of Thrones', '08/01/1996'),
	('A Clash of Kings', '04/02/1999')
INSERT INTO Books (Title, DateOfPublishing) VALUES 
	('Lord of the Rings', '08/01/1996')

SELECT * FROM Books

INSERT INTO Authors (Name) VALUES
	('George R.R. Martin'),
	('J.R.R. Tolkien'),
	('Klaus Iohannis')

SELECT * FROM Authors

INSERT INTO AuthorBook VALUES 
	(1,1),
	(1,2),
	(2,2)
	
SELECT * FROM AuthorBook


