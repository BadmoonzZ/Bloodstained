using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{

    //create a tresasure chest class which contains 15 strings for each line we want to write in the datatable
    //we might also want to start creating flags and bools like. zangetsuto required = true.
    public class TreasureChest
    {
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

        public bool RequiresZangetsuto { get; set; }


        public TreasureChest()
        {
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

            RequiresZangetsuto = false;
        }
    }
}
