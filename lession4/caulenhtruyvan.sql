--1. Thông tin khách hàng (customer). Có bao nhiêu khách hàng?

SELECT * FROM dbo.Customers
SELECT COUNT(cus.CustomerID) FROM dbo.Customers AS cus

--2. Thông tin loại hàng. Có bao nhiêu loại hàng (category), mỗi loại hàng có bao nhiêu sản phẩm (product)
SELECT * FROM dbo.Categories

SELECT COUNT(cat.CategoryID) FROM dbo.Categories AS cat

SELECT	cat.CategoryID, cat.CategoryName, COUNT(pro.ProductID) AS Product
FROM dbo.Categories AS cat INNER JOIN dbo.Products AS pro ON cat.CategoryID = pro.CategoryID
GROUP BY cat.CategoryID, cat.CategoryName

--3. Thông tin nhân viên. Có bao nhiêu nhân viên (Employee)? Nâng cao: bạn có thể truy vấn được tên người quản lý (là người được nhân viên báo cáo) không?
SELECT * FROM dbo.Employees
SELECT COUNT(emp.EmployeeID) FROM dbo.Employees AS emp

--4. Thông tin các nhà cung cấp (supplier). Có bao nhiêu nhà cung cấp.
SELECT * FROM dbo.Suppliers
SELECT COUNT(sup.SupplierID) FROM dbo.Suppliers AS sup

--5. Đơn hàng (order) được lưu trữ gồm những năm nào?
SELECT DISTINCT YEAR(ord.OrderDate)
FROM dbo.Orders AS ord

--6. Khách hàng thường sống ở những quốc gia nào? Những quốc gia nào có nhà cung cấp?
SELECT DISTINCT cus.Country, sup.Country 
FROM dbo.Customers AS cus INNER JOIN dbo.Suppliers AS sup ON sup.Country = cus.Country

--7. Liệt kê các khách hàng không có số Fax?
SELECT CompanyName,ContactName
FROM dbo.Customers
WHERE Fax  is NULL
-- bonus số lượng các khách hàng không có số Fax
SELECT COUNT(CustomerID)
FROM dbo.Customers
WHERE Fax  is NULL

--8. Liệt kê các khách hàng sống ở Pháp. Liệt kê các khách hang sống ở Pháp và Tây Ban Nha
SELECT *
FROM dbo.Customers
WHERE Country  IN ('France','Spain')
ORDER BY Country


--9. Liệt kê các khách hàng không sống ở Châu Mỹ


--10. Liệt kê các hóa đơn của năm 1997
SELECT *
FROM dbo.Orders 
WHERE YEAR(OrderDate) = 1997

--11. Liệt kê 3 hóa đơn mới nhất
SELECT TOP 3 *
FROM dbo.Orders
ORDER BY OrderDate DESC

--12. Liệt kê các hóa đơn có cước phí >100$. Tìm hóa đơn có cước phí cao nhất, thấp nhất.
SELECT MIN(Freight) AS 'freight min', MAX(Freight) AS 'freight max'
FROM dbo.Orders
WHERE Freight > 100 

--13. Đếm số hóa đơn bán được của năm 1996, 1997 và cả 2 năm 1996, 1997
SELECT COUNT(OrderID)
FROM dbo.Orders
WHERE YEAR(OrderDate) = 1996 OR YEAR(OrderDate) = 1997

--14. Tính đơn giá bình quân của tất cả sản phẩm, của sản phẩm thuộc loại hải sản (mã loại là 8)
SELECT AVG(UnitPrice) AS 'avg all'
FROM dbo.Products

SELECT AVG(UnitPrice) AS 'avg seefood'
FROM dbo.Products
WHERE CategoryID = 8

--15. Liệt kê 3 sản phẩm có đơn giá mắc nhất.
SELECT TOP 3 *
FROM dbo.Products
ORDER BY UnitPrice DESC


/*16. Liệt kê các sản phẩm có tên bắt đầu bằng ký tự N? Bắt đầu bằng ký tự N
hoặc A? Liệt kê các sản phẩm có tên không bắt đầu bằng N? Không bắt đầu bằng N và A? */
SELECT *
FROM dbo.Products
WHERE ProductName LIKE 'N%'

SELECT *
FROM dbo.Products
WHERE ProductName LIKE 'N%' OR  ProductName LIKE 'A%'

SELECT *
FROM dbo.Products
WHERE ProductName LIKE '[N,A]%'

SELECT *
FROM dbo.Products
WHERE ProductName NOT LIKE  'N%' AND  ProductName NOT LIKE 'A%'

SELECT *
FROM dbo.Products
WHERE ProductName LIKE '[^N,A]%'

--17. Liệt kê các sản phẩm có đơn giá từ 100 đến 200
SELECT *
FROM dbo.Products
WHERE UnitPrice BETWEEN 100 AND 200

/*18. Liệt kê các sản phẩm có số lượng tồn kho (units in stock) thấp hơn định mức
tồn kho tối thiểu (reorder level)*/
SELECT *
FROM dbo.Products
WHERE UnitsInStock < ReorderLevel

--19. Tính số sản phẩm được cung cấp bởi nhà cung cấp Tokyo Traders (có mã là 4)
SELECT COUNT(Prod.ProductID)
FROM dbo.Products Prod JOIN dbo.Suppliers Sup ON Sup.SupplierID = Prod.SupplierID
WHERE sup.CompanyName = 'Tokyo Traders'

