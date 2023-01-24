CREATE DATABASE ZooManagement;

USE ZooManagement;

CREATE TABLE TicketTypes
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Subscription VARCHAR(20),
Price INT,
Validity VARCHAR(20),
);

CREATE TABLE Visitors
(
Id INT IDENTITY(1,1) PRIMARY KEY,
LastName VARCHAR(50),
FirstName VARCHAR(50),
TicketId INT REFERENCES TicketTypes(Id),
EntryDate Date,
);

CREATE TABLE Species
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50),
);

CREATE TABLE Animals
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50),
Species INT REFERENCES Species(Id),
);

CREATE TABLE VisitorsFeedingAnimals
(
Id INT IDENTITY(1,1) PRIMARY KEY,
VisitorId INT REFERENCES Visitors(Id),
AnimalId INT REFERENCES Animals(Id),
);

CREATE TABLE Caretakers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
LastName VARCHAR(50),
FirstName VARCHAR(50),
SpeciesExpertise INT REFERENCES Species(Id),
);

INSERT INTO TicketTypes
VALUES ('Standard', 10, 'One day');
INSERT INTO TicketTypes
VALUES ('Premium', 20, 'One week');
INSERT INTO TicketTypes
VALUES ('VIP', 35, 'One month');

SELECT *
FROM TicketTypes;

INSERT INTO Visitors
VALUES ('Ionescu', 'Ionut', 2, '2023-01-20');
INSERT INTO Visitors
VALUES ('Eminescu', 'Mihai', 3, '2023-01-20');
INSERT INTO Visitors
VALUES ('Iorgescu', 'Iorgu', 1, '2023-01-21');
INSERT INTO Visitors
VALUES ('Daminescu', 'Damian', 2, '2023-01-22');
INSERT INTO Visitors
VALUES ('Georgescu', 'George', 1, '2023-01-22');
INSERT INTO Visitors
VALUES ('Vasilescu', 'Vasile', 2, '2023-01-23');
INSERT INTO Visitors
VALUES ('Petrescu', 'Petrisor', 1, '2023-01-23');

SELECT *
FROM Visitors;

INSERT INTO Species
VALUES ('monkey');
INSERT INTO Species
VALUES ('lion');
INSERT INTO Species
VALUES ('tiger');
INSERT INTO Species
VALUES ('giraffe');
INSERT INTO Species
VALUES ('penguin');
INSERT INTO Species
VALUES ('zebra');
INSERT INTO Species
VALUES ('kangaroo');

SELECT *
FROM Species;

INSERT INTO Animals
VALUES ('Cita', 1);
INSERT INTO Animals
VALUES ('Penelope', 1);
INSERT INTO Animals
VALUES ('Tommy', 3);
INSERT INTO Animals
VALUES ('Spartan', 7);
INSERT INTO Animals
VALUES ('Flipper', 5);
INSERT INTO Animals
VALUES ('Layla', 6);
INSERT INTO Animals
VALUES ('Atena', 6);
INSERT INTO Animals
VALUES ('Leonid', 2);
INSERT INTO Animals
VALUES ('Macarena', 7);
INSERT INTO Animals
VALUES ('Lionel', 2);
INSERT INTO Animals
VALUES ('Clementine', 4);
INSERT INTO Animals
VALUES ('Polly', 1);

SELECT *
FROM Animals;

INSERT INTO VisitorsFeedingAnimals
VALUES (1, 5);
INSERT INTO VisitorsFeedingAnimals
VALUES (1, 6);
INSERT INTO VisitorsFeedingAnimals
VALUES (2, 6);
INSERT INTO VisitorsFeedingAnimals
VALUES (3, 5);
INSERT INTO VisitorsFeedingAnimals
VALUES (4, 6);
INSERT INTO VisitorsFeedingAnimals
VALUES (4, 7);

SELECT *
FROM VisitorsFeedingAnimals;

INSERT INTO Caretakers
VALUES ('Ene', 'Mircea', 1);
INSERT INTO Caretakers
VALUES ('Doaga', 'Ana', 3);
INSERT INTO Caretakers
VALUES ('Lupu', 'Elena', 6);
INSERT INTO Caretakers
VALUES ('Florea', 'Mihai', 4);
INSERT INTO Caretakers
VALUES ('Vaida', 'Paula', 7);
INSERT INTO Caretakers
VALUES ('Turcu', 'Traian', 5);
INSERT INTO Caretakers
VALUES ('Bancu', 'Cecilia', 2);

SELECT *
FROM Caretakers;
DROP TABLE Caretakers;
