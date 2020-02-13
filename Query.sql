INSERT INTO Tabla (Id,Mensaje)
values (0,'Hola');

select *
from Objetoes;

drop table Books;

create table Books(
	BookId int primary key not null identity,
	Title nchar(100)
);