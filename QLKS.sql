create table PHONG(
MaPhong nchar(10) not null primary key,
Tinhtrang nvarchar(50),
Giaphong nvarchar(50),
Loaiphong nvarchar(50)
)
create TABLE KHACHHANG(
 Socmnd nvarchar(50) not null Primary key,
 Hoten nvarchar(50) ,
 Diachi  nvarchar(50),
 Sdt  nvarchar(50),
MaPhong nchar(10) REFERENCES PHONG(MaPhong),
Ngayden  nvarchar(50),
Ngaytra  nvarchar(50)
)
create table DICHVU(
 Madv nchar(10) not null primary key,
 Tendv nvarchar(50),
 Giadv nvarchar(50)
)
create table DICHVUSUDUNG(
Socmnd nvarchar(50) REFERENCES KHACHHANG(Socmnd),
 
Madv nchar(10) REFERENCES DICHVU(Madv),
Soluong int,
Thanhtoan float
) 