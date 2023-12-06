use master;
go
drop database if exists kolokvij6;
go
create database kolokvij6;
go
alter database kolokvij3 collate Croatian_CI_AS;
go
use kolokvij6;


--0.)
create table decko(
sifra int not null primary key identity(1,1),
prviputa datetime,
modelnaocala varchar(41),
nausnica int,
zena int not null
);

create table zena(
sifra int not null primary key identity(1,1),
novcica decimal(14,8) not null,
narukvica int not null,
dukserica varchar(30),
hlace varchar(32),
brat int not null
);

create table brat(
sifra int not null primary key identity(1,1),
nausnica int not null,
treciputa datetime not null,
narukvica int not null,
hlace varchar(31),
prijatelj int
);

create table prijatelj(
sifra int not null primary key identity(1,1),
haljina varchar(35),
prstena int not null,
introvertno bit,
stilfrizura varchar(36) not null
);

create table prijatelj_ostavljena(
sifra int not null primary key identity(1,1),
prijatelj int not null,
ostavljena int not null
);

create table ostavljena(
sifra int not null primary key identity(1,1),
prviputa datetime not null,
kratkamajica varchar(39) not null,
drugiputa datetime,
maraka decimal(14,10)
);

create table svekrva(
sifra int not null primary key identity(1,1),
hlace varchar(48) not null,
suknja varchar(42) not null,
ogrlica int not null,
treciputa datetime not null,
dukserica varchar(32) not null,
narukvica int not null,
punac int
);

create table punac(
sifra int not null primary key identity(1,1),
ekstrovertno bit not null,
suknja varchar(30) not null,
majica varchar(44) not null,
prviputa datetime not null
);


alter table decko add foreign key (zena) references zena (sifra);
alter table zena add foreign key (brat) references brat (sifra);
alter table brat add foreign key (prijatelj) references prijatelj (sifra);
alter table prijatelj_ostavljena add foreign key (prijatelj) references prijatelj (sifra);
alter table prijatelj_ostavljena add foreign key (ostavljena) references ostavljena (sifra);
alter table svekrva add foreign key (punac) references punac (sifra);