using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace textcopier2
{
    
    public class CheckLogic
    {
        //take the first entry in earlylogicenemies (whatever it is) and assign it one of the 6 main movementshards.
        public static void BasicEarlyShardPlacement(List<string> fulllistofshards, Random rndshard)
        {
            List<EnemyDropTable> listofenemies = ShardRandomizer.CreateEnemyList();

            //Create a subset list of enemies in the early game for some base logic
            List<EnemyDropTable> earlyenemieslist = ShardRandomizer.GenerateEarlyEnemiesList(listofenemies);
            //randomize the early enemies
            earlyenemieslist = earlyenemieslist.OrderBy(i => rndshard.Next()).ToList();

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
                else if (i == indexofearlymove)
                {
                    listofenemies[i].ShardId = mainmovementshards[0];

                    //spoilerarray.Add(listofenemies[i].FriendlyName + " " + mainmovementshards[0] + " check early move");   //ye olde spoiler log helper
                }
                else
                {
                    listofenemies[i].ShardId = fulllistofshards[i];
                }

            }

        }

        public static List<TreasureChest> BasicZangetsutoPlacement(List<TreasureChest> CheststoCheck , Random seednumber)
        {
            //take the randomized chest list and modify the ID of each chest to be a valid randomizer chest ID for seed 17791.
            //CheststoCheck = ChestShuffle.ApplySeedID(CheststoCheck, ChestShuffle.seed17791IDs);
            bool ZImposible = true;     //zangetsuto check
            while (ZImposible == true)
            {
                ZImposible = false;

                //first shuffle the list of chests
                CheststoCheck = CheststoCheck.OrderBy(i => seednumber.Next()).ToList();
                //next take the shuffled list and sequentially modify each chestID to the chest ID for seed 17791.
                CheststoCheck = ChestShuffle.ApplySeedID(CheststoCheck, ChestShuffle.seed17791IDs);

                //next check each chest. if it has an ID in Den, Ice, or Extra, throw ZImpossible, and start over with a new shuffle.
                for (int i = 0; i < ChestShuffle.seed17791IDs.Count(); i++)
                {
                    switch (CheststoCheck[i].ChestId)
                    {
                        case 386: //craftwork chest
                        case 103: //craftwork chest
                        case 56: //craftwork chest
                        case 301:
                        case 239:
                        case 359:
                        case 260:
                        case 102:
                        case 155:
                        case 457:
                        case 175:
                        case 363:
                        case 453:
                        case 312:
                        case 78:
                        case 492:
                        case 324:
                        case 73:
                        case 361:
                        case 251:
                        case 255:
                        case 415:
                        case 196:
                        case 141:
                        case 547:
                        case 526:
                        case 541:
                        case 192:
                        case 321:
                        case 356:
                        case 57:
                        case 91:
                        case 295:
                        case 92:
                        case 434:
                        case 123:
                        case 139:
                        case 451:
                        case 371:
                        case 517:
                        case 499:
                        case 509:
                        case 397: //tower
                        case 144: //tower
                        case 87: //gebels
                            if (CheststoCheck[i].RareItemId == "Swordsman")
                            {
                                ZImposible = true;
                                //spoilerarray.Add("Ah ha~ broken seed!!! rerolling...");
                            }
                            if (CheststoCheck[i].RareItemId == "Silverbromide")
                            {
                                ZImposible = true;
                                //poor check to make bromide also not in a zlock area.
                            }
                            break;
                        default:
                            //do nothing
                            break;
                    }

                }
            }

            return CheststoCheck;
        }

    }
}
