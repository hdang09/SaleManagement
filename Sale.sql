USE [master]
GO
/****** Object:  Database [FUStoreDB]    Script Date: 11/1/2023 7:06:13 AM ******/
CREATE DATABASE [FUStoreDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FUStoreDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FUStoreDB.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FUStoreDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FUStoreDB_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FUStoreDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FUStoreDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FUStoreDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FUStoreDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FUStoreDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FUStoreDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FUStoreDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FUStoreDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FUStoreDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FUStoreDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FUStoreDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FUStoreDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FUStoreDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FUStoreDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FUStoreDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FUStoreDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FUStoreDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FUStoreDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FUStoreDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FUStoreDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FUStoreDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FUStoreDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FUStoreDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FUStoreDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FUStoreDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FUStoreDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FUStoreDB] SET  MULTI_USER 
GO
ALTER DATABASE [FUStoreDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FUStoreDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FUStoreDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FUStoreDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FUStoreDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/1/2023 7:06:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Member]    Script Date: 11/1/2023 7:06:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11/1/2023 7:06:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[MemberId] [int] NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/1/2023 7:06:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/1/2023 7:06:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Food')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Drink')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'hiep@gmail.com', N'FPT', N'HCM', N'Viet nam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'trung@gmail.com', N'FPT', N'HCM', N'Viet nam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'dang@gmail.com', N'FPT', N'HCM', N'Viet nam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'kiet@gmail.com', N'FPT', N'HCM', N'Viet nam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'hoang@gmail.com', N'FPT', N'HCM', N'Viet nam', N'1')
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (4665, 1, CAST(N'2023-11-05 12:05:07.677' AS DateTime), CAST(N'2023-11-04 00:00:00.000' AS DateTime), CAST(N'2021-11-05 00:00:00.000' AS DateTime), 10000.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (6113, 2, CAST(N'2023-11-05 14:04:07.950' AS DateTime), CAST(N'2023-11-04 00:00:00.000' AS DateTime), CAST(N'2021-11-05 00:00:00.000' AS DateTime), 20000.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (6259, 1, CAST(N'2023-11-05 14:02:50.557' AS DateTime), CAST(N'2023-11-06 00:00:00.000' AS DateTime), CAST(N'2021-11-07 00:00:00.000' AS DateTime), 15000.0000)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (4665, 1, 20000.0000, 1, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (6113, 4, 10000.0000, 3, 10)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (6113, 5, 15000.0000, 4, 15)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (6259, 2, 300000.0000, 2, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (6259, 4, 10000.0000, 2, 5)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'Candy', N'500g', 20000.0000, 19)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 1, N'Mixed Candy', N'270g', 30000.0000, 22)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 1, N'Cake', N'200g', 15000.0000, 40)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'Pepsi', N'250ml', 10000.0000, 45)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 1, N'Snack Oshi''s', N'100g', 15000.0000, 31)
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [FUStoreDB] SET  READ_WRITE 
GO
