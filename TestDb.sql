CREATE TABLE [dbo].[Employee]
(
  [Id] [int]  NOT NULL,
  [FirstName] [nvarchar](50)  NOT NULL,
  [LastName] [nvarchar](50)  NULL,
  [PermanentAddress] [nvarchar](50)  NULL,
  [PresentAddress] [nvarchar](50)  NULL,
  [ContactAddress] [nvarchar](50)  NULL,
  [ContactMail] [nvarchar](50)  NULL,
  [ContactNo] [nvarchar](50)  NULL,
  [Phone] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[Employee] ADD CONSTRAINT PK__Employee__3214EC07686C33F5 PRIMARY KEY  ([Id])

-- Add 2 rows for Employee.
INSERT INTO Employee (Id, FirstName, LastName, PermanentAddress, PresentAddress, ContactAddress, ContactMail, ContactNo, Phone) VALUES 
(2001,'C M ','Abdullah','Amtali','Bonosree','rampura ','a.kium.khan@gmail.com','+8801717','+880171724'),
(2002,'Mainul','Hasan','Mohakhali','Gulsan','Malibag ','mainul@gmail.com','+880197','+880191724');

CREATE TABLE [dbo].[Employee1]
(
  [Id] [int]  NOT NULL,
  [FirstName] [nvarchar](40)  NOT NULL,
  [LastName] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[Employee1] ADD CONSTRAINT PK__Employee__3214EC0790DB1402 PRIMARY KEY  ([Id])

-- Add 2 rows for Employee1.
INSERT INTO Employee1 (Id, FirstName, LastName) VALUES 
(2,'C M ','Abdullah'),
(3,'Mainul','Hasan');

CREATE TABLE [dbo].[FK]
(
  [SId] [int]  NOT NULL,
  [FirstName] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[FK] ADD CONSTRAINT PK__FK__CA1959500420E4B0 PRIMARY KEY  ([SId])

-- Add 3 rows for FK.
INSERT INTO FK (SId, FirstName) VALUES 
(2001,'C M '),
(2002,'Abdullah'),
(2003,'Khan');

CREATE TABLE [dbo].[Leave]
(
  [Id] [int]  NOT NULL,
  [CasualLeave] [nvarchar](40)  NOT NULL,
  [StudyLeave] [nvarchar](50)  NULL,
  [Medical] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[Leave] ADD CONSTRAINT PK__Leave__3214EC071F9653DE PRIMARY KEY  ([Id])

-- Add 1 rows for Leave.
INSERT INTO Leave (Id, CasualLeave, StudyLeave, Medical) VALUES 
(2,'25d','5y','2m');

CREATE TABLE [dbo].[Notice]
(
  [Id] [int]  NOT NULL,
  [NoticeType] [nvarchar](40)  NOT NULL,
  [NoticeName] [nvarchar](50)  NULL,
  [NoticeDate] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[Notice] ADD CONSTRAINT PK__Notice__3214EC07107B90DD PRIMARY KEY  ([Id])

-- Add 2 rows for Notice.
INSERT INTO Notice (Id, NoticeType, NoticeName, NoticeDate) VALUES 
(9,'Meeting','About Eid ul AdHa','10/08/2017'),
(11,'Meeting','About Exm time schaduling','10/8/2017');

CREATE TABLE [dbo].[Salary]
(
  [Id] [int]  NOT NULL,
  [Basic] [nvarchar](40)  NOT NULL,
  [HouseRent] [nvarchar](50)  NULL,
  [Medical] [nvarchar](50)  NULL,
  [Bonus] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[Salary] ADD CONSTRAINT PK__Salary__3214EC073CCB0F9A PRIMARY KEY  ([Id])

-- Add 2 rows for Salary.
INSERT INTO Salary (Id, Basic, HouseRent, Medical, Bonus) VALUES 
(2,'20000','5000','10000','20000'),
(3,'30000','6000','15000','30000');

CREATE TABLE [dbo].[Salary1]
(
  [sId] [int]  NOT NULL,
  [Basic] [nvarchar](50)  NOT NULL,
  [Medical] [nvarchar](50)  NULL,
  [HouseRent] [nvarchar](50)  NULL,
  [Education] [nvarchar](50)  NULL,
  [Bonus] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[Salary1] ADD CONSTRAINT PK__Salary1__DDDED96E40AB0E64 PRIMARY KEY  ([sId])

-- Add 2 rows for Salary1.
INSERT INTO Salary1 (sId, Basic, Medical, HouseRent, Education, Bonus) VALUES 
(2001,'20000','2000','8000','5000','20000 '),
(2002,'30000','3000','9000','5000','30000 ');

CREATE TABLE [dbo].[Students]
(
  [Id] [int]  NOT NULL,
  [Name] [nvarchar](50)  NOT NULL,
  [Program] [nvarchar](5)  NULL
)
ALTER TABLE [dbo].[Students] ADD CONSTRAINT PK__Students__3214EC07C900A32A PRIMARY KEY  ([Id])

-- Add 15 rows for Students.
INSERT INTO Students (Id, Name, Program) VALUES 
(1,'s','a'),
(7,'y','h'),
(8,'j','j'),
(11,'sdsax','aaa'),
(33,'tt','tttt'),
(44,'vv','bbbb'),
(55,'e','d'),
(112,'22sd','bbb'),
(2001,'abdullah','cse'),
(2017,'cm abdullahkhan','csee'),
(3388,'eee','cm'),
(30310,'3Abdullah','CM'),
(30317,'3Khan','3CM'),
(33001,'3CM','3CMa'),
(111333322,'ddddd3333','aaa');

CREATE TABLE [dbo].[Teacher]
(
  [Id] [int]  NOT NULL,
  [Name] [nvarchar](50)  NOT NULL,
  [Department] [nvarchar](50)  NULL
)
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT PK__Teacher__3214EC07BC5A85B9 PRIMARY KEY  ([Id])

-- Add 3 rows for Teacher.
INSERT INTO Teacher (Id, Name, Department) VALUES 
(2001,'C M ','CSE'),
(2002,'Abdullah','CSE'),
(2003,'Khan','SE');

