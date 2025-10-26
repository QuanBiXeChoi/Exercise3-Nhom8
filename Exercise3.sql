create database Exercise3
go

use Exercise3
go

create table Users  (
	UserId int identity(1,1) primary key,
	Username nvarchar(50) unique not null,
	Passwd nvarchar(64) not null,
	Email nvarchar(50),
	FullName nvarchar(100),
	Birthday Date
)