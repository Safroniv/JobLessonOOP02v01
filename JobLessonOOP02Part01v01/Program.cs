namespace JobLessonOOP02Part01v01
{
    class Program
    {
        static void Main()
        {
            BankAccount myBankAccount = new();
            myBankAccount.AccountOfBank = 10;
            myBankAccount.BallanceAccountOfBank = 10000;
            myBankAccount.TypeAccountOfBank = TypeAccountOfBank.current;
            myBankAccount.GetInfo();
            
        }
    }
}
