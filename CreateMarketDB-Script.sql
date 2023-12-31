USE [master]
GO
/****** Object:  Database [MarketDB]    Script Date: 8/29/2023 5:12:43 PM ******/
CREATE DATABASE [MarketDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MarketDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MarketDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MarketDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\MarketDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MarketDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MarketDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MarketDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MarketDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MarketDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MarketDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MarketDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MarketDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MarketDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MarketDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MarketDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MarketDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MarketDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MarketDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MarketDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MarketDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MarketDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MarketDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MarketDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MarketDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MarketDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MarketDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MarketDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MarketDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MarketDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MarketDB] SET  MULTI_USER 
GO
ALTER DATABASE [MarketDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MarketDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MarketDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MarketDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MarketDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MarketDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MarketDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MarketDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MarketDB]
GO
/****** Object:  Table [dbo].[Buyers]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buyers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BuyerName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Passsword] [nvarchar](50) NULL,
	[AccountStatus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [int] NULL,
	[Quantity] [int] NULL,
	[Category] [nvarchar](50) NULL,
	[SellerId] [int] NULL,
	[BuyerId] [int] NULL,
	[ProductId] [int] NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Price] [int] NULL,
	[Quantity] [int] NULL,
	[Category] [nvarchar](50) NULL,
	[SellerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [int] NOT NULL,
	[SellerId] [int] NULL,
	[BuyerId] [int] NULL,
	[Date] [varchar](50) NULL,
	[TotalBill] [int] NULL,
	[ProductName] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sellers]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sellers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SellerName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Passsword] [nvarchar](50) NULL,
	[AccountStatus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_SellerId_Cart] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Sellers] ([Id])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_SellerId_Cart]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_SellerId] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Sellers] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_SellerId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_BuyerId] FOREIGN KEY([BuyerId])
REFERENCES [dbo].[Buyers] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_BuyerId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SellerId] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Sellers] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_SellerId]
GO
/****** Object:  StoredProcedure [dbo].[spBanBuyer]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spBanBuyer]
	@Id int
AS
	Begin
		Update dbo.Buyers set AccountStatus = 0 where Id = @Id;
	end
GO
/****** Object:  StoredProcedure [dbo].[spBanSeller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spBanSeller]
	@Id int
AS
	Begin
		Update dbo.Sellers set AccountStatus = 0 where Id = @Id;

	DECLARE @ProductId INT;
	DECLARE @CartId INT;
	DECLARE @SellerId INT;

	WHILE EXISTS (SELECT TOP 1 * FROM Cart)
	BEGIN
		SELECT TOP 1 @ProductId = ProductId, @CartId = Id
		FROM Cart;

		UPDATE Products
		SET Products.Quantity = Products.Quantity + 1
		WHERE Products.Id = @ProductId;

		DELETE FROM Cart
		WHERE ProductId = @ProductId And Id = @CartId;
	END;

	end
GO
/****** Object:  StoredProcedure [dbo].[spCreateBuyer]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCreateBuyer]
	@Id int output,
	@FullName nvarchar(50),
	@Username nvarchar(50),
	@Passsword nvarchar(50),
	@Email nvarchar(50),
	@PhoneNumber nvarchar(50),
	@AccountStatus BIT = 1

AS
begin
	set nocount on;

	insert into dbo.Buyers (BuyerName, PhoneNumber, Email, Username, Passsword, AccountStatus) values (@FullName, @PhoneNumber, @Email, @Username, @Passsword, @AccountStatus);
	
	SELECT @Id = SCOPE_IDENTITY();
	
end
GO
/****** Object:  StoredProcedure [dbo].[spCreateProduct]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCreateProduct]
	@Id int output,
	@Name nvarchar(50),
	@Price int,
	@Quantity int,
	@Category nvarchar(50),
	@SellerId int
AS
	Begin
		set nocount on;

			insert into dbo.Products (Name, Price, Quantity, Category,SellerId) values (@Name, @Price, @Quantity, @Category, @SellerId)

			Select @Id = Scope_Identity();
	end
GO
/****** Object:  StoredProcedure [dbo].[spCreateSale]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCreateSale]
	@BuyerId int,
	@TotalBill int
AS
	begin
		Declare @BatchId int;

		Set @BatchId = (Select isNUll(Max(Id), 0)+1 from dbo.Sales)

		Insert into dbo.Sales (Id, SellerId, BuyerId, Date, TotalBill, ProductName)
		Select @BatchId, SellerId , @BuyerId, GETDATE(), @TotalBill, Name from dbo.Cart where BuyerId = @BuyerId;

		delete from dbo.Cart where BuyerId = @BuyerId ;
	end
GO
/****** Object:  StoredProcedure [dbo].[spCreateSeller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spCreateSeller]
	@Id int output,
	@FullName nvarchar(50),
	@PhoneNumber nvarchar(50),
	@Email nvarchar(50),
	@Username nvarchar(50),
	@Passsword nvarchar(50),
	@AccountStatus BIT = 1
AS
Begin
	set nocount on;

	insert into dbo.Sellers (SellerName, PhoneNumber, Email, Username, Passsword, AccountStatus) values (@FullName, @PhoneNumber, @Email, @Username, @Passsword, @AccountStatus)

	SELECT @Id = SCOPE_IDENTITY();
	

end
GO
/****** Object:  StoredProcedure [dbo].[spDeleteProduct]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDeleteProduct]
	@DeleteId int,
	@LatestId int output
AS
	Begin
		set nocount on;

		delete from dbo.Cart where ProductId = @DeleteId;

		delete from dbo.Products where Id = @DeleteId;

		Select @LatestId = ISNULL(Max(Id),0) from dbo.Products;

	end
GO
/****** Object:  StoredProcedure [dbo].[spGetAccountStatus]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAccountStatus]
	@Username nvarchar(50)
AS
begin
	Select IsNull((Select AccountStatus from dbo.Buyers where Username = @Username), 1 )
	union
	Select IsNull((Select AccountStatus from dbo.Sellers where Username = @Username), 1);
end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllBuyers]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllBuyers]
	@Name nvarchar(50)
AS
	begin
		SELECT * from dbo.Buyers where (BuyerName = @Name or @Name is null);
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllDates_Buyer]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllDates_Buyer]
	@BuyerId int
	
AS
	Begin
	set nocount on;
		select Date from dbo.Sales where BuyerId = @BuyerId;
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllDates_Seller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllDates_Seller]
	@SellerId int
	
AS
	Begin
	set nocount on;
		select Date from dbo.Sales where SellerId = @SellerId;
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetAllProducts_Seller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllProducts_Seller]
	@SellerId int
AS
	Begin
		set nocount on;

		select * from dbo.Products where SellerId = @SellerId;

	End
GO
/****** Object:  StoredProcedure [dbo].[spGetAllSellers]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllSellers]
	@Name nvarchar(50)
AS
	begin
		SELECT * from dbo.Sellers where (SellerName = @Name or @Name is Null);
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetCartProducts]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCartProducts]
	@BuyerId int 
AS
	begin
		Select * from dbo.Cart where BuyerId = @BuyerId;
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetCartTable]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCartTable]
	@BuyerId int,
	@Category nvarchar(50)
AS
	begin
		Select Cart.Id, Name, Price, Category, SellerName from dbo.Cart 
		inner join Sellers on Sellers.Id = Cart.SellerId
		where BuyerId = @BuyerId AND (Category = @Category or @Category is null);
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetCustomerDetails]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetCustomerDetails]
	@Username nvarchar(50),
	@BuyerName nvarchar(50) = '' output,
	@SellerName nvarchar(50) = ''  output
AS
begin
	Select * from dbo.Buyers where Username = @Username
	Union
	Select * from dbo.Sellers where Username = @Username;

	Select @BuyerName = BuyerName from Buyers where Buyers.Username = @Username;
	
	Select @SellerName = SellerName from Sellers where Sellers.Username = @Username;

end
GO
/****** Object:  StoredProcedure [dbo].[spGetProduct]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetProduct]
	@Id int
AS
	begin
		Select * from dbo.Products where Id = @Id;
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetProductTable_Buyer]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetProductTable_Buyer]
	@Category nvarchar(50)
AS
begin
	set nocount on;
	
	Select Products.Id, Name, Price, Quantity, Category, SellerName from dbo.Products inner join dbo.Sellers on Sellers.Id = Products.SellerId where AccountStatus = 1 And (Category = @Category or @Category Is Null) And Quantity > 0 ;

end
GO
/****** Object:  StoredProcedure [dbo].[spGetProductTable_Seller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetProductTable_Seller]
	@Category nvarchar(50),
	@SellerId int
As
Begin
	select Id, Name, Price, Quantity,Category from dbo.Products where SellerId = @SellerId And (Category = @Category or @Category Is Null)
end
GO
/****** Object:  StoredProcedure [dbo].[spGetSalesTable_Admin]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetSalesTable_Admin]
	@DateTime dateTime
AS
	Begin
		set nocount on;

		select Sales.Id, SellerName, ProductName, Date, TotalBill from Sales   
		inner join dbo.Sellers on Sellers.Id = SellerId
		WHERE (Date =  @DateTime OR @DateTime IS NULL)

	end
GO
/****** Object:  StoredProcedure [dbo].[spGetSalesTable_Buyer]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetSalesTable_Buyer]
	@BuyerId int,
	@DateTime dateTime
AS
	Begin
		set nocount on;

		select Sales.Id, SellerName, ProductName, Date, TotalBill from Sales   
		inner join dbo.Sellers on Sellers.Id = SellerId
		WHERE BuyerId = @BuyerId And (Date =  @DateTime OR @DateTime IS NULL)

	end
GO
/****** Object:  StoredProcedure [dbo].[spGetSalesTable_Seller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetSalesTable_Seller]
	@SellerId int,
	@DateTime dateTime
AS
	Begin
		set nocount on;

		select Sales.Id, BuyerName, ProductName, Date , TotalBill from Sales  
		inner join dbo.Buyers on BuyerId = Buyers.Id
		WHERE SellerId = @SellerId And (Date = @DateTime OR @DateTime IS NULL);
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetTotalBill]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetTotalBill]
	@BuyerId int,
	@TotalBill int = 0 output
AS
	begin

		Select @TotalBill = Isnull( Sum(Price), 0) from dbo.Cart where BuyerId = @BuyerId ;

	end
GO
/****** Object:  StoredProcedure [dbo].[spInsertIntoCart]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertIntoCart]
	@Id int output,
	@ProductId int,
	@BuyerId int
AS
	begin
		Insert into dbo.Cart (Name, Price, Quantity, Category, SellerId, BuyerId, ProductId)
		Select Name, Price, Quantity, Category, SellerId, @BuyerId, @ProductId from dbo.Products where Id = @ProductId ;

		Update dbo.Products
		Set Quantity = Quantity - 1
		where Id = @ProductId;

		Select @Id = SCOPE_IDENTITY();

	end
GO
/****** Object:  StoredProcedure [dbo].[spRemoveFromCart]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRemoveFromCart]
	@BuyerId int,
	@Id int
AS
	Begin
		set nocount on;

		Declare @ProductId int;
		Select @ProductId = ProductId from dbo.Cart where Id = @Id;

		Update dbo.Products
		Set Quantity = Quantity + 1
		where Id = @ProductId;

		delete from dbo.Cart where Id = @Id and BuyerId = @BuyerId;

	end
GO
/****** Object:  StoredProcedure [dbo].[spUnbanBuyer]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUnbanBuyer]
	@Id int
AS
	begin
		Update dbo.Buyers set AccountStatus = 1 where Id = @Id;
	End
GO
/****** Object:  StoredProcedure [dbo].[spUnbanSeller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUnbanSeller]
	@Id int
AS
	begin
		Update dbo.Sellers set AccountStatus = 1 where Id = @Id;
	End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateProduct]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateProduct]
	@Id int ,
	@Name nvarchar(50),
	@Price int,
	@Quantity int,
	@Category nvarchar(50)
AS
	Begin
		set nocount on;

		Update dbo.Products 
		Set Name = @Name,
			Price = @Price,
			Quantity = @Quantity,
			Category = @Category
		where Id = @Id;

	end
GO
/****** Object:  StoredProcedure [dbo].[spValidateSignIn_Buyer]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spValidateSignIn_Buyer]
	@Username nvarchar(50)

AS
begin
	set nocount on;
	
	Select IsNULL((Select Passsword from dbo.Buyers  where Username = @Username), 'null')
	
end
GO
/****** Object:  StoredProcedure [dbo].[spValidateSignIn_Seller]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spValidateSignIn_Seller]
	@Username nvarchar(50)
	
AS
Begin
	set nocount on;

	Select IsNull((Select Passsword from dbo.Sellers where Username = @Username), 'null')

end
GO
/****** Object:  StoredProcedure [dbo].[spValidateSignUp]    Script Date: 8/29/2023 5:12:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spValidateSignUp]
	@Username nvarchar(50)
	
AS
begin
	set nocount on;

	Select Username from dbo.Buyers Where Username = @Username
	Union
	Select Username from dbo.Sellers Where Username = @Username;

end
GO
USE [master]
GO
ALTER DATABASE [MarketDB] SET  READ_WRITE 
GO
