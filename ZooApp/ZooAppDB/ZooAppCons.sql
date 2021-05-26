create database zooApp

create table animal
(Nombre varchar (40),
colorOjos varchar(40),
colorPiel varchar (40),
ubiPsVist varchar (40),
tipoAnimal varchar (40),
maneraRepro varchar (40),
img image 
)

alter table animal
add  img image;

create 
use zooApp

select * from animal

insert into animal values ('Ballena ','Azuel ','Azul/Negro','Antillas ','Mamifero ','N/A')
A