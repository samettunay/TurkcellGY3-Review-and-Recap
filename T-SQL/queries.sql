select * from Categories

insert into Categories(CategoryName, Description)
values('Tatlýlar', 'Her türlü Türk tatlýlarý')

Update Categories SET Description='Türk mutfaðýnda bulunan eþsiz tatlý lezzetler'
WHERE CategoryId = 9

Select * from Products
--DELETE FROM [TabloAdi] WHERE [Koþul]
DELETE FROM Categories WHERE CategoryId=9

DELETE FROM Products WHERE ProductID=1

SELECT 
  ProductName, UnitPrice, UnitsInStock
FROM Products
WHERE UnitPrice < 50
ORDER BY UnitPrice ASC, UnitsInStock DESC


SELECT 
  ProductName, UnitPrice, UnitsInStock
FROM Products
WHERE UnitPrice <> 100


SELECT
   CustomerID, 	CompanyName, Address, City, Country
FROM Customers
WHERE Country LIKE 'A%'

SELECT
   CustomerID, 	CompanyName, Address, City, Country
FROM Customers
WHERE Country LIKE '%A'

SELECT 
   FirstName, LastName, Title,  YEAR(GETDATE())- YEAR(BirthDate) as Age
FROM Employees
Order by Age

SELECT LOWER('BÜYÜK')
SELECT UPPER('küçük')

SELECT 
   FirstName + ' ' + UPPER( LastName) FullName, Title,  YEAR(GETDATE())- YEAR(BirthDate) as Age
FROM Employees
Order by Age, FullName

SELECT 
 OrderID, CustomerID, Freight, OrderDate
FROM Orders
WHERE OrderDate BETWEEN '1996-07-04' AND '1996-08-01'

SELECT 
 *
FROM Customers 
WHERE CompanyName BETWEEN 'A' AND 'E'


SELECT 
   CustomerID, CompanyName, ContactName, Address, City, Country
FROM Customers
WHERE Country = 'Germany' OR Country='Italy' OR Country = 'UK'
Order by Country

SELECT 
   CustomerID, CompanyName, ContactName, Address, City, Country
FROM Customers
WHERE Country IN ('Germany','Spain','UK','Italy','France')
Order by Country


SELECT 
  CompanyName, Country, Fax
FROM Customers
WHERE Fax is NULL


SELECT 
  DISTINCT Country
FROM Customers

--Aggregate Functions:,

-- 10248 ÝD'LÝ sipariþte ne kadar ödendi?
SELECT 
   SUM(UnitPrice * (1-Discount) * Quantity) 
FROM [Order Details] WHERE OrderID = 10248


-- UK'da kaç adet müþterim var?
select count(*) as TotalCustomerCount from Customers where country = 'UK'

--MAX, MIN, AVG, 
--Group By:
--SELECT Renk, Count(Pantolon) FROM Gardrop
--GROUP BY Renk
--
-- Hangi ülkede kaç adet müþterim var?
SELECT
    Country, Count(CustomerID) TotalCustomers
FROM Customers
GROUP BY Country
ORDER BY TotalCustomers desc

-- 5'den fazla müþterim olan ülkeler
SELECT
    Country, Count(CustomerID) TotalCustomers
FROM Customers
GROUP BY Country
HAVING Count(CustomerID) >= 5
ORDER BY TotalCustomers desc

SELECT 
   OrderId,  '$'+CAST(ROUND(SUM(UnitPrice * (1-Discount) * Quantity), 0) AS nvarchar(5))
FROM [Order Details]
GROUP BY OrderID

--1000 dolardan fazla tutan sipariþler toplamý ne kadar?
SELECT
    SUM(UnitPrice * (1-Discount) * Quantity)
FROM [Order Details]
HAVING SUM(UnitPrice * (1-Discount) * Quantity)>1000

-- Hangi Sipariþte ne kadar ödendi?
SELECT TOP 5 OrderId,  ROUND(SUM(UnitPrice * (1-Discount) * Quantity), 2) as Total
FROM [Order Details]
GROUP BY OrderID
ORDER BY Total Desc 