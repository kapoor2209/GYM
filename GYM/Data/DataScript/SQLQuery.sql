SET IDENTITY_INSERT [dbo].[CustomerDetail] ON
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (1, N'Jamifar', N'Bingo', N'11-6-2020', N'6 maitland street', N'Female')
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (2, N'Mark', N'Lucci', N'22-7-1999', N'55 fow street', N'Male')
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (3, N'Virat', N'Kholi', N'11-6-2020', N'55 fow street', N'Male')
SET IDENTITY_INSERT [dbo].[CustomerDetail] OFF

SET IDENTITY_INSERT [dbo].[Exersice] ON
INSERT INTO [dbo].[Exersice] ([ExcerciseID], [ExersiceName], [TimeDuration], [Advantage], [Disadvantage]) VALUES (1, N'Bench Press', N'2021-01-26 06:23:00', N'Good chest shape', N'Heavy')
INSERT INTO [dbo].[Exersice] ([ExcerciseID], [ExersiceName], [TimeDuration], [Advantage], [Disadvantage]) VALUES (2, N'Biceps Curl', N'2021-01-26 08:24:00', N'Nice Peak', N'Painful')
INSERT INTO [dbo].[Exersice] ([ExcerciseID], [ExersiceName], [TimeDuration], [Advantage], [Disadvantage]) VALUES (3, N'Triceps', N'2021-01-26 09:24:00', N'Good arm size', N'Heavy')
SET IDENTITY_INSERT [dbo].[Exersice] OFF

SET IDENTITY_INSERT [dbo].[ExpTrainer] ON
INSERT INTO [dbo].[ExpTrainer] ([ID], [TrainerID], [ExersiceID]) VALUES (1, 1, 1)
INSERT INTO [dbo].[ExpTrainer] ([ID], [TrainerID], [ExersiceID]) VALUES (2, 2, 2)
INSERT INTO [dbo].[ExpTrainer] ([ID], [TrainerID], [ExersiceID]) VALUES (3, 2, 3)
SET IDENTITY_INSERT [dbo].[ExpTrainer] OFF

SET IDENTITY_INSERT [dbo].[Trainer] ON
INSERT INTO [dbo].[Trainer] ([TrainerID], [Trainername], [Phone], [Address], [Sex], [CostPerHour]) VALUES (1, N'Jenny', N'022345678', N'34 memorial drive', N'Female', N'$30')
INSERT INTO [dbo].[Trainer] ([TrainerID], [Trainername], [Phone], [Address], [Sex], [CostPerHour]) VALUES (2, N'John', N'087585325', N'55 fow street', N'Male', N'$32')
SET IDENTITY_INSERT [dbo].[Trainer] OFF

SET IDENTITY_INSERT [dbo].[CustomerDetail] ON
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (1, N'Sunny', N'Sharma', N'14-05-1999', N'34 tearoha', N'male')
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (2, N'Navjot', N'Kaur', N'11-06-1888', N'10 te aroha street', N'Female')
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (3, N'Linda', N'Lilly', N'22-03-2000', N'55 maitland street', N'Female')
SET IDENTITY_INSERT [dbo].[CustomerDetail] OFF

SET IDENTITY_INSERT [dbo].[Exersice] ON
INSERT INTO [dbo].[Exersice] ([ExcerciseID], [ExersiceName], [TimeDuration], [Advantage], [Disadvantage]) VALUES (1, N'Bench Press', N'2021-01-27 11:00:00', N'good shape', N'painful')
INSERT INTO [dbo].[Exersice] ([ExcerciseID], [ExersiceName], [TimeDuration], [Advantage], [Disadvantage]) VALUES (2, N'Bicep Curls', N'2021-01-27 12:14:00', N'good shape', N'painful')
INSERT INTO [dbo].[Exersice] ([ExcerciseID], [ExersiceName], [TimeDuration], [Advantage], [Disadvantage]) VALUES (3, N'Triceps', N'2021-01-27 13:12:00', N'good shape', N'painful')
SET IDENTITY_INSERT [dbo].[Exersice] OFF

SET IDENTITY_INSERT [dbo].[ExpTrainer] ON
INSERT INTO [dbo].[ExpTrainer] ([ID], [TrainerID], [ExersiceID]) VALUES (1, 1, 1)
INSERT INTO [dbo].[ExpTrainer] ([ID], [TrainerID], [ExersiceID]) VALUES (2, 2, 2)
INSERT INTO [dbo].[ExpTrainer] ([ID], [TrainerID], [ExersiceID]) VALUES (3, 1, 3)
SET IDENTITY_INSERT [dbo].[ExpTrainer] OFF

SET IDENTITY_INSERT [dbo].[Trainer] ON
INSERT INTO [dbo].[Trainer] ([TrainerID], [Trainername], [Phone], [Address], [Sex], [CostPerHour]) VALUES (1, N'mark', N'0223337788', N'pyespa tauranga tauranga', N'male', N'$40')
INSERT INTO [dbo].[Trainer] ([TrainerID], [Trainername], [Phone], [Address], [Sex], [CostPerHour]) VALUES (2, N'jenny', N'0221007473', N'83 waterside Dr', N'Female', N'$40')
SET IDENTITY_INSERT [dbo].[Trainer] OFF
