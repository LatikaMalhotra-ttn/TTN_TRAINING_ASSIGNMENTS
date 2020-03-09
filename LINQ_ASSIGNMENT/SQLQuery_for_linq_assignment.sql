CREATE DATABASE LINQ_Assignment

USE LINQ_ASSIGNMENT

CREATE TABLE tbl_student
(
roll_no int identity(1,1) PRIMARY KEY,
name varchar(50) NOT NULL,
address varchar(100),
phone_no bigint NOT NULL constraint Mobile_Constraint_CK check (phone_no like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
age int,
marks bigint
);
SELECT * FROM tbl_student

INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('latika','vikas puri-delhi',9876567890,22,100)


INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('deepak','rohini-delhi',4567865432,23,98)


INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('anish','pitampura-delhi',1456786543,22,89)


INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('geetika','uttamnagar-delhi',9876567543,26,78)


INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('megha','vikas puri-delhi',5435678890,22,87)


INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('shubham','aptel nagar-delhi',6789065432,17,91)


INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('ravi','kashmiri gate-delhi',7654567890,2,75)


INSERT INTO tbl_student(name,address,phone_no,age,marks)
VALUES('himanshu','karol bagh-delhi',5457678909,19,67)


SELECT * FROM tbl_student


CREATE TABLE tbl_student_course
(
Course_id int,
Roll_no int,
FOREIGN KEY(Roll_no) REFERENCES tbl_student(roll_no)
);


INSERT INTO tbl_student_course(Course_id,Roll_no)
VALUES(1,1);
INSERT INTO tbl_student_course(Course_id,Roll_no)
VALUES(2,2);
INSERT INTO tbl_student_course(Course_id,Roll_no)
VALUES(2,3);
INSERT INTO tbl_student_course(Course_id,Roll_no)
VALUES(3,4);
INSERT INTO tbl_student_course(Course_id,Roll_no)
VALUES(1,5);
INSERT INTO tbl_student_course(Course_id,Roll_no)
VALUES(1,6);

SELECT * FROM tbl_student_course


CREATE TABLE tbl_course
(
Course_id int PRIMARY KEY,
Course_name varchar(20)
);


INSERT INTO tbl_course(Course_id,Course_name)
VALUES(1,'medical')
INSERT INTO tbl_course(Course_id,Course_name)
VALUES(2,'non-medical')
INSERT INTO tbl_course(Course_id,Course_name)
VALUES(3,'commerece')
INSERT INTO tbl_course(Course_id,Course_name)
VALUES(4,'humanities')

SELECT * FROM tbl_course
