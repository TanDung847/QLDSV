USE [QLDSV]
GO

/****** Object:  View [dbo].[v_dslop]    Script Date: 8/18/2018 3:45:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[v_dslop]
as
select l.malop, l.tenlop from lop l
GO

