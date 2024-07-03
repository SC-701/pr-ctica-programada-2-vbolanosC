CREATE DATABASE PracticaPrograma2BD;
GO

USE PracticaPrograma2BD;
GO


/**************PROCEDIMIENTOS*****************/

--LISTAR TAREAS
CREATE PROCEDURE dbo.ListarTareas
AS
BEGIN
    SELECT
        Id,
        Nombre,
        Descripcion,
        FechaInicio,
        FechaFinal,
        Asignado,
        Estado,
        Creador
    FROM 
        dbo.Tarea;
END
GO

--LISTAR TAREAS POR CREADOR
CREATE PROCEDURE dbo.ListarTareasPorCreador
    @Creador UNIQUEIDENTIFIER
AS
BEGIN
    SELECT
        Id,
        Nombre,
        Descripcion,
        FechaInicio,
        FechaFinal,
        Asignado,
        Estado,
        Creador
    FROM 
        dbo.Tarea
    WHERE
        Creador = @Creador;
END
GO

--CREAR TAREA
CREATE PROCEDURE dbo.CrearTarea
    @Nombre VARCHAR(MAX),
    @Descripcion VARCHAR(MAX),
    @FechaInicio DATE,
    @FechaFinal DATE,
    @Asignado UNIQUEIDENTIFIER,
    @Estado UNIQUEIDENTIFIER,
    @Creador UNIQUEIDENTIFIER
AS
BEGIN
    DECLARE @Id UNIQUEIDENTIFIER;
    SET @Id = NEWID();

    INSERT INTO dbo.Tarea (
        Id, Nombre, Descripcion, FechaInicio, FechaFinal, Asignado, Estado, Creador
    )
    VALUES (
        @Id, @Nombre, @Descripcion, @FechaInicio, @FechaFinal, @Asignado, @Estado, @Creador
    );

    SELECT @Id AS Id;
END
GO

--ACTUALIZAR TAREA
CREATE PROCEDURE dbo.ActualizarTarea
    @Id UNIQUEIDENTIFIER,
    @Nombre VARCHAR(MAX),
    @Descripcion VARCHAR(MAX),
    @FechaInicio DATE,
    @FechaFinal DATE,
    @Asignado UNIQUEIDENTIFIER,
    @Estado UNIQUEIDENTIFIER,
    @Creador UNIQUEIDENTIFIER
AS
BEGIN
    UPDATE dbo.Tarea
    SET 
        Nombre = @Nombre,
        Descripcion = @Descripcion,
        FechaInicio = @FechaInicio,
        FechaFinal = @FechaFinal,
        Asignado = @Asignado,
        Estado = @Estado,
        Creador = @Creador
    WHERE
        Id = @Id;
END
GO


--ELIMINAR TAREA
CREATE PROCEDURE dbo.EliminarTarea
    @Id UNIQUEIDENTIFIER
AS
BEGIN
    DELETE FROM dbo.Tarea
    WHERE Id = @Id;
END
GO
