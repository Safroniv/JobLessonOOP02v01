using System;

namespace JobLessonOOP02Part01v01
{
    public class BankAccount
    {
        private int accountOfBank;
        private int ballanceAccountOfBank;
        private TypeAccountOfBank _typeAccountOfBank;


        public int AccountOfBank
        {
            get { return this.accountOfBank; }
            set { this.accountOfBank = value; }
        }
        public int BallanceAccountOfBank
        {
            get { return this.ballanceAccountOfBank; }
            set { this.ballanceAccountOfBank = value; }
        }
        public TypeAccountOfBank TypeAccountOfBank       
        {
            get { return this._typeAccountOfBank; }
            set { this._typeAccountOfBank = value;}
        }
public void GetInfo()
        {
            Console.WriteLine($"Банковский счёт пользователя: # {AccountOfBank} " + "\n" +
            $"Количество средств пользователя: {BallanceAccountOfBank} " + "\n" +
            $"Тип счёта: {TypeAccountOfBank} ");
        }
    }
}
