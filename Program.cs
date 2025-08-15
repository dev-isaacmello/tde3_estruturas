Console.OutputEncoding = System.Text.Encoding.UTF8;

double saldo = 1000;
int option;
do
{
    Console.WriteLine("Bem-vindo ao caixa tchê:");
    Console.WriteLine(" ");
    Console.WriteLine("1 - Ver Saldo");
    Console.WriteLine("2 - Depositar");
    Console.WriteLine("3 - Sacar");
    Console.WriteLine("0 - Sair");
    Console.WriteLine(" ");
    Console.Write("O que tu quer fazer hoje: ");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Clear();
            Console.WriteLine($"seu saldo é: R${saldo:F2}");
            break;
        case 2:
            Console.Write("Quanto tu quer depositar? ");
            double deposito = double.Parse(Console.ReadLine());
            if (deposito < 0 || deposito > 1000000)
            {
                Console.WriteLine("Depósito inválido. O valor deve ser positivo.");
                Console.Clear();
                continue;
            }

            saldo += deposito;
            Console.WriteLine($"feito, teu novo saldo é {saldo:F2}");
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("Quanto tu quer sacar? ");
            double saque = double.Parse(Console.ReadLine());
            if (saque < 0 || saque > saldo)
            {
                Console.WriteLine("Saque inválido. O valor deve ser positivo e não pode exceder o saldo.");
            }
            else
            {
                saldo -= saque;
                Console.WriteLine($"Saque realizado com sucesso! Teu novo saldo é {saldo:F2}");
            }
            Console.Clear();
            break;
        case 0:
            Console.WriteLine("Obrigado por usar o caixa tchê! Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.Clear();
            continue;
    }
} while (option != 0);