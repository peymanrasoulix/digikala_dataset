namespace locker
{
    class lockkeyboard
    {
        private string y;
        private string x;
        private int num;
        private ConsoleKeyInfo digree;
        public int keyboardnumberlocker()
        {
          while (true)
            {
              digree = Console.ReadKey(true);
                if (char.IsDigit(digree.KeyChar))
                {
                    num = num*10 +(int)char.GetNumericValue(digree.KeyChar);
                    Console.Write(digree.KeyChar);
                }
                else
                {
                    Console.Beep();
                }
                if (digree.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }               
            }
          return num;
        }

        public string keyboardYESORNOlocker()
        {
            do
            {
                x = Console.ReadKey(true).KeyChar.ToString();

            } while (x.ToLower() != "y" & x.ToLower() != "n");
            return x;
        }
        public string menulocker()
        {
            do
            {
                y = Console.ReadKey(true).KeyChar.ToString();

            } while (y.ToLower() != "y" & y.ToLower() != "o" & y.ToLower() != "c" & y.ToLower() != "i" & y.ToLower() != "t");
            return y;
        }
    }
}
