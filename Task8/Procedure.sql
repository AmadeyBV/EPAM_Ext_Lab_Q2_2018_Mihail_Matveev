--13.1
CREATE PROCEDURE LargestOrders (@year INT) AS 
SELECT
	empl.FirstName, empl.LastName, ord.OrderID,
	(od.UnitPrice * (1 - od.Discount) * od.Quantity) AS 'Max Price'
FROM
	Northwind.Employees empl
	INNER JOIN Northwind.Orders ord
	ON empl.EmployeeID = ord.EmployeeID
	INNER JOIN Northwind.[Order Details] od
	ON od.OrderID = ord.OrderID
WHERE YEAR(ord.OrderDate) = @year
	AND ((UnitPrice * (1 - Discount)) * Quantity) = 
	(SELECT
		MAX((UnitPrice * (1 - Discount)) * Quantity)
	FROM Northwind.Orders ord1
		INNER JOIN Northwind.[Order Details] od
		ON od.OrderID = ord1.OrderID
	WHERE YEAR(ord1.OrderDate) = @year)
GO

--13.2
CREATE PROCEDURE OverdueOrders (@day INT = 35) AS 
SELECT
	OrderID, OrderDate, ShippedDate,
	DATEDIFF(d, OrderDate, ShippedDate) AS 'ShippedDelay'
FROM Northwind.Orders
WHERE DATEDIFF(d, OrderDate, 'ShippedDate') > @day
	OR 'ShippedDate' IS NULL
GO

--13.3

--13.4
CREATE FUNCTION IsBoss (@employeeID INT) RETURNS BIT AS 
BEGIN
	IF EXISTS (SELECT EmployeeID
		FROM Northwind.Employees
		WHERE ReportsTo = @employeeID)
		RETURN 1
	RETURN 0
END
GO