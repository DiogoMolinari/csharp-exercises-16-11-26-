public class AccountBank
{
    public string AccountHolder;
    public double BankBalance;

    public void setAccountHolder(string accountHolder)
    {
        AccountHolder = accountHolder;
    }

    public void setBankBalance(double bankBalance)
    {
        BankBalance = bankBalance;
    }

    public string getAccountHolder()
    {
        return AccountHolder;
    }
    public double getBankBalance()
    {
        return BankBalance;
    }

    public override string ToString()
    {
        return $"Titular da conta: {this.AccountHolder}\n Saldo da conta: {this.BankBalance}";
    }

    public void Deposit(double valueToDeposit)
    {
        BankBalance += valueToDeposit;
    }

    public void TakeOut (double valueToTakeOut)
    {
        BankBalance-= valueToTakeOut;
    }

    public void ShowBalance()
    {
        Console.Write($"O seu saldo é de R${BankBalance} reais.");
    }
}


