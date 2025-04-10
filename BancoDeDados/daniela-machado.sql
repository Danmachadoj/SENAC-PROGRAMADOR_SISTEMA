CREATE TABLE IF NOT EXISTS empregado (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    idade INT NOT NULL,
    departamentoID INT NOT NULL,
    salario INT NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY (DEPARTAMENTOID) REFERENCES DEPARTAMENTO(ID)
);
CREATE TABLE IF NOT EXISTS departamento (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    PRIMARY KEY(id)
);
INSERT INTO departamento (id, nome) VALUES (1, 'RH'), (2, 'Vendas'), (3, 'TI');

INSERT INTO empregado (
nome, idade, departamentoID, salario
)
VALUES (
'João',
'30',
1,
'50000'
),
(
'Sarah',
28,
3,
'60000'
),
(
'Miguel',
'35',
2,
'55000'),
(
'Ana',
'27',
3,
'62000');

SELECT* FROM empregado;-- identificar que a tabela foi criada

SELECT nome, departamento FROM empregado
WHERE departamento = 'TI'; --  1.1 localizar funcionarios do ti

SELECT nome,
salario FROM empregado
WHERE  salario >'55000'; -- 1.2 localizar nome e salario que ganham mais de 55000

SELECT * FROM empregado
ORDER BY idade desc; -- 1.3 ordenar a idade dos funcionarios

SELECT * FROM empregado
WHERE idade >='28'
AND idade <='35'; -- 2.1 idade entre 28 e 35 (pode ser usado o between "where idade between 28 and 35"

SELECT * FROM empregado
WHERE nome LIKE 'M%'; -- 2.2 funcionarios que começam com M

SELECT nome, departamento FROM empregado
WHERE departamento != 'RH' ; -- 2.3 não estão no RH  (pode ser usado o  <> no lugar no !=)

SELECT 
    departamento, count(id)
FROM empregado
GROUP BY 
	departamento; -- 3.1 numero de empregados de cada departamento

SELECT avg(salario) FROM empregado
WHERE departamento = 'TI'; -- 3.2 media salarial

SELECT sum(salario) from empregado
WHERE departamento = 'Vendas'; -- 3.3 soma de salario do departamento de vendas

SELECT * 
FROM empregado 
INNER JOIN departamento 
ON empregado.departamentoID = departamentoID; -- 4.1 olhar a correção do prof
 
SELECT * 
FROM empregado
LEFT JOIN departamento
ON empregado.departamentoID = departamentoID;-- 4.2  olhar a correção do prof

SELECT * FROM empregado
WHERE salario >(SELECT AVG(salario) FROM empregado); -- 5.1 empregados que o salario é maior que a media salarial

SELECT nome, departamentoid FROM empregado
WHERE departamentoid = (SELECT departamentoid FROM empregado WHERE nome = 'Sarah'); -- 5.2 empregados que pertencem ao mesmo departamento que Sarah -- errei olhar correção do prof


INSERT INTO empregado (
nome, idade, departamentoid, salario
)
VALUES (
'Tomás',
'45',
'2',
'58000'); -- 6.1 incluir novo funcionario

UPDATE empregado
SET salario = salario + (salario * 0.05)
WHERE departamentoid = '3'; -- 6.2 aumento de salario de 5% funcionarios de TI - errei, olhar correção do prf

DELETE FROM empregado
WHERE idade > '40'; -- 6.3 excluir funcionario com mais de 40 anos






