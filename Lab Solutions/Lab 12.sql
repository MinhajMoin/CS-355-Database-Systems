--Question 1
create view Question1 as
select P.ProductName,S.CompanyName,C.CategoryName,P.UnitPrice,count(O.OrderID) as 'No. of Orders',sum(OD.Quantity) as 'Total Quantity' from Products P,Orders O,Categories C,Suppliers S, [Order Details] OD
where P.CategoryID = C.CategoryID and S.SupplierID = P.SupplierID and O.OrderID = OD.OrderID and OD.ProductID = P.ProductID
group by ProductName,CompanyName,CategoryName,P.UnitPrice

--Question 2
create view Question2 as 
select E.FirstName+' '+E.LastName as 'Employee Name', M.FirstName+' '+M.LastName as 'Manager Name',Datediff(year,E.BirthDate,getdate()) as 'Age',Datediff(year,E.HireDate,getdate()) as 'No. of Years in Company',count (O.OrderID) as 'No. of Orders Processed' from Employees E, Employees M , Orders O
where E.ReportsTo = M.EmployeeID and O.EmployeeID = E.EmployeeID
group by E.FirstName,E.LastName,M.FirstName,M.LastName,E.BirthDate,E.HireDate

--Question 3
alter procedure OfferDiscount
	@ProductID int,
	@DiscountPercent float
as
Begin
Update Products
set UnitPrice = UnitPrice - UnitPrice*(@DiscountPercent/100) where ProductID = @ProductID

Update [Order Details]
set Discount = (@DiscountPercent/100) from Products,Orders,[Order Details]
where Products.ProductID = @ProductID and Orders.OrderDate > getdate() and Orders.OrderID = [Order Details].OrderID
End

--Question 4
create procedure DeleteEmployee
	@EmployeeID int
as Begin
Update Employees
set ReportsTo = E1.ReportsTo from Employees E1 where E1.EmployeeID = @EmployeeID and E1.ReportsTo!=NULL and 
(select Count(Orders.OrderID) from Orders,Employees where Employees.EmployeeID = Orders.EmployeeID and Employees.EmployeeID = @EmployeeID group by Employees.EmployeeID) < 1

Delete Employees
where ReportsTo!=NULL and EmployeeID = @EmployeeID and 
(select Count(Orders.OrderID) from Orders,Employees where Employees.EmployeeID = Orders.EmployeeID and Employees.EmployeeID = @EmployeeID group by Employees.EmployeeID) < 1

Delete EmployeeTerritories
where EmployeeID = @EmployeeID and (select E.Reportsto from Employees E where E.EmployeeID = @EmployeeID)!=NULL and
(select Count(Orders.OrderID) from Orders,Employees where Employees.EmployeeID = Orders.EmployeeID and Employees.EmployeeID = @EmployeeID group by Employees.EmployeeID) < 1
End

-- Question 5
create procedure CopyOrder
	@OrderID int,
	@CustomerID varchar(20)
as Begin
Insert into Orders (OrderID,CustomerID,EmployeeID,Freight,ShipAddress,ShipCountry,ShipAddress,ShipCity,ShipVia,ShipRegion,ShipPostalCode,ShipName,RequiredDate,OrderDate)
select distinct O.OrderID,C.CustomerID,O.EmployeeID,O.Freight,O.ShipAddress,O.ShipCountry,O.ShipAddress,O.ShipCity,O.ShipVia,O.ShipRegion,O.ShipPostalCode,O.ShipName,O.RequiredDate,getdate() as OrderDate from Orders O,Customers C,Shippers S
where O.CustomerID = C.CustomerID and C.CustomerID = @CustomerID and O.OrderID = @OrderID
End
