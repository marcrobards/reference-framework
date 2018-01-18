USE [Exercise]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [LuGender](
	[GenderId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_LuGender] PRIMARY KEY CLUSTERED 
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [LuGender] ON 

INSERT [LuGender] ([GenderId], [Name], [Description], [IsActive]) VALUES (1, N'F', N'Female', 1)
INSERT [LuGender] ([GenderId], [Name], [Description], [IsActive]) VALUES (2, N'M', N'Male', 1)
INSERT [LuGender] ([GenderId], [Name], [Description], [IsActive]) VALUES (3, N'U', N'Unknown', 1)
SET IDENTITY_INSERT [LuGender] OFF
ALTER TABLE [LuGender] ADD  CONSTRAINT [DF_LuGender_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
