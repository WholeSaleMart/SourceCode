create database WSM_GIS;
go

use WSM_GIS;
go

create table Country (
	ID int identity(1,1) primary key,
	Name varchar(100) not null,
	Code char(3) not null
)
go

create table State (
	ID int identity(1,1) primary key,
	Name varchar(100) not null,
	Code varchar(3),
	CountryID int not null foreign key references Country(ID)
)
go

create table City (
	ID int identity(1,1) primary key,
	Name varchar(100) not null,
	StateID int not null foreign key references State(ID)
)
go

create view vCity
with schemabinding
as
select 
	cn.Name as Country,
	cn.Code as CountryCode,
	st.Name as State,
	st.Code as StateCode,
	ct.Name as City,
	ct.ID as CityID
from
	dbo.City ct
	inner join dbo.State st on st.ID = ct.StateID
	inner join dbo.Country cn on cn.ID = st.CountryID

go