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
        }

        //move more functtions here

        //list of items
        public static List<string> CreateListOfItems()
        {


            List<string> listofitems = new List<string>
            {
                //
                "Tunic",
                "Skinbreastplate",
                "Countrydress",
                "Copperbreastplate",
                "Chemisedress",
                "Scalearmor",
                "Ironbreastplate",
                "Brigandine",
                "IronMansApron",
                "KungFuBest",
                "Teadress",
                "Chainmail",
                "Beastleather",
                "Maturedress",
                "Shovelarmorsarmor",
                "LamellarArmor",
                "CrusadeArmor",
                "Steelbreastplate",
                "RidingHabit",
                "DuelBrest",
                "Silverbreastplate",
                "Assassinvest",
                "Featherrobe",
                "VoronezDress",
                "Cureus",
                "Crystalscale",
                "BreastplateofAguilar",
                "DragonScale",
                "Goldbreastplate",
                "SpikeBreast",
                "Silkdress",
                "GloriousBreast",
                "ShiningBreast",
                "Ashinbacostume",
                "Caracilis",
                "Crimsondress",
                "ImperialArmor",
                "Shieldless",
                "Coronationdress",
                "Valkyriedress",
                "AriesHorns",
                "Headband",
                "PirateTriangleCap",
                "DurahanMaherm",
                "Circlet",
                "Garbohat",
                "Santacap",
                "Beastberet",
                "CatEars",
                "CowboyHat",
                "WolfHood",
                "Circletoffire",
                "Icecirclet",
                "Thunderscirclet",
                "FeatherCrown",
                "BraveBeret",
                "Crowhat",
                "GadgetBand",
                "SilverTiara",
                "Magushat",
                "Cutebeastberet",
                "BunnyEars",
                "Dentistshat",
                "Maidheadband",
                "Westernhat",
                "ribbon",
                "Flightcapoftraveler",
                "HermitsBeret",
                "KitsuneMask",
                "DemonHorns",
                "ElderTiara",
                "Recyclehat",
                "Pleiades",
                "ValkyrieTiara",
                "HumptyDumpty",
                "LoveOfBenki",
                "Plan9FOSpace",
                "Mega64Head",
                "Muffler",
                "Turbinemuffler",
                "Batwing",
                "Outlinestyle",
                "Made-to-order",
                "Usagimuffler",
                "FaerieScarf",
                "Sendomuffler",
                "Firemuffler",
                "TalismanScarf",
                "OvertheRainbow",
                "Elfearcap",
                "Eyeglasses",
                "Enlargedglasses",
                "Horuseyes",
                "sunglasses",
                "Bottleglasses",
                "Measurementglasses",
                "Gebelsglasses",
                "Stonemask",
                "Crowmask",
                "DanceMask",
                "Breathingforcedmask",
                "NoseEyeglasses",
                "Transformationmask",
                "OfudaTalisman",
                "HeyI’mGrump",
                "I’mNotSoGrump",
                "AKindaFunnyMask",
                "BigMustache",
                "PlagueDoctorFace",
                "The-BazMask",
                "RustedRing",
                "Ring",
                "Necklace",
                "Safering",
                "UnicornRing",
                "Flamering",
                "Icering",
                "Thunderring",
                "Criticalring",
                "AssassinsRing",
                "LethalityRing",
                "Walkerking",
                "Cursering",
                "Striderbelt",
                "Silvermanring",
                "RoseRing",
                "SkullNecklace",
                "Moonring",
                "WeightedRing",
                "Speedstar",
                "CutpursesRing",
                "PlunderersRing",
                "Goldmanring",
                "Riskring",
                "DemonNecklace",
                "Adversityring",
                "Blackbelt",
                "Gamblersring",
                "WarlocksNecklace",
                "RingofSolomon",
                //
                "Alkhahest",
                "Sulfur",
                "Saltpeter",
                "Mercury",
                "Sulfate",
                "Gunpowder",
                "Ectoplasm",
                "Bronze",
                "Iron",
                "Obsidian",
                "Steel",
                "Silver",
                "DamascusSteel",
                "Mithril",
                "Platinum",
                "Clystal",
                "Gold",
                "Hihiirokane",
                "Orichalcum",
                "Hemp",
                "Cotton",
                "Felt",
                "Silk",
                "Leather",
                "Halite",
                "ElmLumber",
                "OakLumber",
                "WalnutLumber",
                "MahoganyLumber",
                "CypressLumber",
                "Ruby",
                "Sapphire",
                "Emerald",
                "Diamond",
                "Bixbite",
                "Alexandrite",
                "8BitCoin",
                "16BitCoin",
                "32BitCoin",
                "Medal022",
                "Recklesslimb",
                "SharpRazor",
                "DevilBookPaperStrip",
                "deathBringerDebris",
                "Mimicchairdebris",
                "MonsterBirdTears",
                "Cyhyraethtear",
                "Lamastutear",
                "Giantratteeth",
                "Batfang",
                "DemonDogFang",
                "Ivory",
                "Devilsfang",
                "Gusionfang",
                "Marbasfang",
                "Gieremundfang",
                "Wolfclaw",
                "Dragonclaw",
                "Apenail",
                "Chicomecoatlhorn",
                "Gaaphorn",
                "Gamiginhoof",
                "Glashtynhoof",
                "MeltedBone",
                "Dragonbone",
                "Knightbone",
                "Bloodybone",
                "MeltingSkull",
                "Jeneralskull",
                "Warriorskull",
                "Bloodyskull",
                "Mimicshell",
                "Dethtrapshell",
                "CannonDebris",
                "Gargoyledebris",
                "Gamiginhair",
                "Glashtynhair",
                "ManeLion",
                "Marbasmane",
                "MonsterBirdHair",
                "ThunderbirdFeathers",
                "WindFeathers",
                "Haagentifeather",
                "BatFeather",
                "Toadwing",
                "Gaapwing",
                "Giantrattail",
                "DevilRoyalTail",
                "Lilimtail",
                "Lamastutail",
                "Lilimear",
                "Dineseawing",
                "Tytaniawing",
                "FairyPowder",
                "TytaniaPoisonedNeedle",
                "Dragonscales",
                "Abyssguardianbastard",
                "DemonCloth",
                "Assasincloth",
                "Lerajecloth",
                "Ninjacloth",
                "DemonDogSkin",
                "MonkeyFur",
                "Buerfur",
                "Wolfmanfur",
                "Decarabialeather",
                "DevilBookLeather",
                "Decimaleather",
                "Silverwolffur",
                "Gusionfur",
                "Poisontoadeye",
                "Evileye",
                "SeekerEye",
                "DevilRoyalEyeball",
                "ToadHeart",
                "BelialHeart",
                "EligosHeart",
                "AbyssguardianHeart",
                "MurmurHeart",
                "Toadfluid",
                "Misteriousfluid",
                //
                "Potion",
                "HighPotion",
                "ExPotion",
                "Ether",
                "HighEther",
                "ExEther",
                "Mithridate",
                "HolyWater",
                "Stonethaw",
                "Poison",
                "Waystone",
                "Panacea",
                "FaerieMedicine",
                "FaerieElixir",
                "FaerieAllheal",
                "FaeriePanacea",
                "SeedCorn",
                "SeedRice",
                "SeedPotato",
                //
                "KungFuShoes",
                "BattleBoots",
                "KillerBoots",
                "Toyshoes",
                "Assaultsollette",
                "Rabbitboots",
                "Dragonshoes",
                "Hermesshoes",
                "Decapitator",
                "CoolShoesOfMrNarita",
                "CoolShoesOfMrNarita2",
                "CoolShoesOfMrNarita3",
                "IceSlewShoes",
                "IceSlewShoes2",
                "IceSlewShoes3",
                "PoisonSpikeShoes",
                "PoisonSpikeShoes2",
                "PoisonSpikeShoes3",
                "Knife",
                "Baselard",
                "Kukuri",
                "PoisonKukri",
                "Swordbreaker",
                "ManGauche",
                "Calnwenan",
                "Mandaupasar",
                "Rapier",
                "Epe",
                "Stinger",
                "Miserikorde",
                "Cazilk",
                "Juwuse",
                "CrystalSword",
                "CrystalSword2",
                "CrystalSword3",
                "ShortSword",
                "LongSword",
                "WolfBalt",
                "Halper",
                "invisible",
                "Mulgres",
                "Redumbrella",
                "Burtgang",
                "Flagarach",
                "Hoffdo",
                "Dineslave",
                "Florenberg",
                "Armas",
                "Caradoborg",
                "Liddyl",
                "HuntedBrad",
                "Broadsword",
                "SwordWhip",
                "BradBlingerLv1",
                "ShieldWeapon",
                "ShieldWeapon2",
                "ShieldWeapon3",
                "XrossBrade",
                "XrossBrade2",
                "XrossBrade3",
                "BradeOfEU",
                "BradeOfEU2",
                "BradeOfEU3",
                "LightSaber",
                "LightSaber2",
                "LightSaber3",
                "JodoSwordLight",
                "JodoSwordLight2",
                "JodoSwordLight3",
                "SpearCutDownAside",
                "SpearCutDownAside2",
                "SpearCutDownAside3",
                "ClockSowrd",
                "LoveOfPizza",
                "KongSword",
                "SwordOfTheMushroom",
                "PowerSword",
                "SilverAndBlackSword",
                "DungeonNightSword",
                "EvilTheSword",
                "ValkyrieSword",
                "Mace",
                "Morgenstern",
                "McAutil",
                "Yagurushi",
                "Aimur",
                "Charwell",
                "Mistrutein",
                "StickOfMagiGirl",
                "StickOfMagiGirl2",
                "StickOfMagiGirl3",
                "RemoteDart",
                "OracleBlade",
                "WalalSoulimo",
                "ValralAltar",
                "Claymore",
                "Perex",
                "Flanders",
                "OutsiderKnightSword",
                "Valdish",
                "SteamFlatWideEnd",
                "Gram",
                "Gambanttain",
                "Lohengrin",
                "Sherdar",
                "LightningBolt",
                "Karadanda",
                "Durandal",
                "DiesIle",
                "TurmericBasara",
                "Exactor",
                "DeathBringer",
                "DeathBringer2",
                "DeathBringer3",
                "SacredSword",
                "SacredSword2",
                "SacredSword3",
                "ChargeWideEnd",
                "ChargeWideEnd2",
                "ChargeWideEnd3",
                "DrillWideEnd",
                "DrillWideEnd2",
                "DrillWideEnd3",
                "PetrifactionSword",
                "PetrifactionSword2",
                "PetrifactionSword3",
                "Dull",
                "Noda",
                "Tsurumaru",
                "ShiroTorujiro",
                "Lightningoff",
                "OgreWoodenSword",
                "Tadanako",
                //"Swordsman",  //you cant craft or dismantle zangetsuto.  at least not right now.
                "MikazukiMaen",
                "Truesixteenthnight",
                "Spear",
                "Reims",
                "Partizan",
                "Excavator",
                "Triplet",
                "ShingoGempo",
                "Coldgrindingsaw",
                "Aradovar",
                "Nibbleheim",
                "GunungNil",
                "Gayalsals",
                "IcePillarSpear",
                "IcePillarSpear2",
                "IcePillarSpear3",
                "LoveOfFairyDragon",
                "LoveOfFairyDragon2",
                "LoveOfFairyDragon3",
                "Awhip",
                "Ibarakaswhip",
                "FireWhip",
                "BlackRockHell",
                "Snakebyte",
                "BeastKiller",
                "Albireo",
                "Andromeda",
                "WhipsOfLightDarkness",
                "WhipsOfLightDarkness2",
                "WhipsOfLightDarkness3",
                "Musketon",
                "Branderbus",
                "Tanegasima",
                "Trador",
                "Carvalin",
                "Betelgeuse",
                "Ursula",
                "Adrastea",
                "TrustMusket",
                "TrustMusket2",
                "TrustMusket3",
                //
                "Softpoint",
                "Hollowpoint",
                "ArmorPiercing",
                "Firebullet",
                "Icebullet",
                "ThunderRounds",
                "SilverBullets",
                "WeaponbaneRounds",
                "ShieldbaneRounds",
                "PoisonRounds",
                "PetrifyingRounds",
                "CurseRounds",
                "Shotshell",
                "CriticalBullet",
                "DiamondBullets",
                //
            };

        return listofitems;

        }

        //
        //takes two lists.  one list of shards that need to be placed, and a second list to fill in the remainder.
        //needs error checking added to see if the two lists are the wrong size...
        public static List<string> FindCraftableShards(List<string> unplacedshards, List<string> fillershards)
        {
            List<string> combinedlist = unplacedshards;
            // find count of unplaced shards, then do 12- x, then find x shards from filler that are != to current list.
            int x = 12 - unplacedshards.Count();
            if (x < 0)
            { x = 0; };

            //need to randomize fillershards
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

        public static List<string> FindUnusedShardsAsCraftingMats(List<string> craftingshards, List<string> fillershards)
        {
            List<string> materials = new List<string>();

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
        public static void WriteCraftedShards(List<string> listtowrite , List<string> ingredients, List<string> itemingredients , string jsontowrite)
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
                    w.WriteLine("      \"Ingredient2Id\": \"" + itemingredients[i] + "\",");  //needs to be randomized
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
