public class CheckingAccount : AccountBank
{
    public double AccountLimit { get; set; }

    
    public void CalculateLimit()
    {
        if (BankBalance > 0)
        {
            AccountLimit = 0;
        }
        else
        {
            AccountLimit = BankBalance * 3;
        }
       
    }

}

