-- DDL ou SCHEMA
CREATE TABLE filial (
	id INT IDENTITY,
	nome NVARCHAR(50),
	PRIMARY KEY (id)
);

CREATE TABLE setor (
	id INT IDENTITY,
	nome NVARCHAR(50),
	PRIMARY KEY (id)
);

CREATE TABLE cargo (
	id INT IDENTITY,
	nome NVARCHAR(50),
	PRIMARY KEY (id)
);

CREATE TABLE empregado (
	id INT IDENTITY,
	nome NVARCHAR(50),
	id_filial INT,
	id_setor INT,
	id_cargo INT,
	PRIMARY KEY (id),	
	FOREIGN KEY (id_setor) REFERENCES setor (id),
	FOREIGN KEY (id_filial) REFERENCES filial (id),
	FOREIGN KEY (id_cargo) REFERENCES cargo (id)
);