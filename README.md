# roadmap-dev
Testando fundamentos lógicos

Etapa1_Logica/Soma
Na primeira etapa foi criado a classe AquecimentoSoma, dentro da classe foi criado o método soma, que recebe dois parâmetros inteiros escolhidos pelo o usuario(Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());) e retorna a soma dos dois números. A ideia é que fosse tão simples como é o exercicio. Foi criado também um objeto no Program para testar o método soma.

Etapa1_Logica/ParOuImpar
Ainda na classe AquecimentoSoma, foi criado o método parOuImpar, que recebe um número inteiro (tambem inserido pelo Console.ReadLine()) como parâmetro e retorna uma string "Par" se o número for par e "Ímpar" se o número for ímpar. Da mesma forma, também foi inserido um objeto no Program para testar o método parOuImpar.S

Etapa1_Logica/Tabuada
Tambem foi criado o metodo Tabuada na classe AquecimentoSoma. No metodo ele recebe um número inteiro como parâmetro (inserido pelo usuario tbm) e retorna a tabuada do número de 1 a 10 que usa a estrutura FOR. Método tambem testado no Program.

Etapa1_Logica/VerificarMaiorNumero
Foi criado o método VerificarMaiorNumero na classe ControleDeFluxo. O método recebe três números inteiros como parâmetros (inseridos pelo usuario) e retorna o maior número entre eles três, na qual foi usado o laço IF/ELSE para fazer a verificação. Tambem criado um objeto no Program para testar os resultados.

Etapa1_Logica/MediaDeNotas
Dentro do metodo MediaDeNotas criei 3 double (nota1, nota2, nota3), 1 double media que recebia as 3 notas e dividia por 3 e o laço IF/ELSE para fazer a verificação se a média era maior ou igual a 7, retornando "Aprovado" se fosse maior ou igual a 7 e "Reprovado" se fosse menor que 7. O método recebe as 3 notas como parâmetros (inseridas pelo usuario) e retorna a média das notas e se o aluno foi aprovado ou reprovado. Tambem foi criado um objeto no Program para testar o método.

Etapa1_Logica/Crescente
No metodo Crescente usei a estrutura de repetição WHILE para imprimir os números de 1 a 10 em ordem crescente. Eu inclui uma verificação IF/ELSE para verificar se os numeros digitados estão dentro dos parametros (de 1 a 10) E eu tambem criei o objeto no program para poder testa-lo.

Etapa1_Logica/NumerosPrimos 
No metodo NumerosPrimos usei a estrutura de repetição FOR para imprimir os números primos de um numero escolhido pelo usuario. A verificação de número primo foi feita usando um laço FOR aninhado para contar os divisores de cada número. Se um número tiver exatamente dois divisores (1 e ele mesmo), ele é considerado primo. O método não recebe parâmetros e retorna uma lista de números primos. Também criei um objeto no Program para testar o método.

Etapa1_Logica/Fatorial
Ja no metodo Fatorial usei a estrutura IF/ELSE para verificar se o numero é negativo, zero ou positivo. Se o número for negativo, o método retorna -1 para indicar que o fatorial não está definido para números negativos. Se o número for zero, o método retorna 1, pois o fatorial de zero é definido como 1. Para números positivos, usei um laço FOR para calcular o fatorial multiplicando todos os números inteiros de 1 até o numero escolhido pelo usuario. O metodo recebe um numero inteiro como parâmetro e retorna o fatorial desse número. Também criei um objeto no Program para testar o método.

Etapa2_SQL/create_table.sql
Foi criado o banco de dados chamado EmpresaDB e dentro do banco de dados foi criada a tabela Funcionarios com os seguintes campos: Id (inteiro, chave primaria), Nome (varchar(100), não nulo), Cargo (varchar(50)), Salario (decimal(10,2)), DataContratacao (date) e ID_Departamento (inteiro, chave estrangeira referenciando a tabela Departamentos). Já a tabela Departamentos foi criada com os seguintes campos: Id (inteiro, chave primaria), NomeDepartamento (varchar(100), não nulo).

