CREATE TABLE cliente (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    nome_social VARCHAR(100) NULL,
    data_nascimento DATE NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    telefone VARCHAR(11) NOT NULL UNIQUE,
    tipo INT NOT NULL,
    etnia INT NOT NULL,
    genero INT NOT NULL,
    estrangeiro BIT NOT NULL,
    id_endereco INT NOT NULL,
    FOREIGN KEY (id_endereco)
        REFERENCES endereco (id)
);

INSERT INTO cliente
(nome, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)
VALUES ('Daniela Machado', '1995-11-23', 'danielamachado@email.com', '11999999999', 0, 1, 0, 0,(SELECT id FROM endereco WHERE logradouro = 'endereçoDaniela')),
('Fabio Saraiva', '2013-08-30', 'fabiosaraiva@email.com', '11999999992', 0, 1, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'endereçoFabio')),
('Vitor Lima', '1997-09-15', 'vitorlima@email.com', '11999999993', 0, 1, 0, 0, (SELECT id FROM endereco WHERE logradouro = 'endereçoVitor'));

select* from cliente;