--Examen_3-ErnestoVargas

-- Crear la base de datos
CREATE DATABASE Examen_3_ErnestoVargas;
GO

-- Seleccionar la base de datos
USE Examen_3_ErnestoVargas;
GO

-- Crear la tabla encuesta
CREATE TABLE Encuesta (
    EncuestaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50) NOT NULL,
	FechaDeNacimiento DATETIME NOT NULL,
    CorreoElectronico VARCHAR(50) NOT NULL
);
GO

-- Crear la tabla partidos
CREATE TABLE PartidosPoliticos (
    PartidoPoliticoID INT PRIMARY KEY IDENTITY(1,1),
    PartidoPolitico VARCHAR(50) NOT NULL,
    EncuestaID INT FOREIGN KEY REFERENCES Encuesta(EncuestaID)
);
GO

-- STORE PROCEDURE

-- Stored Procedure para insertar un nuevo usuario encuestado
CREATE PROCEDURE AgregarUsuario
    @Nombre VARCHAR(50),
    @FechaDeNacimiento DATETIME,
    @CorreoElectronico VARCHAR(50)
AS
BEGIN
    INSERT INTO Encuesta(Nombre, FechaDeNacimiento, CorreoElectronico)
    VALUES (@Nombre, @FechaDeNacimiento, @CorreoElectronico);
END;

EXECUTE AgregarUsuario;

--SELECT *  FROM Encuesta
--INSERT INTO Encuesta(NombreTest, FechaDeNacimientoTest, CorreoElectronicoTest)
--EXEC AgregarUsuario 'ErnestoTest', '1990-01-01', 'Ernesto.Test@prueba.com';
