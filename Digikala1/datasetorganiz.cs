using Digikala1.Model;

namespace digi
{
    class dataset
    {
        string address = @"C:\orders.csv";
        private string line;
        public string cityextractor()
        {
            List<string> cityes = new List<string>();

            using (StreamReader srreader = new StreamReader(address))
            {
                while (!srreader.EndOfStream)
                {
                    line = srreader.ReadLine();
                    cityes.Add(Regex.Replace(line, @"(\d|\.|,|:|-| )+", ""));



                    var nonduplicatecitys = cityes.Distinct();

                    foreach (string city in nonduplicatecitys)
                    {
                        using (StreamWriter strwriter = new StreamWriter(@"C:\digikala\cities\" + city + ".csv"))
                        {

                            strwriter.WriteLine();

                        }
                    }
                }
            }
            return line;
        }

    }
}
