--USE Northwind
--GO
----------------------------------------------------------------------------------
--CREATE PROC Sp_GetProductList
--AS
--SELECT [ProductID],[ProductName],Products.[SupplierID],Suppliers.CompanyName As 'Supplier Name',Products.[CategoryID],CategoryName,[QuantityPerUnit],[UnitPrice],[Discontinued] FROM Products LEFT JOIN Suppliers ON Products.SupplierID  = Suppliers.SupplierID LEFT JOIN Categories ON Products.CategoryID = Categories.CategoryID
----------------------------------------------------------------------------------
--EXEC Sp_GetProductList
----------------------------------------------------------------------------------
--CREATE PROC Sp_GetCategoryList
--AS
--SELECT CategoryID,CategoryName FROM Categories
----------------------------------------------------------------------------------
--CREATE PROC Sp_GetSupplierList
--AS
--SELECT SupplierID,CompanyName From Suppliers 
----------------------------------------------------------------------------------


--CREATE PROC Sp_InsertProduct
--(
--@ProductName nvarchar(40),
--@SupplierID int,
--@CategoryID int,
--@QuantityPerUnit nvarchar(20),
--@UnitPrice money,
--@Discontinued bit
--)
--AS
--Insert Into Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,
--Discontinued) VALUES (@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@Discontinued)
----------------------------------------------
--EXEC Sp_InsertProduct 'dfdsf',1,1,'sdsadadasda',33.45,0

--EXEC Sp_InsertProduct  @ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@Discontinued
-----------------------------------------------------------------
--CREATE PROC Sp_DeleteProduct
--(@ProductID int)
--AS
--DELETE FROM Products WHERE ProductID = @ProductID
----------------------------------------------------
--EXEC Sp_DeleteProduct 5

--DROP PROC Sp_DeleteProduct

----------------------------------------------------
--CREATE PROC Sp_UpdateProduct
--(
--@ProductID int,
--@ProductName nvarchar(40),
--@SupplierID int,
--@CategoryID int,
--@QuantityPerUnit nvarchar(20),
--@UnitPrice money,
--@Discontinued bit
--)
--AS
--BEGIN
--	UPDATE Products 
--	SET
--	ProductName=@ProductName,
--	SupplierID=@SupplierID,
--	CategoryID=@CategoryID,
--	QuantityPerUnit=@QuantityPerUnit,
--	UnitPrice=@UnitPrice,
--	Discontinued=@Discontinued
--	WHERE ProductID = @ProductID
--END
------------------------------------------------------------------
--CREATE PROC Sp_GetCategoryImage
--(@CategoryID int)
--AS
--SELECT Picture FROM Categories WHERE CategoryID = @CategoryID
----------------------------------------------------------------
--EXEC Sp_GetCategoryImage 3






