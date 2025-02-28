USE [master]
GO
/****** Object:  Database [QLTHUCHI]    Script Date: 11/24/2019 6:57:10 PM ******/
CREATE DATABASE [QLTHUCHI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTHUCHI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLTHUCHI.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTHUCHI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLTHUCHI_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTHUCHI] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTHUCHI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTHUCHI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTHUCHI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTHUCHI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTHUCHI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTHUCHI] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTHUCHI] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTHUCHI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTHUCHI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTHUCHI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTHUCHI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTHUCHI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTHUCHI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTHUCHI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTHUCHI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTHUCHI] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTHUCHI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTHUCHI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTHUCHI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTHUCHI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTHUCHI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTHUCHI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTHUCHI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTHUCHI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTHUCHI] SET  MULTI_USER 
GO
ALTER DATABASE [QLTHUCHI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTHUCHI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTHUCHI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTHUCHI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTHUCHI] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLTHUCHI]
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 11/24/2019 6:57:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenhs] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[malop] [int] NULL,
 CONSTRAINT [PK_HOCSINH] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOANCHI]    Script Date: 11/24/2019 6:57:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOANCHI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[sotien] [money] NULL,
	[ngay] [date] NULL CONSTRAINT [DF_KHOANCHI_ngay]  DEFAULT (getdate()),
	[chitiet] [nvarchar](500) NULL,
	[loaikhoanchi] [int] NOT NULL,
	[nguoithem] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOANTHU]    Script Date: 11/24/2019 6:57:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOANTHU](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sotien] [money] NULL CONSTRAINT [DF_KHOANTHU_sotien]  DEFAULT ((0)),
	[ngay] [datetime] NULL CONSTRAINT [DF__KHOANTHU__ngay__1920BF5C]  DEFAULT (getdate()),
	[chitiet] [nvarchar](500) NULL,
	[loaikhoanthu] [int] NOT NULL,
	[mahocsinh] [int] NULL,
	[nguoithem] [varchar](50) NOT NULL,
 CONSTRAINT [PK__KHOANTHU__3213E83FA180CE6D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIKHOANCHI]    Script Date: 11/24/2019 6:57:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIKHOANCHI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[tenkhoanchi] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIKHOANCHI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIKHOANTHU]    Script Date: 11/24/2019 6:57:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIKHOANTHU](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenkhoanthu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 11/24/2019 6:57:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenlop] [nvarchar](50) NULL,
	[namhoc] [varchar](15) NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 11/24/2019 6:57:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HOCSINH] ON 

INSERT [dbo].[HOCSINH] ([id], [tenhs], [diachi], [malop]) VALUES (16, N'ad', N'ằe', 1)
INSERT [dbo].[HOCSINH] ([id], [tenhs], [diachi], [malop]) VALUES (22, N'hkjhk', N'khkj', 1)
INSERT [dbo].[HOCSINH] ([id], [tenhs], [diachi], [malop]) VALUES (25, N'gjdgj', N'dgjdgj', 1)
SET IDENTITY_INSERT [dbo].[HOCSINH] OFF
SET IDENTITY_INSERT [dbo].[KHOANCHI] ON 

INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (1, 10000.0000, CAST(N'2019-08-06' AS Date), N'Dbzd', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (3, 10000.0000, CAST(N'2019-08-06' AS Date), N'zfbz', 3, N'admin1')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (5, 15000.0000, CAST(N'2019-08-05' AS Date), NULL, 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (6, 15000.0000, CAST(N'2019-08-04' AS Date), N'zdfbdfb', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (7, 25000.0000, CAST(N'2019-08-04' AS Date), N'dbDb', 2, N'admin1')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (8, 35000.0000, CAST(N'2019-08-03' AS Date), NULL, 3, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (10, 55000.0000, CAST(N'2019-08-01' AS Date), N'bSbfSdb', 5, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (11, 12345.0000, CAST(N'2019-08-07' AS Date), NULL, 6, N'admin1')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (12, 65321.0000, CAST(N'2019-08-07' AS Date), NULL, 7, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (14, 10000.0000, CAST(N'2019-08-08' AS Date), NULL, 3, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (18, 100000.0000, CAST(N'2019-08-08' AS Date), NULL, 5, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (19, 100000.0000, CAST(N'2019-08-08' AS Date), N'Sbd', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (22, 500000.0000, CAST(N'2019-08-08' AS Date), NULL, 6, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (30, 10000.0000, CAST(N'2019-08-09' AS Date), NULL, 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (31, 10000.0000, CAST(N'2019-08-09' AS Date), NULL, 2, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (32, 50000.0000, CAST(N'2019-08-09' AS Date), NULL, 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (36, 50000.0000, CAST(N'2019-08-10' AS Date), N'xôi lạc', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (37, 50000.0000, CAST(N'2019-08-10' AS Date), N'abc', 2, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (38, 50000.0000, CAST(N'2019-08-10' AS Date), N'', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (39, 360000.0000, CAST(N'2019-08-10' AS Date), N'', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (40, 214234.0000, CAST(N'2019-08-10' AS Date), N'', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (41, 20000.0000, CAST(N'2019-08-14' AS Date), N'aaaa', 1, N'admin')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (42, 20000.0000, CAST(N'2019-08-15' AS Date), N'aa', 1, N'admin1')
INSERT [dbo].[KHOANCHI] ([ID], [sotien], [ngay], [chitiet], [loaikhoanchi], [nguoithem]) VALUES (43, 80000.0000, CAST(N'2019-08-21' AS Date), N'rrh', 6, N'admin')
SET IDENTITY_INSERT [dbo].[KHOANCHI] OFF
SET IDENTITY_INSERT [dbo].[KHOANTHU] ON 

INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (1, 30000.0000, CAST(N'2019-08-11 00:00:00.000' AS DateTime), N'xxxx', 4, NULL, N'admin1')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (2, 20000.0000, CAST(N'2019-02-10 00:00:00.000' AS DateTime), N'333333', 1, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (3, 4000000.0000, CAST(N'2019-08-11 00:00:00.000' AS DateTime), N'mua bàn ghế', 7, NULL, N'admin1')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (4, 120000.0000, CAST(N'2019-08-11 00:00:00.000' AS DateTime), N'bảo hiểm y tế', 3, NULL, N'admin1')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (5, 210000.0000, CAST(N'2019-08-11 00:00:00.000' AS DateTime), N'', 2, NULL, N'admin1')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (6, 450000.0000, CAST(N'2019-08-10 00:00:00.000' AS DateTime), N'', 4, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (7, 670000.0000, CAST(N'2019-08-09 00:00:00.000' AS DateTime), N'', 1, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (8, 1150000.0000, CAST(N'2019-08-11 00:00:00.000' AS DateTime), N'', 6, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (9, 70000.0000, CAST(N'2019-08-12 00:00:00.000' AS DateTime), N'Lớp xxx', 1, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (10, 70000.0000, CAST(N'2019-08-12 00:00:00.000' AS DateTime), N'Lớp xxx', 1, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (11, 70000.0000, CAST(N'2019-08-12 00:00:00.000' AS DateTime), N'Lớp xxx', 1, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (12, 30000.0000, CAST(N'2019-08-12 20:45:43.543' AS DateTime), N'', 4, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (13, 60000.0000, CAST(N'2019-08-12 20:48:08.123' AS DateTime), N'dfdhs', 1, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (14, 100000.0000, CAST(N'2019-08-12 20:48:22.147' AS DateTime), N'', 5, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (15, 30000.0000, CAST(N'2019-08-14 19:17:37.380' AS DateTime), N'asd', 1, NULL, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (38, 124000.0000, CAST(N'2019-11-19 23:50:56.343' AS DateTime), NULL, 1, 16, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (39, 123.0000, CAST(N'2019-11-19 23:50:56.343' AS DateTime), NULL, 2, 16, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (40, 1421.0000, CAST(N'2019-11-19 23:50:56.343' AS DateTime), NULL, 3, 16, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (41, 234.0000, CAST(N'2019-11-19 23:50:56.343' AS DateTime), NULL, 4, 16, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (42, 513.0000, CAST(N'2019-11-19 23:50:56.343' AS DateTime), NULL, 5, 16, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (43, 34.0000, CAST(N'2019-11-19 23:50:56.343' AS DateTime), NULL, 6, 16, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (44, 23.0000, CAST(N'2019-11-19 23:50:56.343' AS DateTime), NULL, 7, 16, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (80, 1241432.0000, CAST(N'2019-11-20 00:39:01.007' AS DateTime), NULL, 1, 22, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (81, 32131.0000, CAST(N'2019-11-20 00:39:01.007' AS DateTime), NULL, 2, 22, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (82, 43.0000, CAST(N'2019-11-20 00:39:01.007' AS DateTime), NULL, 3, 22, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (83, 43.0000, CAST(N'2019-11-20 00:39:01.007' AS DateTime), NULL, 4, 22, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (84, 3434.0000, CAST(N'2019-11-20 00:39:01.007' AS DateTime), NULL, 5, 22, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (85, 232.0000, CAST(N'2019-11-20 00:39:01.007' AS DateTime), NULL, 6, 22, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (86, 54545.0000, CAST(N'2019-11-20 00:39:01.007' AS DateTime), NULL, 7, 22, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (101, 0.0000, CAST(N'2019-11-20 00:45:12.417' AS DateTime), NULL, 1, 25, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (102, 0.0000, CAST(N'2019-11-20 00:45:12.417' AS DateTime), NULL, 2, 25, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (103, 0.0000, CAST(N'2019-11-20 00:45:12.417' AS DateTime), NULL, 3, 25, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (104, 0.0000, CAST(N'2019-11-20 00:45:12.417' AS DateTime), NULL, 4, 25, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (105, 0.0000, CAST(N'2019-11-20 00:45:12.417' AS DateTime), NULL, 5, 25, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (106, 0.0000, CAST(N'2019-11-20 00:45:12.417' AS DateTime), NULL, 6, 25, N'admin')
INSERT [dbo].[KHOANTHU] ([id], [sotien], [ngay], [chitiet], [loaikhoanthu], [mahocsinh], [nguoithem]) VALUES (107, 0.0000, CAST(N'2019-11-20 00:45:12.417' AS DateTime), NULL, 7, 25, N'admin')
SET IDENTITY_INSERT [dbo].[KHOANTHU] OFF
SET IDENTITY_INSERT [dbo].[LOAIKHOANCHI] ON 

INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (1, N'Tiền ăn')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (2, N'Trang thiết bị bán trú')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (3, N'Lương nhân viên')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (4, N'Xây dựng cơ sở vật chất')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (5, N'Bảo hiểm y tế học sinh')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (6, N'Đồng phục')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (7, N'Trang thiết bị học tập')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (8, N'Các khoản khác')
INSERT [dbo].[LOAIKHOANCHI] ([ID], [tenkhoanchi]) VALUES (9, N'Học ph')
SET IDENTITY_INSERT [dbo].[LOAIKHOANCHI] OFF
SET IDENTITY_INSERT [dbo].[LOAIKHOANTHU] ON 

INSERT [dbo].[LOAIKHOANTHU] ([id], [tenkhoanthu]) VALUES (1, N'Tiền học phí')
INSERT [dbo].[LOAIKHOANTHU] ([id], [tenkhoanthu]) VALUES (2, N'Tiền ăn')
INSERT [dbo].[LOAIKHOANTHU] ([id], [tenkhoanthu]) VALUES (3, N'Bảo hiểm y tế')
INSERT [dbo].[LOAIKHOANTHU] ([id], [tenkhoanthu]) VALUES (4, N'Quỹ lớp')
INSERT [dbo].[LOAIKHOANTHU] ([id], [tenkhoanthu]) VALUES (5, N'Đồng phục')
INSERT [dbo].[LOAIKHOANTHU] ([id], [tenkhoanthu]) VALUES (6, N'Trang thiết bị học tập')
INSERT [dbo].[LOAIKHOANTHU] ([id], [tenkhoanthu]) VALUES (7, N'Cơ sở vật chất')
SET IDENTITY_INSERT [dbo].[LOAIKHOANTHU] OFF
SET IDENTITY_INSERT [dbo].[LOP] ON 

INSERT [dbo].[LOP] ([id], [tenlop], [namhoc]) VALUES (1, N'Mẫu giáo lớn', N'2019-2020')
INSERT [dbo].[LOP] ([id], [tenlop], [namhoc]) VALUES (9, N'Mẫu giáo bé', N'2019-2020')
INSERT [dbo].[LOP] ([id], [tenlop], [namhoc]) VALUES (11, N'aaaaa', N'2019-2020')
INSERT [dbo].[LOP] ([id], [tenlop], [namhoc]) VALUES (12, N'xxx', N'2019-2020')
SET IDENTITY_INSERT [dbo].[LOP] OFF
INSERT [dbo].[TAIKHOAN] ([username], [password]) VALUES (N'admin', N'admin')
INSERT [dbo].[TAIKHOAN] ([username], [password]) VALUES (N'admin1', N'12345')
INSERT [dbo].[TAIKHOAN] ([username], [password]) VALUES (N'admin2', N'123')
INSERT [dbo].[TAIKHOAN] ([username], [password]) VALUES (N'user', N'user')
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [FK_HOCSINH_LOP] FOREIGN KEY([malop])
REFERENCES [dbo].[LOP] ([id])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [FK_HOCSINH_LOP]
GO
ALTER TABLE [dbo].[KHOANCHI]  WITH CHECK ADD  CONSTRAINT [FK_KHOANCHI_LOAIKC] FOREIGN KEY([loaikhoanchi])
REFERENCES [dbo].[LOAIKHOANCHI] ([ID])
GO
ALTER TABLE [dbo].[KHOANCHI] CHECK CONSTRAINT [FK_KHOANCHI_LOAIKC]
GO
ALTER TABLE [dbo].[KHOANCHI]  WITH CHECK ADD  CONSTRAINT [FK_KHOANCHI_TK] FOREIGN KEY([nguoithem])
REFERENCES [dbo].[TAIKHOAN] ([username])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KHOANCHI] CHECK CONSTRAINT [FK_KHOANCHI_TK]
GO
ALTER TABLE [dbo].[KHOANTHU]  WITH CHECK ADD  CONSTRAINT [FK_KHOANTHU_HOCSINH] FOREIGN KEY([mahocsinh])
REFERENCES [dbo].[HOCSINH] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KHOANTHU] CHECK CONSTRAINT [FK_KHOANTHU_HOCSINH]
GO
ALTER TABLE [dbo].[KHOANTHU]  WITH CHECK ADD  CONSTRAINT [FK_THU_ACC] FOREIGN KEY([nguoithem])
REFERENCES [dbo].[TAIKHOAN] ([username])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[KHOANTHU] CHECK CONSTRAINT [FK_THU_ACC]
GO
ALTER TABLE [dbo].[KHOANTHU]  WITH CHECK ADD  CONSTRAINT [FK_THU_LOAI] FOREIGN KEY([loaikhoanthu])
REFERENCES [dbo].[LOAIKHOANTHU] ([id])
GO
ALTER TABLE [dbo].[KHOANTHU] CHECK CONSTRAINT [FK_THU_LOAI]
GO
USE [master]
GO
ALTER DATABASE [QLTHUCHI] SET  READ_WRITE 
GO
