CREATE DATABASE [ASP_Assignment]
GO

USE [ASP_Assignment]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/3/2020 12:09:02 PM ******/
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
/****** Object:  Table [dbo].[tb_Login]    Script Date: 3/3/2020 12:09:02 PM ******/
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
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (1, N'Latika', 2, 200000.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (4, N'deepak', 1, 12345.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (5, N'anish', 1, 1233.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (6, N'mehak', 2, 12421.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (7, N'shagun', 2, 12213.0000)
GO
INSERT [dbo].[Employee] ([Emp_id], [Emp_name], [Emp_Gender], [Salary]) VALUES (9, N'deepika', 2, 1234.0000)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[tb_Login] ON 
GO
INSERT [dbo].[tb_Login] ([UserId], [UserName], [UserEmail], [UserPassword], [UserConfirmPassword], [Mobile], [Gender], [age]) VALUES (100, N'Latika', N'latika@tothenew.com', 1234, 1234, 9871333273, 2, 23)
GO
SET IDENTITY_INSERT [dbo].[tb_Login] OFF
GO
ALTER TABLE [dbo].[tb_Login] ADD  DEFAULT ((0)) FOR [Gender]
GO
/****** Object:  StoredProcedure [dbo].[SP_INNSERT_VALUES_IN_TABLE]    Script Date: 3/3/2020 12:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INNSERT_VALUES_IN_TABLE]
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
/****** Object:  StoredProcedure [dbo].[SP_Insert_Values_in_tb_login]    Script Date: 3/3/2020 12:09:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spGetLigin]    Script Date: 3/3/2020 12:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spGetLigin]
@UserName nvarchar(50),
@Password bigint
as
Begin
 Select * from tb_Login 
 where (UserName like @UserName + '%') AND
       (UserPassword like @Password + '%')
End
GO
/****** Object:  StoredProcedure [dbo].[spGetLogin]    Script Date: 3/3/2020 12:09:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[spGetLogin]
@UserName varchar(45),
@Password nvarchar(50)
as
Begin
 Select * from tb_Login 
 where (UserName like @UserName + '%') AND
       (UserPassword like @Password + '%')
End
GO

