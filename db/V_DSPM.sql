USE [QLDSV]
GO

/****** Object:  View [dbo].[V_DSPM]    Script Date: 8/5/2018 11:12:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[V_DSPM]
AS
SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
 FROM sysmergepublications  PUBS, sysmergesubscriptions SUBS
 WHERE PUBS.pubid = SUBS.pubid AND publisher<>subscriber_server

GO


