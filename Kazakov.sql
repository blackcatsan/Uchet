USE [Kazakov]
GO
/****** Object:  Table [dbo].[Install]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Install](
	[prog] [int] NOT NULL,
	[pc] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kabs]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kabs](
	[knum] [int] NOT NULL,
	[knam] [nvarchar](25) NOT NULL,
	[teach] [int] NULL,
 CONSTRAINT [PK_Kabs] PRIMARY KEY CLUSTERED 
(
	[knum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[License]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[License](
	[lnum] [int] NOT NULL,
	[lnam] [nvarchar](100) NOT NULL,
	[dlit] [int] NOT NULL,
 CONSTRAINT [PK_License] PRIMARY KEY CLUSTERED 
(
	[lnum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PC]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PC](
	[PCnum] [int] NOT NULL,
	[PCnet] [nvarchar](50) NOT NULL,
	[Kab] [int] NOT NULL,
 CONSTRAINT [PK_PC] PRIMARY KEY CLUSTERED 
(
	[PCnum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predmet]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predmet](
	[pnum] [int] NOT NULL,
	[pnam] [nvarchar](100) NOT NULL,
	[lab_hours] [int] NOT NULL,
	[spec] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Predmet] PRIMARY KEY CLUSTERED 
(
	[pnum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prepodav]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prepodav](
	[tnum] [int] NOT NULL,
	[pnum] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgPred]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgPred](
	[prog] [int] NOT NULL,
	[predm] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Programs]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Programs](
	[prnum] [int] NOT NULL,
	[prnam] [nvarchar](100) NOT NULL,
	[version] [nvarchar](50) NOT NULL,
	[license] [int] NOT NULL,
	[inst_dat] [datetime] NOT NULL,
	[expr_dat] [datetime] NOT NULL,
	[value] [int] NOT NULL,
 CONSTRAINT [PK_Programs] PRIMARY KEY CLUSTERED 
(
	[prnum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgUpd]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgUpd](
	[Years] [int] NOT NULL,
	[All_Upd] [int] NOT NULL,
	[Upd] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sotr]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sotr](
	[snum] [int] NOT NULL,
	[snam] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
	[role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sotr] PRIMARY KEY CLUSTERED 
(
	[snum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[tnum] [int] NOT NULL,
	[tfam] [nvarchar](50) NOT NULL,
	[tnam] [nvarchar](50) NOT NULL,
	[totch] [nvarchar](50) NOT NULL,
	[dolg] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[tnum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Install] ([prog], [pc]) VALUES (1, 1)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (1, 3)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (2, 3)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (3, 1)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (3, 2)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (3, 3)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (4, 1)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (4, 3)
INSERT [dbo].[Install] ([prog], [pc]) VALUES (4, 4)
GO
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (1, N'1/402', 1)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (2, N'1/403', 2)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (3, N'1/404', 1)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (4, N'1/405', 3)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (5, N'1/406', 2)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (6, N'1/407', 2)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (7, N'1/408', 1)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (8, N'1/409', 5)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (9, N'1/410', 2)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (10, N'1/411', 3)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (11, N'1/412', 5)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (12, N'1/413', 1)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (13, N'5764', 3)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (14, N'111', 1)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (15, N'1112', 2)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (16, N'33', 4)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (17, N'уе35', 3)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (18, N'436346', 6)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (19, N'156', 7)
INSERT [dbo].[Kabs] ([knum], [knam], [teach]) VALUES (20, N'3446', 6)
GO
INSERT [dbo].[License] ([lnum], [lnam], [dlit]) VALUES (1, N'GNUv2', 3)
INSERT [dbo].[License] ([lnum], [lnam], [dlit]) VALUES (2, N'варар', 333)
INSERT [dbo].[License] ([lnum], [lnam], [dlit]) VALUES (3, N'free', 500)
GO
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (1, N'kk1413-2', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (2, N'kk1413-1', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (3, N'kk1413-3', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (4, N'kk1413-4', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (5, N'kk1413-5', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (6, N'kk1413-6', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (7, N'kk1413-7', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (8, N'kk1413-8', 12)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (9, N'Kdjnh', 19)
INSERT [dbo].[PC] ([PCnum], [PCnet], [Kab]) VALUES (10, N'укпр', 11)
GO
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (1, N'БД', 95, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (2, N'МДК4.1', 111, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (3, N'1С', 125, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (4, N'Системное программирование', 120, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (5, N'Основы алгоритмизации', 100, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (6, N'kjkug', 122, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (7, N'ssdbsh', 126, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (8, N'БД', 90, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (9, N'Алгоритмизация', 124, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (10, N'fbf', 464573, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (11, N' ', 6, N'09.02.05')
INSERT [dbo].[Predmet] ([pnum], [pnam], [lab_hours], [spec]) VALUES (12, N'fhhjfhddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd', 7, N'09.02.05')
GO
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (4, 2)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (4, 5)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (5, 2)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (5, 6)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (7, 7)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (3, 2)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (1, 1)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (1, 2)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (1, 6)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (1, 7)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (9, 1)
INSERT [dbo].[Prepodav] ([tnum], [pnum]) VALUES (7, 6)
GO
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (1, 1)
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (1, 2)
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (2, 1)
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (3, 1)
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (4, 1)
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (4, 2)
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (4, 3)
INSERT [dbo].[ProgPred] ([prog], [predm]) VALUES (3, 2)
GO
INSERT [dbo].[Programs] ([prnum], [prnam], [version], [license], [inst_dat], [expr_dat], [value]) VALUES (1, N'Masteer', N'2020', 1, CAST(N'2021-01-12T18:14:00.000' AS DateTime), CAST(N'2024-01-19T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Programs] ([prnum], [prnam], [version], [license], [inst_dat], [expr_dat], [value]) VALUES (2, N'Visual Studio', N'2019', 1, CAST(N'2021-01-19T18:12:23.490' AS DateTime), CAST(N'2024-01-19T18:12:48.523' AS DateTime), 23)
INSERT [dbo].[Programs] ([prnum], [prnam], [version], [license], [inst_dat], [expr_dat], [value]) VALUES (3, N'SQL Server', N'2019', 1, CAST(N'2021-01-19T18:13:19.230' AS DateTime), CAST(N'2024-01-19T18:13:53.117' AS DateTime), 25)
INSERT [dbo].[Programs] ([prnum], [prnam], [version], [license], [inst_dat], [expr_dat], [value]) VALUES (4, N'dfhsjgsgsfk', N'fhsfjfgjk', 3, CAST(N'2021-01-29T20:11:39.087' AS DateTime), CAST(N'2521-01-29T20:11:45.783' AS DateTime), 50)
GO
INSERT [dbo].[ProgUpd] ([Years], [All_Upd], [Upd]) VALUES (2024, 9, 4)
INSERT [dbo].[ProgUpd] ([Years], [All_Upd], [Upd]) VALUES (2521, 1, 0)
INSERT [dbo].[ProgUpd] ([Years], [All_Upd], [Upd]) VALUES (2020, 13, 11)
INSERT [dbo].[ProgUpd] ([Years], [All_Upd], [Upd]) VALUES (2021, 18, 5)
INSERT [dbo].[ProgUpd] ([Years], [All_Upd], [Upd]) VALUES (2022, 12, 5)
INSERT [dbo].[ProgUpd] ([Years], [All_Upd], [Upd]) VALUES (2023, 22, 16)
GO
INSERT [dbo].[Sotr] ([snum], [snam], [pass], [role]) VALUES (1, N'Admin', N'TmZT9ywVjiKvfEVn', N'Администратор')
INSERT [dbo].[Sotr] ([snum], [snam], [pass], [role]) VALUES (2, N'User', N'j4zgdzqwmwVgeZeN', N'Преподаватель')
INSERT [dbo].[Sotr] ([snum], [snam], [pass], [role]) VALUES (3, N'Admin1', N'v9syAQwF1cD02kCK', N'Преподаватель')
GO
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (1, N'Сандова', N'Эльвира', N'Геннадьевна', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (2, N'Вольхина', N'Кристина', N'Сергеевна', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (3, N'Кононова', N'Ольга', N'Александровна', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (4, N'fgjdgj', N'fgjhdfgj', N'dtjdfj', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (5, N'hjf', N''';kl'';k', N'hjfhgf', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (6, N'арвоапо', N'атапо', N'авоап', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (7, N'Правывсы', N'fиррив', N'fesfsамв', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (8, N'рвар', N'вара', N'аоао', N'Преподаватель')
INSERT [dbo].[Teachers] ([tnum], [tfam], [tnam], [totch], [dolg]) VALUES (9, N'dgsg', N'sgs', N'sdgs', N'Преподаватель')
GO
ALTER TABLE [dbo].[Install]  WITH CHECK ADD  CONSTRAINT [FK_Install_PC] FOREIGN KEY([pc])
REFERENCES [dbo].[PC] ([PCnum])
GO
ALTER TABLE [dbo].[Install] CHECK CONSTRAINT [FK_Install_PC]
GO
ALTER TABLE [dbo].[Install]  WITH CHECK ADD  CONSTRAINT [FK_Install_Programs] FOREIGN KEY([prog])
REFERENCES [dbo].[Programs] ([prnum])
GO
ALTER TABLE [dbo].[Install] CHECK CONSTRAINT [FK_Install_Programs]
GO
ALTER TABLE [dbo].[Kabs]  WITH CHECK ADD  CONSTRAINT [FK_Kabs_Teachers] FOREIGN KEY([teach])
REFERENCES [dbo].[Teachers] ([tnum])
GO
ALTER TABLE [dbo].[Kabs] CHECK CONSTRAINT [FK_Kabs_Teachers]
GO
ALTER TABLE [dbo].[PC]  WITH CHECK ADD  CONSTRAINT [FK_PC_Kabs] FOREIGN KEY([Kab])
REFERENCES [dbo].[Kabs] ([knum])
GO
ALTER TABLE [dbo].[PC] CHECK CONSTRAINT [FK_PC_Kabs]
GO
ALTER TABLE [dbo].[Prepodav]  WITH CHECK ADD  CONSTRAINT [FK_Prepodav_Predmet] FOREIGN KEY([pnum])
REFERENCES [dbo].[Predmet] ([pnum])
GO
ALTER TABLE [dbo].[Prepodav] CHECK CONSTRAINT [FK_Prepodav_Predmet]
GO
ALTER TABLE [dbo].[Prepodav]  WITH CHECK ADD  CONSTRAINT [FK_Prepodav_Teachers] FOREIGN KEY([tnum])
REFERENCES [dbo].[Teachers] ([tnum])
GO
ALTER TABLE [dbo].[Prepodav] CHECK CONSTRAINT [FK_Prepodav_Teachers]
GO
ALTER TABLE [dbo].[ProgPred]  WITH CHECK ADD  CONSTRAINT [FK_ProgPred_Predmet] FOREIGN KEY([predm])
REFERENCES [dbo].[Predmet] ([pnum])
GO
ALTER TABLE [dbo].[ProgPred] CHECK CONSTRAINT [FK_ProgPred_Predmet]
GO
ALTER TABLE [dbo].[ProgPred]  WITH CHECK ADD  CONSTRAINT [FK_ProgPred_Programs] FOREIGN KEY([prog])
REFERENCES [dbo].[Programs] ([prnum])
GO
ALTER TABLE [dbo].[ProgPred] CHECK CONSTRAINT [FK_ProgPred_Programs]
GO
ALTER TABLE [dbo].[Programs]  WITH CHECK ADD  CONSTRAINT [FK_Programs_License] FOREIGN KEY([license])
REFERENCES [dbo].[License] ([lnum])
GO
ALTER TABLE [dbo].[Programs] CHECK CONSTRAINT [FK_Programs_License]
GO
/****** Object:  Trigger [dbo].[ins_ins]    Script Date: 29.01.2021 21:40:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_ins] on [dbo].[Install] instead of insert
as
	declare @prog int, @pc int

	select @prog = prog, @pc = pc from inserted ins

	if exists(select * from Install where prog = @prog and pc = @pc)
	begin
		Print('Запись уже существует');
		
	end
	else
	insert into Install values (@prog,@pc)
GO
ALTER TABLE [dbo].[Install] ENABLE TRIGGER [ins_ins]
GO
/****** Object:  Trigger [dbo].[del_kab]    Script Date: 29.01.2021 21:40:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[del_kab] on [dbo].[Kabs] instead of delete
as 
	declare @knum int, @knam nvarchar(25), @teach int
	
	

	select @knum = knum, @knam = knam, @teach = teach from deleted

	if exists(select * from PC where kab = @knum)
	begin
		delete from PC where kab = @knum
		
	end
	
	delete from kabs where knum = @knum

GO
ALTER TABLE [dbo].[Kabs] ENABLE TRIGGER [del_kab]
GO
/****** Object:  Trigger [dbo].[ins_kab]    Script Date: 29.01.2021 21:40:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_kab] on [dbo].[Kabs] instead of insert
as 
	declare @knum int, @knam nvarchar(25), @teach int
	
	if exists(select * from Kabs where knum > 0)
		select @knum = Max(knum) from Kabs
	else
		select @knum = 0

	select @knam = knam, @teach = teach from inserted ins

	if exists(select * from Kabs where knam = @knam and teach = @teach)
	begin
		Print('Запись уже существует')
		
	end
	else
		insert into Kabs values (@knum + 1,@knam,@teach)

GO
ALTER TABLE [dbo].[Kabs] ENABLE TRIGGER [ins_kab]
GO
/****** Object:  Trigger [dbo].[upd_kab]    Script Date: 29.01.2021 21:40:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[upd_kab] on [dbo].[Kabs] instead of update
as 
	declare @knum int, @knam nvarchar(25), @teach int

	select @knum = knum, @knam = knam, @teach = teach from inserted

	if exists(select * from Kabs where knam = @knam and teach = @teach and not knum = @knum)
	begin
		Print('Запись уже существует')
		
	end
	else
		Update Kabs set knam = @knam, teach = @teach where knum = @knum

GO
ALTER TABLE [dbo].[Kabs] ENABLE TRIGGER [upd_kab]
GO
/****** Object:  Trigger [dbo].[del_lic]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[del_lic] on [dbo].[License] instead of delete
as 
	declare @lnum int, @lnam nvarchar(100), @dlit int
	
	

	select @lnum = lnum, @lnam = lnam, @dlit = dlit from deleted
	if exists(select * from Programs where license = @lnum)
	begin
		Print('Существуют программы с данной лицензией')
		
	end
	else
		delete from License where lnum = @lnum
GO
ALTER TABLE [dbo].[License] ENABLE TRIGGER [del_lic]
GO
/****** Object:  Trigger [dbo].[ins_lic]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_lic] on [dbo].[License] instead of insert
as 
	declare @lnum int, @lnam nvarchar(100), @dlit int
	
	if exists(select * from License where lnum > 0)
		select @lnum = Max(lnum) from License
	else
		select @lnum = 0

	select @lnam = lnam, @dlit = dlit from inserted ins
	if exists(select * from License where lnam = @lnam and dlit = @dlit)
	begin
		Print('Запись уже существует')
		
	end
	else
		insert into License values (@lnum + 1,@lnam,@dlit)
GO
ALTER TABLE [dbo].[License] ENABLE TRIGGER [ins_lic]
GO
/****** Object:  Trigger [dbo].[upd_lic]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[upd_lic] on [dbo].[License] instead of update
as 
	declare @lnum int, @lnam nvarchar(100), @dlit int
	
	

	select @lnum = lnum, @lnam = lnam, @dlit = dlit from inserted ins

	if exists(select * from License where lnam = @lnam and dlit = @dlit and not lnum = @lnum)
	begin
		Print('Запись уже существует')
		
	end
	else
		Update License set lnam = @lnam, dlit = @dlit where lnum = @lnum
GO
ALTER TABLE [dbo].[License] ENABLE TRIGGER [upd_lic]
GO
/****** Object:  Trigger [dbo].[del_pc]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[del_pc] on [dbo].[PC] instead of delete
as 
	declare @pcnum int, @pcnet nvarchar(50), @kab int
	
	

	select @pcnum = pcnum, @pcnet = pcnet, @kab = kab from deleted
	if exists(select * from Install where pc = @pcnum)
	begin
		delete from Install where pc = @pcnum
		
	end
	delete from PC where pcnum = @pcnum
GO
ALTER TABLE [dbo].[PC] ENABLE TRIGGER [del_pc]
GO
/****** Object:  Trigger [dbo].[ins_pc]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_pc] on [dbo].[PC] instead of insert
as 
	declare @pcnum int, @pcnet nvarchar(50), @kab int
	
	if exists(select * from PC where pcnum > 0)
		select @pcnum = Max(pcnum) from PC
	else
		select @pcnum = 0

	select @pcnet = pcnet, @kab = kab from inserted ins
	if exists(select * from pc where pcnet = @pcnet and kab = @kab)
	begin
		Print('Запись уже существует')
		
	end
	else
	insert into PC values (@pcnum + 1,@pcnet,@kab)
GO
ALTER TABLE [dbo].[PC] ENABLE TRIGGER [ins_pc]
GO
/****** Object:  Trigger [dbo].[upd_pc]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[upd_pc] on [dbo].[PC] instead of Update
as 
	declare @pcnum int, @pcnet nvarchar(50), @kab int
	
	

	select @pcnum = pcnum, @pcnet = pcnet, @kab = kab from inserted ins
	if exists(select * from pc where pcnet = @pcnet and kab = @kab and not PCnum = @pcnum)
	begin
		Print('Запись уже существует')
		
	end
	else
	Update PC set pcnet = @pcnet, kab = @kab where pcnum = @pcnum
GO
ALTER TABLE [dbo].[PC] ENABLE TRIGGER [upd_pc]
GO
/****** Object:  Trigger [dbo].[del_pred]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[del_pred] on [dbo].[Predmet] instead of delete
as 
	declare @pnum int, @pnam nvarchar(100), @hours int, @spec nvarchar(40)
	
	

	select @pnum = pnum, @pnam = pnam, @hours = lab_hours, @spec = spec from deleted
	if exists(select * from prepodav where pnum = @pnum)
		delete from prepodav where pnum = @pnum
	if exists(select * from progpred where predm = @pnum)
		delete from progpred where predm = @pnum
	delete from Predmet where pnum = @pnum
GO
ALTER TABLE [dbo].[Predmet] ENABLE TRIGGER [del_pred]
GO
/****** Object:  Trigger [dbo].[ins_pred]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_pred] on [dbo].[Predmet] instead of insert
as 
	declare @pnum int, @pnam nvarchar(100), @hours int, @spec nvarchar(40)
	
	if exists(select * from Predmet where pnum > 0)
		select @pnum = Max(pnum) from Predmet
	else
		select @pnum = 0

	select @pnam = pnam, @hours = lab_hours, @spec = spec from inserted ins
	if exists(select * from Predmet where pnam = @pnam and lab_hours = @hours and spec = @spec)
	begin
		Print('Запись уже существует')
		
	end
	else
	insert into Predmet values (@pnum + 1,@pnam,@hours,@spec)
GO
ALTER TABLE [dbo].[Predmet] ENABLE TRIGGER [ins_pred]
GO
/****** Object:  Trigger [dbo].[upd_pred]    Script Date: 29.01.2021 21:40:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[upd_pred] on [dbo].[Predmet] instead of update
as 
	declare @pnum int, @pnam nvarchar(100), @hours int, @spec nvarchar(40)
	
	

	select @pnum = pnum, @pnam = pnam, @hours = lab_hours, @spec = spec from inserted ins
	if exists(select * from Predmet where pnam = @pnam and lab_hours = @hours and spec = @spec and not pnum = @pnum)
	begin
		Print('Запись уже существует')
		
	end
	else
	Update Predmet set pnam = @pnam,lab_hours = @hours,spec = @spec where pnum = @pnum
GO
ALTER TABLE [dbo].[Predmet] ENABLE TRIGGER [upd_pred]
GO
/****** Object:  Trigger [dbo].[ins_prepod]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[ins_prepod] on [dbo].[Prepodav] instead of insert
as 
	declare @tnum int, @pnum int

	select @tnum = tnum, @pnum = pnum from inserted ins

	if exists(select * from Prepodav where tnum = @tnum and pnum = @pnum)
	begin
		Print('Запись уже существует')
		
	end
	else
	insert into prepodav values (@tnum,@pnum)
GO
ALTER TABLE [dbo].[Prepodav] ENABLE TRIGGER [ins_prepod]
GO
/****** Object:  Trigger [dbo].[ins_progpred]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_progpred] on [dbo].[ProgPred] instead of insert
as 
	declare @prog int, @predm int

	select @prog = prog, @predm = predm from inserted ins

	if exists(select * from ProgPred where prog = @prog and predm = @predm)
	begin
		Print('Запись уже существует')
		
	end
	else
	insert into ProgPred values (@prog,@predm)
GO
ALTER TABLE [dbo].[ProgPred] ENABLE TRIGGER [ins_progpred]
GO
/****** Object:  Trigger [dbo].[del_prog]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[del_prog] on [dbo].[Programs] instead of delete
as 
	declare @prnum int, @prnam nvarchar(100), @vers nvarchar(50), @lice int, @inst datetime, @expr datetime, @value int
	
	

	select @prnum = prnum, @prnam = prnam, @vers = version, @lice = license, @inst = inst_dat, @expr = expr_dat, @value = value from deleted

	if exists(select * from progpred where prog = @prnum)
		delete from progpred where prog = @prnum
	if exists(select * from install where prog = @prnum)
		delete from install where prog = @prnum
	update progUpd set all_upd = all_upd - 1 where years = datepart(yy,@expr)
	delete from Programs where prnum = @prnum
GO
ALTER TABLE [dbo].[Programs] ENABLE TRIGGER [del_prog]
GO
/****** Object:  Trigger [dbo].[ins_prog]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_prog] on [dbo].[Programs] instead of insert
as 
	declare @prnum int, @prnam nvarchar(100), @vers nvarchar(50), @lice int, @inst datetime, @expr datetime, @value int
	
	if exists(select * from Programs where prnum > 0)
		select @prnum = Max(prnum) from Programs
	else
		select @prnum = 0

	select @prnam = prnam, @vers = version, @lice = license, @inst = inst_dat, @expr = expr_dat, @value = value from inserted ins

	if exists(select * from programs where  prnam =  @prnam and version = @vers and license = @lice and inst_dat = @inst and expr_dat = @expr and value = @value)
	begin
		Print('Запись уже существует')
		
	end
	else
	Begin
	insert into Programs values (@prnum + 1,@prnam,@vers,@lice,@inst,@expr,@value)
	if exists (select * from ProgUpd where years = datepart(yy,@expr))
		Update ProgUpd set All_upd= All_Upd+1
	else
		Begin
			insert into ProgUpd (Years,All_Upd,Upd) values (DATEPART(yy,@expr),1,0)
			
		end
	end
GO
ALTER TABLE [dbo].[Programs] ENABLE TRIGGER [ins_prog]
GO
/****** Object:  Trigger [dbo].[upd_prog]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[upd_prog] on [dbo].[Programs] instead of update
as 
	declare @prnum int, @prnam nvarchar(100), @vers nvarchar(50), @lice int, @inst datetime, @expr datetime, @value int
	
	

	select @prnum = prnum, @prnam = prnam, @vers = version, @lice = license, @inst = inst_dat, @expr = expr_dat, @value = value from inserted ins

	if exists(select * from programs where  prnam =  @prnam and version = @vers and license = @lice and inst_dat = @inst and expr_dat = @expr and value = @value and not prnum = @prnum)
	begin
		Print('Запись уже существует')
		
	end
	else
	update Programs set prnam = @prnam,version = @vers,license = @lice,inst_dat = @inst,expr_dat = @expr,value = @value where prnum = @prnum
GO
ALTER TABLE [dbo].[Programs] ENABLE TRIGGER [upd_prog]
GO
/****** Object:  Trigger [dbo].[ins_sotr]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_sotr] on [dbo].[Sotr] instead of insert
as 
	declare @snum int, @snam nvarchar(50), @pass nvarchar(50), @role nvarchar(50)
	
	if exists(select * from Sotr where snum > 0)
		select @snum = Max(snum) from Sotr
	else
		select @snum = 0

	select @snam = snam, @pass = pass, @role = role from inserted ins
	if exists(select * from sotr where snam = @snam)
	begin
		Print('Пользователь с таким именем существует')
		
	end
	else
	insert into Sotr values (@snum + 1,@snam,@pass, @role)
GO
ALTER TABLE [dbo].[Sotr] ENABLE TRIGGER [ins_sotr]
GO
/****** Object:  Trigger [dbo].[upd_sotr]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[upd_sotr] on [dbo].[Sotr] instead of update
as 
	declare @snum int, @snam nvarchar(50), @pass nvarchar(50), @role nvarchar(50)
	
	

	select @snum = snum, @snam = snam, @pass = pass, @role = role from inserted ins
	if exists(select * from sotr where pass = @pass)
	begin
		Print('Введите другой пароль')
		
	end
	else
	update Sotr set snam = @snam, pass = @pass, role = @role where snum = @snum
GO
ALTER TABLE [dbo].[Sotr] ENABLE TRIGGER [upd_sotr]
GO
/****** Object:  Trigger [dbo].[del_teach]    Script Date: 29.01.2021 21:40:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[del_teach] on [dbo].[Teachers] instead of delete
as 
	declare @tnum int, @tfam nvarchar(50), @tnam nvarchar(50), @totch nvarchar(50), @dolg nvarchar(50)
	
	

	select @tnum = tnum, @tfam = tfam, @tnam = tnam, @totch = totch, @dolg = dolg from deleted

	if exists(select * from prepodav where  tnum = @tnum)
		delete from prepodav where tnum = @tnum
	if exists (select * from Kabs where teach = @tnum)
		update kabs set teach = null where teach = @tnum
	delete from Teachers where tnum = @tnum
GO
ALTER TABLE [dbo].[Teachers] ENABLE TRIGGER [del_teach]
GO
/****** Object:  Trigger [dbo].[ins_teach]    Script Date: 29.01.2021 21:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[ins_teach] on [dbo].[Teachers] instead of insert
as 
	declare @tnum int, @tfam nvarchar(50), @tnam nvarchar(50), @totch nvarchar(50), @dolg nvarchar(50)
	
	if exists(select * from Teachers where tnum > 0)
		select @tnum = Max(tnum) from Teachers
	else
		select @tnum = 0

	select @tfam = tfam, @tnam = tnam, @totch = totch, @dolg = dolg from inserted ins

	if exists(select * from teachers where  tfam =  @tfam and tnam = @tnam and totch = @totch and dolg = @dolg)
	begin
		Print('Запись уже существует')
		
	end
	else
	insert into Teachers values (@tnum + 1,@tfam,@tnam,@totch,@dolg)
GO
ALTER TABLE [dbo].[Teachers] ENABLE TRIGGER [ins_teach]
GO
/****** Object:  Trigger [dbo].[upd_teach]    Script Date: 29.01.2021 21:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[upd_teach] on [dbo].[Teachers] instead of update
as 
	declare @tnum int, @tfam nvarchar(50), @tnam nvarchar(50), @totch nvarchar(50), @dolg nvarchar(50)
	
	

	select @tnum = tnum, @tfam = tfam, @tnam = tnam, @totch = totch, @dolg = dolg from inserted ins

	if exists(select * from teachers where  tfam =  @tfam and tnam = @tnam and totch = @totch and dolg = @dolg and not tnum = @tnum)
	begin
		Print('Запись уже существует')
		
	end
	else
	update Teachers set tfam = @tfam,tnam = @tnam,totch = @totch,dolg = @dolg where tnum = @tnum
GO
ALTER TABLE [dbo].[Teachers] ENABLE TRIGGER [upd_teach]
GO
