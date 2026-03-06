using Bank;

Console.Write("Enter owner name: ");
string name = Console.ReadLine();

Console.Write("Enter account number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter starting balance: ");
decimal balance = Convert.ToDecimal(Console.ReadLine());


BankAccount acc = new BankAccount(name, number, (double)balance);
Console.WriteLine(acc.GetBallance());

Console.Write("Enter deposit money: ");
decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
acc.Deposit((double)depositAmount);
Console.WriteLine(acc.GetBallance());

Console.Write("Enter withdraw money: ");
decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
acc.Withdraw((double)withdrawAmount);


