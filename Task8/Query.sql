/*1.1 ������� � ������� Orders ������, ������� ���� ���������� ����� 6 ��� 1998 ���� (������� ShippedDate) 
������������ � ������� ���������� � ShipVia >= 2. ������ �������� ���� ������ ���� ������ ��� ����� 
������������ ����������, �������� ����������� ������ �WritINg International Transact-SQL Statements� � Books ONlINe 
������ �AccessINg AND ChangINg Relational Data Overview�. ���� ����� ������������ ����� ��� ���� �������. 
������ ������ ����������� ������ ������� OrderID, ShippedDate � ShipVia. 
�������� ������ ���� �� ������ ������ � NULL-�� � ������� ShippedDate.*/
SELECT OrderID, ShippedDate, ShipVia 
FROM NORthwINd.Orders
WHERE ShippedDate >= CONVERT(datetime, '19980506')
	AND ShipVia >= 2

/*1.2 �������� ������, ������� ������� ������ �������������� ������ �� ������� Orders. 
� ����������� ������� ����������� ��� ������� ShippedDate ������ �������� NULL ������ 
�Not Shipped� � ������������ ��������� ������� CAS�. ������ ������ ����������� ������ ������� OrderID � ShippedDate.*/
SELECT OrderID,
	CASE 
		WHEN ShippedDate IS NULL Then 'Not Shipped'
	END ShippedDate
FROM NORthwINd.Orders
WHERE ShippedDate IS NULL

/*1.3 ������� � ������� Orders ������, ������� ���� ���������� ����� 6 ��� 1998 ���� (ShippedDate) 
�� ������� ��� ���� ��� ������� ��� �� ����������. � ������� ������ ������������� ������ ������� 
OrderID (������������� � Order Number) � ShippedDate (������������� � Shipped Date). 
� ����������� ������� ����������� ��� ������� ShippedDate ������ �������� NULL ������ �Not Shipped�, 
��� ��������� �������� ����������� ���� � ������� �� ���������.*/
SELECT OrderID AS 'Order Number',
	CASE
		WHEN ShippedDate IS NULL Then 'Not Shipped'
		ELSE CONVERT(nchar, ShippedDate)
	END 'Shipped Date'
FROM NORthwINd.Orders
WHERE ShippedDate > CONVERT(datetime, '19980506')
	OR ShippedDate IS NULL

/*2.1 ������� �� ������� Customers ���� ����������, ����������� � USA � Canada. 
������ ������� � ������ ������� ��������� IN. ����������� ������� � ������ ������������ � ��������� ������ � ����������� �������. 
����������� ���������� ������� �� ����� ���������� � �� ����� ����������.*/
SELECT ContactName, Country
FROM NORthwINd.Customers
WHERE Country IN ('USA', 'Canada')
ORDER BY ContactName, Country

/*2.2 ������� �� ������� Customers ���� ����������, �� ����������� � USA � Canada. ������ ������� � ������� ��������� IN. 
����������� ������� � ������ ������������ � ��������� ������ � ����������� �������. ����������� ���������� ������� �� ����� ����������.*/
SELECT ContactName, Country
FROM NORthwINd.Customers
WHERE Country NOT IN ('USA', 'Canada')
ORDER BY ContactName

/*2.3 ������� �� ������� Customers ��� ������, � ������� ��������� ���������. ������ ������ ���� ��������� ������ ���� ��� � ������ 
������������ �� ��������. �� ������������ ����������� GROUP BY. ����������� ������ ���� ������� � ����������� �������.*/
SELECT DISTINCT Country
FROM NORthwINd.Customers
ORDER BY Country DESC

/*3.1 ������� ��� ������ (OrderID) �� ������� Order Details (������ �� ������ �����������), ��� ����������� �������� � ����������� 
�� 3 �� 10 ������������ � ��� ������� Quantity � ������� Order Details. ������������ �������� BETWEEN. 
������ ������ ����������� ������ ������� OrderID.*/
SELECT DISTINCT OrderID
FROM NORthwINd.[Order Details]
WHERE Quantity BETWEEN 3 AND 10