Etapa2_SQL/insert.sql
Foram inseridos 3 registros na tabela Departamento  (1, TI; 2, Recursos Humanos; 3, Financeiro) e 6 registros na tabela Funcionarios (que segue esse padrão: (95, 'João', 'Analista JR', 1500, '2024-11-25', 3))

Etapa2_SQL/select.sql
Foram criadas 8 consultas no SQL. sendo elas:
Selecionar todos os funcionários,
Funcionários apenas nome e cargo da tabela Funcionarios,
Todos os campos da tabela Funcionarios pelo campo salario em ordem decrescente,
Todos os campos da tabela Funcionarios onde o DepartamentoID é igual a 1 (departamento de TI)
Calculo da média salarial dos funcionários,
Contagem do número total de funcionários,
Todos os campos da tabela Funcionarios onde o salário é maior que 1400
Todos os campos da tabela Funcionarios onde a data de contratação é posterior a 1º de janeiro de 2023

Etapa2_SQL/update.sql
Foram criadas 4 consultas de atualização no SQL. sendo elas:
Aumentando o salário em 10% para todos os funcionários do departamento de RH
Aumentando o salário para o funcionário com ID 98 em 30%
Deletados todos os funcionários com salário menor ou igual a 1500
Atualizando o cargo do funcionário com ID = 97

Etapa3_Csharp/ContaBancaria
   Em ContaBancaria foi criada a pasta Modelos, dentro da pasta modelo contém 2 classes (Cliente e ContaBancaria).
   Na classe Cliente foi incluida algumas propriedades como Nome, CPF, DataNasicmento e Telefone.
Tambem foi criada um contrutor publico que contem os parametros como: string nome, string cpf, datetime dataNascimento, string Telefone. Que foram criados para iniciar o objeto com os dados especificos.

 Já na class Conta bancaria foi incluida as propiedades NumeroConta, Titular (que é do tipo Cliente) e Saldo. Criado também alguns contrutores como o proprio conta bancaria que recebe os parametros das propriedades, depositar(double valor), Sacar(double valor) - que faz uma verificação para ver se o cliente tem saldo com o IF/ELSE como estrutura condicional.
 E o ExbirDados que serve para organizar as informações que temos em um formato mais facil de ser visualizado quando chamado o método.

 No program incluimos alguns dados para os clientes manualmente criando um new Cliente e colocando como parametro conforme colocamos na classe Cliente. Além disso temos os Métodos Depositar e Sacar para fazer os devidos testes (também incluindo manualmente) e o método ExibirDados que traz os dados da forma mais visual possivel.

 Etapa3_Csharp/Agenda
  Esse projeto Agenda cotém uma aplicação simples, na qual foram criado 1 classe que se chama Compromisso, dentro de compromisso temos 2 propiedades do tipo string (Nome e Telefone) e 1 propiedade do tipo DateTime (Data).
Dentro dessa mesma classe tambem foi incluido 2 construtores: Compromisso que tem como objetivo iniciar a classe Compromisso com os parametros das propiedades. Incluido também um construtor chamado MOSTRAR, pra imprimir na tela de uma mais visual e organizada o resultado pós ter feito o compromisso na agenda.
  Em program foi criado uma lista do tipo Compromisso que leva o nome de agenda, essa lista recebe os compromissos que o usuário incluiu, tambem foi inserido as interações com o usuário (Digite seu nome).
Além disso incluir uma estrutura condicional IF/ELSE para validar se a data inserida é valida (se for no passado ele trás a mensagem de erro "Data invalida. Não é possivel agendar em uma data passada").
  Por fim, foi inserido a estrutura de repetição FOREACH, que passa pela lista agenda imprimindo o resultado inserido pelo usuario, que é chamado pelo método MOSTRAR.