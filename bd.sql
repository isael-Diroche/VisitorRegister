use itla_visitors;

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
    foto_visita longblob,
    se_dirige varchar(50) NOT NULL
);

select * from visitas;
-- in D_nombre varchar(50), D_apellido varchar(50), D_carrera varchar(50), D_correo varchar(50), D_edificio varchar(50), D_hora_entrada varchar(50), D_hora_salida varchar(50), D_motivo_visita varchar(50), D_foto_visita longblob, D_se_dirige varchar(50)

DELIMITER //
create procedure SP_mostrar_visitas()
BEGIN
SELECT * from visitas;
END //
DELIMITER ;

 
 create table edificios (
	id int auto_increment primary key,
    descripcion varchar(50) not null
 );