USE [DoMin]
GO
/****** Object:  Table [dbo].[SaveScore]    Script Date: 1/25/2022 7:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaveScore](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiChoi] [nvarchar](50) NULL,
	[Score] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[SaveScore] ON 

INSERT [dbo].[SaveScore] ([ID], [TenNguoiChoi], [Score]) VALUES (1, N'Thiện', 5)
INSERT [dbo].[SaveScore] ([ID], [TenNguoiChoi], [Score]) VALUES (2, N'thien3721', 9)
INSERT [dbo].[SaveScore] ([ID], [TenNguoiChoi], [Score]) VALUES (3, N'Tien3821', 2)
INSERT [dbo].[SaveScore] ([ID], [TenNguoiChoi], [Score]) VALUES (5, N'thien', 7)
INSERT [dbo].[SaveScore] ([ID], [TenNguoiChoi], [Score]) VALUES (7, N'ThienTran', 10)
SET IDENTITY_INSERT [dbo].[SaveScore] OFF
