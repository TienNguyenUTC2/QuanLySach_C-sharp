create database BOOKSTORT

use BOOKSTORT

create table PhanQuyen
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	TenPhanQuyen nvarchar(50),
)

create table TaiKhoan
(
	IDTaiKhoan int IDENTITY(1,1) PRIMARY KEY,
	TenTaiKhoan nvarchar(50) NOT NULL,
	MatKhau nvarchar(50) NOT NULL,
	Email nvarchar(50) NOT NULL,
	SDT varchar(15),
	NgaySinh date,
	GioiTinh bit,
	ID int, 
	FOREIGN KEY (ID) REFERENCES PhanQuyen(ID), 
)


Select TaiKhoan.IDTaiKhoan, TaiKhoan.TenTaiKhoan,TaiKhoan.MatKhau,TaiKhoan.Email,TaiKhoan.NgaySinh ,PhanQuyen.TenPhanQuyen  from TaiKhoan , PhanQuyen 
where TaiKhoan.ID=PhanQuyen.ID

create table KhachHang
(
	IDKhachHang int IDENTITY(1,1) PRIMARY KEY,
	TenKhachHang nvarchar(50),
	SDT varchar(15),
	Email nvarchar(50),
	NgaySinh date,
	SoTienDaMua int,
	CapBac nvarchar(50),
	GioiTinh bit,
)

create table HoaDon
(
	IDHoaDon int IDENTITY(1,1) PRIMARY KEY,
	NgayInHoaDon date,
	GioInHoaDon time,
	TongTien int,
	IDTaiKhoan int,
	IDKhachHang int,
	FOREIGN KEY (IDTaiKhoan) REFERENCES TaiKhoan(IDTaiKhoan),
	FOREIGN KEY (IDKhachHang) REFERENCES KhachHang(IDKhachHang),
)
create table Sach
(
	IDSach int IDENTITY(1,1) PRIMARY KEY,
	TenSach nvarchar(50) NOT NULL,
	NXB nvarchar(50) NOT NULL,
	TenTacGia nvarchar(50) NOT NULL,
	Gia float(2),
	SoLuong int NOT NULL,
)

create table ChiTietHoaDon
(
	IDChiTietHoaDon int IDENTITY(1,1) PRIMARY KEY,
	SoLuong int,
	IDHoaDon int,
	IDSach int,
	FOREIGN KEY (IDHoaDon) REFERENCES HoaDon(IDHoaDon),
	FOREIGN KEY (IDSach) REFERENCES Sach(IDSach),
)
select IDHoaDon as N'ID HĐ' ,NgayInHoaDon as N'Ngày In HĐ', GioInHoaDon as N'Giờ In HĐ',TongTien as N'Tổng Tiền',TenKhachHang as N'Tên Khách Hàng' , TenTaiKhoan as N'Nhân Viên Bán' from HoaDon ,TaiKhoan,KhachHang where
HoaDon.IDTaiKhoan=TaiKhoan.IDTaiKhoan and HoaDon.IDKhachHang=KhachHang.IDKhachHang
create table LuuID
(
	IDChiTietHoaDon int IDENTITY(1,1) PRIMARY KEY,
	IDStaff int,
)
insert into LuuID values(1)
--Sách

insert into Sach values(N'JavaScript','ABC',N'Ivelin Demirov',30000,15)
insert into Sach values(N'PHP','ABC',N'Larry Ullman',35000,15)
--Dữ liệu bảng Phân Quyền
insert into PhanQuyen values(N'Quản Lý')
insert into PhanQuyen values(N'Nhân Viên')
select * from TaiKhoan


--Dữ liệu bảng Tài Khoản
insert into TaiKhoan values(N'Nguyễn Văn Tiến','1','tien1602@gmail.com','0373300348','2001/02/16',1,1)
insert into TaiKhoan values(N'Nguyễn Văn Tùng','2','tung0711@gmail.com','0373300347','2001/11/11',1,2)
insert into TaiKhoan values(N'Trần Ngọc Trinh','trinh','ngoctrinh0602@gmail.com','090912345','2002/02/11',1,1)
insert into TaiKhoan values(N'Đỗ Tiến Đạt','dat','tiendat01@gmail.com','0373300346','2001/11/11',1,2)
 select * from TaiKhoan 
--Dữ liệu bảng Khách Hàng
insert into KhachHang(TenKhachHang,SDT,Email,CapBac,SoTienDaMua) values(N'Quang Sơn','0123456789','quangSon@gmail.com',N'Đồng',0)
insert into KhachHang(TenKhachHang,SDT,Email,CapBac,SoTienDaMua) values(N'Xuân Trọng','0123456987','xuantrong@gmail.com',N'Đồng',0)
insert into KhachHang(TenKhachHang,SDT,Email,CapBac,SoTienDaMua) values(N'Thành Tiến','0123456789','thanhtien0867@gmail.com',N'Đồng',0)
insert into KhachHang(TenKhachHang,SDT,Email,CapBac,SoTienDaMua) values(N'Quang Vinh','0123456987','vinhz019@gmail.com',N'Đồng',0)


select ChiTietHoaDon.IDHoaDon,ChiTietHoaDon.IDSach,TenSach,Gia,ChiTietHoaDon.SoLuong,HoaDon.NgayInHoaDon,HoaDon.GioInHoaDon, HoaDon.TongTien ,KhachHang.TenKhachHang ,TaiKhoan.TenTaiKhoan from Sach,ChiTietHoaDon,HoaDon ,KhachHang,TaiKhoan where 
Sach.IDSach = ChiTietHoaDon.IDSach and HoaDon.IDHoaDon=ChiTietHoaDon.IDHoaDon and HoaDon.IDKhachHang=KhachHang.IDKhachHang and HoaDon.IDTaiKhoan=TaiKhoan.IDTaiKhoan and ChiTietHoaDon.IDHoaDon =6


select IDHoaDon as N'ID HĐ' ,NgayInHoaDon as N'Ngày In HĐ', GioInHoaDon as N'Giờ In HĐ',TongTien as N'Tổng Tiền',TenKhachHang as N'Tên Khách Hàng' , TenTaiKhoan as N'Nhân Viên Bán' from HoaDon ,TaiKhoan,KhachHang 
where HoaDon.IDTaiKhoan = TaiKhoan.IDTaiKhoan and HoaDon.IDKhachHang = KhachHang.IDKhachHang
select *from HoaDon