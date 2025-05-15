﻿--create database edunovawp8;
use master;
go
drop database if exists edunovawp8;
go
create database edunovawp8;
go

--drop database edunovawp8;

use edunovawp8;

create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2) null, --null se ne mora pisati
datumpokretanja datetime, --i ovo je null iako ne pise
aktivan bit not null default 0 
);

create table grupe(
sifra int not null primary key identity(1,1),
naziv varchar(20),
smjer int not null,
predavac varchar(50)
);

--drop table polaznici;

create table polaznici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(100)
);


create table clanovi(
grupa int not null,
polaznik int not null
);