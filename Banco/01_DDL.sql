CREATE DATABASE SpMedGroup;

USE SpMedGroup;

CREATE TABLE Clinica
(
	idClinica INT PRIMARY KEY IDENTITY 
	,NomeFantasia VARCHAR (200) NOT NULL
	,Cnpj VARCHAR (200) NOT NULL
	,RazaoSocial VARCHAR (200) NOT NULL 
	,Endereco VARCHAR (200) NOT NULL 
	,HorarioAbertura TIME NOT NULL
	,HorarioFechamento TIME NOT NULL

);


CREATE TABLE tiposUsuario
(
	idTipoUsuario INT PRIMARY KEY IDENTITY
	,tituloTipoUsuario VARCHAR (200) NOT NULL
);


CREATE TABLE Usuario
(
	idUsuario	INT PRIMARY KEY IDENTITY
	,idTipoUsuario	INT FOREIGN KEY REFERENCES tiposUsuario (idTipoUsuario)
	,NomeUsuario VARCHAR (200) NOT NULL
	,Email VARCHAR (200) NOT NULL 
	,Senha VARCHAR (200) NOT NULL
);


CREATE TABLE Paciente
(
	idPaciente INT PRIMARY KEY IDENTITY	
	,idUsuario INT FOREIGN KEY REFERENCES Usuario (idUsuario) 
	,Nome VARCHAR (200) NOT NULL 
	,DataNascimento VARCHAR (200) NOT NULL
	,Telefone VARCHAR (200) NOT NULL
	,Rg	VARCHAR (200) NOT NULL
	,Cpf VARCHAR (200) NOT NULL
	,Endereco VARCHAR (200) NOT NULL
);


CREATE TABLE Especialidade
(
	idEspecialidade INT PRIMARY KEY IDENTITY 
	,nomeEspecialide VARCHAR (200) NOT NULL

);


CREATE TABLE Situacao 
(
	IdSituacao INT PRIMARY KEY IDENTITY
	,Situacao VARCHAR (200) NOT NULL
);


CREATE TABLE Medico
(
	idMedico INT PRIMARY KEY IDENTITY 
	,idClinica INT FOREIGN KEY REFERENCES Clinica (idClinica)
	,idUsuario INT FOREIGN KEY REFERENCES Usuario (idUsuario)
	,idEspecialidade INT FOREIGN KEY REFERENCES Especialidade (idEspecialidade) 
	,NomeMedico VARCHAR (200) NOT NULL 
	,Crm VARCHAR (100) NOT NULL
);


CREATE TABLE Consulta
(
	idConsulta INT PRIMARY KEY IDENTITY 
	,idPaciente INT FOREIGN KEY REFERENCES Paciente (idPaciente)
	,idSituacao INT FOREIGN KEY REFERENCES Situacao	 (idSituacao)
	,idMedico INT FOREIGN KEY REFERENCES	Medico  (idMedico)
	,horaConsulta VARCHAR(200) NOT NULL
	,dataConsulta DATE NOT NULL
	,descricao VARCHAR (200) NOT NULL
);

DROP TABLE Consulta