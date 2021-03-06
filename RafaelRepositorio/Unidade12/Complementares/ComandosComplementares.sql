﻿SELECT * FROM Funcionario WHERE Salario > 1000 order by PrimeiroNome, SobreNome
SELECT * FROM Funcionario WHERE Salario > 0 order by Salario
SELECT * FROM Funcionario WHERE Salario > 0 order by Departamento_Id
DELETE FROM Funcionario WHERE PrimeiroNome = null
SELECT D.Nome FROM Departamento as D inner join Funcionario as F on F.Departamento_Id = D.Id and F.Funcao = 'Supervisor'
SELECT * FROM Funcionario WHERE Salario between 500 and 1500 order by PrimeiroNome
SELECT * FROM Funcionario WHERE PrimeiroNome LIKE 'R%' order by Departamento_Id
SELECT COUNT(Id) FROM Funcionario

