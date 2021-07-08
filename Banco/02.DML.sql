USE SpMedGroup;

INSERT INTO	tiposUsuario (tituloTipoUsuario)
VALUES	('Administrador')
		   ,('Medico')
		   ,('Paciente');
GO


INSERT INTO Usuario (idTipoUsuario, NomeUsuario, Email, Senha)
VALUES				(2,'Ricardo Lemos','ricardo.lemos@spmedgroup.com.br','ricardo123')
					,(2,'Roberto Possarle','roberto.possarle@spmedgroup.com.br','roberto123')
					,(2,'Helena Souza','helena.souza@spmedgroup.com.br','helena123')
					,(3,'Ligia','ligia@gmail.com','ligia123')
					,(3,'Alexandre','alexandre@gmail.com','alexandre123')
					,(3,'Fernando','fernando@gmail.com','fernando')
					,(1,'Adm','sauloadm@gmail.com','saulo123')
					,(3,'Henrique','henrique@gmail.com','henrique123')
					,(3,'Jo�o','joao@gmail.com','joao123')
					,(3,'Bruno','bruno@gmail.com','bruno123')
					,(3,'Mariana','mariana@outlook.com','mariana123');
GO


INSERT INTO Especialidade (nomeEspecialide)
VALUES						 ('Acupuntura')
							,('Anestesiologia')
							,('Angiologia')
							,('Cardiologia')
							,('Cirurgia Cardiovascular')
							,('Cirurgia da M�o')
							,('Cirurgia do Aparelho Digestivo')
							,('Cirurgia Geral')
							,('Cirurgia Pedi�trica')
							,('Cirurgia Pl�stica')
							,('Cirurgia Tor�cica')
							,('Cirurgia Vascular')
							,('Dermatologia')
							,('Radioterapia')
							,('Urologia')
							,('Pediatria')
							,('Psiquiatria');
GO


INSERT INTO Paciente (idUsuario,Nome, Datanascimento, Telefone, Rg, Cpf, Endereco)
VALUES					 (4,'Ligia','10/03/1983','1134567654','435225435','94839859000','Rua Estado de Israel 240, S�o Paulo, Estado de S�o Paulo, 04022-000')
						,(5,'Alexandre','07/03/2001','73556944057','326543457','326543457','Av. Paulista, 1578 - Bela Vista, S�o Paulo - SP, 01310-200')
						,(6,'Fernando','10/10/1978','16839338002','546365253','546365253','Av. Ibirapuera - Indian�polis, 2927,  S�o Paulo - SP, 04029-200')
						,(7,'Henrique','13/10/1985','14332654765','543663625','543663625','R. Vit�ria, 120 - Vila Sao Jorge, Barueri - SP, 06402-030')
						,(8,'Jo�o','27/08/1975','91305348010','325444441','325444441','R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeir�o Pires - SP, 09405-380')
						,(9,'Bruno','21/03/1972','79799299004','545662667','545662667','Alameda dos Arapan�s, 945 - Indian�polis, S�o Paulo - SP, 04524-001')
						,(10,'Mariana','05/03/2018','13771913039','545662668','545662668','R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140');
GO


INSERT INTO Situacao (Situacao)
VALUES				('Agendada')
					,('Realizada')
					,('Cancelada');
GO


INSERT INTO Clinica (NomeFantasia, Cnpj, RazaoSocial, Endereco, HorarioAbertura, HorarioFechamento)
VALUES				('Clinica Possarle', '86.400.902/0001-301', 'SP M�dical Group', 'Av.Bar�o Limeira, 532,  S�o Paulo, SP', '05:00', '20:00' );

GO


INSERT INTO Medico ( idClinica, idUsuario, idEspecialidade,NomeMedico,Crm)
VALUES				(1,1,17,'Ricardo Lemos','10359-SP')
					,(1,2,6,'Roberto Possarle','74114-SP')
					,(1,3,10,'Helena Strada','94710-SP');
GO


INSERT INTO  Consulta (idPaciente, idSituacao, idMedico, horaConsulta, dataConsulta, descricao)
VALUES					(1,3,2, '07:00','14/04/2021','Dor lombar')
						,(2,1,3,'09:30','28/03/2021','cefaleia')
						,(3,3,2,'10:00','29/03/2021','dor no nervo ci�tico')
						,(4,2,1,'13:00','08/04/2021','bra�o quebrado')
						,(5,1,2,'14:45','21/05/2021','pneumonia')
						,(6,2,1,'15:00','30/03/2021','depress�o')
						,(7,1,3,'16:00','06/04/2021','anemia');
GO




SELECT * FROM tiposUsuario
SELECT * FROM Usuario
SELECT * FROM Especialidade
SELECT * FROM Paciente
SELECT * FROM Situacao
SELECT * FROM Clinica
SELECT * FROM Medico
SELECT * FROM Consulta