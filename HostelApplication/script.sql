USE [master]
GO
/****** Object:  Database [HostelApps]    Script Date: 4/9/2022 8:54:19 PM ******/
CREATE DATABASE [HostelApps]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hostel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Hostel.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hostel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Hostel_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [HostelApps] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HostelApps].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HostelApps] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HostelApps] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HostelApps] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HostelApps] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HostelApps] SET ARITHABORT OFF 
GO
ALTER DATABASE [HostelApps] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HostelApps] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HostelApps] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HostelApps] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HostelApps] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HostelApps] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HostelApps] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HostelApps] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HostelApps] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HostelApps] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HostelApps] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HostelApps] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HostelApps] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HostelApps] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HostelApps] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HostelApps] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HostelApps] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HostelApps] SET RECOVERY FULL 
GO
ALTER DATABASE [HostelApps] SET  MULTI_USER 
GO
ALTER DATABASE [HostelApps] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HostelApps] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HostelApps] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HostelApps] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HostelApps] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HostelApps', N'ON'
GO
USE [HostelApps]
GO
/****** Object:  Table [dbo].[Absent]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Absent](
	[AbsentId] [int] IDENTITY(1,1) NOT NULL,
	[MatricNo] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[Faculty] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[StudentLevel] [nvarchar](50) NULL,
	[Course] [nvarchar](50) NULL,
	[DepartureDate] [datetime] NULL,
	[Destination] [nvarchar](50) NULL,
	[Parent] [nvarchar](50) NULL,
	[SessionofAdmission] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Absent] PRIMARY KEY CLUSTERED 
(
	[AbsentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Allocation]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allocation](
	[AllocationId] [int] IDENTITY(1,1) NOT NULL,
	[MatricNo] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[Faculty] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[Course] [nvarchar](50) NULL,
	[StudentLevel] [nvarchar](50) NULL,
	[Hall] [nvarchar](50) NULL,
	[Block] [nvarchar](50) NULL,
	[Room] [nvarchar](50) NULL,
	[Bunk] [nvarchar](50) NULL,
	[StartDate] [datetime] NULL,
	[ExpireDate] [datetime] NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Allocation] PRIMARY KEY CLUSTERED 
(
	[AllocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AuditTrail]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditTrail](
	[AuditTrailId] [int] IDENTITY(1,1) NOT NULL,
	[ObjectName] [nvarchar](50) NULL,
	[NewValue] [nvarchar](50) NULL,
	[Action] [nvarchar](50) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[IPAddress] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_AuditTrail] PRIMARY KEY CLUSTERED 
(
	[AuditTrailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Block]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Block](
	[BlockId] [int] IDENTITY(1,1) NOT NULL,
	[BlockNo] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Block] PRIMARY KEY CLUSTERED 
(
	[BlockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bunk]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bunk](
	[BunkId] [int] IDENTITY(1,1) NOT NULL,
	[BunkNo] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Bedroom] PRIMARY KEY CLUSTERED 
(
	[BunkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Course]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Entry]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entry](
	[EntryId] [int] IDENTITY(1,1) NOT NULL,
	[MatricNo] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[Registry] [nvarchar](50) NULL,
	[Bursary] [nvarchar](50) NULL,
	[Faculty] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[StudentLevel] [nvarchar](50) NULL,
	[Course] [nvarchar](50) NULL,
	[SessionofAdmission] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Entry] PRIMARY KEY CLUSTERED 
(
	[EntryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exit]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exit](
	[ExitId] [int] IDENTITY(1,1) NOT NULL,
	[MatricNo] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[Faculty] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[StudentLevel] [nvarchar](50) NULL,
	[Course] [nvarchar](50) NULL,
	[Destination] [nvarchar](50) NULL,
	[DepartureDate] [datetime] NULL,
	[SessionofAdmission] [nvarchar](50) NULL,
	[Parent] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Exit] PRIMARY KEY CLUSTERED 
(
	[ExitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculty]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
	[FacultyId] [int] IDENTITY(1,1) NOT NULL,
	[FacultyName] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Faculty] PRIMARY KEY CLUSTERED 
(
	[FacultyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hall]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hall](
	[HallId] [int] IDENTITY(1,1) NOT NULL,
	[HallName] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Hall] PRIMARY KEY CLUSTERED 
(
	[HallId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HallAdmin]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HallAdmin](
	[HallAdminId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[HallAdminName] [nvarchar](50) NULL,
	[StaffNo] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[Rank] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_HallAdmin] PRIMARY KEY CLUSTERED 
(
	[HallAdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Relocate]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relocate](
	[RelocateId] [int] IDENTITY(1,1) NOT NULL,
	[MatricNo] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[Faculty] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[Course] [nvarchar](50) NULL,
	[StudentLevel] [nvarchar](50) NULL,
	[Hall] [nvarchar](50) NULL,
	[Block] [nvarchar](50) NULL,
	[Room] [nvarchar](50) NULL,
	[Bunk] [nvarchar](50) NULL,
	[StartDate] [datetime] NULL,
	[ExpireDate] [datetime] NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Relocate] PRIMARY KEY CLUSTERED 
(
	[RelocateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomNo] [nvarchar](50) NULL,
	[TotalBedSpace] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[MatricNumber] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[Faculty] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[Course] [nvarchar](50) NULL,
	[StudentLevel] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[ParentNo] [nvarchar](50) NULL,
	[SessionofAdmission] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Temporary]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temporary](
	[TemporaryId] [int] IDENTITY(1,1) NOT NULL,
	[MatricNo] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[Faculty] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[StudentLevel] [nvarchar](50) NULL,
	[Course] [nvarchar](50) NULL,
	[Hall] [nvarchar](50) NULL,
	[Block] [nvarchar](50) NULL,
	[Room] [nvarchar](50) NULL,
	[Bunk] [nvarchar](50) NULL,
	[StartDate] [datetime] NULL,
	[ExpireDate] [datetime] NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_Temporary] PRIMARY KEY CLUSTERED 
(
	[TemporaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 4/9/2022 8:54:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[OtherName] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
	[Created] [datetime] NULL,
	[Updated] [datetime] NULL,
	[RowVersion] [timestamp] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Allocation] ON 

INSERT [dbo].[Allocation] ([AllocationId], [MatricNo], [LastName], [FirstName], [OtherName], [Faculty], [Department], [Course], [StudentLevel], [Hall], [Block], [Room], [Bunk], [StartDate], [ExpireDate], [Created], [Updated]) VALUES (5, N'001', N'Seun', N'Agboola', N'Olawade', N'Political sc', N'Politics education', N'Computer Sc', N'100', N'Isiaqa Adeleke Hall', N'B', N'1', N'1', CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2022-03-24 09:53:02.020' AS DateTime), CAST(N'2022-03-24 09:53:02.020' AS DateTime))
INSERT [dbo].[Allocation] ([AllocationId], [MatricNo], [LastName], [FirstName], [OtherName], [Faculty], [Department], [Course], [StudentLevel], [Hall], [Block], [Room], [Bunk], [StartDate], [ExpireDate], [Created], [Updated]) VALUES (6, N'002', N'kola', N'jummy', N'femi', N'Political sc', N'Politics education', N'Computer Sc', N'100', N'Isiaqa Adeleke Hall', N'B', N'1', N'1', CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2022-03-24 16:34:51.373' AS DateTime), CAST(N'2022-03-24 16:34:51.373' AS DateTime))
INSERT [dbo].[Allocation] ([AllocationId], [MatricNo], [LastName], [FirstName], [OtherName], [Faculty], [Department], [Course], [StudentLevel], [Hall], [Block], [Room], [Bunk], [StartDate], [ExpireDate], [Created], [Updated]) VALUES (7, N'002', N'Seun', N'Akande', N'Olawade', N'Political sc', N'Politics education', N'Computer Sc', N'100', N'Isiaqa Adeleke Hall', N'B', N'1', N'1', CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2022-03-25 04:18:37.213' AS DateTime), CAST(N'2022-03-25 04:18:38.823' AS DateTime))
INSERT [dbo].[Allocation] ([AllocationId], [MatricNo], [LastName], [FirstName], [OtherName], [Faculty], [Department], [Course], [StudentLevel], [Hall], [Block], [Room], [Bunk], [StartDate], [ExpireDate], [Created], [Updated]) VALUES (8, N'002', N'Seun', N'Akande', N'Olawade', N'Political sc', N'Politics education', N'Computer Sc', N'100', N'Isiaqa Adeleke Hall', N'B', N'1', N'1', CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2022-03-25 04:19:04.050' AS DateTime), CAST(N'2022-03-25 04:19:04.050' AS DateTime))
SET IDENTITY_INSERT [dbo].[Allocation] OFF
SET IDENTITY_INSERT [dbo].[AuditTrail] ON 

INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (7043, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-03-25 04:15:51.400' AS DateTime), CAST(N'2022-03-25 04:15:51.403' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (7044, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-03-25 04:18:29.730' AS DateTime), CAST(N'2022-03-25 04:18:29.790' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (7045, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-03-25 04:19:04.040' AS DateTime), CAST(N'2022-03-25 04:19:04.040' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (7047, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-03-25 04:21:30.650' AS DateTime), CAST(N'2022-03-25 04:21:30.650' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (7048, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-03-25 04:27:16.880' AS DateTime), CAST(N'2022-03-25 04:27:16.880' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (8038, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-03-30 17:21:24.230' AS DateTime), CAST(N'2022-03-30 17:21:24.230' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9037, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:25:35.500' AS DateTime), CAST(N'2022-04-01 04:25:35.500' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9038, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:31:36.850' AS DateTime), CAST(N'2022-04-01 04:31:36.850' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9039, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:31:55.047' AS DateTime), CAST(N'2022-04-01 04:31:55.047' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9040, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:32:16.523' AS DateTime), CAST(N'2022-04-01 04:32:16.523' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9041, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:32:45.337' AS DateTime), CAST(N'2022-04-01 04:32:45.337' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9042, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:33:26.760' AS DateTime), CAST(N'2022-04-01 04:33:26.760' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9043, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:33:51.647' AS DateTime), CAST(N'2022-04-01 04:33:51.647' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9044, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:34:17.253' AS DateTime), CAST(N'2022-04-01 04:34:17.253' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9045, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:34:47.403' AS DateTime), CAST(N'2022-04-01 04:34:47.403' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9046, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:35:10.973' AS DateTime), CAST(N'2022-04-01 04:35:10.973' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9047, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:35:38.340' AS DateTime), CAST(N'2022-04-01 04:35:38.340' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9048, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:35:52.630' AS DateTime), CAST(N'2022-04-01 04:35:52.630' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9049, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:36:39.180' AS DateTime), CAST(N'2022-04-01 04:36:39.180' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9050, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:36:54.077' AS DateTime), CAST(N'2022-04-01 04:36:54.077' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9051, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:37:11.633' AS DateTime), CAST(N'2022-04-01 04:37:11.633' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9052, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:37:31.310' AS DateTime), CAST(N'2022-04-01 04:37:31.310' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9053, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:37:59.647' AS DateTime), CAST(N'2022-04-01 04:37:59.647' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9054, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:38:10.543' AS DateTime), CAST(N'2022-04-01 04:38:10.543' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9055, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:38:21.110' AS DateTime), CAST(N'2022-04-01 04:38:21.110' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9056, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:38:30.993' AS DateTime), CAST(N'2022-04-01 04:38:30.993' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9057, N'Create', N'College', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:38:42.540' AS DateTime), CAST(N'2022-04-01 04:38:42.540' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9058, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 04:39:50.457' AS DateTime), CAST(N'2022-04-01 04:39:50.457' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (9059, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 05:10:12.073' AS DateTime), CAST(N'2022-04-01 05:10:12.073' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10037, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 13:53:53.830' AS DateTime), CAST(N'2022-04-01 13:53:53.830' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10038, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-01 14:28:10.627' AS DateTime), CAST(N'2022-04-01 14:28:10.627' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10039, N'Login', N'Login', N'Login', NULL, N'127.0.0.1', CAST(N'2022-04-01 14:31:40.757' AS DateTime), CAST(N'2022-04-01 14:31:40.757' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10040, N'Create', N'College', N'Create', N'eboue1000@gmail.com', N'127.0.0.1', CAST(N'2022-04-01 14:53:20.753' AS DateTime), CAST(N'2022-04-01 14:53:20.753' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10041, N'Login', N'Login', N'Login', N'eboue1000@gmail.com', N'127.0.0.1', CAST(N'2022-04-02 08:07:24.460' AS DateTime), CAST(N'2022-04-02 08:07:24.460' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10042, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 04:29:44.983' AS DateTime), CAST(N'2022-04-07 04:29:44.983' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10043, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 04:44:34.733' AS DateTime), CAST(N'2022-04-07 04:44:34.733' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10044, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 04:45:48.167' AS DateTime), CAST(N'2022-04-07 04:45:48.167' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10045, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 04:59:04.633' AS DateTime), CAST(N'2022-04-07 04:59:04.633' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10046, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:00:08.387' AS DateTime), CAST(N'2022-04-07 05:00:08.387' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10047, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:04:23.033' AS DateTime), CAST(N'2022-04-07 05:04:23.033' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10048, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:05:24.160' AS DateTime), CAST(N'2022-04-07 05:05:24.160' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10049, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:09:11.233' AS DateTime), CAST(N'2022-04-07 05:09:11.233' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10050, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:12:14.763' AS DateTime), CAST(N'2022-04-07 05:12:14.763' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10051, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:14:10.720' AS DateTime), CAST(N'2022-04-07 05:14:10.720' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10052, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:21:57.553' AS DateTime), CAST(N'2022-04-07 05:21:57.553' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (10053, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 05:24:35.377' AS DateTime), CAST(N'2022-04-07 05:24:35.377' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11042, N'Login', N'Login', N'Login', NULL, N'127.0.0.1', CAST(N'2022-04-07 16:42:40.750' AS DateTime), CAST(N'2022-04-07 16:42:40.750' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11043, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 16:43:47.120' AS DateTime), CAST(N'2022-04-07 16:43:47.120' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11044, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 16:47:10.963' AS DateTime), CAST(N'2022-04-07 16:47:10.963' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11045, N'Create', N'Department', N'Create', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 16:48:11.830' AS DateTime), CAST(N'2022-04-07 16:48:11.830' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11046, N'Login', N'Login', N'Login', NULL, N'127.0.0.1', CAST(N'2022-04-07 21:57:06.393' AS DateTime), CAST(N'2022-04-07 21:57:06.393' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11047, N'Login', N'Login', N'Login', NULL, N'127.0.0.1', CAST(N'2022-04-07 22:03:36.527' AS DateTime), CAST(N'2022-04-07 22:03:36.527' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11048, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 22:20:28.277' AS DateTime), CAST(N'2022-04-07 22:20:28.277' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11049, N'displayhostel', N'Temporary', N'displayallocation', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 22:20:46.847' AS DateTime), CAST(N'2022-04-07 22:20:46.847' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11050, N'Login', N'Login', N'Login', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 22:24:37.723' AS DateTime), CAST(N'2022-04-07 22:24:37.723' AS DateTime))
INSERT [dbo].[AuditTrail] ([AuditTrailId], [ObjectName], [NewValue], [Action], [CreatedBy], [IPAddress], [Created], [Updated]) VALUES (11051, N'displayhostel', N'Temporary', N'displayallocation', N'seun@yahoo.com', N'127.0.0.1', CAST(N'2022-04-07 22:24:50.717' AS DateTime), CAST(N'2022-04-07 22:24:50.717' AS DateTime))
SET IDENTITY_INSERT [dbo].[AuditTrail] OFF
SET IDENTITY_INSERT [dbo].[Block] ON 

INSERT [dbo].[Block] ([BlockId], [BlockNo], [Created], [Updated]) VALUES (1, N'A', CAST(N'2022-03-22 23:37:47.757' AS DateTime), CAST(N'2022-03-22 23:37:47.757' AS DateTime))
INSERT [dbo].[Block] ([BlockId], [BlockNo], [Created], [Updated]) VALUES (2, N'B', CAST(N'2022-03-22 23:37:58.367' AS DateTime), CAST(N'2022-03-22 23:37:58.367' AS DateTime))
INSERT [dbo].[Block] ([BlockId], [BlockNo], [Created], [Updated]) VALUES (3, N'C', CAST(N'2022-03-22 23:38:07.410' AS DateTime), CAST(N'2022-03-22 23:38:07.410' AS DateTime))
INSERT [dbo].[Block] ([BlockId], [BlockNo], [Created], [Updated]) VALUES (1002, N'D', CAST(N'2022-04-01 04:35:38.663' AS DateTime), CAST(N'2022-04-01 04:35:38.663' AS DateTime))
INSERT [dbo].[Block] ([BlockId], [BlockNo], [Created], [Updated]) VALUES (1003, N'E', CAST(N'2022-04-01 04:35:52.633' AS DateTime), CAST(N'2022-04-01 04:35:52.633' AS DateTime))
SET IDENTITY_INSERT [dbo].[Block] OFF
SET IDENTITY_INSERT [dbo].[Bunk] ON 

INSERT [dbo].[Bunk] ([BunkId], [BunkNo], [Created], [Updated]) VALUES (2, N'1', CAST(N'2022-03-22 23:41:08.590' AS DateTime), CAST(N'2022-03-22 23:41:08.590' AS DateTime))
INSERT [dbo].[Bunk] ([BunkId], [BunkNo], [Created], [Updated]) VALUES (1002, N'2', CAST(N'2022-04-01 04:37:59.650' AS DateTime), CAST(N'2022-04-01 04:37:59.650' AS DateTime))
INSERT [dbo].[Bunk] ([BunkId], [BunkNo], [Created], [Updated]) VALUES (1003, N'3', CAST(N'2022-04-01 04:38:10.547' AS DateTime), CAST(N'2022-04-01 04:38:10.547' AS DateTime))
INSERT [dbo].[Bunk] ([BunkId], [BunkNo], [Created], [Updated]) VALUES (1004, N'4', CAST(N'2022-04-01 04:38:21.113' AS DateTime), CAST(N'2022-04-01 04:38:21.113' AS DateTime))
INSERT [dbo].[Bunk] ([BunkId], [BunkNo], [Created], [Updated]) VALUES (1005, N'5', CAST(N'2022-04-01 04:38:30.997' AS DateTime), CAST(N'2022-04-01 04:38:30.997' AS DateTime))
INSERT [dbo].[Bunk] ([BunkId], [BunkNo], [Created], [Updated]) VALUES (1006, N'6', CAST(N'2022-04-01 04:38:42.543' AS DateTime), CAST(N'2022-04-01 04:38:42.543' AS DateTime))
SET IDENTITY_INSERT [dbo].[Bunk] OFF
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([CourseId], [CourseName], [Created], [Updated]) VALUES (1, N'Computer Sc', CAST(N'2022-03-23 13:32:26.740' AS DateTime), CAST(N'2022-03-23 13:32:26.740' AS DateTime))
INSERT [dbo].[Course] ([CourseId], [CourseName], [Created], [Updated]) VALUES (2, N'Statistics', CAST(N'2022-04-01 04:31:36.853' AS DateTime), CAST(N'2022-04-01 04:31:36.853' AS DateTime))
INSERT [dbo].[Course] ([CourseId], [CourseName], [Created], [Updated]) VALUES (3, N'Surgery', CAST(N'2022-04-01 04:31:55.053' AS DateTime), CAST(N'2022-04-01 04:31:55.053' AS DateTime))
INSERT [dbo].[Course] ([CourseId], [CourseName], [Created], [Updated]) VALUES (4, N'Agric Education', CAST(N'2022-04-01 04:32:16.527' AS DateTime), CAST(N'2022-04-01 04:32:16.527' AS DateTime))
INSERT [dbo].[Course] ([CourseId], [CourseName], [Created], [Updated]) VALUES (5, N'Linguistic', CAST(N'2022-04-01 04:32:45.340' AS DateTime), CAST(N'2022-04-01 04:32:45.340' AS DateTime))
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([DepartmentId], [DepartmentName], [Created], [Updated]) VALUES (1, N'Politics education', CAST(N'2022-03-13 06:37:02.000' AS DateTime), CAST(N'2022-03-13 06:37:02.000' AS DateTime))
INSERT [dbo].[Department] ([DepartmentId], [DepartmentName], [Created], [Updated]) VALUES (2, N'Surgery', CAST(N'2022-04-01 04:30:14.523' AS DateTime), CAST(N'2022-04-01 04:30:14.523' AS DateTime))
INSERT [dbo].[Department] ([DepartmentId], [DepartmentName], [Created], [Updated]) VALUES (3, N'Computer sc', CAST(N'2022-04-01 04:30:29.203' AS DateTime), CAST(N'2022-04-01 04:30:29.203' AS DateTime))
INSERT [dbo].[Department] ([DepartmentId], [DepartmentName], [Created], [Updated]) VALUES (4, N'Crop Sc', CAST(N'2022-04-01 04:30:48.717' AS DateTime), CAST(N'2022-04-01 04:30:48.717' AS DateTime))
INSERT [dbo].[Department] ([DepartmentId], [DepartmentName], [Created], [Updated]) VALUES (1002, N'Electrical', CAST(N'2022-04-01 14:34:24.940' AS DateTime), CAST(N'2022-04-01 14:34:24.940' AS DateTime))
SET IDENTITY_INSERT [dbo].[Department] OFF
SET IDENTITY_INSERT [dbo].[Faculty] ON 

INSERT [dbo].[Faculty] ([FacultyId], [FacultyName], [Created], [Updated]) VALUES (1, N'Political sc', CAST(N'2022-03-13 06:31:44.000' AS DateTime), CAST(N'2022-03-13 06:31:45.000' AS DateTime))
INSERT [dbo].[Faculty] ([FacultyId], [FacultyName], [Created], [Updated]) VALUES (2, N'Science', CAST(N'2022-04-01 04:28:36.040' AS DateTime), CAST(N'2022-04-01 04:28:36.040' AS DateTime))
INSERT [dbo].[Faculty] ([FacultyId], [FacultyName], [Created], [Updated]) VALUES (3, N'Medicine', CAST(N'2022-04-01 04:29:08.990' AS DateTime), CAST(N'2022-04-01 04:29:08.990' AS DateTime))
INSERT [dbo].[Faculty] ([FacultyId], [FacultyName], [Created], [Updated]) VALUES (4, N'Agric', CAST(N'2022-04-01 04:29:32.373' AS DateTime), CAST(N'2022-04-01 04:29:32.373' AS DateTime))
INSERT [dbo].[Faculty] ([FacultyId], [FacultyName], [Created], [Updated]) VALUES (1002, N'Engineering', CAST(N'2022-04-01 14:33:26.897' AS DateTime), CAST(N'2022-04-01 14:33:26.897' AS DateTime))
SET IDENTITY_INSERT [dbo].[Faculty] OFF
SET IDENTITY_INSERT [dbo].[Hall] ON 

INSERT [dbo].[Hall] ([HallId], [HallName], [Created], [Updated]) VALUES (1, N'Isiaqa Adeleke Hall', CAST(N'2022-03-22 23:37:27.110' AS DateTime), CAST(N'2022-03-22 23:37:27.110' AS DateTime))
INSERT [dbo].[Hall] ([HallId], [HallName], [Created], [Updated]) VALUES (2, N'Senate Hall', CAST(N'2022-04-01 04:33:26.763' AS DateTime), CAST(N'2022-04-01 04:33:26.763' AS DateTime))
INSERT [dbo].[Hall] ([HallId], [HallName], [Created], [Updated]) VALUES (3, N'Ademola Hall', CAST(N'2022-04-01 04:33:51.653' AS DateTime), CAST(N'2022-04-01 04:33:51.653' AS DateTime))
INSERT [dbo].[Hall] ([HallId], [HallName], [Created], [Updated]) VALUES (4, N'Newhorizons Hall', CAST(N'2022-04-01 04:34:17.257' AS DateTime), CAST(N'2022-04-01 04:34:17.257' AS DateTime))
INSERT [dbo].[Hall] ([HallId], [HallName], [Created], [Updated]) VALUES (5, N'Postgraduate Hall', CAST(N'2022-04-01 04:34:47.403' AS DateTime), CAST(N'2022-04-01 04:34:47.403' AS DateTime))
INSERT [dbo].[Hall] ([HallId], [HallName], [Created], [Updated]) VALUES (6, N'Azeez  Hall', CAST(N'2022-04-01 04:35:10.973' AS DateTime), CAST(N'2022-04-01 04:35:10.973' AS DateTime))
SET IDENTITY_INSERT [dbo].[Hall] OFF
SET IDENTITY_INSERT [dbo].[HallAdmin] ON 

INSERT [dbo].[HallAdmin] ([HallAdminId], [Title], [HallAdminName], [StaffNo], [PhoneNo], [EmailAddress], [Rank], [Gender], [Created], [Updated]) VALUES (1, N'Dr', N'Ajiroba', N'23', N'323245424626', N'ajiroba@yahoo.com', N'senior Officer', N'Male', CAST(N'2022-03-22 23:42:45.277' AS DateTime), CAST(N'2022-03-22 23:42:45.277' AS DateTime))
INSERT [dbo].[HallAdmin] ([HallAdminId], [Title], [HallAdminName], [StaffNo], [PhoneNo], [EmailAddress], [Rank], [Gender], [Created], [Updated]) VALUES (2, N'Mr', N'ALade', N'Judge', N'090789908899', N'alade@yahoo.com', N'Officer', N'Male', CAST(N'2022-03-25 04:21:30.653' AS DateTime), CAST(N'2022-03-25 04:21:30.653' AS DateTime))
INSERT [dbo].[HallAdmin] ([HallAdminId], [Title], [HallAdminName], [StaffNo], [PhoneNo], [EmailAddress], [Rank], [Gender], [Created], [Updated]) VALUES (1002, N'Mr', N'Oyebamiji Vincent', N'20005', N'08030507890', N'adeoye@gmail.com', N'Seniol Admin Officer', N'Male', CAST(N'2022-04-01 14:53:20.760' AS DateTime), CAST(N'2022-04-01 14:53:20.760' AS DateTime))
SET IDENTITY_INSERT [dbo].[HallAdmin] OFF
SET IDENTITY_INSERT [dbo].[Relocate] ON 

INSERT [dbo].[Relocate] ([RelocateId], [MatricNo], [LastName], [FirstName], [OtherName], [Faculty], [Department], [Course], [StudentLevel], [Hall], [Block], [Room], [Bunk], [StartDate], [ExpireDate], [Created], [Updated]) VALUES (2, N'002', N'Seun', N'Agboola', N'Olawade', N'Political sc', N'Politics education', N'Computer Sc', N'100', N'Isiaqa Adeleke Hall', N'B', N'1', N'1', CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2022-03-25 04:09:32.070' AS DateTime), CAST(N'2022-03-25 04:09:32.073' AS DateTime))
SET IDENTITY_INSERT [dbo].[Relocate] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName], [Created], [Updated]) VALUES (1, N'SuperAdmin', CAST(N'2022-03-22 05:39:25.083' AS DateTime), CAST(N'2022-03-22 05:39:25.083' AS DateTime))
INSERT [dbo].[Role] ([RoleId], [RoleName], [Created], [Updated]) VALUES (2, N'Admin', CAST(N'2022-03-22 05:39:43.947' AS DateTime), CAST(N'2022-03-22 05:39:43.947' AS DateTime))
INSERT [dbo].[Role] ([RoleId], [RoleName], [Created], [Updated]) VALUES (1002, N'Student', CAST(N'2022-04-01 04:39:50.460' AS DateTime), CAST(N'2022-04-01 04:39:50.463' AS DateTime))
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([RoomId], [RoomNo], [TotalBedSpace], [Created], [Updated]) VALUES (6, N'1', N'6', CAST(N'2022-03-22 23:38:48.920' AS DateTime), CAST(N'2022-03-22 23:38:48.920' AS DateTime))
INSERT [dbo].[Room] ([RoomId], [RoomNo], [TotalBedSpace], [Created], [Updated]) VALUES (1006, N'2', N'6', CAST(N'2022-04-01 04:36:39.183' AS DateTime), CAST(N'2022-04-01 04:36:39.183' AS DateTime))
INSERT [dbo].[Room] ([RoomId], [RoomNo], [TotalBedSpace], [Created], [Updated]) VALUES (1007, N'3', N'6', CAST(N'2022-04-01 04:36:54.080' AS DateTime), CAST(N'2022-04-01 04:36:54.080' AS DateTime))
INSERT [dbo].[Room] ([RoomId], [RoomNo], [TotalBedSpace], [Created], [Updated]) VALUES (1008, N'4', N'6', CAST(N'2022-04-01 04:37:11.637' AS DateTime), CAST(N'2022-04-01 04:37:11.637' AS DateTime))
INSERT [dbo].[Room] ([RoomId], [RoomNo], [TotalBedSpace], [Created], [Updated]) VALUES (1009, N'5', N'6', CAST(N'2022-04-01 04:37:31.313' AS DateTime), CAST(N'2022-04-01 04:37:31.313' AS DateTime))
SET IDENTITY_INSERT [dbo].[Room] OFF
SET IDENTITY_INSERT [dbo].[Temporary] ON 

INSERT [dbo].[Temporary] ([TemporaryId], [MatricNo], [LastName], [FirstName], [OtherName], [Faculty], [Department], [StudentLevel], [Course], [Hall], [Block], [Room], [Bunk], [StartDate], [ExpireDate], [Created], [Updated]) VALUES (1, N'001', N'Seun', N'Agboola', N'akanni', N'Medicine', N'Politics education', N'500', N'Agric Education', N'Isiaqa Adeleke Hall', N'A', N'2', N'2', CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2009-12-09 00:00:00.000' AS DateTime), CAST(N'2022-04-07 16:48:11.850' AS DateTime), CAST(N'2022-04-07 16:48:11.850' AS DateTime))
SET IDENTITY_INSERT [dbo].[Temporary] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [OtherName], [PhoneNo], [EmailAddress], [Password], [RoleId], [Created], [Updated]) VALUES (1005, N'Akin', N'Akande', N'ade', N'090677888899', N'akin@yahoo.com', N'b1761c9419b142203ec803e88800c404', 1, CAST(N'2022-03-22 05:41:09.177' AS DateTime), CAST(N'2022-03-22 05:41:09.177' AS DateTime))
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [OtherName], [PhoneNo], [EmailAddress], [Password], [RoleId], [Created], [Updated]) VALUES (1006, N'Seun', N'Adeleju', N'akanni', N'09067567876', N'seun@yahoo.com', N'00763bbebe95b1da50e690c78a6ae0ae', 2, CAST(N'2022-03-22 05:46:13.917' AS DateTime), CAST(N'2022-03-22 05:46:13.917' AS DateTime))
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [OtherName], [PhoneNo], [EmailAddress], [Password], [RoleId], [Created], [Updated]) VALUES (2005, N'John', N'Akande', N'akanni', N'090677888899', N'john@yahoo.com', N'6e0b7076126a29d5dfcbd54835387b7b', 2, CAST(N'2022-03-22 23:43:56.403' AS DateTime), CAST(N'2022-03-22 23:43:56.403' AS DateTime))
INSERT [dbo].[User] ([UserId], [LastName], [FirstName], [OtherName], [PhoneNo], [EmailAddress], [Password], [RoleId], [Created], [Updated]) VALUES (3005, N'Israel', N'Ilerioluwa', N'Fagbayike', N'08030605722', N'eboue1000@gmail.com', N'f664a72122b0d50728d8a98f9c3a1923', 1, CAST(N'2022-04-01 14:30:36.110' AS DateTime), CAST(N'2022-04-01 14:30:36.110' AS DateTime))
SET IDENTITY_INSERT [dbo].[User] OFF
USE [master]
GO
ALTER DATABASE [HostelApps] SET  READ_WRITE 
GO
