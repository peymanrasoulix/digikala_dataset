//Peyman rasouli -- digikala dataset
using Digikala1.Model;
using Digikala1.Operations;
using locker;
using orcity;


datasetorganiz dataor = new datasetorganiz();
lockkeyboard yn = new lockkeyboard();
string q;
do
{
    string address = @"F:\digikala\orders.csv";

    DigikalaContext context = new DigikalaContext(address);

    DigikalaOperation op = new DigikalaOperation(context.digikalas);

    lockkeyboard lk = new lockkeyboard();


    Console.WriteLine("WHAT DO YOU NEED? \n " + " PRICE BY ORDER (PRESS O) \n " +
                      "TOTAL PRICE BY CUSTOMER (PRESS C) \n TOTAL PRICE BY ITEM PRESS(I)" +
                      "\n TOTAL PRICE BY TIME (PRESS T) \n TOTAL PRICE BY CITY (PRESS Y)");
    string x = lk.menulocker();


    switch (x)
    {
        case "o" or "O":
            Console.WriteLine("ENTER ID_ORDER");
            int o = lk.keyboardnumberlocker();

            Console.WriteLine(op.priceSalesByorder(o));

            break;

        case "c" or "C":
            Console.WriteLine("ENTER ID_CUSTOMER");
            int c = lk.keyboardnumberlocker();

            Console.WriteLine(op.SumSalesBycustomer(c));

            break;


        case "i" or "I":
            Console.WriteLine("ENTER ID_ITEM");
            int i = lk.keyboardnumberlocker();

            Console.WriteLine(op.sumSalesByitem(i));

            break;


        case "t" or "T":
            Console.WriteLine("ENTER DATE");
            int t = lk.keyboardnumberlocker();

            Console.WriteLine(op.SumSalesByYear(t));

            break;


        case "y" or "Y":
            Console.WriteLine("ENTER CITY (FARSI)");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(op.SumSalescity_name(y));

            break;

        default:
            throw new Exception("INVALID CHARACTER");

    }
    Console.WriteLine("DO YOU WANT TRY AGAIN ? (Y) OR (N)");
    q = lk.keyboardYESORNOlocker();

} while (q.ToLower() == "y");

Console.WriteLine("DO YOU WANT TO ORGANIZ DATASET BY CITY ? (Y) OR (N)");
string g = yn.keyboardYESORNOlocker();

if (g.ToLower() != "n")
    dataor.cityextractor();


Console.WriteLine("HAVE NICE DAY");
