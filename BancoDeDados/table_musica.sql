CREATE TABLE IF NOT EXISTS musica (
    id INT PRIMARY KEY AUTO_INCREMENT,
    cantor VARCHAR(50) NOT NULL,
    musica VARCHAR(50) NOT NULL,
   genero VARCHAR(16) NOT NULL,
   cd VARCHAR(30) NOT NULL
);

    INSERT INTO musica ( cantor, musica, genero, cd)
 VALUES ('chris brown', 'residual', 'r&b', '11:11'),
 ('jonas brothers', 'when you look me in the eyes', 'pop', 'jonas brothers'),
 ('falling in reverse', 'watch the world burn', 'rock','popular monster'),
 ('escape the fate', 'the guilliotine', 'rock', 'dying is your latest fashion'),
 ('keri hilson', 'knock you down', 'r&b', 'in a perfect world...'),
 ('demi lovato', 'give your heart a break', 'pop', 'unbroken'),
 ('miley cyrus', 'angels like you', 'pop', 'plastic hearts'),
 ('selena gomez', 'perfect', 'pop', 'revival'),
 ('beyonce', 'halo', 'r&b', ' i am… sasha fierce'),
 ('ciara', 'like a boy', 'r&b',' ciara: the evolution'),
 ('rihanna', 'take a bow', 'r&b', ' good girl gone bad: reloaded'),
 ('neyo', 'hate that i love you', 'r&b', 'good girl gone bad'),
 ('nelly', 'dilema', 'r&b','nellyville'),
 ('destinys child', 'survivor', 'r&b', 'Survivor'),
 ('mariah carey', 'obsessed', 'pop', ' memoirs of an imperfect angel');
 
SELECT 
    *
FROM
    musica
WHERE cantor = 'ciara';
