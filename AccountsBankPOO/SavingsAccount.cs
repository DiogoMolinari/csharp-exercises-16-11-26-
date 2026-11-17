public class SavingsAccount : AccountBank
{
    public override void ToTakeOut(double takeOutValue)
    {
        BankBalance = BankBalance - (takeOutValue * 1.05);
        Console.WriteLine($"O saque da poupança foi efetuado com sucesso. Seu saldo atual é de {BankBalance} reais.");
    }
}
