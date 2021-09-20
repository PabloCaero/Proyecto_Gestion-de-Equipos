Create Database Equipos_Nuevos
go
Use Equipos_Nuevos
go

Create Table Tecnicos(
IDTecnico INT NOT NULL PRIMARY KEY,
Nombres VARCHAR(150) NOT NULL
)
go

Create Table Oficinas(
IDOficina INT NOT NULL PRIMARY KEY,
Nombres VARCHAR(150) NOT NULL
)
go

Create Table Licencias(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Nombre VARCHAR(150) NOT NULL,
PrimerGrupo CHAR(5) NOT NULL UNIQUE,
SegundoGrupo CHAR(5) NOT NULL UNIQUE, 
TercerGrupo CHAR(5) NOT NULL UNIQUE, 
CuartoGrupo CHAR(5) NOT NULL UNIQUE, 
QuintoGrupo CHAR(5) NOT NULL UNIQUE
)
go

Create Table Equipos(
Ticket INT NOT NULL PRIMARY KEY,
TecnicoAsignado INT NOT NULL FOREIGN KEY REFERENCES Tecnicos(IDTecnico),
Nombre VARCHAR(150) NOT NULL UNIQUE,
Tipo VARCHAR(50) NOT NULL CHECK(Tipo = 'PC DE ESCRITORIO' OR Tipo = 'NOTEBOOK'),


)
