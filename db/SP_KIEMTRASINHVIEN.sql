USE [QLDSV]
GO

/****** Object:  StoredProcedure [dbo].[sp_KiemTraSinhVien]    Script Date: 8/18/2018 3:45:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_KiemTraSinhVien]
@masv char(8),
@ret int output
as
set @ret = 0
if exists (select sv.MASV from dbo.SINHVIEN sv where sv.MASV = @masv)
begin
	set @ret = 1
end
else 
begin
	if exists (select sv.MASV from LINK1.QLDSV.dbo.SINHVIEN sv where sv.MASV = @masv)
	begin
		set @ret = 2
	end
end


GO

