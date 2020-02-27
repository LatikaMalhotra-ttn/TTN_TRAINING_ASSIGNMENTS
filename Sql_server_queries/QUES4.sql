--QUES4:What are the benifits of using views also give an example ?

--VIEW is like a virtual table . It contains rows and coloumn just like a table .The fields in 
--a view are fields from the result of a query which is run on one or more table .

-----------MAIN ADVANTAGES OF VIEW ARE : 1. Gives extra security
-----------------------------------------2. Simplify query
-----------------------------------------3.consistency
-----------------------------------------4.integrity
-----------------------------------------5.Performance
-----------------------------------------6.Update Restrictions



------------------CREATING A VIEW

CREATE VIEW [view_of_Employee]
AS 
(
SELECT 
    tblEmployee.Emp_Id,tblEmployee.Emp_Name,tblEmployee.Date_of_birth,tblEmployee.Mobile,tblEmployee.ZIP,tblSalary.Month_of_which_salary_is_given,
	tblSalary.Month_Wise_Salary
FROM
    tblEmployee
INNER JOIN
    tblSalary ON tblEmployee.Emp_Id=tblSalary.Emp_Id
);


-------------------Displaying view
SELECT * FROM [view_of_Employee]