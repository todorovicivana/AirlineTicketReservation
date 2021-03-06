USE [master]
GO
/****** Object:  Database [RezervacijaAvioKarataBaza]    Script Date: 9/1/2019 1:32:00 PM ******/
CREATE DATABASE [RezervacijaAvioKarataBaza] ON  PRIMARY 
( NAME = N'Test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Test.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Test_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RezervacijaAvioKarataBaza].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET ARITHABORT OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET  MULTI_USER 
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET DB_CHAINING OFF 
GO
USE [RezervacijaAvioKarataBaza]
GO
/****** Object:  Table [dbo].[Aerodrom]    Script Date: 9/1/2019 1:32:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aerodrom](
	[AerodromID] [int] NOT NULL,
	[NazivAerodroma] [nvarchar](50) NULL,
	[NazivMesta] [nvarchar](50) NULL,
 CONSTRAINT [PK_Aerodrom] PRIMARY KEY CLUSTERED 
(
	[AerodromID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Let]    Script Date: 9/1/2019 1:32:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Let](
	[LetID] [int] NOT NULL,
	[VremePolaska] [datetime] NULL,
	[VremeDolaska] [datetime] NULL,
	[TrajanjeLeta] [time](7) NULL,
	[Klasa] [nvarchar](50) NULL,
	[BrojRaspolozivihMesta] [int] NULL,
	[NazivLeta] [nvarchar](50) NULL,
 CONSTRAINT [PK_Let] PRIMARY KEY CLUSTERED 
(
	[LetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presedanje]    Script Date: 9/1/2019 1:32:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presedanje](
	[AerodromID] [int] NOT NULL,
	[LetID] [int] NOT NULL,
	[TipStanice] [nvarchar](50) NULL,
 CONSTRAINT [PK_Presedanje] PRIMARY KEY CLUSTERED 
(
	[AerodromID] ASC,
	[LetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Putnik]    Script Date: 9/1/2019 1:32:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Putnik](
	[JMBGPutnika] [nvarchar](50) NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[BrojPasosa] [nvarchar](50) NULL,
	[KontakTelefon] [nvarchar](50) NULL,
 CONSTRAINT [PK_Putnik] PRIMARY KEY CLUSTERED 
(
	[JMBGPutnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervacija]    Script Date: 9/1/2019 1:32:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervacija](
	[RezervacijaID] [int] NOT NULL,
	[DatumIsticanja] [datetime] NULL,
	[UkupnaCena] [numeric](10, 2) NULL,
	[ZaposleniID] [int] NULL,
	[PutnikID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rezervacija] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaRezervacije]    Script Date: 9/1/2019 1:32:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaRezervacije](
	[RezervacijaID] [int] NOT NULL,
	[RedniBroj] [int] NOT NULL,
	[Cena] [numeric](10, 2) NULL,
	[LetID] [int] NULL,
 CONSTRAINT [PK_StavkaRezervacije] PRIMARY KEY CLUSTERED 
(
	[RezervacijaID] ASC,
	[RedniBroj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zaposleni]    Script Date: 9/1/2019 1:32:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zaposleni](
	[ZaposleniID] [int] NOT NULL,
	[Ime] [nvarchar](50) NULL,
	[Prezime] [nvarchar](50) NULL,
	[KorisnickoIme] [nvarchar](50) NULL,
	[KorisnickaSifra] [nvarchar](50) NULL,
 CONSTRAINT [PK_Zaposleni] PRIMARY KEY CLUSTERED 
(
	[ZaposleniID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (1, N'Aerodrom Nikola Tesla', N'Beograd')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (2, N'Aerodrom Kontantin Veliki', N'Nis')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (3, N'Aerodrom Morava', N'Kraljevo')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (4, N'Aerodrom "Charles de Gaulle"', N'Pariz')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (5, N'Aerodrom Frankfurt', N'Frankfurt')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (6, N'Aerodrom "Atatürk" Istanbul', N'Istanbul')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (7, N'Međunarodni aerodrom "Sabiha Gökçen"', N'Istanbul')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (8, N'Aerodrom Jegin Lug Tuzla', N'Tuzla')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (9, N'Aerodrom Heathrow', N'London')
INSERT [dbo].[Aerodrom] ([AerodromID], [NazivAerodroma], [NazivMesta]) VALUES (10, N'Aerodrom Split', N'Split')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (1, CAST(N'2019-09-09T05:00:00.000' AS DateTime), CAST(N'2019-09-09T07:00:00.000' AS DateTime), CAST(N'02:00:00' AS Time), N'I klasa', 129, N'Beograd - Budimpesta')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (2, CAST(N'2019-09-09T09:00:00.000' AS DateTime), CAST(N'2019-09-09T12:00:00.000' AS DateTime), CAST(N'03:00:00' AS Time), N'I klasa', 90, N'Madrid - Bec')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (3, CAST(N'2019-09-09T05:30:00.000' AS DateTime), CAST(N'2019-09-09T11:00:00.000' AS DateTime), CAST(N'05:30:00' AS Time), N'II klasa', 209, N'Budimpesta - Pariz')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (4, CAST(N'2019-12-12T12:00:00.000' AS DateTime), CAST(N'2019-12-12T16:00:00.000' AS DateTime), CAST(N'04:00:00' AS Time), N'I klasa', 47, N'Beograd - Madrid')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (5, CAST(N'2019-11-23T17:00:00.000' AS DateTime), CAST(N'2019-11-23T18:15:00.000' AS DateTime), CAST(N'01:15:00' AS Time), N'I klasa', 95, N'Nis - Milano')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (6, CAST(N'2019-10-18T05:00:00.000' AS DateTime), CAST(N'2019-10-18T08:45:00.000' AS DateTime), CAST(N'03:45:00' AS Time), N'II klasa', 199, N'Beograd - Amsterdam')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (7, CAST(N'2019-09-25T11:00:00.000' AS DateTime), CAST(N'2019-09-25T14:22:00.000' AS DateTime), CAST(N'03:22:00' AS Time), N'II klasa', 114, N'Lugano - Beograd')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (8, CAST(N'2020-01-01T15:30:00.000' AS DateTime), CAST(N'2020-01-01T19:30:00.000' AS DateTime), CAST(N'04:00:00' AS Time), N'II klasa', 198, N'Bec - Nis')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (9, CAST(N'2020-02-02T22:00:00.000' AS DateTime), CAST(N'2020-02-02T23:15:00.000' AS DateTime), CAST(N'01:15:00' AS Time), N'I klasa', 103, N'Beograd - Egipat')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (10, CAST(N'2019-11-28T04:00:00.000' AS DateTime), CAST(N'2019-11-28T06:50:00.000' AS DateTime), CAST(N'02:50:00' AS Time), N'II klasa', 57, N'Zagreb - Atina')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (11, CAST(N'2019-09-25T15:00:00.000' AS DateTime), CAST(N'2019-09-25T19:00:00.000' AS DateTime), CAST(N'04:00:00' AS Time), N'I klasa', 90, N'Zagreb - Egipat')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (12, CAST(N'2019-12-23T12:00:00.000' AS DateTime), CAST(N'2019-12-23T15:15:00.000' AS DateTime), CAST(N'03:15:00' AS Time), N'I klasa', 115, N'Beograd - Istanbul')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (13, CAST(N'2019-12-01T05:00:00.000' AS DateTime), CAST(N'2019-12-01T08:20:00.000' AS DateTime), CAST(N'03:20:00' AS Time), N'II klasa', 200, N'Madrid - Zagreb')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (14, CAST(N'2020-02-02T12:00:00.000' AS DateTime), CAST(N'2020-02-02T13:00:00.000' AS DateTime), CAST(N'01:00:00' AS Time), N'I klasa', 86, N'Skoplje - Sofija')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (15, CAST(N'2019-12-12T09:00:00.000' AS DateTime), CAST(N'2019-12-12T11:00:00.000' AS DateTime), CAST(N'02:00:00' AS Time), N'II klasa', 125, N'Rim - Amsterdam')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (16, CAST(N'2019-11-11T12:00:00.000' AS DateTime), CAST(N'2019-11-11T17:00:00.000' AS DateTime), CAST(N'05:00:00' AS Time), N'II klasa', 118, N'Oslo - Beograd')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (17, CAST(N'2019-10-10T12:00:00.000' AS DateTime), CAST(N'2019-10-10T14:14:00.000' AS DateTime), CAST(N'02:14:00' AS Time), N'I klasa', 80, N'Prag - Nis')
INSERT [dbo].[Let] ([LetID], [VremePolaska], [VremeDolaska], [TrajanjeLeta], [Klasa], [BrojRaspolozivihMesta], [NazivLeta]) VALUES (18, CAST(N'2019-09-09T20:00:00.000' AS DateTime), CAST(N'2019-09-09T22:00:00.000' AS DateTime), CAST(N'02:00:00' AS Time), N'I klasa', 105, N'Berlin - Barselona')
INSERT [dbo].[Presedanje] ([AerodromID], [LetID], [TipStanice]) VALUES (1, 2, N'Pocetna')
INSERT [dbo].[Presedanje] ([AerodromID], [LetID], [TipStanice]) VALUES (2, 1, N'Krajnja')
INSERT [dbo].[Presedanje] ([AerodromID], [LetID], [TipStanice]) VALUES (3, 4, N'Pocetna')
INSERT [dbo].[Presedanje] ([AerodromID], [LetID], [TipStanice]) VALUES (4, 3, N'Pocetna')
INSERT [dbo].[Presedanje] ([AerodromID], [LetID], [TipStanice]) VALUES (5, 6, N'Krajnja')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'0101995440123', N'Nadja', N'Petkovic', N'299034432', N'0643245889')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'0803985343476', N'Ana', N'Vojinovic', N'445562230', N'0646785552')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'1109992657834', N'Nevena', N'Jankovic', N'283740010', N'032345876')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'1111996456573', N'Nenad', N'Stojanovic', N'349800558', N'011234887')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'1212990435455', N'Andjela', N'Nenadic', N'443259882', N'032456784')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'1504982553281', N'Nikola', N'Trifunovic', N'324519002', N'011355712')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'1605996787823', N'Ivana', N'Todorovic', N'745674356', N'0663453456')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'1710998343476', N'Sofija', N'Milosevic', N'734523900', N'0645672349')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'1804992154623', N'Ana', N'Andjelic', N'33333333', N'3333333333')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'2005996574832', N'Natasa', N'Pavlovic', N'349849249', N'0665785673')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'2112000435679', N'Lazar', N'Pejanovic', N'215671233', N'0669400986')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'2509991764599', N'Igor', N'Zimonjic', N'234005621', N'0634566789')
INSERT [dbo].[Putnik] ([JMBGPutnika], [Ime], [Prezime], [BrojPasosa], [KontakTelefon]) VALUES (N'3011993667120', N'Tijana', N'Djokovic', N'328773002', N'022657123')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (1, CAST(N'2019-11-04T19:47:39.000' AS DateTime), CAST(820.00 AS Numeric(10, 2)), 10, N'1710998343476')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (2, CAST(N'2019-10-24T19:49:12.000' AS DateTime), CAST(680.00 AS Numeric(10, 2)), 10, N'0101995440123')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (3, CAST(N'2019-11-08T19:50:05.000' AS DateTime), CAST(200.00 AS Numeric(10, 2)), 1, N'0803985343476')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (4, CAST(N'2019-10-15T19:50:19.000' AS DateTime), CAST(350.00 AS Numeric(10, 2)), 1, N'1111996456573')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (5, CAST(N'2019-10-11T19:50:50.000' AS DateTime), CAST(800.00 AS Numeric(10, 2)), 6, N'1212990435455')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (6, CAST(N'2019-10-18T19:51:43.000' AS DateTime), CAST(666.00 AS Numeric(10, 2)), 6, N'1504982553281')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (7, CAST(N'2019-08-31T19:52:28.000' AS DateTime), CAST(112.00 AS Numeric(10, 2)), 6, N'1605996787823')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (8, CAST(N'2019-11-21T19:53:01.000' AS DateTime), CAST(540.00 AS Numeric(10, 2)), 1, N'1710998343476')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (9, CAST(N'2019-12-01T19:53:17.000' AS DateTime), CAST(1000.00 AS Numeric(10, 2)), 1, N'2112000435679')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (10, CAST(N'2019-08-31T19:53:53.000' AS DateTime), CAST(590.00 AS Numeric(10, 2)), 3, N'3011993667120')
INSERT [dbo].[Rezervacija] ([RezervacijaID], [DatumIsticanja], [UkupnaCena], [ZaposleniID], [PutnikID]) VALUES (11, CAST(N'2019-12-23T19:54:40.000' AS DateTime), CAST(1000.00 AS Numeric(10, 2)), 3, N'1710998343476')
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (1, 1, CAST(320.00 AS Numeric(10, 2)), 3)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (1, 2, CAST(500.00 AS Numeric(10, 2)), 8)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (2, 1, CAST(230.00 AS Numeric(10, 2)), 1)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (2, 2, CAST(450.00 AS Numeric(10, 2)), 10)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (3, 1, CAST(200.00 AS Numeric(10, 2)), 4)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (4, 1, CAST(350.00 AS Numeric(10, 2)), 4)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (5, 1, CAST(800.00 AS Numeric(10, 2)), 10)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (6, 1, CAST(345.00 AS Numeric(10, 2)), 6)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (6, 2, CAST(321.00 AS Numeric(10, 2)), 10)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (7, 1, CAST(112.00 AS Numeric(10, 2)), 9)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (8, 1, CAST(540.00 AS Numeric(10, 2)), 4)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (9, 1, CAST(1000.00 AS Numeric(10, 2)), 8)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (10, 1, CAST(590.00 AS Numeric(10, 2)), 7)
INSERT [dbo].[StavkaRezervacije] ([RezervacijaID], [RedniBroj], [Cena], [LetID]) VALUES (11, 1, CAST(1000.00 AS Numeric(10, 2)), 9)
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (1, N'Nina', N'Samardzic', N'nina', N'nina991')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (2, N'Nikola', N'Vujovic', N'nikola', N'nikola993')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (3, N'Marta', N'Pejovic', N'marta', N'marta996')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (4, N'Ana', N'Todorovic', N'ana', N'ana990')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (5, N'Petar', N'Zecevic', N'petar', N'petar985')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (6, N'Stefan', N'Cekovic', N'stefan', N'stefan992')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (7, N'Jovana', N'Lukovic', N'jovana', N'jovana993')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (8, N'Filip', N'Jelic', N'filip', N'filip991')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (9, N'Nenad', N'Novovic', N'nenad', N'nenad996')
INSERT [dbo].[Zaposleni] ([ZaposleniID], [Ime], [Prezime], [KorisnickoIme], [KorisnickaSifra]) VALUES (10, N'Maja', N'Stevanovic', N'maja', N'maja992')
ALTER TABLE [dbo].[Presedanje]  WITH CHECK ADD  CONSTRAINT [FK_Presedanje_Aerodrom] FOREIGN KEY([AerodromID])
REFERENCES [dbo].[Aerodrom] ([AerodromID])
GO
ALTER TABLE [dbo].[Presedanje] CHECK CONSTRAINT [FK_Presedanje_Aerodrom]
GO
ALTER TABLE [dbo].[Presedanje]  WITH CHECK ADD  CONSTRAINT [FK_Presedanje_Let] FOREIGN KEY([LetID])
REFERENCES [dbo].[Let] ([LetID])
GO
ALTER TABLE [dbo].[Presedanje] CHECK CONSTRAINT [FK_Presedanje_Let]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Putnik] FOREIGN KEY([PutnikID])
REFERENCES [dbo].[Putnik] ([JMBGPutnika])
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Putnik]
GO
ALTER TABLE [dbo].[Rezervacija]  WITH CHECK ADD  CONSTRAINT [FK_Rezervacija_Zaposleni] FOREIGN KEY([ZaposleniID])
REFERENCES [dbo].[Zaposleni] ([ZaposleniID])
GO
ALTER TABLE [dbo].[Rezervacija] CHECK CONSTRAINT [FK_Rezervacija_Zaposleni]
GO
ALTER TABLE [dbo].[StavkaRezervacije]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRezervacije_Let] FOREIGN KEY([LetID])
REFERENCES [dbo].[Let] ([LetID])
GO
ALTER TABLE [dbo].[StavkaRezervacije] CHECK CONSTRAINT [FK_StavkaRezervacije_Let]
GO
ALTER TABLE [dbo].[StavkaRezervacije]  WITH CHECK ADD  CONSTRAINT [FK_StavkaRezervacije_Rezervacija] FOREIGN KEY([RezervacijaID])
REFERENCES [dbo].[Rezervacija] ([RezervacijaID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaRezervacije] CHECK CONSTRAINT [FK_StavkaRezervacije_Rezervacija]
GO
USE [master]
GO
ALTER DATABASE [RezervacijaAvioKarataBaza] SET  READ_WRITE 
GO
