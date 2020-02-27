--Ques10: Difference between stored procedures and user defined functions. Explain with suitable examples.

-----Stored Procedure:-1. it cannot return 0 value, it is mandatory to return 1 value
-----------------------2. procedures cannot be called from function
-----------------------3. Exception can be handled by try-catch block in a procedure 
-----------------------4. Procedures can not be utilized in a select statement

-----User define function:-1. it can return 0 value
---------------------------2. Functions acn be called from procedures
---------------------------3. try-catch block cannot be used in a function.
---------------------------4. function can be embedded in a select statement.


------------STORED PROCEDURE-----------------------------------
----STEP1- CREATE PROCEDURE TO FIND SUM OF SALARY--------------------------------
CREATE PROCEDURE SUM_OF_EMPLOYEE_SALARY @e_id int,@output int OUTPUT
AS
BEGIN
	SET @output=(SELECT SUM(Month_Wise_salary) FROM tblSalary WHERE Emp_Id=@e_id )
	RETURN @output
END
---------CALLING STORED PROCEDURE------------------------------
EXEC SUM_OF_EMPLOYEE_SALARY @EMP_ID, @result output
Print @result


------------------User defined function-------------------------
------------1. CREATE INLINE TABLED VALUE FUNCTION--------------
CREATE FUNCTION GET_Salary(@Total_salary_of_employees INT)  
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM tblEmployee WHERE tblEmployee.Yearly_Salary>=@Total_salary_of_employees 
-------CALLING FUNCTION-----------------------------------------
SELECT *FROM GET_Salary(50000) 

--------------2. CREATE Multi-Statement Table Valued Function---
Alter FUNCTION GET_MAX_SALARY(@Salary int)  
RETURNS int
AS  
BEGIN  
	RETURN (SELECT tblEmployee.Emp_Id
			FROM tblEmployee
			WHERE tblEmployee.Yearly_Salary=@Salary)
			
END 
---------------Calling fnction------------------------------------
PRINT dbo.GET_MAX_SALARY(30000)
