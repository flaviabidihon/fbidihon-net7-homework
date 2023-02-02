CREATE DATABASE LibrariesManagement;

USE LibrariesManagement;

CREATE TABLE Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(50),
    StreetName VARCHAR(50),
    City VARCHAR(50)
)

CREATE TABLE Librarians
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(30),
    HireDate Date,
    IsOnHoliday VARCHAR(3),
    LibraryId INT REFERENCES Libraries(Id)
)

CREATE TABLE Books
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Title VARCHAR(50),
    AuthorFirstName VARCHAR(30),
    AuthorLastName VARCHAR(30),
    Type VARCHAR(10), -- crime, fantasy, horror, adventure
)

ALTER TABLE Books
ADD AuthorEmail VARCHAR(50);

CREATE TABLE Books_Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    LibraryId INT REFERENCES Libraries(Id)
)

CREATE TABLE Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    NumberOfCopies INT,
    LibraryId INT REFERENCES Libraries(Id),
    LibrarianId INT REFERENCES Librarians(Id)
)

ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK__Sales__Librarian__4316F928]  -- couldn't drop column Librarians without doing this
ALTER TABLE [dbo].[Sales] DROP CONSTRAINT [FK__Sales__LibraryId__4222D4EF]

ALTER TABLE Sales
DROP COLUMN LibrarianId;
ALTER TABLE Sales
DROP COLUMN LibraryId;
ALTER TABLE Sales
ADD BookLibraryId INT REFERENCES Books_Libraries(Id)

CREATE TABLE Books_Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    SalesId INT REFERENCES Sales(Id)
)

--exercise1
-- 1st improvement: inserting data to tables
-- 2nd improvement: changing IsOnHoliday from VARCHAR to BIT
-- 3rd improvement: inserting into Books column AuthorEmail
-- 4th improvement: dropping from Sales LibraryId and LibrarianId and adding BookLibraryId

INSERT INTO Libraries
VALUES('Luceafarul', 'Bulevardul Pacii', 'Iasi')
INSERT INTO Libraries
VALUES('Carusel', 'Bulevardul Eroilor', 'Bucuresti')
INSERT INTO Libraries
VALUES('Books and coffee', 'Anastasie Pana', 'Cluj')
INSERT INTO Libraries
VALUES('Lecturarium', 'Emil Racovita', 'Iasi')

SELECT *
FROM Libraries;

ALTER TABLE Librarians
ALTER COLUMN IsOnHoliday BIT;

INSERT INTO Librarians
VALUES('Andreea', '2020-05-10', 0, 1)
INSERT INTO Librarians
VALUES('Paul', '2016-07-30', 1, 2)
INSERT INTO Librarians
VALUES('Simona', '2021-01-24', 1, 4)
INSERT INTO Librarians
VALUES('Traian', '2023-01-15', 0, 4)
INSERT INTO Librarians
VALUES('Larisa', '2012-11-30', 0, 3)

SELECT *
FROM Librarians;

INSERT INTO Books
VALUES('Prietena mea geniala', 'Elena', 'Ferrante', 'fantasy', 'ferrante@gmail.com')
INSERT INTO Books
VALUES('Povestea noului nume', 'Elena', 'Ferrante', 'fantasy', 'ferrante@gmail.com')
INSERT INTO Books
VALUES('Scurta Istorie a Pamantului', 'Andrew', 'Knoll', 'nonfiction', 'a_knoll@gmail.com')
INSERT INTO Books
VALUES('Nascut in afara legii', 'Trevor', 'Noah', 'memoir', 'trevorrr@gmail.com')
INSERT INTO Books
VALUES('Din cer au cazut trei mere', 'Narine', 'Abgarian', 'fantasy', 'abgarian@gmail.com')
INSERT INTO Books
VALUES('Cei care pleaca si cei care raman', 'Elena', 'Ferrante', 'fantasy', 'ferrante@gmail.com')
INSERT INTO Books
VALUES('Ciuleandra', 'Liviu', 'Rebreanu', 'crime', 'rebreanu@postaromana.ro')
INSERT INTO Books
VALUES('Povestea fetitei pierdute', 'Elena', 'Ferrante', 'fantasy', 'ferrante@gmail.com')

INSERT INTO Books_Libraries
VALUES(1, 1)
INSERT INTO Books_Libraries
VALUES(1, 3)
INSERT INTO Books_Libraries
VALUES(2, 1)
INSERT INTO Books_Libraries
VALUES(2, 3)
INSERT INTO Books_Libraries
VALUES(3, 3)
INSERT INTO Books_Libraries
VALUES(4, 1)
INSERT INTO Books_Libraries
VALUES(5, 4)
INSERT INTO Books_Libraries
VALUES(6, 1)
INSERT INTO Books_Libraries
VALUES(6, 3)
INSERT INTO Books_Libraries
VALUES(7, 4)
INSERT INTO Books_Libraries
VALUES(8, 1)
INSERT INTO Books_Libraries
VALUES(8, 3)

