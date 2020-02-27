--Ques9: Difference b/w having clause and where clause provide examples.
--HAVING CLAUSE:- 1. it can be used with aggrigation
                --2. It is not used without group by clause
				--3. It select rows after grouping.

--Where clasue:-1. It cannot be used with aggrigation, it works on row data
			--  2. It select rows before grouping
			--	3. It specifices the criteria which individual rrecords must meet to be selected by query
			--  4. It can be used without by group by clause


-------USE OF WHERE CLAUSE

SELECT *
FROM tblEmployee
Where Yearly_Salary >=50000

-------USE OF HAVING CLAUSE

SELECT Emp_Id, AVG(Month_Wise_Salary) AS Average_Salary 
FROM tblSalary 
GROUP BY Emp_Id
HAVING AVG(Month_Wise_Salary)>=20000;