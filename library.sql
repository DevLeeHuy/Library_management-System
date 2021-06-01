use Library_management;

create table users(
	id INT NOT NULL,
	type int foreign key references userType(id) on delete set null on update cascade,
	lname nvarchar(100) NOT NULL,
	fname nvarchar(100) NOT NULL,
	BirthDate datetime, 
	gender nvarchar(100)  ,
	phone nvarchar(100),
	address nvarchar(100),
	img image,
	PRIMARY KEY (id)
	);



create table userType(
	id int identity(1,1) primary key,
	typeName varchar(20) not null
);
create table account(
	id int primary key foreign key references users(id) on delete cascade on update cascade,
	username varchar(50) not null,
	password varchar(50) not null
);
select * from users
CREATE TABLE book (
	id int primary key,
	title nvarchar(50) not null,
	description text,
	author nvarchar(50),
	pubDate datetime,
	publisher nvarchar(50),
	categoryId int foreign key references bookCategory(id) on delete set null on update cascade,
	quantity int not null,
	price float
)
create table bookCategory(
	id int identity(1,1) primary key,
	catName nvarchar(50) not null,
)
drop table bookCategory

create table returnBook(
	id int primary key,
	uid int foreign key references users(id) on delete cascade on update cascade,
	bid int foreign key references book(id) on delete cascade on update cascade,
	isExpired bit,
	isDamaged bit,
	isLost bit,
	pending bit
)
create table fineMoney(
	id int primary key foreign key references users(id) on delete cascade on update cascade,
	fine float
)

create view  Br_Rt as
(select id,uid,bid from borrow) UNION (select id,uid,bid from returnBook)

create function top3Book()
returns table as
return (
	select bid, count(uid) quantity
	from Br_Rt
	group by bid
)

select * from top3Book()
order by quantity DESC
