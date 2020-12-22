using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
//
// WARNING.  THIS FILE IS NO LONGER USED.
//
//
namespace textcopier2
{
    //hack of a function to check if we have one of six shards
    public class CheckLogic
    {

        //hack of a function to check if we have one of six shards
        public static int EarlyProgressionCheck(string shard)
        {
            if (shard == "      \"ShardId\": \"Dimensionshift\"," || shard == "      \"ShardId\": \"Invert\"," || shard == "      \"ShardId\": \"Demoniccapture\"," ||
                shard == "      \"ShardId\": \"Doublejump\"," || shard == "      \"ShardId\": \"Reflectionray\"," || shard == "      \"ShardId\": \"HighJump\",")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //another hack
        //checks a list of shards, if dimension shift is present, returns a 0, otherwise a 10
        //expectation is to use this on a list of unplaced shards
        public static int PlaceDimensionshift(List<string> remainingshards)
        {

            for (int i = 0; i < remainingshards.Count(); i++)
            {
                if (remainingshards[i] == "Dimensionshift")
                {
                    return 0;
                }
                else
                {
                    //print the shard to spoiler log.
                    //note this function will eventually go away, so skipping this for now.
                }

            }
            return 10;
        }
    }
}
