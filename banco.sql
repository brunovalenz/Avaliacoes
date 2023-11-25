CREATE TABLE Midias (
    ID NUMBER PRIMARY KEY,
    Titulo VARCHAR2(255) NOT NULL,
    AnoLancamento NUMBER(4),
    Descricao CLOB,
    Classificacao VARCHAR2(15)
);

CREATE TABLE Filmes (
    ID NUMBER PRIMARY KEY,
    ID_Midia NUMBER,
    Diretor VARCHAR2(100),
    Duracao NUMBER(3),
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Musicas (
    ID NUMBER PRIMARY KEY,
    ID_Midia NUMBER,
    Artista VARCHAR2(100),
    Duracao NUMBER(4),
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Livros (
    ID NUMBER PRIMARY KEY,
    ID_Midia NUMBER,
    Autor VARCHAR2(127),
    TotalPag NUMBER,
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Series (
    ID NUMBER PRIMARY KEY,
    ID_Midia NUMBER,
    Diretor VARCHAR2(127),
    QntEps NUMBER(3),
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);

CREATE TABLE Avaliacoes (
    ID NUMBER PRIMARY KEY,
    ID_Midia NUMBER,
    Nota NUMBER(2),
    Avaliacao CLOB,
    DataAvaliacao DATE,
    FOREIGN KEY (ID_Midia) REFERENCES Midias(ID) ON DELETE CASCADE
);
