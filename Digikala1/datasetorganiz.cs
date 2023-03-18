using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Digikala1.Model;

namespace orcity
{
    class datasetorganiz
    {
        string address = @"F:\digikala\orders.csv";
        private string line;
        public string cityextractor()
        {
            List<string> cities = new List<string>();

            using (StreamReader srreader = new StreamReader(address))
            {
                while (!srreader.EndOfStream)
                {
                    line = srreader.ReadLine();
                    cities.Add(Regex.Replace(line, @"(\d|\.|,|:|-| )+", ""));



                    var nonduplicatecitys = cities.Distinct();

                    foreach (string city in nonduplicatecitys)
                    {
                        using (StreamWriter strwriter = new StreamWriter(@"F:\digikala\cities\" + city + ".csv"))
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
