using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textcopier2
{
    class Program
    {
        static void Main(string[] args)
        {
            string vanillafile = "base.json";
            string modfile = "PB_DT_DropRateMaster.json";
            string spoilerlog = "spoiler.txt";

            string vanillacraft = "basecraft.json";
            string modcraftfile = "PB_DT_CraftMaster.json";

            string vanillashop = "baseshop.json";
            string modshopfile = "PB_DT_ItemMaster.json";

            //create an array of strings for each line in the base files
            string[] arrLine = File.ReadAllLines(vanillafile);
            string[] crafterLine = File.ReadAllLines(vanillacraft);
            string[] shopLine = File.ReadAllLines(vanillashop);

            bool shuffleChestOn = false; //temp toggle so we don't shuffle chests until we are ready.   prob make perm as a flag

            //create a list that has all of the shards.
            List<string> fulllistofshards = ShardList.GenerateShardList();
 

            //get a seed from somewhere, or generate one.
            Random unsuppliedseednumber = new Random();
            //TODO: if importedseednumber == null use an unsuppliedseednumber
            int importedseednumber = unsuppliedseednumber.Next(100000, 1000000);
            string recordseednumber = importedseednumber.ToString();
            Random rndshard = new Random(importedseednumber);


            //create a list which will contain strings to printed into a spoiler log
            List<string> spoilerarray = new List<string>();
            spoilerarray.Add(" --Shard Spoiler Log--");
            spoilerarray.Add(" seed number: " + recordseednumber);
            spoilerarray.Add("");
            //end spoiler log list header

            
            //*********************************************************
            //
            // now for enemy shard rando
            //
            //*********************************************************

            //Create a list with all enemies drop tables
            List<EnemyDropTable> listofenemies = ShardRandomizer.CreateEnemyList();

            //Create a subset list of enemies in the early game
            List<EnemyDropTable> earlyenemieslist = ShardRandomizer.GenerateEarlyEnemiesList(listofenemies);
  

            //randomize the early enemies for logic
            earlyenemieslist = earlyenemieslist.OrderBy(i => rndshard.Next()).ToList();

            //randomize full list of shards.
            //TODO: fulllist of shards should be a CONST and a variable copy should be used here.
            fulllistofshards = fulllistofshards.OrderBy(i => rndshard.Next()).ToList();

            //*****
            //This section needs to be moved to Logic.
            //
            //take the first entry in earlylogicenemies (whatever it is) and assign it one of the 6 main movementshards.
            List<string> mainmovementshards = new List<string>
            {
                "Invert", "Doublejump", "Dimensionshift", "HighJump", "Reflectionray", "Demoniccapture",
            };
            //now shuflle the movement shard list and assign one of them to whatever enemy is first in our earlyenemy list.
            mainmovementshards = mainmovementshards.OrderBy(i => rndshard.Next()).ToList();
            earlyenemieslist[0].ShardId = mainmovementshards[0];

            //find the selected early shard and remove it from the list so it doesn't get placed twice.
            fulllistofshards.Remove(mainmovementshards[0]);

            //search for craftwork and find its id.
            int indexofcraftwork = listofenemies.FindIndex(a => a.FriendlyName == "Craftwork");
            //search for the index of the enemy who has the same name as the enemy we set a move shard too
            int indexofearlymove = listofenemies.FindIndex(a => a.FriendlyName == earlyenemieslist[0].FriendlyName);
            //write our shuffled shardlist to enemydroptable except for craftwork
            for (int i = 0; i < listofenemies.Count(); i++)
            {
                if (i == indexofcraftwork)
                {
                    listofenemies[i].ShardId = "Shortcut";
                }
                else if(i == indexofearlymove)
                {
                    listofenemies[i].ShardId = mainmovementshards[0];

                    spoilerarray.Add(listofenemies[i].FriendlyName + " " + mainmovementshards[0] + " check early move pls");
                }
                else
                {
                    listofenemies[i].ShardId = fulllistofshards[i];
                }

            }
            List<EnemyDropTable> cannonmorte100 = new List<EnemyDropTable>();
            cannonmorte100.Add(ShardRandomizer.CannonMorte100);
            int indexofcannonmorte = listofenemies.FindIndex(a => a.FriendlyName == "Cannon Morte");
            cannonmorte100[0].ShardId = listofenemies[indexofcannonmorte].ShardId;

            //
            //End Logic block in main
            //******

            //write the files
            spoilerarray.Add("");
            ShardRandomizer.WriteShardsToDataTable(listofenemies, arrLine, spoilerarray);
            ShardRandomizer.WriteShardsToDataTable(cannonmorte100, arrLine, spoilerarray);

            //create and write a list of everything that was not assigned
            List<string> unplacedshards = new List<string>();
            spoilerarray.Add("");
            spoilerarray.Add("Unassigned:");
            for (int i = listofenemies.Count(); i < fulllistofshards.Count(); i++)
                {
                unplacedshards.Add(fulllistofshards[i]);
                spoilerarray.Add(fulllistofshards[i]);
                }
            spoilerarray.Add("");
            spoilerarray.Add("");


            //*******************************************************
            //
            // now for enemy drops rando
            //
            //*******************************************************

            //can use the same list of enemies as above
            //need a list of all items
            //shuffle list and write to enemy tables
            //can use a switch or if statement for modes such as 'shuffle' vs 'random'


            //*******************************************************
            //
            // now for chest rando
            //
            //*******************************************************

            List<TreasureChest> ListOfAllChests = new List<TreasureChest>();
            ListOfAllChests = ChestRandomizer.CreateChestList();

            //need to write logic for seed xxxxx
            //will first have to identify and cross refernce every chest in the seed.
            //for example if item normally found in den is in ship, it will now have to be considerd a ship chest for our logic. that chest could have zangetsuto

            //now shuffle the list
            //note that this will put stuff into some of those impossible chests.  fix it later during logic.
            //this method could be better.  this was a simple solution found online on a Unity forum.
            ListOfAllChests = ListOfAllChests.OrderBy(i => rndshard.Next()).ToList();


            //prior to this section we need to manually fill a few specific exceptions: testingredients, villagekeybox, potionmaterial, photoevent, certificationboardevent, benjaminring , z2, 
            // the line number that chests start appearing in the datatable
            // Now take our shuffled listofChests, and write all of them them to the datatable one at a time.
            int lineplaceholder = 907;
            if (shuffleChestOn == true) { 
            WriteTreasureShuffle(lineplaceholder, ListOfAllChests, arrLine); }


            //*******************************************************
            //
            // now for shop rando
            //
            //*******************************************************

            //create a list of all line numbers that have an item that can go in the shop
            List<int> shopProduced = ShopRandomizer.GetLineNumbers();

            //shuffle the list so that the items are no longer in the same order
            shopProduced = shopProduced.OrderBy(i => rndshard.Next()).ToList();

            //now take that shuffled list and write it to the json
            ShopRandomizer.WriteShop(shopProduced , rndshard, shopLine, spoilerarray);


            //then write the files
            File.WriteAllLines(modshopfile, shopLine);


            //*******************************************************
            //
            // now for craft rando
            //
            //*******************************************************

            //start by formatting the original file to contain zero craftables.
            CrafterRandomizer.BlankDefaultCrafter(crafterLine);

            //this makes it so the original last item is no longer the end of the json table.
            crafterLine[19545] = "  },";
            crafterLine[19546] = "  {";


            //then write the entire modifed array into a new file: modcraftfile
            File.WriteAllLines(modcraftfile, crafterLine);


            //create a list that contains all of the items in the game, then randomize it.
            List<string> listofitems = CrafterRandomizer.CreateListOfItems();
            listofitems = listofitems.OrderBy(i => rndshard.Next()).ToList();

            spoilerarray.Add(listofitems.Count.ToString());
            spoilerarray.Add(""); //whitespace

            Random craftingmats = new Random(importedseednumber);  //this is probably unnecessary...

            //give specific item numbers to modify
            CrafterRandomizer.WriteCrafterShuffle(0 , 73 , "None" , craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(74, 81, "ArmsRecipe003", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(81, 85, "ArmsRecipe004", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(85, 96, "ArmsRecipe005", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(96, 101, "ArmsRecipe007", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(101, 109, "ArmsRecipe009", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(109, 111, "ArmsRecipe012", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(111, 123, "ArmsRecipe018", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(123, 138, "ArmsRecipe019", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(138, 152, "ArmsRecipe020", craftingmats, listofitems, modcraftfile, spoilerarray);

            //bullets
            CrafterRandomizer.WriteCrafterShuffle(128, 155, "BalletRecipe001", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(155, 160, "BalletRecipe002", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(160, 162, "BalletRecipe003", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(162, 163, "BalletRecipe004", craftingmats, listofitems, modcraftfile, spoilerarray);

            //healing items
            CrafterRandomizer.WriteCrafterShuffle(163, 165, "ItemRecipe001", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(165, 168, "ItemRecipe002", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(168, 172, "ItemRecipe003", craftingmats, listofitems, modcraftfile, spoilerarray);

            //individual acquisitions
            CrafterRandomizer.WriteCrafterShuffle(172, 175, "Circlet", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(175, 177, "Silver", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(177, 180, "Ring", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(180, 181, "Crystalscale", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(181, 182, "Silkdress", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(181, 182, "Dragonscales", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(182, 183, "Clystal", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(183, 184, "Platinum", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(184, 185, "Felt", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(185, 186, "WindFeathers", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(186, 188, "Lerajecloth", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(188, 189, "Gamiginhoof", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(189, 192, "Buerfur", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(192, 193, "DemonCloth", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(193, 195, "MonkeyFur", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(195, 196, "Cotton", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(196, 197, "Headband", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(197, 198, "Beastberet", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(198, 199, "Betelgeuse", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(199, 200, "BeastKiller", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(200, 201, "Aimur", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(198, 199, "ShingoGempo", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(199, 200, "ShiroTorujiro", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(200, 201, "Dragonshoes", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(201, 202, "Toyshoes", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(202, 203, "BattleBoots", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(203, 204, "Miserikorde", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(204, 205, "RemoteDart", craftingmats, listofitems, modcraftfile, spoilerarray);

            //16bit & 32bit
            CrafterRandomizer.WriteCrafterShuffle(205, 206, "CrystalSword", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(206, 207, "CrystalSword2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(207, 208, "WhipsOfLightDarkness", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(208, 209, "WhipsOfLightDarkness2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(209, 210, "ShieldWeapon", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(210, 211, "ShieldWeapon2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(211, 212, "DeathBringer", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(212, 213, "DeathBringer2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(213, 214, "IcePillarSpear", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(214, 215, "IcePillarSpear2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(216, 217, "SacredSword", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(217, 218, "SacredSword2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(218, 219, "XrossBrade", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(219, 220, "XrossBrade2", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(220, 221, "BradeOfEU", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(221, 222, "BradeOfEU2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(222, 223, "TrustMusket", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(223, 224, "TrustMusket2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(224, 225, "ChargeWideEnd", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(225, 226, "ChargeWideEnd2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(226, 227, "LoveOfFairyDragon", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(227, 228, "LoveOfFairyDragon2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(228, 229, "StickOfMagiGirl", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(229, 230, "StickOfMagiGirl2", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(230, 231, "DrillWideEnd", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(231, 232, "DrillWideEnd2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(232, 233, "CoolShoesOfMrNarita", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(233, 234, "CoolShoesOfMrNarita2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(234, 235, "IceSlewShoes", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(235, 236, "IceSlewShoes2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(236, 237, "LightSaber", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(237, 238, "LightSaber2", craftingmats, listofitems, modcraftfile, spoilerarray);

            CrafterRandomizer.WriteCrafterShuffle(238, 239, "JodoSwordLight", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(239, 240, "JodoSwordLight2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(240, 241, "SpearCutDownAside", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(241, 242, "SpearCutDownAside2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(242, 243, "PoisonSpikeShoes", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(243, 244, "PoisonSpikeShoes2", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(244, 245, "PetrifactionSword", craftingmats, listofitems, modcraftfile, spoilerarray);
            CrafterRandomizer.WriteCrafterShuffle(245, 246, "PetrifactionSword2", craftingmats, listofitems, modcraftfile, spoilerarray);

            //now do we do another loop for everything that you can't craft
            //or do wehave to?  are there really 220 uncraftable materials?

            //also do this for shards.  First create a list and have it comprise of the unused shards plus some extra shards.
            List<string> shardstocraft = new List<string>();
            shardstocraft = CrafterRandomizer.FindCraftableShards(unplacedshards, fulllistofshards);

            //the write to a spoiler which 12 we found.
            //eventually create a spoiler class to take care of all these things.
            for (int i = 0; i < 12; i++)
            {
                spoilerarray.Add(shardstocraft[i] + " *****************");
            }

            List<string> shardsasingredients = CrafterRandomizer.FindUnusedShardsAsCraftingMats(shardstocraft, fulllistofshards);

            //then write the 12 shards to the crafter json.
            CrafterRandomizer.WriteCraftedShards(shardstocraft, shardsasingredients, listofitems , modcraftfile);
            

            //and finally end the file...
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



            //**********************************************************
            //*
            //*save warp shuffle
            //*
            //**********************************************************

            // make alfred warp always a warp
            // keep the other perminant warps warps
            // keep town the same
            // shuffle the rest.  need to get a count first.
            // write to json and write to spoiler

            //**********************************************************
            //*
            //*finally write the new file and spoiler log
            //*
            //**********************************************************

            //then write the entire modified array into a new file
            File.WriteAllLines(modfile, arrLine);

            //and write the spoiler list into a new file
            string[] spoilerconvert = spoilerarray.ToArray();
            spoilerlog = "flags_" + recordseednumber + "_" + spoilerlog;
            File.WriteAllLines(spoilerlog, spoilerconvert);
        }

     
        private static void WriteTreasureShuffle(int linetowrite , List<TreasureChest> treasurelisttowrite , string[] arr)
        {
            int l = linetowrite;
            //i = treasureindex;

            for (int i = 0; i < treasurelisttowrite.Count(); i++)
            {

                arr[l] = "      \"RareItemId\": \"" + treasurelisttowrite[i].RareItemId + "\",";
                arr[l + 1] = "      \"RareItemQuantity\": " + treasurelisttowrite[i].RareItemQuantity + ",";
                arr[l + 2] = "      \"RareItemRate\": " + treasurelisttowrite[i].RareItemRate + ",";
                arr[l + 3] = "      \"CommonItemId\": \"" + treasurelisttowrite[i].CommonItemId + "\",";
                arr[l + 4] = "      \"CommonItemQuantity\": " + treasurelisttowrite[i].CommonItemQuantity + ",";
                arr[l + 5] = "      \"CommonRate\": " + treasurelisttowrite[i].CommonItemRate + ",";
                arr[l + 6] = "      \"RareIngredientId\": \"" + treasurelisttowrite[i].RareIngreditentId + "\",";
                arr[l + 7] = "      \"RareIngredientQuantity\": " + treasurelisttowrite[i].RareIngreditentQuantity + ",";
                arr[l + 8] = "      \"RareIngredientRate\": " + treasurelisttowrite[i].RareIngredientRate + ",";
                arr[l + 9] = "      \"CommonIngredientId\": \"" + treasurelisttowrite[i].CommonIngredientId + "\",";
                arr[l + 10] = "      \"CommonIngredientQuantity\": " + treasurelisttowrite[i].CommonIngredientQuantity + ",";
                arr[l + 11] = "      \"CommonIngredientRate\": " + treasurelisttowrite[i].CommonIngredientRate + ",";
                arr[l + 12] = "      \"CoinType\": \"EDropCoin::" + treasurelisttowrite[i].CoinType + "\",";
                arr[l + 13] = "      \"CoinOverride\": " + treasurelisttowrite[i].CoinOverride + ",";
                arr[l + 14] = "      \"CoinRate\": " + treasurelisttowrite[i].CoinRate + ",";

                //t = t + 1; //go to the next treasure chest
                l = l + 25; //move to the next datatable entry
            }

        }

    }

}
