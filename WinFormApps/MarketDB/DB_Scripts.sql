SELECT [ProductID],[ProductName],Products.[SupplierID],Suppliers.CompanyName As 'Supplier Name',Products.[CategoryID],CategoryName,[QuantityPerUnit],[UnitPrice],[Discontinued] FROM Products LEFT JOIN Suppliers ON Products.SupplierID  = Suppliers.SupplierID LEFT JOIN Categories ON Products.CategoryID = Categories.CategoryID

SELECT CategoryID,CategoryName FROM Categories

SELECT SupplierID,CompanyName From Suppliers 













