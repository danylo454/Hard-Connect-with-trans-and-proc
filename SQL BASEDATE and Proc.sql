use Stationery_firm
go

create table Manager(
Id int identity primary key not null,
Name nvarchar(20) not null,
SurName nvarchar(20) not null
);
go

create table Stationery(
Id int identity primary key not null,
Type nvarchar(max) not null,
Name nvarchar(max) not null,
Count int not null,
Price money not null
);
go
create table Sales(
Id int identity not null,
IdManager int foreign key references Manager(Id) not null,
Type nvarchar(max) not null,
Name nvarchar(max) not null,
Price money not null,
DateBought date not null,
FirmNameBought nvarchar(max) not null,
CountBought int not null
);
go

--Insert Manager 
INSERT INTO [Manager] (Name,SurName)
VALUES
  ('Garth','French'),
  ('Leandra','West'),
  ('Constance','Andrews'),
  ('Sophia','Roth'),
  ('Eric','Lawrence'),
  ('Damon','Copeland'),
  ('Keegan','Dominguez'),
  ('Meghan','Waters'),
  ('Bernard','Mckee'),
  ('Raymond','Dotson');
INSERT INTO [Manager] (Name,SurName)
VALUES
  ('Daquan','Hebert'),
  ('Erica','Brown'),
  ('Jin','Mcconnell'),
  ('Derek','Rose'),
  ('Emerson','Mathews'),
  ('Honorato','Combs'),
  ('Honorato','Buckley'),
  ('Angela','Wooten'),
  ('Zorita','Wolfe'),
  ('Bell','Gay');
  go
--Insert Stationery
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Electronics','Pen',138,526),
  ('Clothes','Copybook',217,948),
  ('Stationery','Copybook',238,741),
  ('Clothes','Eraser',159,575),
  ('Clothes','Socks',86,849),
  ('Stationery','Pen',149,836),
  ('Clothes','Socks',211,771),
  ('Clothes','Pen',150,980),
  ('Clothes','Copybook',85,761),
  ('Electronics','Copybook',231,629);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Electronics','Book',146,804),
  ('Stationery','Book',243,773),
  ('Clothes','Pants',132,656),
  ('Clothes','Laptop',130,599),
  ('Clothes','Backpack',203,561),
  ('Clothes','Socks',224,516),
  ('Clothes','Copybook',218,830),
  ('Electronics','Book',186,890),
  ('Electronics','Copybook',135,572),
  ('Stationery','Backpack',176,913);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Electronics','Eraser',138,907),
  ('Clothes','Pants',249,703),
  ('Stationery','Cap',233,899),
  ('Electronics','Pen',159,954),
  ('Electronics','Pants',222,586),
  ('Clothes','Cap',155,814),
  ('Stationery','Laptop',125,978),
  ('Electronics','Pen',87,905),
  ('Clothes','Book',231,533),
  ('Electronics','Pants',223,714);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Electronics','Pen',156,600),
  ('Clothes','Laptop',82,763),
  ('Clothes','Socks',208,531),
  ('Clothes','Socks',108,896),
  ('Stationery','Backpack',214,530),
  ('Electronics','Laptop',196,819),
  ('Clothes','Laptop',113,525),
  ('Stationery','Book',87,984),
  ('Clothes','Copybook',105,833),
  ('Clothes','Pants',169,776);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Stationery','Laptop',210,861),
  ('Clothes','Copybook',135,903),
  ('Electronics','Copybook',64,623),
  ('Electronics','Cap',70,762),
  ('Clothes','Book',195,696),
  ('Stationery','Copybook',217,708),
  ('Clothes','Backpack',199,933),
  ('Clothes','Eraser',116,589),
  ('Stationery','Copybook',194,620),
  ('Electronics','Copybook',141,751);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Electronics','Pants',215,652),
  ('Electronics','Pants',115,878),
  ('Stationery','Book',229,540),
  ('Clothes','Eraser',243,875),
  ('Electronics','Pants',193,891),
  ('Clothes','Laptop',80,686),
  ('Clothes','Sneakers',114,871),
  ('Electronics','Cap',186,583),
  ('Clothes','Cap',182,573),
  ('Stationery','Laptop',185,979);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Clothes','Backpack',157,503),
  ('Electronics','Sneakers',108,848),
  ('Clothes','Pants',231,991),
  ('Stationery','Pen',162,514),
  ('Clothes','Pen',212,726),
  ('Electronics','Sneakers',58,720),
  ('Clothes','Pants',108,977),
  ('Clothes','Book',174,815),
  ('Electronics','Pants',78,610),
  ('Clothes','Socks',133,651);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Clothes','Socks',60,982),
  ('Stationery','Book',56,725),
  ('Stationery','Cap',185,574),
  ('Clothes','Sneakers',162,715),
  ('Stationery','Sneakers',108,637),
  ('Clothes','Laptop',108,513),
  ('Clothes','Eraser',230,773),
  ('Clothes','Eraser',151,685),
  ('Clothes','Pen',57,938),
  ('Clothes','Backpack',195,778);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Clothes','Pen',65,660),
  ('Electronics','Socks',173,872),
  ('Stationery','Cap',140,758),
  ('Stationery','Book',212,844),
  ('Clothes','Pants',78,684),
  ('Clothes','Cap',195,847),
  ('Stationery','Backpack',141,792),
  ('Electronics','Cap',189,608),
  ('Clothes','Laptop',182,829),
  ('Electronics','Laptop',72,819);
