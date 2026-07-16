// Crie um sistema que:
// Exibe um menu com opções:
// Depositar
// Sacar
// Ver saldo
// Sair
// O menu deve aparecer pelo menos uma vez.
// O saldo não pode ficar negativo.
// O usuário deve conseguir fazer várias operações até escolher sair.


/// 1 preciso criar uma exibicao de menu 
/// 2 preciso conseguir fazer o menu repetir enquanto a pessoa não escolher sair 
/// 3 preciso criar logica para depositar valor na conta 
/// 4 preciso criar logica para sacar valor, não permitir saque > saldo 


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