--How to update column name of table ?

--BY USING sp_name we ae renaming column name SALARY to Yearly Salary

EXEC sp_rename 'tblEmployee.Salary', 'Yearly_Salary', 'COLUMN';

SELECT * FROM tblEmployee
