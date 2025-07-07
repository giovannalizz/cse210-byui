namespace FinalProject
{
    public class BankAccount
    {
        private string _accountHolder;
        private decimal _balance;

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            _accountHolder = accountHolder;
            _balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public string GetAccountHolder()
        {
            return _accountHolder;
        }
    }
}
