--QUES3- How data can be copied from one table to another table ? 

--THERE ARE TWO WAYS IN DOING THIS
--1. BY DIRECLY COPING ONE TABLE DATA IN ANOTHER IN WHICH TABLE SCHEMA IS CREATED IMPLICITELY
SELECT * INTO tblEmployee_Backup
FROM tblEmployee;

SELECT * FROM tblEmployee_Backup


--2. BY CREATING TABLE EXPLICITLY AND THEN COPYING DATA FROM NE TABLE TO ANOTHER
CREATE TABLE tblEmployee_Backup1
(
	Emp_Id int identity(100,1) PRIMARY KEY,
	Emp_Name varchar(50) NOT NULL,
	Date_of_birth date,
	Emp_Address varchar(50),
	Salary Money,
	Mobile varchar(10)  NOT NULL constraint Mobile_Constraint_CK1 check (Mobile like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	ZIP varchar(6) NOT NULL constraint zip_constraint_Ck1 check (ZIP like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
	IsActive bit DEFAULT 0,
	CreateDate datetime2 default GETDATE(),
	ModifyDate datetime2
);

SET IDENTITY_INSERT tblEmployee_Backup1 ON
SET IDENTITY_INSERT tblEmployee ON

INSERT INTO tblEmployee_Backup1(Emp_Id,Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive)
SELECT Emp_Id,Emp_Name,Date_of_birth,Emp_Address,Mobile,ZIP,IsActive FROM tblEmployee

SELECT * FROM tblEmployee_Backup1
