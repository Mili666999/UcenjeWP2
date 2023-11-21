
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


alter table fotografije add foreign key (djelatnik) references djelatnici(id);
alter table dokumenti add foreign key (djelatnik) references djelatnici(id);


--Unos Djelatnika
insert into djelatnici (ime,prezime,kontakt,oib,iban) values
('Ana','Horvat','anahorvat@firma.hr','48807033063','HR48807033063'),
('Filip','Petrović','filippetrovic@firma.hr','75942713307','HR75942713307'),
('Ivan','Kovačić','ivankovacic@firma.hr','03430120955','HR03430120955'),
('Lara','Marković','laramarkovic@firma.hr','82712977132','HR82712977132'),
('Lea','Šimić','leasimic@firma.hr','97732515526','HR97732515526'),
('Luka','Novak','lukanovak@firma.hr','85299208009','HR85299208009'),
('Marko','Vuković','markovukovic@firma.hr','27954351006','HR27954351006'),
('Mateo','Tomić','mateotomic@firma.hr','09282353996','HR09282353996'),
('Mia','Jurić','miajuric@firma.hr','00486563817','HR00486563817'),
('Petra','Kovač','petrakovac@firma.hr','56031664672','HR56031664672');


--Unos Fotografija
DECLARE @ImagePath1 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\AnaHorvat.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('AnaHorvat', @ImagePath1, 1);

DECLARE @ImagePath2 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\FilipPetrovic.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('FilipPetrovic', @ImagePath2, 2);

DECLARE @ImagePath3 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\IvanKovacic.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('IvanKovacic', @ImagePath3, 3);

DECLARE @ImagePath4 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\LaraMarkovic.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('LaraMarkovic', @ImagePath4, 4);

DECLARE @ImagePath5 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\LeaSimic.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('LeaSimic', @ImagePath5, 5);

DECLARE @ImagePath6 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\LukaNovak.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('LukaNovak', @ImagePath6, 6);

DECLARE @ImagePath7 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\MarkoVukovic.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('MarkoVukovic', @ImagePath7, 7);

DECLARE @ImagePath8 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\MateoTomic.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('MateoTomic', @ImagePath8, 8);

DECLARE @ImagePath9 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\MiaJuric.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('MiaJuric', @ImagePath9, 9);

DECLARE @ImagePath10 VARCHAR(255) =
'file:///C:\Users\Mili\Documents\GitHub\UcenjeWP2\SQL\Zavrsni\FotkeIDokumentiDjelatnika\PetraKovac.jpg';
INSERT INTO fotografije (naziv, lokacija, djelatnik)
VALUES ('PetraKovac', @ImagePath10, 10);


--Unos Dokumenata
INSERT INTO dokumenti (naziv, lokacija, djelatnik) VALUES 
('AnaHorvatUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/AnaHorvatUgovor.pdf', 1),
('AnaHorvatZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/AnaHorvatZivotopis.pdf', 1),

('FilipPetrovicUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/FilipPetrovicUgovor.pdf', 2),
('FilipPetrovicZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/FilipPetrovicZivotopis.pdf', 2),

('IvanKovacicUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/IvanKovacicUgovor.pdf', 3),
('IvanKovacicZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/IvanKovacicZivotopis.pdf', 3),

('LaraMarkovicUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/LaraMarkovicUgovor.pdf', 4),
('LaraMarkovicZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/LaraMarkovicZivotopis.pdf', 4),

('LeaSimicUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/LeaSimicUgovor.pdf', 5),
('LeaSimicZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/LeaSimicZivotopis.pdf', 5),

('LukaNovakUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/LukaNovakUgovor.pdf', 6),
('LukaNovakZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/LukaNovakZivotopis.pdf', 6),

('MarkoVukovicUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/MarkoVukovicUgovor.pdf', 7),
('MarkoVukovicZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/MarkoVukovicZivotopis.pdf', 7),

('MateoTomicUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/MateoTomicUgovor.pdf', 8),
('MateoTomicZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/MateoTomicZivotopis.pdf', 8),

('MiaJuricUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/MiaJuricUgovor.pdf', 9),
('MiaJuricZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/MiaJuricZivotopis.pdf', 9),

('PetraKovacUgovor', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/PetraKovacUgovor.pdf', 10),
('PetraKovacZivotopis', 'file:///C:/Users/Mili/Documents/GitHub/UcenjeWP2/SQL/Zavrsni/FotkeIDokumentiDjelatnika/PetraKovacZivotopis.pdf', 10);

