using System;

namespace JobLessonOOP02Part02v01
{
    public class BankAccount
    {
        public int AccountOfBank { get; set; } = GenerateNumberAccount();
        public int BallanceAccountOfBank { get; set; }
        public TypeAccountOfBank TypeAccountOfBank { get; set; }

        public static int generateAccBank = 0;
        public static int GenerateNumberAccount() 
        {
            int numAcc = generateAccBank;
            numAcc++;
            generateAccBank = numAcc;
            return generateAccBank;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Банковский счёт пользователя: # {AccountOfBank} " + "\n" +
            $"Количество средств пользователя: {BallanceAccountOfBank} " + "\n" +
            $"Тип счёта: {TypeAccountOfBank} ");
        }
    }
}
