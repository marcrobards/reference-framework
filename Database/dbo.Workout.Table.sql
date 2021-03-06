SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Workout](
	[WorkoutId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[WorkoutTypeId] [int] NOT NULL,
	[Description] [nvarchar](255) NULL,
	[WorkoutDateTime] [smalldatetime] NOT NULL,
	[WorkoutDuration] [decimal](18, 0) NULL,
	[PerceivedExertionId] [int] NULL,
	[NormalizedPower] [decimal](18, 0) NULL,
	[TrainingStressScore] [int] NULL,
	[AveragePace] [decimal](18, 0) NULL,
	[Distance] [decimal](18, 0) NULL,
	[Route] [nvarchar](100) NULL,
	[GearId] [int] NULL,
	[Notes] [text] NULL,
	[IsCompleted] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Workout] PRIMARY KEY CLUSTERED 
(
	[WorkoutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [Workout]  WITH CHECK ADD  CONSTRAINT [FK_Workout_Gear] FOREIGN KEY([GearId])
REFERENCES [Gear] ([GearId])
GO
ALTER TABLE [Workout] CHECK CONSTRAINT [FK_Workout_Gear]
GO
ALTER TABLE [Workout]  WITH CHECK ADD  CONSTRAINT [FK_Workout_LuPerceivedExertion] FOREIGN KEY([PerceivedExertionId])
REFERENCES [LuPerceivedExertion] ([PerceivedExertionId])
GO
ALTER TABLE [Workout] CHECK CONSTRAINT [FK_Workout_LuPerceivedExertion]
GO
ALTER TABLE [Workout]  WITH CHECK ADD  CONSTRAINT [FK_Workout_LuWorkoutType] FOREIGN KEY([WorkoutTypeId])
REFERENCES [LuWorkoutType] ([WorkoutTypeId])
GO
ALTER TABLE [Workout] CHECK CONSTRAINT [FK_Workout_LuWorkoutType]
GO
ALTER TABLE [Workout]  WITH CHECK ADD  CONSTRAINT [FK_Workout_User] FOREIGN KEY([UserId])
REFERENCES [User] ([UserId])
GO
ALTER TABLE [Workout] CHECK CONSTRAINT [FK_Workout_User]
GO
