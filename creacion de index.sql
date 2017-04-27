create database indices;
use indices;

create table usuarios(
id int,
nombre varchar(50),
apellidos varchar(70)
);

-- metodo 1
alter table usuarios add index idx_apellidos(apellidos);

drop index idx_apellidos on usuarios;
-- metodo 2
create index idx_apellidos on usuarios(apellidos);


show create table usuarios;