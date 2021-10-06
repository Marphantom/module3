CREATE VIEW [dbo].[v_Category_Product_Supplier]
AS
SELECT c.CategoryID,
	c.CategoryName,
	p.ProductID,
	p.ProductName,
	p.UnitPrice,
	s.SupplierID,
	s.CompanyName,
	s.ContactName,
	s.Country
FROM Categories c INNER JOIN Products p ON c.CategoryID = p.CategoryID
				INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
-------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[sp_GetProductByCategoryAndSupplier]
(
	@CategoryId		INT,
	@SupplierId		INT = 0
)
AS
BEGIN
	IF(@SupplierId <> 0)
	BEGIN
		SELECT * 
		FROM v_Category_Product_Supplier
		WHERE CategoryID = @CategoryId AND SupplierID = @SupplierId
	END
	ELSE
	BEGIN
		SELECT * 
		FROM v_Category_Product_Supplier
		WHERE CategoryID = @CategoryId
	END
END
-----------------------------------------------------------
CREATE FUNCTION [dbo].[fn_GetProductByCategoryAndSupplier]
(
	@CategoryId		INT,
	@SupplierId		INT = 0
)
RETURNS @data TABLE(CategoryId INT, CategoryName NVARCHAR(15), ProductId INT, ProductName NVARCHAR(40),
					UnitPrice MONEY, SupplierId INT, CompanyName NVARCHAR(40), ContactName NVARCHAR(30),
					Country NVARCHAR(15))
AS
BEGIN	 
		INSERT INTO @data 
				SELECT * 
					FROM v_Category_Product_Supplier
					WHERE CategoryId = @CategoryId AND CategoryId = @SupplierId
		RETURN
END
----------------------------------------------------------------
CREATE FUNCTION [dbo].[fn_CalcAmount]
(
	@Quantity	INT,
	@Price	MONEY,
	@Discount	REAL
)
RETURNS MONEY
AS
BEGIN
	RETURN (@Quantity * @Price)*(1-@Discount)
END
------------------------------------------------
CREATE INDEX [idx_Employee_Country] ON [dbo].[Employees]
(
	[Country]
)