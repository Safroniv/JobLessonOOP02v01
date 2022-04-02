using System;

namespace JobLessonOOP02Part04v01
{
    public class BankAccount
    {
        private int _accountOfBank;
        private double _ballanceAccountOfBank =500.00;
        private TypeAccountOfBank typeAccountOfBank=TypeAccountOfBank.debet;


        public BankAccount(double ballance) 
        { 
            _accountOfBank = GenerateNumberAccount();
            _ballanceAccountOfBank = ballance;
        }
        public BankAccount(TypeAccountOfBank typeAccount)
        {
            _accountOfBank = GenerateNumberAccount();
            typeAccountOfBank = typeAccount;
        }
        public BankAccount(double ballance, TypeAccountOfBank typeAccount)
        {
            _accountOfBank = GenerateNumberAccount();
            _ballanceAccountOfBank = ballance;
            typeAccountOfBank = typeAccount;
        }
 
        public static int generateAccBank = 000_000_100_000;
        public static int GenerateNumberAccount()
        {
            int numAcc = generateAccBank;
            numAcc++;
            generateAccBank = numAcc;
            return generateAccBank;
        }
        public void GetInfo()
        {
            Console.WriteLine(
                $"Банковский счёт пользователя: # {_accountOfBank} " + "\n" +
                $"Количество средств на счёте пользователя: {_ballanceAccountOfBank} руб." + "\n" +
                $"Тип счёта: {typeAccountOfBank} " + "\n" +
                $"=========================================================");
        }
    }
}