/*3.2 ������� ���� ���������� �� ������� Customers, � ������� �������� ������ ���������� �� ����� �� ��������� b � g. 
������������ �������� BETWEEN. ���������, ��� � ���������� ������� �������� Germany. ������ ������ ����������� ������ 
������� CustomerID � Country � ������������ �� Country.*/
SELECT CustomerID, Country
FROM NORthwINd.Customers
WHERE Country BETWEEN 'B%' AND 'Gg%'
ORDER BY Country

/*3.3 ������� ���� ���������� �� ������� Customers, � ������� �������� ������ ���������� �� ����� �� ��������� b � g, 
�� ��������� �������� BETWEEN. � ������� ����� �Execution Plan� ���������� ����� ������ ���������������� 
3.2 ��� 3.3 � ��� ����� ���� ������ � ������ ���������� ���������� Execution Plan-a ��� ���� ���� ��������, 
���������� ���������� Execution Plan ���� ������ � ������ � ���� ����������� � �� �� ����������� ���� ����� 
�� ������ � �� ������ ��������� ���� ��������� ���������. ������ ������ ����������� ������ ������� CustomerID � Country � ������������ �� Country.
3.2: 0% - 71% - 29%
3.3: 0% - 71% - 29%
�����: ������� �� ������*/
SELECT CustomerID, Country
FROM NORthwINd.Customers
WHERE SUBSTRING(Country, 1, 1) >= 'B' AND SUBSTRING(Country, 1, 1) <= 'G'
ORDER BY Country

/*4.1 � ������� Products ����� ��� �������� (������� ProductName), ��� ����������� ��������� 'chocolade'. 
��������, ��� � ��������� 'chocolade' ����� ���� �������� ���� ����� 'c' � �������� - ����� ��� ��������, 
������� ������������� ����� �������. ���������: ���������� ������� ������ ����������� 2 ������.*/
SELECT ProductName
FROM NORthwINd.Products
WHERE ProductName LIKE '%cho[c,k]olade%'

/*5.1 ����� ����� ����� ���� ������� �� ������� Order Details � ������ ���������� ����������� ������� � ������ �� ���. 
��������� ��������� �� ����� � ��������� � ����� 1 ��� ���� ������ money.  ������ (������� Discount) ���������� ������� 
�� ��������� ��� ������� ������. ��� ����������� �������������� ���� �� ��������� ������� ���� ������� ������ �� ��������� � ������� UnitPrice ����. 
����������� ������� ������ ���� ���� ������ � ����� �������� � ��������� ������� 'Totals'.*/
SELECT ROUND(SUM(UnitPrice * (1 - Discount / 100)), 2) AS Totals
FROM NORthwINd.[Order Details]

/*5.2 �� ������� Orders ����� ���������� �������, ������� ��� �� ���� ���������� (�.�. � ������� ShippedDate ��� �������� ���� ��������). 
������������ ��� ���� ������� ������ �������� COUNT. �� ������������ ����������� WHERE � GROUP.*/
SELECT COUNT(*) - COUNT(ShippedDate)
FROM NORthwINd.Orders

/*5.3 �� ������� Orders ����� ���������� ��������� ����������� (CustomerID), ��������� ������. 
������������ ������� COUNT � �� ������������ ����������� WHERE � GROUP.*/
SELECT COUNT(DISTINCT CustomerID)
FROM NORthwINd.Orders

/*6.1 �� ������� Orders ����� ���������� ������� � ������������ �� �����. � ����������� ������� ���� ����������� 
��� ������� c ���������� Year � Total. �������� ����������� ������, ������� ��������� ���������� ���� �������.*/
SELECT YEAR(OrderDate) AS 'Year', COUNT('Year') AS Total
FROM NORthwINd.Orders
GROUP BY YEAR(OrderDate)

