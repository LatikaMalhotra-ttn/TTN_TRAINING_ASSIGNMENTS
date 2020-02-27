--QUES1 -Create a table (datatype should be appropriate for each column).Insert data into table,Update one table data using join with other table
--       (you can create another table   which takes the reference from the first table). Table structure should be like.
--		 Id column should be primary key and identity,
--	     EmpName,
--       Mobile number should have 10 digits apply constraint.
--       DateOfBirth,
--	     Address,
--	     salary,
--       ZIP code should be 6 digits long,
--       IsActive
--	     CreatedDate,
--	     ModifiedDate.




----------CREATING DATABASE AND USING IT-------------------------------
CREATE DATABASE DB_Assignment_MS_sql;
USE DB_Assignment_MS_sql

--------------CREATING EMPLOYEE TABLE----------------------------------

CREATE TABLE tblEmployee
(
	Emp_Id int identity(100,1) PRIMARY KEY,
	Emp_Name varchar(50) NOT NULL,
	Date_of_birth date,
	Emp_Address varchar(50),
	Salary Money,
	Mobile varchar(10)  NOT NULL constraint Mobile_Constraint_CK check (Mobile like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	ZIP varchar(6) NOT NULL constraint zip_constraint_Ck check (ZIP like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
	IsActive bit DEFAULT 0,
	CreateDate datetime2 default GETDATE(),
	ModifyDate datetime2

);

--------------INSERTING VALUES IN EMPLOYEE TABLE------------------------

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('latika','1996-09-27','Vikas Puri-Delhi',9871333273,110018,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('deepak','1995-10-18','Rohini-Delhi',9818124789,110056,0);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('mehak','1997-03-12','Cannaught Place-Delhi',9998976543,110078,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('deepanshu','1995-02-12','Panipath-Harayana',9987876543,220009,0);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('charu','1989-10-17','Shrinagar-kashmir',9878987678,110045,0);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('neha','1992-06-27','Mukharji-nagar-Delhi',9878987678,110067,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('sakshi','1991-10-23','Dehradhun-Uttrakhand',9987654321,110045,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('vishash','1993-02-13','Shadra-Delhi',9876543234,110023,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('abhishak','1991-04-23','patel Nagar-Delhi',8787876543,110032,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('azeem','1996-01-15','YammunaVihar-Delhi',9876546789,110097,-0);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('arpit','1989-12-17','Gaur city-UP',8765789098,110050,0);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('shagun','1993-11-27','Badarpur-Delhi',7656789087,110076,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('punita','1998-10-22','Faridabadh-UP',8787654567,110087,1);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('siddarth','1985-12-18','Gaziabad-UP',9876543234,110072,0);

INSERT INTO tblEmployee(Emp_Name,DAte_of_birth,Emp_Address,Mobile,ZIP,IsActive) 
VALUES('punita','1994-05-15','Uttam Nagar-Delhi',2625371289,110083,1);


------------------DISPLAYING CONTENTS OF EMPLOYEE TABLE ----------------------
SELECT * FROM tblEmployee


------------------CREATING SALARY TABLE---------------------------------------
CREATE TABLE tblSalary(
SalaryId int Identity(1,1) PRIMARY KEY,
Emp_Id int NOT NULL,
Month_of_which_salary_is_given varchar(10) NOT NULL,
Month_Wise_Salary Money,
FOREIGN KEY(Emp_Id) REFERENCES tblEmployee(Emp_Id)
);


-----------------INSERTING VALUES IN SALARY TABLE------------------------------

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(100,'January',10000)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(100,'February',20000)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(102,'May',10200)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(102,'June',40000)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(105,'November',10340)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(105,'December',10210)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(106,'January',20000)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(106,'February',30000)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(107,'March',12000)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(107,'April',14000)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(108,'May',10210)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(108,'June',42300)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(111,'July',10351)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(111,'August',12323)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(112,'September',10130)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(112,'Octuber',100521)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(114,'November',23340)
INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(114,'December',11210)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(101,'November',0)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(103,'December',0)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(104,'November',0)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(109,'December',0)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(110,'December',0)

INSERT INTO tblSalary(Emp_Id,Month_of_which_salary_is_given,Month_Wise_Salary)
VALUES(114,'December',0)

--------------------------DISPLAYING DATA OF SALARY TABLE------------------------
SELECT * FROM tblSalary

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
------------------1 way - BY USING UPDATE AND JOIN ------------------------------
---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
UPDATE		tblEmployee
SET			tblEmployee.Salary=SALARY_TABLE.Salary
FROM		tblEmployee
INNER JOIN (SELECT Emp_Id,SUM(Month_Wise_Salary)AS Salary 
			FROM tblSalary 
			GROUP BY Emp_Id) AS SALARY_TABLE
ON			tblEmployee.Emp_Id=SALARY_TABLE.Emp_Id



---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
------------------2 way - BY USING STORED PROCEDURE -----------------------------
---------------------------------------------------------------------------------
---------------------------------------------------------------------------------
----STEP1- CREATE PROCEDURE TO FIND SUM OF SALARY--------------------------------
CREATE PROCEDURE SUM_OF_EMPLOYEE_SALARY @e_id int,@output int OUTPUT
AS
BEGIN
	SET @output=(SELECT SUM(Month_Wise_salary) FROM tblSalary WHERE Emp_Id=@e_id )
	RETURN @output
END

--------------STEP- CREATE PROCEDURE TO UPDATE TABLE------------------------------

CREATE PROCEDURE Update_employee_salary
AS
BEGIN
	DECLARE @Total varchar(10),@INITIALIZER varchar(5)
	SET @Total= (SELECT COUNT(*)FROM tblEmployee)
	SET @INITIALIZER=1
	PRINT @Total

	DEclare @EMPLOYEES_ID as table
	(
	id int
	)

	INSERT INTO @EMPLOYEES_ID(id) SELECT Emp_Id FROM tblEmployee

	WHILE @INITIALIZER<=@Total
	BEGIN
		declare @result int
		DECLARE @EMP_ID int
		SET @EMP_ID= (select top 1 id from @EMPLOYEES_ID )
		EXEC SUM_OF_EMPLOYEE_SALARY @EMP_ID, @result output
		update tblEmployee set Salary= @result where Emp_Id=@EMP_ID;
		print @result
		DELETE  @EMPLOYEES_ID Where id =@EMP_ID;
		set @INITIALIZER=@INITIALIZER+1;
		set @result=0;
	END
END
GO
--------------------Step3-to call procedure------------------------

EXEC Update_employee_salary

