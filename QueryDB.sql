DROP TABLE HocSinh;
GO

CREATE TABLE HocSinh(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	diachi nvarchar(150),
	ngaysinh date 
)
GO

INSERT INTO HocSinh(hoten,diachi,ngaysinh)
VALUES (N'Nguyễn Văn A', N'Bình Dương', '20030912');

SELECT * FROM HocSinh;