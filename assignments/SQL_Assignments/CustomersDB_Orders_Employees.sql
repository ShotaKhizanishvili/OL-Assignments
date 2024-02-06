create database CustomersDB;
go

use CustomersDB;
go

create table Customers(
	Id int identity(1,1) primary key,
	Name varchar(255),
	City varchar(255),
	Country varchar(255)
);

insert into Customers(Name, City, Country)
values
('Alice', 'London', 'UK'),
('Bob', 'New York', 'USA'),
('Eve', 'Paris', 'France'),
('Frank', 'Berlin', 'Germany'),
('Grace', 'Mumbai', 'India')
;

select Name from Customers
where City in ('London','Paris');

-- Orders SQL

create table Orders(
	Id int identity(1,1) primary key,
	CustomerId int,
	ProductName varchar(255),
	Quantity int,
	foreign key (CustomerId) references Customers(Id)
);

insert into Orders(CustomerId, ProductName, Quantity)
values
(1, 'Phone', 2),
(1, 'Tablet', 1),
(2, 'Laptop', 3),
(3, 'Smartwatch', 1),
(4, 'Headphones', 2),
(5, 'Speaker', 1)
;

select c.Name, count(o.Id) as TotalProducts
from Customers c
join Orders o on c.Id = o.CustomerId
group by c.Name

-- Employees SQL

create table Employees(
	Id int identity(1,1) primary key,
	Name varchar(100),
	Salary decimal(10,3),
	Departament varchar(50)
);

insert into Employees(Name, Salary, Departament)
values
('John', 1000,'Sales'),
('Jane', 1200,'Marketing'),
('Bill', 1500,'Engineering'),
('Rachel', 1200,'Marketing'),
('Steve', 1000,'Sales')
;

select Departament, AVG(Salary) as AverageSalary
from Employees
group by Departament
order by AverageSalary desc;