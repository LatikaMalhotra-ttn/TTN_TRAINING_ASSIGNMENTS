USE [EmployeeDB]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/11/2020 5:53:09 PM ******/
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
/****** Object:  Table [dbo].[Users]    Script Date: 4/11/2020 5:53:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_values]    Script Date: 4/11/2020 5:53:09 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_insert_values]    Script Date: 4/11/2020 5:53:09 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 4/11/2020 5:53:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login]
@username nvarchar(100),
@password nvarchar(100)
as
Begin
	Select Count(Id) FROM Users Where Username=@username and Password=@password
End
GO
/****** Object:  StoredProcedure [dbo].[sp_update_values]    Script Date: 4/11/2020 5:53:09 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spUserLogin]    Script Date: 4/11/2020 5:53:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUserLogin] 
@username nvarchar(100),
@password nvarchar(100),
@output nvarchar(100) OUTPUT
AS
BEGIN
	SET @output=(Select Email FROM Users Where Username=@username and Password=@password )
	RETURN @output
END
GO
