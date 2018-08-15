--Minhaj Ahmed Moin - hm02896
-- DB Lab 8

--Question 1
select TitleOfCourtesy +' '+FirstName+' '+LastName as Fullname from Employees where DATEDIFF(year,HireDate, GETDATE())>10

--Question 2
select Orders.OrderID,Customers.CustomerID,Customers.ContactName,Customers.Country from Orders,Customers where Customers.CustomerID=Orders.CustomerID and  DATEPART(month,OrderDate)=10 and (Country like 'USA' or Country like 'UK' or Country like 'Germany')

--Question 3
select * from Employees
order by Employees.BirthDate

--Question 4
select top 3* from Employees
order by Employees.BirthDate

--Question 5
select top 1 * from Employees order by Employees.HireDate

--Question 6
select e.EmployeeID,e.TitleOfCourtesy+' '+e.FirstName+' '+e.LastName as Fullname, Datediff(year,m.BirthDate,e.Birthdate) as "Age Difference" from Employees e , Employees m where e.ReportsTo = m.EmployeeID

--Question 7
select Orders.OrderID,Orders.CustomerID,Employees.TitleOfCourtesy+' '+ Employees.FirstName + ' ' + Employees.LastName as Name,DATEDIFF(day,Orders.OrderDate,Orders.ShippedDate) as Delay from Employees,Orders where Employees.EmployeeID=Orders.EmployeeID and DATEDIFF(day,Orders.OrderDate,Orders.ShippedDate)>0

--Question 8
select Orders.OrderID,DATEDIFF(day,Orders.OrderDate,Orders.RequiredDate) as Date_to_Process_Order from Orders
