﻿using System;
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

            for (int i = 12; i < 1150;)
            {
                shopProduced.Add(i);
                i = i + 21;
            }
            for (int i = 1461; i < 2540;)
            {
                shopProduced.Add(i);
                i = i + 21;
            }
            for (int i = 2580; i < 4120;)  //this includes no purchaseable 8bits
            {
                shopProduced.Add(i);
                i = i + 21;
            }
            for (int i = 4404; i < 7600;)
            {
                shopProduced.Add(i);
                i = i + 21;
            }
            for (int i = 7644; i < 10825;) //this includes some non purchasable items such as i am gump
            {
                shopProduced.Add(i);
                i = i + 21;
            }
            for (int i = 12789; i < 14794;)
            {
                shopProduced.Add(i);
                i = i + 21;
            }

            return shopProduced;
        }

        // takes the list of index integers generated GetLineNumber and the json file then writes the randomized shop.
        public static void WriteShop(List<int> shopProduced , Random rnd, string[] shopLine , List<string> spoilerarray)
        {
            //in the shuffled list, check the first 70 items, then write to json the unlock condition based on index
            for (int i = 0; i < 70; i++)
            {
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"Event_01_001_0000\",";
                if(shopLine[shopProduced[i] - 2] == "      \"sellPrice\": 0,")
                {
                    int newsellprice = rnd.Next(2000,5600); //random this
                    shopLine[shopProduced[i] - 2] = "      \"sellPrice\": " + newsellprice + ",";
                    shopLine[shopProduced[i] - 3] = "      \"buyPrice\": " + newsellprice * 10 + ",";
                    spoilerarray.Add("Price adjusted " + newsellprice);
                }
                spoilerarray.Add("base store items = " + shopLine[shopProduced[i] - 10]); // write the 70 items
            }
            //look at the next 2 items in list, then change those lines to available after z1
            for (int i = 70; i < 72; i++)
            {
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"Event_06_001_0000\",";
                if (shopLine[shopProduced[i] - 2] == "      \"sellPrice\": 0,")
                {
                    int newsellprice = rnd.Next(2000, 5600); //random this
                    shopLine[shopProduced[i] - 2] = "      \"sellPrice\": " + newsellprice + ",";
                    shopLine[shopProduced[i] - 3] = "      \"buyPrice\": " + newsellprice * 10 + ",";
                    spoilerarray.Add("Price adjusted " + newsellprice);
                }
                spoilerarray.Add("z1 extra items = " + shopLine[shopProduced[i] - 10]); // write the two items
            }
            //look at the next 20 items in list, then change those lines to available after train
            for (int i = 72; i < 92; i++)
            {
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"Event_08_001_0000\",";
                if (shopLine[shopProduced[i] - 2] == "      \"sellPrice\": 0,")
                {
                    int newsellprice = rnd.Next(2000, 5600); //random this
                    shopLine[shopProduced[i] - 2] = "      \"sellPrice\": " + newsellprice + ",";
                    shopLine[shopProduced[i] - 3] = "      \"buyPrice\": " + newsellprice * 10 + ",";
                    spoilerarray.Add("Price adjusted " + newsellprice);
                }
                spoilerarray.Add("train items = " + shopLine[shopProduced[i] - 10]); // write the 20 post train items
            }
            //look at the rest of the lines in our list and set them to None
            for (int i = 92; i < 580; i++)  //(shopLine.Count()-1)
            {
                shopLine[shopProduced[i] - 1] = "      \"Producted\": \"None\",";
            }
        }

    }
}
