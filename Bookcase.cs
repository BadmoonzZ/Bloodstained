using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class Bookcase
    {

        public static List<string> BookcaseHelper = new List<string>();


        public static void BasicHints(string[] BookcaseLine, Random rndshard,
            string eightbit, string scytheshard, string gremshard, string kuneshard, string abysshard, string gaapshard, string bombshard, string gcannonshard,
            string burriedrocky, string burriedzepar, string waterchest, string clamsinkerchest, string underbridge, string shipcaptain, string shipdulla, string beforevalacchest, List<string> spoilerlog)
        {

            //automate this
            if (burriedrocky == "None")
            {
                burriedrocky = "Some Money";
            }
            if (burriedzepar == "None")
            {
                burriedzepar = "Some Money";
            }
            if (waterchest == "None")
            {
                waterchest = "Some Money";
            }
            if (clamsinkerchest == "None")
            {
                clamsinkerchest = "Some Money";
            }
            if (underbridge == "None")
            {
                underbridge = "Some Money";
            }
            if (shipcaptain == "None")
            {
                shipcaptain = "Some Money";
            }
            if (shipdulla == "None")
            {
                shipdulla = "Some Money";
            }
            if (beforevalacchest == "None")
            {
                beforevalacchest = "Some Money";
            }

            //perhaps move the css code out of the string....
            //not sure how to get this to work.  span is the only thing it seems to recognize.  cannot combine. only one line.
            string hint01 = "<span color=\\\"#999999\\\">Springball is behind Ridley.</>";
            string hint02 = "<span color=\\\"#999999\\\">Gebel is not wearing his glasses.  They could be anywhere!</>";
            string hint03 = "<span color=\\\"#999999\\\">Eastmost peninsula has the secret.</>";
            string hint04 = "<span color=\\\"#999999\\\">I am Error.</>";
            string hint05 = "<span color=\\\"#999999\\\">A piece of heart and Hookshot can be found on the west side of Swamp Palace.</>";
            string hint06 = "<span color=\\\"#999999\\\">Song of Storms can be found by staring into a cow ass.</>";
            string hint07 = "<span color=\\\"#999999\\\">Doesn't even have accelerator?</>";
            string hint08 = "<span color=\\\"#999999\\\">The times two dream!</>\\n\\n\\n<span color=\\\"#999999\\\">The times two dream!</>";
            string hint09 = "<span color=\\\"#999999\\\">OD is in the library.</>";
            string hint10 = "<span color=\\\"#999999\\\">Did you know that reading books during a race can be considered a waste of time?</>";
            string hint11 = "<span color=\\\"#999999\\\">Did you know that there are 40 bookcases in the game.</>\\n\\n<span color=\\\"#999999\\\">There might even be more!</>";
            string hint12 = "<span color=\\\"#999999\\\">Jass can be found in Desert.</>";
            string hint13 = "<span color=\\\"#999999\\\">Flame Mammoth is weak to Storm Eagle.</>";
            string hint14 = "<span color=\\\"#999999\\\">Pro Tip: Phantoon is weak to Super Missiles.</>\\n\\n<span color=\\\"#999999\\\">Now you're playing with power!</>";
            string hint15 = "<span color=\\\"#999999\\\">Carabosse will sing you a song if you are willing to play some piano for her.</>";
            string hint16 = "<span color=\\\"#999999\\\">Have you hit the shard yet?</>";
            string hint17 = "<span color=\\\"#999999\\\">There are many ways to softlock on the Train.</>\\n\\n<span color=\\\"#999999\\\">Have Zangetsu fall off the train.</>\\n<span color=\\\"#999999\\\">Fail to receive a shard from the Glutton Train.</>\\n<span color=\\\"#999999\\\">Have a familiar attack Glutton Train in the final phase.</>\\n<span color=\\\"#999999\\\">Zangetsu sometimes will jump up and down instead of following you.</>";
            string hint18 = "<span color=\\\"#999999\\\">The president can be found in Garden.</>";
            string hint19 = "<span color=\\\"#999999\\\">Many weapons in this game have a technique that can be used and mastered.</>\\n\\n<image id=\\\"Text_Command_Arrow_Up\\\"/> <image id=\\\"Text_Command_Arrow_Up\\\"/> <image id=\\\"Text_Command_Arrow_Down\\\"/> <image id=\\\"Text_Command_Arrow_Down\\\"/> <image id=\\\"Text_Command_Arrow_Left\\\"/> <image id=\\\"Text_Command_Arrow_Right\\\"/> <image id=\\\"Text_Command_Arrow_Left\\\"/> <image id=\\\"Text_Command_Arrow_Right\\\"/> \\n <span size=\\\"30\\\">B A START</>";
            string hint20 = "<span color=\\\"#999999\\\">Luminescent Elementals form while loitering atop bovine fauna.</>";
            string hint21 = "<span color=\\\"#999999\\\">The Richter scale is a numerical expression for the magnitude of the protaganist in the Castlevania series.</>";
            string hint22 = "<span color=\\\"#999999\\\">Bookcase vaccuum occurs when you accidentally or incidentally press up in the vicinity of a nearby bookcase.</>";
            string hint23 = "<span color=\\\"#999999\\\">Adventurer's Tip:</>\\n<span color=\\\"#999999\\\">Know your escape routes.  Sometimes one chest and a poison frog isn't worth it.</>";
            string hint24 = "<span color=\\\"#999999\\\">Oishiiiiiiiiiiiiiiiiiiiiiiiiiiii\\nScrumptious!\\nHigh Ceeeeeeeeeeeeeee\\n\\nWhat's going on?\\nOh, Miriam is just eating.\\n\\nHigh Ceeeeeeeeeeeeeee\\nHigh Ceeeeeeeeeeeeeee\\nHigh Ceeeeeeeeeeeeeee\\nHigh Ceeeeeeeeeeeeeee</>";
            string hint25 = "<span color=\\\"#999999\\\">Mithridate!\\n\\nMedicine for purging poison from the body.\\n\\nUseful after opening certain types of frogs.";
            string hint26 = "<span color=\\\"#999999\\\">So what's on this card anyways?  Wait.  Why is THAT there?!</>";
            string hint27 = "<span color=\\\"#999999\\\">  MEOW MEOW MEOW MEOW</>\\n<span color=\\\"#999999\\\">     MEOW MEOW MEOW</>\\n<span color=\\\"#999999\\\">        OH MY GOD</>";
            string hint28 = "<span color=\\\"#999999\\\">The Bridge of Evil is neither a bridge, nor evil, nor an empire.</>";
            string hint29 = "<span color=\\\"#999999\\\">The Boots is in Ganon's Tower.</>\\n\\n<span color=\\\"#999999\\\">Wait.</>\\n<span color=\\\"#999999\\\">Shouldn't that be 'are' in Ganon's Tower.</>\\n\\n<span color=\\\"#999999\\\">Nope.  The Boots are progressive.  This is the location of only one of the boots.</>";
            string hint30 = "<span color=\\\"#999999\\\">Take a ride on the Chair Express.  It could elevate you to new (or maybe old) heights.</>";
            string hint31 = "<span color=\\\"#999999\\\">Using Bloodsteal on Bloodless is more effective than the names imply.</>";
            string hint32 = "<span color=\\\"#999999\\\">Stop giving Benjamin Waystones.  You're enabling him.</>\\n\\n<span color=\\\"#999999\\\">Waystone addiction, also called Waystone use disorder, is a disease that affects a person's brain and behavior and leads to an inability to control the use of legal or illegal waystone useage.</>";
            string hint33 = "<span color=\\\"#999999\\\">Kefka can be found at the top of Kefka's Tower.</>";
            string hint34 = "<span color=\\\"#999999\\\">EEEEEEEEEE... OOOOOOOOOO...</>\\n\\n<span color=\\\"#999999\\\">What is that?</>\\n<span color=\\\"#999999\\\">The author must have died while writing this.</>\\n<span color=\\\"#999999\\\">Really?</>\\n<span color=\\\"#999999\\\">If they were dying they wouldn't bother to write EEEEEEEEEE... OOOOOOOOOO..., they'd just say it.</>\\n<span color=\\\"#999999\\\">Perhaps it was dictated.</>";
            string hint35 = "<span color=\\\"#999999\\\">If it's on the card, put me down for:</>\\n\\n<span color=\\\"#999999\\\">Spam those emotes in Wild's Chat.</>";
            string hint36 = "<span color=\\\"#999999\\\">Submit your story today!</>";

            string ghint01 = "<span size=\\\"30\\\">Bomber Morte has the " + FriendlyString.Translate(bombshard) + " shard.</>";
            string ghint02 = "<span size=\\\"30\\\"> " + FriendlyString.Translate(waterchest) + " can be found in an underwater locker.</>";
            string ghint03 = "<span size=\\\"30\\\">" + FriendlyString.Translate(underbridge) + " can be found under a bridge in the Oriental Sorcery Lab.</>";
            string ghint04 = "<span size=\\\"30\\\">" + FriendlyString.Translate(shipcaptain) + " can be just out of reach on the ship.</>";
            string ghint05 = "<span size=\\\"30\\\">Gaap has the " + FriendlyString.Translate(gaapshard) + " shard.</>";
            string ghint06 = "<span size=\\\"30\\\">" + FriendlyString.Translate(burriedrocky) + " can be found buried in the sand.</>";
            string ghint07 = "<span size=\\\"30\\\">Gremory has the " + FriendlyString.Translate(gremshard) + " shard.</>";
            string ghint08 = "<span size=\\\"30\\\">KuneKune has the " + FriendlyString.Translate(kuneshard) + " shard.</>";
            string ghint09 = "<span size=\\\"30\\\">Abyssal Dragon has the " + FriendlyString.Translate(abysshard) + " shard.</>";
            string ghint10 = "<span size=\\\"30\\\">Eight Bit Overlord has the " + FriendlyString.Translate(eightbit) + " shard.</>";
            string ghint11 = "<span size=\\\"30\\\">Scythe Mite has the " + FriendlyString.Translate(scytheshard) + " shard.</>";
            string ghint12 = "<span size=\\\"30\\\">Gusion Cannon has the " + FriendlyString.Translate(gcannonshard) + " shard.</>";
            string ghint13 = "<span size=\\\"30\\\">" + FriendlyString.Translate(beforevalacchest) + " can be found above Valac.</>";
            string ghint14 = "<span size=\\\"30\\\">" + FriendlyString.Translate(clamsinkerchest) + " can be found in an underwater locker.</>";
            string ghint15 = "<span size=\\\"30\\\">" + FriendlyString.Translate(shipdulla) + " can be just out of reach on the ship.</>";
            string ghint16 = "<span size=\\\"30\\\">" + FriendlyString.Translate(burriedzepar) + " can be found buried in the sand.</>";
            string ghint17 = "A shard recipe can be unlocked with some materials plus a shard.";
            if (Bookcase.BookcaseHelper.ElementAt(2) != null)
            {
                //this will need to be improved in the future. for example the bookcase list will probably change over time.
                ghint17 = "<span size=\\\"30\\\">A shard recipe can be unlocked with some materials plus the following transmute: " + Bookcase.BookcaseHelper[2] + ".</>";
            }
            string ghint18 = "A shard recipe can be unlocked with some materials plus a shard.";
            if (Bookcase.BookcaseHelper.ElementAt(4) != null)
            {
                ghint18 = "<span size=\\\"30\\\">A shard recipe can be unlocked with some materials plus the following transmute: " + Bookcase.BookcaseHelper[4] + ".</>";
            }

            //
            spoilerlog.Add("");
            spoilerlog.Add("");
            spoilerlog.Add("**HINTS**");
            spoilerlog.Add(ghint01);
            spoilerlog.Add(ghint02 + " (a deepsinker chest?) - " + waterchest);
            spoilerlog.Add(ghint03 + " - " + underbridge);
            spoilerlog.Add(ghint04 + " (captains quarters) - " + shipcaptain);
            spoilerlog.Add(ghint05);
            spoilerlog.Add(ghint06 + " (by rocky) - " + burriedrocky);
            spoilerlog.Add(ghint07);
            spoilerlog.Add(ghint08);
            spoilerlog.Add(ghint09);
            spoilerlog.Add(ghint10);
            spoilerlog.Add(ghint11);
            spoilerlog.Add(ghint12);
            spoilerlog.Add(ghint13);
            spoilerlog.Add(ghint14 + " (clamsinker) - " + clamsinkerchest);
            spoilerlog.Add(ghint15 + " (cargo hold) - " + shipdulla);
            spoilerlog.Add(ghint16 + " (by zepar sand) - " + burriedzepar);
            spoilerlog.Add(ghint17);
            spoilerlog.Add(ghint18);
            spoilerlog.Add("****");
            spoilerlog.Add("");
            //

            List<string> FakeHints = new List<string>
            {
                hint01, hint02, hint03, hint04, hint05, hint06, hint07, hint08, hint09, hint10,
                hint11, hint12, hint13, hint14, hint15, hint16, hint17, hint18, hint19, hint20,
                hint21, hint22, hint23, hint24, hint25, hint26, hint27, hint28, hint29, hint30,
                hint31, hint32, hint33, hint34, hint35, hint36,
                ghint01, ghint02, ghint03, ghint04, ghint05, ghint06, ghint07, ghint08, ghint09, ghint10,
                ghint11, ghint12, ghint13, ghint14, ghint15, ghint16, ghint17, ghint18
            };
            FakeHints = FakeHints.OrderBy(i => rndshard.Next()).ToList();

            //SHIP
            BookcaseLine[399] = "    \"HELP_TXT_003_00\": \"" + FakeHints[0] + " \",";  //ship1
            BookcaseLine[400] = "    \"HELP_TXT_003_01\": \"\",";

            BookcaseLine[428] = "    \"ARTS_TXT_013_00\": \"" + FakeHints[1] + " \",";  //ship second save
            BookcaseLine[429] = "    \"ARTS_TXT_013_01\": \"\",";

            //TOWN
            BookcaseLine[406] = "    \"ARTS_TXT_002_00\": \"" + FakeHints[2] + " \",";  //halfway house
            BookcaseLine[407] = "    \"ARTS_TXT_002_01\": \"\",";

            //ENTRANCE
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

            //CATHEDRAL
            BookcaseLine[430] = "    \"ARTS_TXT_014_00\": \"" + FakeHints[8] + " \",";  //first cathedral save
            BookcaseLine[431] = "    \"ARTS_TXT_014_01\": \"\",";

            BookcaseLine[375] = "    \"DIARY_TXT_002_00\": \"" + FakeHints[9] + " \","; //before the barber
            BookcaseLine[376] = "    \"DIARY_TXT_002_01\": \"\",";

            BookcaseLine[444] = "    \"ARTS_TXT_021_00\": \"" + FakeHints[10] + " \","; //before craftwork
            BookcaseLine[445] = "    \"ARTS_TXT_021_01\": \"\",";


            BookcaseLine[448] = "    \"ARTS_TXT_023_00\": \"" + FakeHints[11] + " \",";  //cyreath orientalcathedral
            BookcaseLine[449] = "    \"ARTS_TXT_023_01\": \"\",";



            BookcaseLine[424] = "    \"ARTS_TXT_011_00\": \"" + FakeHints[12] + " \","; //pre bloodless
            BookcaseLine[425] = "    \"ARTS_TXT_011_01\": \"\",";

            //HALL
            BookcaseLine[385] = "    \"DIARY_TXT_007_00\": \"" + FakeHints[13] + " \",";
            BookcaseLine[386] = "    \"DIARY_TXT_007_01\": \"\",";  //hall save

            BookcaseLine[387] = "    \"DIARY_TXT_008_00\": \"" + FakeHints[14] + " \",";
            BookcaseLine[388] = "    \"DIARY_TXT_008_01\": \"\",";  //before gebel

            BookcaseLine[410] = "    \"ARTS_TXT_004_00\": \"" + FakeHints[15] + " \",";  //before gebel 2
            BookcaseLine[411] = "    \"ARTS_TXT_004_01\": \"\",";

            //GARDEN
            BookcaseLine[426] = "    \"ARTS_TXT_012_00\": \"" + FakeHints[16] + " \","; //after carrage
            BookcaseLine[427] = "    \"ARTS_TXT_012_01\": \"\",";

            BookcaseLine[412] = "    \"ARTS_TXT_005_00\": \"" + FakeHints[17] + " \",";  //before Z1 ?????
            BookcaseLine[413] = "    \"ARTS_TXT_005_01\": \"\",";

            BookcaseLine[401] = "    \"DIARY_TXT_101_01\": \"" + FakeHints[18] + " \",";  //early garden

            BookcaseLine[402] = "    \"DIARY_TXT_101_02\": \"" + FakeHints[19] + " \",";  //mid garden

            //TOWER

            BookcaseLine[446] = "    \"ARTS_TXT_022_00\": \"" + FakeHints[20] + " \",";  //end of tower 
            BookcaseLine[447] = "    \"ARTS_TXT_022_01\": \"\",";

            BookcaseLine[379] = "    \"DIARY_TXT_004_00\": \"" + FakeHints[21] + " \",";  //top of tower
            BookcaseLine[380] = "    \"DIARY_TXT_004_01\": \"\",";

            BookcaseLine[434] = "    \"ARTS_TXT_016_00\": \"" + FakeHints[22] + " \",";  //before valac
            BookcaseLine[435] = "    \"ARTS_TXT_016_01\": \"\",";

            BookcaseLine[397] = "    \"HELP_TXT_001_00\": \"" + FakeHints[23] + "  \",";  //tower gear
            BookcaseLine[398] = "    \"HELP_TXT_002_00\": \"" + FakeHints[24] + "  \",";  //libre first

            //LIBRE

            BookcaseLine[377] = "    \"DIARY_TXT_003_00\": \"" + FakeHints[25] + " \",";  //pre andrea
            BookcaseLine[378] = "    \"DIARY_TXT_003_01\": \"\",";

            BookcaseLine[436] = "    \"ARTS_TXT_017_00\": \"" + FakeHints[26] + " \",";  //jinrai  lance armor
            BookcaseLine[437] = "    \"ARTS_TXT_017_01\": \"\",";

            BookcaseLine[383] = "    \"DIARY_TXT_006_00\": \"" + FakeHints[27] + " \",";  //before abyssaal dragon
            BookcaseLine[384] = "    \"DIARY_TXT_006_01\": \"\",";


            //TRAIN
            BookcaseLine[404] = "    \"ARTS_TXT_001_00\": \"" + FakeHints[28] + " \",";  //post train
            BookcaseLine[405] = "    \"ARTS_TXT_001_01\": \"\",";


            //LAB
            BookcaseLine[381] = "    \"DIARY_TXT_005_00\": \"" + FakeHints[29] + " \",";  //pre bathin
            BookcaseLine[382] = "    \"DIARY_TXT_005_01\": \"\",";

            BookcaseLine[408] = "    \"ARTS_TXT_003_00\": \"" + FakeHints[30] + " \",";  //post bathin
            BookcaseLine[409] = "    \"ARTS_TXT_003_01\": \"\",";

            //UNDERGROUND
            BookcaseLine[432] = "    \"ARTS_TXT_015_00\": \"" + FakeHints[31] + " \",";  //under the well
            BookcaseLine[433] = "    \"ARTS_TXT_015_01\": \"\",";

            BookcaseLine[422] = "    \"ARTS_TXT_010_00\": \"" + FakeHints[32] + " \",";  //first underground save
            BookcaseLine[423] = "    \"ARTS_TXT_010_01\": \"\",";

            BookcaseLine[440] = "    \"ARTS_TXT_019_00\": \"" + FakeHints[33] + " \",";  //shovel save
            BookcaseLine[441] = "    \"ARTS_TXT_019_01\": \"\",";


            //DESERT
            BookcaseLine[418] = "    \"ARTS_TXT_008_00\": \"" + FakeHints[34] + " \",";  //zepar algred
            BookcaseLine[419] = "    \"ARTS_TXT_008_01\": \"\",";

            //INFERNO

            BookcaseLine[391] = "    \"DIARY_TXT_010_00\": \"" + FakeHints[35] + " \",";  //pre orobos
            BookcaseLine[392] = "    \"DIARY_TXT_010_01\": \"\",";

            //LAB
            BookcaseLine[389] = "    \"DIARY_TXT_009_00\": \"" + FakeHints[36] + " \",";  //torture lab
            BookcaseLine[390] = "    \"DIARY_TXT_009_01\": \"\",";

            //ORIENTAL
            BookcaseLine[393] = "    \"DIARY_TXT_011_00\": \"" + FakeHints[37] + " \",";
            BookcaseLine[394] = "    \"DIARY_TXT_011_01\": \"\",";  //before z2

            //ICE
            BookcaseLine[438] = "    \"ARTS_TXT_018_00\": \"" + FakeHints[38] + " \",";  //cresent stroke.  ice save
            BookcaseLine[439] = "    \"ARTS_TXT_018_01\": \"\",";

            //DEN
            BookcaseLine[395] = "    \"DIARY_TXT_012_00\": \"" + FakeHints[39] + " \",";  //pre valefar
            BookcaseLine[396] = "    \"DIARY_TXT_012_01\": \"\",";



        }
    }
}