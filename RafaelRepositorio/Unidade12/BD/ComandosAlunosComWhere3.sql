--SELECT * FROM Aluno WHERE Altura = 1.8;
----SELECIONA ALTURA = 1.8 , 1.80
--SELECT * FROM Aluno WHERE Altura != 1.8;
----SELECIONA ALTURA diferente 1.8 , 1.80
--SELECT * FROM Aluno WHERE Altura <= 1.8;
----SELECIONA ALTURA Menor ou igual 1.8 , 1.80
--SELECT * FROM Aluno WHERE Altura < 1.8;
----SELECIONA ALTURA Somente menor 1.8 , 1.80
--SELECT * FROM Aluno WHERE Altura >= 1.8;
----SELECIONA ALTURA Maior ou igual 1.8 , 1.80
--SELECT * FROM Aluno WHERE Altura > 1.8;
----SELECIONA ALTURA Somente maior 1.8 , 1.80

---------------------------------------------------------------------------

--SELECT * FROM Aluno WHERE Nome IS NULL ;
--Mostra dados com nomes vazios
--SELECT * FROM Aluno WHERE Nome IS NOT NULL ;
--Mostra dados com nomes nao vazios

---------------------------------------------------------------------------

----SELECT * FROM Aluno WHERE Altura BETWEEN 1.5 AND 1.8;
--mostra alunos com o altura entre 1.5 e 1.8
--SELECT * FROM Aluno WHERE Altura NOT BETWEEN 1.5 AND 1.8;
--mostra alunos que nao estejam com a altura ente 1.5 e 1.8
--------------------------------------------------------------------------

--SELECT * FROM Aluno WHERE Nome LIKE 'rafael%';
--Mostra o nome rafael que esteja inserido na tabela
--SELECT * FROM Aluno WHERE Nome NOT LIKE 'Rafael %';
--Mostra nomes que sejam diferentes de rafael

--------------------------------------------------------------------------

--SELECT * FROM Aluno WHERE Altura IN (1.5 , 1.6 , 1.7 , 1.8) ;
--Mostra as alturas que estejam ente 1.5,1.6,1.7,1.8
--SELECT * FROM Aluno WHERE Altura NOT IN (1.5 , 1.6 , 1.7 , 1.8) ;
--Mostra as alturar que nao estejam entre 1.5,1.6,1.7,1.8
---------------------------------------------------------------------------

--SELECT * FROM Aluno WHERE NOT Altura = 1.80;
--Seleciona da tabela aluno onde altura nao é = a 1.80
--SELECT * FROM Aluno WHERE Altura < 1.8 AND Nome LIKE 'rafael ';
--Seleciona a altura menor que 1.8 e o nome seja rafael
--SELECT * FROM Aluno WHERE Altura < 1.8 OR Nome LIKE 'R%';
--Seleciona a altura menor que 1.8 ou nome que inicia com inicial