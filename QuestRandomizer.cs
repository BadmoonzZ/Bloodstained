using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class QuestRandomizer
    {



        public static void MurdersSimpleRandom(Random rndshard, string[] questLine, List<string> spoilerarray)
        {
            List<string> questitems = ItemList.GenerateItemList();  //this will not include crafting books
            questitems = questitems.OrderBy(i => rndshard.Next()).ToList();

            List<string> enemycandidates = new List<string>
                {
                    "N3003", "N3006", "N3007", "N3004",  //morte, seama, aello, bone morte
                    "N3015", "N3013", "N3051", "N3105",  //dullahammer, ghost, giant rat, bloodgrinder knight
                    "N3073", "N3104", "N3121", "N3100",  //gieremund, ordog, eightbitzombie, poltergiest
                    "N3080", "N3084", "N3008", "N3079",  //sabnock, buer armor, celano, killer barber
                    "N3011", "N3064", "N3010", "N3103",  //barbatos, decarabia, shovel armor, rulsha
                    "N3055", "N2002", "N3017", "N3033",  //demon, wolfman, carriage morte, thunder elemental
                    "N3111", "N3019", "N3063", "N3058",  //shield outsider, assassin, dantalion, lili
                    "N3009", "N3110", "N3082", "N3066",  //ocypete, axe outrsider, scythe mite, mocoweed
                    "N3022", "N3056", "N3092", "N3043",  //deeseama, archdemon, sidhe, poison toad
                    "N2010", "N3059", "N3072", "N3087",  //living fossil, lamashtu, chair mimic, cyhyraeth
                    "N3035", "N3057", "N3012", "N3077",  //gusion, demonlord, leraje, gamigin
                    "N3085", "N3102", "N3078", "N3113",  //lance armor, light elemental, forneus, macaron
                    "N3070", "N3014", "N3002", "N3075",  //mimic, amy, allocer, zagan
                    "N3001", "N3116", "N3091", "N3123",  //buer, nyabon, caraboose, hellhound
                    "N3086", "N3115", "N3101", "N3109",  //zepar, rocky, dark elemental, tamako-death
                    "N3052", "N2009", "N3053", "N3020",  //bloodbringer, dragon, gargoyle, ninja
                };
            enemycandidates = enemycandidates.OrderBy(i => rndshard.Next()).ToList();

            spoilerarray.Add("Lindsay Murderer's dead quests:");
            for (int i = 0; i < 20; i++)
            {
                int rngqty = rndshard.Next(1, 11);
                questLine[26 + 40 * i] = "      \"Enemy01\": \"" + enemycandidates[i] + "\",";
                questLine[27 + 40 * i] = "      \"EnemyNum01\": " + rngqty + ",";

                rngqty = rndshard.Next(1, 6);
                questLine[29 + 40 * i] = "      \"RewardItem01\": \"" + questitems[i] + "\",";
                questLine[30 + 40 * i] = "      \"RewardNum01\": " + rngqty + ",";

                spoilerarray.Add(FriendlyString.Translate(enemycandidates[i]) + " - " + FriendlyString.Translate(questitems[i]) + " x" + rngqty);
            }


        }

        public static void SusieSimpleRandom(Random rndshard, string[] questLine, List<string> spoilerarray)
        {
            List<string> questitems = ItemList.GenerateItemList();  //this will not include crafting books
            questitems = questitems.OrderBy(i => rndshard.Next()).ToList();

            for (int i = 0; i < 21; i++)
            {
                int rngqty = new int();
                rngqty = rndshard.Next(1, 6);
                questLine[1429 + 40 * i] = "      \"RewardItem01\": \"" + questitems[i] + "\",";
                questLine[1430 + 40 * i] = "      \"RewardNum01\": " + rngqty + ",";

                spoilerarray.Add("Susie " + i + " - " + FriendlyString.Translate(questitems[i]) + " x" + rngqty);
            }
        }

        public static void AbigailSimpleRandom(Random rndshard, string[] questLine, List<string> spoilerarray)
        {
            List<string> questitems = ItemList.GenerateItemList();
            questitems = questitems.OrderBy(i => rndshard.Next()).ToList();

            for (int i = 0; i < 15; i++)
            {
                int rngqty = new int();
                rngqty = rndshard.Next(1, 6);
                questLine[829 + 40 * i] = "      \"RewardItem01\": \"" + questitems[i] + "\",";
                questLine[830 + 40 * i] = "      \"RewardNum01\": " + rngqty + ",";

                spoilerarray.Add("Abigail " + i + " - " + FriendlyString.Translate(questitems[i]) + " x" + rngqty);
            }
        }

    }
}
