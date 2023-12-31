USE [master]
GO
/****** Object:  Database [FUStoreDB]    Script Date: 4/11/2023 11:54:52 AM ******/
CREATE DATABASE [FUStoreDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FUStoreDB', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FUStoreDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FUStoreDB_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\FUStoreDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FUStoreDB] SET COMPATIBILITY_LEVEL = 160
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
ALTER DATABASE [FUStoreDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FUStoreDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FUStoreDB', N'ON'
GO
ALTER DATABASE [FUStoreDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [FUStoreDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FUStoreDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/11/2023 11:54:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](40) NOT NULL,
 CONSTRAINT [PK__Category__19093A0B07DC022F] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 4/11/2023 11:54:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Role] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 4/11/2023 11:54:53 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 4/11/2023 11:54:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/11/2023 11:54:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
 CONSTRAINT [PK__Product__B40CC6CDBE453656] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Food')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Drink')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Fastfood')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (6, N'Normal food')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Email], [Role], [City], [Country], [Password]) VALUES (1, N'hiep@gmail.com', N'USER', N'HCM', N'Viet nam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [Role], [City], [Country], [Password]) VALUES (2, N'trung@gmail.com', N'ADMIN', N'HCM', N'Vietnam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [Role], [City], [Country], [Password]) VALUES (3, N'dang@gmail.com', N'ADMIN', N'HCM', N'Vietnam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [Role], [City], [Country], [Password]) VALUES (4, N'kiet@gmail.com', N'USER', N'HCMC', N'Vietnam', N'1')
INSERT [dbo].[Member] ([MemberId], [Email], [Role], [City], [Country], [Password]) VALUES (6, N'hoang@gmail.com', N'USER', N'HCM', N'Vietnam', N'1')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (4665, 1, CAST(N'2023-11-05T12:05:07.677' AS DateTime), CAST(N'2023-11-04T00:00:00.000' AS DateTime), CAST(N'2023-11-05T00:00:00.000' AS DateTime), 10000.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (6113, 2, CAST(N'2023-11-05T14:04:07.950' AS DateTime), CAST(N'2023-11-04T00:00:00.000' AS DateTime), CAST(N'2023-11-05T00:00:00.000' AS DateTime), 20000.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (6259, 1, CAST(N'2023-11-05T14:02:50.557' AS DateTime), CAST(N'2023-11-06T00:00:00.000' AS DateTime), CAST(N'2023-11-07T00:00:00.000' AS DateTime), 15000.0000)
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (191312825, 3, 15000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (327641527, 5, 15000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (353890232, 3, 15000.0000, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (403076448, 2, 30000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (410067150, 2, 30000.0000, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (708428868, 3, 15000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (851550752, 2, 30000.0000, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1075527985, 3, 15000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1270473137, 3, 15000.0000, 3, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1310006139, 4, 10000.0000, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1387431949, 2, 30000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1431637043, 4, 10000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1498064774, 5, 15000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1636270385, 3, 15000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1751239744, 1, 20000.0000, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1829812037, 3, 15000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1887924067, 2, 30000.0000, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1951454410, 1, 20000.0000, 4, 1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1963605547, 1, 20000.0000, 1, 1)
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'Candy', N'500g', 20000.0000, 19)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 1, N'Mixed Candy', N'270g', 30000.0000, 22)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 2, N'Cake', N'200g', 12000.0000, 40)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'Pepsi', N'250ml', 15000.0000, 45)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 4, N'Snack Oshi''s', N'100g', 15000.0000, 31)
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Produ__403A8C7D] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Produ__403A8C7D]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Produ__412EB0B6] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Produ__412EB0B6]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK__Product__Categor__4222D4EF] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK__Product__Categor__4222D4EF]
GO
USE [master]
GO
ALTER DATABASE [FUStoreDB] SET  READ_WRITE 
GO
