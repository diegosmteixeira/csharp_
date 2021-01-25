﻿namespace Secao10.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //chamando a regra da superclasse (opcional)
            Balance -= 2.0;
        }
    }
}