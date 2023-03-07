Create table Edificio (
	Edificio_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nombre varchar(MAX) NOT NULL
);


Create table Empleado (
	Empleado_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Identificacion int NOT NULL,
	Nombre varchar(MAX) NOT NULL,
	Apellido1 varchar(MAX) NOT NULL,
	Apellido2 varchar(MAX) NOT NULL,
	FechaNacimiento date NOT NULL,
	FechaSalida date,
);

Create table TipoProfesional(
	TipoProfesional_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nombre varchar(MAX),
	Salario MONEY
);

Create table Profesion(
	Profesion_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Nombre varchar(MAX) NOT NULL,
	TipoProfesion_Id int FOREIGN KEY REFERENCES TipoProfesional(TipoProfesional_Id),
);

Create table EmpleadoEdificioProfesion (
	Cargo_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Empleado_Id int FOREIGN KEY REFERENCES Empleado(Empleado_Id),
	Edificio_Id int FOREIGN KEY REFERENCES Edificio(Edificio_Id),
	Profesion_Id int FOREIGN KEY REFERENCES Profesion(Profesion_Id),
	IsAcenso bit NOT NULL,
	Fecha date,
);


Create table Ingreso (
	Ingreso_Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Empleado_Id int FOREIGN KEY REFERENCES Empleado(Empleado_Id),
	Edificio_Id int FOREIGN KEY REFERENCES Edificio(Edificio_Id),
	Fecha date,
	);

INSERT INTO Edificio 
VALUES ('Edificio Obelisco');
INSERT INTO Edificio
VALUES ('Edificio Principal');
INSERT INTO Edificio
VALUES ('Edificio Eiffel');

INSERT INTO TipoProfesional
VALUES ('Técnico',511689.26);
INSERT INTO TipoProfesional
VALUES ('Diplomado',552643.52);
INSERT INTO TipoProfesional
VALUES ('Bachiller',626828.55);
INSERT INTO TipoProfesional
VALUES ('Licenciado',752220.04);

Select * from [dbo].[TipoProfesional];
