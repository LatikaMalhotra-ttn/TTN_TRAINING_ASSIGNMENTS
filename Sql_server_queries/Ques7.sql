--Ques7: Give examples of self,Inner,left outer,right outer joins.

--------INNER JOIN IS APPLIED BELOW
SELECT tblEmployee.Emp_Id,tblEmployee.Emp_Name,tblEmployee.Emp_Address,TblSalary.Month_of_which_salary_is_given,tblSalary.Month_Wise_Salary
FROM tblEmployee
INNER JOIN tblSalary ON tblEmployee.Emp_Id=tblSalary.Emp_Id;

-------------LEFT JOIN  IS APPLIED BELOW
SELECT tblEmployee.Emp_Id,tblEmployee.Emp_Name,tblEmployee.Emp_Address,TblSalary.Month_of_which_salary_is_given,tblSalary.Month_Wise_Salary
FROM tblEmployee
LEFT OUTER JOIN tblSalary ON tblEmployee.Emp_Id=tblSalary.Emp_Id;

-----------RIGHT JOIN  IS APPLIED BELOW
SELECT tblEmployee.Emp_Id,tblEmployee.Emp_Name,tblEmployee.Emp_Address,TblSalary.Month_of_which_salary_is_given,tblSalary.Month_Wise_Salary
FROM tblEmployee
RIGHT OUTER JOIN tblSalary ON tblEmployee.Emp_Id=tblSalary.Emp_Id;


----------------SELF JOIN  IS APPLIED BELOW
----CREATED THE TABLE ON WHICH SELF JOIN CAN BE APPLIED
CREATE TABLE Student
(student_id int identity(1,1) NOT NULL PRIMARY KEY,
student_name varchar(20) NULL,
dt_of_admission date NULL,
student_supervisor int NULL,
CONSTRAINT student_supv_fk FOREIGN KEY(student_supervisor) 
REFERENCES Student(student_id));

INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('latika','2000-02-02',NULL)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('deepak','2000-01-29',NULL)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('ishita','2006-02-03',1)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('neelam','2006-02-04',1)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('nikhil','2006-02-06',1)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('kunika','2006-02-05',1)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('yash','2006-02-07',2)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('harsh','2006-02-08',2)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('anish','2006-02-09',2)
INSERT INTO Student(student_name,dt_of_admission,student_supervisor)
VALUES('ankita','2006-02-10',3)

SELECT * FROM Student

-------QUERY FOR SELF JOIN

SELECT main.student_id AS "Student_ID",main.student_name AS "Student Name",sup.student_id AS "Supervisor ID",sup.student_name AS "Supervisor Name"
FROM Student main, Student sup
WHERE main.student_supervisor = sup.student_id;
