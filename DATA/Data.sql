USE [master]
GO
/****** Object:  Database [QuanLyQuanCafe]    Script Date: 30/08/2024 16:05:27 ******/
CREATE DATABASE [QuanLyQuanCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyQuanCafe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyQuanCafe]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[Username] [varchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[AccountType] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILL]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TimeCheckIn] [datetime] NOT NULL,
	[TimeCheckOut] [datetime] NULL,
	[TableID] [int] NOT NULL,
	[Status] [bit] NULL,
	[Discount] [int] NULL,
	[TotalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BILL_INFOMATION]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BILL_INFOMATION](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillID] [int] NOT NULL,
	[DrinkID] [int] NOT NULL,
	[Count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DRINK_CATEGORY]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DRINK_CATEGORY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DRINKS]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DRINKS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[DrinkCategoryID] [int] NOT NULL,
	[Price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLES]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TableNumber] [nvarchar](100) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([Username], [DisplayName], [Password], [AccountType]) VALUES (N'ADMIN1000', N'Nguyễn Quang Duy', N'ADMIN123', N'ADMIN')
INSERT [dbo].[ACCOUNT] ([Username], [DisplayName], [Password], [AccountType]) VALUES (N'Canhnguyendz', N'Cảnh Nguyễn', N'nvc123314', N'STAFF')
INSERT [dbo].[ACCOUNT] ([Username], [DisplayName], [Password], [AccountType]) VALUES (N'phuong2109', N'Phươngg Phươngg', N'phuongkutephomaiwe', N'STAFF')
INSERT [dbo].[ACCOUNT] ([Username], [DisplayName], [Password], [AccountType]) VALUES (N'phuongvoik4', N'Hà Phương', N'Cafe123', N'STAFF')
INSERT [dbo].[ACCOUNT] ([Username], [DisplayName], [Password], [AccountType]) VALUES (N'TBGTruongk4', N'Trường Nhật', N'Truongdzkosai', N'ADMIN')
INSERT [dbo].[ACCOUNT] ([Username], [DisplayName], [Password], [AccountType]) VALUES (N'tu2004', N'Vũ Kim Tú', N'Cafe123', N'STAFF')
GO
SET IDENTITY_INSERT [dbo].[BILL] ON 

INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (66, CAST(N'2024-08-26T10:20:56.660' AS DateTime), CAST(N'2024-08-26T11:19:17.870' AS DateTime), 2, 1, 50, 12500)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (69, CAST(N'2024-08-26T11:49:02.783' AS DateTime), CAST(N'2024-08-26T11:49:15.707' AS DateTime), 6, 1, 0, 35000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (70, CAST(N'2024-08-26T11:54:53.383' AS DateTime), CAST(N'2024-08-26T14:26:59.297' AS DateTime), 30, 1, 0, 30000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (71, CAST(N'2024-08-26T11:55:02.370' AS DateTime), CAST(N'2024-08-26T13:58:39.130' AS DateTime), 6, 1, 0, 130000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (72, CAST(N'2024-08-26T11:55:37.787' AS DateTime), CAST(N'2024-08-26T11:55:51.853' AS DateTime), 2, 1, 90, 3000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (73, CAST(N'2024-08-26T14:26:38.363' AS DateTime), CAST(N'2024-08-26T16:40:25.487' AS DateTime), 19, 1, 0, 40000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (74, CAST(N'2024-08-26T14:35:02.200' AS DateTime), CAST(N'2024-08-26T16:38:00.590' AS DateTime), 9, 1, 0, 60000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (75, CAST(N'2024-08-26T16:37:43.393' AS DateTime), CAST(N'2024-08-26T21:03:03.797' AS DateTime), 3, 1, 0, 140000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (76, CAST(N'2024-08-26T21:02:56.647' AS DateTime), CAST(N'2024-08-26T21:21:24.050' AS DateTime), 29, 1, 0, 70000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (77, CAST(N'2024-08-26T21:03:08.440' AS DateTime), CAST(N'2024-08-26T21:20:41.667' AS DateTime), 9, 1, 0, 115000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (78, CAST(N'2024-08-26T21:03:27.963' AS DateTime), CAST(N'2024-08-26T21:20:53.967' AS DateTime), 10, 1, 0, 65000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (79, CAST(N'2024-08-26T21:03:41.357' AS DateTime), CAST(N'2024-08-26T21:20:28.717' AS DateTime), 2, 1, 0, 80000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (80, CAST(N'2024-08-26T21:58:46.517' AS DateTime), CAST(N'2024-08-26T23:12:52.490' AS DateTime), 5, 1, 0, 40000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (81, CAST(N'2024-08-26T21:58:54.160' AS DateTime), CAST(N'2024-08-26T23:13:26.913' AS DateTime), 26, 1, 0, 70000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (82, CAST(N'2024-08-26T21:59:00.523' AS DateTime), CAST(N'2024-08-26T23:13:04.453' AS DateTime), 10, 1, 0, 60000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (83, CAST(N'2024-08-26T21:59:09.500' AS DateTime), CAST(N'2024-08-26T23:13:21.900' AS DateTime), 25, 1, 0, 45000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (84, CAST(N'2024-08-26T21:59:40.013' AS DateTime), CAST(N'2024-08-26T23:13:10.690' AS DateTime), 19, 1, 0, 105000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (85, CAST(N'2024-08-27T10:54:20.973' AS DateTime), CAST(N'2024-08-27T23:13:39.760' AS DateTime), 34, 1, 0, 105000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (86, CAST(N'2024-08-27T10:54:43.457' AS DateTime), CAST(N'2024-08-27T12:10:16.180' AS DateTime), 2, 1, 0, 115000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (87, CAST(N'2024-08-27T10:55:10.837' AS DateTime), CAST(N'2024-08-27T11:36:31.460' AS DateTime), 6, 1, 0, 85000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (88, CAST(N'2024-08-27T10:58:31.287' AS DateTime), CAST(N'2024-08-27T12:25:46.897' AS DateTime), 19, 1, 0, 105000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (89, CAST(N'2024-08-27T11:01:27.063' AS DateTime), CAST(N'2024-08-27T12:25:16.840' AS DateTime), 12, 1, 0, 35000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (90, CAST(N'2024-08-27T11:01:32.460' AS DateTime), CAST(N'2024-08-27T16:12:01.233' AS DateTime), 2, 1, 0, 70000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (91, CAST(N'2024-08-27T12:25:31.083' AS DateTime), CAST(N'2024-08-27T15:21:22.723' AS DateTime), 26, 1, 0, 115000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (92, CAST(N'2024-08-27T15:21:04.833' AS DateTime), CAST(N'2024-08-27T23:07:54.920' AS DateTime), 7, 1, 0, 115000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (94, CAST(N'2024-08-27T15:33:12.190' AS DateTime), CAST(N'2024-08-27T21:27:49.233' AS DateTime), 15, 1, 0, 60000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (96, CAST(N'2024-08-27T16:12:14.550' AS DateTime), CAST(N'2024-08-27T17:20:22.193' AS DateTime), 5, 1, 0, 95000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (97, CAST(N'2024-08-27T21:29:43.083' AS DateTime), CAST(N'2024-08-27T23:13:51.433' AS DateTime), 25, 1, 20, 120000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (100, CAST(N'2024-08-28T12:02:48.647' AS DateTime), CAST(N'2024-08-28T23:36:28.327' AS DateTime), 7, 1, 0, 60000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (101, CAST(N'2024-08-28T17:22:07.980' AS DateTime), CAST(N'2024-08-28T23:36:32.347' AS DateTime), 26, 1, 0, 40000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (102, CAST(N'2024-08-29T09:21:38.523' AS DateTime), CAST(N'2024-08-29T11:07:58.473' AS DateTime), 25, 1, 100, 0)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (103, CAST(N'2024-08-29T09:33:35.983' AS DateTime), CAST(N'2024-08-29T11:07:28.580' AS DateTime), 16, 1, 0, 85000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (104, CAST(N'2024-08-29T10:01:07.827' AS DateTime), CAST(N'2024-08-29T10:15:30.780' AS DateTime), 2, 1, 10, 94500)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (105, CAST(N'2024-08-29T15:05:44.900' AS DateTime), CAST(N'2024-08-29T23:12:30.970' AS DateTime), 3, 1, 0, 60000)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (106, CAST(N'2024-08-30T11:05:56.277' AS DateTime), NULL, 12, 0, 0, NULL)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (107, CAST(N'2024-08-30T13:59:36.130' AS DateTime), NULL, 3, 0, 0, NULL)
INSERT [dbo].[BILL] ([ID], [TimeCheckIn], [TimeCheckOut], [TableID], [Status], [Discount], [TotalPrice]) VALUES (108, CAST(N'2024-08-30T13:59:43.490' AS DateTime), NULL, 20, 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[BILL] OFF
GO
SET IDENTITY_INSERT [dbo].[BILL_INFOMATION] ON 

INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (99, 66, 53, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (103, 69, 71, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (104, 70, 16, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (105, 71, 22, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (106, 71, 24, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (107, 72, 54, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (108, 73, 13, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (109, 74, 53, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (110, 74, 55, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (111, 75, 62, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (112, 75, 54, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (113, 76, 38, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (114, 77, 43, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (115, 77, 55, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (116, 78, 77, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (117, 78, 61, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (118, 79, 18, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (119, 80, 61, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (120, 81, 39, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (121, 82, 69, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (122, 83, 48, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (123, 84, 55, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (124, 84, 56, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (125, 85, 53, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (126, 86, 55, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (127, 86, 54, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (128, 87, 22, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (129, 88, 61, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (130, 86, 73, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (131, 88, 62, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (132, 88, 75, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (133, 87, 68, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (134, 89, 72, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (135, 90, 72, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (136, 90, 70, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (137, 91, 13, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (138, 91, 78, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (139, 85, 68, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (140, 92, 13, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (141, 85, 38, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (142, 92, 78, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (143, 92, 61, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (144, 94, 54, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (146, 96, 39, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (147, 96, 53, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (148, 97, 55, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (150, 97, 61, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (152, 100, 53, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (153, 100, 55, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (154, 101, 61, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (155, 102, 53, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (156, 103, 23, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (157, 103, 61, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (158, 104, 53, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (159, 104, 54, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (160, 104, 73, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (161, 105, 54, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (162, 106, 61, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (163, 107, 71, 2)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (164, 108, 22, 1)
INSERT [dbo].[BILL_INFOMATION] ([ID], [BillID], [DrinkID], [Count]) VALUES (165, 108, 48, 1)
SET IDENTITY_INSERT [dbo].[BILL_INFOMATION] OFF
GO
SET IDENTITY_INSERT [dbo].[DRINK_CATEGORY] ON 

INSERT [dbo].[DRINK_CATEGORY] ([ID], [Name]) VALUES (4, N'Nước ép')
INSERT [dbo].[DRINK_CATEGORY] ([ID], [Name]) VALUES (5, N'Trà sữa')
INSERT [dbo].[DRINK_CATEGORY] ([ID], [Name]) VALUES (7, N'Trà')
INSERT [dbo].[DRINK_CATEGORY] ([ID], [Name]) VALUES (10, N'Cafe')
INSERT [dbo].[DRINK_CATEGORY] ([ID], [Name]) VALUES (11, N'Sinh tố')
INSERT [dbo].[DRINK_CATEGORY] ([ID], [Name]) VALUES (12, N'Sữa chua')
INSERT [dbo].[DRINK_CATEGORY] ([ID], [Name]) VALUES (13, N'Ăn vặt')
SET IDENTITY_INSERT [dbo].[DRINK_CATEGORY] OFF
GO
SET IDENTITY_INSERT [dbo].[DRINKS] ON 

INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (13, N'Nước ép cam', 4, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (14, N'Nước ép cam dứa', 4, 45000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (15, N'Nước ép cam cà rốt', 4, 45000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (16, N'Nước ép chanh tươi', 4, 30000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (18, N'Nước ép dưa hấu', 4, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (22, N'Trà sữa thái', 5, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (23, N'Matcha đá xay', 5, 45000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (24, N'Matcha kem trứng', 5, 50000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (38, N'Trà nhài ổi hồng', 7, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (39, N'Trà sen vàng lá nếp', 7, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (40, N'Trà mạn', 7, 25000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (41, N'Trà cam quế đào', 7, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (43, N'Trà Olong vải', 7, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (44, N'Trà vải hoa hồng', 7, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (47, N'Trà đào cam xả', 7, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (48, N'Trà sữa trân trâu đường đen', 5, 45000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (50, N'Nước ép chanh leo ', 4, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (53, N'Cà phê đen', 10, 25000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (54, N'Cà phê sữa', 10, 30000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (55, N'Bạc xỉu', 10, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (56, N'Cacao sữa', 10, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (57, N'Cà phê kem muối', 10, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (58, N'Cà phê kem trứng', 10, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (59, N'Cà phê cốt dừa', 10, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (60, N'Cà phê chai', 10, 99000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (61, N'Sinh tố bơ', 11, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (62, N'Sinh tố mãng cầu', 11, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (63, N'Sinh tố dâu tây', 11, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (64, N'Bơ dầm', 11, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (65, N'Sinh tố xoài', 11, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (66, N'Sinh tố chanh leo', 11, 40000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (67, N'Cappuccino', 10, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (68, N'Trà sữa nướng', 5, 45000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (69, N'Sữa chua thạch', 12, 30000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (70, N'Sữa chua cà phê', 12, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (71, N'Sữa chua hoa quả', 12, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (72, N'Sữa chua việt quất', 12, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (73, N'Hướng dương', 13, 20000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (74, N'Bò khô', 13, 30000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (75, N'Khô gà lá chanh', 13, 25000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (76, N'Khoai tây lắc phô mai', 13, 25000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (77, N'Sữa chua dầm đá', 12, 25000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (78, N'Nước ép ổi', 4, 35000)
INSERT [dbo].[DRINKS] ([ID], [Name], [DrinkCategoryID], [Price]) VALUES (79, N'Trà cúc mật ong', 7, 40000)
SET IDENTITY_INSERT [dbo].[DRINKS] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLES] ON 

INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (2, N'Bàn 2', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (3, N'Bàn 3', N'Có khách')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (4, N'Bàn 22', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (5, N'Bàn 32', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (6, N'Bàn 6', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (7, N'Bàn 7', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (8, N'Bàn 8', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (9, N'Bàn 9', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (10, N'Bàn 10', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (11, N'Bàn 11', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (12, N'Bàn 12', N'Có khách')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (13, N'Bàn 13', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (15, N'Bàn 15', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (16, N'Bàn 16', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (17, N'Bàn 17', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (18, N'Bàn 18', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (19, N'Bàn 19', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (20, N'Bàn 20', N'Có khách')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (21, N'Bàn 21', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (22, N'Bàn 23', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (24, N'Bàn 24', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (25, N'Bàn 25', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (26, N'Bàn 26', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (27, N'Bàn 27', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (28, N'Bàn 28', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (29, N'Bàn 29', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (30, N'Bàn 30', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (32, N'Bàn 1', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (33, N'Bàn 35', N'Trống')
INSERT [dbo].[TABLES] ([ID], [TableNumber], [Status]) VALUES (34, N'Bàn 34', N'Trống')
SET IDENTITY_INSERT [dbo].[TABLES] OFF
GO
ALTER TABLE [dbo].[ACCOUNT] ADD  DEFAULT ('???') FOR [Username]
GO
ALTER TABLE [dbo].[ACCOUNT] ADD  DEFAULT ('Cafe123') FOR [Password]
GO
ALTER TABLE [dbo].[BILL] ADD  DEFAULT (getdate()) FOR [TimeCheckIn]
GO
ALTER TABLE [dbo].[BILL] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[BILL] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[BILL_INFOMATION] ADD  DEFAULT ((0)) FOR [Count]
GO
ALTER TABLE [dbo].[TABLES] ADD  DEFAULT (N'TRỐNG') FOR [Status]
GO
ALTER TABLE [dbo].[BILL]  WITH CHECK ADD FOREIGN KEY([TableID])
REFERENCES [dbo].[TABLES] ([ID])
GO
ALTER TABLE [dbo].[BILL_INFOMATION]  WITH CHECK ADD FOREIGN KEY([BillID])
REFERENCES [dbo].[BILL] ([ID])
GO
ALTER TABLE [dbo].[BILL_INFOMATION]  WITH CHECK ADD FOREIGN KEY([DrinkID])
REFERENCES [dbo].[DRINKS] ([ID])
GO
ALTER TABLE [dbo].[DRINKS]  WITH CHECK ADD FOREIGN KEY([DrinkCategoryID])
REFERENCES [dbo].[DRINK_CATEGORY] ([ID])
GO
/****** Object:  StoredProcedure [dbo].[SP_AddAccount]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddAccount]
@USERNAME varchar(100), @DISPLAYNAME NVARCHAR(100), @ACCOUNTTYPE VARCHAR(50)
AS
BEGIN	
     DECLARE @CNT INT = 0
	 SELECT @CNT = COUNT(*) FROM ACCOUNT WHERE Username = @USERNAME AND DisplayName = @DISPLAYNAME
	 IF @CNT = 0
	 INSERT INTO ACCOUNT (username, displayname ,accounttype) VALUES (@USERNAME, @DISPLAYNAME, @ACCOUNTTYPE)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AddBill]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddBill]
@IDTable int, @cnt int
as
begin
      if(@cnt > 0)
	  BEGIN
		   INSERT INTO BILL (TimeCheckIn, TimeCheckOut, TableID, Status)
		   VALUES(GETDATE(), NULL, @IDTable, 0)
	  END
end
GO
/****** Object:  StoredProcedure [dbo].[SP_AddOrUpdateBillinfor]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AddOrUpdateBillinfor]
@IDBill int, @IDDrink int, @Count int
as
begin
	 DECLARE @DEM INT = 0 
	 select @DEM = COUNT(*) from BILL_INFOMATION where BillID = @IDBill and DrinkID = @IDDrink

	 --Kiểm tra xem nếu tồn tại hóa đơn thì cập nhật, ngược lại sẽ thêm mới
	 if @DEM > 0 
	 begin
	     DECLARE @CNT INT, @CurrentCount int --Lấy ra số lượng hóa đơn trước và sau khi update

		 SELECT @CNT = COUNT FROM BILL_INFOMATION where BillID = @IDBill and DrinkID = @IDDrink

		 update BILL_INFOMATION set Count = @CNT + @Count where BillID = @IDBill and DrinkID = @IDDrink

		 select @CurrentCount = count from BILL_INFOMATION where BillID = @IDBill and DrinkID = @IDDrink
		 --Nếu số lượng hóa đơn sau khi cập nhật nhỏ hơn hoặc bằng 0 thì tiến hành xóa dữ liệu
		 if @CurrentCount <= 0
			BEGIN
				 DELETE from BILL_INFOMATION where BillID = @IDBill and DrinkID = @IDDrink
				 DELETE from BILL WHERE ID = @IDBill
			END
	 end
	 else if @Count > 0
	 INSERT INTO BILL_INFOMATION VALUES(@IDBill, @IDDrink, @Count)
end

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCategory]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteCategory]
@ID int, @NAME NVARCHAR(50)
as
begin
  
      DECLARE @CHK INT = 0
      SELECT @CHK = COUNT(*) FROM DRINK_CATEGORY WHERE ID = @ID AND Name = @NAME

	  IF @CHK > 0
	  BEGIN
		--Lấy ra các iddrink cần xóa từ id category
		SELECT ID INTO DrinkIDList FROM DRINKS WHERE DrinkCategoryID = @ID

		--Lấy ra danh sách các billid chứa iddrink cần xóa
		SELECT BILLID INTO BillIDList FROM BILL_INFOMATION WHERE DrinkID IN (SELECT * FROM DrinkIDList)

		--Xóa 
		DELETE BILL_INFOMATION WHERE DrinkID IN (SELECT * FROM DrinkIDList)
		DELETE DRINKS WHERE DrinkCategoryID = @ID
		DELETE DRINK_CATEGORY WHERE ID = @ID

		--Cập nhật lại danh sách billid sau khi xóa billInfor
		--tất cả những hóa đơn có id đồ uống ko nằm trong danh sách cần xóa sẽ bị lọc ra khỏi billidlist
		SELECT BillID INTO Cur_BillIDList FROM BILL_INFOMATION WHERE BillID IN (SELECT * FROM BillIDList)
		DELETE BillIDList WHERE BillID IN (SELECT * FROM Cur_BillIDList)


		--Lấy ra danh sách bàn thuộc hóa đơn chuẩn bị xóa
		SELECT TableID INTO IDTableList FROM BILL WHERE ID IN (SELECT * FROM BillIDList)

		DELETE BILL WHERE ID IN (SELECT * FROM BillIDList) AND Status = 0

		--Cập nhật trạng thái các bàn nằm trong danh sách
		UPDATE TABLES SET Status = N'Trống' WHERE ID IN (SELECT * FROM IDTableList)

		--Giải phóng các danh sách sau khi dùng xong
		DROP TABLE BillIDList
		DROP TABLE Cur_BillIDList
		DROP TABLE DrinkIDList
		DROP TABLE IDTableList
	END
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteDrink]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteDrink] 
@ID int, @DRINKNAME nvarchar(100)
as
begin

     DECLARE @CHK INT = 0
	 SELECT @CHK = COUNT(*) FROM DRINKS WHERE ID = @ID AND Name = @DRINKNAME

	 IF @CHK > 0
	 BEGIN
		 --Lấy ra hóa đơn của đồ uống cần xóa
		 DECLARE @BILLID INT
		 SELECT @BILLID = BILLID FROM BILL_INFOMATION WHERE DrinkID = @ID

		 --Lấy ra số lượng đồ uống tương ứng với hóa đơn của đồ uống cần xóa
		 DECLARE @CNT INT
		 SELECT @CNT = COUNT(*) FROM BILL_INFOMATION WHERE BillID = @BILLID


		 delete BILL_INFOMATION where DrinkID = @ID
		 delete DRINKS where id = @ID


		 --Nếu như chỉ tồn tại duy nhất 1 đồ uống trên hóa đơn đó thì sẽ thực hiện xóa hóa đơn đó
		 IF @CNT <= 1
			DELETE BILL WHERE ID = @BILLID AND Status = 0
	END
end
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteTable]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteTable] 
@ID INT, @TABLENAME NVARCHAR(100)
AS
BEGIN
	 DECLARE @CNT INT = 0
	 SELECT @CNT = COUNT(*) FROM BILL WHERE TableID = @ID

	 IF @CNT = 0
	   DELETE TABLES WHERE ID = @ID AND TableNumber = @TABLENAME
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ExtractBill]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ExtractBill]
@ID int
as
begin
    select BillID, DRINKS.Name, BILL_INFOMATION.Count, Price, BILL_INFOMATION.Count * Price AS SUM from DRINKS join BILL_INFOMATION ON DRINKS.ID = BILL_INFOMATION.DrinkID JOIN BILL ON BILL.ID = BILL_INFOMATION.BillID WHERE TableID = @ID AND BILL.Status = 0
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetDatetimeBill]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GetDatetimeBill]
@IDTABLE INT
AS
BEGIN	
	SELECT TimeCheckIn FROM BILL JOIN TABLES ON BILL.TableID = TABLES.ID WHERE TableID = @IDTABLE AND BILL.Status = 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GetTableIDByDrinkID]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetTableIDByDrinkID]
@IDDrink int
as
begin
	    SELECT TABLES.ID 
		FROM TABLES JOIN BILL ON TABLES.ID = BILL.TableID 
		JOIN BILL_INFOMATION ON BILL.ID = BILL_INFOMATION.BillID  
		JOIN DRINKS ON BILL_INFOMATION.DrinkID = DRINKS.ID
		WHERE DRINKS.ID = @IDDrink AND BILL.Status = 0
end
GO
/****** Object:  StoredProcedure [dbo].[SP_MergeTable]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MergeTable]
@IDLeftTable int, @IDRightTable int
as
begin
	  DECLARE @IDLeftBill int, @IDRightBill int
	  SELECT @IDLeftBill = ID FROM BILL WHERE TableID = @IDLeftTable AND Status = 0
	  SELECT @IDRightBill = ID FROM BILL WHERE TableID = @IDRightTable AND Status = 0

	  UPDATE BILL_INFOMATION SET BillID = @IDRightBill WHERE BillID = @IDLeftBill
	  DELETE BILL WHERE ID = @IDLeftBill AND Status = 0

	  UPDATE TABLES SET Status = N'Trống' WHERE ID = @IDLeftTable
	  UPDATE TABLES SET Status = N'Có khách' WHERE ID = @IDRightTable
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchBill]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ALTER
CREATE PROCEDURE [dbo].[SP_SearchBill]
@In DATETIME, @Out DATETIME, @Page int
as
begin
     --Trong đó: 10 là số dòng muốn hiển thị trên 1 trang, page là trang mà người dùng chọn
	 DECLARE @PageExcept int = (@Page - 1) * 10

	 SELECT BILL.ID, TableNumber as [Tên bàn], FORMAT(TimeCheckIn, 'dd/MM/yyyy  HH:mm:ss') as [Ngày tạo hóa đơn], FORMAT(TimeCheckOut, 'dd/MM/yyyy  HH:mm:ss') as [Ngày xuất hóa đơn], CAST(Discount as varchar(3)) + '%' as [Giảm giá], FORMAT(TotalPrice , 'C0', 'vi-VN') as [Tổng tiền]
	 INTO TEMPBILL
	 FROM TABLES JOIN BILL ON TABLES.ID = BILL.TableID 
	 where BILL.Status = 1 AND TimeCheckOut >= @In AND TimeCheckOut <= @Out

	 SELECT TOP 10 * FROM TEMPBILL WHERE ID NOT IN 
	 (SELECT TOP (@PageExcept) ID FROM TEMPBILL)

	 DROP TABLE TEMPBILL
end
GO
/****** Object:  StoredProcedure [dbo].[SP_SwapTable]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SwapTable]
@IDLeftTable int, @IDRightTable int
as
begin
	  DECLARE @IDLeftBill int, @IDRightBill int
	  SELECT @IDLeftBill = ID FROM BILL WHERE TableID = @IDLeftTable AND Status = 0
	  SELECT @IDRightBill = ID FROM BILL WHERE TableID = @IDRightTable AND Status = 0

	  IF (@IDLeftBill IS NULL)
	  BEGIN

		    UPDATE BILL SET TableID = @IDLeftTable WHERE ID = @IDRightBill 
			
			--Cập nhật trạng thái cho 2 bàn sau khi chuyển 
			UPDATE TABLES SET Status = N'Trống' WHERE ID = @IDRightTable
			UPDATE TABLES SET Status = N'Có khách' WHERE ID = @IDLeftTable

	  END
	  ELSE IF (@IDRightBill IS NULL)
	  BEGIN

			UPDATE BILL SET TableID = @IDRightTable WHERE ID = @IDLeftBill 

			print 1
			--Cập nhật trạng thái cho 2 bàn sau khi chuyển 
			UPDATE TABLES SET Status = N'Trống' WHERE ID = @IDLeftTable
			UPDATE TABLES SET Status = N'Có khách' WHERE ID = @IDRightTable

	  END
      ELSE
	  BEGIN
			SELECT ID INTO TMPBillInfor from BILL_INFOMATION where BillID = @IDRightBill

			update BILL_INFOMATION set BillID = @IDRightBill WHERE BillID = @IDLeftBill

			update BILL_INFOMATION set BillID = @IDLeftBill WHERE ID IN (SELECT * FROM TMPBillInfor)

			DROP table TMPBillInfor
	  END
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TableLoad]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_TableLoad] 
as
begin
	SELECT ID, TableNumber AS [Tên bàn], Status as [Trạng thái] FROM TABLES
end
GO
/****** Object:  StoredProcedure [dbo].[SP_UserLogin]    Script Date: 30/08/2024 16:05:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UserLogin] @Username varchar(100), @Password varchar(100)
as
begin
	SELECT * FROM ACCOUNT WHERE Username = @Username AND Password = @Password
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanCafe] SET  READ_WRITE 
GO
