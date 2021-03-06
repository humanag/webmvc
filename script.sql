/****** Object:  Database [MVC]    Script Date: 2020-07-09 11:23:38 PM ******/
CREATE DATABASE [MVC]
GO
use [MVC]
GO
/****** Object:  Table [dbo].[Blog]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Content] [ntext] NULL,
	[Image] [varchar](250) NULL,
	[CategoryId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [bigint] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [bigint] NULL,
	[Visible] [bit] NULL,
	[Sort] [int] NULL,
	[Views] [int] NULL,
	[MetaTitle] [nvarchar](250) NULL,
 CONSTRAINT [PK_Blog] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BlogCategory]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BlogCategory](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[ParentId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [bigint] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [bigint] NULL,
	[Visible] [bit] NULL,
	[Sort] [int] NULL,
 CONSTRAINT [PK_BlogCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[ParentId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [bigint] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [bigint] NULL,
	[Visible] [bit] NULL,
	[Sort] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Code] [varchar](39) NULL,
	[MetaTitle] [nvarchar](250) NULL,
	[Description] [ntext] NULL,
	[Detail] [ntext] NULL,
	[Image] [varchar](250) NULL,
	[CategoryId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateBy] [bigint] NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateBy] [bigint] NULL,
	[Visible] [bit] NULL,
	[Sort] [int] NULL,
	[IsNew] [bit] NULL,
	[Views] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImage]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImage](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NULL,
	[path] [varchar](250) NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductRelation]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductRelation](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NULL,
	[RelationId] [bigint] NULL,
 CONSTRAINT [PK_ProductRelation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysBusiness]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysBusiness](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BusinessId] [varchar](64) NOT NULL,
	[BusinessName] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_dbo.SysBusiness] PRIMARY KEY CLUSTERED 
(
	[BusinessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysGrantPermission]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysGrantPermission](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PermissionId] [bigint] NOT NULL,
	[UID] [bigint] NOT NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_dbo.SysGrantPermission] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC,
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysParam]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysParam](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Type] [int] NULL,
	[Value] [nvarchar](250) NULL,
 CONSTRAINT [PK_SysParam] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysPermission]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysPermission](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[PermissionName] [varchar](250) NOT NULL,
	[Description] [nvarchar](250) NOT NULL,
	[BusinessId] [varchar](64) NOT NULL,
	[Visible] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.SysPermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUser]    Script Date: 2020-07-09 11:23:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUser](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](64) NOT NULL,
	[FullName] [nvarchar](250) NOT NULL,
	[PassWD] [varchar](64) NULL,
	[Email] [nvarchar](250) NULL,
 CONSTRAINT [PK_dbo.SysUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_PermissionId]    Script Date: 2020-07-09 11:23:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_PermissionId] ON [dbo].[SysGrantPermission]
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UID]    Script Date: 2020-07-09 11:23:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_UID] ON [dbo].[SysGrantPermission]
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SysParam]    Script Date: 2020-07-09 11:23:39 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SysParam] ON [dbo].[SysParam]
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_BusinessId]    Script Date: 2020-07-09 11:23:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_BusinessId] ON [dbo].[SysPermission]
(
	[BusinessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Blog] ADD  CONSTRAINT [DF_News_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Blog] ADD  CONSTRAINT [DF_News_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[Blog] ADD  CONSTRAINT [DF_News_Visible]  DEFAULT ((0)) FOR [Visible]
GO
ALTER TABLE [dbo].[BlogCategory] ADD  CONSTRAINT [DF_NewsCategory_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[BlogCategory] ADD  CONSTRAINT [DF_NewsCategory_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[BlogCategory] ADD  CONSTRAINT [DF_NewsCategory_Visible]  DEFAULT ((1)) FOR [Visible]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_InVisible]  DEFAULT ((1)) FOR [Visible]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_InVisible]  DEFAULT ((0)) FOR [Visible]
GO
ALTER TABLE [dbo].[SysGrantPermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SysGrantPermission_dbo.SysPermission_PermissionId] FOREIGN KEY([PermissionId])
REFERENCES [dbo].[SysPermission] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysGrantPermission] CHECK CONSTRAINT [FK_dbo.SysGrantPermission_dbo.SysPermission_PermissionId]
GO
ALTER TABLE [dbo].[SysGrantPermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SysGrantPermission_dbo.SysUser_UID] FOREIGN KEY([UID])
REFERENCES [dbo].[SysUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysGrantPermission] CHECK CONSTRAINT [FK_dbo.SysGrantPermission_dbo.SysUser_UID]
GO
ALTER TABLE [dbo].[SysPermission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SysPermission_dbo.SysBusiness_BusinessId] FOREIGN KEY([BusinessId])
REFERENCES [dbo].[SysBusiness] ([BusinessId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SysPermission] CHECK CONSTRAINT [FK_dbo.SysPermission_dbo.SysBusiness_BusinessId]
GO
ALTER DATABASE [MVC] SET  READ_WRITE 
GO
