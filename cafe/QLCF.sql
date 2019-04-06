CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Kter',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'staff1' , -- UserName - nvarchar(100)
          N'casang' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'staff2' , -- UserName - nvarchar(100)
          N'catoi' , -- DisplayName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO


CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'Staff1' -- nvarchar(100)

Select * from dbo.Account  where UserName = 'Staff1' and PassWord = '1'

EXEC dbo.USP_GetAccountByUserName @userName = N'Staff1' -- nvarchar(100)

GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO

DECLARE @i INT = 1

WHILE @i <= 36
BEGIN
	INSERT dbo.TableFood ( name)VALUES  ( N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

create proc USP_GetTableList
as select * from dbo.TableFood

exec USP_GetTableList


INSERT dbo.FoodCategory(name)
VALUES( N'Đá xay - Sinh tố')
INSERT dbo.FoodCategory(name)
VALUES( N'Trà sữa')
INSERT dbo.FoodCategory(name)
VALUES( N'Cafe')
INSERT dbo.FoodCategory(name)
VALUES( N'Other')
INSERT dbo.FoodCategory(name)
VALUES( N'Đồ ăn vặt')

select * from dbo.FoodCategory

INSERT INTO dbo.Food(name,idCategory,price)
VALUES( N'Sinh tố Việt quất',1,45000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Socola Đá xay ',1,50000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Sinh tố dưa hấu',1,45000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Sinh tố cam xoài',1,45000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Matcha Đá xay ',1,50000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Hạt dẻ Đá xay ',1,50000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Mocha Đá xay ',1,50000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Trà sữa trân châu',2,40000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Trà sữa trân châu trắng',2,45000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Trà sữa hạt dẻ',2,40000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Trà sữa thạch',2,40000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Trà đen Matchiato',2,45000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Trà xanh Matchiato',2,45000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Matcha Matchiato',2,45000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe đen đá',3,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe đen nóng',3,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe sữa đá',3,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe sữa nóng',3,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Bạc sỉu đá',3,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Bạc sỉu nóng',3,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe đen xay',3,35000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe nâu xay',3,35000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Latte',3,40000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Americano',3,30000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Capuchino',3,40000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cocacola',4,10000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Pepsi',4,10000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'7 up',4,10000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Nước khoáng',4,10000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe phin 500gr',4,200000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Cafe xay 500gr',4,250000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Bim Bim',5,10000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Khô gà 100gr',5,110000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Bánh socola',5,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Bánh matcha',5,25000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Bánh bông lan trứng muối',5,30000)
INSERT dbo.Food(name,idCategory,price)
VALUES( N'Bánh Cafe',5,20000)

select * from dbo.Food

INSERT	dbo.Bill
        ( DateCheckIn ,
          DateCheckOut ,
          idTable ,
          status
        )
VALUES  ( GETDATE() ,NULL , 1 , 0  )

INSERT	dbo.BillInfo
        ( idBill, idFood, count )
VALUES  ( 1, 1,  2  )