USE [Baitaplon]
GO
/****** Object:  Table [dbo].[Acount]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acount](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](100) NULL,
	[password] [nvarchar](20) NULL,
	[role] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
	[Discription] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [nvarchar](10) NOT NULL,
	[ContactName] [nvarchar](100) NULL,
	[Address] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepId] [int] IDENTITY(1,1) NOT NULL,
	[DepName] [nvarchar](100) NOT NULL,
	[TotalEmployee] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[DepId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [nvarchar](20) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](100) NULL,
	[Address] [nvarchar](100) NULL,
	[DateStart] [datetime] NULL,
	[EndStart] [datetime] NULL,
	[DepId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [nvarchar](10) NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Size] [nvarchar](5) NULL,
	[Discount] [float] NULL,
	[NodeCustom] [nvarchar](100) NULL,
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [nvarchar](10) NOT NULL,
	[CustomerId] [nvarchar](10) NULL,
	[EmployeeId] [nvarchar](20) NULL,
	[OrderDate] [datetime] NULL,
	[RequiredDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/11/2021 2:00:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[Price] [float] NULL,
	[CategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Acount] ON 

INSERT [dbo].[Acount] ([id], [username], [password], [role]) VALUES (1, N'AdminRoot', N'123456', N'ADMIN')
INSERT [dbo].[Acount] ([id], [username], [password], [role]) VALUES (2, N'PhamDuyen', N'123456789', N'CASHIER')
SET IDENTITY_INSERT [dbo].[Acount] OFF
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Discription]) VALUES (0, N'Sinh tố', N'Nước ép')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Discription]) VALUES (1, N'Trà thơm', N'Trà')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Discription]) VALUES (2, N'Bánh ', N'Bánh')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Discription]) VALUES (3, N'Cafe', N'Cafe')
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Discription]) VALUES (4, N'Nước ngọt', N'Nước giải khát')
INSERT [dbo].[Customers] ([CustomerId], [ContactName], [Address], [Phone]) VALUES (N'C01', N'Duyên Phạm', N'Thái Bình', N'09878623')
INSERT [dbo].[Customers] ([CustomerId], [ContactName], [Address], [Phone]) VALUES (N'C02', N'Nguyễn Nhung', N'Hà Nội', N'0989876786')
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DepId], [DepName], [TotalEmployee]) VALUES (1, N'Quản lý', 2)
INSERT [dbo].[Department] ([DepId], [DepName], [TotalEmployee]) VALUES (2, N'Nhân viên', 20)
SET IDENTITY_INSERT [dbo].[Department] OFF
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Email], [Phone], [Address], [DateStart], [EndStart], [DepId]) VALUES (N'NV01', N'Phạm Thái Anh A', N'phamanh@gmail.com', N'09867328', N'Thái Bình', CAST(N'2021-04-14 20:30:00.000' AS DateTime), CAST(N'2021-04-14 22:30:00.000' AS DateTime), 2)
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Email], [Phone], [Address], [DateStart], [EndStart], [DepId]) VALUES (N'nv02', N'Nguyễn Văn A', N'a123@gmail.com', N'0987656754', N'Nam Định', CAST(N'2021-04-14 20:30:00.000' AS DateTime), CAST(N'2021-04-14 22:30:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [Quantity], [Size], [Discount], [NodeCustom], [STT], [Price]) VALUES (N'122', 3, 1, N'L', 3, N'Mlem mlem', 4, NULL)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [Quantity], [Size], [Discount], [NodeCustom], [STT], [Price]) VALUES (N'122', 4, 2, N'M', 0, N'ổn à', 5, NULL)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [Quantity], [Size], [Discount], [NodeCustom], [STT], [Price]) VALUES (N'O1', 6, 1, N'L', 5, N'mlem mlem', 6, NULL)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [Quantity], [Size], [Discount], [NodeCustom], [STT], [Price]) VALUES (N'122', 5, 1, N'M', 0, N'Ngon', 7, NULL)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [Quantity], [Size], [Discount], [NodeCustom], [STT], [Price]) VALUES (N'122', 3, 1, N'S', 0, N'okk', 8, NULL)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [RequiredDate]) VALUES (N'122', N'C01', N'NV01', CAST(N'2021-04-15 14:33:15.173' AS DateTime), CAST(N'2021-04-15 14:33:15.180' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [RequiredDate]) VALUES (N'A12', N'C02', N'NV01', CAST(N'2021-04-22 21:34:51.307' AS DateTime), CAST(N'2021-04-22 21:34:51.310' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [RequiredDate]) VALUES (N'O01', N'C01', N'nv02', CAST(N'2021-04-15 14:32:01.970' AS DateTime), CAST(N'2021-04-15 14:32:01.987' AS DateTime))
INSERT [dbo].[Orders] ([OrderId], [CustomerId], [EmployeeId], [OrderDate], [RequiredDate]) VALUES (N'O1', N'C01', N'NV01', CAST(N'2021-04-15 14:30:25.980' AS DateTime), CAST(N'2021-04-15 14:30:25.990' AS DateTime))
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [CategoryId]) VALUES (1, N'Trà xanh', 10000, 1)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [CategoryId]) VALUES (2, N'Trà thái', 12000, 1)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [CategoryId]) VALUES (3, N'Cafe đen', 15000, 3)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [CategoryId]) VALUES (4, N'Cafe sữa', 21000, 3)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [CategoryId]) VALUES (5, N'Bánh trứng', 20000, 2)
INSERT [dbo].[Product] ([ProductId], [ProductName], [Price], [CategoryId]) VALUES (6, N'7up', 12000, 4)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Departme__CFE04C24B040C268]    Script Date: 8/11/2021 2:00:54 PM ******/
ALTER TABLE [dbo].[Department] ADD UNIQUE NONCLUSTERED 
(
	[DepName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DepId])
REFERENCES [dbo].[Department] ([DepId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
