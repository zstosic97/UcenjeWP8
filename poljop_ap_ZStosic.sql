

use master;
go
drop database if exists poljoprivrednaaplikacija;
go
create database poljoprivrednaaplikacija collate Croatian_CI_AS;
go

use poljoprivrednaaplikacija

Create table prodavatelji(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
adresasjedista varchar(50) not null,
email varchar(50) not null,
);


create table kategorijeproizvoda(
sifra int not null primary key identity(1,1),
nazivkategorije varchar (20)
);

create table proizvodi(
sifra int not null primary key identity(1,1),
nazivproizvoda varchar (30) not null,
kolicina decimal (18,3) not null,
vlaga decimal (3,2), 
primjesa decimal (3,2), 
hektolitar decimal (3,2),
protein decimal (3,2),
ulje decimal (3,2),
lom decimal (3,2),
defekt decimal (3,2),
prodavatelj int not null references prodavatelji(sifra),
kategorija int not null references kategorijeproizvoda(sifra),
);


create table kupci(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
adresasjedista varchar(50) not null,
email varchar (50) not null,
);

create table narudzbe(
sifra int not null primary key identity(1,1),
datum datetime not null,
kupac int not null references kupci(sifra)
);

create table stavkanarudzbe (
sifra int not null primary key identity(1,1),
kolicina decimal (18,3) not null,
narudzba int not null references narudzbe(sifra),
proizvod int not null references proizvodi(sifra)
);

