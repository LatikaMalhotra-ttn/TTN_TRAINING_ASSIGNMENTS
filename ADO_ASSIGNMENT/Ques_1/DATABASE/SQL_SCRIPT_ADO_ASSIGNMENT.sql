CREATE DATABASE [ADO_ASSIGNMENT]
GO

USE [ADO_ASSIGNMENT]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Emp_id] [int] IDENTITY(1,1) NOT NULL,
	[Emp_name] [varchar](45) NOT NULL,
	[Emp_Gender] [int] NULL,
	[Salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Login]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Login](
	[UserId] [int] IDENTITY(100,1) NOT NULL,
	[UserName] [varchar](45) NOT NULL,
	[UserEmail] [varchar](50) NULL,
	[UserPassword] [bigint] NULL,
	[UserConfirmPassword] [bigint] NULL,
	[Mobile] [bigint] NULL,
	[Gender] [int] NULL,
	[age] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_employee_salary]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_employee_salary](
	[emp_id] [int] IDENTITY(100,1) NOT NULL,
	[emp_name] [varchar](50) NULL,
	[emp_sal] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (1, N'latika', 2, 12344.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (2, N'Deepak', 1, 12343.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (3, N'anish', 1, 33221.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (4, N'Deepti', 2, 214562.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (9, N'shagun', 2, 1234.0000)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Login] ON 
GO
INSERT [dbo].[tb_Login] ([UserId], [UserName], [UserEmail], [UserPassword], [UserConfirmPassword], [Mobile], [Gender], [age]) VALUES (100, N'latika', N'l@tothenew.com', 1234, 1234, 9876543210, 2, 22)
GO
INSERT [dbo].[tb_Login] ([UserId], [UserName], [UserEmail], [UserPassword], [UserConfirmPassword], [Mobile], [Gender], [age]) VALUES (101, N'deepak', N'd@tothenew.com', 12234, 12234, 9876323210, 1, 21)
GO
INSERT [dbo].[tb_Login] ([UserId], [UserName], [UserEmail], [UserPassword], [UserConfirmPassword], [Mobile], [Gender], [age]) VALUES (102, N'anish', N'a@tothenew.com', 1134, 1134, 9876543210, 1, 24)
GO
INSERT [dbo].[tb_Login] ([UserId], [UserName], [UserEmail], [UserPassword], [UserConfirmPassword], [Mobile], [Gender], [age]) VALUES (103, N'nirbhay', N'n@tothenew.com', 122334, 122334, 1876543210, 1, 22)
GO
INSERT [dbo].[tb_Login] ([UserId], [UserName], [UserEmail], [UserPassword], [UserConfirmPassword], [Mobile], [Gender], [age]) VALUES (104, N'ravi', N'r@tothenew.com', 12345, 12345, 9816263746, 1, 34)
GO
SET IDENTITY_INSERT [dbo].[tb_Login] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_employee_salary] ON 
GO
INSERT [dbo].[tbl_employee_salary] ([emp_id], [emp_name], [emp_sal]) VALUES (100, N'latika', 4900.0000)
GO
INSERT [dbo].[tbl_employee_salary] ([emp_id], [emp_name], [emp_sal]) VALUES (101, N'deepak', 9800.0000)
GO
INSERT [dbo].[tbl_employee_salary] ([emp_id], [emp_name], [emp_sal]) VALUES (102, N'anish', 25200.0000)
GO
INSERT [dbo].[tbl_employee_salary] ([emp_id], [emp_name], [emp_sal]) VALUES (103, N'shagun', 21100.0000)
GO
INSERT [dbo].[tbl_employee_salary] ([emp_id], [emp_name], [emp_sal]) VALUES (104, N'mansi', 22200.0000)
GO
SET IDENTITY_INSERT [dbo].[tbl_employee_salary] OFF
GO
ALTER TABLE [dbo].[tb_Login] ADD  DEFAULT ((0)) FOR [Gender]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_VALUES_IN_TABLE]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_VALUES_IN_TABLE]
@Name varchar(45),
@Gender int,
@Salary money,
@EmployeeId int out
AS
BEGIN
Insert INTO Employee(Emp_name,Emp_Gender,Salary) values (@Name , @Gender,@Salary)
SELECT @EmployeeId =SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Values_in_tb_login]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Values_in_tb_login]
@Name varchar(45),
@Email varchar(50),
@Pass bigint,
@conPass bigint,
@mobile bigint,
@gender int,
@age int,
@UserId int out
AS
BEGIN
Insert INTO tb_Login(UserName,UserEmail,UserPassword,UserConfirmPassword,Mobile,Gender,age) values (@Name ,@Email,@Pass,@conPass,@mobile,@gender,@age)
SELECT @UserId =SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spGetEmployeeAccountData]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spGetEmployeeAccountData]
as
Begin
 Select *
 from tbl_employee_salary
End
GO
/****** Object:  StoredProcedure [dbo].[spGetEmployeeAndLoginData]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spGetEmployeeAndLoginData]
as
Begin
 Select *
 from Employee

 Select *
 from tb_Login

 Select UserId,UserName,Mobile,age
 from tb_Login
End
GO
/****** Object:  StoredProcedure [dbo].[spGetEmployeeAndLoginData1]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[spGetEmployeeAndLoginData1]
as
Begin
 Select *
 from Employee


 Select UserId,UserName,Mobile,age
 from tb_Login
End
GO
/****** Object:  StoredProcedure [dbo].[spGetLogin]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spGetLogin]
@UserName varchar(45),
@Password nvarchar(50)
as
Begin
 Select * from tb_Login 
 where (UserName like @UserName + '%') AND
       (UserPassword like @Password + '%')
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTable]    Script Date: 3/3/2020 10:54:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spUpdateTable]  
@EmployeeId1 int,
@EmployeeId2 int
as  
Begin  
update tbl_employee_salary set emp_sal=emp_sal-100 where emp_id=@EmployeeId1

update tbl_employee_salary set emp_sal=emp_sal+100 where emp_id=@EmployeeId2

End
GO
