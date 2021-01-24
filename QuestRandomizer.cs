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
                    "N3003", "N3003", "N3007", "N3004",
                    "N3015", "N3013", "N3051", "N3105",
                    "N3073", "N3104", "N3121", "N3100",
                    "N3080", "N3084", "N3008", "N3079",
                    "N3011", "N3064", "N3010", "N3103",
                    "N3055", "N2002", "N3017", "N3033",
                    "N3111", "N3019", "N3063", "N3058",
                    "N3009", "N3110", "N3082", "N3066",
                    "N3022", "N3056", "N3092", "N3043",
                    "N2010", "N3059", "N3072", "N3087",
                    "N3035", "N3057", "N3012", "N3077",
                    "N3085", "N3102", "N3078", "N3113",
                    "N3070", "N3014", "N3002", "N3075",
                    "N3001", "N3116", "N3091", "N3123",
                    "N3086", "N3115", "N3101", "N3109",
                };
            enemycandidates = enemycandidates.OrderBy(i => rndshard.Next()).ToList();

            for (int i = 0; i < 20; i++)
            {
                int rngqty = rndshard.Next(1, 11);
                questLine[26 + 40 * i] = "      \"Enemy01\": \"" + enemycandidates[i] + "\",";
                questLine[27 + 40 * i] = "      \"EnemyNum01\": " + rngqty + ",";

                rngqty = rndshard.Next(1, 6);
                questLine[29 + 40 * i] = "      \"RewardItem01\": \"" + questitems[i] + "\",";
                questLine[30 + 40 * i] = "      \"RewardNum01\": " + rngqty + ",";

                spoilerarray.Add(enemycandidates[i] + " - " + questitems[i]);
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

                spoilerarray.Add("Susie " + i + " - " + questitems[i]);
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

                spoilerarray.Add("Abigail " + i + " - " + questitems[i]);
            }
        }

    }
}
