DROP TABLE HocSinh
GO

CREATE TABLE HocSinh(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	diachi nvarchar(150),
	ngaysinh date,
	email varchar(150),
	phone varchar(12),
	gioitinh int,
	cmnd varchar(20)
)
GO
DROP TABLE GiaoVien
GO

CREATE TABLE GiaoVien(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	diachi nvarchar(150),
	ngaysinh date,
	email varchar(150),
	phone varchar(12),
	gioitinh int,
	cmnd varchar(20)
)
GO

SELECT * FROM HocSinh;
SELECT * FROM GiaoVien;

INSERT INTO HocSinh(hoten,diachi,ngaysinh,email,phone,gioitinh,cmnd)
VALUES(N'Nguyễn Văn A',N'Bình Dương','20030807','anv@gmail.com','0877864325',0,524211334455);

INSERT INTO GiaoVien(hoten,diachi,ngaysinh,email,phone,gioitinh,cmnd)
VALUES(N'Trần Thị B',N'Đồng Nai','19871229','btt@gmail.com','0877864097',1,524211334466);