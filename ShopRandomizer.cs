using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class ShopRandomizer
    {
        //create a list of all line numbers item that could be placed in the shop
        public static List<int> GetLineNumbers()
        {
            List<int> shopProduced = new List<int>();
            int sizeofentry = 22;

            for (int i = 12; i < 1205;)
            {
                shopProduced.Add(i);
                i = i + sizeofentry;
            }
            for (int i = 1530; i < 2660;)
            {
                shopProduced.Add(i);
                i = i + sizeofentry;
            }
            for (int i = 2702; i < 4337;)  //this includes no purchaseable 8bits
            {
                shopProduced.Add(i);
                i = i + sizeofentry;
            }
            for (int i = 4632; i < 7980;)
            {
                shopProduced.Add(i);
                i = i + sizeofentry;
            }
            for (int i = 8026; i < 11355;) //this includes some non purchasable items such as i am gump
            {
                shopProduced.Add(i);
                i = i + sizeofentry;
            }
            for (int i = 13416; i < 15514;)
            {
                shopProduced.Add(i);
                i = i + sizeofentry;
            }

            return shopProduced;
        }

        // takes the list of index integers generated GetLineNumber and the json file then writes the randomized shop.
        public static void WriteShop(List<int> shopProduced , Random rnd, string[] shopLine , List<string> spoilerarray)
        {
            spoilerarray.Add("");
            spoilerarray.Add("[Shop]");
            //in the shuffled list, check the first 70 items, then write to json the unlock condition based on index
            for (int i = 0; i < 70; i++)
            {
                string appendprice = "";
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"Event_01_001_0000\",";
                if(shopLine[shopProduced[i] - 2] == "      \"sellPrice\": 0,")
                {
                    int newsellprice = rnd.Next(2000,5600);
                    shopLine[shopProduced[i] - 2] = "      \"sellPrice\": " + newsellprice + ",";
                    shopLine[shopProduced[i] - 3] = "      \"buyPrice\": " + newsellprice * 10 + ",";
                    appendprice = "Price adjusted " + newsellprice;
                }
                spoilerarray.Add("base store items = " + shopLine[shopProduced[i] - 10] + " " + appendprice); // write the 70 items
            }
            //look at the next 2 items in list, then change those lines to available after z1
            for (int i = 70; i < 72; i++)
            {
                string appendprice = "";
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"Event_06_001_0000\",";
                if (shopLine[shopProduced[i] - 2] == "      \"sellPrice\": 0,")
                {
                    int newsellprice = rnd.Next(2000, 5600);
                    shopLine[shopProduced[i] - 2] = "      \"sellPrice\": " + newsellprice + ",";
                    shopLine[shopProduced[i] - 3] = "      \"buyPrice\": " + newsellprice * 10 + ",";
                    appendprice = "Price adjusted " + newsellprice;
                }
                spoilerarray.Add("z1 extra items = " + shopLine[shopProduced[i] - 10] + " " + appendprice); // write the two items
            }
            //look at the next 20 items in list, then change those lines to available after train
            for (int i = 72; i < 92; i++)
            {
                string appendprice = "";
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"Event_08_001_0000\",";
                if (shopLine[shopProduced[i] - 2] == "      \"sellPrice\": 0,")
                {
                    int newsellprice = rnd.Next(2000, 5600); //random this
                    shopLine[shopProduced[i] - 2] = "      \"sellPrice\": " + newsellprice + ",";
                    shopLine[shopProduced[i] - 3] = "      \"buyPrice\": " + newsellprice * 10 + ",";
                    appendprice = "Price adjusted " + newsellprice;
                }
                spoilerarray.Add("train items = " + shopLine[shopProduced[i] - 10] + " " + appendprice); // write the 20 post train items
            }
            //look at the rest of the lines in our list and set them to None
            for (int i = 92; i < 580; i++)  //(shopLine.Count()-1)
            {
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"None\",";
            }
        }

    }
}
