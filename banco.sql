CREATE TABLE Midias (
    Id INT PRIMARY KEY,
    Titulo VARCHAR(255) NOT NULL,
    AnoLancamento INT,
    Descricao TEXT,
    Classificacao VARCHAR(15)
);

CREATE TABLE Filmes (
    ID INT PRIMARY KEY,
    IdMidia INT,
    Diretor VARCHAR(100),
    Duracao INT,
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Musicas (
    ID INT PRIMARY KEY,
    IdMidia INT,
    Artista VARCHAR(100),
    Duracao INT,
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Livros (
    ID INT PRIMARY KEY,
    IdMidia INT,
    Autor VARCHAR(127),
    TotalPag INT,
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Series (
    ID INT PRIMARY KEY,
    IdMidia INT,
    Diretor VARCHAR(127),
    QntEps INT,
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Avaliacoes (
    ID INT PRIMARY KEY,
    IdMidia INT,
    Nota INT,
    Avaliacao TEXT,
    DataAvaliacao DATE,
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID)
);
