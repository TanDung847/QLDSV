USE [QLDSV]
GO

/****** Object:  View [dbo].[v_dskhoa]    Script Date: 8/18/2018 3:45:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[v_dskhoa]
as
select MAKH, TENKH from KHOA
GO

