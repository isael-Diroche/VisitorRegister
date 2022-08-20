use itla_visitors;

-- create table usuarios

create table visitas (
	id int auto_increment primary key,
    nombre varchar(50) NOT NULL,
    apellido varchar(50) NOT NULL,
    carrera varchar(50) NOT NULL,
    correo varchar(50),
    edificio varchar(50) NOT NULL,
    hora_entrada varchar(50) NOT NULL,
    hora_salida varchar(50) NOT NULL,
    motivo_visita text,
    foto_visita longblob NOT NULL,
    se_dirige varchar(50) NOT NULL
);

create table edificios (
	id int auto_increment primary key,
    descripcion varchar(50) not null
);

create table aulas (
	id int auto_increment primary key,
    id_edificio varchar(20), 
    descripcion varchar(50) not null
);

create table carrera (
	id int auto_increment primary key,
    descripcion varchar(100) not null
);

