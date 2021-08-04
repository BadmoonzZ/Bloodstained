using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class EnemyDropShuffle
    {

        public static List<EnemyDropTable> ShuffleEnemies(List<EnemyDropTable> listofenemies , Random rndshard)
        {
            List<int> enemylines = new List<int>();
            List<EnemyDropTable> shuffledenemies = listofenemies;

            //create the list of enemyline numbers.
            for (int i = 0; i < shuffledenemies.Count(); i++)
            {
                enemylines.Add(shuffledenemies[i].DatatableLineNumber);
            }

            //shuffle the enemy numbers
            enemylines = enemylines.OrderBy(i => rndshard.Next()).ToList();

            //write the shuffled enemy numbers into shuffled list
            for (int i = 0; i < shuffledenemies.Count(); i++)
            {
                shuffledenemies[i].DatatableLineNumber = enemylines[i];
            }

            //return shuffled list.
            return shuffledenemies;

        }

        public static void WriteEnemyDrops(List<EnemyDropTable> listofenemies , string[] arrline , List<string> spoilernotes)
        {
            //for each enemy in list of enemies
            //read the DatatableLineNumber
            //write the lines based on it.
            for (int i = 0; i < listofenemies.Count(); i++)
            {
                int j = listofenemies[i].DatatableLineNumber;
                arrline[j + 3] = "      \"RareItemId\": \"" + listofenemies[i].RareItemId + "\",";
                arrline[j + 4] = "      \"RareItemQuantity\": " + listofenemies[i].RareItemQuantity + ",";
                arrline[j + 5] = "      \"RareItemRate\": " + listofenemies[i].RareItemRate + ",";
                arrline[j + 6] = "      \"CommonItemId\": \"" + listofenemies[i].CommonItemId + "\",";
                arrline[j + 7] = "      \"CommonItemQuantity\": " + listofenemies[i].CommonItemQuantity + ",";
                arrline[j + 8] = "      \"CommonRate\": " + listofenemies[i].CommonItemRate + ",";
                arrline[j + 9] = "      \"RareIngredientId\": \"" + listofenemies[i].RareIngreditentId + "\",";
                arrline[j + 10] = "      \"RareIngredientQuantity\": " + listofenemies[i].RareIngreditentQuantity + ",";
                arrline[j + 11] = "      \"RareIngredientRate\": " + listofenemies[i].RareIngredientRate + ",";
                arrline[j + 12] = "      \"CommonIngredientId\": \"" + listofenemies[i].CommonIngredientId + "\",";
                arrline[j + 13] = "      \"CommonIngredientQuantity\": " + listofenemies[i].CommonIngredientQuantity + ",";
                arrline[j + 14] = "      \"CommonIngredientRate\": " + listofenemies[i].CommonIngredientRate + ",";

                spoilernotes.Add(listofenemies[i].FriendlyName + " - " + listofenemies[i].DatatableLineNumber); //this could be more clear.

                //
                //due to not knowing what I was going the local list of enemies is actually public
                //because of this I cannot create another base version
                //so either that needs to be fixed or we make this worse by just writing another check
                //we want to take the datalinenumber and createa new lookup table because we overwrote the first one....
                //

            }
            spoilernotes.Add("");//whitespace

        }


    }
}
