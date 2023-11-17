use master;
go
drop database if exists djelatnici;
go
create database djelatnici;
go
use djelatnici;


create table fotografije(
id int not null primary key identity(1,1),
naziv varchar(100),
lokacija varchar(255),
djelatnik int not null
);

create table dokumenti(
id int not null primary key identity(1,1),
naziv varchar(100),
lokacija varchar(255),
djelatnik int not null
);

create table djelatnici(
id int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
kontakt varchar(150) not null,
oib char(11) not null,
iban varchar(50) not null
);