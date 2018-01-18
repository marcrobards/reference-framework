USE [Exercise]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LuGearType](
	[GearTypeId] [int] IDENTITY(1,1) NOT NULL,
	[SportId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Order] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_LuGearType] PRIMARY KEY CLUSTERED 
(
	[GearTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [LuGearType] ON 

INSERT [LuGearType] ([GearTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (1, 1, N'Bike', 1, 1)
INSERT [LuGearType] ([GearTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (2, 2, N'Shoes', 1, 1)
SET IDENTITY_INSERT [LuGearType] OFF
ALTER TABLE [LuGearType] ADD  CONSTRAINT [DF_LuGearType_Order]  DEFAULT ((0)) FOR [Order]
GO
ALTER TABLE [LuGearType] ADD  CONSTRAINT [DF_LuGearType_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [LuGearType]  WITH CHECK ADD  CONSTRAINT [FK_LuGearType_LuSport] FOREIGN KEY([SportId])
REFERENCES [LuSport] ([SportId])
GO
ALTER TABLE [LuGearType] CHECK CONSTRAINT [FK_LuGearType_LuSport]
GO
