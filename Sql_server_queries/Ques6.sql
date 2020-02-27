--QUES6:  Find the data from a table between two dates.
-- HERE WE HAVE FIRST ADDED VALES IN MODIFY DATE COLUMN AND THEN WE HAVE EXECUTED THE QUERY


--UPDATING VALUES 
ALTER TABLE tblEmployee 
ALTER COLUMN ModifyDate DATE;


UPDATE tblEmployee
SET ModifyDate='2020-02-21'
WHERE Emp_Id=100;

UPDATE tblEmployee
SET ModifyDate='2020-02-22'
WHERE Emp_Id=101;
UPDATE tblEmployee
SET ModifyDate='2020-02-23'
WHERE Emp_Id=102;
UPDATE tblEmployee
SET ModifyDate='2020-02-24'
WHERE Emp_Id=103;
UPDATE tblEmployee
SET ModifyDate='2020-02-25'
WHERE Emp_Id=104;
UPDATE tblEmployee
SET ModifyDate='2020-02-26'
WHERE Emp_Id=105;
UPDATE tblEmployee
SET ModifyDate='2020-02-27'
WHERE Emp_Id=106;
UPDATE tblEmployee
SET ModifyDate='2020-02-28'
WHERE Emp_Id=107;
UPDATE tblEmployee
SET ModifyDate='2020-02-29'
WHERE Emp_Id=108;
UPDATE tblEmployee
SET ModifyDate='2020-02-11'
WHERE Emp_Id=109;
UPDATE tblEmployee
SET ModifyDate='2020-02-12'
WHERE Emp_Id=110;
UPDATE tblEmployee
SET ModifyDate='2020-02-13'
WHERE Emp_Id=111;
UPDATE tblEmployee
SET ModifyDate='2020-02-14'
WHERE Emp_Id=112;
UPDATE tblEmployee
SET ModifyDate='2020-02-15'
WHERE Emp_Id=113;
UPDATE tblEmployee
SET ModifyDate='2020-02-16'
WHERE Emp_Id=114;

--------------------------QUERU

SELECT Emp_Id,Emp_Name,ModifyDate 
FROM tblEmployee
where ModifyDate between '2020-02-21' and '2020-02-28'

