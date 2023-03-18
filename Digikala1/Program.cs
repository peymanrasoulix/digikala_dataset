//peyman rasouli -- digikala dataset

using Digikala1.Model;
using Digikala1.Operations;

string address = @"C:\src\orders.csv";

DigikalaContext context = new DigikalaContext(address);

DigikalaOperation op = new DigikalaOperation(context.digikalas);
 Console.WriteLine(op.SearchByUser(637880));
LockKeyboard lk = new LockKeyboard();