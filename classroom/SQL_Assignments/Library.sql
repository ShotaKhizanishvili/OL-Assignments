CREATE DATABASE Library;
GO

USE Library;
GO

CREATE TABLE Authors (
    AuthorId INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Age INT
);

CREATE TABLE Books (
    BookId INT PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    AuthorId INT,
    YearPublished DATE,
    FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)
);

CREATE TABLE Members (
    MemberId INT PRIMARY KEY,
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
