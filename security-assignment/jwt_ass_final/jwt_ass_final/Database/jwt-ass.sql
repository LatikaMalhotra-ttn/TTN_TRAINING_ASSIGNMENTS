USE [jwt_ass]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 3/18/2020 12:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[LoginId] [nvarchar](100) NULL,
	[UserName] [nvarchar](100) NULL,
	[UserPass] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[RoleId] [int] NOT NULL,
	[IsActive] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 3/18/2020 12:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON 
GO
INSERT [dbo].[UserInfo] ([UserId], [LoginId], [UserName], [UserPass], [Email], [RoleId], [IsActive]) VALUES (1, N'admin', N'administrator', N'123', N'admin@gmail.com', 1, 1)
GO
INSERT [dbo].[UserInfo] ([UserId], [LoginId], [UserName], [UserPass], [Email], [RoleId], [IsActive]) VALUES (2, N'user', N'general uuser', N'123', N'user@gmail.com', 2, 1)
GO
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRole] ON 
GO
INSERT [dbo].[UserRole] ([RoleId], [RoleName]) VALUES (1, N'administrator')
GO
INSERT [dbo].[UserRole] ([RoleId], [RoleName]) VALUES (2, N'user')
GO
SET IDENTITY_INSERT [dbo].[UserRole] OFF
GO
