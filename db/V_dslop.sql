USE [QLDSV]
GO

/****** Object:  View [dbo].[v_dslop]    Script Date: 8/15/2018 10:42:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[v_dslop]
as
select l.malop, l.tenlop from lop l

GO


