USE [QLDSV]
GO

/****** Object:  View [dbo].[V_dssv]    Script Date: 8/19/2018 3:50:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_dssv] as
select s.HO + ' ' + s.TEN 'Ho va Ten', s.MASV from sinhvien s
GO

