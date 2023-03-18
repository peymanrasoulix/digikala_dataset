using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digikala1.Operations
{
    class LockKeyboard
    {
        private string input;
        public string LockKeyboradYN()
        {
            Console.WriteLine("Do you want to continue? press y, for stop enter n:");
            do
            {
                input = Console.ReadKey(true).KeyChar.ToString();

            } while (input.ToLower() != "y" && input.ToLower() != "n");

            return input;
        }
    }
}
