CREATE TABLE Departamento (
    ID INT PRIMARY KEY,
    NomeDepartamento VARCHAR(100) NOT NULL
);

CREATE TABLE Funcionario (
    ID INT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cargo VARCHAR(100),
    salario DECIMAL(10, 2),
    dataContratacao DATE,
    ID_Departamento INT,
    FOREIGN KEY (ID_Departamento) REFERENCES Departamento(ID)
);

