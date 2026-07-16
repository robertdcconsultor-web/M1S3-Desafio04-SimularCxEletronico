// Crie um sistema que:
// Exibe um menu com opções:
// Depositar
// Sacar
// Ver saldo
// Sair
// O menu deve aparecer pelo menos uma vez.
// O saldo não pode ficar negativo.
// O usuário deve conseguir fazer várias operações até escolher sair.


/*

string selecao = "";
decimal saldo = 0; 

while (selecao != "4")
{
    Console.WriteLine("Bem vindo ao Banco SCTec! Digite uma opção para continuar: ");
    Console.WriteLine("1 - Depositar ");
    Console.WriteLine("2 - Sacar ");
    Console.WriteLine("3 - Ver Saldo ");
    Console.WriteLine("4 - Sair ");

    selecao = Console.ReadLine();

    switch (selecao)
    {
        case "1":
            Console.WriteLine(" ===== Deposito ===== ");
            Console.Write("Digite o Valor do deposito: ");
            decimal valorDeposito = decimal.Parse(Console.ReadLine());
            saldo += valorDeposito; // saldo = saldo + valor; 
            Console.Write("Deposito realizado com sucesso!");
            break;
        case "2":
            Console.WriteLine(" ===== Sacar ===== ");
             Console.Write("Digite o Valor do saque: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine());
            if (saldo < valorSaque)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                saldo = saldo - valorSaque; //saldo -= valorSaque;
                Console.WriteLine("Saque realizado com sucesso! ");
            }
            break;
        case "3":
            Console.WriteLine(" ===== Ver Saldo ===== ");
            Console.WriteLine($"Seu saldo é de: {saldo:C2}");
            break;
        case "4":
            Console.WriteLine(" ===== Sair ===== ");
            break;

        default:
            Console.WriteLine(" ===== Opção inválida ===== ");
            break;

    }
}

*/

// Revisão da aula, fazendo de cabeça para validar meu entendimento
// Crie um sistema que:
// Exibe um menu com opções:
// Depositar
// Sacar
// Ver saldo
// Sair
// O menu deve aparecer pelo menos uma vez.
// O saldo não pode ficar negativo.
// O usuário deve conseguir fazer várias operações até escolher sair.


// 1 preciso criar uma exibicao de menu 
// 2 preciso conseguir fazer o menu repetir enquanto a pessoa não escolher sair 
// 3 preciso criar logica para depositar valor na conta 
// 4 preciso criar logica para sacar valor, não permitir saque > saldo 


// using System.Collections;
// using System.Linq.Expressions;

/// 1 preciso criar uma exibicao de menu 
/// 2 preciso conseguir fazer o menu repetir enquanto a pessoa não escolher sair 
/// 3 preciso criar logica para depositar valor na conta 
/// 4 preciso criar logica para sacar valor, não permitir saque > saldo 

String menuCx = ""; // Estamos declarando que temos uma string "menu"
decimal saldo = 0; // Declaramos que temos um decimal "saldo" para que a aplicação posso seguir e armazenar a informação;

while ( menuCx != "4") // aqui dizemos que enquanto o menu não for 4, continue...
{
    Console.WriteLine("\n=== Bem-vindo ao Terminal de Auto Atendimento RDC === \nDigite uma das opções: "); // apenas mensagem na tela e opções!
    Console.WriteLine("1. Depósito"); // apenas mensagem na tela e opções!
    Console.WriteLine("2. Saque"); // apenas mensagem na tela e opções!
    Console.WriteLine("3. Saldo"); // apenas mensagem na tela e opções!
    Console.WriteLine("4. Sair"); // apenas mensagem na tela e opções!

    menuCx = Console.ReadLine(); // Aqui armazenamos a opção selecionada pelo cliente para executar a "função" a seguir:

    switch (menuCx) // declaramos que temos multiplas escolhas;
    {
        case "1": // declaramos que essa é a opção 1
            Console.WriteLine($"=== 1. Depósito ==="); //apresentamos um texto
            Console.WriteLine($"Informe o valor do depósito: "); // questionamos para coletar a informação
            decimal qntDeposito = decimal.Parse(Console.ReadLine()); // informamos o tipo de informação e pedimos para armazenar como qntDeposito.
            saldo += qntDeposito; // aqui estamos somando o saldo anterior mais o depositado;
            Console.WriteLine($"O valor depositado foi {qntDeposito}! \nSeu novo saldo é de {saldo}!"); // aqui validamos o valor depositado + saldo total, usando o \n para quebrar uma linha.
            break;

        case "2": // declaramos que essa é a opção 2
            Console.WriteLine($"=== 2. Saque ==="); //apresentamos um texto
            Console.WriteLine($"Informe o valor de saque: "); // questionamos para coletar a informação
            decimal qntSaque = decimal.Parse(Console.ReadLine()); // informamos o tipo de informação e pedimos para armazenar como qntDeposito.
            
            saldo = saldo - qntSaque; // aqui estamos subtraindo o valor do saldo anterior;
            Console.WriteLine($"O valor de saque foi {qntSaque}! \nSeu novo saldo é de {saldo}!"); // aqui validamos o valor depositado + saldo total, usando o \n para quebrar uma linha.
            break;
    }



}

