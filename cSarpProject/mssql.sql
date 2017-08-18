
SELECT * FROM sys.sysdatabases
GO

SELECT * FROM sys.tables
GO

CREATE TABLE T1 (C1 INT NOT NULL)
GO

SELECT * FROM T1
GO

-- query from table
SELECT * FROM sys.tables
GO

/**formula of creat new database*/
USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'TutorialDB'
)
CREATE DATABASE [TutorialDB]
GO

/*** my code **/
-- query from table
SELECT * FROM sys.tables
GO
-- Create the table in the specified schema by cm
CREATE TABLE LoginTable (
    cID              INT             NOT NULL   PRIMARY KEY,
    PasswordOfUsr   [NVARCHAR](50) NOT NULL,
    Player          [NVARCHAR](50) NOT NULL
)
GO

-- Insert rows into table 'LoginTable'
INSERT INTO LoginTable
   ([cID],[PasswordOfUsr],[Player])
VALUES
   ( 14103295, N'absscd', N'Sddtudent'),
   ( 12103296, N'defssg', N'Faddculty'),
   ( 13103334, N'xyzdda', N'Stdduff') 
GO  

-- Query all LoginTable information
SELECT e.cID, e.PasswordOfUsr, e.Player 
FROM dbo.LoginTable as e
GO

-- Query the total count of LoginTable
SELECT COUNT(*) as EmployeeCount FROM dbo.LoginTable;
GO

-- Drop the table if it already exists
IF OBJECT_ID('dbo.T1', 'U') IS NOT NULL
DROP TABLE dbo.T1
GO



SELECT @@SERVERNAME,
    SERVERPROPERTY('ComputerNamePhysicalNetBIOS'),
    SERVERPROPERTY('MachineName'),
    SERVERPROPERTY('ServerName')
    go






--login table
CREATE TABLE Login (
    Id  INT   NOT NULL   PRIMARY KEY,
    Name  [NVARCHAR](50) NOT NULL
)
GO


-- Insert rows into table 'LoginTable'
INSERT INTO Login
   ([Id],[Name])
VALUES
   ( 00252221, N'21abdaullah 005'),
   ( 0022262, N'21cm aa006'),
   ( 0022244, N'21Khan aa004') 
GO  


-- Query all LoginTable information
SELECT e.Id, e.Name 
FROM dbo.Login as e
GO



--test mode

/**formula of creat new database*/
USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'Abdullah'
)
CREATE DATABASE [Abdullah]
GO




--login table
CREATE TABLE Log (
    Id  INT   NOT NULL   PRIMARY KEY,
    Name  [NVARCHAR](50) NOT NULL
)
GO


-- Insert rows into table 'LoginTable'
INSERT INTO Log
   ([Id],[Name])
VALUES
   ( 51, N'abdullah new'),
   ( 62, N'cm nwe'),
   ( 44, N'Khan new') 
GO  


-- Query all LoginTable information
SELECT e.Id, e.Name 
FROM dbo.Log as e
GO


--bullsheet
CREATE DATABASE TestDBCM

SELECT Name from sys.Databases
GO


USE TestDBCM
GO

CREATE TABLE Inventory (id INT, name NVARCHAR(50), quantity INT)
GO


INSERT INTO Inventory VALUES (1, 'banana', 150); INSERT INTO Inventory VALUES (2, 'orange', 154);
GO


SELECT * FROM Inventory WHERE quantity > 152;
GO

-- Query all LoginTable information
SELECT e.id, e.Name , e.quantity
FROM dbo.Inventory as e
GO



--testing
-- Create the table in the specified schema by cm
CREATE TABLE InstitutionDetails (
    Id              INT             NOT NULL   PRIMARY KEY,
    Name   [NVARCHAR](50) NOT NULL
)
GO

-- Insert rows into table 'LoginTable'
INSERT INTO InstitutionDetails
   ([Id],[Name])
VALUES
   ( 2001, N'CM'),
   ( 2010, N'Abdullah'),
   ( 1017, N'Khan') 
GO  


-- Query all LoginTable information
SELECT e.Id, e.Name 
FROM dbo.InstitutionDetails as e
GO







--testing student table
-- Create the table in the specified schema by cm
CREATE TABLE Students (
    Id              INT             NOT NULL   PRIMARY KEY,
    Name   [NVARCHAR](50) NOT NULL
)
GO

-- Insert rows into table 'LoginTable'
INSERT INTO InstitutionDetails
   ([Id],[Name])
VALUES
   ( 3001, N'3CM'),
   ( 3010, N'3Abdullah'),
   ( 3017, N'3Khan') 
GO  


-- Query all LoginTable information
SELECT e.Id, e.Name 
FROM dbo.InstitutionDetails as e
GO




------
-------

---------

USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'TestDb'
)
CREATE DATABASE [TestDb]
GO
use TestDb
GO

-- Create the table in the specified schema by cm
CREATE TABLE Students (
    Id              INT             NOT NULL   PRIMARY KEY,
    Name   [NVARCHAR](50) NOT NULL,
    Program [nvarchar](5) NULL
)
GO



INSERT INTO Students
   ([Id],[Name],[Program])
VALUES
   ( 33001, N'3CM',N'3CMa'),
   ( 30310, N'3Abdullah',N'CM'),
   ( 30317, N'3Khan',N'3CM') 
GO  


USE TestDb
GO

SELECT e.Id, e.Name ,e.Program
FROM dbo.Students as e
GO

---new table
CREATE TABLE Teacher (
    Id              INT             NOT NULL   PRIMARY KEY,
    Name   [NVARCHAR](50) NOT NULL,
    Department [nvarchar](50) NULL

)
GO

INSERT INTO Teacher
   ([Id],[Name],[Department])
VALUES
   ( 2001, N'C M ',N'CSE'),
   ( 2002, N'Abdullah',N'CSE'),
   ( 2003, N'Khan',N'SE') 
GO  
SELECT e.Id, e.Name ,e.Department
FROM dbo.Teacher as e
GO


-- working with project

CREATE TABLE Employee (
    Id   INT  NOT NULL   PRIMARY KEY,
    FirstName   [NVARCHAR](50) NOT NULL,
    LastName [nvarchar](50) NULL,
    PermanentAddress [nvarchar](50) NULL,
    PresentAddress [nvarchar](50) NULL,
    ContactAddress [nvarchar](50) NULL,
    ContactMail [nvarchar](50) NULL,
    ContactNo [nvarchar](50) NULL,
    Phone [nvarchar](50) NULL
)
GO

--employee table
INSERT INTO Employee
   ([Id],[FirstName],[LastName],[PermanentAddress],[PresentAddress],[ContactAddress],[ContactMail],[ContactNo],[Phone])
VALUES
   ( 2001, N'C M ',N'Abdullah', N'Amtali',N'Bonosree', N'rampura ',N'a.kium.khan@gmail.com', N'+8801717',N'+880171724'),
   ( 2002, N'Mainul',N'Hasan', N'Mohakhali',N'Gulsan', N'Malibag ',N'mainul@gmail.com', N'+880197',N'+880191724')
GO 

SELECT e.Id, e.FirstName ,e.LastName,e.PermanentAddress,e.PresentAddress,e.ContactAddress,e.ContactMail,e.ContactNo,e.Phone
FROM dbo.Employee as e
GO