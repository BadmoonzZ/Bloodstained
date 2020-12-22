using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class ChestRandomizer
    {

        public static List<TreasureChest> CreateChestList() {

            //any manual strings could and should be changed into a variable for easier modulation
            //need to create or import a list of strings that maps to each item
            //for example
            string weapon_invisibleblade = "invisible";
            string weapon_steellightning = "LightningBolt";
            string acces_gaugeglasses = "Measurementglasses";
            string weapon_fragarach = "Flagarach";

            string capacityup = "MaxBulletUP";
            string hpup = "MaxHPUP";
            string mpup = "MaxMPUP";

            //so now we can build each individual chest.
            //there should be an entry for every chest in the datatable. even impossible ones.
            //later we will specifically not write into those.
            TreasureChest Ship_FirstChest = new TreasureChest
            {
                RareItemId = "KungFuShoes",
                RareItemQuantity = "1",
                RareItemRate = "100.0",
                CommonItemId = "Knife",
                CommonItemQuantity = "1",
                CommonItemRate = "100.0",
            };

            TreasureChest Ship_BeforeDoor = new TreasureChest
            {
                RareItemId = "HighPotion",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            TreasureChest Ship_BehindDullahammer = new TreasureChest
            {
                RareItemId = acces_gaugeglasses,
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            TreasureChest Ship_OutsideTopleft = new TreasureChest
            {
                RareItemId = "Tunic",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            //Treasurebox_SIP005
            TreasureChest Ship_BeforeFirstsave = new TreasureChest
            {
                RareItemId = "SpikeBreast",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            //Treasurebox_SIP005
            TreasureChest Ship_FarLeftFirstsave = new TreasureChest
            {
                RareItemId = "Potion",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            //Treasurebox_SIP006
            TreasureChest Ship_BottomWithseema = new TreasureChest
            {
                RareItemId = "Beastberet",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            TreasureChest Ship_LeftTreasureRoom1 = new TreasureChest
            {
                RareItemId = "Carvalin",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_LeftTreasureRoom2 = new TreasureChest
            {
                RareItemId = "SoftPoint",
                RareItemQuantity = "5",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_RightTreasureRoom1 = new TreasureChest
            {
                CoinOverride = "2000",
                CoinType = "D1000",
                CoinRate = "100.0"
            };
            TreasureChest Ship_RightTreasureRoom2 = new TreasureChest
            {
                RareItemId = capacityup,
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_NearFirstBats = new TreasureChest
            {
                RareItemId = "Ginger",
                RareItemQuantity = "1",
                RareItemRate = "100.0",
                CommonItemId = "Hemp",
                CommonItemQuantity = "1",
                CommonItemRate = "100.0",
            };
            TreasureChest Ship_RightsideBelowDeck = new TreasureChest
            {
                RareItemId = weapon_steellightning,
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_BelowDeck = new TreasureChest
            {
                RareItemId = "ShipMap",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_LeftsideBelowDeck = new TreasureChest
            {
                RareItemId = "Softpoint",
                RareItemQuantity = "5",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_TopBelowDeck = new TreasureChest
            {
                RareItemId = "FriedFish",
                RareItemQuantity = "2",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_SecondSaveChest = new TreasureChest
            {
                RareItemId = "SoySauce",
                RareItemQuantity = "1",
                RareItemRate = "100.0",
                CommonItemId = "Miso",
                CommonItemQuantity = "1",
                CommonItemRate = "100.0",
            };
            TreasureChest Ship_LifeboatRoom = new TreasureChest
            {
                RareItemId = "Firemuffler",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_SecretAboveDullahammer = new TreasureChest
            {
                RareItemId = "ShipMap",
                RareItemQuantity = "6",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_SecretWallAboveDullahammer = new TreasureChest
            {
                RareItemId = "ShipMap",
                RareItemQuantity = "7",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_GhostsRoom = new TreasureChest
            {
                RareItemId = "Bloodybone",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_TrippleSeemaChest = new TreasureChest
            {
                RareItemId = weapon_fragarach,
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_TrippleSeemaWall = new TreasureChest
            {
                RareItemId = "Safering",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_FirstRatChest = new TreasureChest
            {
                RareItemId = "Ruby",
                RareItemQuantity = "1",
                RareItemRate = "100.0",
                CommonItemId = "Emerald",
                CommonItemQuantity = "1",
                CommonItemRate = "40.0",
            };
            TreasureChest Ship_BlockPuzzleChest = new TreasureChest
            {
                RareItemId = "Musketon",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_AboveDeckLeftChest = new TreasureChest
            {
                CoinOverride = "2000",
                CoinType = "D1000",
                CoinRate = "100.0"
            };
            TreasureChest Ship_MoneyFarmChest = new TreasureChest
            {
                RareItemId = "HighPotion",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_RatSaveChest = new TreasureChest
            {
                CoinOverride = "1000",
                CoinType = "D1000",
                CoinRate = "100.0"
            };
            TreasureChest Ship_AboveEndofShip = new TreasureChest
            {
                RareItemId = "Feathercrown",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_CaptainsChest1 = new TreasureChest
            {
                RareItemId = hpup,
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_CaptainsChest2 = new TreasureChest
            {
                RareItemId = "Gram",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_Wallabovestart = new TreasureChest
            {
                RareItemId = hpup,
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };
            TreasureChest Ship_Wallbyfirstbats = new TreasureChest
            {
                RareItemId = capacityup,
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            TreasureChest Ship_InvertReqChest = new TreasureChest
            {
                RareItemId = "ShipMap",
                RareItemQuantity = "5",
                RareItemRate = "100.0"
            };

            TreasureChest Vil_KeyBox = new TreasureChest
            {

            };
            TreasureChest Vil_Crafter = new TreasureChest
            {

            };
            TreasureChest Vil_beforetown = new TreasureChest
            {

            };
            TreasureChest Vil_intown = new TreasureChest
            {

            };
            TreasureChest Vil_gebels = new TreasureChest
            {

            };
            TreasureChest Vil_brokenhousetop = new TreasureChest
            {

            };
            TreasureChest Vil_brokenhouseinside = new TreasureChest
            {

            };
            TreasureChest Vil_beforewarp = new TreasureChest
            {

            };
            TreasureChest Vil_abovehalfwayhouse = new TreasureChest
            {

            };
            TreasureChest Vil_halfwayhouse = new TreasureChest
            {

            };
            TreasureChest Vil_abovegate1 = new TreasureChest
            {

            };
            TreasureChest Vil_abovegate2 = new TreasureChest
            {


            };
            TreasureChest Vil_underbrokenhouse = new TreasureChest
            {

            };


            TreasureChest Ent_sabnockchest = new TreasureChest
            { };

            TreasureChest Ent_2 = new TreasureChest
            { };

            TreasureChest Ent_3 = new TreasureChest
            { };

            TreasureChest Ent_4 = new TreasureChest
            { };

            TreasureChest Ent_5 = new TreasureChest
            { };

            TreasureChest Ent_6 = new TreasureChest
            { };

            TreasureChest Ent_7 = new TreasureChest
            { };

            TreasureChest Ent_8 = new TreasureChest
            { };

            TreasureChest Ent_9 = new TreasureChest
            { };

            TreasureChest Ent_10 = new TreasureChest
            { };

            TreasureChest Ent_11 = new TreasureChest
            { };

            TreasureChest Ent_12 = new TreasureChest
            { };

            TreasureChest Ent_13 = new TreasureChest
            { };

            TreasureChest Ent_14 = new TreasureChest
            { };

            TreasureChest Ent_15 = new TreasureChest
            { };

            TreasureChest Ent_16 = new TreasureChest
            { };

            TreasureChest Ent_17 = new TreasureChest
            { };

            TreasureChest Ent_18 = new TreasureChest
            { };

            TreasureChest Ent_19 = new TreasureChest
            { };

            TreasureChest Ent_20 = new TreasureChest
            { };

            TreasureChest Ent_21 = new TreasureChest
            { };
            TreasureChest Ent_22 = new TreasureChest
            { };
            TreasureChest Ent_23 = new TreasureChest
            { };
            TreasureChest Ent_24 = new TreasureChest
            { };
            TreasureChest Ent_25 = new TreasureChest
            { };
            TreasureChest Ent_26 = new TreasureChest
            { };
            TreasureChest Ent_27 = new TreasureChest
            { };
            TreasureChest Ent_wall1 = new TreasureChest
            { };
            TreasureChest Ent_wall2 = new TreasureChest
            { };


            TreasureChest Garden_1 = new TreasureChest
            { };
            TreasureChest Garden_2 = new TreasureChest
            { };
            TreasureChest Garden_3 = new TreasureChest
            { };
            TreasureChest Garden_4 = new TreasureChest
            { };
            TreasureChest Garden_5 = new TreasureChest
            { };
            TreasureChest Garden_6 = new TreasureChest
            { };
            TreasureChest Garden_7 = new TreasureChest
            { };
            TreasureChest Garden_8 = new TreasureChest
            { };
            TreasureChest Garden_9 = new TreasureChest
            { };
            TreasureChest Garden_10 = new TreasureChest
            { };
            TreasureChest Garden_11 = new TreasureChest
            { };
            TreasureChest Garden_12 = new TreasureChest
            { };
            TreasureChest Garden_13 = new TreasureChest
            { };
            TreasureChest Garden_14 = new TreasureChest
            { };
            TreasureChest Garden_15 = new TreasureChest
            { };
            TreasureChest Garden_16 = new TreasureChest
            { };
            TreasureChest Garden_17 = new TreasureChest
            { };
            TreasureChest Garden_18 = new TreasureChest
            { };
            TreasureChest Garden_Aradialwall = new TreasureChest
            {
                RareItemId = "None",
                RareItemQuantity = "1",
                RareItemRate = "100.0"
            };

            TreasureChest Cathedral_1 = new TreasureChest
            { };
            TreasureChest Cathedral_2 = new TreasureChest
            { };
            TreasureChest Cathedral_3 = new TreasureChest
            { };
            TreasureChest Cathedral_4 = new TreasureChest
            { };
            TreasureChest Cathedral_5 = new TreasureChest
            { };
            TreasureChest Cathedral_6 = new TreasureChest
            { };
            TreasureChest Cathedral_7 = new TreasureChest
            { };
            TreasureChest Cathedral_8 = new TreasureChest
            { };
            TreasureChest Cathedral_9 = new TreasureChest
            { };
            TreasureChest Cathedral_10 = new TreasureChest
            { };
            TreasureChest Cathedral_11 = new TreasureChest
            { };
            TreasureChest Cathedral_12 = new TreasureChest
            { };
            TreasureChest Cathedral_13 = new TreasureChest
            { };
            TreasureChest Cathedral_14 = new TreasureChest
            { };
            TreasureChest Cathedral_15 = new TreasureChest
            { };
            TreasureChest Cathedral_16 = new TreasureChest
            { };
            TreasureChest Cathedral_17 = new TreasureChest
            { };
            TreasureChest Cathedral_18 = new TreasureChest
            { };
            TreasureChest Cathedral_19 = new TreasureChest
            { };
            TreasureChest Cathedral_20 = new TreasureChest
            { };
            TreasureChest Cathedral_21 = new TreasureChest
            { };
            TreasureChest Cathedral_22 = new TreasureChest
            { };
            TreasureChest Cathedral_23 = new TreasureChest
            { };
            TreasureChest Cathedral_24 = new TreasureChest
            { };
            TreasureChest Cathedral_25 = new TreasureChest
            { };
            TreasureChest Cathedral_26 = new TreasureChest
            { };
            TreasureChest Cathedral_27 = new TreasureChest
            { };
            TreasureChest Cathedral_28 = new TreasureChest
            { };
            TreasureChest Cathedral_29 = new TreasureChest
            { };
            TreasureChest Cathedral_30 = new TreasureChest
            { };
            TreasureChest Cathedral_31 = new TreasureChest
            { };
            TreasureChest Cathedral_32 = new TreasureChest
            { };
            TreasureChest Cathedral_33 = new TreasureChest
            { };
            TreasureChest Cathedral_34 = new TreasureChest
            { };
            TreasureChest Cathedral_35 = new TreasureChest
            { };
            TreasureChest Cathedral_36 = new TreasureChest
            { };
            TreasureChest Cathedral_37 = new TreasureChest
            { };
            TreasureChest Cathedral_38 = new TreasureChest
            { };
            TreasureChest Cathedral_39 = new TreasureChest
            { };
            TreasureChest Cathedral_40 = new TreasureChest
            { };
            TreasureChest Cathedral_Wall1 = new TreasureChest
            { };
            TreasureChest Cathedral_Wall2 = new TreasureChest
            { };
            TreasureChest Cathedral_Wall3 = new TreasureChest
            { };


            TreasureChest Tower_1 = new TreasureChest
            { };
            TreasureChest Tower_2 = new TreasureChest
            { };
            TreasureChest Tower_3 = new TreasureChest
            { };
            TreasureChest Tower_4 = new TreasureChest
            { };
            TreasureChest Tower_5 = new TreasureChest
            { };
            TreasureChest Tower_6 = new TreasureChest
            { };
            TreasureChest Tower_7 = new TreasureChest
            { };

            //
            //check if using shuffle or chaos
            //if chaos we need to mix chests contents before moving on.
            //

            //make a list of all the chests and then add each one to the list.
            List<TreasureChest> ListOfAllChests = new List<TreasureChest>
            {
                Ship_FirstChest, Ship_BeforeDoor, Ship_BehindDullahammer, Ship_OutsideTopleft, Ship_FarLeftFirstsave , Ship_BeforeFirstsave ,  //6
                Ship_BottomWithseema, Ship_LeftTreasureRoom1, Ship_LeftTreasureRoom2, Ship_RightTreasureRoom1, Ship_RightTreasureRoom2, Ship_NearFirstBats,  //12
                Ship_RightsideBelowDeck, Ship_BelowDeck, Ship_LeftsideBelowDeck, Ship_TopBelowDeck, Ship_SecondSaveChest, Ship_LifeboatRoom,  //18
                Ship_SecretAboveDullahammer, Ship_SecretWallAboveDullahammer, Ship_GhostsRoom, Ship_TrippleSeemaChest, Ship_TrippleSeemaWall, Ship_FirstRatChest,  //24
                Ship_BlockPuzzleChest, Ship_AboveDeckLeftChest, Ship_MoneyFarmChest, Ship_RatSaveChest, Ship_AboveEndofShip, //29
                Ship_CaptainsChest1, Ship_CaptainsChest2, Ship_InvertReqChest, Ship_Wallabovestart, Ship_Wallbyfirstbats, //34
            };

            return ListOfAllChests;

        }
    }
}
