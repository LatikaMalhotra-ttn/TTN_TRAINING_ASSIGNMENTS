CREATE DATABASE [EmployeeDB]
GO

USE [EmployeeDB]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/9/2020 3:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (1, N'latika', N'malhotra', N'female', 600000.0000)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (3, N'rahul', N'aaaa', N'female', 700000.0000)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (5, N'dimple', N'duggal', N'female', 900000.0000)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (8, N'hina', N'setia', N'female', 200000.0000)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (9, N'geetangali', N'sachdeva', N'female', 680000.0000)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (10, N'punita', N'yadav', N'female', 29999.0000)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (11, N'shagun', N'gupta', N'female', 400000.0000)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [LastName], [Gender], [Salary]) VALUES (12, N'adarsh', N'gupta', N'male', 400000.0000)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_values]    Script Date: 3/9/2020 3:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_delete_values]
@EmpId int
AS
BEGIN
delete from Employees where ID=@EmpId;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_values]    Script Date: 3/9/2020 3:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insert_values]
@FirstName  nvarchar(50),
@Lastname nvarchar(50),
@Gender nvarchar(50),
@Salary nvarchar(50)
AS
BEGIN
INSERT INTO Employees VALUES(@FirstName,@LastName,@Gender,@Salary)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_values]    Script Date: 3/9/2020 3:58:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_update_values]
@FirstName  varchar(50),
@Lastname varchar(50),
@Emp_id int
AS
BEGIN
Update Employees 
SET FirstName=@FirstName ,
LastName=@Lastname
Where Id=@Emp_id
END
GO

