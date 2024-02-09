create database Inventory;
go

use Inventory;
go

create table Categories(
	Id int identity(1,1) primary key,
	Name nvarchar(100) not null,
	Description nvarchar(max) not null
);

create table Products(
	Id int identity(1,1) primary key,
	Name nvarchar(100) not null,
	Price decimal not null,
	Stock int not null,
	CategoryId int foreign key references Categories(Id)
);

create table Sales(
	Id int identity(1,1) primary key,
	ProductId int not null,
	Quantity int not null,
	SaleDate date not null,
	foreign key (ProductId) references Products(Id)
);