create table unpaid_books
(
	id int primary key identity(1,1),
	Book_name varchar(50),
	Author_name varchar(50),
	Genre varchar(50),
	Release_year int,
	Price float
)