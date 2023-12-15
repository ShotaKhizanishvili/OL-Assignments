CREATE DATABASE Library;
GO

USE Library;
GO

CREATE TABLE Authors (
    AuthorId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Age INT
);

CREATE TABLE Books (
    BookId INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    AuthorId INT,
    YearPublished INT,
    FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)
);

CREATE TABLE Members (
    MemberId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    MembershipDate DATE
);

SELECT * FROM Books
WHERE YearPublished > '2000-01-01';

SELECT A.AuthorId, A.Name, COUNT(B.BookId) AS BookCount
FROM Authors A
JOIN Books B ON A.AuthorId = B.AuthorId
GROUP BY A.AuthorId, A.Name
HAVING COUNT(B.BookId) > 3;

INSERT INTO Members(Name,MembershipDate)
VALUES
	('name1','2001-01-01'),
	('name2','2002-02-02'),
	('name3','2003-03-03'),
	('name4','2004-04-04'),
	('name5','2005-05-05')
;

INSERT INTO Authors(Name,Age)
VALUES
	('name1',18),
	('name2',19),
	('name3',20),
	('name4',21),
	('name5',22)
;

INSERT INTO Books(Title,AuthorId,YearPublished)
VALUES
	('bookname1',1,2001),
	('bookname2',1,2002),
	('bookname3',2,2003),
	('bookname4',3,2004),
	('bookname5',5,2005)
;

UPDATE Authors
SET Age = 41
WHERE Age = 20;

DELETE FROM Books
WHERE BookId = 2;

SELECT * FROM Authors
ORDER BY Name;

SELECT * FROM Books
WHERE YearPublished BETWEEN 1990 AND 2003;

SELECT BookId,Title,YearPublished,COUNT(AuthorId) as BookCount FROM Books
GROUP BY BookId,Title,YearPublished;