SELECT *
FROM Books_Libraries;
SELECT *
FROM Libraries;
SELECT *
FROM Books;

INSERT INTO Sales
VALUES(114, 1)
INSERT INTO Sales
VALUES(98, 4)
INSERT INTO Sales
VALUES(321, 3)
INSERT INTO Sales
VALUES(987, 2)
INSERT INTO Sales
VALUES(89, 7)
INSERT INTO Sales
VALUES(56, 8)
INSERT INTO Sales
VALUES(347, 5)
INSERT INTO Sales
VALUES(563, 11)
INSERT INTO Sales
VALUES(97, 6)
INSERT INTO Sales
VALUES(224, 9)
INSERT INTO Sales
VALUES(90, 12)
INSERT INTO Sales
VALUES(542, 10)

SELECT *
FROM Sales;

--exercise2
--Display all the librarians together with the library name they work in ordered by librarian name and library name descending.
SELECT L.Name, Lib.Name
FROM Librarians L
INNER JOIN Libraries Lib ON Lib.Id = L.LibraryId
ORDER BY L.Name DESC;

SELECT L.Name, Lib.Name
FROM Librarians L
INNER JOIN Libraries Lib ON Lib.Id = L.LibraryId
ORDER BY Lib.Name DESC;

--exercise3
--Update all the street names to start with "STR.".
UPDATE Libraries
SET StreetName = 'STR. ' + Streetname;   --I didn't know how to undo the 1st update. That's why the 1st try of 'str' is still there

--exercise4
--Display the authors' email for those who have more than 3 books published.
SELECT AuthorEmail
FROM Books
GROUP BY AuthorEmail
HAVING COUNT(AuthorLastName) > 3;

--exercise5
--Display the library name and the book title of the largest sale (the highest number of copies sold in one sale).
SELECT MAX(S.NumberOfCopies), Lib.Name, B.Title    --I'm so stuck...
FROM Sales S
JOIN Books_Libraries BL ON S.BookLibraryId = BL.Id
JOIN Libraries Lib ON Lib.Id = BL.LibraryId
JOIN Books B ON B.Id = BL.BookId;

--exercise6
--Display all the librarians that are not on holiday and are hired more than 5 years ago.
SELECT Name 
FROM Librarians
WHERE IsOnHoliday = 0 AND HireDate < GETDATE() - YEAR(5)

--exercise7
--Create a stored procedure that displays, based on the book title, the number of libraries in which the book is found. Call the procedure with three different book titles.
GO
CREATE PROCEDURE CountLibraries(
    @BookTitle VARCHAR(50)
)
AS
BEGIN
SELECT COUNT(LibraryId) AS NumberOfLibraries
FROM Books_Libraries
JOIN Books ON Books.Id = Books_Libraries.BookId
WHERE @BookTitle = Books.Title
END
GO

exec
CountLibraries'Prietena mea geniala';
exec
CountLibraries'Nascut in afara legii';
exec
CountLibraries'Ciuleandra';

--exercise8
--Create a function that returns, based on the author's email, the number of copies sold for each of his / her books. Call the function with three different emails.
--I messed up here -_-
GO
CREATE FUNCTION dbo.CopiesSoldByAuthorEmail(
    @Email VARCHAR(50)
)
RETURNS INT
AS
BEGIN
DECLARE @numberOfCopies INT;
SET @numberOfCopies = 
    (SELECT COUNT(Sales.NumberOfCopies)
    FROM Sales    
    JOIN Books_Libraries ON Sales.BookLibraryId = Books_Libraries.Id
    JOIN Books ON Books.Id = Books_Libraries.BookId
    WHERE Books.AuthorEmail = @Email);
RETURN @numberOfCopies;
END;
GO

select dbo.CopiesSoldByAuthorEmail('ferrante@gmail.com');

SELECT *
FROM Books;
SELECT *
FROM Books_Libraries;
SELECT *
FROM Sales;

--exercise9
--Create a trigger so that when a new librarian is added to the system with no library assigned (NULL on LibraryId), he / she is automatically assigned to a library.
--I can't figure out what am I missing here :(
GO
CREATE TRIGGER AssignToLibrary
ON Librarians
AFTER INSERT
AS
BEGIN
UPDATE Librarians
SET LibraryId = 3
WHERE Id = NULL
END
GO

INSERT INTO Librarians
VALUES('Paula', '2023-02-02', 1, NULL)

SELECT *
FROM Librarians;
