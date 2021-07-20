using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class CrafterRandomizer
    {
        //this will prime the crafter file to remove all crafts by setting all craftables to ShipMap. for some reason that I don't understand
        public static void BlankDefaultCrafter(string[] crafterLine)
        {

            for (int i = 3; i < 6078; i = i + 25)
            {
                crafterLine[i - 1] = "    \"Key\": \"ShipMap\",";
                crafterLine[i + 2] = "      \"CraftItemId\": \"ShipMap\",";
            }
            for (int i = 9573; i < 10240; i = i + 25)  //remove bullets and craftable shards
            {
                crafterLine[i - 1] = "    \"Key\": \"ShipMap\",";
                crafterLine[i + 2] = "      \"CraftItemId\": \"ShipMap\",";
            }

            //this makes it so the original last item is no longer the end of the json table.
            crafterLine[19620] = "  },";
            crafterLine[19621] = "  {";
        }

        public static void WriteLastLine(string modcraftfile , List<string> listofitems ,  List<string> spoilerarray)
        {
            using (StreamWriter w = File.AppendText(modcraftfile))
            {
                //w.WriteLine("  },");
                //w.WriteLine("  {");
                w.WriteLine("    \"Key\": \"" + listofitems[468] + "\",");
                w.WriteLine("    \"Value\": {");
                w.WriteLine("      \"Type\": \"ECraftType::Craft\",");
                w.WriteLine("      \"CraftItemId\": \"" + listofitems[468] + "\",");
                w.WriteLine("      \"CraftValue\": 1,");
                w.WriteLine("      \"RankMin\": 0,");
                w.WriteLine("      \"RankMax\": 0,");
                w.WriteLine("      \"Ingredient1Id\": \"BatFeather\",");
                w.WriteLine("      \"Ingredient1Total\": 1,");
                w.WriteLine("      \"Ingredient2Id\": \"MeltedBone\",");
                w.WriteLine("      \"Ingredient2Total\": 1,");
                w.WriteLine("      \"Ingredient3Id\": \"None\",");
                w.WriteLine("      \"Ingredient3Total\": 0,");
                w.WriteLine("      \"Ingredient4Id\": \"None\",");
                w.WriteLine("      \"Ingredient4Total\": 0,");
                w.WriteLine("      \"OpenKeyRecipeID\": \"None\",");
                w.WriteLine("      \"openCondition\": \"EPBCraftRequirement::None\",");
                w.WriteLine("      \"openParameter\": 0,");
                w.WriteLine("      \"firstTimeBonusSpecialEffectId\": \"None\",");
                w.WriteLine("      \"FirstBonusType\": [],");
                w.WriteLine("      \"FirstBonusValue\": [],");
                w.WriteLine("      \"Alkhahest\": 1");  //yes the last item is always 1.  you are welcome.
                w.WriteLine("    }");
                w.WriteLine("  }");
                w.WriteLine("]");
            }
            spoilerarray.Add(468 + " - " + listofitems[468] + " - " + 1 + " - requires " + "None" + " - crafting costs : " + "BatFeather , MeltedBone");
        }

        //move more functtions here

     

        //takes two lists.  one list of shards that need to be placed, and a second list to fill in the remainder.
        //needs error checking added to see if the two lists are the wrong size...
        public static List<string> FindCraftableShards(List<string> unplacedshards, List<string> fillershards , Random rndshard)
        {
            List<string> combinedlist = unplacedshards;
            // find count of unplaced shards, then do 12- x, then find x shards from filler that are != to current list.
            int x = 12 - unplacedshards.Count();
            if (x < 0)
            { x = 0; };

            //might not need to randomize fillershards
            fillershards = fillershards.OrderBy(i => rndshard.Next()).ToList();

            bool alreadyexists = false;

            for (int i = 0; i < x; i++)
            { 
                //check if fillershard[i] is already in the list
                alreadyexists = combinedlist.Contains(fillershards[i]);
                while (alreadyexists == true)
                {
                    fillershards.RemoveAt(i);
                    alreadyexists = combinedlist.Contains(fillershards[i]);
                }
                combinedlist.Add(fillershards[i]);
            }
            return combinedlist;
        }

        public static List<string> FindUnusedShardsAsCraftingMats(List<string> craftingshards, List<string> fillershards , Random rndshard)
        {
            List<string> materials = new List<string>();
            
            //need to randomize fillershards
            fillershards = fillershards.OrderBy(i => rndshard.Next()).ToList();
            fillershards.Remove("None");

            for (int i = 0; i < 12; i++)
            {
                //make sure it doesn't require itself.
                while (craftingshards[i] == fillershards[i])
                {
                    fillershards.RemoveAt(i); 
                }

                materials.Add(fillershards[i]);

            }
            return materials;
        }

        //
        //takes the list of shards you want to become craftable and a list of shards as ingredients and writes them to the crafter json
        public static void WriteCraftedShards(List<string> listtowrite , List<string> ingredients, List<string> itemingredients , string jsontowrite , List<string> spoilerlog)
        {
            for (int i = 0; i < 12; i++)
            {
                using (StreamWriter w = File.AppendText(jsontowrite))
                {
                    //w.WriteLine("  },");
                    //w.WriteLine("  {");
                    w.WriteLine("    \"Key\": \"" + listtowrite[i] + "\",");
                    w.WriteLine("    \"Value\": {");
                    w.WriteLine("      \"Type\": \"ECraftType::Craft\",");
                    w.WriteLine("      \"CraftItemId\": \"" + listtowrite[i] + "\",");
                    w.WriteLine("      \"CraftValue\": 1,");
                    w.WriteLine("      \"RankMin\": 0,");
                    w.WriteLine("      \"RankMax\": 0,");
                    w.WriteLine("      \"Ingredient1Id\": \"" + ingredients[i] +"\",");
                    w.WriteLine("      \"Ingredient1Total\": 1,");
                    w.WriteLine("      \"Ingredient2Id\": \"" + itemingredients[i] + "\",");
                    w.WriteLine("      \"Ingredient2Total\": 1,");
                    w.WriteLine("      \"Ingredient3Id\": \"None\",");
                    w.WriteLine("      \"Ingredient3Total\": 0,");
                    w.WriteLine("      \"Ingredient4Id\": \"None\",");
                    w.WriteLine("      \"Ingredient4Total\": 0,");
                    w.WriteLine("      \"OpenKeyRecipeID\": \"" + ingredients[i] + "\",");
                    w.WriteLine("      \"openCondition\": \"EPBCraftRequirement::None\",");
                    w.WriteLine("      \"openParameter\": 0,");
                    w.WriteLine("      \"firstTimeBonusSpecialEffectId\": \"None\",");
                    w.WriteLine("      \"FirstBonusType\": [],");
                    w.WriteLine("      \"FirstBonusValue\": [],");
                    w.WriteLine("      \"Alkhahest\": 0");
                    w.WriteLine("    }");
                    w.WriteLine("  },");
                    w.WriteLine("  {");
                }
                spoilerlog.Add(listtowrite[i] + " unlocked by: " + ingredients[i]);
            }
        }


        //this will take a list of items, assign a random item, a random material cost and alk cost.
        //first supply an lower and upper value i for the amount of items in this category
        //supply the requirement for unlocking the recipie
        //supply the seednumber
        //supply a list of all the items you wish to be included.
        //supply the json we are writing
        //supple the spoiler we are writing
        public static void WriteCrafterShuffle(int ivalue, int ivalueupper, string bookreq, Random craftingrng, List<string> itemslist, string filetoedit, List<string> forspoiler)
        {
            Random craftingmats = craftingrng;
            List<string> listofitems = itemslist;

            for (int i = ivalue; i < ivalueupper; i++)
            {

                int rngalkhahest = craftingmats.Next(1, 19);

                int firstingredient = craftingmats.Next(0, listofitems.Count()); // lets pick a random item, and the make sure we didn't pick ourself.
                while (firstingredient == i)
                {
                    firstingredient = craftingmats.Next(0, listofitems.Count());
                }
                int firstquantity = craftingmats.Next(1, 5);  //get a random 1-4
                if (firstquantity > 1) { firstquantity = craftingmats.Next(1, 5); } // if you get 1, keep it.  otherwise roll again
                if (firstquantity > 2) { firstquantity = craftingmats.Next(1, 5); } // if you get 1 or 2 keep it.  otherwise roll again.
                if (firstquantity > 3) { firstquantity = craftingmats.Next(1, 5); } // if you get 1 2 or 3 keep it.  otherwise roll again. should obfuscate the % well enough.


                //2nd
                int checkforsecond = craftingmats.Next(0, 5);  //80% chance for a second material
                int secondingredient = craftingmats.Next(0, listofitems.Count());
                string s = "";
                string s2 = "";
                if (checkforsecond == 0)
                {
                    //we're done
                    s = "      \"Ingredient2Id\": \"None\",";
                    s2 = "0";
                }
                else
                {
                    while (secondingredient == i || secondingredient == firstingredient)
                    {
                        secondingredient = craftingmats.Next(0, listofitems.Count());
                    }
                    s = "      \"Ingredient2Id\": \"" + listofitems[secondingredient] + "\",";
                    s2 = "1";
                }

                //3rd
                int checkforthird = craftingmats.Next(0, 2); // 50% chance for a third if the second exists
                int thirdingredient = craftingmats.Next(0, listofitems.Count());
                string s3 = "";
                string s4 = "";
                if (checkforsecond == 0 || checkforthird == 0)
                {
                    s3 = "      \"Ingredient3Id\": \"None\",";
                    s4 = "0";
                }
                else
                {
                    while (thirdingredient == i || thirdingredient == firstingredient || thirdingredient == secondingredient)
                    {
                        thirdingredient = craftingmats.Next(0, listofitems.Count());
                    }
                    s3 = "      \"Ingredient3Id\": \"" + listofitems[thirdingredient] + "\",";
                    s4 = "1";
                }

                //4th
                int checkforfourth = craftingmats.Next(0, 2);  //50% for a fourth if the third exists
                int fourthingredient = craftingmats.Next(0, listofitems.Count());
                string s5 = "";
                string s6 = "";
                if (checkforsecond == 0 || checkforthird == 0 || checkforfourth == 0)
                {
                    s5 = "      \"Ingredient4Id\": \"None\",";
                    s6 = "0";
                }
                else
                {
                    while (fourthingredient == i || fourthingredient == firstingredient || fourthingredient == secondingredient || fourthingredient == thirdingredient)
                    {
                        fourthingredient = craftingmats.Next(0, listofitems.Count());
                    }
                    s5 = "      \"Ingredient4Id\": \"" + listofitems[fourthingredient] + "\",";
                    s6 = "1";
                }

                using (StreamWriter w = File.AppendText(filetoedit))
                {
                    //w.WriteLine("  },");
                    //w.WriteLine("  {");
                    w.WriteLine("    \"Key\": \"" + listofitems[i] + "\",");
                    w.WriteLine("    \"Value\": {");
                    w.WriteLine("      \"Type\": \"ECraftType::Craft\",");
                    w.WriteLine("      \"CraftItemId\": \"" + listofitems[i] + "\",");
                    w.WriteLine("      \"CraftValue\": 1,");
                    w.WriteLine("      \"RankMin\": 0,");
                    w.WriteLine("      \"RankMax\": 0,");
                    w.WriteLine("      \"Ingredient1Id\": \"" + listofitems[firstingredient] + "\",");
                    w.WriteLine("      \"Ingredient1Total\": " + firstquantity + ",");
                    w.WriteLine(s);
                    w.WriteLine("      \"Ingredient2Total\": " + s2 + ",");
                    w.WriteLine(s3);
                    w.WriteLine("      \"Ingredient3Total\": " + s4 + ",");
                    w.WriteLine(s5);
                    w.WriteLine("      \"Ingredient4Total\": " + s6 + ",");
                    w.WriteLine("      \"OpenKeyRecipeID\": \"" + bookreq + "\",");
                    w.WriteLine("      \"openCondition\": \"EPBCraftRequirement::None\",");
                    w.WriteLine("      \"openParameter\": 0,");
                    w.WriteLine("      \"firstTimeBonusSpecialEffectId\": \"None\",");
                    w.WriteLine("      \"FirstBonusType\": [],");
                    w.WriteLine("      \"FirstBonusValue\": [],");
                    w.WriteLine("      \"Alkhahest\": " + rngalkhahest); //this does not considre dismantle cost for items not added. I guess they are default then...
                    w.WriteLine("    }");
                    w.WriteLine("  },");
                    w.WriteLine("  {");
                }

                forspoiler.Add(i + " - " + listofitems[i] + " -Alk: " + rngalkhahest + " -- requires " + bookreq + " -- crafting costs : " +
                listofitems[firstingredient] + " (" + firstquantity + ") , " +
                listofitems[secondingredient] + " (" + s2 + ") , " +
                listofitems[thirdingredient] + " (" + s4 + ") , " +
                listofitems[fourthingredient] + " (" + s6 + ") ");
            }
        }
    }
}
