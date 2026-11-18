public abstract class AccountBank
{
    public int NumberAccount { get; set; }
    public double BankBalance { get; set; }

    public virtual bool Deposit(double depositValue)
    {
        if (depositValue > 0)
        {
            BankBalance += depositValue;
            return true;
        }
        return false;

    }
    public string ToTakeOut(double takeOutValue)
    {
        if (takeOutValue <= 0)
        {
            return "Valor inválido";
        }
        else
        {
            if (takeOutValue > BankBalance)
            {
                return "Saldo insuficiente";
            }
            BankBalance -= takeOutValue;
            return BankBalance.ToString();
        }


    }


    public string ToPay(double payValue)
    {
        return ToTakeOut(payValue);
    }


    public string ToTransfer(AccountBank destination, double transferValue)
    {
        string result = ToTakeOut(transferValue);

        if (result == "Valor inválido" || result == "Saldo insuficiente")
        {
            return result;
        }

        destination.Deposit(transferValue);

        return "Transferência realizada com sucesso!";
    }

}
