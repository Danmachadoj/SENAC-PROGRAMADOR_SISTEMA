CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    saldo DECIMAL (6,2) NULL
    );
INSERT INTO cliente (
nome, idade, cidade, saldo
) VALUES 
( 'Carlos', '45', 'São Paulo','2500.00'),
('Mariana','32','Rio de Janeiro','3200.50'),
('Pedro','27','Belo Horizonte', '1500.75'),
('Fernanda','38','Curitiba','4200.00');

CREATE TABLE IF NOT EXISTS pedido (
id INT PRIMARY KEY AUTO_INCREMENT,
id_cliente INT NOT NULL,
valor DECIMAL(10, 2) NULL,
data_pedido DATETIME NOT NULL,
FOREIGN KEY (id_cliente)
REFERENCES cliente (id)
);
   
INSERT INTO pedido(
id_cliente, valor, data_pedido
) VALUES
('1','500.00','2024-03-10'),
('2','1200.00','2024-03-12'),
('3','300.50','2024-03-15'),
('1','800.00','2024-03-18')
;

SELECT* FROM cliente
WHERE cidade = 'Rio de Janeiro';

SELECT nome, saldo FROM cliente
WHERE saldo >2000 ORDER BY saldo desc;

SELECT nome, idade FROM cliente
WHERE idade >"30";

SELECT * FROM cliente
WHERE idade between '25' and '40';

SELECT nome FROM cliente
WHERE NOME LIKE 'F%';

SELECT nome, cidade FROM cliente
WHERE cidade != 'São Paulo' AND cidade != 'Curitiba';

SELECT COUNT(id) AS 'pedidos'
FROM pedido;

SELECT AVG(valor) AS 'media'
FROM pedido;

SELECT cliente.nome, SUM(valor)
FROM pedido
JOIN cliente ON pedido.id_cliente = cliente.id
GROUP BY id_cliente; 

SELECT pedido.id AS 'pedidos', valor, data_pedido, cliente.nome
FROM pedido
INNER JOIN cliente ON pedido.id_cliente = cliente.id;

SELECT cliente.nome, idade, cidade, saldo, valor, data_pedido FROM cliente
LEFT JOIN pedido ON pedido.id_cliente = cliente.id;


SELECT nome, valor
FROM pedido
LEFT JOIN cliente ON pedido.id_cliente = cliente.id
WHERE valor > 1000;

INSERT INTO cliente (
nome, idade, cidade, saldo
) VALUES 
( 'Rafael', '35', 'Porto Alegre','0');

UPDATE cliente
SET saldo = saldo + (saldo * 0.1);

DELETE FROM pedido
WHERE id = (SELECT id FROM pedido WHERE valor < '500');