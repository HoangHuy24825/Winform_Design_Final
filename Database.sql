USE master
GO

IF(EXISTS(SELECT * FROM SYSDATABASES WHERE NAME='BakeryManagement'))
	DROP DATABASE BakeryManagement

CREATE DATABASE BakeryManagement

USE BakeryManagement
GO

--Supplier
--Cake
--Category
--ImportCoupon
--ImportCouponDetail
--Bill
--BillDetail
--Staff
--Account	
--Salary

CREATE TABLE Supplier
(
	idSupplier INT IDENTITY PRIMARY KEY,
	nameSupplier NVARCHAR(255) NOT NULL,
	phoneSupplier VARCHAR(15) NOT NULL,
	addressSupplier NVARCHAR(255) NOT NULL,
	isDeleted BIT --0: Chưa xóa, 1: Đã xóa
)

CREATE TABLE Category 
(
	idCategory INT IDENTITY PRIMARY KEY,
	nameCategory NVARCHAR(255) NOT NULL,
	isDeleted BIT --0: Chưa xóa, 1: Đã xóa
)

CREATE TABLE Cake
(
	idCake INT IDENTITY PRIMARY KEY,
	nameCake NVARCHAR(255) NOT NULL,
	exportPrice FLOAT NOT NULL,--Gia xuat
	importPrice FLOAT NOT NULL,--Gia nhap
	remainingAmount INT NOT NULL,
	expCake DATE,
	mfgCake DATE,
	size CHAR(5) NOT NULL,
	idCategory INT NOT NULL,
	isDeleted BIT, --0: Chưa xóa, 1: Đã xóa
	FOREIGN KEY (idCategory) REFERENCES Category(idCategory) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE ImportCoupon
(
	idCoupon INT IDENTITY PRIMARY KEY,
	idSupplier INT NOT NULL,
	dayImport DATETIME,
	isDeleted BIT DEFAULT 0, --0:Chưa xóa, 1: Đã xóa
	FOREIGN KEY (idSupplier) REFERENCES Supplier(idSupplier) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE ImportCouponDetail
(
	idCouponDetail INT IDENTITY PRIMARY KEY,
	idCoupon INT NOT NULL,
	idCake INT NOT NULL,
	amountCake INT NOT NULL,
	priceImport FLOAT NOT NULL,
	isDeleted BIT DEFAULT 0, --0:Chưa xóa, 1: Đã xóa
	FOREIGN KEY (idCoupon) REFERENCES ImportCoupon(idCoupon) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (idCake) REFERENCES Cake(idCake) ON UPDATE CASCADE ON DELETE CASCADE,
)

CREATE TABLE Staff
(
	idStaff INT IDENTITY PRIMARY KEY,
	nameStaff NVARCHAR(255) NOT NULL,
	gender BIT NOT NULL,--0: Nam, 1: Nữ
	phoneStaff VARCHAR(15) NOT NULL,
	addressStaff NVARCHAR(255) NOT NULL,
	isDeleted BIT, --0:Chưa xóa, 1: Đã xóa
)

CREATE TABLE Salary
(
	idSalary INT IDENTITY PRIMARY KEY,
	salaryDate FLOAT NOT NULL,
	workDays FLOAT NOT NULL,
	hoursOverTime FLOAT NOT NULL,
	rewards FLOAT NOT NULL,
	salaryOverTime FLOAT NOT NULL,
	twoDateIsTimeKeeped DATE NULL,
	dateIsTimeKeeped DATE NOT NULL,
	salaryTime DATE NOT NULL,
	idStaff INT NOT NULL,
	oldHoursOverTime FLOAT NOT NULL,
	FOREIGN KEY (idStaff) REFERENCES Staff(idStaff) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE Account
(
	userName VARCHAR(255) PRIMARY KEY,
	pass VARCHAR(30),
	typeAccount BIT, --0: Admin, 1:Staff
	idStaff INT NOT NULL,
	isDeleted BIT,--0: Chưa xóa, 1: Đã xóa
	FOREIGN KEY (idStaff) REFERENCES Staff(idStaff) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE Bill
(
	idBill INT IDENTITY PRIMARY KEY,
	exportDate DATE NOT NULL,
	idStaff INT NOT NULL,
	discount FLOAT,
	FOREIGN KEY (idStaff) REFERENCES Staff(idStaff) ON UPDATE CASCADE ON DELETE CASCADE
)

CREATE TABLE BillDetail
(
	idDetail INT IDENTITY PRIMARY KEY,
	idCake INT NOT NULL,
	idBill INT NOT NULL,
	amountOrder INT NOT NULL,
	FOREIGN KEY (idCake) REFERENCES Cake(idCake) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (idBill) REFERENCES Bill(idBill) ON UPDATE CASCADE ON DELETE CASCADE
)

INSERT INTO Supplier (nameSupplier,phoneSupplier,addressSupplier,isDeleted) VALUES
(N'Công ty Kinh Đô','0369784632',N'Thanh Xuân - Hà Nội',0),
(N'Công ty Hữu Nghị','0386451135',N'Hoàn Kiếm - Hà Nội',0),
(N'Công ty bánh kem Ngọc Lan','03548956123',N'Hà Đông - Hà Nội',0)

INSERT INTO Category (nameCategory,isDeleted) VALUES
(N'Bánh trung thu',0),
(N'Bánh gato',0),
(N'Bánh quy',0)

INSERT INTO Cake(nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,idCategory,isDeleted) VALUES
(N'Bánh trung thu Kinh Đô nhân trứng muối',60000,50000,120,'2021-01-01','2020-10-13','M',1,0),
(N'Bánh trung thu Kinh Đô nhân đậu xanh',80000,70000,50,'2021-02-10','2020-9-15','L',1,0),
(N'Bánh quy bơ trứng Hữu Nghị',10000,90000,70,'2021-03-20','2020-11-10','M',3,0),
(N'Bánh kem Oreo Chocolate Ngọc Lan',70000,50000,20,'2021-06-01','2020-10-30','M',3,0),
(N'Bánh gato Ngọc Lan',85000,70000,50,'2021-03-31','2020-12-15','L',2,0)

INSERT INTO ImportCoupon (idSupplier,dayImport) VALUES
(1,'2020-01-01'),
(2,'2020-02-02'),
(3,'2020-03-03')

INSERT INTO ImportCouponDetail(idCoupon,idCake,amountCake,priceImport) VALUES
(1,1,60,50000),
(1,2,10,70000),
(2,3,75,90000),
(3,4,98,50000),
(3,5,23,70000)

INSERT INTO Staff(nameStaff,gender,phoneStaff,addressStaff,isDeleted) VALUES
(N'Nguyễn Thị Hoa',1,'0385946325',N'Phủ Lý - Hà Nam',0),
(N'Lê Văn Nam',0,'0387894256',N'Nam Đàn - Nghệ An',0),
(N'Trần Tuấn Anh',0,'0384562894',N'Từ Sơn - Bắc Ninh',0),
(N'Ngô Thị Hương',1,'03978456325',N'Bắc Từ Liêm - Hà Nội',0),
(N'Hoàng Thị Ánh Hồng',1,'03758942631',N'Vĩnh Tuy - Vĩnh Phúc',0)

INSERT INTO Salary(salaryDate,workDays,hoursOverTime,oldHoursOverTime,rewards,salaryOverTime,dateIsTimeKeeped,twoDateIsTimeKeeped,salaryTime,idStaff) VALUES
(250000,28,5,0,300000,15000,'2020-11-17','2020-11-16','2020-11-1',2),
(260000,27,1,0,200000,15000,'2020-11-17','2020-11-16','2020-11-1',3),
(240000,25,0,0,0,15000,'2020-11-17','2020-11-16','2020-11-1',4),
(230000,21,0,0,0,15000,'2020-11-17','2020-11-16','2020-11-1',5)

INSERT INTO Account(userName,pass,typeAccount,idStaff,isDeleted) VALUES
('Admin','1',0,1,0),
('Staff01','1',1,2,0),
('Staff02','1',1,3,0),
('Staff03','1',1,4,0),
('Staff04','1',1,5,0)

INSERT INTO Bill(exportDate,discount,idStaff) VALUES
('2020-12-6',0,2),
('2020-11-4',0,2),
('2020-10-2',0,2),
('2021-1-2',0,3),
('2021-1-8',0,3),
('2021-1-5',0,4),
('2021-1-6',0,4)

INSERT INTO BillDetail(idBill,idCake,amountOrder) VALUES
(1,1,2),
(4,2,6),
(2,1,2),
(2,3,4),
(3,4,7),
(5,2,1),
(5,3,2),
(6,4,4),
(6,3,1),
(7,4,4),
(7,3,1)
GO


--Proceduce Get List Cake
CREATE PROC GetFullListCake
AS 
BEGIN
	SELECT C.idCake,nameCake,exportPrice,remainingAmount,mfgCake,expCake,size
	FROM Cake AS C, Category AS CA
	WHERE C.idCategory=CA.idCategory AND C.isDeleted=0
END

--EXEC GetFullListCake
--DROP PROC GetFullListCake
GO

--Proceduce Get List Cake For Select
CREATE PROC GetListCakeForSelect
AS
BEGIN
	SELECT C.idCake,nameCake,exportPrice,remainingAmount,size,FORMAT(expCake,'dd/MM/yyyy') as expCake
	FROM Cake AS C, Category AS CA
	WHERE C.idCategory=CA.idCategory AND C.isDeleted=0
END
--EXEC GetListCakeForSelect
--DROP PROC GetListCakeForSelect
GO

--Proceduce Get Account
CREATE PROC GetFullAccount
AS
BEGIN
	SELECT A.userName,A.pass,A.typeAccount,S.nameStaff,S.idStaff
	FROM Staff AS S,Account AS A
	WHERE S.idStaff = A.idStaff AND A.isDeleted = 0
END

--EXEC GetFullAccount
--DROP PROC GetFullAccount
GO

--Function convert to unsigned
CREATE FUNCTION F_ConvertToUnsigned
(@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
GO

--Create proc compare account
CREATE FUNCTION F_CompareAccount
(@userName VARCHAR(255),
@pass VARCHAR(30))
RETURNS BIT
AS
BEGIN
	DECLARE @result BIT
	IF(EXISTS(SELECT * FROM Account WHERE userName=@userName AND pass=@pass AND isDeleted=0))
		SET @result=1
	ELSE SET @result=0
	RETURN @result
END

--SELECT dbo.F_CompareAccount('Admin','1')
--DROP FUNCTION DBO.F_CompareAccount
GO

--Proceduce search cake by cake name
CREATE PROC STP_SearchCakeByCakeName
@cakeName NVARCHAR(255)
AS 
BEGIN
	SELECT C.idCake,nameCake,exportPrice,remainingAmount,size,FORMAT(expCake,'dd/MM/yyyy') as expCake
	FROM Cake AS C, Category AS CA
	WHERE C.idCategory=CA.idCategory AND C.isDeleted=0 AND dbo.F_ConvertToUnsigned(nameCake) LIKE '%'+dbo.F_ConvertToUnsigned(@cakeName)+'%'
END

--EXEC STP_SearchCakeByCakeName N'muối'
--DROP PROC STP_SearchCakeByCakeName
GO

--Proceduce search cake by category name
CREATE PROC STP_SearchCakeByCategoryName
@categoryName NVARCHAR(255)
AS 
BEGIN
	SELECT C.idCake,nameCake,exportPrice,remainingAmount,size,FORMAT(expCake,'dd/MM/yyyy') as expCake
	FROM Cake AS C, Category AS CA
	WHERE C.idCategory=CA.idCategory AND C.isDeleted=0 AND dbo.F_ConvertToUnsigned(nameCategory) LIKE '%'+dbo.F_ConvertToUnsigned(@categoryName)+'%'
END

--EXEC STP_SearchCakeByCategoryName 'Gato'
--DROP PROC STP_SearchCakeByCategoryName
GO

--Function get id staff by userName
CREATE FUNCTION F_GetIDStaffByUserName
(@userName VARCHAR(255))
RETURNS INT
AS
BEGIN
	DECLARE @result INT
	SELECT @result = S.idStaff
	FROM Staff AS S, Account AS A
	WHERE S.idStaff=A.idStaff AND A.userName=@userName
	RETURN @result
END

--SELECT dbo.F_GetIDStaffByUserName ('admin')
--DROP FUNCTION F_GetIDStaffByUserName
GO

----Trigger delete bill detail by id bill
CREATE TRIGGER TRG_DeleteBillDetail
ON BillDetail
FOR DELETE
AS
BEGIN
	SELECT * INTO TempleTable FROM deleted
	DECLARE @count INT
	DECLARE @rowDeleted INT
	SET @count=0
	SELECT @rowDeleted=COUNT(*) FROM deleted
	WHILE @count<@rowDeleted
	BEGIN
		DECLARE @idCakeDeleted INT 
		SET @idCakeDeleted = (SELECT TOP(1) idCake FROM TempleTable)
		UPDATE Cake SET remainingAmount=remainingAmount+(SELECT TOP(1) amountOrder FROM TempleTable)
		WHERE idCake=@idCakeDeleted
		DELETE TempleTable WHERE idCake=@idCakeDeleted
		SET @count=@count+1
	END
	DROP TABLE TempleTable
END

--DROP TRIGGER TRG_DeleteBillDetail
GO

--Proceduce Add Cake To Bill
CREATE PROC STP_AddCakeToBill
@idCake INT,
@idBill INT, 
@amountOrder INT
AS
BEGIN
	IF(EXISTS(SELECT * FROM BillDetail WHERE idCake=@idCake AND idBill=@idBill))
		BEGIN
			IF(@amountOrder=0)
				BEGIN
					DELETE BillDetail WHERE idCake=@idCake AND idBill=@idBill
				END
			ELSE 
				BEGIN
					DECLARE @oldOrder1 INT
					SELECT @oldOrder1=amountOrder FROM BillDetail WHERE idCake=@idCake AND idBill=@idBill
					UPDATE BillDetail SET amountOrder=@amountOrder WHERE idCake=@idCake AND idBill=@idBill
					UPDATE Cake SET remainingAmount=remainingAmount-(@amountOrder-@oldOrder1) WHERE idCake=@idCake
				END
		END
	ELSE
		BEGIN
			INSERT INTO BillDetail(idBill,idCake,amountOrder) VALUES (@idBill,@idCake,@amountOrder)
			UPDATE Cake SET remainingAmount=remainingAmount-@amountOrder WHERE idCake=@idCake
		END
END

--EXEC STP_AddCakeToBill 1,1,10
--EXEC STP_AddCakeToBill 4,1,10
--DROP PROC STP_AddCakeToBill
GO

--Function get old amount order
CREATE FUNCTION F_GetOldAmountOrder
(@idCake INT,@idBill INT)
RETURNS INT 
AS 
BEGIN 
	DECLARE @result INT
	IF(EXISTS(SELECT * FROM BillDetail WHERE idCake=@idCake AND idBill=@idBill))
		SELECT @result=amountOrder FROM BillDetail WHERE idCake=@idCake AND idBill=@idBill
	ELSE SET @result=0
	RETURN @result
END

--SELECT dbo.F_GetOldAmountOrder (1,1)
--SELECT dbo.F_GetOldAmountOrder (4,2)
--DROP FUNCTION dbo.F_GetOldAmountOrder
GO


--Proceduce Get Bill By ID BILL
CREATE PROC STP_GetBillByIdBill
@idBill INT
AS 
BEGIN
	SELECT C.idCake,nameCake,exportPrice,amountOrder,size
	FROM Cake as C, Bill as B, BillDetail as BD
	WHERE C.idCake=BD.idCake AND B.idBill=BD.idBill AND B.idBill=@idBill
END

--EXEC STP_GetBillByIdBill 5
--DROP PROC STP_GetBillByIdBill
GO

--Create temple table 
CREATE TABLE ##PayBill
(
	idPayBill INT IDENTITY PRIMARY KEY,
	idBill INT,
	totalMoney FLOAT,
	totalAfterDiscount FLOAT,
	customerPay FLOAT,
	returnMoney FLOAT,
)
--DROP TABLE ##PayBill
--SELECT * FROM ##PayBill
GO

--Procedure print Bill
CREATE PROC STP_PrintBill
@idBill INT
AS 
BEGIN 
	SELECT B.idBill,S.idStaff,exportDate,totalMoney,B.discount,totalAfterDiscount,customerPay,returnMoney,nameCake,exportPrice,amountOrder,C.size
	FROM Bill AS B, BillDetail AS BD, Staff AS S, ##PayBill AS PB, Cake AS C
	WHERE B.idBill=BD.idBill AND B.idStaff=S.idStaff AND B.idBill=PB.idBill AND C.idCake=BD.idCake AND B.idBill=@idBill
	DELETE FROM ##PayBill
END

--EXEC STP_PrintBill 7
--DROP PROC STP_PrintBill
GO

--Function total money
CREATE FUNCTION F_TotalMoney
(@idBill INT)
RETURNS FLOAT
AS 
BEGIN
	DECLARE @result FLOAT
	SET @result=0
	SELECT @result=@result+(C.exportPrice*BD.amountOrder)
	FROM Cake AS C, Bill AS B, BillDetail AS BD
	WHERE C.idCake=BD.idCake AND B.idBill=BD.idBill AND BD.idBill=@idBill
	RETURN @result
END

--SELECT dbo.F_TotalMoney (1)
--DROP FUNCTION dbo.F_TotalMoney
GO

--Proceduce Add an Account
CREATE PROC STP_AddAnAccount(
	@userName VARCHAR(255),
	@typeAccount BIT,
	@idStaff INT
)
AS
BEGIN
	DECLARE @result BIT
	IF(NOT EXISTS (SELECT * FROM Account WHERE idStaff = @idStaff AND isDeleted = 0))
	BEGIN
		INSERT INTO Account(userName,pass,typeAccount,idStaff,isDeleted) VALUES 
		(@userName,'1',@typeAccount,@idStaff,0)
		SET @result = 1
	END
	ELSE
		SET @result = 0
	SELECT @result AS result
END

--EXEC STP_AddAnAccount 'Staff08',1,1
--DROP PROC STP_AddAnAccount
GO

--Proceduce Get full list staff
CREATE PROC GetFullStaff
AS
BEGIN
	SELECT idStaff, nameStaff, gender, phoneStaff, addressStaff FROM Staff WHERE isDeleted = 0
END

--EXEC GetFullStaff
--DROP PROC GetFullStaff
GO
--Proceduce Add a Staff
CREATE PROC AddStaff
(
	@nameStaff NVARCHAR(255),
	@gender BIT,
	@phoneStaff VARCHAR(15),
	@addressStaff NVARCHAR(255)
)
AS
BEGIN
	INSERT INTO Staff(nameStaff,gender,phoneStaff,addressStaff,isDeleted) VALUES (@nameStaff,@gender,@phoneStaff,@addressStaff,0)
END

--EXEC AddStaff N'Đoàn Văn Linh',1,'03758942631',N'Hải Dương',1.7,27
--DROP PROC AddStaff
GO

--Proceduce Search Account
CREATE PROC SearchAccount
@nameStaff NVARCHAR(255)
AS 
BEGIN
	SELECT A.userName,A.pass,A.typeAccount,S.nameStaff,S.idStaff
	FROM Account AS A,Staff AS S
	WHERE A.idStaff = S.idStaff AND A.isDeleted=0 AND dbo.F_ConvertToUnsigned(S.nameStaff) LIKE '%'+dbo.F_ConvertToUnsigned(@nameStaff)+'%'
END

--EXEC SearchAccount N'Anh'
--DROP PROC SearchAccount
GO 

--Proceduce Search Staff
CREATE PROC SearchStaff
@nameStaff NVARCHAR(255)
AS 
BEGIN
	SELECT S.idStaff, nameStaff, gender, phoneStaff, addressStaff FROM Staff AS S, Account AS A
	WHERE A.idStaff = S.idStaff AND A.isDeleted=0 AND dbo.F_ConvertToUnsigned(S.nameStaff) LIKE '%'+dbo.F_ConvertToUnsigned(@nameStaff)+'%'
END

--EXEC SearchStaff N'Anh'
--DROP PROC SearchStaff
GO

--Proceduce Edit Staff
CREATE PROC STP_EditStaff
	@name NVARCHAR(255),
	@gender BIT,
	@phoneStaff VARCHAR(15),
	@addressStaff NVARCHAR(255),
	@idStaff INT
AS
BEGIN
	UPDATE Staff SET nameStaff=@name, gender = @gender ,phoneStaff = @phoneStaff, addressStaff = @addressStaff WHERE idStaff = @idStaff
END

--EXEC STP_EditStaff 1,65664564,N'Hải Dương',1.2,12,1
--DROP PROC STP_EditStaff

GO

--Proceduce Delete Cake
CREATE PROC STP_DeleteCake
@idCake int
AS
BEGIN
	UPDATE Cake SET isDeleted = 1 WHERE idCake = @idCake
END

--EXEC STP_DeleteCake 1
--DROP PROC STP_DeleteCake
GO

--Proceduce Get Account By User Name
CREATE PROC STP_GetAccountByUserName
@userName VARCHAR(255)
AS
BEGIN
	SELECT A.userName,A.pass,A.typeAccount,S.nameStaff,S.idStaff
	FROM Staff AS S,Account AS A
	WHERE S.idStaff = A.idStaff AND A.isDeleted = 0 AND userName=@userName
END

EXEC STP_GetAccountByUserName 'staff01'
DROP PROC STP_GetAccountByUserName
GO

--Proceduce search supplier by supplier name
CREATE PROC STP_SearchSupplierBySupplierName
@nameSupplier NVARCHAR(255)
AS
BEGIN
	SELECT * FROM Supplier 
	WHERE isDeleted=0 AND dbo.F_ConvertToUnsigned(nameSupplier) LIKE '%'+dbo.F_ConvertToUnsigned(@nameSupplier)+'%'
END

--EXEC STP_SearchSupplierBySupplierName 'm'
--DROP PROC STP_SearchSupplierBySupplierName
GO

--Proceduce Get Full List Bill
CREATE PROC STP_GetFullListBill
AS
BEGIN
	SELECT B.idBill,FORMAT(B.exportDate,'dd/MM/yyyy') as exportDate,S.nameStaff,B.discount, 
		(SELECT SUM(BD.amountOrder*C.exportPrice) 
		FROM BillDetail AS BD, Cake AS C 
		WHERE BD.idBill=B.idBill AND C.idCake=BD.idCake) AS totalMoney
	FROM Bill AS B, Staff AS S
	WHERE B.idStaff=S.idStaff
END

--EXEC STP_GetFullListBill
--DROP PROC STP_GetFullListBill
GO

--Proceduce Get Full Bill Detail 
CREATE PROC STP_GetBillDetailByIDBill
@idBill INT
AS 
BEGIN
	SELECT nameCake,exportPrice,amountOrder
	FROM BillDetail AS BD, Cake AS C
	WHERE BD.idBill=@idBill AND C.idCake=BD.idCake
END

--EXEC STP_GetBillDetailByIDBill '5'
--DROP PROC STP_GetBillDetailByIDBill
GO

--Proceduce search bill by staff name
CREATE PROC STP_SearchBillByNameStaff
@nameStaff NVARCHAR(255)
AS 
BEGIN
	SELECT B.idBill,FORMAT(B.exportDate,'dd/MM/yyyy') as exportDate,S.nameStaff,B.discount, 
		(SELECT SUM(BD.amountOrder*C.exportPrice) 
		FROM BillDetail AS BD, Cake AS C 
		WHERE BD.idBill=B.idBill AND C.idCake=BD.idCake) AS totalMoney
	FROM Bill AS B, Staff AS S
	WHERE B.idStaff=S.idStaff AND dbo.F_ConvertToUnsigned(nameStaff) LIKE '%'+dbo.F_ConvertToUnsigned(@nameStaff)+'%'
END 

--EXEC STP_SearchBillByNameStaff 'OA'
--DROP PROC STP_SearchBillByNameStaff
GO

--Proceduce filter bill by date
CREATE PROC STP_FilterBillByDate
@startDate DATE,
@endDate Date
AS 
BEGIN
	SELECT B.idBill,FORMAT(B.exportDate,'dd/MM/yyyy') as exportDate,S.nameStaff,B.discount, 
		(SELECT SUM(BD.amountOrder*C.exportPrice) 
		FROM BillDetail AS BD, Cake AS C 
		WHERE BD.idBill=B.idBill AND C.idCake=BD.idCake) AS totalMoney
	FROM Bill AS B, Staff AS S
	WHERE B.idStaff=S.idStaff AND exportDate<=@endDate AND exportDate>=@startDate
END 

--EXEC STP_FilterBillByDate '2021-11-11','2021-11-20'
--EXEC STP_FilterBillByDate '2021-11-15','2021-11-15'
--DROP PROC STP_FilterBillByDate
GO

--Proceduce statistical revenue 7 days ago
CREATE PROC STP_StatisticalRevenue7Days
@startDate DATE,
@endDate Date
AS 
BEGIN
	SELECT FORMAT(B.exportDate,'dd/MM/yyyy') as exportDate, SUM(BD.amountOrder*C.exportPrice) AS totalMoney 
	FROM BillDetail AS BD, Cake AS C, Bill AS B 
	WHERE BD.idBill=B.idBill AND C.idCake=BD.idCake AND exportDate<=@endDate AND exportDate>=@startDate 
	GROUP BY exportDate
END 

--EXEC STP_StatisticalRevenue7Days '2020-11-10','2020-11-30'
--DROP PROC STP_StatisticalRevenue7Days
GO

--Proceduce statistical 10 best seller cake 30 days ago
CREATE PROC STP_Statistical10BestSeller
@startDate DATE,
@endDate Date
AS 
BEGIN
	SELECT TOP(10) nameCake,SUM(amountOrder) AS order1 
	FROM BillDetail AS BD, Cake AS C, Bill AS B 
	WHERE BD.idBill=B.idBill AND C.idCake=BD.idCake AND exportDate<=@endDate AND exportDate>=@startDate 
	GROUP BY nameCake
	ORDER BY order1 DESC
END 

--EXEC STP_Statistical10BestSeller '2020-12-1','2020-12-30'
--DROP PROC STP_Statistical10BestSeller
GO

--Proceduce statistical 10 slowest seller cake 30 days ago
CREATE PROC STP_Statistical10SlowestSeller
@startDate DATE,
@endDate Date
AS 
BEGIN
	SELECT TOP(10) nameCake,SUM(amountOrder) AS order1 
	FROM BillDetail AS BD, Cake AS C, Bill AS B 
	WHERE BD.idBill=B.idBill AND C.idCake=BD.idCake AND exportDate<=@endDate AND exportDate>=@startDate
	GROUP BY nameCake
	ORDER BY order1
END 

--EXEC STP_Statistical10SlowestSeller'2020-12-1','2020-12-30'
--DROP PROC STP_Statistical10SlowestSeller
GO

--Proceduce statistical revenue 3 months ago
CREATE PROC STP_StatisticalRevenue3Months
@startDate DATE,
@endDate Date
AS 
BEGIN
	SELECT CONCAT(CONVERT(NVARCHAR(10),MONTH(exportDate)),'/',CONVERT(NVARCHAR(10),Year(exportDate))) as exportDate, SUM(BD.amountOrder*C.exportPrice) AS totalMoney
	FROM BillDetail AS BD, Cake AS C, Bill AS B 
	WHERE BD.idBill=B.idBill AND C.idCake=BD.idCake AND exportDate<=@endDate AND exportDate>=@startDate
	GROUP BY MONTH(exportDate),Year(exportDate)
END 

--EXEC STP_StatisticalRevenue3Months '2020-10-1','2021-1-8'
--DROP PROC STP_StatisticalRevenue3Months
GO

--Proceduce Get list Cake with category
CREATE PROC STP_GetFullCakeWithCategory
AS
BEGIN
	SELECT idCake,nameCake,C.nameCategory,exportPrice,remainingAmount,size,FORMAT(expCake,'dd/MM/yyyy') AS expCake 
	FROM Cake AS CA,Category AS C 
	WHERE CA.idCategory = C.idCategory AND CA.isDeleted = 0
END

--EXEC STP_GetFullCakeWithCategory
--DROP PROC STP_GetFullCakeWithCategory
GO

--Proceduce Edit Cake
CREATE PROC STP_EditCake
	@nameCake NVARCHAR(255),
	@price FLOAT,
	@size CHAR(5),
	@idCategory INT,
	@idCake INT
AS
BEGIN
	DECLARE @oldExportPrice FLOAT 
	SELECT @oldExportPrice=exportPrice FROM Cake WHERE idCake=@idCake
	IF(@oldExportPrice=@price)
		UPDATE Cake SET nameCake = @nameCake , exportPrice = @price , size = @size , idCategory =  @idCategory
		WHERE idCake = @idCake
	ELSE 
		UPDATE Cake SET nameCake = @nameCake , exportPrice = @price , size = @size , idCategory =  @idCategory
		WHERE nameCake=@nameCake AND size=@size
END

--EXEC STP_EditCake 'Kinh Đô',15000,L,'Bánh Trung Thu',1
--DROP PROC STP_EditCake
GO

--Proceduce search cake by cake name for Admin Cake
CREATE PROC STP_SearchCakeByCakeNameWithCategory
@cakeName NVARCHAR(255)
AS 
BEGIN
	SELECT C.idCake,nameCake,CA.nameCategory,exportPrice,remainingAmount,size,FORMAT(expCake,'dd/MM/yyyy') as expCake
	FROM Cake AS C, Category AS CA
	WHERE C.idCategory=CA.idCategory AND C.isDeleted=0 AND dbo.F_ConvertToUnsigned(nameCake) LIKE '%'+dbo.F_ConvertToUnsigned(@cakeName)+'%'
END

--EXEC STP_SearchCakeByCakeNameWithCategory N'Oreo'
--DROP PROC STP_SearchCakeByCakeNameWithCategory
GO

--Proceduce search cake by category name for Admin Cake
CREATE PROC STP_SearchCakeByCategoryNameWithCategory
@categoryName NVARCHAR(255)
AS 
BEGIN
	SELECT C.idCake,nameCake,CA.nameCategory,exportPrice,remainingAmount,size,FORMAT(expCake,'dd/MM/yyyy') as expCake
	FROM Cake AS C, Category AS CA
	WHERE C.idCategory=CA.idCategory AND C.isDeleted=0 AND dbo.F_ConvertToUnsigned(nameCategory) LIKE '%'+dbo.F_ConvertToUnsigned(@categoryName)+'%'
END

--EXEC STP_SearchCakeByCategoryNameWithCategory 'Gato'
--DROP PROC STP_SearchCakeByCategoryNameWithCategory
GO

--Proceduce Load Category
CREATE PROC STP_LoadCategory
AS
BEGIN
	SELECT idCategory,nameCategory  
	FROM Category
	WHERE isDeleted = 0
END
--EXEC STP_LoadCategory
--DROP PROC STP_LoadCategory
GO
--Proceduce Search Category
CREATE PROC STP_SearchCategoryByNameCategory
@categoryName NVARCHAR(255)
AS 
BEGIN
	SELECT CA.idCategory, CA.nameCategory  
	FROM Category AS CA LEFT JOIN Cake AS C
	ON CA.idCategory = C.idCategory
	WHERE CA.isDeleted=0 AND dbo.F_ConvertToUnsigned(nameCategory) LIKE '%'+dbo.F_ConvertToUnsigned(@categoryName)+'%'
	GROUP BY CA.idCategory , CA.nameCategory
END

--EXEC STP_SearchCategoryByNameCategory N'lạnh'
--DROP PROC STP_SearchCategoryByNameCategory
GO

--Trigger Delete Category
CREATE TRIGGER AFTER_DELETE_CATEGORY 
ON Category
FOR UPDATE
AS
BEGIN
	UPDATE Category SET nameCategory = N'Chưa phân loại' WHERE idCategory = (SELECT idCategory FROM inserted WHERE isDeleted = 1)
END

--DROP TRIGGER AFTER_DELETE_CATEGORY
--UPDATE Category SET isDeleted = 1 WHERE idCategory = 2
GO

--Proceduce Get Full 

--Proceduce Get List Cake Detail
CREATE PROC STP_GetFullListCakeDetail
AS 
BEGIN
	SELECT C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
	FROM Cake AS C , Category AS CA,
	Supplier AS S,ImportCoupon AS I,ImportCouponDetail AS IM
	WHERE S.idSupplier = I.idSupplier
	AND C.idCategory = CA.idCategory
	AND I.idCoupon = IM.idCoupon
	AND IM.idCake = C.idCake
	AND C.isDeleted=0
	GROUP BY C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
END

--EXEC STP_GetFullListCakeDetail
--DROP PROC STP_GetFullListCakeDetail
GO

--Proceduce Add Cake From Import Coupon
CREATE PROC STP_AddCakeFromCoupon
	@nameCake NVARCHAR(255) ,
	@exportPrice FLOAT ,
	@importPrice FLOAT,
	@remainingAmount INT ,
	@expCake DATE,
	@mfgCake DATE,
	@size CHAR(5),
	@nameCategory NVARCHAR(255)
AS 
BEGIN 
	SELECT * INTO #TempTable FROM Cake WHERE nameCake = @nameCake
	IF((SELECT COUNT(*) FROM #TempTable)>0)--HAS SAME CAKE
		BEGIN
			IF((SELECT COUNT(*) FROM #TempTable WHERE size = @size)>0)--HAS SAME SIZE
				BEGIN
					IF((SELECT COUNT(*) FROM #TempTable WHERE expCake = @expCake)>0)--HAS SAME EXP DAY
						UPDATE Cake SET remainingAmount = remainingAmount+@remainingAmount WHERE idCake = (SELECT idCake FROM #TempTable WHERE expCake = @expCake)
					ELSE
						INSERT INTO Cake VALUES (@nameCake,@exportPrice,@importPrice,@remainingAmount,@expCake,@mfgCake,@size,(SELECT idCategory FROM Category WHERE nameCategory = @nameCategory),0)
				END
			ELSE
				INSERT INTO Cake VALUES (@nameCake,@exportPrice,@importPrice,@remainingAmount,@expCake,@mfgCake,@size,(SELECT idCategory FROM Category WHERE nameCategory = @nameCategory),0)
		END
	ELSE
		INSERT INTO Cake VALUES (@nameCake,@exportPrice,@importPrice,@remainingAmount,@expCake,@mfgCake,@size,(SELECT idCategory FROM Category WHERE nameCategory = @nameCategory),0)
END
--EXEC STP_AddCakeFromCoupon N'Bánh trung thu nhân trứng muối sfv',30000,28000,120,'2021-01-02','2020-10-13','M',N'Bánh trung thu'
--DROP PROC STP_AddCakeFromCoupon
GO

--Proceduce Add Coupon Detail
CREATE PROC AddCouponDetail
	@idCoupon INT,
	@idCake INT,
	@amountCake INT,
	@priceImport FLOAT
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM ImportCouponDetail WHERE idCoupon = @idCoupon AND idCake = @idCake AND isDeleted = 0))
		INSERT INTO ImportCouponDetail VALUES (@idCoupon,@idCake,@amountCake,@priceImport,0)
	ELSE 
		UPDATE ImportCouponDetail SET amountCake = amountCake + @amountCake WHERE idCoupon = @idCoupon AND idCake = @idCake
END

--EXEC AddCouponDetail 6,3,25,28000
--DROP PROC AddCouponDetail
GO

--Proceduce Get Max id Coupon
CREATE PROC GetMaxIdCoupon
AS
BEGIN
	SELECT MAX(idCoupon) AS idCoupon FROM ImportCoupon WHERE  isDeleted = 0
END

--EXEC GetMaxIdCoupon
--DROP PROC GetMaxIdCoupon
GO

--Proceduce Get Max id Supplier
CREATE PROC STP_GetMaxIdSupplier
AS
BEGIN
	
	SELECT idSupplier FROM ImportCoupon WHERE  isDeleted = 0 AND idCoupon = (SELECT MAX(idCoupon) FROM ImportCoupon WHERE  isDeleted = 0)
END

--EXEC STP_GetMaxIdSupplier
--DROP PROC STP_GetMaxIdSupplier
GO

--Proceduce Get New Detail Coupon
CREATE PROC STP_GetNewDetailCoupon
AS
BEGIN
	DECLARE @newCoupon INT
	SET @newCoupon = (SELECT MAX(idCoupon) FROM ImportCoupon)
	SELECT IM.idCouponDetail,C.nameCake,C.size,amountCake,priceImport,(amountCake*priceImport) AS totalMoney,C.idCake,I.idCoupon
	FROM ImportCouponDetail AS IM,ImportCoupon AS I ,Cake AS C
	WHERE IM.idCoupon = I.idCoupon
	AND IM.idCake = C.idCake
	AND IM.isDeleted = 0 
	AND IM.idCoupon = @newCoupon
END

--EXEC STP_GetNewDetailCoupon
--DROP PROC STP_GetNewDetailCoupon
GO

--Proceduce Edit Detail Coupon
CREATE PROC STP_EditDetailCoupon
	@idCouponDetail INT,
	@amountCake INT,
	@amountCakeEdited INT,--số lượng chênh lệch
	@priceImport FLOAT
AS
BEGIN
	IF(@amountCake = 0)
		UPDATE ImportCouponDetail SET amountCake = 0, isDeleted = 1 WHERE idCouponDetail = @idCouponDetail
	ELSE
		UPDATE ImportCouponDetail SET amountCake = @amountCake , priceImport = @priceImport WHERE idCouponDetail = @idCouponDetail
	UPDATE Cake SET remainingAmount = remainingAmount + @amountCakeEdited WHERE idCake = (SELECT idCake FROM ImportCouponDetail WHERE idCouponDetail = @idCouponDetail)
END

--EXEC STP_EditDetailCoupon 4 , 0 , -1 , 20000
--DROP PROC STP_EditDetailCoupon
GO
--Proceduce Delete Coupon Present
CREATE PROC STP_DeleteCouponPresent
	@idImportCoupon INT
AS
BEGIN
	UPDATE ImportCoupon SET isDeleted = 1 WHERE idCoupon = @idImportCoupon
END

--EXEC STP_DeleteCouponPresent 1
--DROP PROC STP_DeleteCouponPresent
GO

--Proceduce search present cake by name cake
CREATE PROC STP_SearchPresentCakeByName
@cakeName NVARCHAR(255)
AS 
BEGIN
	SELECT C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
	FROM Cake AS C , Category AS CA,
	Supplier AS S,ImportCoupon AS I,ImportCouponDetail AS IM
	WHERE S.idSupplier = I.idSupplier
	AND C.idCategory = CA.idCategory
	AND I.idCoupon = IM.idCoupon
	AND IM.idCake = C.idCake
	AND C.isDeleted=0
	AND dbo.F_ConvertToUnsigned(nameCake) LIKE '%'+dbo.F_ConvertToUnsigned(@cakeName)+'%'
	GROUP BY C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
END

--EXEC STP_SearchPresentCakeByName N'Bơ'
--DROP PROC STP_SearchPresentCakeByName
GO

--Proceduce search present cake by name Supplier
CREATE PROC STP_SearchPresentCakeBySupplier
@supplierName NVARCHAR(255)
AS 
BEGIN
	SELECT C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
	FROM Cake AS C , Category AS CA,
	Supplier AS S,ImportCoupon AS I,ImportCouponDetail AS IM
	WHERE S.idSupplier = I.idSupplier
	AND C.idCategory = CA.idCategory
	AND I.idCoupon = IM.idCoupon
	AND IM.idCake = C.idCake
	AND C.isDeleted=0
	AND dbo.F_ConvertToUnsigned(nameSupplier) LIKE '%'+dbo.F_ConvertToUnsigned(@supplierName)+'%'
	GROUP BY C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
END

--EXEC STP_SearchPresentCakeBySupplier N'Lan'
--DROP PROC STP_SearchPresentCakeBySupplier
GO

--Proceduce search Coupon Detail by name Cake
CREATE PROC STP_SearchCouponDetailByName
@cakeName NVARCHAR(255)
AS 
BEGIN
	SELECT IM.idCouponDetail,C.nameCake,amountCake,priceImport,(amountCake*priceImport) AS totalMoney,C.idCake,I.idCoupon
	FROM ImportCouponDetail AS IM,ImportCoupon AS I ,Cake AS C
	WHERE IM.idCoupon = I.idCoupon
	AND IM.idCake = C.idCake
	AND IM.isDeleted = 0 
	AND dbo.F_ConvertToUnsigned(nameCake) LIKE '%'+dbo.F_ConvertToUnsigned(@cakeName)+'%'
END

--EXEC STP_SearchCouponDetailByName N'Bơ'
--DROP PROC STP_SearchCouponDetailByName
GO

--Proceduce DeleteCouponDetail
CREATE PROC STP_DeleteCouponDetail 
@idCoupon INT
AS
BEGIN
	UPDATE ImportCouponDetail SET isDeleted = 1 WHERE idCoupon = @idCoupon
END
--EXEC STP_DeleteCouponDetail 1
--DROP PROC STP_DeleteCouponDetail
GO

--Proceduce CheckExistsCategory
CREATE PROC STP_CheckExistsCategory
@nameCategory NVARCHAR(255)
AS
BEGIN
	SELECT COUNT(*) AS amount FROM Category WHERE isDeleted = 0 AND nameCategory = @nameCategory
END
--EXEC STP_CheckExistsCategory N'Bánh Lạnh'
--DROP PROC STP_CheckExistsCategory
GO


--Proceduce CheckExistsSupplier
CREATE PROC STP_CheckExistsSupplier
@nameSupplier NVARCHAR(255)
AS
BEGIN
	SELECT COUNT(*) AS amount FROM Supplier WHERE isDeleted = 0 AND nameSupplier = @nameSupplier
END
--EXEC STP_CheckExistsSupplier N'Kinh Đô'
--DROP PROC STP_CheckExistsSupplier
GO

--Proceduce GetListCoupon Import
CREATE PROC STP_GetListCouponImport
AS
BEGIN 
	SELECT idCoupon,S.nameSupplier,dayImport
	FROM ImportCoupon AS I,Supplier AS S
	WHERE I.idSupplier = S.idSupplier
	AND I.isDeleted = 0
END

--EXEC STP_GetListCouponImport
--DROP PROC STP_GetListCouponImport
GO

--Proceduce Get Detail Coupon Import By id
CREATE PROC STP_GetDetailCouponImport
@idCoupon INT
AS
BEGIN 
	SELECT IM.idCouponDetail,C.nameCake,C.size,amountCake,priceImport,(amountCake*priceImport) AS totalMoney
	FROM ImportCouponDetail AS IM,ImportCoupon AS I ,Cake AS C
	WHERE IM.idCoupon = I.idCoupon
	AND IM.idCake = C.idCake
	AND IM.isDeleted = 0 
	AND IM.idCoupon = @idCoupon
END

--EXEC STP_GetDetailCouponImport 1
--DROP PROC STP_GetDetailCouponImport
GO

--Proceduce search Coupon By Supplier
CREATE PROC STP_SearchCouponBuSupplier
@nameSupplier NVARCHAR(255)
AS 
BEGIN
	SELECT idCoupon,S.nameSupplier,dayImport
	FROM ImportCoupon AS I,Supplier AS S
	WHERE I.idSupplier = S.idSupplier
	AND I.isDeleted = 0
	AND dbo.F_ConvertToUnsigned(S.nameSupplier) LIKE '%'+dbo.F_ConvertToUnsigned(@nameSupplier)+'%'
END

--EXEC STP_SearchCouponBuSupplier N'Kinh Đô'
--DROP PROC STP_SearchCouponBuSupplier
GO

--Proceduce Filter Coupon by date
CREATE PROC STP_FilterCouponByDate
@startDate DATE,
@endDate Date
AS 
BEGIN
	SELECT idCoupon,S.nameSupplier,dayImport
	FROM ImportCoupon AS I,Supplier AS S
	WHERE I.idSupplier = S.idSupplier
	AND I.isDeleted = 0
	AND dayImport<=@endDate AND dayImport>=@startDate
END 

--EXEC STP_FilterCouponByDate '2020-1-1','2020-2-2'
--DROP PROC STP_FilterCouponByDate
GO
--Proceduce GetCakeById
CREATE PROC STP_GetCakeById
@id INT
AS 
BEGIN
	SELECT C.idCake,nameCake,C.exportPrice,remainingAmount,mfgCake,expCake,size,CA.nameCategory
	FROM Cake AS C, Category AS CA
	WHERE C.idCategory=CA.idCategory AND C.isDeleted=0 AND C.idCake = @id
END

--EXEC STP_GetCakeById 1
--DROP PROC STP_GetCakeById
GO

--Proceduce Get Detail Import Coupon by ID
CREATE PROC STP_GetDetailImportCouponById
@id INT
AS
BEGIN
	SELECT C.idCake,nameCake,exportPrice,importPrice,IM.amountCake,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
	FROM Cake AS C , Category AS CA,
	Supplier AS S,ImportCoupon AS I,ImportCouponDetail AS IM
	WHERE S.idSupplier = I.idSupplier
	AND C.idCategory = CA.idCategory
	AND I.idCoupon = IM.idCoupon
	AND IM.idCake = C.idCake
	AND C.isDeleted=0
	AND IM.idCouponDetail = @id
	GROUP BY C.idCake,nameCake,exportPrice,importPrice,IM.amountCake,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
END

--EXEC STP_GetDetailImportCouponById 1
--DROP PROC STP_GetDetailImportCouponById
GO
--Proceduce Get Detail Import Coupon by ID
CREATE PROC STP_GetCakePresentById
@id INT
AS
BEGIN
	SELECT C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
	FROM Cake AS C , Category AS CA,
	Supplier AS S,ImportCoupon AS I,ImportCouponDetail AS IM
	WHERE S.idSupplier = I.idSupplier
	AND C.idCategory = CA.idCategory
	AND I.idCoupon = IM.idCoupon
	AND IM.idCake = C.idCake
	AND C.isDeleted=0
	AND C.idCake = @id
	GROUP BY C.idCake,nameCake,exportPrice,importPrice,remainingAmount,expCake,mfgCake,size,CA.nameCategory,S.nameSupplier,I.dayImport,S.idSupplier
END

--EXEC STP_GetCakePresentById 1
--DROP PROC STP_GetCakePresentById
GO

--Procedure Get List Salary
CREATE PROC STP_GetListSalary
@date DATE
AS
BEGIN
	SELECT S.idStaff, nameStaff,salaryDate,SA.workDays,hoursOverTime,rewards,salaryOverTime,FORMAT(salaryTime,'MM/yyyy') AS salaryTime
	FROM Staff AS S, Salary AS SA
	WHERE S.idStaff=SA.idStaff AND S.isDeleted=0 AND MONTH(@date)=MONTH(salaryTime) AND YEAR(@date) = YEAR(salaryTime)
END

--EXEC STP_GetListSalary '2020-11-17'
--DROP PROC STP_GetListSalary
GO

--Procedure Payroll
CREATE PROC STP_Payroll
@date DATE
AS
BEGIN
	SELECT S.idStaff, nameStaff,salaryDate,SA.workDays,hoursOverTime,rewards,salaryOverTime,(salaryDate*workDays+hoursOverTime*salaryOverTime+rewards) AS salary
	FROM Staff AS S, Salary AS SA
	WHERE S.idStaff=SA.idStaff AND S.isDeleted=0 AND MONTH(@date)=MONTH(salaryTime) AND YEAR(@date) = YEAR(salaryTime)
END
--EXEC STP_Payroll '2020-11-17'
--DROP PROC STP_Payroll
GO

--Procedure Get List Salary By Staff Name
CREATE PROC STP_GetListSalaryByStaffName
@staffName NVARCHAR(255)
AS
BEGIN
	SELECT S.idStaff, nameStaff,salaryDate,SA.workDays,hoursOverTime,rewards,salaryOverTime,FORMAT(salaryTime,'MM/yyyy') AS salaryTime
	FROM Staff AS S, Salary AS SA
	WHERE S.idStaff=SA.idStaff AND S.isDeleted=0 AND dbo.F_ConvertToUnsigned(nameStaff) LIKE '%'+dbo.F_ConvertToUnsigned(@staffName)+'%'
END

--EXEC STP_GetListSalaryByStaffName 'am'
--DROP PROC STP_GetListSalaryByStaffName
GO


--Procedure Get List Salary By Staff Id
CREATE PROC STP_GetListSalaryByStaffID
@idStaff INT,
@date DATE
AS
BEGIN
	SELECT S.idStaff, nameStaff,salaryDate,SA.workDays,hoursOverTime,rewards,salaryOverTime,twoDateIsTimeKeeped,dateIsTimeKeeped,salaryTime,FORMAT(salaryTime,'MM/yyyy') AS salaryTime
	FROM Staff AS S, Salary AS SA
	WHERE S.idStaff=SA.idStaff AND S.isDeleted=0 AND MONTH(@date)=MONTH(salaryTime) AND YEAR(@date) = YEAR(salaryTime) AND S.idStaff=@idStaff
END

--EXEC STP_GetListSalaryByStaffID 2,'2020-12-1'
--DROP PROC STP_GetListSalaryByStaffID
GO

--Procedure insert salary
CREATE PROC STP_TimeKeeping
@hoursOverTime INT,
@idStaff INT
AS
BEGIN
	DECLARE @currentDate DATE
	DECLARE @newIDSalary INT
	SELECT @newIDSalary = MAX(idSalary) FROM Salary WHERE idStaff=@idStaff
	SET @currentDate = GETDATE()
	SELECT * INTO TempleSalary FROM Salary WHERE idStaff=@idStaff AND MONTH(salaryTime)=MONTH(@currentDate) AND YEAR(salaryTime)=YEAR(@currentDate)
	DECLARE @id_Salary INT
	SELECT @id_Salary=idSalary FROM TempleSalary
	UPDATE Salary SET 
	oldHoursOverTime=hoursOverTime,
	hoursOverTime=hoursOverTime+@hoursOverTime, 
	workDays=workDays+1,
	twoDateIsTimeKeeped=dateIsTimeKeeped,
	dateIsTimeKeeped=@currentDate
	WHERE idSalary=@id_Salary
	DROP TABLE TempleSalary
END

--EXEC STP_TimeKeeping 2,2
--DROP PROC STP_TimeKeeping
GO

--Procedure insert salary new month
CREATE PROC STP_InsertSalaryNewMonth
AS
BEGIN
	DECLARE @currentDate DATE
	SET @currentDate = GETDATE()
	SELECT * INTO TempleStaff FROM Staff WHERE isDeleted=0
	DECLARE @RowTempleStaff INT
	SELECT @RowTempleStaff = COUNT(*) FROM TempleStaff
	DECLARE @count INT
	SET @count=0
	WHILE @count<@RowTempleStaff
		BEGIN		
			DECLARE @idStaff INT
			SELECT TOP(1) @idStaff=idStaff FROM TempleStaff	
			DECLARE @newIDSalary INT
			SELECT @newIDSalary = MAX(idSalary) FROM Salary WHERE idStaff=@idStaff
			IF(@newIDSalary=NULL) SET @newIDSalary=-1
			IF(@newIDSalary!=-1)
				BEGIN
					DECLARE @salaryDate FLOAT
					DECLARE @rewards FLOAT
					DECLARE @salaryOverTime FLOAT
					DECLARE @dateIsKeeped DATE
					DECLARE @twoDateIsTimeKeeped DATE

					SELECT @salaryDate = salaryDate,@rewards=rewards,@salaryOverTime=salaryOverTime,@dateIsKeeped=dateIsTimeKeeped,@twoDateIsTimeKeeped=twoDateIsTimeKeeped
					FROM Salary WHERE idSalary=@newIDSalary

					INSERT INTO Salary(salaryDate,workDays,hoursOverTime,oldHoursOverTime,rewards,salaryOverTime,dateIsTimeKeeped,twoDateIsTimeKeeped,salaryTime,idStaff) VALUES
					(@salaryDate,0,0,0,@rewards,@salaryOverTime,@dateIsKeeped,@twoDateIsTimeKeeped,GETDATE(),@idStaff)
					DELETE TempleStaff WHERE idStaff=2
				END
				SET @count=@count+1
				DELETE TempleStaff WHERE idStaff=@idStaff
		END
	DROP TABLE TempleStaff
END

--EXEC STP_InsertSalaryNewMonth 12
--DROP PROC STP_InsertSalaryNewMonth
GO

--Procedure cancel time keeping salary
CREATE PROC STP_CancelTimeKeeping
@idStaff INT
AS
BEGIN
	DECLARE @currentDate DATE
	DECLARE @newIDSalary INT
	SELECT @newIDSalary = MAX(idSalary) FROM Salary WHERE idStaff=@idStaff
	SET @currentDate = GETDATE()
	SELECT * INTO TempleSalary FROM Salary WHERE idStaff=@idStaff AND MONTH(salaryTime)=MONTH(@currentDate) AND YEAR(salaryTime)=YEAR(@currentDate)
	DECLARE @id_Salary INT
	SELECT @id_Salary=idSalary FROM TempleSalary
	UPDATE Salary SET 
	hoursOverTime=oldHoursOverTime,
	oldHoursOverTime=0,
	workDays=workDays-1,
	dateIsTimeKeeped=twoDateIsTimeKeeped,
	twoDateIsTimeKeeped=NULL
	WHERE idSalary=@id_Salary
	DROP TABLE TempleSalary
END

--EXEC STP_CancelTimeKeeping 2
--DROP PROC STP_CancelTimeKeeping
GO

--Procedure update salary
CREATE PROC STP_UpdateSalaryByIdStaff
@idStaff INT,
@salaryDate FLOAT,
@reward FLOAT,
@salaryOverTime FLOAT
AS
BEGIN
	DECLARE @currentDate DATE
	DECLARE @newIDSalary INT
	SELECT @newIDSalary = MAX(idSalary) FROM Salary WHERE idStaff=@idStaff
	SET @currentDate = GETDATE()
	SELECT * INTO TempleSalary FROM Salary WHERE idStaff=@idStaff AND MONTH(salaryTime)=MONTH(@currentDate) AND YEAR(salaryTime)=YEAR(@currentDate)
	DECLARE @id_Salary INT
	SELECT @id_Salary=idSalary FROM TempleSalary
	UPDATE Salary SET 
	salaryDate=@salaryDate,
	rewards=@reward,
	salaryOverTime=@salaryOverTime
	WHERE idSalary=@id_Salary
	DROP TABLE TempleSalary
END

--EXEC STP_UpdateSalaryByIdStaff 2,250000,500000,25000
--DROP PROC STP_UpdateSalaryByIdStaff
GO

--Function check exists salary by id staff
CREATE FUNCTION F_CheckExistsSalaryByIdStaff
(@idStaff INT)
RETURNS BIT
AS 
BEGIN
	DECLARE @result BIT
	SET @result = 0
	IF(EXISTS(SELECT * FROM Salary WHERE idStaff=@idStaff))
		SET @result=1
	RETURN @result
END

--SELECT DBO.F_CheckExistsSalaryByIdStaff (2)
--DROP FUNCTION DBO.F_CheckExistsSalaryByIdStaff
GO

--Procedure insert salary by id staff
CREATE PROC STP_InsertNewSalaryByIdStaff
@idStaff INT,
@salaryDate FLOAT,
@salaryOverTime FLOAT
AS
BEGIN 
	INSERT INTO Salary(salaryDate,workDays,hoursOverTime,oldHoursOverTime,rewards,salaryOverTime,dateIsTimeKeeped,twoDateIsTimeKeeped,salaryTime,idStaff) VALUES
	(@salaryDate,0,0,0,0,@salaryOverTime,GETDATE(),NULL,GETDATE(),@idStaff)
END

--EXEC STP_InsertNewSalaryByIdStaff 1,120000,15000
--DROP PROC STP_InsertNewSalaryByIdStaff 
GO


SELECT * FROM Salary
SELECT * FROM Supplier
SELECT * FROM Category
SELECT * FROM ImportCoupon 
SELECT * FROM ImportCouponDetail
SELECT * FROM Cake
SELECT * FROM Bill
SELECT * FROM BillDetail
SELECT * FROM Staff
SELECT * FROM Account
