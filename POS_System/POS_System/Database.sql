USE [master]
GO
/****** Object:  Database [POS]    Script Date: 7/25/2018 12:09:35 AM ******/
CREATE DATABASE [POS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\POS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'POS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\POS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [POS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POS] SET ARITHABORT OFF 
GO
ALTER DATABASE [POS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [POS] SET  MULTI_USER 
GO
ALTER DATABASE [POS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [POS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [POS] SET QUERY_STORE = OFF
GO
USE [POS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [POS]
GO
/****** Object:  Table [dbo].[tbl_categories]    Script Date: 7/25/2018 12:09:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[description] [text] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_dea_cust]    Script Date: 7/25/2018 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_dea_cust](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[name] [varchar](150) NULL,
	[email] [varchar](150) NULL,
	[contact] [varchar](15) NULL,
	[address] [text] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_dea_cust] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_products]    Script Date: 7/25/2018 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[description] [text] NULL,
	[rate] [decimal](18, 2) NULL,
	[qty] [decimal](18, 2) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_transaction_detail]    Script Date: 7/25/2018 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_transaction_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[rate] [decimal](18, 2) NULL,
	[qty] [decimal](18, 2) NULL,
	[total] [decimal](18, 2) NULL,
	[dea_cust_id] [int] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tble_transaction_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_transactions]    Script Date: 7/25/2018 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[dea_cust_id] [int] NULL,
	[grandTotal] [decimal](18, 2) NULL,
	[transaction_date] [datetime] NULL,
	[tax] [decimal](18, 2) NULL,
	[discount] [decimal](18, 2) NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_users]    Script Date: 7/25/2018 12:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[email] [varchar](150) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[address] [text] NULL,
	[gender] [varchar](10) NULL,
	[user_type] [varchar](15) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_users] SET (LOCK_ESCALATION = DISABLE)
GO
SET IDENTITY_INSERT [dbo].[tbl_categories] ON 

INSERT [dbo].[tbl_categories] ([id], [title], [description], [added_date], [added_by]) VALUES (1, N'Food', N'Food Items Here', CAST(N'2018-07-19T09:46:49.737' AS DateTime), 0)
INSERT [dbo].[tbl_categories] ([id], [title], [description], [added_date], [added_by]) VALUES (3, N'Drink', N'Drink Itemes Here
', CAST(N'2018-07-19T10:17:32.590' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tbl_categories] OFF
SET IDENTITY_INSERT [dbo].[tbl_dea_cust] ON 

INSERT [dbo].[tbl_dea_cust] ([id], [type], [name], [email], [contact], [address], [added_date], [added_by]) VALUES (1, N'Customer', N'M Nawaz', N'Example@POS.com', N'03041596991', N'Sahiwal
', CAST(N'2018-07-21T03:51:50.740' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tbl_dea_cust] OFF
SET IDENTITY_INSERT [dbo].[tbl_products] ON 

INSERT [dbo].[tbl_products] ([id], [name], [category], [description], [rate], [qty], [added_date], [added_by]) VALUES (1, N'Coke', N'Drink', N'Coca Cola', CAST(85.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(N'2018-07-20T10:29:00.953' AS DateTime), 0)
INSERT [dbo].[tbl_products] ([id], [name], [category], [description], [rate], [qty], [added_date], [added_by]) VALUES (3, N'sdd', N'Food', N'ds', CAST(52.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(N'2018-07-20T11:08:23.820' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tbl_products] OFF
SET IDENTITY_INSERT [dbo].[tbl_transaction_detail] ON 

INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (1, 0, CAST(85.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(170.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T10:07:54.633' AS DateTime), 5)
INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (2, 0, CAST(52.00 AS Decimal(18, 2)), CAST(4.00 AS Decimal(18, 2)), CAST(208.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T10:07:54.653' AS DateTime), 5)
INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (3, 1, CAST(85.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(425.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T10:13:41.617' AS DateTime), 5)
INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (4, 3, CAST(52.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(260.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T10:13:41.637' AS DateTime), 5)
INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (8, 1, CAST(85.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(425.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T10:59:45.390' AS DateTime), 5)
INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (9, 3, CAST(52.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(520.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T10:59:45.460' AS DateTime), 5)
INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (10, 1, CAST(85.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(425.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T11:12:12.663' AS DateTime), 5)
INSERT [dbo].[tbl_transaction_detail] ([id], [product_id], [rate], [qty], [total], [dea_cust_id], [added_date], [added_by]) VALUES (13, 1, CAST(85.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(425.00 AS Decimal(18, 2)), 1, CAST(N'2018-07-23T11:17:24.440' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[tbl_transaction_detail] OFF
SET IDENTITY_INSERT [dbo].[tbl_transactions] ON 

INSERT [dbo].[tbl_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (2, N'Purchase', 1, CAST(398.96 AS Decimal(18, 2)), CAST(N'2018-07-23T10:07:54.593' AS DateTime), CAST(10.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[tbl_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (3, N'Purchase', 1, CAST(1226.04 AS Decimal(18, 2)), CAST(N'2018-07-23T10:13:41.577' AS DateTime), CAST(5.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[tbl_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (6, N'Purchase', 1, CAST(924.68 AS Decimal(18, 2)), CAST(N'2018-07-23T10:59:45.317' AS DateTime), CAST(3.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[tbl_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (7, N'Purchase', 1, CAST(424.83 AS Decimal(18, 2)), CAST(N'2018-07-23T11:12:12.557' AS DateTime), CAST(2.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[tbl_transactions] ([id], [type], [dea_cust_id], [grandTotal], [transaction_date], [tax], [discount], [added_by]) VALUES (10, N'Sales', 1, CAST(411.82 AS Decimal(18, 2)), CAST(N'2018-07-23T11:17:24.403' AS DateTime), CAST(2.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 5)
SET IDENTITY_INSERT [dbo].[tbl_transactions] OFF
SET IDENTITY_INSERT [dbo].[tbl_users] ON 

INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (1, N'Muhammad', N'Nawaz', N'admin@POS.com', N'admin', N'admin', N'03041596991', N'Sahiwal,Punjab', N'Male', N'admin', CAST(N'2018-12-07T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (5, N'CH', N'Nawaz', N'Ch@POS.com', N'CH123', N'CH123', N'03041596991', N'PAKISTAN', N'male', N'user', CAST(N'2018-07-22T06:35:57.417' AS DateTime), 1)
INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (6, N'Nawaz', N'CH', N'Nawaz@POS.com', N'Nawaz123', N'Nawaz123', N'03167892015', N'Niazi Sahiwal', N'male', N'admin', CAST(N'2018-07-19T04:54:04.967' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tbl_users] OFF
USE [master]
GO
ALTER DATABASE [POS] SET  READ_WRITE 
GO
