-- 1. Crear la tabla Alumno
CREATE TABLE [dbo].[Alumno] (
    [rut]       VARCHAR (50) NOT NULL,
    [nombre]    VARCHAR (50) NOT NULL,
    [nota1]     FLOAT (53)   NOT NULL,
    [nota2]     FLOAT (53)   NOT NULL,
    [nota3]     FLOAT (53)   NOT NULL,
    [promFinal] FLOAT (53)   NOT NULL,
    PRIMARY KEY CLUSTERED ([rut] ASC)
);

-- 2. Insertar los datos con comas
INSERT INTO [dbo].[Alumno] (rut, nombre, nota1, nota2, nota3, promFinal) 
VALUES ('1234-5', 'Elseb Ollín', 6,3, 5,2, 5,9, 5,8);

INSERT INTO [dbo].[Alumno] (rut, nombre, nota1, nota2, nota3, promFinal) 
VALUES ('3456-7', 'Zacarías Flores', 4,5, 4,4, 3,2, 4,0);

INSERT INTO [dbo].[Alumno] (rut, nombre, nota1, nota2, nota3, promFinal) 
VALUES ('5678-9', 'Elusaza Patos', 5,3, 6,8, 3,2, 5,1);

INSERT INTO [dbo].[Alumno] (rut, nombre, nota1, nota2, nota3, promFinal) 
VALUES ('9123-1', 'Yonoro Varía', 6,7, 6,9, 6,4, 6,6);