/*6.2 �� ������� Orders ����� ���������� �������, c�������� ������ ���������. ����� ��� ���������� �������� � ��� ����� ������ � ������� Orders, 
��� � ������� EmployeeID ������ �������� ��� ������� ��������. � ����������� ������� ���� ����������� ������� � ������ �������� 
(������ ������������� ��� ���������� ������������� LAStName & FirstName. ��� ������ LAStName & FirstName ������ ���� �������� ��������� �������� 
� ������� ��������� �������. ����� �������� ������ ������ ������������ ����������� �� EmployeeID.) � ��������� ������� �Seller� � ������� 
c ����������� ������� ����������� � ��������� 'Amount'. ���������� ������� ������ ���� ����������� �� �������� ���������� �������.*/
SELECT (SELECT (LAStName + ' ' + FirstName)
	FROM NORthwINd.Employees
	WHERE Employees.EmployeeID = Orders.EmployeeID) AS 'Seller',
	COUNT('Seller') AS 'Amount'
FROM NORthwINd.Orders
GROUP BY EmployeeID
ORDER BY 'Amount' DESC

/*6.3 �� ������� Orders ����� ���������� �������, c�������� ������ ��������� � ��� ������� ����������. 
���������� ���������� ��� ������ ��� ������� ��������� � 1998 ����. � ����������� ������� ���� ����������� ������� � ������ �������� 
(�������� ������� �Seller�), ������� � ������ ���������� (�������� ������� �Customer�)  � ������� c ����������� ������� ����������� � ��������� 'Amount'. 
� ������� ���������� ������������ ����������� �������� ����� T-SQL ��� ������ � ���������� GROUP (���� �� �������� ������� �������� 
������ �ALL� � ����������� �������). ����������� ������ ���� ������� �� ID �������� � ����������. ���������� ������� ������ ���� ����������� �� ��������, 
���������� � �� �������� ���������� ������. � ����������� ������ ���� ������� ���������� �� ��������. �.�. � ������������� ������ ������ �������������� 
������������� � ���������� � �������� �������� ��� ������� ���������� ��������� �������:
Seller		Customer	Amount
ALL 		ALL			<����� ����� ������>
<���>		ALL			<����� ������ ��� ������� ��������>
ALL			<���>		<����� ������ ��� ������� ����������>
<���>		<���>		<����� ������ ������� �������� ��� �������� ����������>*/
SELECT
	CASE
		WHEN CompanyName IS NULL Then 'All'
		ELSE CompanyName
	END AS 'Seller',
	CASE
		WHEN FirstName IS NULL Then 'All'
		ELSE FirstName
	END AS Customer,
	COUNT(OrderID) AS 'Amount' 
FROM NORthwINd.Orders
	INNER JOIN NORthwINd.Customers 
	ON Orders.CustomerID = Customers.CustomerID
	INNER JOIN NORthwINd.Employees 
	ON Orders.EmployeeID = Employees.EmployeeID
WHERE YEAR(OrderDate) = YEAR(CONVERT(datetime, '19980101'))
GROUP BY CUBE (CompanyName,FirstName)
ORDER BY 'Seller', 'Customer', 'Amount' DESC

/*6.4 ����� ����������� � ���������, ������� ����� � ����� ������. ���� � ������ ����� ������ ���� ��� ��������� ��������� ��� ������ ���� ��� 
��������� �����������, �� ���������� � ����� ���������� � ��������� �� ������ �������� � �������������� �����. �� ������������ ����������� JOIN. 
� ����������� ������� ���������� ������� ��������� ��������� ��� ����������� �������: �Person�, �Type� (����� ���� �������� ������ �Customer� ��� 
�Seller� � ��������� �� ���� ������), �City�. ������������� ���������� ������� �� ������� �City� � �� �Person�.*/
SELECT
	CASE
		WHEN NOT Employees.FirstName IS NULL Then Employees.FirstName + ' ' + Employees.LAStName
	END AS 'Person',
	Customers.ContactName AS 'Seller', 
	Employees.City
FROM NORthwINd.NORthwINd.Customers, 
	NORthwINd.NORthwINd.Employees
WHERE Employees.City = Customers.City

/*6.5 ����� ���� �����������, ������� ����� � ����� ������. � ������� ������������ ���������� ������� Customers c ����� - ��������������. 
��������� ������� CustomerID � City. ������ �� ������ ����������� ����������� ������. ��� �������� �������� ������, ������� ����������� ������, 
������� ����������� ����� ������ ���� � ������� Customers. ��� �������� ��������� ������������ �������.*/
SELECT
	firstCustomers.CustomerID, 
	firstCustomers.City 
