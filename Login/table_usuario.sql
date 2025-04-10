CREATE TABLE usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(20) NOT NULL
);

INSERT INTO usuario (email, senha) VALUES
('joe.jonas@email.com', 'brothers'),
('chris.brown@email.com', 'residuals'),
('elisa.jesus@email.com', 'nenem');

SELECT 
    *
FROM
    usuario;