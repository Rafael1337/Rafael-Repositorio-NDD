--INSERINDO CURSO 1)
INSERT INTO TBMatricula (Curso_Id, Aluno_Id) VALUES (4,1)

--2 )
select nome from AlunoTB where Id > 0 order by Nome;
select * from TBCurso where id > 0 order by Nome

-- 3) 
select * from AlunoTB where DataNascimento <= '01/01/1995'

-- 4)
select count(*) from  AlunoTB

-- 5)
select count(*) from  AlunoTB
INNER JOIN TBMatricula
ON AlunoTB.Id=TBMatricula.Aluno_Id
INNER JOIN TBMatricula
ON AlunoTB.Id=TBMatricula.Curso_Id

-- 6)
select Nome from AlunoTB where DataNascimento <= '01/01/1995'

-- 7)
select Nome from AlunoTB where Sexo = 'F'

-- 8)


-- 9)
select Nome from TBCurso order by Nome

-- 10)
