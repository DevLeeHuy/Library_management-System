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