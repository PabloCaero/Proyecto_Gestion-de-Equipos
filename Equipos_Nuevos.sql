Create Database Equipos_Nuevos
go

Use Equipos_Nuevos
go

Create Table Tecnicos(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Legajo INT NOT NULL,
Apellidos VARCHAR(150) NOT NULL,
Nombres VARCHAR(150) NOT NULL
)
go

Create Table Oficinas(
ID INT NOT NULL PRIMARY KEY,
Nombre VARCHAR(150) NOT NULL
)
go

Create Table Cuentas(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Descripcion VARCHAR(150) NOT NULL,
)
go

Create Table LicenciasWindows(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Descripcion VARCHAR(150) NOT NULL,
Numero VARCHAR(25) NOT NULL UNIQUE
)
go

Create Table LicenciasCartonOffice(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
IDCuenta INT NULL FOREIGN KEY REFERENCES Cuentas(ID),
Descripcion VARCHAR(150) NOT NULL,
Numero VARCHAR(25) NOT NULL UNIQUE
)
go

Create Table LicenciasOffice(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
IDCartonOffice INT NOT NULL FOREIGN KEY REFERENCES LicenciasCartonOffice(ID),
FechaCarga DATE NOT NULL CHECK(FechaCarga <= GetDate()),
Numero VARCHAR(25) NOT NULL UNIQUE
)
go


Create Table CPUs(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Descripcion VARCHAR(150) NOT NULL,
)
go

Create Table GPUs(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Descripcion VARCHAR(150) NOT NULL,
)
go

Create Table RAMs(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Descripcion VARCHAR(150) NOT NULL,
)
go

Create Table DISCOs(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Descripcion VARCHAR(150) NOT NULL,
)
go

Create Table Equipos(
ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
Ticket INT NOT NULL,
IDTecnicoAsignado INT NOT NULL FOREIGN KEY REFERENCES Tecnicos(ID),
IDOficina INT NOT NULL FOREIGN KEY REFERENCES Oficinas(ID),
Nombre VARCHAR(150) NOT NULL UNIQUE,
Tipo VARCHAR(50) NOT NULL CHECK(Tipo = 'PC DE ESCRITORIO' OR Tipo = 'NOTEBOOK'),
IDCPU INT NOT NULL FOREIGN KEY REFERENCES CPUs(ID),
IDGPU INT NOT NULL FOREIGN KEY REFERENCES GPUs(ID),
IDRAM INT NOT NULL FOREIGN KEY REFERENCES RAMs(ID),
IDDISCO1 INT NOT NULL FOREIGN KEY REFERENCES DISCOs(ID),
IDDISCO2 INT NOT NULL FOREIGN KEY REFERENCES DISCOs(ID),
IDWIN INT NOT NULL FOREIGN KEY REFERENCES LicenciasWindows(ID),
IDOFFICE INT NOT NULL FOREIGN KEY REFERENCES LicenciasOffice(ID)
)
