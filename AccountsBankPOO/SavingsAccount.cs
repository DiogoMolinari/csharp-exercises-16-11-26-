public class SavingsAccount : AccountBank
{
    public string ToTakeOut(double takeOutValue)
    {
       return base.ToTakeOut(takeOutValue * 1.05);
    }
}
