// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace AccessModifierExample
{

    public class BankAccount
    {
        private decimal _balance; // Private: Only accessible within BankAccount
        public string AccountNumber { get; private set; } // Public getter, private setter
        protected string OwnerName; // Accessible within BankAccount and derived classes
        internal string BankName; // Accessible within the same assembly
        protected internal string BranchCode; // Accessible within the same assembly OR derived classes
        private protected string InternalId; // Accessible in the same class and derived class in the same assembly

        public BankAccount(string accountNumber, decimal initialBalance, string ownerName, string bankName, string branchCode)
        {
            AccountNumber = accountNumber;
            _balance = initialBalance;
            OwnerName = ownerName;
            BankName = bankName;
            BranchCode = branchCode;
            InternalId = Guid.NewGuid().ToString();
        }
        
        

       

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }

        public decimal GetBalance() // Public method to access the private balance
        {
            return _balance;
        }
    }
}