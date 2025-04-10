CREATE TABLE livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_publicacao DATETIME NOT NULL,
    numero_paginas INT NULL,
    preco DECIMAL(10 , 2 ) NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    genero VARCHAR(30) NOT NULL,
    editora VARCHAR(50) NOT NULL,
    autor VARCHAR(100) NOT NULL
);

INSERT INTO livro(
titulo, data_publicacao, preco, isbn, genero, editora, autor
) VALUE (
'titulo do meu livro',
'1994-08-31 22:38:48',
129.99,
'978-3-16-148410-0',
'tecnologia',
'editora',
'rafael sousa'
);

INSERT INTO livro(
titulo, data_publicacao, preco, isbn, genero, editora, autor
) VALUE (
'o diario da perda',
'2024-08-10',
99.99,
'856-4-26-457862-2',
'drama',
'editora',
'daniela machado'
);

INSERT INTO livro(
titulo, data_publicacao, preco, isbn, genero, editora, autor
) VALUE (
'vida de cao - a historia de 3 cachorros',
'2025-01-23',
45.99,
'764-1-83-514681-6',
'aventura',
'editora',
'daniela machado'
);

DROP TABLE livro;
