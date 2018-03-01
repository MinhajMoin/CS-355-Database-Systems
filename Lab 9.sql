-- Lab 9
-- Minhaj Ahmed Moin
-- hm02896

--Question 1
select Orders.OrderID,OrderDate,ProductName from Orders,[Order Details],Products,Categories
where Orders.OrderID=[Order Details].OrderID and Products.ProductID=[Order Details].ProductID and Products.CategoryID=Categories.CategoryID and CategoryName='Seafood'

--Question 2
select count(*) from Suppliers

--Question 3
select count(*) from Orders
where Datepart(year,Orders.OrderDate) = 1997

--Question 4
select count(*) from Orders,Customers
where Orders.CustomerID = Customers.CustomerID and Customers.Country = 'UK'

--Question 5
select count(*) from Orders , [Order Details]
where Orders.OrderID = 11070 and [Order Details].OrderID = Orders.OrderID

--Question 6
select count(Suppliers.SupplierID) from Suppliers,Products
where Suppliers.SupplierID = Products.SupplierID
group by Suppliers.SupplierID

--Question 7
select Products.SupplierID,count(Products.ProductID),min(Categories.CategoryName) as NoofProducts,min(Suppliers.ContactName),avg(Products.UnitPrice),sum(Products.UnitsInStock) from Products,Categories,Suppliers
where Suppliers.SupplierID=Products.ProductID and Categories.CategoryID=Products.CategoryID
group by Products.CategoryID,Products.SupplierID

--Question 8
select Suppliers.SupplierID,count(Products.ProductID) as No_of_Products from Products,Suppliers
where Products.SupplierID = Suppliers.SupplierID
group by Suppliers.SupplierID
having count(Products.ProductID) > 4

--Question 9
select Region.RegionID,count(Employees.Region) from Region,Employees
group by Region.RegionID

--Question 10
select sum(UnitPrice*Quantity-Discount) from [Order Details] 
where OrderID = 11070 
group by OrderID

--Question 11
select [Order Details].OrderID,sum([Order Details].UnitPrice*[Order Details].Quantity) from [Order Details]
group by OrderID

--Question 12
select top 3 e.EmployeeID, count(*) as CC
from Employees e, Orders o
where e.EmployeeID=o.EmployeeID
group by e.EmployeeID
order by CC desc

--Question 13
select top 1 c.Country, count(*) as CC
from Customers c
group by c.Country
order by CC desc

--Question 14
select c.CategoryName, count(*) as NoOfProducts
from Categories c, Products p
where c.CategoryID=p.CategoryID
group by c.CategoryName

--Question 15
select c.CompanyName, s.CompanyName, count(*)
from Customers c, Orders o, [Order Details] od, Products p, Suppliers s
where c.CustomerID=o.CustomerID and o.OrderID=od.OrderID and p.ProductID=od.ProductID and p.SupplierID=s.SupplierID
group by c.CompanyName, s.CompanyName

--Question 16
select e.EmployeeID, DATEPART(year, o.OrderDate), count(*)
from Orders o, Employees e
where o.EmployeeID=e.EmployeeID
group by e.EmployeeID, DATEPART(year, o.OrderDate)

--Question 17
select s.CompanyName, CategoryName, count(*) as NoOfProducts
from Suppliers s, Categories c, Products p
where c.CategoryID=p.CategoryID and p.SupplierID=s.SupplierID
group by s.CompanyName, c.CategoryName


--Question 18
select o.OrderID, o.OrderDate, ProductName, CategoryName
from Orders o, Products p, [Order Details] od, Categories c
where p.ProductID=od.ProductID and od.OrderID=o.OrderID and c.CategoryID=p.CategoryID and CategoryName like 'Seafood'


--Question 19
select top 3 e.EmployeeID, count(*) as CC
from Employees e, Orders o
where e.EmployeeID=o.EmployeeID
group by e.EmployeeID
order by CC desc

--Question 20
select s.CompanyName, CategoryName, count(*) as NoOfProducts
from Suppliers s, Categories c, Products p
where c.CategoryID=p.CategoryID and p.SupplierID=s.SupplierID
group by s.CompanyName, c.CategoryName














