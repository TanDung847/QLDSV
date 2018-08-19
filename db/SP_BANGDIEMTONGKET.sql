create proc sp_BANGDIEMTONGKET
@malop char(8)
AS
declare @cols nvarchar(max)
declare @sql nvarchar(max)
set @cols = STUFF(
(SELECT DISTINCT ',[' + MH.TENMH + ']' FROM MONHOC MH GROUP BY MH.TENMH FOR XML PATH(''))
, 1, 1, '');
set @sql = '
WITH RESULT
AS
(
  SELECT SV.HO + '' '' + SV.TEN ''Ho Ten'',MH.TENMH, MAX(D.DIEM) DIEM FROM SINHVIEN SV
JOIN DIEM D
ON SV.MASV = D.MASV
JOIN MONHOC MH
ON MH.MAMH = D.MAMH
WHERE SV.MALOP = ''' + @malop +'''
GROUP BY SV.HO, SV.TEN, MH.TENMH
)
SELECT * FROM RESULT
PIVOT (MAX(DIEM) FOR TENMH IN (' + @cols + ')) AS Pivoted;
';
EXEC sp_executesql @sql