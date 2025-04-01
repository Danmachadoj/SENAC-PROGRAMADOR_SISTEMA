create table if not exists empregado (
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
idade VARCHAR(50) NOT NULL,
departamento VARCHAR (16) NOT NULL,
salario INT NOT NULL
);

INSERT INTO empregado (
nome, idade, departamento, salario
)
VALUES (
'João',
'30',
'RH',
'50000'
),
(
'Sarah',
28,
'TI',
'60000'
),
(
'Miguel',
'35',
'Vendas',
'55000'),
(
'Ana',
'27',
'TI',
'62000');

SELECT* FROM empregado;-- identificar que a tabela foi criada

SELECT nome, departamento FROM empregado
WHERE departamento LIKE '%TI%'; -- localizar funcionarios do ti

SELECT nome,
salario FROM empregado
WHERE  salario >'55000'; -- localizar nome e salario que ganham mais de 55000

SELECT * FROM empregado
ORDER BY idade desc; -- ordenar a idade dos funcionarios

SELECT * FROM empregado
WHERE idade >'28'
AND idade <'35'; -- idade entre 28 e 35

SELECT * FROM empregado
WHERE nome LIKE 'M%'; -- funcionarios que começam com M

SELECT nome, departamento FROM empregado
WHERE departamento NOT LIKE "RH" ; -- não estão no RH

SELECT 
    departamento, count(departamento)
FROM empregado
GROUP BY 
	departamento; -- numero de empregados de cada departamento

SELECT avg(salario) FROM empregado
WHERE departamento = 'TI'; -- media salarial

SELECT sum(salario) from empregado
WHERE departamento = 'Vendas'; -- soma de salario do departamento de vendas








SELECT * FROM empregado
WHERE salario >(SELECT AVG(salario) FROM empregado); -- empregados que o salario é maior que a media salarial

SELECT nome, departamento FROM empregado
WHERE departamento = (SELECT departamento FROM empregados WHERE nome = 'Sarah'); -- empregados que pertencem ao mesmo departamento que Sarah


INSERT INTO empregado (
nome, idade, departamento, salario
)
VALUES (
'Tomás',
'45',
'Vendas',
'58000')



