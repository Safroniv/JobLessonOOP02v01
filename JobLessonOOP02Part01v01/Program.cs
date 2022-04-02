namespace JobLessonOOP02Part04v01
{
    class Program
    {
        static void Main()
        {
            BankAccount bankAccount1 = new(2000.50);
            bankAccount1.GetInfo();
            BankAccount bankAccount2 = new(TypeAccountOfBank.current);
            bankAccount2.GetInfo();
            BankAccount bankAccount3 = new(50_000_000.00, TypeAccountOfBank.credit);
            bankAccount3.GetInfo();
        }
    }
}
