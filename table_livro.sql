create table livro (
id int primary key auto_increment,
titulo varchar(100) not null,
genero varchar(30) not null,
editora varchar(50) not null,
isbn varchar(15) not null unique,
autor varchar(100) not null
);

