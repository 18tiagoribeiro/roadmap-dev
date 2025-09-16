# roadmap-dev
Testando fundamentos lógicos

Etapa1_Logica/Soma
Na primeira etapa foi criado a classe AquecimentoSoma, dentro da classe foi criado o método soma, que recebe dois parâmetros inteiros escolhidos pelo o usuario(Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());) e retorna a soma dos dois números. A ideia é que fosse tão simples como é o exercicio. Foi criado também um objeto no Program para testar o método soma.

Etapa1_Logica/ParOuImpar
Ainda na classe AquecimentoSoma, foi criado o método parOuImpar, que recebe um número inteiro (tambem inserido pelo Console.ReadLine()) como parâmetro e retorna uma string "Par" se o número for par e "Ímpar" se o número for ímpar. Da mesma forma, também foi inserido um objeto no Program para testar o método parOuImpar.

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