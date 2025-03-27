CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    
 INSERT INTO usuario (
 nome,
 email,
 senha
 )
 VALUES (
 'daniela.machado',
 'daniela.machado@email.com',
 'senha@123'
 );
  INSERT INTO usuario (nome, email, senha)
 VALUES ('Neymar Jr.','njr@email.com','"Brun@'),
 ('Maria Madalena','mmadalena@email.com','M@dal3n@'),
 ('Pablo Vittar','pvittar@email.com','*Senh@Fort3');
 