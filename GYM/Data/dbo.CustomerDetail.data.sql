SET IDENTITY_INSERT [dbo].[CustomerDetail] ON
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (1, N'Sunny', N'Sharma', N'14-05-1999', N'34 tearoha', N'male')
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (2, N'Navjot', N'Kaur', N'11-06-1888', N'10 te aroha street', N'Female')
INSERT INTO [dbo].[CustomerDetail] ([CustomerID], [Firstname], [Lastname], [DoB], [Address], [Sex]) VALUES (3, N'Linda', N'Lilly', N'22-03-2000', N'55 maitland street', N'Female')
SET IDENTITY_INSERT [dbo].[CustomerDetail] OFF
