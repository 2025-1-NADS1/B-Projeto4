-- Primeiro, cria a tabela Comodo

CREATE TABLE Comodo (
    id_comodo INT PRIMARY KEY IDENTITY,
    nome VARCHAR(100) NOT NULL
);

-- Depois, cria a tabela Dispositivo com a FK referenciando Comodo

CREATE TABLE Dispositivo (
    id_dispositivo INT PRIMARY KEY IDENTITY,
    nome VARCHAR(100) NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    status VARCHAR(20) NOT NULL,
    id_comodo INT NOT NULL,
    FOREIGN KEY (id_comodo) REFERENCES Comodo(id_comodo)
);

SELECT*FROM Dispositivo

INSERT INTO Comodo (nome) VALUES 
('Sala de Estar'),
('Cozinha'),
('Quarto Principal');

INSERT INTO Dispositivo (nome, tipo, status, id_comodo) VALUES 
('Lâmpada Inteligente', 'Iluminação', 'ligado', 1),
('Tomada Inteligente', 'Energia', 'desligado', 2),
('Ar Condicionado', 'Climatização', 'ligado', 3),
('Sensor de Movimento', 'Segurança', 'ativo', 1);

SELECT*FROM Comodo
