create database MindboxDB;
go 
use MindboxDB
create table Products
(
	ProductId int primary key,
	ProductName nvarchar(100)
);
create table Categories
(
	CategoryId int primary key,
	CategoryName nvarchar(100)
)
go
create table ProductsCategories
(
	ProductId int not null foreign key references Products(ProductId),
	CategoryId int foreign key references Categories(CategoryId)
);
go

insert into Products (ProductId,ProductName)
values
(1,'Яблоки'),
(2,'Помидоры'),
(3,'Вода')

insert into Categories (CategoryId,CategoryName)
values
(1,'Фрукты'),
(2,'Овощи')
go

insert into ProductsCategories 
values 
(1,1),
(2,2),
(3,null)

go

select p.ProductName,c.CategoryName from ProductsCategories as pc
full join Products as p on p.ProductId = pc.ProductId
full join Categories as c on c.CategoryId = pc.CategoryId