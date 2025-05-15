--create database knjizara

use master;
go
drop database if exists knjizara;
go
create database knjizara;
go
use knjizara;

Create table clanovi(
sifra int,
clbroj int
);

create table vlasnici(
sifra int,
knjiga int
);

create table knjige(
sifra int,
naslov varchar(50),
pisac varchar(50),
vlasnik int,
clan int,
datumpos datetime,
datumvrac datetime
);

create table osobe(
sifra int,
ime varchar (50),
prezime varchar(50),
email varchar (50)
);