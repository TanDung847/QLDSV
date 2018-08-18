USE [QLDSV]
GO

/****** Object:  View [dbo].[v_dsmh]    Script Date: 8/19/2018 2:43:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[v_dsmh]
as
select mh.TENMH, mh.MAMH from MONHOC mh

GO

