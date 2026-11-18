public class CheckingAccount : AccountBank
{
    public double AccountLimit;


    public void CalculateLimit()
    {
        if (BankBalance < 0)
        {
            AccountLimit = 0;
        }
        else
        {
            AccountLimit = BankBalance * 3;
        }
    }
    public override bool Deposit(double depositValue)
    {
        if (base.Deposit(depositValue))
        {
            CalculateLimit();
            return true;
        }
        return false;

    }

    public string ToTakeOut(double value)
    {
        if (value >= 0)
        {
            return "Valor inválido";
        }
        else
        {
            if(value > this.BankBalance + AccountLimit)
            {
                return "Saldo insuficiente";
            }
            else
            {
                BankBalance -= value;
                CalculateLimit();
            }
        }
        return $"Seu saldo é de R$ {this.BankBalance} e o limite é deR${this.AccountLimit}. Totalizando RS{this.AccountLimit + BankBalance}.";
    }

    public string ToPay(double value)
    {
        return ToTakeOut(value);
    }
}



