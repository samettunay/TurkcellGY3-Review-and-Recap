create database imdbBase
go
use imdbBase
go
create table Oyuncular(
	Id int identity(1,1) not null,
	Ad nvarchar(50) not null,
	Soyad nvarchar(50) not null
)
go
Alter Table Oyuncular
Add Constraint PK_Oyuncular
Primary Key (Id)
go
create table Filmler (
	Id int identity(1,1) not null PRIMARY KEY,
	Ad nvarchar(50) not null
)
go
CREATE TABLE FilmlerOyuncular(
  FilmId int not null,
  OyuncuId int not null,
  Rol nvarchar(50) null
)
go
Alter Table FilmlerOyuncular
ADD Constraint PK_Oyuncular_Filmler
PRIMARY KEY (FilmId, OyuncuId)
go
alter table FilmlerOyuncular
add constraint FK_Oyuncu_Film
foreign key (FilmId)
references Filmler(Id)

ALTER TABLE FilmlerOyuncular
ADD Constraint FK_Film_Oyuncu
FOREIGN KEY (OyuncuId)
REFERENCES  Oyuncular(Id)