FROM
	NORthwINd.Customers firstCustomers
	JOIN NORthwINd.Customers secondCustomers 
ON 
	firstCustomers.City = secondCustomers.City
GROUP BY firstCustomers.CustomerID, firstCustomers.City
HAVING COUNT(firstCustomers.City) > 1

/*6.6 �� ������� Employees ����� ��� ������� �������� ��� ������������, �.�. ���� �� ������ �������. ��������� ������� � ������� 'User Name' (LAStName)
 � 'Boss'. � �������� ������ ���� ��������� ����� �� ������� LAStName. ��������� �� ��� �������� � ���� �������?*/
SELECT employees2.LAStName AS 'User Name', 
	employees1.LAStName AS 'Boss' 
FROM
	NORthwINd.Employees employees1
	RIGHT JOIN NORthwINd.Employees employees2 
	ON employees1.EmployeeID = employees2.RepORtsTo

/*7.1 ���������� ���������, ������� ����������� ������ 'Western' (������� Region). ���������� ������� ������ ����������� ��� ����: 
'LAStName' �������� � �������� ������������� ���������� ('TerritORyDESCription' �� ������� TerritORies). ������ ������ ������������ JOIN 
� ����������� FROM. ��� ����������� ������ ����� ��������� Employees � TerritORies ���� ������������ ����������� ��������� ��� ���� NORthwINd.*/
SELECT 
	FirstName, TerritORyDESCription
FROM 
	NORthwINd.Employees
	INNER JOIN NORthwINd.EmployeeTerritORies 
ON Employees.EmployeeID = EmployeeTerritORies.EmployeeID
	INNER JOIN NORthwINd.TerritORies 
ON EmployeeTerritORies.TerritORyID = TerritORies.TerritORyID
	INNER JOIN NORthwINd.Region 
ON TerritORies.RegionID = Region.RegionID
WHERE RegionDESCription = 'Western'

/*8.1 ��������� � ����������� ������� ����� ���� ���������� �� ������� Customers � ��������� ���������� �� ������� �� ������� Orders. 
������� �� ��������, ��� � ��������� ���������� ��� �������, �� ��� ����� ������ ���� �������� � ����������� �������. 
����������� ���������� ������� �� ����������� ���������� �������.*/
SELECT cust.CustomerID,
	COUNT(ORd.OrderID) AS 'Orders'
FROM NORthwINd.Customers cust
	LEFT JOIN NORthwINd.Orders ORd ON cust.CustomerID = ORd.CustomerID
GROUP BY cust.CustomerID
ORDER BY Orders

/*9.1 ��������� ���� ����������� ������� CompanyName � ������� Suppliers, � ������� ��� ���� �� ������ �������� �� ������ 
(UnitsInStock � ������� Products ����� 0). ������������ ��������� SELECT ��� ����� ������� � �������������� ��������� IN. 
����� �� ������������ ������ ��������� IN �������� '=' ?*/
SELECT CompanyName
FROM NORthwINd.Suppliers
	INNER JOIN NORthwINd.Products
	ON Products.ProductID = Suppliers.SupplierID
WHERE Products.SupplierID IN
	(SELECT SupplierID
	FROM NORthwINd.Suppliers
	WHERE UnitsInStock = 0)

/*10.1 ��������� ���� ���������, ������� ����� ����� 150 �������. ������������ ��������� ��������������� SELECT.*/
SELECT EmployeeID
FROM NORthwINd.Employees
WHERE EmployeeID IN
	(SELECT EmployeeID
	FROM NORthwINd.Orders
	GROUP BY EmployeeID
		HAVING COUNT(OrderID) > 150)

/*11.1 ��������� ���� ���������� (������� Customers), ������� �� ����� �� ������ ������ (��������� �� ������� Orders). 
������������ ��������������� SELECT � �������� EXISTS.*/
SELECT CompanyName
FROM NORthwINd.Customers
WHERE NOT EXISTS
	(SELECT CustomerID
	FROM NORthwINd.Orders
	WHERE Customers.CustomerID = Orders.CustomerID)

