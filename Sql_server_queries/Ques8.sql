--Ques8: Create and invoke one stored procedure from another stored procedure.

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