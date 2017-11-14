-- Question 1
insert into Products (ProductName,CategoryID,UnitPrice) values ('Mountain Dew',1,10)

-- Question 2
insert into Products (ProductName,CategoryID,UnitPrice) values ('Mountain Dew',
(select CategoryID from Categories where CategoryName like 'Beverages')
,10)

--Question 3
update Products
set UnitPrice+=0.25*(UnitPrice)
where Products.CategoryID = 
(select CategoryID from Categories where CategoryName like 'Beverages')

--Question 4
update [Order Details]
set Discount+=0.2*(UnitPrice)
from Orders,[Order Details]
where Orders.OrderID = [Order Details].OrderID and DatePart(month,Orders.RequiredDate)-DATEPART(month,getdate()) >0

--Question 5
insert into Categories (CategoryName) values ('Drinks')

--Question 6
Insert into Products (ProductName,CategoryID,Discontinued,QuantityPerUnit,ReorderLevel,SupplierID,UnitsInStock,UnitPrice,UnitsOnOrder)
select Products.ProductName,Products.CategoryID,Products.Discontinued,Products.QuantityPerUnit,Products.ReorderLevel,Products.SupplierID,Products.UnitsInStock,Products.UnitPrice,Products.UnitsOnOrder from Products,Categories where Products.CategoryID = Categories.CategoryID and Categories.CategoryName like 'Beverages'

--Question 7
Insert into Products (ProductName,CategoryID,Discontinued,QuantityPerUnit,ReorderLevel,SupplierID,UnitsInStock,UnitPrice,UnitsOnOrder)
select Products.ProductName,Products.CategoryID,Products.Discontinued,Products.QuantityPerUnit,Products.ReorderLevel,Products.SupplierID,Products.UnitsInStock,Products.UnitPrice,Products.UnitsOnOrder from Products,Categories where Products.CategoryID = Categories.CategoryID and Categories.CategoryName like 'Beverages'

delete Categories
select Products.ProductName,Products.CategoryID,Products.Discontinued,Products.QuantityPerUnit,Products.ReorderLevel,Products.SupplierID,Products.UnitsInStock,Products.UnitPrice,Products.UnitsOnOrder from Products,Categories where Products.CategoryID = Categories.CategoryID and Categories.CategoryName like 'Beverages'

--Question 8
Delete EmployeeTerritories
select * from EmployeeTerritories et,Employees e where e.EmployeeID = et.EmployeeID and e.FirstName like 'Nancy' and e.LastName like 'Davolio'

insert into EmployeeTerritories
select n.EmployeeID,et.TerritoryID from Employees e,Employees n,EmployeeTerritories et where e.FirstName like 'Robert' and e.LastName like 'King'

--Question 10
Delete Products
where Products.UnitPrice>1000

--Question 9


--Question 11
Delete Products
from Products,Categories
where UnitPrice<5 and Categories.CategoryID = Products.CategoryID and Categories.CategoryName like 'Seafood'

--Question 12
Delete Categories
from (select c.CategoryID,count(p.ProductID) as 'Number of Products' from Products p,Categories c where c.CategoryID=p.CategoryID group by c.CategoryID) as KL,Categories
where Categories.CategoryID=KL.CategoryID and KL.[Number of Products]<1

select Categories.CategoryID,count(Products.ProductID) from Categories,Products where Products.CategoryID = Categories.CategoryID
group by Categories.CategoryID

--Question 13
Delete [Order Details]
from [Order Details],Orders
where [Order Details].OrderID = Orders.OrderID and Orders.CustomerID like 'ALFKI'
Delete Orders
where Orders.CustomerID like 'ALFKI'

--Question 14
Delete [Order Details]
from [Order Details],Orders
where [Order Details].OrderID = Orders.OrderID and datepart(month,getdate()) - datepart(month,OrderDate) = 1
Delete Orders
where datepart(month,getdate()) - datepart(month,OrderDate) = 1
