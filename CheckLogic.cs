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
        //this takes a list of shard strings, and makes a new list of movement starhds
        //then it creates a new list of all the enemies and a new list of the early enemies
        //next shuffle the early enemies and list of movement shards
        //then give whatever is the shuffled first enemy in the earlyenemies list the shuffled first movementshard
        //next modify the list of shards strings by removing the movement shard we added to the early list to prevent duplication
        //at this point the only change that has happened is the original full list of all shards is now missing a movement shard
        //..
        //now find the index of craftwork in our new enemy list & the index of whatever enemy we gave the movementshard to
        //finally, for each enemy in the new list, assign it a shard from the inputed original shuffled shard list. with exceptions for craftwork and the move shard enemy we just found.
        //now that the routine is over, throw away that new list? it should be gone, but magically it is somehow writing to the final file...??????
        public static void BasicEarlyShardPlacement(List<string> fulllistofshards, Random rndshard)
        {
            List<EnemyDropTable> listofenemies2 = ShardRandomizer.CreateEnemyList();

            //Create a subset list of enemies in the early game for some base logic
            List<EnemyDropTable> earlyenemieslist = ShardRandomizer.GenerateEarlyEnemiesList(listofenemies2);
            //randomize the early enemies
            earlyenemieslist = earlyenemieslist.OrderBy(i => rndshard.Next()).ToList();

            List<string> mainmovementshards = new List<string>
            {
                "Invert", "Doublejump", "Dimensionshift", "HighJump", "Reflectionray", "Demoniccapture",
            };

            //shuflle the movement shard list and assign one of them to whatever enemy is first in our earlyenemy list.
            mainmovementshards = mainmovementshards.OrderBy(i => rndshard.Next()).ToList();
            earlyenemieslist[0].ShardId = mainmovementshards[0];
            earlyenemieslist[1].ShardId = "Aquastream";    //****

            //find the selected early shard and remove it from the list so it doesn't get placed twice.
            fulllistofshards.Remove(mainmovementshards[0]);
            fulllistofshards.Remove("Aquastream");  //****

            //search for craftwork and find its id.
            int indexofcraftwork = listofenemies2.FindIndex(a => a.FriendlyName == "Craftwork");
            //search for the index of the enemy who has the same name as the enemy we set a move shard too
            int indexofearlymove = listofenemies2.FindIndex(a => a.FriendlyName == earlyenemieslist[0].FriendlyName);
            int indexofearlymove2 = listofenemies2.FindIndex(a => a.FriendlyName == earlyenemieslist[1].FriendlyName);  //****

            //write our shuffled shardlist to enemydroptable except for craftwork
            for (int i = 0; i < listofenemies2.Count(); i++)
            {
                if (i == indexofcraftwork)
                {
                    fulllistofshards.Add(fulllistofshards[i]);  //this adds the shard we are overwriting back to the pool
                    listofenemies2[i].ShardId = "Shortcut";

                }
                else if (i == indexofearlymove)
                {
                    fulllistofshards.Add(fulllistofshards[i]);  //this adds the shard we are overwriting back to the pool
                    listofenemies2[i].ShardId = mainmovementshards[0];
                }
                else if (i == indexofearlymove2)
                {
                    fulllistofshards.Add(fulllistofshards[i]);  //this adds the shard we are overwriting back to the pool
                    listofenemies2[i].ShardId = "Aquastream";
                }
                else
                {
                    listofenemies2[i].ShardId = fulllistofshards[i];
                }

            }

        }



        public static List<TreasureChest> BasicZangetsutoPlacement(List<TreasureChest> CheststoCheck , Random seednumber)
        {
            //take the randomized chest list and modify the ID of each chest to be a valid randomizer chest ID for seed 17791.
            bool ZImposible = true;
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
                        case 450: //oriental bridge
                        case 397: //tower
                        case 144: //tower
                        case 87: //gebels
                        case 253: //carpenter
                        case 382: //carpenter2
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
                            if (CheststoCheck[i].RareItemId == "Keyofbacker1")
                            {
                                ZImposible = true;
                                //no logic poor check to make sure carpenter key is not a lock
                            }
                            break;
                        case 207: //for extra safety lets make sure bomide cannot be on train too.
                        case 122:
                        case 278:
                        case 105:
                        case 416:
                        case 500:
                        case 309: //and underground sorcery lab
                        case 298:
                        case 282:
                        case 462:
                        case 355:
                        case 79:
                        case 55:
                        case 113:
                            if (CheststoCheck[i].RareItemId == "Silverbromide")
                            {
                                ZImposible = true;
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
