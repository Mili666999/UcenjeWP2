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
lokacija 
);