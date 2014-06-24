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

select count(*), C.Nome from  AlunoTB as A 
INNER JOIN TBMatricula as M
ON A.Id=M.Aluno_Id
INNER JOIN TBCurso as C
ON C.Id=M.Curso_Id
Group by C.Nome

-- 6)
select Nome from AlunoTB where DataNascimento <= '01/01/1995'

-- 7)
select Nome from AlunoTB where Sexo = 'F'

-- 8)
SELECT COUNT(*) FROM AlunoTB as a inner join TBMatricula as m on a.Id = m.Aluno_Id inner join TBCurso as c on c.Id = m.Curso_Id group by c.Nome

-- 9)
select Nome from TBCurso order by Nome

-- 10)
