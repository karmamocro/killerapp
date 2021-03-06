USE [funTest]
GO
/****** Object:  Table [dbo].[power]    Script Date: 8-1-2018 22:47:50 ******/
DROP TABLE [dbo].[power]
GO
/****** Object:  Table [dbo].[macht]    Script Date: 8-1-2018 22:47:50 ******/
DROP TABLE [dbo].[macht]
GO
/****** Object:  Table [dbo].[gegevens]    Script Date: 8-1-2018 22:47:50 ******/
DROP TABLE [dbo].[gegevens]
GO
/****** Object:  Table [dbo].[gebruiker]    Script Date: 8-1-2018 22:47:50 ******/
DROP TABLE [dbo].[gebruiker]
GO
USE [master]
GO
/****** Object:  Database [funTest]    Script Date: 8-1-2018 22:47:50 ******/
DROP DATABASE [funTest]
GO
/****** Object:  Database [funTest]    Script Date: 8-1-2018 22:47:50 ******/
CREATE DATABASE [funTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'funTest', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\funTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'funTest_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\funTest_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [funTest] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [funTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [funTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [funTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [funTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [funTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [funTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [funTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [funTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [funTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [funTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [funTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [funTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [funTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [funTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [funTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [funTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [funTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [funTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [funTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [funTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [funTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [funTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [funTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [funTest] SET RECOVERY FULL 
GO
ALTER DATABASE [funTest] SET  MULTI_USER 
GO
ALTER DATABASE [funTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [funTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [funTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [funTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [funTest] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'funTest', N'ON'
GO
ALTER DATABASE [funTest] SET QUERY_STORE = OFF
GO
USE [funTest]
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
USE [funTest]
GO
/****** Object:  Table [dbo].[gebruiker]    Script Date: 8-1-2018 22:47:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gebruiker](
	[gebruikerid] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](255) NULL,
	[password] [nvarchar](255) NULL,
	[gen_length] [int] NULL,
 CONSTRAINT [PK_gebruiker] PRIMARY KEY CLUSTERED 
(
	[gebruikerid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[gegevens]    Script Date: 8-1-2018 22:47:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gegevens](
	[iddata] [int] IDENTITY(1,1) NOT NULL,
	[domain] [varchar](255) NULL,
	[username] [varchar](255) NULL,
	[password] [varchar](255) NULL,
	[dateCreated] [datetime] NULL,
	[gebruiker_fk] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[macht]    Script Date: 8-1-2018 22:47:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[macht](
	[idmacht] [int] NULL,
	[powerfk] [int] NULL,
	[gebruikerfk] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[power]    Script Date: 8-1-2018 22:47:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[power](
	[idpower] [int] IDENTITY(1,1) NOT NULL,
	[powerlevel] [int] NULL,
	[name] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[gebruiker] ON 

INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (1, N'erik', N'hans', 20)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (2, N'master', N'wachtwoordje', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (3, N'oussama', N'afmelden', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (13, N'klaiw', N'xx', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (16, N'55', N'55', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (17, N'77', N'77', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (1011, N'mo', N'mo1', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (1012, N'Khalid', N'123', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (1013, N'J', N'J', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (1014, N'classi', N'classi1234', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (1015, N'tommy', N'tommy', 11)
INSERT [dbo].[gebruiker] ([gebruikerid], [username], [password], [gen_length]) VALUES (1016, N'riezj', N'stevejobs123', 11)
SET IDENTITY_INSERT [dbo].[gebruiker] OFF
SET IDENTITY_INSERT [dbo].[gegevens] ON 

INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1, N'izan.com', N'erik', N'hans', CAST(N'2017-12-12T03:09:23.000' AS DateTime), 1)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (7, N'55', N'55', N'55', CAST(N'2018-06-01T15:49:44.000' AS DateTime), 1)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (8, N'77', N'77', N'77', CAST(N'2018-06-01T15:52:16.000' AS DateTime), 17)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1003, N'qweqwqqwqw', N'eqweqw', N'qweqweqw', CAST(N'2018-07-01T00:48:20.000' AS DateTime), 1011)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1004, N'IZAN', N'IZAN', N'IZAN', CAST(N'2018-07-01T14:48:17.000' AS DateTime), 1013)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1005, N'QWEQW', N'QWEQW', N'QWEQW', CAST(N'2018-06-01T15:40:51.000' AS DateTime), 1013)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1011, N'xnxx.com', N'pedomasterbickdicksucka', N'tmRGrT0pyLN', CAST(N'2018-08-01T13:35:15.000' AS DateTime), 1016)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1012, N'weffwewef', N'wefwe', N'fwefww', CAST(N'2018-08-01T13:38:04.000' AS DateTime), 1016)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1006, N'EWQEQW', N'EQWWEQ', N'QWEQEQ', CAST(N'2018-07-01T14:49:27.000' AS DateTime), 1013)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1007, N'qwdqwd', N'qwdqwd', N'qwdqwd', CAST(N'2018-07-01T15:01:26.000' AS DateTime), 16)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1008, N'ous', N'mas', N'as', CAST(N'2018-07-01T15:01:33.000' AS DateTime), 16)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1009, N'hotmail.com', N'classico@live.nl', N'yfHooouIR0t', CAST(N'2018-07-01T15:06:30.000' AS DateTime), 1014)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1010, N'hotmail.com', N'flowziek', N'123', CAST(N'2018-07-01T21:12:31.000' AS DateTime), 1015)
INSERT [dbo].[gegevens] ([iddata], [domain], [username], [password], [dateCreated], [gebruiker_fk]) VALUES (1013, N'qwd', N'dqwd', N'qdqwdwq', CAST(N'2018-08-01T21:21:15.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[gegevens] OFF
INSERT [dbo].[macht] ([idmacht], [powerfk], [gebruikerfk]) VALUES (NULL, 1, 4)
INSERT [dbo].[macht] ([idmacht], [powerfk], [gebruikerfk]) VALUES (NULL, 2, 3)
INSERT [dbo].[macht] ([idmacht], [powerfk], [gebruikerfk]) VALUES (NULL, 3, 2)
INSERT [dbo].[macht] ([idmacht], [powerfk], [gebruikerfk]) VALUES (NULL, 4, 13)
SET IDENTITY_INSERT [dbo].[power] ON 

INSERT [dbo].[power] ([idpower], [powerlevel], [name]) VALUES (1, 100, N'gebruiker')
INSERT [dbo].[power] ([idpower], [powerlevel], [name]) VALUES (2, 150, N'moderator')
INSERT [dbo].[power] ([idpower], [powerlevel], [name]) VALUES (3, 200, N'administrator')
INSERT [dbo].[power] ([idpower], [powerlevel], [name]) VALUES (4, 999, N'ontwikkelaar')
SET IDENTITY_INSERT [dbo].[power] OFF
USE [master]
GO
ALTER DATABASE [funTest] SET  READ_WRITE 
GO
