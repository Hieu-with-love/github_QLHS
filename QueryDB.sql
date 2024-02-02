DROP TABLE HocSinh
GO
DROP TABLE GiaoVien
GO

CREATE TABLE HocSinh(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	diachi nvarchar(150),
	ngaysinh date,
	email varchar(150),
	phone varchar(12),
	gioitinh int
)
GO

CREATE TABLE GiaoVien(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	diachi nvarchar(150),
	ngaysinh date,
	email varchar(150),
	phone varchar(12),
	gioitinh int
)
GO

SELECT * FROM HocSinh;
SELECT * FROM GiaoVien;

INSERT INTO HocSinh(hoten,diachi,ngaysinh,email,phone,gioitinh)
VALUES(N'Nguyễn Văn A',N'Bình Dương','20030807','anv@gmail.com','0877864325',0);

INSERT INTO GiaoVien(hoten,diachi,ngaysinh,email,phone,gioitinh)
VALUES(N'Trần Thị B',N'Đồng Nai','19871229','btt@gmail.com','0877864097',1);