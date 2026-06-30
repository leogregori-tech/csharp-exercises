internal class BankAccount
{
    public int AccountNumber { get; private set; }
    public string HolderName { get; set; }
    public double Balance { get; private set; }

    public BankAccount(int accountNumber, string holderName) {
        AccountNumber = accountNumber;
        HolderName = holderName;
    }

    public BankAccount(int accoutNumber, string holderName, double valueInitialDeposit) : this (accoutNumber, holderName)
    {
        Deposit(valueInitialDeposit);
    }

    public void Deposit(double depositValue)
    {
        Balance += depositValue;
    }

    public void Withdrawal(double withdrawalValue)
    {
        double withdrawalTax = 5.0;
        Balance -= withdrawalValue;
        Balance -= withdrawalTax;
    }

    public override string ToString()
    {
        return $"Account {AccountNumber}, Holder: {HolderName}, Balance: $ {Balance:F2}";
    }
}