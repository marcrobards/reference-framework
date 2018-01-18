USE [Exercise]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LuWorkoutType](
	[WorkoutTypeId] [int] IDENTITY(1,1) NOT NULL,
	[SportId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Order] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_LuWorkoutType] PRIMARY KEY CLUSTERED 
(
	[WorkoutTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [LuWorkoutType] ON 

INSERT [LuWorkoutType] ([WorkoutTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (1, 2, N'Run Indoors', 2, 1)
INSERT [LuWorkoutType] ([WorkoutTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (3, 2, N'Run Outside', 1, 1)
INSERT [LuWorkoutType] ([WorkoutTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (4, 1, N'Bike Indoors', 1, 1)
INSERT [LuWorkoutType] ([WorkoutTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (5, 1, N'Bike Outside', 2, 1)
INSERT [LuWorkoutType] ([WorkoutTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (6, 3, N'Ageless Fitness Workout', 1, 1)
INSERT [LuWorkoutType] ([WorkoutTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (7, 4, N'Yoga At Home', 1, 1)
INSERT [LuWorkoutType] ([WorkoutTypeId], [SportId], [Name], [Order], [IsActive]) VALUES (8, 4, N'Yoga Class', 2, 1)
SET IDENTITY_INSERT [LuWorkoutType] OFF
ALTER TABLE [LuWorkoutType] ADD  CONSTRAINT [DF_LuWorkoutType_Order]  DEFAULT ((0)) FOR [Order]
GO
ALTER TABLE [LuWorkoutType] ADD  CONSTRAINT [DF_LuWorkoutType_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [LuWorkoutType]  WITH CHECK ADD  CONSTRAINT [FK_LuWorkoutType_LuSport] FOREIGN KEY([SportId])
REFERENCES [LuSport] ([SportId])
GO
ALTER TABLE [LuWorkoutType] CHECK CONSTRAINT [FK_LuWorkoutType_LuSport]
GO
