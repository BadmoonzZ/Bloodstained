using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textcopier2
{
    class Generate
    {

        public static void CreateSeed()
        {
            string vanillafile = "Base\\base.json";
            string modfile = "PB_DT_DropRateMaster.json";

            string spoilerlog = "spoiler.txt";
            string flagslabel = "";

            string vanillacraft = "Base\\basecraft.json";
            string modcraftfile = "PB_DT_CraftMaster.json";

            string vanillashop = "Base\\baseshop.json";
            string modshopfile = "PB_DT_ItemMaster.json";

            string vanillaquest = "Base\\basequest.json";
            string modquestfile = "PB_DT_QuestMaster.json";

            string vanillaroom = "Base\\baseroom.json";
            string modroomfile = "PB_DT_RoomMaster.json";

            string vanillaUI = "Base\\baseUI.json";
            string modUIfile = "PBSystemStringTable.json";

            string vanillaShardmaster = "Base\\baseshardmaster.json";
            string modshardmasterfile = "PB_DT_ShardMaster.json";

            //create an array of strings for each line in the base files
            string[] arrLine = File.ReadAllLines(vanillafile);
            string[] crafterLine = File.ReadAllLines(vanillacraft);
            string[] shopLine = File.ReadAllLines(vanillashop);
            string[] questLine = File.ReadAllLines(vanillaquest);
            string[] roomLine = File.ReadAllLines(vanillaroom);
            string[] UILine = File.ReadAllLines(vanillaUI);
            string[] shardmasterLine = File.ReadAllLines(vanillaShardmaster);


            //get a seed from the GUI, or generate one if null.
            if (Globals.seednumber == 0)
            {
                Random unsuppliedseednumber = new Random();
                Globals.seednumber = unsuppliedseednumber.Next(100000, 10000000);
            }

            Random rndshard = new Random(Globals.seednumber);
            string recordseednumber = Globals.seednumber.ToString();



            //create a spoiler log header
            List<string> spoilerarray = new List<string>();
            spoilerarray.Add(" --Spoiler Log--");
            spoilerarray.Add(" seed number: " + recordseednumber);
            spoilerarray.Add("");



            //*********************************************************
            //
            // now for enemy shard rando
            //
            //*********************************************************

            //create a list that has all of the shards.
            List<string> fulllistofshards = ShardList.GenerateShardList();

            //Create a list with all enemies drop tables
            List<EnemyDropTable> listofenemies = ShardRandomizer.CreateEnemyList();

            string revenantstoreshard = ""; //temp fix to make revenant not have two different shards

            if (Globals.shuffleShardsOn == true)
            {

                //add one blank back to the full list of shards then randomize the list
                fulllistofshards.Add("None");
                fulllistofshards = fulllistofshards.OrderBy(i => rndshard.Next()).ToList();

                //guarantee a movement shard to an early enemy.  (this also forces shortcut on craftwork)  //this may also remove a shard. need to check.
                CheckLogic.BasicEarlyShardPlacement(fulllistofshards, rndshard);


                //ensures the 100 cannon morte has the same shard as regular cannon morte.
                List<EnemyDropTable> cannonmorte100 = new List<EnemyDropTable>();
                cannonmorte100.Add(ShardRandomizer.CannonMorte100);
                int indexofcannonmorte = listofenemies.FindIndex(a => a.FriendlyName == "Cannon Morte");
                cannonmorte100[0].ShardId = listofenemies[indexofcannonmorte].ShardId;


                int rev2index = listofenemies.FindIndex(a => a.FriendlyName == "Revenant 2");
                revenantstoreshard = listofenemies[rev2index].ShardId;
                int rev1index = listofenemies.FindIndex(a => a.FriendlyName == "Revenant");
                listofenemies[rev2index].ShardId = listofenemies[rev1index].ShardId;


                //write the files
                spoilerarray.Add("");
                ShardRandomizer.WriteShardsToDataTable(listofenemies, arrLine, spoilerarray);
                ShardRandomizer.WriteShardsToDataTable(cannonmorte100, arrLine, spoilerarray);



                flagslabel += "SHAs";
            }
            else
            {
                spoilerarray.Add("");
                spoilerarray.Add("Enemy shards set to default.");
                spoilerarray.Add("");
                flagslabel += "SHAv";
            }


            //create and write a list of everything that was not assigned
            List<string> unplacedshards = new List<string>();
            spoilerarray.Add("");
            spoilerarray.Add("Unassigned:");
            unplacedshards.Add(revenantstoreshard);
            for (int i = listofenemies.Count(); i < fulllistofshards.Count() ; i++)
            {
                unplacedshards.Add(fulllistofshards[i]);
                if (Globals.shuffleShardsOn == true)
                { spoilerarray.Add(fulllistofshards[i]); }
            }
            spoilerarray.Add("");
            spoilerarray.Add("");


            //*******************************************************
            //
            // now for enemy drops rando
            //
            //*******************************************************

            if (Globals.shuffleDropsOn == true)
            {
                //generate a list of enemy drop tables
                List<EnemyDropTable> EnemyDrops = new List<EnemyDropTable>();
                EnemyDrops = EnemyDropList.GenerateEnemyDropList();

                //shuffle the list ID number
                EnemyDropShuffle.ShuffleEnemies(EnemyDrops, rndshard);

                //write the list items to the base file. the lines will be written based on the ID number.
                EnemyDropShuffle.WriteEnemyDrops(EnemyDrops, arrLine, spoilerarray);

                flagslabel += "Ds";
            }
            else
            {
                spoilerarray.Add("");
                spoilerarray.Add("Enemy drops set to default.");
                spoilerarray.Add("");
                flagslabel += "Dv";
            }


            //*******************************************************
            //
            // now for chest rando
            //
            //*******************************************************

            if (Globals.shuffleChestOn == true)
            {

                //start by getting two lists of all chests in the normal game.  One to shuffle, and another for comparison.
                List<TreasureChest> ShuffledChestsList = new List<TreasureChest>();
                ShuffledChestsList = ChestRandomizer.CreateChestList();
                List<TreasureChest> SpoilerChestsList = new List<TreasureChest>();
                SpoilerChestsList = ChestRandomizer.CreateChestList();

                //now check our shuffled list to see if Zangetsuto is in a dumb place and reshuffle until fixed.
                ShuffledChestsList = CheckLogic.BasicZangetsutoPlacement(ShuffledChestsList, rndshard);



                //create a spoiler. for each chest, write the base chestname then the shuffled item.
                for (int i = 0; i < ChestShuffle.seed17791IDs.Count(); i++)
                {
                    spoilerarray.Add(SpoilerChestsList[i].ChestName + ": " + ShuffledChestsList[i].ChestId.ToString() + " " + ShuffledChestsList[i].RareItemId);
                }//this needs to be redone.  somehow it has lik 10% failure rate on reporting...
                spoilerarray.Add(""); //white space

                //then write to the json
                //find the line number, the i th treasure chest, and write to the json array
                for (int i = 0; i < ChestShuffle.seed17791IDs.Count(); i++)
                {
                    ChestShuffle.WriteTreasureChest(ChestShuffle.FindJsonWriteNumber(ChestShuffle.seed17791IDs[i]), ShuffledChestsList[i], arrLine);
                }


                flagslabel += "Cs";
            }
            else
            {
                spoilerarray.Add("");
                spoilerarray.Add("Chests set to default Seed 17791");
                spoilerarray.Add("");
                flagslabel += "Cv";
            }


            //*******************************************************
            //
            // now for shop rando
            //
            //*******************************************************

            if (Globals.shuffleShopOn == true)
            {

                //create a list of all line numbers that have an item that can go in the shop
                List<int> shopProduced = ShopRandomizer.GetLineNumbers();

                //shuffle the list so that the items are no longer in the same order
                shopProduced = shopProduced.OrderBy(i => rndshard.Next()).ToList();

                //now take that shuffled list and write it to the json
                ShopRandomizer.WriteShop(shopProduced, rndshard, shopLine, spoilerarray);


                //then write the files
                File.WriteAllLines(modshopfile, shopLine);

                flagslabel += "Ss";
            }
            else
            {
                spoilerarray.Add("");
                spoilerarray.Add("Shops set to default.");
                spoilerarray.Add("");
                flagslabel += "Sv";
            }


            //*******************************************************
            //
            // now for craft rando
            //
            //*******************************************************


            if (Globals.shuffleCraftOn == true)
            {

                //start by formatting the original file to contain zero craftables.
                CrafterRandomizer.BlankDefaultCrafter(crafterLine);


                //then write the entire modifed array into a new file: modcraftfile
                File.WriteAllLines(modcraftfile, crafterLine);


                //create a list that contains all of the items in the game, then randomize it.
                List<string> listofitems = ItemList.GenerateItemList();
                listofitems = listofitems.OrderBy(i => rndshard.Next()).ToList();

                spoilerarray.Add(listofitems.Count.ToString());
                spoilerarray.Add(""); //whitespace


                //give specific item numbers to modify
                CrafterRandomizer.WriteCrafterShuffle(0, 73, "None", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(74, 81, "ArmsRecipe003", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(81, 85, "ArmsRecipe004", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(85, 96, "ArmsRecipe005", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(96, 101, "ArmsRecipe007", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(101, 109, "ArmsRecipe009", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(109, 111, "ArmsRecipe012", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(111, 123, "ArmsRecipe018", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(123, 138, "ArmsRecipe019", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(138, 152, "ArmsRecipe020", rndshard, listofitems, modcraftfile, spoilerarray);

                //bullets
                CrafterRandomizer.WriteCrafterShuffle(128, 155, "BalletRecipe001", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(155, 160, "BalletRecipe002", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(160, 162, "BalletRecipe003", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(162, 163, "BalletRecipe004", rndshard, listofitems, modcraftfile, spoilerarray);

                //healing items
                CrafterRandomizer.WriteCrafterShuffle(163, 165, "ItemRecipe001", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(165, 168, "ItemRecipe002", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(168, 172, "ItemRecipe003", rndshard, listofitems, modcraftfile, spoilerarray);

                //individual acquisitions
                CrafterRandomizer.WriteCrafterShuffle(172, 175, "Circlet", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(175, 177, "Silver", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(177, 180, "Ring", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(180, 181, "Crystalscale", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(181, 182, "Silkdress", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(181, 182, "Dragonscales", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(182, 183, "Clystal", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(183, 184, "Platinum", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(184, 185, "Felt", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(185, 186, "WindFeathers", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(186, 188, "Lerajecloth", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(188, 189, "Gamiginhoof", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(189, 192, "Buerfur", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(192, 193, "DemonCloth", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(193, 195, "MonkeyFur", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(195, 196, "Cotton", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(196, 197, "Headband", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(197, 198, "Beastberet", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(198, 199, "Betelgeuse", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(199, 200, "BeastKiller", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(200, 201, "Aimur", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(198, 199, "ShingoGempo", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(199, 200, "ShiroTorujiro", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(200, 201, "Dragonshoes", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(201, 202, "Toyshoes", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(202, 203, "BattleBoots", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(203, 204, "Miserikorde", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(204, 205, "RemoteDart", rndshard, listofitems, modcraftfile, spoilerarray);

                //16bit & 32bit
                CrafterRandomizer.WriteCrafterShuffle(205, 206, "CrystalSword", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(206, 207, "CrystalSword2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(207, 208, "WhipsOfLightDarkness", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(208, 209, "WhipsOfLightDarkness2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(209, 210, "ShieldWeapon", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(210, 211, "ShieldWeapon2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(211, 212, "DeathBringer", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(212, 213, "DeathBringer2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(213, 214, "IcePillarSpear", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(214, 215, "IcePillarSpear2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(216, 217, "SacredSword", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(217, 218, "SacredSword2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(218, 219, "XrossBrade", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(219, 220, "XrossBrade2", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(220, 221, "BradeOfEU", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(221, 222, "BradeOfEU2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(222, 223, "TrustMusket", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(223, 224, "TrustMusket2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(224, 225, "ChargeWideEnd", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(225, 226, "ChargeWideEnd2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(226, 227, "LoveOfFairyDragon", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(227, 228, "LoveOfFairyDragon2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(228, 229, "StickOfMagiGirl", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(229, 230, "StickOfMagiGirl2", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(230, 231, "DrillWideEnd", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(231, 232, "DrillWideEnd2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(232, 233, "CoolShoesOfMrNarita", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(233, 234, "CoolShoesOfMrNarita2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(234, 235, "IceSlewShoes", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(235, 236, "IceSlewShoes2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(236, 237, "LightSaber", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(237, 238, "LightSaber2", rndshard, listofitems, modcraftfile, spoilerarray);

                CrafterRandomizer.WriteCrafterShuffle(238, 239, "JodoSwordLight", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(239, 240, "JodoSwordLight2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(240, 241, "SpearCutDownAside", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(241, 242, "SpearCutDownAside2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(242, 243, "PoisonSpikeShoes", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(243, 244, "PoisonSpikeShoes2", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(244, 245, "PetrifactionSword", rndshard, listofitems, modcraftfile, spoilerarray);
                CrafterRandomizer.WriteCrafterShuffle(245, 246, "PetrifactionSword2", rndshard, listofitems, modcraftfile, spoilerarray);

                //now do we do another loop for everything that you can't craft
                //or do wehave to?  are there really 220 uncraftable materials?


                //also do this for shards.  First create a list and have it comprise of the unused shards plus some extra shards.
                List<string> shardstocraft = new List<string>();
                shardstocraft = CrafterRandomizer.FindCraftableShards(unplacedshards, fulllistofshards, rndshard);


                List<string> shardsasingredients = CrafterRandomizer.FindUnusedShardsAsCraftingMats(shardstocraft, fulllistofshards, rndshard);

                //then write the 12 shards to the crafter json.
                CrafterRandomizer.WriteCraftedShards(shardstocraft, shardsasingredients, listofitems, modcraftfile, spoilerarray);



                //and finally end the file...
                CrafterRandomizer.WriteLastLine(modcraftfile, listofitems, spoilerarray);

                flagslabel += "Cr";
            }
            else
            {
                spoilerarray.Add("");
                spoilerarray.Add("Crafter set to default.");
                spoilerarray.Add("");
                flagslabel += "Cv";
            }
            

            //**********************************************************
            //*
            //*quest shuffle
            //*
            //**********************************************************

            if (Globals.shuffleQuestsOn == true)
            {
                spoilerarray.Add(""); //whitespace
                QuestRandomizer.MurdersSimpleRandom(rndshard, questLine, spoilerarray);

                spoilerarray.Add("");
                QuestRandomizer.SusieSimpleRandom(rndshard, questLine, spoilerarray);

                spoilerarray.Add("");
                QuestRandomizer.AbigailSimpleRandom(rndshard, questLine, spoilerarray);
                spoilerarray.Add("");

                //then write the entire modifed array into a new file: modquestfile
                File.WriteAllLines(modquestfile, questLine);

                flagslabel += "Qs";
            }
            else
            {
                spoilerarray.Add("");
                spoilerarray.Add("Quests set to default.");
                spoilerarray.Add("");
                flagslabel += "Qv";
            }


            //leave farming alone for now
            //leave benjiman alone for now

            //leave susie inputs alone
            //leave abigal inputs alone

            //refine the inputs


            //**********************************************************
            //*
            //*save warp shuffle
            //*
            //**********************************************************

            if (Globals.shullfeSaveWarpOn == true)
            {

                //generate a list of how many saves and warps you want.
                List<string> roomshelperlist = SaveWarp.Buildroomshelperlist(SaveWarp.roomswarpcount, SaveWarp.roomswarpcount, SaveWarp.roomsloadcount);
                //randomize the list
                roomshelperlist = roomshelperlist.OrderBy(i => rndshard.Next()).ToList();

                if (SaveWarp.modeselection == 1 || SaveWarp.modeselection == 3)
                {
                    spoilerarray.Add("room warps - safe "); //whitespace
                    SaveWarp.WriteShuffling(SaveWarp.safeSaveWarps, roomshelperlist, roomLine, spoilerarray);
                    spoilerarray.Add(""); //whitespace
                }
                if (SaveWarp.modeselection == 2 || SaveWarp.modeselection == 4)
                {
                    spoilerarray.Add("room warps - no logic"); //whitespace
                    SaveWarp.WriteShuffling(SaveWarp.unsafeSaveWarps, roomshelperlist, roomLine, spoilerarray);
                    spoilerarray.Add(""); //whitespace
                }

                File.WriteAllLines(modroomfile, roomLine);

                flagslabel += "Ws";

            }
            else
            {
                spoilerarray.Add("");
                spoilerarray.Add("Save Warps set to default.");
                spoilerarray.Add("");
                flagslabel += "Wv";
            }

            //**********************************************************
            //*
            //*shard stats
            //*
            //**********************************************************

            if (Globals.nerfCharge == true)
            {
                shardmasterLine[2909] = "      \"minGradeValue\": 5.0,";  //quarter aquastream
                shardmasterLine[3750] = "      \"minGradeValue\": 11.0,";  //quarter voidray
                shardmasterLine[4110] = "      \"minGradeValue\": 17.5,";  //quarter bolide
                shardmasterLine[4530] = "      \"minGradeValue\": 11.5,";  //quarter tis ro

                File.WriteAllLines(modshardmasterfile, shardmasterLine);
            }
            else
            {
                //
            }



            //**********************************************************
            //*
            //*enemy stats
            //*
            //**********************************************************

            //code

            //**********************************************************
            //*
            //*UI changes
            //*
            //**********************************************************

            UILine[147] = "    \"SYS_SEN_Menu_RandomSeed\": \"Seed # {0}" + " Pak: " + recordseednumber + "\",";

            //UILine[157] = "    \"SYS_SEN_RandomizerSelect_EnterSeed\": \"Did you enter 17791\",";

            UILine[648] = "    \"TUTORIAL_START\": \"Begin a new game." + " Seed: " + recordseednumber + "\",";
            UILine[649] = "    \"TUTORIAL_RESUME\": \"Resume this game where you left off." + " Seed: " + recordseednumber + "\",";

            File.WriteAllLines(modUIfile, UILine);


            //**********************************************************
            //*
            //*finally write the new file and spoiler log
            //*
            //**********************************************************

            //then write the entire modified array into a new file
            File.WriteAllLines(modfile, arrLine);

            //and write the spoiler list into a new file
            if (Globals.writeSpoilerLog == true)
            {
                string[] spoilerconvert = spoilerarray.ToArray();
                spoilerlog = "Output\\" + recordseednumber + "_" + flagslabel + "_" + spoilerlog;
                File.WriteAllLines(spoilerlog, spoilerconvert);
            }

            //**********************************************************
            //*
            //*now that files are written, let's compile the pak file
            //*
            //**********************************************************

            //takes the seed number, and the files you are modifying, then does the work to create a mod.pak file
            GeneratePak.Generate(recordseednumber, modfile, modcraftfile, modshopfile, modquestfile, modroomfile, modUIfile, modshardmasterfile);
        }
    }
}
