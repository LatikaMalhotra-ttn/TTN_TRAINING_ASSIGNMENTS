USE [entity_database_first_approch]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 3/21/2020 12:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Gender] [varchar](10) NULL,
	[Location] [varchar](100) NULL,
	[Zip_Pin] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblOrder]    Script Date: 3/21/2020 12:12:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[ProductId] [int] NULL,
	[OrderStatus] [bit] NULL,
	[Order_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProduct]    Script Date: 3/21/2020 12:12:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[BrandName] [varchar](50) NULL,
	[Price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCustomer] ON 
GO
INSERT [dbo].[tblCustomer] ([Id], [FirstName], [LastName], [Gender], [Location], [Zip_Pin]) VALUES (1, N'latika', N'malhotra', N'female', N'vikas-puri', 110018)
GO
INSERT [dbo].[tblCustomer] ([Id], [FirstName], [LastName], [Gender], [Location], [Zip_Pin]) VALUES (2, N'deepak', N'kalra', N'male', N'rohini', 110056)
GO
INSERT [dbo].[tblCustomer] ([Id], [FirstName], [LastName], [Gender], [Location], [Zip_Pin]) VALUES (3, N'dimple', N'duggle', N'female', N'patel nagar', 110056)
GO
INSERT [dbo].[tblCustomer] ([Id], [FirstName], [LastName], [Gender], [Location], [Zip_Pin]) VALUES (4, N'gitika', N'sachdeva', N'female', N'uttam-nagar', 110043)
GO
INSERT [dbo].[tblCustomer] ([Id], [FirstName], [LastName], [Gender], [Location], [Zip_Pin]) VALUES (5, N'shagun', N'gupta', N'female', N'janakpuri', 110095)
GO
INSERT [dbo].[tblCustomer] ([Id], [FirstName], [LastName], [Gender], [Location], [Zip_Pin]) VALUES (7, N'sonal', N'kapoor', N'female', N'uttar pradesh', 200018)
GO
INSERT [dbo].[tblCustomer] ([Id], [FirstName], [LastName], [Gender], [Location], [Zip_Pin]) VALUES (8, N'shubham', N'sachdeva', N'male', N'shadra', 110034)
GO
SET IDENTITY_INSERT [dbo].[tblCustomer] OFF
GO
SET IDENTITY_INSERT [dbo].[tblOrder] ON 
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (1, 2, 1, 1, CAST(N'2020-02-11' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (2, 1, 3, 0, CAST(N'2020-03-19' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (3, 2, 4, 1, CAST(N'2020-02-19' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (4, 2, 5, 1, CAST(N'2020-02-17' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (5, 2, 6, 1, CAST(N'2020-02-14' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (6, 3, 1, 0, CAST(N'2020-03-19' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (7, 4, 2, 1, CAST(N'2020-02-11' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (8, 5, 3, 0, CAST(N'2020-03-19' AS Date))
GO
INSERT [dbo].[tblOrder] ([Id], [CustomerId], [ProductId], [OrderStatus], [Order_date]) VALUES (10, 1, 2, 1, CAST(N'2020-03-11' AS Date))
GO
SET IDENTITY_INSERT [dbo].[tblOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[tblProduct] ON 
GO
INSERT [dbo].[tblProduct] ([Id], [ProductName], [BrandName], [Price]) VALUES (1, N'Phone', N'Apple', 100000)
GO
INSERT [dbo].[tblProduct] ([Id], [ProductName], [BrandName], [Price]) VALUES (2, N'Refrigerator', N'LG', 50000)
GO
INSERT [dbo].[tblProduct] ([Id], [ProductName], [BrandName], [Price]) VALUES (3, N'TV', N'Samsung', 12000)
GO
INSERT [dbo].[tblProduct] ([Id], [ProductName], [BrandName], [Price]) VALUES (4, N'Radio', N'MI', 2000)
GO
INSERT [dbo].[tblProduct] ([Id], [ProductName], [BrandName], [Price]) VALUES (5, N'Headphone', N'JBL', 3000)
GO
INSERT [dbo].[tblProduct] ([Id], [ProductName], [BrandName], [Price]) VALUES (6, N'Speaker', N'JBL', 5000)
GO
SET IDENTITY_INSERT [dbo].[tblProduct] OFF
GO
ALTER TABLE [dbo].[tblOrder]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[tblCustomer] ([Id])
GO
ALTER TABLE [dbo].[tblOrder]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[tblProduct] ([Id])
GO
