BankAccount account;

Console.Write("Insert the account number: ");
int accountNumber = int.Parse(Console.ReadLine());
Console.Write("Insert the bank account holder: ");
string holderName = Console.ReadLine();
Console.Write("It will be made an initial deposit (y/n)? ");
char answerInitialDeposit = char.Parse(Console.ReadLine());

if (answerInitialDeposit == 'y' || answerInitialDeposit == 'Y')
{
    Console.Write("Insert the initial deposit value: ");
    double valueInitialDeposit = double.Parse(Console.ReadLine());   
    account = new BankAccount(accountNumber, holderName, valueInitialDeposit)
}
else
{
    account = new BankAccount(accountNumber, holderName);
}

Console.WriteLine();
Console.WriteLine("Account data:");
Console.WriteLine(account);

Console.WriteLine();
Console.Write("Insert a value to be deposited: ");
double value = double.Parse(Console.ReadLine());
account.Deposit(value);
Console.WriteLine("Updated account data:");
Console.WriteLine(account);

Console.WriteLine();
Console.Write("Insert a value to be withdrawn: ");
value = double.Parse(Console.ReadLine());
account.Withdrawal(value);
Console.WriteLine("Updated account data:");
Console.WriteLine(account);
