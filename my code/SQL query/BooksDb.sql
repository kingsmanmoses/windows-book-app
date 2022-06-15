
use Customers
use Books

create table Customer
(
   FirstName varchar(50),
   LastName varchar(50),
   Age int
)

insert into Customer ( FirstName, LastName, Age) values ('Joey', 'John', 18)
insert into Customer ( FirstName, LastName, Age) values ('Micheal', 'Smith', 19)
insert into Customer ( FirstName, LastName, Age) values ('Tom', 'McTominnay', 25)	
insert into Customer ( FirstName, LastName, Age) values ('Paul', 'Pogba', 21)	

select * from Customer


create table freeBooks
(
	BookName varchar(50),
	AuthorName varchar(50),
	Genre varchar(50),
	ReleaseYear int,
)

ALTER TABLE freeBooks
ADD test varchar(50);

insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Great Africa', 'John Doe', 'Romance', '2008')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Rising Darkness', 'Jonathan Jac', 'Fantasy, Horror', '1981')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('IT', 'Stephen King', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')
insert into freeBooks (BookName, AuthorName, Genre, ReleaseYear) values ('Alita: Battle Angel', 'Sivo Macintosh', 'Fantasy, Action', '2003')

select * from freeBooks
