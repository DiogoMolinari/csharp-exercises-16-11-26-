class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o nome do titular da conta:");
        string accountHolder = Console.ReadLine();

        Console.WriteLine("Informe o saldo atual:");
        double bankBalance = double.Parse(Console.ReadLine());

        AccountBank account = new AccountBank();

        account.setAccountHolder(accountHolder);
        account.setBankBalance(bankBalance);

        Console.WriteLine("\n");
        Console.WriteLine("Dados da conta:");
        Console.WriteLine(account);

        Console.WriteLine("\n");
        Console.WriteLine("Informe um valor para depositar:");
        double depositValue = double.Parse(Console.ReadLine());

        account.Deposit(depositValue);

        Console.WriteLine("\n");
        Console.WriteLine("Informe um valor para sacar:");
        double takeOutValue = double.Parse(Console.ReadLine());

        account.TakeOut(takeOutValue);

        Console.WriteLine("\n");
        Console.WriteLine("Saldo atualizado:");
        account.ShowBalance();

        Console.WriteLine("\n");
        Console.WriteLine("Informações finais da conta:");
        Console.WriteLine(account);
    }
}