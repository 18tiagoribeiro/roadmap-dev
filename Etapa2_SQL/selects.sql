
--SELECT *
--FROM Funcionarios
-- Selecionando todos os campos da tabela Funcionarios

--SELECT nome, cargo
--FROM Funcionarios
-- Selecionando apenas nome e cargo da tabela Funcionarios

--SELECT *
--FROM Funcionarios
--ORDER BY salario DESC
-- Selecionando e ordenando todos os campos da tabela Funcionarios pelo campo salario em ordem decrescente

--SELECT *
--FROM Funcionarios
--WHERE DepartamentoID = 1;
-- Selecionando todos os campos da tabela Funcionarios onde o DepartamentoID � igual a 1 (departamento de TI)

--SELECT ROUND(CAST(AVG(salario) AS DECIMAL(10,2)), 2) AS SalarioMedio
--FROM Funcionarios
-- Calculando a m�dia dos sal�rios dos funcion�rios. O resultado � arredondado para duas casas decimais (ROUND(..., 2)) e exibido com o alias "SalarioMedio".(CAST(AVG(salario) AS DECIMAL(10,2)), 2) converte a m�dia para decimal com duas casas decimais e depois arredonda o valor.

--SELECT d.NomeDepartamento, COUNT(f.ID) AS TotalFuncionarios
--FROM Funcionarios f
--JOIN Departamento d ON f.DepartamentoID = d.ID
--GROUP BY d.NomeDepartamento;
-- Contando o n�mero de funcion�rios em cada departamento. A jun��o (JOIN) � feita entre as tabelas Funcionarios e Departamento com base no campo DepartamentoID. O resultado � agrupado pelo nome do departamento (GROUP BY d.NomeDepartamento) e o total de funcion�rios em cada departamento � exibido com o alias "TotalFuncionarios".

--SELECT *
--FROM Funcionarios
--WHERE salario > 1400;
-- Selecionando todos os campos da tabela Funcionarios onde o sal�rio � maior que 1400

--SELECT *
--FROM Funcionarios
--WHERE dataContratacao > '2023-01-01';
-- Selecionando todos os campos da tabela Funcionarios onde a data de contrata��o � posterior a 1� de janeiro de 2023
