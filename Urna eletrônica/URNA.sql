USE master
GO

DROP DATABASE Urna
GO

CREATE DATABASE Urna
GO

USE Urna
GO

CREATE TABLE Eleitor
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150),
	Titulo VARCHAR(15),
	Votou BIT
)
GO

CREATE TABLE Candidato
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150),
	Numero INT
)
GO

CREATE TABLE Eleicao
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Ano INT,
	Turno INT
)
GO