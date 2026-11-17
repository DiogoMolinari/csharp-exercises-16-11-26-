public abstract class AccountBank
{
    public int NumberAccount { get; set; }
    public double BankBalance { get; set; }

    public virtual void Deposit(double depositValue)
    {
        BankBalance += depositValue;
        Console.WriteLine($"O depósito foi efetuado com sucesso. Seu saldo atual é de {BankBalance} reais.");
    }
    public virtual void ToTakeOut(double takeOutValue)
    {
        BankBalance -= takeOutValue;
        Console.WriteLine($"O saque foi efetuado com sucesso. Seu saldo atual é de {BankBalance} reais.");
    }
    public virtual void ToTransfer(double transferValue, string name)
    {
        BankBalance -= transferValue;
        Console.WriteLine($"A transferência para {name} no valor de {transferValue} foi efetuada com sucesso!");
    }
    public virtual void ToPay(double payValue)
    {
        BankBalance -= payValue;
        Console.WriteLine($"Sua conta, no valor de {payValue} foi paga com sucesso!");
    }
}