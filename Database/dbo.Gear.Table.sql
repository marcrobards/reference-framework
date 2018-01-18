USE [Exercise]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gear](
	[GearId] [int] IDENTITY(1,1) NOT NULL,
	[GearTypeId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Manufacturer] [nvarchar](100) NULL,
	[Model] [nvarchar](100) NULL,
	[Size] [nvarchar](50) NULL,
	[DatePurchased] [datetime] NULL,
	[CurrentMileage] [decimal](9, 2) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Gear] PRIMARY KEY CLUSTERED 
(
	[GearId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Gear] ADD  CONSTRAINT [DF_Gear_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [Gear] ADD  CONSTRAINT [DF_Gear_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [Gear]  WITH CHECK ADD  CONSTRAINT [FK_Gear_LuGearType] FOREIGN KEY([GearTypeId])
REFERENCES [LuGearType] ([GearTypeId])
GO
ALTER TABLE [Gear] CHECK CONSTRAINT [FK_Gear_LuGearType]
GO
