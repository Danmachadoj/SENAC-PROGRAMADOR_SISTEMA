CREATE TABLE IF NOT EXISTS produto (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco INT NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
    FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
);
 
 
CREATE TABLE IF NOT EXISTS fornecedor (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    PRIMARY KEY(id),
	cidade VARCHAR(100) NOT NULL
);
 
CREATE TABLE IF NOT EXISTS pedido (
    id INT AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATE NOT NULL,
    cliente_id INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (produto_id)
        REFERENCES produto (id),
    FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

CREATE TABLE IF NOT EXISTS cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    idade INT NOT NULL
);
 
INSERT INTO cliente (
nome, cidade, idade
) VALUES 
( 'João Silva', 'São Paulo', '35'),
('Maria Santos','Belo Horizonte','28'),
('Carlos Lima','Rio de Janeiro','42'),
('Fernada Rocha','Curitiba','30');

INSERT INTO  produto (nome, categoria, preco, estoque, fornecedor_id) 
VALUE ('celular X', 'eletrônicos', 2500, 30, 1),
('notebook Y','eletrônicos', 4800, 15, 2),
('mesa de madeira','móveis', 750, 10, 3),
('cadeira Z', 'móveis', 300, 25, 3),
('tv 50', 'eletrônicos',3500, 8, 1);


INSERT INTO fornecedor (
nome, cidade
) VALUES 
( 'TechBrasil', 'São Paulo'),
('Computech','Rio de Janeiro'),
('Moveis&Co','Curitiba');

INSERT INTO  pedido (produto_id, quantidade, data_pedido, cliente_id) 
VALUE (1, 2, '2024-03-10', 1),
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);
 
SELECT 
  nome, categoria, preco
FROM
    produto
WHERE
    preco > 3000
ORDER BY preco DESC; -- 2.1

SELECT 
    nome, idade, cidade
FROM
    cliente
WHERE
    cidade <> 'São Paulo'
        AND idade > 30; -- 2.2
        
        SELECT data_pedido from pedido
        WHERE data_pedido between "2024-03-10" AND "2024-03-15"
        order by data_pedido ASC; -- 2.3
        
        SELECT nome, estoque, preco FROM produto
        WHERE estoque <10 order by estoque asc; -- 2.4
        
   SELECT 
    nome, cidade
FROM
    fornecedor
WHERE
    cidade <> 'Rio de Janeiro'
        AND  nome like 'T%'; -- 2.5
        
SELECT 
    AVG(preco) AS preco_medio
FROM
    produto
GROUP BY categoria; -- 3.1

SELECT
    cliente_id, COUNT(quantidade)
FROM
    pedido
    group by cliente_id; -- 3.2
    
  SELECT
  categoria, sum(estoque)
FROM
    produto
    group by categoria; -- 3.3
    
    SELECT 
    id, produto_id, quantidade
FROM
    pedido
WHERE
    quantidade = (SELECT 
            MAX(quantidade)
        FROM
            pedido); -- 3.4
    
    SELECT cidade, count(cidade) AS total_cliente 
    from cliente
    group by cidade 
    order by cidade desc; -- 3.5
    
    SELECT 
    p.nome AS produto, f.nome AS fornecedor
FROM
    produto p
        INNER JOIN
    fornecedor f ON p.fornecedor_id = f.id
ORDER BY f.nome; -- 4.1

SELECT 
    pedido.id AS pedido_id, c.nome AS cliente, p.nome AS produto
FROM
    pedido
        INNER JOIN
    cliente c ON c.id = pedido.cliente_id
        INNER JOIN
    produto p ON p.id = pedido.produto_id
ORDER BY data_pedido; -- 4.2

SELECT 
   c.nome AS cliente, p.nome AS produto, f.nome as fornecedor
FROM
    pedido
        INNER JOIN
    cliente c ON c.id = pedido.cliente_id
        INNER JOIN
    produto p ON p.id = pedido.produto_id
        INNER JOIN
   fornecedor f on p.fornecedor_id = f.id; -- 4.3
   
SELECT c.nome AS cliente, SUM(p.quantidade) AS total_produtos_comprados
FROM pedido p
JOIN cliente c ON p.cliente_id = c.id
GROUP BY c.nome; -- 4.4
  
SELECT *
FROM produto p
WHERE preco > ( SELECT AVG(preco)  FROM produto  WHERE categoria = p.categoria
); -- 5.1

UPDATE produto
SET preco = preco * 1.10
WHERE categoria = 'Eletrônicos'; -- 5.2

DELETE FROM pedido
WHERE cliente_id IN (
    SELECT id
    FROM cliente
    WHERE cidade = 'Curitiba'
); -- 5.3

INSERT INTO cliente (nome, cidade, idade)
VALUES ('Ricardo Lopes', 'Porto Alegre', 38); -- 5.4
 
INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id)
VALUES (
    (SELECT id FROM produto WHERE nome = 'Notebook Y'), 
    2, 
    '2024-03-25', 
    (SELECT id FROM cliente WHERE nome = 'João Silva')
); -- 5.5

SELECT DISTINCT c.nome
FROM cliente c
JOIN pedido  ON c.id = pedido.cliente_id
JOIN produto p ON pedido.produto_id = p.id
WHERE p.categoria = 'Móveis'; -- 5.6