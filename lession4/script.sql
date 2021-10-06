SELECT * FROM Products;

SELECT AVG(Price) AS 'Average Price' FROM Products

SELECT * FROM Products;

SELECT COUNT(ProductId) AS 'Count' FROM Products

SELECT MAX(Price) AS 'Max Price' FROM Products;

SELECT MIN(Price) AS 'Max Price' FROM Products;

SELECT SUM(Price) AS 'Total Amount' FROM Products;


SELECT ProductID, 
		CONCAT(ProductName, '-', Unit) AS Product_Unit,
        SupplierId,
        CategoryID,
        Price
FROM Products;

SELECT ProductID, 
		ProductName,
		LEN(ProductName) AS 'Length',
        SupplierId,
        CategoryID,
        Unit,
        Price
FROM Products;

SELECT REPLACE(Unit, 'box' , 'boxes') FROM Products;

SELECT SUBSTRING(ProductName, 1,5) FROM Products;

SELECT o.OrderId,
		p.ProductName,
        od.Quantity,
        p.Price,
        FORMAT(od.Quantity * p.Price, 'C') AS 'Amount'
FROM Orders o INNER JOIN OrderDetails od on o.OrderId = od.OrderId
INNER JOIN Products p ON od.ProductId = p.ProductId
WHERE o.OrderId = 10248;


DECLARE @number INT = NULL
SELECT @number + 1
SELECT ISNULL(@number, 0) + 1


SELECT GETDATE()


SELECT CategoryID, COUNT(CategoryID) AS 'Count' FROM Products
GROUP BY CategoryID
HAVING COUNT(CategoryID) >=10

SELECT o.OrderId,
		COUNT(od.ProductId) AS 'Count Product',
        SUM(od.Quantity * p.Price) AS 'Total Amount'
FROM Orders o INNER JOIN OrderDetails od on o.OrderId = od.OrderId
INNER JOIN Products p on od.ProductID = p.ProductId
GROUP BY o.OrderId
ORDER BY SUM(od.Quantity * p.Price) ASC