Create database QLKS
go
use QLKS
go
Create table TAIKHOAN
(
	[id_TK] Varchar(10) primary key,
	[ten_TK] Nvarchar(30),
	[matkhau_TK] Varchar(30),
	[tenhienthi_TK] Nvarchar(50),
	[gioitinh] Nvarchar(20),
	[sdt] Varchar(11) ,
	[diachi] Nvarchar(50),
	[email] Nvarchar(50),
	[trangthai] Nvarchar(1),
) 
go
Create table KHACHHANG
(
	[id_KH] Varchar(10)primary key,
	[ten] Nvarchar(50),
	[ngaysinh] Varchar(30),
	[gioitinh] Nvarchar(20),
	[cmnd] Varchar(10),
	[quoctich] Nvarchar(30),
) 
go
Create table [LOAIPHONG]
(
	[id_LP] Varchar(10) PRIMARY KEY,
	[ten_LP] Nvarchar(30),
	[succhua] Integer,
	[giaphong] int,

) 

Create table PHONG 
(
	[id_P] Varchar(10) primary key,
	[ten_P] Nvarchar(30),
	[tinhtrang] Nvarchar(30),
	[id_LP] Varchar(10) REFERENCES DBO.LOAIPHONG(id_LP),
)
go

Create table DICHVU
(
	[id_DV] Varchar(10) PRIMARY KEY,
	[ten_DV] Nvarchar(30),
	[gia_DV] int,
) 
go

Create table [HOADON]
(
	[id_HD] int identity PRIMARY KEY,
	[id_KH] Varchar(10) REFERENCES DBO.KHACHHANG(id_KH),
	[ngayvao] DATE NOT NULL DEFAULT GETDATE(),
	[ngaytra] date,
	[tinhtrang] int not null, ----1: đã thanh toán, 0: chưa thanh toán.
	[id_P] Varchar(10) REFERENCES DBO.PHONG(id_P)
) 
go
Create table CHITIETHOADON
(
	[id_CTHD] int identity primary key,
	[id_HD] int REFERENCES DBO.HOADON(id_HD),
	[id_DV] Varchar(10) REFERENCES DBO.DICHVU(id_DV),
	[soluong] int,
	[ngaysudung] DATE NOT NULL DEFAULT GETDATE(),
) 
go

INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (1, 2, N'01DV', 1, CAST(N'2021-01-17' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (2, 2, N'03DV', 2, CAST(N'2021-01-17' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (3, 4, N'09DV', 1, CAST(N'2021-01-17' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (4, 4, N'01DV', 2, CAST(N'2021-01-17' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (5, 3, N'01DV', 2, CAST(N'2021-01-17' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (6, 3, N'04DV', 4, CAST(N'2021-01-17' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (7, 7, N'02DV', 2, CAST(N'2021-01-17' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (8, 10, N'01DV', 1, CAST(N'2021-01-20' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (9, 10, N'02DV', 2, CAST(N'2021-01-20' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (10, 10, N'08DV', 2, CAST(N'2021-01-20' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (11, 10, N'10DV', 2, CAST(N'2021-01-20' AS Date))
INSERT [dbo].[CHITIETHOADON] ([id_CTHD], [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES (12, 10, N'12DV', 2, CAST(N'2021-01-20' AS Date))
GO
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'01DV', N'Xe ô tô', 200000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'02DV', N'Xe mô tô', 100000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'03DV', N'Karaoke', 50000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'04DV', N'Tắm hơi', 80000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'05DV', N'Cơm phần', 45000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'06DV', N'Giặt ủi', 70000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'07DV', N'Spa', 450000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'08DV', N'Sân tenis', 800000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'09DV', N'Em út', 1200000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'10DV', N'Bcs', 110000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'12DV', N'ShisA', 200000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'13DV', N'Bóng', 120000)
GO
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (2, N'01KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (3, N'02KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'07P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (4, N'01KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'04P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (5, N'01KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (6, N'01KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'04P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (7, N'01KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (8, N'01KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (9, N'01KH', CAST(N'2021-01-17' AS Date), CAST(N'2021-01-17' AS Date), 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (10, N'07KH', CAST(N'2021-01-20' AS Date), CAST(N'2021-01-20' AS Date), 1, N'02P')
SET IDENTITY_INSERT [dbo].[HOADON] OFF
GO
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'01KH', N'Cao Minh Thắng', N'25/06/2000', N'Nam', N'215494361', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'02KH', N'Trần Nguyễn Nhật Nam', N'20/11/20000', N'Nam', N'541915652', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'03KH', N'Nguyễn Thị Kim Ngân', N'30/10/2000', N'Nữ', N'515619565', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'04KH', N'Nguyễn Văn Cương', N'04/12/2000', N'Nam', N'651516598', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'05KH', N'Đinh Tuấn Thành', N'01/01/2000', N'Nam', N'262952625', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'06KH', N'Nguyễn Trung Tuyến', N'12/05/2000', N'Nam', N'651265165', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'07KH', N'Nguyễn Phạm Kiệt', N'09/02/2000', N'Nam', N'252511851', N'Việt Nam')
GO
INSERT [dbo].[LOAIPHONG] ([id_LP], [ten_LP], [succhua], [giaphong]) VALUES (N'01LP', N'Thường 2', 2, 200000)
INSERT [dbo].[LOAIPHONG] ([id_LP], [ten_LP], [succhua], [giaphong]) VALUES (N'02LP', N'Thương gia 2', 2, 400000)
INSERT [dbo].[LOAIPHONG] ([id_LP], [ten_LP], [succhua], [giaphong]) VALUES (N'03LP', N'Thường 4', 4, 500000)
INSERT [dbo].[LOAIPHONG] ([id_LP], [ten_LP], [succhua], [giaphong]) VALUES (N'04LP', N'Thương gia 4', 4, 700000)
GO
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'01P', N'Phòng 1', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'02P', N'Phòng 2', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'03P', N'Phòng 3', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'04P', N'Phòng 4', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'05P', N'Phòng 5', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'06P', N'Phòng 6', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'07P', N'Phòng 7', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'08P', N'Phòng 8', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'09P', N'Phòng 9', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'10P', N'Phòng 10', N'Sẵn sàng', N'01LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'11P', N'Phòng 11', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'12P', N'Phòng 12', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'13P', N'Phòng 13', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'14P', N'Phòng 14', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'15P', N'Phòng 15', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'16P', N'Phòng 16', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'17P', N'Phòng 17', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'18P', N'Phòng 18', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'19P', N'Phòng 19', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'20P', N'Phòng 20', N'Sẵn sàng', N'02LP')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [id_LP]) VALUES (N'21P', N'Phòng 21', N'Sẵn sàng', N'03LP')
GO
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'01TK', N'danghoangviet', N'danghoangviet', N'Đặng Hoàng Việt', N'Nam', N'348938553', N'Bình Chánh', N'vietkhungkhung@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'02TK', N'phamvantuyen', N'phamvantuyen1', N'Phạm Văn Tuyển', N'Nam', N'834438476', N'Thủ Đức', N'tuyenpham162@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'03TK', N'nguyenminhthong', N'nguyenminhthong', N'Nguyễn Minh Thông', N'Nam', N'963482741', N'Quận 9', N'thongn363@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'04TK', N'dinhtuanthanh', N'dinhtuanthanh', N'Đinh Tuấn Thành', N'Nam', N'389437197', N'Bình Dương', N'dinhthanh11011@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'05TK', N'doanquychi', N'doanquychi', N'Đoàn Thị Quý Chi', N'Nữ', N'968572937', N'Quận 9', N'doanthiquichi2452000@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'06TK', N'phantuongvi', N'phantuongvi', N'Phan Thị Tường Vi', N'Nữ', N'918615170', N'Quận 9', N'vivituong116@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'07TK', N'Trần Nguyễn N.Nam', N'namduycho', N'Trần Nguyễn N.Nam', N'Nam', N'337662557', N'Quận 9', N'tnnnam2011@gmail.com', NULL)
GO
                                  --CHÚ Ý--
------------------------------------------------------------------------------
------------------------------------------------------------------------------
-------------------------------------------------------------------------------------

-----------------Tạo strigger----------------------------------------------

--------------Update dựa vào Bill - có bill là phòng có người
CREATE TRIGGER UTG_UpdatePhongg
ON HOADON FOR INSERT, UPDATE
AS
BEGIN 
	DECLARE @idphong varchar(10)
	SELECT @idphong =  id_P FROM Inserted
	Update PHONG SET tinhtrang = N'Đã thuê' WHERE id_P = @idphong
END
GO

-------------thanh toán bill thì phòng thành phòng rỗng
create TRIGGER UTG_UpdateBilll
ON HOADON FOR UPDATE
AS
BEGIN 
	DECLARE @idhd int
	SELECT @idhd = id_HD FROM Inserted
	DECLARE @idphong varchar(10)
	SELECT @idphong = id_P FROM HOADON WHERE id_HD = @idhd
	DECLARE @count int = 0
	SELECT @count  = COUNT(*) FROM HOADON WHERE id_P = @idphong and tinhtrang = 0
	if(@count =0)
		Update PHONG SET tinhtrang = N'Sẵn sàng' where id_P = @idphong
END
GO
----

-----


--------------------------------------------------------------------------------------------------------
-------------------- TẠO STORED PROCEDURE  ---------------------

 -- DROP PROCEDURE USP_LoadCustomer ----ALTER	
 -------Load đặt phòng
CREATE PROC USP_LoadDatPhongg
AS
	SELECT r.ten_P as [Phòng], c.ten as [Khách hàng], c.cmnd as[CMND], b.ngayvao as[Ngày vào], rt.ten_LP as[Loại phòng], rt.giaphong as [Giá Phòng]
	FROM PHONG as r, LOAIPHONG as rt, HOADON as b, KHACHHANG as c
	Where rt.id_LP = r.id_LP and r.id_P = b.id_P and b.id_KH = c.id_KH 
GO
EXECUTE USP_LoadDatPhongg;
GO

 --------Load khách hàng
CREATE PROC USP_LoadCustomerr
AS
	SELECT id_KH, ten as [Tên KH], ngaysinh as [Ngày sinh], gioitinh as [Giới tính], cmnd as [Số CM], quoctich as [Quốc tịch]
	FROM KHACHHANG
GO
EXECUTE USP_LoadCustomerr;
GO



-----Lấy ra phòng hiện tại
CREATE PROC USP_GetRoomListt
AS
	SELECT * FROM PHONG
GO
EXEC USP_GetRoomListt;
GO
------Lấy ra service hiện tại
CREATE PROC USP_GetServicee
AS
	SELECT * FROM DICHVU
GO
EXEC USP_GetServicee;
GO


-----------Thêm vào BillInfo
CREATE PROCEDURE USP_InsertBillInfoo
@idhoadon int, 
@iddichvu varchar(10), 
@soluong int
as
BEGIN
	
	DECLARE @KtraBillInfo INT
	DECLARE @CountService INT = 1
	SELECT @KtraBillInfo = id_CTHD, @CountService = soluong FROM CHITIETHOADON 
	WHERE id_HD = @idhoadon and id_DV = @iddichvu -- coi có idBill chưa và xem có thức ăn nào như v đã có trong bill chưa
	IF (@KtraBillInfo >0)
		BEGIN
			DECLARE @newCount int = @CountService + @soluong
			IF(@newCount > 0)
				UPDATE CHITIETHOADON SET soluong = @CountService + @soluong WHERE id_DV = @iddichvu and id_HD = @idhoadon
			ELSE
				DELETE CHITIETHOADON WHERE id_HD = @idhoadon and id_DV = @iddichvu -----ngược lại xoá billInfo 
		END
	ELSE
		BEGIN
			INSERT INTO CHITIETHOADON(id_HD, id_DV, soluong, ngaysudung)
			VALUES (@idhoadon, @iddichvu, @soluong, GETDATE())
		END
END
GO

---------Thêm vào Bill

CREATE PROCEDURE USP_InsertBilll
@idRoom varchar(10),
@idCustomer varchar(10)
AS
BEGIN
	DECLARE @KtraStatus INT
	SELECT @KtraStatus  = COUNT(*) FROM HOADON WHERE id_P = @idRoom and tinhtrang = 0
	IF(@KtraStatus =  0)
		BEGIN
			INSERT INTO HOADON(id_KH, ngayvao, ngaytra, id_P, tinhtrang)  
			VALUES ( @idCustomer, GETDATE(), NULl,  @idRoom , 0)
		END
	ELSE
		BEGIN
			Print N'Nhập lại'
		END
END
GO

------------Thay đổi phòng
alter procedure USP_SwitchRoomm
@idphongcu varchar(10),
@idphongmoi varchar(10)
as
begin
	declare @idhoadoncu int
	declare @idhoadonmoi int

	declare @isoldroomempty int = 1
	declare @isnewroomempty int = 1

	select @idhoadoncu = id_HD from dbo.HOADON where id_P = @idphongcu and tinhtrang = 0
	select @idhoadonmoi = id_HD from dbo.HOADON where id_P = @idhoadonmoi and tinhtrang = 0

	if(@idhoadoncu is null) --Nếu = null thì insert vào 1 hoá đơn trống
	begin
		insert dbo.HOADON
					(
					id_KH,
					ngayvao,
					ngaytra,
					tinhtrang,
					id_P
					)
		values
					(
					null,
					GETDATE(),
					null,
					0,
					@idphongcu
					)
	select @idhoadoncu = max(id_HD) from dbo.HOADON where id_P = @idphongcu and tinhtrang = 0
	end
	select @isoldroomempty = count (*) from dbo.CHITIETHOADON where id_HD = @idhoadoncu -- đếm số lượng chi tiết hoá đơn trong bàn cũ

	if(@idhoadonmoi is null) --Nếu = null thì insert vào 1 hoá đơn trống
	begin
		insert dbo.HOADON
		(
					id_KH,
					ngayvao,
					ngaytra,
					tinhtrang,
					id_P
					)
		values
					(
					null,
					GETDATE(),
					null,
					0,
					@idphongmoi
					)
	select @idhoadonmoi = max(id_HD) from dbo.HOADON where id_P = @idphongmoi and tinhtrang = 0
	end
	select @isnewroomempty = count (*) from dbo.CHITIETHOADON where id_HD = @idhoadonmoi -- đếm số lượng chi tiết hoá đơn trong bàn mới

	select id_CTHD into idhoadonphong from dbo.CHITIETHOADON where id_HD = @idhoadonmoi -- lưu id chi tiết hoá đơn của cái hoá đơn mới vào bên thứ 3 chứa id hoá đơn mới
	update dbo.CHITIETHOADON set id_HD = @idhoadonmoi where id_HD = @idhoadoncu -- cập nhật id hoá đơn cũ = id hoá đơn mới khi id hoá đơn của nó là id hoá đơn cũ
	-- cập nhật id hoá đơn mới = id hoá đơn cũ khi id hoá đơn của nó là id hoá đơn mới nằm bên thứ 3
	update dbo.CHITIETHOADON set id_HD = @idhoadoncu where id_HD in (select * from dbo.idhoadonphong )

	drop table idhoadonphong -- xong thì xoá bên thứ  3 đi
	if(@isoldroomempty =0)
		update dbo.PHONG set tinhtrang = N'Sẵn sàng' where id_P = @idphongmoi
	if(@isnewroomempty =0)
		update dbo.PHONG set tinhtrang = N'Sẵn sàng' where id_P = @idphongcu
end
go

exec USP_SwitchRoomm @idphongcu = N'22', @idphongmoi = N'07'

-- Thủ tục thống kê hoá đơn theo ngày
create proc USP_GetListBillByDate
@ngayvao date, @ngaytra date
as
begin
select b.ten_P as [Tên phòng], a.ngayvao as [Ngày thuê], a.ngaytra as [Ngày trả], c.ten as [Khách hàng]
from dbo.HOADON as a, dbo.PHONG as b, dbo.KHACHHANG as c 
where ngayvao >= @ngayvao and ngaytra <= @ngaytra and a.tinhtrang = 1 and a.id_P = b.id_P and a.id_KH = c.id_KH
end 
go

----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------
