namespace JobLessonOOP02Part02v01
{
    class Program
    {
        static void Main()
        {
            BankAccount myBankAccount = new BankAccount();            
            myBankAccount.BallanceAccountOfBank = 10000;
            myBankAccount.TypeAccountOfBank = TypeAccountOfBank.current;
            myBankAccount.GetInfo();
            
        }
    }
}
