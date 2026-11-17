public class SalaryAccount : AccountBank
{
    public override void ToTakeOut(double takeOutValue)
    {
        if (takeOutValue > BankBalance)
        {
            Console.WriteLine($"Seu saldo é insuficiente! Você tem um saldo atual de: {BankBalance} reais.");
            return;
        }

        base.ToTakeOut(takeOutValue);
    }

    public override void ToTransfer(double transferValue, string name)
    {
        if (transferValue > BankBalance)
        {
            Console.WriteLine($"Seu saldo é insuficiente! Você tem um saldo atual de: {BankBalance} reais.");
            return;
        }

        base.ToTransfer(transferValue, name);
    }

    public override void ToPay(double payValue)
    {
        if (payValue > BankBalance)
        {
            Console.WriteLine($"Seu saldo é insuficiente! Você tem um saldo atual de: {BankBalance} reais.");
            return;
        }

        base.ToPay(payValue);
    }
}