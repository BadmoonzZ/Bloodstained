using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{

    //create an enemy drop table class which contains x strings for each line we want to write in the datatable
    //we might also want to start creating flags and bools like. location = ship or spehere = zero.
    class EnemyDropTable { 
        
        public string ShardId { get; set; }
        public string ShardRate { get; set; }

        public string RareItemId { get; set; }
        public string RareItemQuantity { get; set; }
        public string RareItemRate { get; set; }

        public string CommonItemId { get; set; }
        public string CommonItemQuantity { get; set; }
        public string CommonItemRate { get; set; }

        public string RareIngreditentId { get; set; }
        public string RareIngreditentQuantity { get; set; }
        public string RareIngredientRate { get; set; }

        public string CommonIngredientId { get; set; }
        public string CommonIngredientQuantity { get; set; }
        public string CommonIngredientRate { get; set; }

        public string CoinType { get; set; }
        public string CoinOverride { get; set; }
        public string CoinRate { get; set; }

        public string FriendlyName { get; set; }
        public int DatatableLineNumber { get; set; }

        public bool EarlyEnemy { get; set; }

        public EnemyDropTable()
        {
            ShardId = "None";
            ShardRate = "0.0";

            RareItemId = "None";
            RareItemQuantity = "0";
            RareItemRate = "0.0";

            CommonItemId = "None";
            CommonItemQuantity = "0";
            CommonItemRate = "0.0";

            RareIngreditentId = "None";
            RareIngreditentQuantity = "0";
            RareIngredientRate = "0.0";

            CommonIngredientId = "None";
            CommonIngredientQuantity = "0";
            CommonIngredientRate = "0.0";

            CoinType = "None";
            CoinOverride = "0";
            CoinRate = "0.0";

            FriendlyName = "Unset";
            DatatableLineNumber = 0;

            EarlyEnemy = false;
        }
        
    }
}