INSERT INTO [Stationery] (Type,Name,Count,Price)
VALUES
  ('Clothes','Sneakers',215,728),
  ('Electronics','Socks',180,748),
  ('Stationery','Eraser',237,598),
  ('Stationery','Eraser',96,970),
  ('Clothes','Backpack',185,629),
  ('Clothes','Book',141,890),
  ('Clothes','Backpack',200,772),
  ('Clothes','Sneakers',82,981),
  ('Clothes','Eraser',118,519),
  ('Electronics','Eraser',65,905);
  go
--Procedure Buy
CREATE PROC BuyAndAddSales
@IdStationery int,
@IdManager int,
@NameFirmaBuy nvarchar(max),
@CountBuy int
AS
	declare @CountStationery int;
	set @CountStationery = (Select [Count] from Stationery where Id = @IdStationery);
	declare @Name nvarchar(max);
			declare @Type nvarchar(max);
			declare @Price money;
				set @Name =(Select Name from Stationery where Id = @IdStationery);
				set @Type =(Select Type from Stationery where Id = @IdStationery);
			    set @Price =(Select Price from Stationery where Id = @IdStationery);
		If @CountStationery = @CountBuy
			Begin
			Insert Sales Values(@IdManager,@Type,@Name,@Price,GETDATE(),@NameFirmaBuy,@CountBuy);
			Delete from Stationery where Id = @IdStationery;
			End
		else if @CountStationery > @CountBuy
			Begin
			declare @CountNew int;
			set @CountNew = @CountStationery - @CountBuy;
				Insert Sales Values(@IdManager,@Type,@Name,@Price,GETDATE(),@NameFirmaBuy,@CountBuy);
				Update Stationery set Count = @CountNew where Id = @IdStationery;
			End
		else
			Begin
				Print 'Error!!! operation!!!!';
			End
go

select * from Sales
select * from Manager
select * from Stationery
select * from Stationery where Count = (select Max(Count) from Stationery)
go


create proc ShowStationeryByType
@TypeName nvarchar(max)
as
declare @Error nvarchar(20);
IF EXISTS (SELECT Type FROM Stationery WHERE Type =@TypeName)
	Begin
	Select * from Stationery where Type = @TypeName;
	End
else
	begin
	set @Error = 'Error Type!!!';
		Print @Error;
	end
go

create proc ShowManagerHadSold
@TypeName nvarchar(max)
as
declare @id int;
IF EXISTS (SELECT Name FROM Manager WHERE Name =@TypeName)
	Begin
		Select * from Sales
		left join Manager as m
		on m.Name = @TypeName
	End
else
	begin
		declare @Error nvarchar(20);
		set @Error = 'Error Name Manager!!!';
		Print @Error;
	end
go

create proc SearchSoldByFirma
@NameFirma nvarchar(max)
as
IF EXISTS (SELECT FirmNameBought FROM Sales WHERE FirmNameBought =@NameFirma)
	begin
		select * from Sales where FirmNameBought = @NameFirma;
	end
else
	begin
		Print 'Error!!!';
	end
go



SELECT distinct Type,AVG(Count) FROM Stationery group by Type

