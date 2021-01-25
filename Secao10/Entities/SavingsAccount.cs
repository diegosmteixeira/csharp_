namespace Secao10.Entities
{
    sealed class SavingsAccount : Account
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

        public sealed override void Withdraw(double amount)  //sealed = essa operação não pode ser sobrescrita novamente em uma outra subclasse
        {
            base.Withdraw(amount); //chamando a regra da superclasse (opcional)
            Balance -= 2.0;
        }
    }
}