/*12.1 ��� ������������ ����������� ��������� Employees ��������� �� ������� Employees ������ ������ ��� ���� ��������, 
� ������� ���������� ������� Employees (������� LAStName ) �� ���� �������. ���������� ������ ������ ���� ������������ �� �����������.*/
SELECT DISTINCT SUBSTRING(LAStName, 1, 1) AS 'Char'
FROM NORthwINd.Employees
ORDER BY 'Char'

/*13.1 �������� ���������, ������� ���������� ����� ������� ����� ��� ������� �� ��������� �� ������������ ���. 
� ����������� �� ����� ���� ��������� ������� ������ ��������, ������ ���� ������ ���� � ����� �������. 
� ����������� ������� ������ ���� �������� ��������� �������: ������� � ������ � �������� �������� (FirstName � LAStName � ������: Nancy Davolio), 
����� ������ � ��� ���������. � ������� ���� ��������� Discount ��� ������� �������. ��������� ���������� ���, �� ������� ���� ������� �����, 
� ���������� ������������ �������. ���������� ������� ������ ���� ����������� �� �������� ����� ������. ��������� ������ ���� ����������� � �������������� 
��������� SELECT � ��� ������������� ��������. �������� ������� �������������� GreatestOrders. ���������� ������������������ ������������� ���� ��������. 
����� ������ ������������ ������� �������� � ������� Query.sql ���� �������� ��������� �������������� ����������� ������ ��� ������������ 
������������ ������ ��������� GreatestOrders. ����������� ������ ������ �������� � ������� ��� ��������� � ������������ ������ �������� ���� 
��� ������������� �������� ��� ���� ��� ������� �� ������������ ��������� ��� � ����������� ��������� �������: ��� ��������, ����� ������, ����� ������. 
����������� ������ �� ������ ��������� ������, ���������� � ���������, - �� ������ ��������� ������ ��, ��� ������� � ����������� �� ����.
��� ������� �� ������ �������� ������ ���� �������� � ����� Query.sql � ��. ��������� ���� � ������� ����������� � �����������.*/
EXEC Northwind.dbo.LargestOrders 1996
EXEC Northwind.dbo.LargestOrders 1997
EXEC Northwind.dbo.LargestOrders 1998

/*13.2 �������� ���������, ������� ���������� ������ � ������� Orders, �������� ���������� ����� �������� � ���� (������� ����� OrderDate � ShippedDate).  
� ����������� ������ ���� ���������� ������, ���� ������� ��������� ���������� �������� ��� ��� �������������� ������. �������� �� ��������� 
��� ������������� ����� 35 ����. �������� ��������� ShippedOrdersDiff. ��������� ������ ����������� ��������� �������: OrderID, OrderDate, ShippedDate, 
ShippedDelay (�������� � ���� ����� ShippedDate � OrderDate), SpecifiedDelay (���������� � ��������� ��������).  ���������� ������������������ 
������������� ���� ���������.*/
EXEC Northwind.dbo.OverdueOrders
EXEC Northwind.dbo.OverdueOrders 10
EXEC Northwind.dbo.OverdueOrders 15

/*13.3 �������� ���������, ������� ����������� ���� ����������� ��������� ��������, ��� ����������������, ��� � ����������� ��� �����������. 
� �������� �������� ��������� ������� ������������ EmployeeID. ���������� ����������� ����� ����������� � ��������� �� � ������ 
(������������ �������� PRINT) �������� �������� ����������. ��������, ��� �������� ���� ����� ����������� ����� ������ ���� ��������. 
�������� ��������� SubordinationInfo. � �������� ��������� ��� ������� ���� ������ ���� ������������ ������, ����������� � Books Online 
� ��������������� Microsoft ��� ������� ��������� ���� �����. ������������������ ������������� ���������.*/


/*13.4 �������� �������, ������� ����������, ���� �� � �������� �����������. ���������� ��� ������ BIT. � �������� �������� ��������� ������� 
������������ EmployeeID. �������� ������� IsBoss. ������������������ ������������� ������� ��� ���� ��������� �� ������� Employees.*/
SELECT EmployeeID,
	CASE
		WHEN Northwind.dbo.IsBoss (EmployeeID) = 1 THEN 'True'
		ELSE 'False'
	END AS 'Is Boss'
FROM Northwind.Employees