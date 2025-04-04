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
        
SELECT AVG (preco) from produto; -- 3.1

SELECT
    cliente_id, COUNT(quantidade)
FROM
    pedido
    group by cliente_id; -- 3.2
    
  SELECT
  categoria, sum(estoque)
FROM
    produto
    group by categoria; -- 3.2 