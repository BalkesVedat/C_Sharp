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


CREATE PROC Sp_EnsertProduct
(
@ProductName nvarchar(40),
@SupplierID int,
@CategoryID int,
@QuantityPerUnit nvarchar(20),
@UnitPrice money,
@Discontinued bit
)
AS
Insert Into Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,
Discontinued) VALUES (@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@Discontinued)
----------------------------------------------
--EXEC Sp_InsertProduct 'dfdsf',1,1,'sdsadadasda',33.45,0

EXEC Sp_EnsertProduct  @ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@Discontinued








