--Ques5: How to create and invoke user defined functions ?

-- When a task is needed to be performed on repeated basis then a user cn make a function so that by just calling a function our task is done
-- and then there is no need to right same set of statements again and again

-- user-defined functions are routines that accept parameters, perform an action, such as a complex calculation, and return the result of 
-- that action as a value. The return value can either be a single scalar value or a result set.

-- User define function provide 1. modular programming 2.allow faster execution   3. reduce network trafic

--In 2 ways user defined functions can be created in ms sql

------------1. CREATE INLINE TABLED VALUE FUNCTION

CREATE FUNCTION GET_Salary(@Total_salary_of_employees INT)  
RETURNS TABLE  
AS  
RETURN  
    SELECT * FROM tblEmployee WHERE tblEmployee.Yearly_Salary>=@Total_salary_of_employees 


SELECT *FROM GET_Salary(50000) 


--------------2. CREATE Multi-Statement Table Valued Function
Alter FUNCTION GET_MAX_SALARY(@Salary int)  
RETURNS int
AS  
BEGIN  
	RETURN (SELECT tblEmployee.Emp_Id
			FROM tblEmployee
			WHERE tblEmployee.Yearly_Salary=@Salary)
			
END 

PRINT dbo.GET_MAX_SALARY(30000)
