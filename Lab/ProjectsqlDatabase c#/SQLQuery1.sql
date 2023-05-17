create database mobileshop

use mobileshop

create table newMobile(
	mid int NOT NULL IDENTITY(1,1) primary key,
	cname varchar(250) not null,
	mname varchar(250) not null,
	ram varchar(250) not null,
	internal varchar(250) not null,
	expandable varchar(250) not null,
	display varchar(250) not null,
	rear varchar(250) not null,
	front varchar(250) not null,
	finger varchar(250) not null,
	sim varchar(250) not null,
	network varchar(250) not null,
	price bigint not null
);


select * From newMobile



create table customerPurchase(
	cid int not null Identity(1,1) primary key,
	cname varchar(250) not null ,
	gender varchar(50) not null,
	contact bigint not null,
	email varchar(250) not null,
	caddress varchar(350) not null,
	company varchar(250) not null,
	model varchar(250) not null,
	imei varchar(250) not null
);

select * from customerPurchase

cname, gender, contact, email, caddress, company, model, imei