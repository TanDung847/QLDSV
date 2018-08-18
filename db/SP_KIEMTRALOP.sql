USE [QLDSV]
GO

/****** Object:  StoredProcedure [dbo].[sp_KiemTraLop]    Script Date: 8/18/2018 3:44:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_KiemTraLop] 
@malop char(8), @tenlop nvarchar(80), @ret int out
as
declare @check char(8)
set @ret = 0
IF EXISTS (select l.malop from dbo.Lop l
where l.MALOP = @malop or l.TENLOP = @tenlop)
	begin
	set @ret = 1
	end
else
begin
	IF EXISTS (select l.malop from LINK1.QLDSV.dbo.LOP l 
	where l.MALOP = @malop or l.TENLOP = @tenlop)
	begin
		set @ret = 2
	end
end

GO

