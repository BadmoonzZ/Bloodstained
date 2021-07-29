using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class Bookcase
    {
        public static void BasicHints(string[] BookcaseLine , Random rndshard, 
            string eightbit, string scytheshard, string gremshard, string kuneshard, string abysshard, string gaapshard, string bombshard, string gcannonshard, 
            string burriedsand, string waterchest, string underbridge, string highship, string abovevalac)
        {

            //automate this
            if (burriedsand == "None")
            {
                burriedsand = "Some Money";
            }
            if (waterchest == "None")
            {
                waterchest = "Some Money";
            }
            if (underbridge == "None")
            {
                underbridge = "Some Money";
            }
            if (highship == "None")
            {
                highship = "Some Money";
            }


            string hint01 = "Springball is behind Ridley.";
            string hint02 = "Gebel is not wearing his glasses.  They could be anywhere!";
            string hint03 = "Eastmost peninsula has the secret.";
            string hint04 = "I am Error.";
            string hint05 = "A piece of heart and Hookshot can be found on the west side of Swamp Palace.";
            string hint06 = "Song of Storms can be found by staring into a cow ass.";
            string hint07 = "Doesn't even have accelerator?";
            string hint08 = "The times two dream!\\nThe times two dream!";
            string hint09 = "OD is in the library.";
            string hint10 = "Did you know that reading books during a race can be considered a waste of time?";
            string hint11 = "Did you know that there are 38 bookcases in the game.\\n\\nThere might even be more!";
            string hint12 = "Jass can be found in Desert";
            string hint13 = "Flame Mammoth is weak to Storm Eagle.";
            string hint14 = "Pro Tip: Phantoon is weak to Super Missiles.";
            string hint15 = "Carabosse will sing you a song if you are willing to play some piano for her.";
            string hint16 = "Have you hit the shard yet?";
            string hint17 = "There are many ways to softlock on the Train.\\n\\nHave Zangetsu fall off the train.\\nFail to receive a shard from the Glutton Train.\\nHave a familiar attack Glutton Train in the final phase.\\nZangetsu sometimes will jump up and down instead of following you.";
            string hint18 = "The president can be found in Garden.";
            string hint19 = "Many weapons in this game have a technique that can be used and mastered.";
            string hint20 = "Luminescent Elementals form while loitering atop bovine fauna.";
            string hint21 = "The Richter scale is a numerical expression for the magnitude of the protaganist in the Castlevania series.";
            string hint22 = "Bookcase vaccuum occurs when you accidentally or incidentally press up in the vicinity of a nearby bookcase.";
            string hint23 = "Adventurer's Tip:\\n Know your escape routes.  Sometimes one chest and a poison frog isn't worth it.";
            string hint24 = "Oishiiiiiiiiiiiiiiiiiiiiiiiiiiii\\nScrumptious!\\nHigh Ceeeeeeeeeeeeeee\\n\\nWhat's going on?\\nOh, Miriam is just eating.\\n\\nHigh Ceeeeeeeeeeeeeee\\nHigh Ceeeeeeeeeeeeeee\\nHigh Ceeeeeeeeeeeeeee\\nHigh Ceeeeeeeeeeeeeee";
            string hint25 = "Mithridate!";
            string hint26 = "So what's on this card anyways?\\n\\nWait.\\nWhy is THAT there?!";
            string hint27 = "MEOW MEOW MEOW MEOW\\n  MEOW MEOW MEOW\\n    OH MY GOD";
            string hint28 = "The Bridge of Evil is neither a bridge, nor evil, nor an empire.";
            string hint29 = "The Boots is in Ganon's Tower.\\n\\nWait.\\nShouldn't that be 'are' in Ganon's Tower.\\n\\nNope.  The Boots are progressive.  This is the location of only one of the boots.";
            string hint30 = "Take a ride on the Chair Express.  It could elevate you to new (or maybe old) heights.";
            string hint31 = "Using Bloodsteal on Bloodless is more effective than the names imply.";
            string hint32 = "Stop giving Benjamin Waystones.  You're enabling him.";
            string hint33 = "Kefka can be found at the top of Kefka's Tower.";
            string hint34 = "EEEEEEEEEE... OOOOOOOOOO...\\n\\nWhat is that?\\nThe author must have died while writing this.\\nReally?\\nIf they were dying they wouldn't bother to write EEEEEEEEEE... OOOOOOOOOO..., they'd just say it.\\nPerhaps it was dictated.";


            string ghint01 = "<span size=\\\"30\\\">Bomber Morte has the " + bombshard + " shard.</>";
            string ghint02 = "<span size=\\\"30\\\">" + waterchest + " can be found in an underwater locker.</>";
            string ghint03 = "<span size=\\\"30\\\">" + underbridge + " can be found under a bridge in the Oriental Sorcery Lab.</>";
            string ghint04 = "<span size=\\\"30\\\">" + highship + " can be found up high on the ship.</>";
            string ghint05 = "<span size=\\\"30\\\">Gaap has the " + gaapshard + " shard.</>";
            string ghint06 = "<span size=\\\"30\\\">" + burriedsand + " can be found buried in the sand.</>";
            string ghint07 = "<span size=\\\"30\\\">Gremory has the " + gremshard + " shard.</>";
            string ghint08 = "<span size=\\\"30\\\">KuneKune has the " + kuneshard + " shard.</>";
            string ghint09 = "<span size=\\\"30\\\">Abyssal Dragon has the " + abysshard + " shard.</>";
            string ghint10 = "<span size=\\\"30\\\">Eight Bit Overlord has the " + eightbit + " shard.</>";
            string ghint11 = "<span size=\\\"30\\\">Scythe Mite has the " + scytheshard + " shard.</>";
            string ghint12 = "<span size=\\\"30\\\">Gusian Canon has the " + gcannonshard + " shard.</>";
            string ghint13 = "<span size=\\\"30\\\">" + abovevalac + " can be found above Valac.</>";

            List<string> FakeHints = new List<string>
            {
                hint01, hint02, hint03, hint04, hint05, hint06, hint07, hint08, hint09, hint10,
                hint11, hint12, hint13, hint14, hint15, hint16, hint17, hint18, hint19, hint20,
                hint21, hint22, hint23, hint24, hint25, hint26, hint27, hint28, hint29, hint30,
                hint31, hint32, hint33, hint34,
                ghint01, ghint02, ghint03, ghint04, ghint05, ghint06, ghint07, ghint08, ghint09, ghint10,
                ghint11, ghint12, ghint13
            };
            FakeHints = FakeHints.OrderBy(i => rndshard.Next()).ToList();

            BookcaseLine[399] = "    \"HELP_TXT_003_00\": \"" + FakeHints[0] + " \",";  //ship
            BookcaseLine[400] = "    \"HELP_TXT_003_01\": \"\",";

            BookcaseLine[428] = "    \"ARTS_TXT_013_00\": \"" + FakeHints[1] + " \",";  //ship second save
            BookcaseLine[429] = "    \"ARTS_TXT_013_01\": \"\",";

            BookcaseLine[406] = "    \"ARTS_TXT_002_00\": \"" + FakeHints[2] + " \",";  //halfway house
            BookcaseLine[407] = "    \"ARTS_TXT_002_01\": \"\",";

            BookcaseLine[416] = "    \"ARTS_TXT_007_00\": \"" + FakeHints[3] + " \",";  //Forgotten bookcase
            BookcaseLine[417] = "    \"ARTS_TXT_007_01\": \"\",";

            BookcaseLine[373] = "    \"DIARY_TXT_001_00\": \"" + FakeHints[4] + " \",";  //entrance save
            BookcaseLine[374] = "    \"DIARY_TXT_001_01\": \"\",";

            BookcaseLine[414] = "    \"ARTS_TXT_006_00\": \"" + FakeHints[5] + " \",";  //ghost farm
            BookcaseLine[415] = "    \"ARTS_TXT_006_01\": \"\",";

            BookcaseLine[420] = "    \"ARTS_TXT_009_00\": \"" + FakeHints[6] + " \",";  //before Z1
            BookcaseLine[421] = "    \"ARTS_TXT_009_01\": \"\",";

            BookcaseLine[442] = "    \"ARTS_TXT_020_00\": \"" + FakeHints[7] + " \",";  //after Z1
            BookcaseLine[443] = "    \"ARTS_TXT_020_01\": \"\",";

            BookcaseLine[430] = "    \"ARTS_TXT_014_00\": \"" + FakeHints[8] + " \",";  //first cathedral save
            BookcaseLine[431] = "    \"ARTS_TXT_014_01\": \"\",";

            BookcaseLine[375] = "    \"DIARY_TXT_002_00\": \"" + FakeHints[9] + " \","; //before the barber
            BookcaseLine[376] = "    \"DIARY_TXT_002_01\": \"\",";

            BookcaseLine[444] = "    \"ARTS_TXT_021_00\": \"" + FakeHints[10] + " \","; //before craftwork
            BookcaseLine[445] = "    \"ARTS_TXT_021_01\": \"\",";


            BookcaseLine[448] = "    \"ARTS_TXT_023_00\": \"" + FakeHints[11] + " \",";  //cyreath orientalcathedral
            BookcaseLine[449] = "    \"ARTS_TXT_023_01\": \"\",";

            BookcaseLine[393] = "    \"DIARY_TXT_011_00\": \"" + FakeHints[12] + " \",";
            BookcaseLine[394] = "    \"DIARY_TXT_011_01\": \"\",";  //before z2

            BookcaseLine[424] = "    \"ARTS_TXT_011_00\": \"" + FakeHints[13] + " \","; //pre bloodless
            BookcaseLine[425] = "    \"ARTS_TXT_011_01\": \"\",";

            BookcaseLine[385] = "    \"DIARY_TXT_007_00\": \"" + FakeHints[14] + " \",";
            BookcaseLine[386] = "    \"DIARY_TXT_007_01\": \"\",";  //hall save

            BookcaseLine[387] = "    \"DIARY_TXT_008_00\": \"" + FakeHints[15] + " \",";
            BookcaseLine[388] = "    \"DIARY_TXT_008_01\": \"\",";  //before gebel

            BookcaseLine[426] = "    \"ARTS_TXT_012_00\": \"" + FakeHints[16] + " \","; //after carrage
            BookcaseLine[427] = "    \"ARTS_TXT_012_01\": \"\",";

            BookcaseLine[412] = "    \"ARTS_TXT_005_00\": \"" + FakeHints[17] + " \",";  //before Z1 ?????
            BookcaseLine[413] = "    \"ARTS_TXT_005_01\": \"\",";

            BookcaseLine[401] = "    \"DIARY_TXT_101_01\": \"" + FakeHints[18] + " \",";  //early garden
            
            BookcaseLine[402] = "    \"DIARY_TXT_101_02\": \"" + FakeHints[19] + " \",";  //an unpleasant game of  is mid garden

            //TOWER

            BookcaseLine[446] = "    \"ARTS_TXT_022_00\": \"" + FakeHints[20] + " \",";  //end of tower 
            BookcaseLine[447] = "    \"ARTS_TXT_022_01\": \"\",";

            BookcaseLine[379] = "    \"DIARY_TXT_004_00\": \"" + FakeHints[21] + " \",";  //top of tower
            BookcaseLine[380] = "    \"DIARY_TXT_004_01\": \"\",";

            //hall save

            BookcaseLine[434] = "    \"ARTS_TXT_016_00\": \"" + FakeHints[22] + " \",";  //helmsplitter is before valac
            BookcaseLine[435] = "    \"ARTS_TXT_016_01\": \"\",";

            //LIBRE
            //there are certain doors that are opened   start of libre
            
            BookcaseLine[377] = "    \"DIARY_TXT_003_00\": \"" + FakeHints[23] + " \",";  //pre andrea
            BookcaseLine[378] = "    \"DIARY_TXT_003_01\": \"\",";

            BookcaseLine[436] = "    \"ARTS_TXT_017_00\": \"" + FakeHints[24] + " \",";  //jinrai  lance armor
            BookcaseLine[437] = "    \"ARTS_TXT_017_01\": \"\",";

            BookcaseLine[383] = "    \"DIARY_TXT_006_00\": \"" + FakeHints[25] + " \",";  //i iy 1765 before abyssaal dragon
            BookcaseLine[384] = "    \"DIARY_TXT_006_01\": \"\",";


            //TRAIN
            BookcaseLine[404] = "    \"ARTS_TXT_001_00\": \"" + FakeHints[26] + " \",";  //post train
            BookcaseLine[405] = "    \"ARTS_TXT_001_01\": \"\",";


            //LAB
            BookcaseLine[381] = "    \"DIARY_TXT_005_00\": \"" + FakeHints[27] + " \",";  //pre bathin
            BookcaseLine[382] = "    \"DIARY_TXT_005_01\": \"\",";

            BookcaseLine[408] = "    \"ARTS_TXT_003_00\": \"" + FakeHints[28] + " \",";  //post bathin
            BookcaseLine[409] = "    \"ARTS_TXT_003_01\": \"\",";

            //UNDERGROUND
            BookcaseLine[432] = "    \"ARTS_TXT_015_00\": \"" + FakeHints[29] + " \",";  //under the well
            BookcaseLine[433] = "    \"ARTS_TXT_015_01\": \"\",";

            BookcaseLine[422] = "    \"ARTS_TXT_010_00\": \"" + FakeHints[30] + " \",";  //first underground save
            BookcaseLine[423] = "    \"ARTS_TXT_010_01\": \"\",";

            BookcaseLine[440] = "    \"ARTS_TXT_019_00\": \"" + FakeHints[31] + " \",";  //shovel save
            BookcaseLine[441] = "    \"ARTS_TXT_019_01\": \"\",";


            //DESERT
            BookcaseLine[418] = "    \"ARTS_TXT_008_00\": \"" + FakeHints[32] + " \",";  //zepar algred
            BookcaseLine[419] = "    \"ARTS_TXT_008_01\": \"\",";

            //INFERNO

            BookcaseLine[391] = "    \"DIARY_TXT_010_00\": \"" + FakeHints[33] + " \",";  //pre orobos
            BookcaseLine[392] = "    \"DIARY_TXT_010_01\": \"\",";

            //LAB
            BookcaseLine[389] = "    \"DIARY_TXT_009_00\": \"" + FakeHints[34] + " \",";  //torture lab
            BookcaseLine[390] = "    \"DIARY_TXT_009_01\": \"\",";

            //ICE
            BookcaseLine[438] = "    \"ARTS_TXT_018_00\": \"" + FakeHints[35] + " \",";  //cresent stroke.  ice save
            BookcaseLine[439] = "    \"ARTS_TXT_018_01\": \"\",";

            //DEN
            BookcaseLine[395] = "    \"DIARY_TXT_012_00\": \"" + FakeHints[36] + " \",";  //pre valefar
            BookcaseLine[396] = "    \"DIARY_TXT_012_01\": \"\",";
        }
    }
}
