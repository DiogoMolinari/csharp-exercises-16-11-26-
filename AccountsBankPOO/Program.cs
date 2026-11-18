/*Exercício 5: Faça um programa que crie uma classe de conta bancária abstrata com as seguintes propriedades: numero, saldo. 
 * Os métodos da conta bancária são: depositar, sacar, transferir e pagar. Existem 3 tipos de conta: corrente, poupança e salário. 
 * A conta corrente possui a propriedade limite, que é sempre definida automaticamente pelo triplo do saldo. 
 * Caso o saldo esteja negativo, o limite é zerado. Na conta poupança todo saque desconta 5% de taxa. Na conta salário, não tem limite nenhum. 
 * Faça um programa que gerencie 3 contas em que o usuário escolhe as 3 contas que quer criar.*/

static AccountBank CreateAccount(int number)
{
    Console.WriteLine("\nEscolha o tipo de conta:");
    Console.WriteLine("1 - Conta Corrente");
    Console.WriteLine("2 - Conta Poupança");
    Console.WriteLine("3 - Conta Salário");

    int option = int.Parse(Console.ReadLine()!);

    AccountBank account;

    switch (option)
    {
        case 1:
            account = new CheckingAccount();
            break;

        case 2:
            account = new SavingsAccount();
            break;

        case 3:
            account = new SalaryAccount();
            break;

        default:
            Console.WriteLine("Opção inválida. Por padrão, sua conta corrente foi criada. Se desejar uma outra conta, podemos criar!");
            account = new CheckingAccount();
            break;
    }

    account.NumberAccount = number;

    Console.Write("Informe o saldo inicial: R$ ");
    account.BankBalance = double.Parse(Console.ReadLine()!);

    if (account is CheckingAccount checking)
    {
        checking.CalculateLimit();
    }

    return account;
}


static AccountBank SelectAccount(
    AccountBank account1,
    AccountBank account2,
    AccountBank account3)
{
    int option;

    do
    {
        Console.WriteLine("\nEscolha a conta:");
        Console.WriteLine($"1 - Conta {account1.NumberAccount}");
        Console.WriteLine($"2 - Conta {account2.NumberAccount}");
        Console.WriteLine($"3 - Conta {account3.NumberAccount}");

        option = int.Parse(Console.ReadLine()!);

    } while (option < 1 || option > 3);

    switch (option)
    {
        case 1: return account1;
        case 2: return account2;
        default: return account3;
    }
}


static string ToTakeOut(AccountBank account, double value)
{
    if (account is CheckingAccount checking)
        return checking.ToTakeOut(value);

    if (account is SavingsAccount savings)
        return savings.ToTakeOut(value);

    return account.ToTakeOut(value);
}


Console.WriteLine("=== CADASTRO DAS CONTAS ===");

AccountBank account1 = CreateAccount(1);
AccountBank account2 = CreateAccount(2);
AccountBank account3 = CreateAccount(3);

int option;

do
{
    Console.WriteLine("\n===== MENU BANCÁRIO =====");
    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Transferir");
    Console.WriteLine("4 - Pagar");
    Console.WriteLine("5 - Consultar saldos");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma operação: ");
    option = int.Parse(Console.ReadLine()!);

    AccountBank selected;
    double value;

    switch (option)
    {
        case 1:
            selected = SelectAccount(account1, account2, account3);

            Console.Write("Valor do depósito: R$ ");
            value = double.Parse(Console.ReadLine()!);

            if (selected.Deposit(value))
                Console.WriteLine("Depósito realizado!");
            else
                Console.WriteLine("Valor inválido.");

            break;


        case 2:
            selected = SelectAccount(account1, account2, account3);

            Console.Write("Valor do saque: R$ ");
            value = double.Parse(Console.ReadLine()!);

            Console.WriteLine(ToTakeOut(selected, value));

            break;


        case 3:
            Console.WriteLine("Conta de origem:");
            AccountBank origin = SelectAccount(account1, account2, account3);

            Console.WriteLine("Conta de destino:");
            AccountBank destination = SelectAccount(account1, account2, account3);

            Console.Write("Valor da transferência: R$ ");
            value = double.Parse(Console.ReadLine()!);

            string result = ToTakeOut(origin, value);

            if (result != "Valor inválido" &&
                result != "Saldo insuficiente")
            {
                destination.Deposit(value);
                Console.WriteLine("Transferência realizada!");
            }
            else
            {
                Console.WriteLine(result);
            }

            break;


        case 4:
            selected = SelectAccount(account1, account2, account3);

            Console.Write("Valor do pagamento: R$ ");
            value = double.Parse(Console.ReadLine()!);

            Console.WriteLine(selected.ToPay(value));

            break;


        case 5:
            Console.WriteLine("\n=== SALDOS ===");

            Console.WriteLine($"Conta {account1.NumberAccount}: R$ {account1.BankBalance}");
            Console.WriteLine($"Conta {account2.NumberAccount}: R$ {account2.BankBalance}");
            Console.WriteLine($"Conta {account3.NumberAccount}: R$ {account3.BankBalance}");

            break;


        case 0:
            Console.WriteLine("Encerrando o programa...");
            break;


        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (option != 0);

