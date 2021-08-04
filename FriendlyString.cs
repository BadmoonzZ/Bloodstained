using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class FriendlyString
    {
        public static List<string> yyy = new List<string>();

        public static List<string> CreateDatabase(string[] inputdatabase)
        {
            List<string> listedDatabase = inputdatabase.ToList();

            yyy = listedDatabase;

            return listedDatabase;
        }

        List<string> mynewlist2 = new List<string>() { };


        public static string Translate(string inputword)
        {
            string outputword = "Database Error";

            int findathing = yyy.IndexOf(inputword);
            if (findathing == -1)
            {
                outputword = "Unable to find name.";
            }
            else
            {
                outputword = yyy[findathing + 1];
            }

            return outputword;
        }
    }
}
