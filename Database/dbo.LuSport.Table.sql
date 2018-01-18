USE [Exercise]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LuSport](
	[SportId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_LuSport] PRIMARY KEY CLUSTERED 
(
	[SportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [LuSport] ON 

INSERT [LuSport] ([SportId], [Name], [Description], [IsActive]) VALUES (1, N'Bike', N'Cycling', 1)
INSERT [LuSport] ([SportId], [Name], [Description], [IsActive]) VALUES (2, N'Run', N'Running', 1)
INSERT [LuSport] ([SportId], [Name], [Description], [IsActive]) VALUES (3, N'Strength', N'Bodyweight & Weight Workout', 1)
INSERT [LuSport] ([SportId], [Name], [Description], [IsActive]) VALUES (4, N'Yoga', N'Yoga', 1)
SET IDENTITY_INSERT [LuSport] OFF
ALTER TABLE [LuSport] ADD  CONSTRAINT [DF_LuSport_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
