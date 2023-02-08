use Adventureworks
go
--task1
select FirstName,LastName
from Person.Person
where Title is not null
--task2
select FirstName,LastName
from Person.Person
where FirstName like '%a%' and LastName like '%a%'
--task3
select cr.CurrencyCode SCR,Name,c.CurrencyCode SC
from Sales.CountryRegionCurrency cr , Sales.Currency c
--task4
select * into Humanresources.Hr_dept from HumanResources.Department
--task5
create table task5
(sno int identity(1,1),
fname varchar(20),lname varchar(20),DOB date,phone varchar(10))

declare @var int
set @var =1
while @var<=15
begin
insert task5
values('v','r','01/09/2001','9092219410')
set @var = @var+1
end
select * from task5
--task6
select BusinessEntityID,AddressTypeID
from HumanResources.Department dept
join Person.BusinessEntityAddress BA
on dept.DepartmentID = BA.BusinessEntityID
--task7
select distinct GroupName 
from HumanResources.Department

--task8
select sum(Product.ListPrice) listprice,pch.StandardCost,SUM(pch.StandardCost) sofSC,documentnode
from Production.ProductCostHistory pch 
join Production.Product
on pch.StandardCost =  Product.StandardCost
join Production.Document pd
on pd.DocumentNode = Production.ProductDocument
group by pch.StandardCost ,pd.DocumentNode
--task9
select DATEDIFF(YEAR ,StartDate,EndDate)
from HumanResources.EmployeeDepartmentHistory


--task11
select MAX(TaxRate)
from Sales.SalesTaxRate
--task12
Select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--task13
create view Name_age
as
Select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--task14
select count(*) [No_of_rows] from HumanResources.Department, HumanResources.Employee

--task15
select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory pay join
HumanResources.Department dep
on pay.BusinessEntityID = dep.DepartmentID
group by Name

--task16
select FirstName,MiddleName,Title,AddressTypeID,pb.BusinessEntityID
from Person.Person pp
left join Person.BusinessEntityAddress pb
on pp.BusinessEntityID=pb.BusinessEntityID
where Title is not null


--task 17
select ProductID,PL.LocationID,Shelf
from Production.ProductInventory PI
join Production.Location PL
on PI.LocationID=PL.LocationID
where ProductID>=300 and ProductID<=350 and PL.LocationID=50 or Shelf='E'

--task 18
select Shelf,Name,pp.LocationID
from Production.ProductInventory pp
join Production.Location pl
on pp.LocationID=pl.LocationID

--task 19
select AddressID,AddressLine1,AddressLine2,SP.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince SP
join Person.Address PA
on SP.StateProvinceID=PA.StateProvinceID

--task20
select  CurrencyCode,Sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader so
join Sales.SalesTerritory st
on st.TerritoryID=so.TerritoryID
join Sales.CountryRegionCurrency cr
on cr.CountryRegionCode=st.CountryRegionCode
group by CurrencyCode

--select TaxAmt,SubTotal
--from Sales.SalesOrderHeader


