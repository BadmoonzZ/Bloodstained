using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class ChestRandomizer
    {

        static string capacityup = "MaxBulletUP";
        static string hpup = "MaxHPUP";
        static string mpup = "MaxMPUP";

        static string weapon_invisibleblade = "invisible";
        static string weapon_steellightning = "LightningBolt";
        static string acces_gaugeglasses = "Measurementglasses";
        static string weapon_fragarach = "Flagarach";

        //chests in the ship.  there should be 34.
        public static TreasureChest Ship_FirstChest = new TreasureChest
        {
            ChestName = "Ship_FirstChest",
            RareItemId = "KungFuShoes",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            CommonItemId = "Knife",
            CommonItemQuantity = "1",
            CommonItemRate = "100.0",
            ChestId = 53
        };
        public static TreasureChest Ship_BeforeDoor = new TreasureChest
        {
            ChestName = "Ship_BeforeDoor",
            RareItemId = "Potion",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 54
        };
        public static TreasureChest Ship_BehindDullahammer = new TreasureChest
        {
            ChestName = "Ship_BehindDullahammer",
            RareItemId = "RustedRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 55
        };
        public static TreasureChest Ship_OutsideTopleft = new TreasureChest
        {
            ChestName = "Ship_OutsideTopleft",
            RareItemId = "Countrydress",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 56
        };
        public static TreasureChest Ship_BeforeFirstsave = new TreasureChest
        {
            ChestName = "Ship_BeforeFirstsave",
            RareItemId = "Tunic",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 57
        };
        public static TreasureChest Ship_FarLeftFirstsave = new TreasureChest
        {
            ChestName = "Ship_FarLeftFirstsave",
            RareItemId = "Potion",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 58
        };
        public static TreasureChest Ship_BottomWithseema = new TreasureChest
        {
            ChestName = "Ship_BottomWithseema",
            RareItemId = "Headband",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 59
        };
        public static TreasureChest Ship_LeftTreasureRoom1 = new TreasureChest
        {
            ChestName = "Ship_LeftTreasureRoom1",
            RareItemId = "Musketon",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 60
        };
        public static TreasureChest Ship_LeftTreasureRoom2 = new TreasureChest
        {
            ChestName = "Ship_LeftTreasureRoom2",
            RareItemId = "Softpoint",
            RareItemQuantity = "5",
            RareItemRate = "100.0",
            ChestId = 61
        };
        public static TreasureChest Ship_RightTreasureRoom1 = new TreasureChest
        {
            ChestName = "Ship_RightTreasureRoom1",
            CoinOverride = "1000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 81
        };
        public static TreasureChest Ship_RightTreasureRoom2 = new TreasureChest
        {
            ChestName = "Ship_RightTreasureRoom2",
            RareItemId = "MaxMPUP",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 82
        };
        public static TreasureChest Ship_NearFirstBats = new TreasureChest
        {
            ChestName = "Ship_NearFirstBats",
            RareItemId = "Bronze",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Hemp",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Halite",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Sugar",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 62
        };
        public static TreasureChest Ship_RightsideBelowDeck = new TreasureChest
        {
            ChestName = "Ship_RightsideBelowDeck",
            RareItemId = "ShortSword",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 63
        };
        public static TreasureChest Ship_BelowDeck = new TreasureChest
        {
            ChestName = "Ship_BelowDeck",
            RareItemId = "ShipMap",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 66
        };
        public static TreasureChest Ship_LeftsideBelowDeck = new TreasureChest
        {
            ChestName = "Ship_LeftsideBelowDeck",
            RareItemId = "Softpoint",
            RareItemQuantity = "5",
            RareItemRate = "100.0",
            ChestId = 65
        };
        public static TreasureChest Ship_TopBelowDeck = new TreasureChest
        {
            ChestName = "Ship_TopBelowDeck",
            RareItemId = "Bronze",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Hemp",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Halite",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Sugar",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D100",
            CoinOverride = "100",

            ChestId = 64
        };
        public static TreasureChest Ship_SecondSaveChest = new TreasureChest
        {
            ChestName = "Ship_SecondSaveChest",
            RareItemId = "Bronze",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Hemp",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Halite",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Sugar",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 67
        };
        public static TreasureChest Ship_LifeboatRoom = new TreasureChest
        {
            ChestName = "Ship_LifeboatRoom",
            RareItemId = "Turbinemuffler",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 68
        };
        public static TreasureChest Ship_SecretAboveDullahammer = new TreasureChest
        {
            ChestName = "Ship_SecretAboveDullahammer",
            RareItemId = "Triplet",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 69
        };
        public static TreasureChest Ship_SecretWallAboveDullahammer = new TreasureChest
        {
            ChestName = "Ship_SecretWallAboveDullahammer",
            RareItemId = "PlunderersRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 501,
        };
        public static TreasureChest Ship_GhostsRoom = new TreasureChest
        {
            ChestName = "Ship_GhostsRoom",
            RareItemId = "Bronze",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Hemp",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Halite",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Sugar",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 71
        };
        public static TreasureChest Ship_TrippleSeemaChest = new TreasureChest
        {
            ChestName = "Ship_TrippleSeemaChest",
            RareItemId = "Claymore",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 72
        };
        public static TreasureChest Ship_TrippleSeemaWall = new TreasureChest
        {
            ChestName = "Ship_TrippleSeemaWall",
            RareItemId = "Safering",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 502
        };
        public static TreasureChest Ship_FirstRatChest = new TreasureChest
        {
            ChestName = "Ship_FirstRatChest",
            RareItemId = "SeedCorn",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            CommonItemId = "SeedRice",
            CommonItemQuantity = "1",
            CommonItemRate = "100.0",
            RareIngreditentId = "SeedPotato",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "100.0",
            ChestId = 73
        };
        public static TreasureChest Ship_BlockPuzzleChest = new TreasureChest
        {
            ChestName = "Ship_BlockPuzzleChest",
            RareItemId = "Awhip",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 74
        };
        public static TreasureChest Ship_AboveDeckLeftChest = new TreasureChest
        {
            ChestName = "Ship_AboveDeckLeftChest",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 75
        };
        public static TreasureChest Ship_MoneyFarmChest = new TreasureChest
        {
            ChestName = "Ship_MoneyFarmChest",
            RareItemId = "Potion",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 76
        };
        public static TreasureChest Ship_RatSaveChest = new TreasureChest
        {
            ChestName = "Ship_RatSaveChest",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 78
        };
        public static TreasureChest Ship_AboveEndofShip = new TreasureChest
        {
            ChestName = "Ship_AboveEndofShip",
            RareItemId = "MaxBulletUP",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 83,
        };
        public static TreasureChest Ship_CaptainsChest1 = new TreasureChest
        {
            ChestName = "Ship_CaptainsChest1",
            RareItemId = "MaxBulletUP",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 79,
        };
        public static TreasureChest Ship_CaptainsChest2 = new TreasureChest
        {
            ChestName = "Ship_CaptainsChest2",
            RareItemId = "Carvalin",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 80,
        };
        public static TreasureChest Ship_Wallabovestart = new TreasureChest
        {
            ChestName = "Ship_Wallabovestart",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 499,
        };
        public static TreasureChest Ship_Wallbyfirstbats = new TreasureChest
        {
            ChestName = "Ship_Wallbyfirstbats",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 500
        };
        public static TreasureChest Ship_CrowsNest = new TreasureChest
        {
            ChestName = "Ship_CrowsNest",
            RareItemId = "WorldfashionNo12",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 491,
        };
        //end ship chests.  34 in total

        //village extras chests.  there should be 3.
        public static TreasureChest Vil_KeyBox = new TreasureChest
        {
            ChestName = "Vil_KeyBox",
            RareItemId = "VillageKey",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 19,
        };
        public static TreasureChest Vil_Crafter = new TreasureChest
        {
            ChestName = "Vil_Crafter",
            RareItemId = "BatFeather",
            RareItemQuantity = "3",
            RareItemRate = "100.0",
            CommonItemId = "MeltedBone",
            CommonItemQuantity = "3",
            CommonItemRate = "100.0",
            RareIngreditentId = "Iron",
            RareIngreditentQuantity = "3",
            RareIngredientRate = "100.0",
            CommonIngredientId = "Bronze",
            CommonIngredientQuantity = "4",
            CommonIngredientRate = "100.0",
            ChestId = 18,
        };
        public static TreasureChest Vil_gebels = new TreasureChest
        {
            ChestName = "Vil_gebels",
            RareItemId = "Gebelsglasses",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 87,
        };
        //end village extras chests. 3 in total.

        //village chests.  10 in total.
        public static TreasureChest Vil_beforetown = new TreasureChest
        {
            ChestName = "Vil_beforetown",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 85,
        };
        public static TreasureChest Vil_intown = new TreasureChest
        {
            ChestName = "Vil_intown",
            RareItemId = "Waystone",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 86,
        };
        public static TreasureChest Vil_brokenhousetop = new TreasureChest
        {
            ChestName = "Vil_brokenhousetop",
            RareItemId = "Elfearcap",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 88,
        };
        public static TreasureChest Vil_brokenhouseinside = new TreasureChest
        {
            ChestName = "Vil_brokenhouseinside",
            RareItemId = "Hollowpoint",
            RareItemQuantity = "5",
            RareItemRate = "100.0",
            ChestId = 89,
        };
        public static TreasureChest Vil_beforewarp = new TreasureChest
        {
            ChestName = "Vil_beforewarp",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 90,
        };
        public static TreasureChest Vil_abovehalfwayhouse = new TreasureChest
        {
            ChestName = "Vil_abovehalfwayhouse",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 91,
        };
        public static TreasureChest Vil_halfwayhouse = new TreasureChest
        {
            ChestName = "Vil_halfwayhouse",
            RareItemId = "Baselard",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 92,
        };
        public static TreasureChest Vil_abovegate1 = new TreasureChest
        {
            ChestName = "Vil_abovegate1",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 93,
        };
        public static TreasureChest Vil_abovegate2 = new TreasureChest
        {
            ChestName = "Vil_abovegate2",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 94,
        };
        public static TreasureChest Vil_underbrokenhouse = new TreasureChest
        {
            ChestName = "Vil_underbrokenhouse",
            RareItemId = "8BitCoin",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 95,
        };
        //end village chests. 10 in total

        //entrance chests  there should be 25 in total
        public static TreasureChest Ent_sabnockright = new TreasureChest
        {
            ChestName = "Ent_sabnockright",
            RareItemId = "Skinbreastplate",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 97,
        };
        public static TreasureChest Ent_sabonckleft = new TreasureChest
        {
            ChestName = "Ent_sabonckleft",
            RareItemId = "Iron",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "ElmLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Bronze",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Hemp",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinOverride = "50",
            ChestId = 98,
        };
        public static TreasureChest Ent_ForgottenAreaOverhang = new TreasureChest
        {
            ChestName = "Ent_ForgottenAreaOverhang",
            CoinOverride = "1000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 99,
        };
        public static TreasureChest Ent_PostGhostFarm = new TreasureChest
        {
            ChestName = "Ent_PostGhostFarm",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 100,
        };
        public static TreasureChest Ent_MiddleGhost = new TreasureChest
        {
            ChestName = "Ent_MiddleGhost",
            RareItemId = "Ether",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 101,
        };
        public static TreasureChest Ent_LeftGhost = new TreasureChest
        {
            ChestName = "Ent_LeftGhost",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 102,
        };
        public static TreasureChest Ent_Behindthedoor = new TreasureChest
        {
            ChestName = "Ent_Behindthedoor",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 103,
        };
        public static TreasureChest Ent_Rightmidsection = new TreasureChest
        {
            ChestName = "Ent_Rightmidsection",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Obsidian",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Iron",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "ElmLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinOverride = "50",
            ChestId = 104,
        };
        public static TreasureChest Ent_leftmidsection = new TreasureChest
        {
            ChestName = "Ent_leftmidsection",
            RareItemId = "Branderbus",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 105,
        };
        public static TreasureChest Ent_midsection = new TreasureChest
        {
            ChestName = "Ent_midsection",
            RareItemId = "KillerBoots",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 107,
        };
        public static TreasureChest Ent_PreZangetsu = new TreasureChest
        {
            ChestName = "Ent_PreZangetsu",
            RareItemId = "ItemRecipe001",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 108,
        };
        public static TreasureChest Ent_ChandaleersTopLeft = new TreasureChest
        {
            ChestName = "Ent_ChandaleersTopLeft",
            RareItemId = "Waystone",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 111,
        };
        public static TreasureChest Ent_ChandaleersLedge = new TreasureChest
        {
            ChestName = "Ent_ChandaleersLedge",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 112,
        };
        public static TreasureChest Ent_ChandaleersBottom = new TreasureChest
        {
            ChestName = "Ent_ChandaleersBottom",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 113,
        };
        public static TreasureChest Ent_eeooWall = new TreasureChest
        {
            ChestName = "Ent_eeooWall",
            RareItemId = "WolfBalt",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 505,
        };
        public static TreasureChest Ent_ColumnDemon = new TreasureChest
        {
            ChestName = "Ent_ColumnDemon",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Obsidian",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Iron",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "ElmLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinOverride = "50",
            ChestId = 115,
        };
        public static TreasureChest Ent_ColumnBonemorte = new TreasureChest
        {
            ChestName = "Ent_ColumnBonemorte",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Obsidian",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Iron",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "ElmLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinOverride = "50",
            ChestId = 116,
        };
        public static TreasureChest Ent_Santaroom1 = new TreasureChest
        {
            ChestName = "Ent_Santaroom1",
            RareItemId = "Santacap",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 117,
        };
        public static TreasureChest Ent_Santaroom2 = new TreasureChest
        {
            ChestName = "Ent_Santaroom2",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 118,
        };
        public static TreasureChest Ent_SafetyCrashRoom = new TreasureChest
        {
            ChestName = "Ent_SafetyCrashRoom",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 119,
        };
        public static TreasureChest Ent_NearOriental = new TreasureChest
        {
            ChestName = "Ent_NearOriental",
            RareItemId = "Crowhat",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 120,
        };
        public static TreasureChest Ent_ForgottenRoom1 = new TreasureChest
        {
            ChestName = "Ent_ForgottenRoom1",
            RareItemId = "DishRecipe005",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 121,
        };
        public static TreasureChest Ent_ForgottenRoom2 = new TreasureChest
        {
            ChestName = "Ent_ForgottenRoom2",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 122,
        };
        public static TreasureChest Ent_ForgottenRoom3 = new TreasureChest
        {
            ChestName = "Ent_ForgottenRoom3",
            RareItemId = "Emerald",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Silver",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinOverride = "100",
            ChestId = 123,
        };
        public static TreasureChest Ent_ForgottenWall = new TreasureChest
        {
            ChestName = "Ent_ForgottenWall",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 504,
        };
        //end entrance chests. 25 chests

        //garden chests.  should be 19.
        public static TreasureChest Garden_MocoweedDropdown = new TreasureChest
        {
            ChestName = "Garden_MocoweedDropdown",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 125,
        };
        public static TreasureChest Garden_PlumeParmaCooridor = new TreasureChest
        {
            ChestName = "Garden_PlumeParmaCooridor",
            RareItemId = "Morgenstern",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 126,
        };
        public static TreasureChest Garden_PresidentChest = new TreasureChest
        {
            ChestName = "Garden_PresidentChest",
            RareItemId = "Beastberet",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 127,
        };
        public static TreasureChest Garden_SwampGroundChest = new TreasureChest
        {
            ChestName = "Garden_SwampGroundChest",
            RareItemId = "ArmsRecipe004",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 128,
        };
        public static TreasureChest Garden_AboveCoachLeft = new TreasureChest
        {
            ChestName = "Garden_AboveCoachLeft",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 129,
        };
        public static TreasureChest Garden_AboveRightDoor = new TreasureChest
        {
            ChestName = "Garden_AboveRightDoor",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 130,
        };
        public static TreasureChest Garden_AboveCoachRight = new TreasureChest
        {
            ChestName = "Garden_AboveCoachRight",
            RareItemId = "KungFuBest",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 131,
        };
        public static TreasureChest Garden_TransitionEastGarden = new TreasureChest
        {
            ChestName = "Garden_TransitionEastGarden",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 132,
        };
        public static TreasureChest Garden_DontFall = new TreasureChest
        {
            ChestName = "Garden_DontFall",
            RareItemId = "ItemRecipe003",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 133,
        };
        public static TreasureChest Garden_AbovePiano = new TreasureChest
        {
            ChestName = "Garden_AbovePiano",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 134,
        };
        public static TreasureChest Garden_ZooStairs = new TreasureChest
        {
            ChestName = "Garden_ZooStairs",
            RareItemId = "Ginger",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Steel",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Cotton",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "OakLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinOverride = "50",
            ChestId = 135,
        };
        public static TreasureChest Garden_ThroughWall1 = new TreasureChest
        {
            ChestName = "Garden_ThroughWall1",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 136,
        };
        public static TreasureChest Garden_ThroughWall2 = new TreasureChest
        {
            ChestName = "Garden_ThroughWall2",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 137,
        };
        public static TreasureChest Garden_InvertChest = new TreasureChest
        {
            ChestName = "Garden_InvertChest",
            RareItemId = "Blackbelt",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 138,
        };
        public static TreasureChest Garden_BottomGussian = new TreasureChest
        {
            ChestName = "Garden_BottomGussian",
            RareItemId = "Ginger",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Steel",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Cotton",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "OakLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinOverride = "50",
            ChestId = 139,
        };
        public static TreasureChest Garden_AfterWell = new TreasureChest
        {
            ChestName = "Garden_AfterWell",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 140,
        };
        public static TreasureChest Garden_TopGussian = new TreasureChest
        {
            ChestName = "Garden_TopGussian",
            RareItemId = "Moonring",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 141,
        };
        public static TreasureChest Garden_FinalGardenTransition = new TreasureChest
        {
            ChestName = "Garden_FinalGardenTransition",
            RareItemId = "Potion",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 142,
        };
        public static TreasureChest Garden_Aradialwall = new TreasureChest
        {
            ChestName = "Garden_Aradialwall",
            RareItemId = "FriedEgg",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 507,
        };
        //end garden chests.  there are 19

        //cathedral chests.  I think there are 36
        public static TreasureChest Cathedral_FirstLargeReflectorbottom = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeReflectorbottom",
            RareItemId = "McAutil",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 146,
        };
        public static TreasureChest Cathedral_FirstLargeOrientalLeft = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeOrientalLeft",
            RareItemId = "WorldfashionNo02",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 147,
        };
        public static TreasureChest Cathedral_FirstLargeOrientalRight = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeOrientalRight",
            RareItemId = "Potion",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 148,
        };
        public static TreasureChest Cathedral_FirstLargeBell = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeBell",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 149,
        };
        public static TreasureChest Cathedral_FirstLargeOrientalBell = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeOrientalBell",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 150,
        };
        public static TreasureChest Cathedral_FirstLargeReflectorright = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeReflectorright",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 151,
        };
        public static TreasureChest Cathedral_FirstLargeTopLeft = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeTopLeft",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Obsidian",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Iron",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "ElmLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D50",
            CoinOverride = "50",
            ChestId = 152,
        };
        public static TreasureChest Cathedral_FirstLargeTopRight = new TreasureChest
        {
            ChestName = "Cathedral_FirstLargeTopRight",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 153,
        };
        public static TreasureChest Cathedral_BelowTodd = new TreasureChest
        {
            ChestName = "Cathedral_BelowTodd",
            RareItemId = "DanceMask",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 154,
        };
        public static TreasureChest Cathedral_AcrossTodd = new TreasureChest
        {
            ChestName = "Cathedral_AcrossTodd",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 155,
        };
        public static TreasureChest Cathedral_DshiftLever = new TreasureChest
        {
            ChestName = "Cathedral_DshiftLever",
            RareItemId = "WorldfashionNo10",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 158,
        };
        public static TreasureChest Cathedral_UnderBloodbringer = new TreasureChest
        {
            ChestName = "Cathedral_UnderBloodbringer",
            RareItemId = "Worldfashionfirstissue",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 159,
        };
        public static TreasureChest Cathedral_Craftwork2 = new TreasureChest
        {
            ChestName = "Cathedral_Craftwork2",
            RareItemId = "UnicornRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 161,
        };
        public static TreasureChest Cathedral_Craftwork1 = new TreasureChest
        {
            ChestName = "Cathedral_Craftwork1",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 162,
        };
        public static TreasureChest Cathedral_CraftworkSilverknightchest = new TreasureChest
        {
            ChestName = "Cathedral_CraftworkSilverknightchest",
            RareItemId = "CrusadeArmor",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 163,
        };
        public static TreasureChest Cathedral_SilverknightGlobe1 = new TreasureChest
        {
            ChestName = "Cathedral_SilverknightGlobe1",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 165,
        };
        public static TreasureChest Cathedral_SilverknightGlobe2 = new TreasureChest
        {
            ChestName = "Cathedral_SilverknightGlobe2",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 166,
        };
        public static TreasureChest Cathedral_Bottomleftside = new TreasureChest
        {
            ChestName = "Cathedral_Bottomleftside",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 167,
        };
        public static TreasureChest Cathedral_Topright = new TreasureChest
        {
            ChestName = "Cathedral_Topright",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 168,
        };
        public static TreasureChest Cathedral_Guardedbyspear = new TreasureChest
        {
            ChestName = "Cathedral_Guardedbyspear",
            RareItemId = "ScrambledEggs",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 169,
        };
        public static TreasureChest Cathedral_Topleft = new TreasureChest
        {
            ChestName = "Cathedral_Topleft",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 170,
        };
        public static TreasureChest Cathedral_Belllessbell = new TreasureChest
        {
            ChestName = "Cathedral_Belllessbell",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 171,
        };
        public static TreasureChest Cathedral_Bellgatechest = new TreasureChest
        {
            ChestName = "Cathedral_Bellgatechest",
            RareItemId = "DishRecipe010",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 172,
        };
        public static TreasureChest Cathedral_Topleftbreakablebells = new TreasureChest
        {
            ChestName = "Cathedral_Topleftbreakablebells",
            RareItemId = "ArmsRecipe019",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 174,
        };
        public static TreasureChest Cathedral_Toprightbreakbalebells = new TreasureChest
        {
            ChestName = "Cathedral_Toprightbreakbalebells",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 175,
        };
        public static TreasureChest Cathedral_InsideCenterBell = new TreasureChest
        {
            ChestName = "Cathedral_InsideCenterBell",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 176,
        };
        public static TreasureChest Cathedral_Shieldoutsider = new TreasureChest
        {
            ChestName = "Cathedral_Shieldoutsider",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 177,
        };
        public static TreasureChest Cathedral_TopDemonDoorLeft = new TreasureChest
        {
            ChestName = "Cathedral_TopDemonDoorLeft",
            RareItemId = "Keyofbacker1",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 178,
        };
        public static TreasureChest Cathedral_TopDemonDoorRight = new TreasureChest
        {
            ChestName = "Cathedral_TopDemonDoorRight",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 179,
        };
        public static TreasureChest Cathedral_TopDemonDoorGround = new TreasureChest
        {
            ChestName = "Cathedral_TopDemonDoorGround",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 180,
        };
        public static TreasureChest Cathedral_TopDemonDoorCenterBell = new TreasureChest
        {
            ChestName = "Cathedral_TopDemonDoorCenterBell",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 181,
        };
        public static TreasureChest Cathedral_OcypeteChest = new TreasureChest
        {
            ChestName = "Cathedral_OcypeteChest",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 182,
        };
        public static TreasureChest Cathedral_PostBloodless = new TreasureChest
        {
            ChestName = "Cathedral_PostBloodless",
            RareItemId = "Redumbrella",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 183,
        };
        public static TreasureChest Cathedral_WallAcrossShortcut = new TreasureChest
        {
            ChestName = "Cathedral_WallAcrossShortcut",
            RareItemId = "FriedEgg",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 509,
        };
        public static TreasureChest Cathedral_WallBeforeTodd = new TreasureChest
        {
            ChestName = "Cathedral_WallBeforeTodd",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 510,
        };
        public static TreasureChest Cathedral_BellsWall = new TreasureChest
        {
            ChestName = "Cathedral_BellsWall",
            RareItemId = "RoseRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 511,
        };
        //end cathedral chests  should be 36

        //tower chests.  should be 32
        public static TreasureChest Tower_FirstCelano = new TreasureChest
        {
            ChestName = "Tower_FirstCelano",
            RareItemId = "Ginger",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Steel",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Cotton",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "OakLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D50",
            CoinOverride = "50",
            ChestId = 185,
        };
        public static TreasureChest Tower_BeforeLibrary = new TreasureChest
        {
            ChestName = "Tower_BeforeLibrary",
            RareItemId = "Ether",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 188,
        };
        public static TreasureChest Tower_MidElevatorLeft = new TreasureChest
        {
            ChestName = "Tower_MidElevatorLeft",
            RareItemId = "Breathingforcedmask",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 189,
        };
        public static TreasureChest Tower_AbovePaintingHall = new TreasureChest
        {
            ChestName = "Tower_AbovePaintingHall",
            RareItemId = "GadgetBand",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 190,
        };
        public static TreasureChest Tower_DullaheadSpamRoom = new TreasureChest
        {
            ChestName = "Tower_DullaheadSpamRoom",
            RareItemId = "Emerald",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Silver",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 192,
        };
        public static TreasureChest Tower_ElevatorTopLeft = new TreasureChest
        {
            ChestName = "Tower_ElevatorTopLeft",
            RareItemId = "BalletRecipe002",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 193,
        };
        public static TreasureChest Tower_InsideElevatorMiddle = new TreasureChest
        {
            ChestName = "Tower_InsideElevatorMiddle",
            RareItemId = "Partizan",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 194,
        };
        public static TreasureChest Tower_ElevatorTopRight = new TreasureChest
        {
            ChestName = "Tower_ElevatorTopRight",
            RareItemId = "Emerald",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Silver",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 195,
        };
        public static TreasureChest Tower_RightAttic = new TreasureChest
        {
            ChestName = "Tower_RightAttic",
            RareItemId = "Emerald",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Silver",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 196,
        };
        public static TreasureChest Tower_BigGearRoom = new TreasureChest
        {
            ChestName = "Tower_BigGearRoom",
            RareItemId = "HighPotion",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 197,
        };
        public static TreasureChest Tower_AboveValac = new TreasureChest
        {
            ChestName = "Tower_AboveValac",
            RareItemId = "HighPotion",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 200,
        };
        public static TreasureChest Tower_GearAdventure = new TreasureChest
        {
            ChestName = "Tower_GearAdventure",
            RareItemId = "RemoteDart",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 201,
        };
        public static TreasureChest Tower_WhirligigLower = new TreasureChest
        {
            ChestName = "Tower_WhirligigLower",
            RareItemId = "Ginger",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Steel",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Cotton",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "OakLumber",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D50",
            CoinOverride = "50",
            ChestId = 202,
        };
        public static TreasureChest Tower_LowerTowerWolfman = new TreasureChest
        {
            ChestName = "Tower_LowerTowerWolfman",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 203,
        };
        public static TreasureChest Tower_LowerTowerBackBottom = new TreasureChest
        {
            ChestName = "Tower_LowerTowerBackBottom",
            RareItemId = "WorldfashionNo06",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 204,
        };
        public static TreasureChest Tower_LowerTowerExit = new TreasureChest
        {
            ChestName = "Tower_LowerTowerExit",
            RareItemId = "sunglasses",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 205,
        };
        public static TreasureChest Tower_WhirligigUpper = new TreasureChest
        {
            ChestName = "Tower_WhirligigUpper",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 206,
        };
        public static TreasureChest Tower_LowerTowerTopLeft = new TreasureChest
        {
            ChestName = "Tower_LowerTowerTopLeft",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 207,
        };
        public static TreasureChest Tower_UpperTowerSoftlockTrap = new TreasureChest
        {
            ChestName = "Tower_UpperTowerSoftlockTrap",
            RareItemId = "Emerald",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Silver",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 208,
        };
        public static TreasureChest Tower_FrogsAndCandles2 = new TreasureChest
        {
            ChestName = "Tower_FrogsAndCandles2",
            RareItemId = "WorldfashionNo07",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 209,
        };
        public static TreasureChest Tower_UpperTowerFirstDeadend = new TreasureChest
        {
            ChestName = "Tower_UpperTowerFirstDeadend",
            RareItemId = "Emerald",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Silver",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 210,
        };
        public static TreasureChest Tower_FrogsAndCandles1 = new TreasureChest
        {
            ChestName = "Tower_FrogsAndCandles1",
            RareItemId = "DishRecipe007",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 211,
        };
        public static TreasureChest Tower_UpperTowerTopExit = new TreasureChest
        {
            ChestName = "Tower_UpperTowerTopExit",
            RareItemId = "SteamFlatWideEnd",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 212,
        };
        public static TreasureChest Tower_UpperTowerTopLeft = new TreasureChest
        {
            ChestName = "Tower_UpperTowerTopLeft",
            RareItemId = "DishRecipe004",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 213,
        };
        public static TreasureChest Tower_UpperTowerTopperLeft = new TreasureChest
        {
            ChestName = "Tower_UpperTowerTopperLeft",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 214,
        };
        public static TreasureChest Tower_UpperTowerWolfman = new TreasureChest
        {
            ChestName = "Tower_UpperTowerWolfman",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 215,
        };
        public static TreasureChest Tower_BromideChest = new TreasureChest
        {
            ChestName = "Tower_BromideChest",
            RareItemId = "Silverbromide",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 216,
        };
        public static TreasureChest Tower_AegisPlateChest = new TreasureChest
        {
            ChestName = "Tower_AegisPlateChest",
            RareItemId = "BreastplateofAguilar",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 217,
        };
        public static TreasureChest Tower_BelowBromide = new TreasureChest
        {
            ChestName = "Tower_BelowBromide",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 219,
        };
        public static TreasureChest Tower_DellaheadSpamWall = new TreasureChest
        {
            ChestName = "Tower_DellaheadSpamWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 520,
        };
        public static TreasureChest Tower_BigGearRoomWall = new TreasureChest
        {
            ChestName = "Tower_BigGearRoomWall",
            RareItemId = weapon_invisibleblade,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 521,
        };
        public static TreasureChest Tower_BeforeValacWall = new TreasureChest
        {
            ChestName = "Tower_BeforeValacWall",
            RareItemId = "RidingHabit",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 522,
        };
        //end tower chests. 32 chests.


        //libre chests. I think there are 18.
        public static TreasureChest Libre_GussianTraps = new TreasureChest
        {
            ChestName = "Libre_GussianTraps",
            RareItemId = "Emerald",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Silver",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 221,
        };
        public static TreasureChest Libre_VrukielChest = new TreasureChest
        {
            ChestName = "Libre_VrukielChest",
            RareItemId = "DishRecipe008",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 223,
        };
        public static TreasureChest Libre_RulshaRoom = new TreasureChest
        {
            ChestName = "Libre_RulshaRoom",
            RareItemId = "Waystone",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 224
        };
        public static TreasureChest Libre_UnderOD1 = new TreasureChest
        {
            ChestName = "Libre_UnderOD1",
            RareItemId = "NoseEyeglasses",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 225,
        };
        public static TreasureChest Libre_UnderOD2 = new TreasureChest
        {
            ChestName = "Libre_UnderOD2",
            RareItemId = "MacaroniAndCheese",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 226,
        };
        public static TreasureChest Libre_AndrealphusChest = new TreasureChest
        {
            ChestName = "Libre_AndrealphusChest",
            RareItemId = "FeatherCrown",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 227,
        };
        public static TreasureChest Libre_Grinder = new TreasureChest
        {
            ChestName = "Libre_Grinder",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 228,
        };
        public static TreasureChest Libre_AboveChairMimic = new TreasureChest
        {
            ChestName = "Libre_AboveChairMimic",
            RareItemId = "Garlic",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "WalnutLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "50.0",
            RareIngreditentId = "DamascusSteel",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Mithril",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 230,
        };
        public static TreasureChest Libre_BehindDragon = new TreasureChest
        {
            ChestName = "Libre_BehindDragon",
            RareItemId = "ArmsRecipe007",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 232,
        };
        public static TreasureChest Libre_AnnoyingInvert = new TreasureChest
        {
            ChestName = "Libre_AnnoyingInvert",
            RareItemId = "Thunderscirclet",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 233,
        };
        public static TreasureChest Libre_AboveMimic = new TreasureChest
        {
            ChestName = "Libre_AboveMimic",
            RareItemId = "Garlic",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "WalnutLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "50.0",
            RareIngreditentId = "DamascusSteel",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Mithril",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 234,
        };
        public static TreasureChest Libre_BehindOtherDragon = new TreasureChest
        {
            ChestName = "Libre_BehindOtherDragon",
            RareItemId = "DishRecipe011",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 235,
        };
        public static TreasureChest Libre_PastOtherChair = new TreasureChest
        {
            ChestName = "Libre_PastOtherChair",
            RareItemId = "Garlic",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "WalnutLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "50.0",
            RareIngreditentId = "DamascusSteel",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Mithril",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 236,
        };
        public static TreasureChest Libre_CeilingRoom = new TreasureChest
        {
            ChestName = "Libre_CeilingRoom",
            RareItemId = "Dentistshat",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 237,
        };
        public static TreasureChest Libre_BehindBookcase = new TreasureChest
        {
            ChestName = "Libre_BehindBookcase",
            RareItemId = "Crowmask",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 240,
        };
        public static TreasureChest Libre_DoubleDemonWall = new TreasureChest
        {
            ChestName = "Libre_DoubleDemonWall",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 516,
        };
        public static TreasureChest Libre_BehindDragonWall = new TreasureChest
        {
            ChestName = "Libre_BehindDragonWall",
            RareItemId = "Walkerking",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 517,
        };
        public static TreasureChest Libre_LargeRoomLeftWall = new TreasureChest
        {
            ChestName = "Libre_LargeRoomLeftWall",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 518,
        };
        //end libre chests.  18 chest


        //train chest. 6
        public static TreasureChest Train_HiddenCarLeft = new TreasureChest
        {
            ChestName = "Train_HiddenCarLeft",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 242,
        };
        public static TreasureChest Train_HiddenCarRight = new TreasureChest
        {
            ChestName = "Train_HiddenCarRight",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 243,
        };
        public static TreasureChest Train_CarJunction = new TreasureChest
        {
            ChestName = "Train_CarJunction",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 244,
        };
        public static TreasureChest Train_LuxuryCar = new TreasureChest
        {
            ChestName = "Train_LuxuryCar",
            RareItemId = "ShiroTorujiro",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 245,
        };
        public static TreasureChest Train_NearLever = new TreasureChest
        {
            ChestName = "Train_NearLever",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 246,
        };
        public static TreasureChest Train_WallAfterTrain = new TreasureChest
        {
            ChestName = "Train_WallAfterTrain",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 524,
        };
        //end train chests. 6

        //hall chests.  should be 21.
        public static TreasureChest Hall_AboveSave = new TreasureChest
        {
            ChestName = "Hall_AboveSave",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 249,
        };
        public static TreasureChest Hall_BloodBringer = new TreasureChest
        {
            ChestName = "Hall_BloodBringer",
            RareItemId = "ItemRecipe002",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 250,
        };
        public static TreasureChest Hall_AxeOutsider = new TreasureChest
        {
            ChestName = "Hall_AxeOutsider",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            CoinRate = "100",
            ChestId = 251,
        };
        public static TreasureChest Hall_Archdemon = new TreasureChest
        {
            ChestName = "Hall_Archdemon",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 253,
        };
        public static TreasureChest Hall_Smallhub = new TreasureChest
        {
            ChestName = "Hall_Smallhub",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 254,
        };
        public static TreasureChest Hall_RightofHub = new TreasureChest
        {
            ChestName = "Hall_RightofHub",
            RareItemId = "ArmsRecipe018",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 255,
        };
        public static TreasureChest Hall_LeftofHub = new TreasureChest
        {
            ChestName = "Hall_LeftofHub",
            RareItemId = "Burtgang",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 256,
        };
        public static TreasureChest Hall_BottomLeftofHub = new TreasureChest
        {
            ChestName = "Hall_BottomLeftofHub",
            RareItemId = "SpongeCake",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "Mithril",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Felt",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "50.0",
            CommonIngredientId = "Platinum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "20.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 257,
        };
        public static TreasureChest Hall_ChristosPainting = new TreasureChest
        {
            ChestName = "Hall_ChristosPainting",
            RareItemId = "WorldfashionNo11",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 258,
        };
        public static TreasureChest Hall_Before8bit1 = new TreasureChest
        {
            ChestName = "Hall_Before8bit1",
            RareItemId = "Gram",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 259,
        };
        public static TreasureChest Hall_Before8bit2 = new TreasureChest
        {
            ChestName = "Hall_Before8bit2",
            RareItemId = "Keyofbacker4",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 260,
        };
        public static TreasureChest Hall_Before8bit3 = new TreasureChest
        {
            ChestName = "Hall_Before8bit3",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 261,
        };
        public static TreasureChest Hall_Before8bit4 = new TreasureChest
        {
            ChestName = "Hall_Before8bit4",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 262,
        };
        public static TreasureChest Hall_Before8bit5 = new TreasureChest
        {
            ChestName = "Hall_Before8bit5",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 263,
        };
        public static TreasureChest Hall_GebelStaircaseTop = new TreasureChest
        {
            ChestName = "Hall_GebelStaircaseTop",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 265,
        };
        public static TreasureChest Hall_GebelStaircaseBottom = new TreasureChest
        {
            ChestName = "Hall_GebelStaircaseBottom",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 266,
        };
        public static TreasureChest Hall_GebelCeilingCorner = new TreasureChest
        {
            ChestName = "Hall_GebelCeilingCorner",
            RareItemId = "ArmsRecipe020",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 267,
        };
        public static TreasureChest Hall_Reward8bit = new TreasureChest
        {
            ChestName = "Hall_Reward8bit",
            RareItemId = "Medal022",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 269,
        };
        public static TreasureChest Hall_HiddenRoom = new TreasureChest
        {
            ChestName = "Hall_HiddenRoom",
            RareItemId = "Measurementglasses",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 272,
        };
        public static TreasureChest Hall_FirstroomWall = new TreasureChest
        {
            ChestName = "Hall_FirstroomWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 513,
        };
        public static TreasureChest Hall_TitaniaWall = new TreasureChest
        {
            ChestName = "Hall_TitaniaWall",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 514,
        };
        //end hall chests. 21.


        //underground chests. perhaps 53?
        public static TreasureChest UG_BuerSideRoom = new TreasureChest
        {
            ChestName = "UG_BuerSideRoom",
            RareItemId = "BalletRecipe001",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 274,
        };
        public static TreasureChest UG_NearWaterfallWall = new TreasureChest
        {
            ChestName = "UG_NearWaterfallWall",
            RareItemId = "Rennet",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Emerald",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 276,
        };
        public static TreasureChest UG_WaterfallRight = new TreasureChest
        {
            ChestName = "UG_WaterfallRight",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 277,
        };
        public static TreasureChest UG_WaterfallLeft = new TreasureChest
        {
            ChestName = "UG_WaterfallLeft",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 278,
        };
        public static TreasureChest UG_WaterfallTop = new TreasureChest
        {
            ChestName = "UG_WaterfallTop",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 279,
        };
        public static TreasureChest UG_BigSinkerLeft = new TreasureChest
        {
            ChestName = "UG_BigSinkerLeft",
            RareItemId = "Rennet",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Emerald",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 280,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_BigSinkerRight = new TreasureChest
        {
            ChestName = "UG_BigSinkerRight",
            RareItemId = "Rennet",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Emerald",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 281,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_DemonAboveShovelWall = new TreasureChest
        {
            //was UG_DemonSideroom
            ChestName = "UG_DemonAboveShovelWall",
            RareItemId = "ArmsRecipe003",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 282,
        };
        public static TreasureChest UG_BigRoomShovel = new TreasureChest
        {
            ChestName = "UG_BigRoomShovel",
            RareItemId = "Rennet",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Emerald",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 284,
        };
        public static TreasureChest UG_BigRoomCandle = new TreasureChest
        {
            ChestName = "UG_BigRoomCandle",
            RareItemId = "DishRecipe006",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 285,
        };
        public static TreasureChest UG_BigRoomCenterLeft = new TreasureChest
        {
            ChestName = "UG_BigRoomCenterLeft",
            RareItemId = "Rennet",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Emerald",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 286,
        };
        public static TreasureChest UG_BigRoomTopLeft = new TreasureChest
        {
            ChestName = "UG_BigRoomTopLeft",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 287,
        };
        public static TreasureChest UG_DemonRightofBigRoom = new TreasureChest
        {
            //was called EasytomissRoom
            ChestName = "UG_DemonRightofBigRoom",
            RareItemId = "Walkerking",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 288,
        };
        public static TreasureChest UG_AboveBigRoom = new TreasureChest
        {
            //was PoisonToad
            ChestName = "UG_AboveBigRoom",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 289,
        };
        public static TreasureChest UG_SingleSinker = new TreasureChest
        {
            //was EntranceSinker
            ChestName = "UG_SingleSinker",
            RareItemId = "FriedFish",
            RareItemQuantity = "2",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 300,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_BermudaTriangleSinkerLeft = new TreasureChest
        {
            ChestName = "UG_BermudaTriangleSinkerLeft",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 303,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_BermudaTriangleSinkerTopRight = new TreasureChest
        {
            ChestName = "UG_BermudaTriangleSinkerTopRight",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 304,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_BermudaTriangleSinkerBotRight = new TreasureChest
        {
            ChestName = "UG_BermudaTriangleSinkerBotRight",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 305,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_SinkerTrioTop = new TreasureChest
        {
            ChestName = "UG_SinkerTrioTop",
            CoinOverride = "500",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 306,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_SinkerTrioMid = new TreasureChest
        {
            ChestName = "UG_SinkerTrioMid",
            RareItemId = "Striderbelt",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 307,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_SinkerTrioBottom = new TreasureChest
        {
            ChestName = "UG_SinkerTrioBottom",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 308,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_PoisonToadRoom = new TreasureChest
        {
            //was ToadRoom
            ChestName = "UG_PoisonToadRoom",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 310,
        };
        public static TreasureChest UG_Batsman = new TreasureChest
        {
            ChestName = "UG_Batsman",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 313,
        };
        public static TreasureChest UG_RideLeft = new TreasureChest
        {
            ChestName = "UG_RideLeft",
            RareItemId = "RoseRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 314,
        };
        public static TreasureChest UG_RideRight = new TreasureChest
        {
            ChestName = "UG_RideRight",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 315,
        };
        public static TreasureChest UG_FirstForneusSinker = new TreasureChest
        {
            ChestName = "UG_FirstForneusSinker",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 320,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_FirstForneusAboveWater = new TreasureChest
        {
            ChestName = "UG_FirstForneusAboveWater",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 321,
        };
        public static TreasureChest UG_EyeballSlideRoom = new TreasureChest
        {
            ChestName = "UG_EyeballSlideRoom",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 323,
        };
        public static TreasureChest UG_FishPond = new TreasureChest
        {
            ChestName = "UG_FishPond",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 325,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_SmallEyeRoom = new TreasureChest
        {
            ChestName = "UG_SmallEyeRoom",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 326,
        };
        public static TreasureChest UG_DeseemaSinker = new TreasureChest
        {
            //was DeepDeepSinker
            ChestName = "UG_DeeseemaSinker",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 327,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_HorseSinkerItem = new TreasureChest
        {
            ChestName = "UG_HorseSinkerItem",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 329,
        };
        public static TreasureChest UG_HorseSinkerChest = new TreasureChest
        {
            ChestName = "UG_HorseSinkerChest",
            CoinOverride = "1000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 330,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_ClamTop = new TreasureChest
        {
            ChestName = "UG_ClamTop",
            RareItemId = "OgreWoodenSword",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 332,
        };
        public static TreasureChest UG_ClamSinker = new TreasureChest
        {
            ChestName = "UG_ClamSinker",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 333,
            RequiresDeepSinker = true,
        };
        public static TreasureChest UG_WhiteShardRoom = new TreasureChest
        {
            ChestName = "UG_WhiteShardRoom",
            RareItemId = "Rennet",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Ruby",
            CommonItemQuantity = "1",
            CommonItemRate = "40.0",
            RareIngreditentId = "Sapphire",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Emerald",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "30.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 334,
        };
        public static TreasureChest UG_AcrossWaterfallRoom = new TreasureChest
        {
            ChestName = "UG_AcrossWaterfallRoom",
            RareItemId = "DishRecipe003",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 336,
        };
        public static TreasureChest UG_RightBottomPastWaterfall = new TreasureChest
        {
            ChestName = "UG_RightBottomPastWaterfall",
            RareItemId = "Criticalring",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 339,
        };
        public static TreasureChest UG_VeryOverCat = new TreasureChest
        {
            ChestName = "UG_VeryOverCat",
            RareItemId = "LightningBolt",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 340,
        };
        public static TreasureChest UG_OverCatTop = new TreasureChest
        {
            ChestName = "UG_OverCatTop",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 341,
        };
        public static TreasureChest UG_OverCatBottom = new TreasureChest
        {
            ChestName = "UG_OverCatBottom",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 342,
        };
        public static TreasureChest UG_Cat = new TreasureChest
        {
            ChestName = "UG_Cat",
            RareItemId = "DishRecipe014",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 343,
        };
        public static TreasureChest UG_UnderCat = new TreasureChest
        {
            ChestName = "UG_UnderCat",
            RareItemId = "FriedFish",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Platinum",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "MahoganyLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "40.0",
            CommonIngredientId = "Clystal",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 344,
        };
        public static TreasureChest UG_AcrossCat = new TreasureChest
        {
            ChestName = "UG_AcrossCat",
            RareItemId = "FaerieScarf",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 346,
        };
        public static TreasureChest UG_ShiftLeverWall = new TreasureChest
        {
            ChestName = "UG_ShiftLeverWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 526,
        };
        public static TreasureChest UG_WaterfallWall = new TreasureChest
        {
            ChestName = "UG_WaterfallWall",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 527,
        };
        public static TreasureChest UG_ShovelKnightWall = new TreasureChest
        {
            ChestName = "UG_ShovelKnightWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 528,
        };
        public static TreasureChest UG_BuerArmorWall = new TreasureChest
        {
            //was UnnamedWall
            ChestName = "UG_BuerArmorWall",
            RareItemId = "Transformationmask",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 529,
        };
        public static TreasureChest UG_WellEntranceWall = new TreasureChest
        {
            ChestName = "UG_WellEntranceWall",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 530,
        };
        public static TreasureChest UG_RideWall = new TreasureChest
        {
            ChestName = "UG_RideWall",
            RareItemId = "Criticalring",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 531,
        };
        public static TreasureChest UG_WallBelowEyeballSlide = new TreasureChest
        {
            //was JustWall
            ChestName = "UG_WallBelowEyeballSlide",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 532,
        };
        public static TreasureChest UG_TopClamRoomWall = new TreasureChest
        {
            //was TopClamRoom
            ChestName = "UG_TopClamRoomWall",
            RareItemId = "PlunderersRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 533,
        };
        public static TreasureChest UG_InfernoInvertWall = new TreasureChest
        {
            ChestName = "UG_InfernoInvertWall",
            RareItemId = "DishRecipe015",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 534,
        };
        //end undergound chests

        //desert chests
        public static TreasureChest Desert_DogBurried = new TreasureChest
        {
            ChestName = "Desert_DogBurried",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 351,
        };
        public static TreasureChest Desert_ZeparBurried = new TreasureChest
        {
            ChestName = "Desert_ZeparBurried",
            RareItemId = "Flightcapoftraveler",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 352,
        };
        public static TreasureChest Desert_SmallStonePass = new TreasureChest
        {
            ChestName = "Desert_SmallStonePass",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 353,
        };
        public static TreasureChest Desert_VulshaPuzzle = new TreasureChest
        {
            ChestName = "Desert_VulshaPuzzle",
            RareItemId = "WeightedRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 355,
        };
        public static TreasureChest Desert_OverAmeRight = new TreasureChest
        {
            ChestName = "Desert_OverAmeRight",
            RareItemId = "BalletRecipe003",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 357,
        };
        public static TreasureChest Desert_OverAmeLeft = new TreasureChest
        {
            ChestName = "Desert_OverAmeLeft",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 358,
        };
        public static TreasureChest Desert_LargeStonePass = new TreasureChest
        {
            ChestName = "Desert_LargeStonePass",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 359,
        };
        public static TreasureChest Desert_LeftPathBottom = new TreasureChest
        {
            ChestName = "Desert_LeftPathBottom",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 360,
        };
        public static TreasureChest Desert_LeftPathTop = new TreasureChest
        {
            ChestName = "Desert_LeftPathTop",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 361,
        };
        public static TreasureChest Desert_DeadendDragon = new TreasureChest
        {
            ChestName = "Desert_DeadendDragon",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 364,
        };
        public static TreasureChest Desert_SoftlockTrap = new TreasureChest
        {
            ChestName = "Desert_SoftlockTrap",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 366,
        };
        public static TreasureChest Desert_AmySinkhole = new TreasureChest
        {
            ChestName = "Desert_AmySinkhole",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 367,
        };
        public static TreasureChest Desert_AccelDupeChest = new TreasureChest
        {
            ChestName = "Desert_AccelDupeChest",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 368,
        };
        public static TreasureChest Desert_Cuby = new TreasureChest
        {
            ChestName = "Desert_Cuby",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 369,
        };
        public static TreasureChest Desert_ChestbyWall = new TreasureChest
        {
            ChestName = "Desert_ChestbyWall",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 370,
        };
        public static TreasureChest Desert_SoftlockBigRoom = new TreasureChest
        {
            ChestName = "Desert_SoftlockBigRoom",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 371,
        };
        public static TreasureChest Desert_ZeparVisible = new TreasureChest
        {
            ChestName = "Desert_ZeparVisible",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 375,
        };
        public static TreasureChest Desert_AlfredStash = new TreasureChest
        {
            ChestName = "Desert_AlfredStash",
            RareItemId = "Mithridate",
            RareItemQuantity = "1",
            RareItemRate = "50.0",
            CommonItemId = "MahoganyLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Clystal",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Gold",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 378,
        };
        public static TreasureChest Desert_DragonWall = new TreasureChest
        {
            ChestName = "Desert_DragonWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 536,
        };
        public static TreasureChest Desert_WallNearChest = new TreasureChest
        {
            ChestName = "Desert_WallNearChest",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 537,
        };
        //end desert chests

        //sorcery lab chests
        public static TreasureChest Sorcery_FirstRoom = new TreasureChest
        {
            ChestName = "Sorcery_FirstRoom",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "20.0",
            CommonItemId = "WalnutLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "20.0",
            RareIngreditentId = "DamascusSteel",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Pepper",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 380,
        };
        public static TreasureChest Sorcery_PoisonToads = new TreasureChest
        {
            ChestName = "Sorcery_PoisonToads",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "20.0",
            CommonItemId = "WalnutLumber",
            CommonItemQuantity = "1",
            CommonItemRate = "20.0",
            RareIngreditentId = "DamascusSteel",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "30.0",
            CommonIngredientId = "Pepper",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "40.0",
            CoinType = "D100",
            CoinOverride = "100",
            ChestId = 382,
        };
        public static TreasureChest Sorcery_ArcaneCat = new TreasureChest
        {
            ChestName = "Sorcery_ArcaneCat",
            RareItemId = "ArmsRecipe005",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 383,
        };
        public static TreasureChest Sorcery_ArcaneCandle = new TreasureChest
        {
            ChestName = "Sorcery_ArcaneCandle",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 384,
        };
        public static TreasureChest Sorcery_AfterBathinTop = new TreasureChest
        {
            ChestName = "Sorcery_AfterBathinTop",
            RareItemId = "Silvermanring",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 386,
        };
        public static TreasureChest Sorcery_AfterBathinBottom = new TreasureChest
        {
            ChestName = "Sorcery_AfterBathinBottom",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 387,
        };
        public static TreasureChest Sorcery_SecretFloorLeft = new TreasureChest
        {
            ChestName = "Sorcery_SecretFloorLeft",
            RareItemId = "SkullNecklace",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 388,
        };
        public static TreasureChest Sorcery_SecretFloorRight = new TreasureChest
        {
            ChestName = "Sorcery_SecretFloorRight",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 389,
        };
        //end sorcery lab chests

        //tortue chests
        public static TreasureChest Secret_BigRoom = new TreasureChest
        {
            ChestName = "Secret_BigRoom",
            RareItemId = "MahoganyLumber",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Silk",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Diamond",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 392,
        };
        public static TreasureChest Secret_BigChair = new TreasureChest
        {
            ChestName = "Secret_BigChair",
            RareItemId = "MahoganyLumber",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Silk",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Diamond",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 393,
        };
        public static TreasureChest Secret_VerySpiky = new TreasureChest
        {
            ChestName = "Secret_VerySpiky",
            RareItemId = "SpikeBreast",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 397,
        };
        public static TreasureChest Secret_TrapsRoom = new TreasureChest
        {
            ChestName = "Secret_TrapsRoom",
            RareItemId = "MahoganyLumber",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Silk",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Diamond",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 398,
        };
        public static TreasureChest Secret_Lamashtus = new TreasureChest
        {
            ChestName = "Secret_Lamashtus",
            RareItemId = "MahoganyLumber",
            RareItemQuantity = "1",
            RareItemRate = "40.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Silk",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Diamond",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 401,
        };
        public static TreasureChest Secret_CowWall = new TreasureChest
        {
            ChestName = "Secret_CowWall",
            RareItemId = "CutpursesRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 539,
        };
        //end torture chests

        //oriental chests
        public static TreasureChest Oriental_UnderBridge = new TreasureChest
        {
            ChestName = "Oriental_UnderBridge",
            RareItemId = "TalismanScarf",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 405,
        };
        public static TreasureChest Oriental_FirstGusian = new TreasureChest
        {
            ChestName = "Oriental_FirstGusian",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 406,
        };
        public static TreasureChest Oriental_ArchmazeCow = new TreasureChest
        {
            ChestName = "Oriental_ArchmazeCow",
            RareItemId = "DishRecipe002",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 409,
        };
        public static TreasureChest Oriental_ArchmazeTopLeft = new TreasureChest
        {
            ChestName = "Oriental_ArchmazeTopLeft",
            RareItemId = "ArmsRecipe009",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 410,
        };
        public static TreasureChest Oriental_AboveMimicRoom = new TreasureChest
        {
            ChestName = "Oriental_AboveMimicRoom",
            RareItemId = "WorldfashionNo08",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 414,
        };
        public static TreasureChest Oriental_GaapSave = new TreasureChest
        {
            ChestName = "Oriental_GaapSave",
            RareItemId = "SoySauce",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Miso",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "CypressLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Hihiirokane",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 415,
        };
        public static TreasureChest Oriental_Gusians = new TreasureChest
        {
            ChestName = "Oriental_Gusians",
            CoinOverride = "2000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 416,
        };
        public static TreasureChest Oriental_AboveStoneNose = new TreasureChest
        {
            ChestName = "Oriental_AboveStoneNose",
            RareItemId = "SoySauce",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Miso",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "CypressLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Hihiirokane",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 419,
        };
        public static TreasureChest Oriental_BeforeZ2 = new TreasureChest
        {
            ChestName = "Oriental_BeforeZ2",
            RareItemId = "SoySauce",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Miso",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "CypressLumber",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "20.0",
            CommonIngredientId = "Hihiirokane",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "5.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 421,
        };
        public static TreasureChest Oriental_Swordsman = new TreasureChest
        {
            ChestName = "Oriental_Swordsman",
            RareItemId = "Swordsman", //normally these are CommonItemId.  changed for spoiler log purposes.
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 24,
        };
        public static TreasureChest Oriental_RoomAboveStoneNose = new TreasureChest
        {
            ChestName = "Oriental_RoomAboveStoneNose",
            RareItemId = "OfudaTalisman",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 423,
        };
        public static TreasureChest Oriental_ArchmazeBottomLeft = new TreasureChest
        {
            ChestName = "Oriental_ArchmazeBottomLeft",
            RareItemId = "KitsuneMask",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 424,
        };
        public static TreasureChest Oriental_BeforeCarpenterWall = new TreasureChest
        {
            ChestName = "Oriental_BeforeCarpenterWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 541,
        };
        public static TreasureChest Oriental_StoneNose = new TreasureChest
        {
            ChestName = "Oriental_StoneNose",
            RareItemId = "Manju",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 542,
        };
        //end oriental chests

        //inferno chests
        public static TreasureChest Fire_BigLavaTopRight = new TreasureChest
        {
            ChestName = "Fire_BigLavaTopRight",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Silk",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "10.0",
            CommonIngredientId = "Bixbite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 428,
        };
        public static TreasureChest Fire_BigLavaTopLeft = new TreasureChest
        {
            ChestName = "Fire_BigLavaTopLeft",
            RareItemId = "Firemuffler",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 429,
        };
        public static TreasureChest Fire_AfterDragon = new TreasureChest
        {
            ChestName = "Fire_AfterDragon",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Silk",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "10.0",
            CommonIngredientId = "Bixbite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 430,
        };
        public static TreasureChest Fire_SecretLavaRoom = new TreasureChest
        {
            ChestName = "Fire_SecretLavaRoom",
            RareItemId = "Riskring",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 433,
        };
        public static TreasureChest Fire_RoomNearBugs = new TreasureChest
        {
            ChestName = "Fire_RoomNearBugs",
            RareItemId = "BalletRecipe004",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 436,
        };
        public static TreasureChest Fire_AboveOrobos = new TreasureChest
        {
            ChestName = "Fire_AboveOrobos",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Silk",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "10.0",
            CommonIngredientId = "Bixbite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 440,
        };
        public static TreasureChest Fire_PostOrobosTopRight = new TreasureChest
        {
            ChestName = "Fire_PostOrobosTopRight",
            RareItemId = "Lohengrin",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 441,
        };
        public static TreasureChest Fire_PostOrobosTopLeft = new TreasureChest
        {
            ChestName = "Fire_PostOrobosTopLeft",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Silk",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "10.0",
            CommonIngredientId = "Bixbite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 442,
        };
        public static TreasureChest Fire_UnderBridge = new TreasureChest
        {
            ChestName = "Fire_UnderBridge",
            RareItemId = "CurryPowder",
            RareItemQuantity = "1",
            RareItemRate = "30.0",
            CommonItemId = "Silk",
            CommonItemQuantity = "1",
            CommonItemRate = "30.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "10.0",
            CommonIngredientId = "Bixbite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "10.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 443,
        };
        public static TreasureChest Fire_LastChanceFire = new TreasureChest
        {
            ChestName = "Fire_LastChanceFire",
            RareItemId = "EggSoufflé",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 446,
        };
        public static TreasureChest Fire_EarlyWall = new TreasureChest
        {
            ChestName = "Fire_EarlyWall",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 544,
        };
        public static TreasureChest Fire_LateWall = new TreasureChest
        {
            ChestName = "Fire_LateWall",
            RareItemId = "LethalityRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 545,
        };
        //end inferno chests

        //den chests
        public static TreasureChest Den_Wolfman = new TreasureChest
        {
            ChestName = "Den_Wolfman",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 448,
        };
        public static TreasureChest Den_ChariotBuer = new TreasureChest
        {
            ChestName = "Den_ChariotBuer",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 449,
        };
        public static TreasureChest Den_GardenTopLeft = new TreasureChest
        {
            ChestName = "Den_GardenTopLeft",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 450,
        };
        public static TreasureChest Den_GardenBeforeChasm = new TreasureChest
        {
            ChestName = "Den_GardenBeforeChasm",
            RareItemId = "Keyofbacker3",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 451,
        };
        public static TreasureChest Den_GardenFrogAlcove = new TreasureChest
        {
            ChestName = "Den_GardenFrogAlcove",
            CoinOverride = "1000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 452,
        };
        public static TreasureChest Den_GardenTopRight = new TreasureChest
        {
            ChestName = "Den_GardenTopRight",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 453,
        };
        public static TreasureChest Den_GardenAboveDoor = new TreasureChest
        {
            ChestName = "Den_GardenAboveDoor",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 454,
        };
        public static TreasureChest Den_GardenBottomRight = new TreasureChest
        {
            ChestName = "Den_GardenBottomRight",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 455,
        };
        public static TreasureChest Den_GiantToadStair = new TreasureChest
        {
            ChestName = "Den_GiantToadStair",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 456,
        };
        public static TreasureChest Den_GiantRightStair = new TreasureChest
        {
            ChestName = "Den_GiantRightStair",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 457,
        };
        public static TreasureChest Den_AbyssalDragon = new TreasureChest
        {
            ChestName = "Den_AbyssalDragon",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 458,
        };
        public static TreasureChest Den_BelowValefar = new TreasureChest
        {
            ChestName = "Den_BelowValefar",
            CoinOverride = "1000",
            CoinType = "D1000",
            CoinRate = "100.0",
            ChestId = 459,
        };
        public static TreasureChest Den_BelowValefar2 = new TreasureChest
        {
            ChestName = "Den_BelowValefar2",
            RareItemId = "ValkyrieTiara",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 492,
        };
        public static TreasureChest Den_LowerGardenTopLeft = new TreasureChest
        {
            ChestName = "Den_LowerGardenTopLeft",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 460,
        };
        public static TreasureChest Den_LowerGardenTopRight = new TreasureChest
        {
            ChestName = "Den_LowerGardenTopRight",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 461,
        };
        public static TreasureChest Den_LowerGardenAboveDoor = new TreasureChest
        {
            ChestName = "Den_LowerGardenAboveDoor",
            RareItemId = hpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 462,
        };
        public static TreasureChest Den_CannonMorteStair = new TreasureChest
        {
            ChestName = "Den_CannonMorteStair",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 463,
        };
        public static TreasureChest Den_CannonMorteDeadend = new TreasureChest
        {
            ChestName = "Den_CannonMorteDeadend",
            RareItemId = "ArmsRecipe012",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 464,
        };
        public static TreasureChest Den_LeftStairTop = new TreasureChest
        {
            ChestName = "Den_LeftStairTop",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 465,
        };
        public static TreasureChest Den_LeftStairUnderneath = new TreasureChest
        {
            ChestName = "Den_LeftStairUnderneath",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 466,
        };
        public static TreasureChest Den_LeftStairBeforeRace = new TreasureChest
        {
            ChestName = "Den_LeftStairBeforeRace",
            RareItemId = "Waystone",
            RareItemQuantity = "2",
            RareItemRate = "10.0",
            CommonItemId = "Clystal",
            CommonItemQuantity = "1",
            CommonItemRate = "10.0",
            RareIngreditentId = "Diamond",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Alexandrite",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 467,
        };
        public static TreasureChest Den_WolfmanWall = new TreasureChest
        {
            ChestName = "Den_WolfmanWall",
            RareItemId = "Gamblersring",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 547,
        };
        public static TreasureChest Den_LowerGardenWall = new TreasureChest
        {
            ChestName = "Den_LowerGardenWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 548,
        };
        public static TreasureChest Den_CannonWall = new TreasureChest
        {
            ChestName = "Den_CannonWall",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 549,
        };
        //end den chests

        //ice chests
        public static TreasureChest Ice_EntryBottom = new TreasureChest
        {
            ChestName = "Ice_EntryBottom",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 469,
        };
        public static TreasureChest Ice_EntryRight = new TreasureChest
        {
            ChestName = "Ice_EntryRight",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 470,
        };
        public static TreasureChest Ice_Stair = new TreasureChest
        {
            ChestName = "Ice_Stair",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 471,
        };
        public static TreasureChest Ice_TeleportRight = new TreasureChest
        {
            ChestName = "Ice_TeleportRight",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 472,
        };
        public static TreasureChest Ice_TeleportLeft = new TreasureChest
        {
            ChestName = "Ice_TeleportLeft",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 473,
        };
        public static TreasureChest Ice_BelowDemonLord = new TreasureChest
        {
            ChestName = "Ice_BelowDemonLord",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 474,
        };
        public static TreasureChest Ice_ReflectorChest = new TreasureChest
        {
            ChestName = "Ice_ReflectorChest",
            RareItemId = weapon_fragarach,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 475,
        };
        public static TreasureChest Ice_GAxeOutsider = new TreasureChest
        {
            ChestName = "Ice_GAxeOutsider",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 476,
        };
        public static TreasureChest Ice_BeforeGremory = new TreasureChest
        {
            ChestName = "Ice_BeforeGremory",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 477,
        };
        public static TreasureChest Ice_BelowGremory = new TreasureChest
        {
            ChestName = "Ice_BelowGremory",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 478,
        };
        public static TreasureChest Ice_GussianCannon = new TreasureChest
        {
            ChestName = "Ice_GussianCannon",
            RareItemId = "Keyofbacker2",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 479,
        };
        public static TreasureChest Ice_PartyRoom = new TreasureChest
        {
            ChestName = "Ice_PartyRoom",
            RareItemId = "Clystal",
            RareItemQuantity = "1",
            RareItemRate = "15.0",
            CommonItemId = "Alexandrite",
            CommonItemQuantity = "1",
            CommonItemRate = "5.0",
            RareIngreditentId = "Leather",
            RareIngreditentQuantity = "1",
            RareIngredientRate = "5.0",
            CommonIngredientId = "Orichalcum",
            CommonIngredientQuantity = "1",
            CommonIngredientRate = "3.0",
            CoinType = "D500",
            CoinOverride = "500",
            ChestId = 480,
        };
        public static TreasureChest Ice_TeleportWall = new TreasureChest
        {
            ChestName = "Ice_TeleportWall",
            RareItemId = "WeightedRing",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 551,
        };
        public static TreasureChest Ice_GremoryWall = new TreasureChest
        {
            ChestName = "Ice_GremoryWall",
            RareItemId = mpup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 552,
        };
        public static TreasureChest Ice_BaelWall = new TreasureChest
        {
            ChestName = "Ice_BaelWall",
            RareItemId = capacityup,
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 553,
        };
        //end ice chests

        //start other chests
        public static TreasureChest Carpenter1 = new TreasureChest
        {
            ChestName = "Carpenter1",
            RareItemId = "Bloodybone",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 733,
        };
        public static TreasureChest Carpenter2 = new TreasureChest
        {
            ChestName = "Carpenter2",
            CommonItemId = "Garlic",
            CommonItemQuantity = "1",
            CommonItemRate = "100.0",
            ChestId = 734,
        };
        public static TreasureChest AboveValac = new TreasureChest
        {
            ChestName = "AboveValac",
            RareItemId = "Valkyriedress",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 493,
        };
        public static TreasureChest DshiftBeforeValac = new TreasureChest
        {
            ChestName = "DshiftBeforeValac",
            RareItemId = "ValkyrieSword",
            RareItemQuantity = "1",
            RareItemRate = "100.0",
            ChestId = 494,
        };
        //end other


        public static List<TreasureChest> CreateChestList() {

            //make a list of all the chests.
            List<TreasureChest> ListOfAllChests = new List<TreasureChest>
            {
                Ship_FirstChest, Ship_BeforeDoor, Ship_BehindDullahammer, Ship_OutsideTopleft, Ship_BeforeFirstsave, Ship_FarLeftFirstsave,  //6
                Ship_BottomWithseema, Ship_LeftTreasureRoom1, Ship_LeftTreasureRoom2, Ship_NearFirstBats,  //10, 
                Ship_RightsideBelowDeck, Ship_TopBelowDeck, Ship_LeftsideBelowDeck, Ship_BelowDeck, Ship_SecondSaveChest, Ship_LifeboatRoom,  //16
                Ship_SecretAboveDullahammer, Ship_GhostsRoom, Ship_TrippleSeemaChest, Ship_FirstRatChest, Ship_BlockPuzzleChest, //21
                Ship_AboveDeckLeftChest, Ship_MoneyFarmChest, Ship_RatSaveChest, Ship_CaptainsChest1, Ship_CaptainsChest2, //26
                Ship_RightTreasureRoom1, Ship_RightTreasureRoom2, Ship_AboveEndofShip, Ship_CrowsNest, //30 
                Ship_Wallabovestart, Ship_Wallbyfirstbats, Ship_SecretWallAboveDullahammer, Ship_TrippleSeemaWall, //34

                /*Vil_KeyBox,*/ Vil_Crafter, Vil_gebels, //3

                Vil_beforetown, Vil_intown, Vil_brokenhousetop, Vil_brokenhouseinside, Vil_beforewarp, Vil_abovehalfwayhouse, Vil_halfwayhouse, Vil_abovegate1,
                Vil_abovegate2, Vil_underbrokenhouse, //10

                Ent_sabnockright, Ent_sabonckleft, Ent_ForgottenAreaOverhang, Ent_PostGhostFarm, Ent_MiddleGhost, Ent_LeftGhost, //6
                Ent_Behindthedoor, Ent_Rightmidsection, Ent_leftmidsection, Ent_midsection, Ent_PreZangetsu, //11
                Ent_ChandaleersTopLeft, Ent_ChandaleersLedge, Ent_ChandaleersBottom, Ent_eeooWall, Ent_ColumnDemon, Ent_ColumnBonemorte, Ent_Santaroom1, Ent_Santaroom2, //19
                Ent_SafetyCrashRoom, Ent_NearOriental, Ent_ForgottenRoom1, Ent_ForgottenRoom2, Ent_ForgottenRoom3, Ent_ForgottenWall, //25

                Garden_MocoweedDropdown, Garden_PlumeParmaCooridor, Garden_PresidentChest, Garden_SwampGroundChest, Garden_AboveCoachLeft, //5
                Garden_AboveRightDoor, Garden_AboveCoachRight, Garden_TransitionEastGarden, Garden_DontFall, Garden_AbovePiano, Garden_ZooStairs, //11
                Garden_ThroughWall1, Garden_ThroughWall2, Garden_InvertChest, Garden_BottomGussian, Garden_AfterWell, Garden_TopGussian, //17
                Garden_FinalGardenTransition, Garden_Aradialwall, //19

                Cathedral_FirstLargeReflectorbottom, Cathedral_FirstLargeOrientalLeft, Cathedral_FirstLargeOrientalRight, Cathedral_FirstLargeBell, //4
                Cathedral_FirstLargeOrientalBell, Cathedral_FirstLargeReflectorright, Cathedral_FirstLargeTopLeft, Cathedral_FirstLargeTopRight, //8
                Cathedral_BelowTodd, Cathedral_AcrossTodd, Cathedral_DshiftLever, Cathedral_UnderBloodbringer, //12
                Cathedral_Craftwork2, Cathedral_Craftwork1, Cathedral_CraftworkSilverknightchest, Cathedral_SilverknightGlobe1, Cathedral_SilverknightGlobe2, //17
                Cathedral_Bottomleftside, Cathedral_Topright, Cathedral_Guardedbyspear, Cathedral_Topleft, //21
                Cathedral_Belllessbell, Cathedral_Bellgatechest, Cathedral_Topleftbreakablebells, Cathedral_Toprightbreakbalebells, Cathedral_InsideCenterBell, //26
                Cathedral_Shieldoutsider, //27
                Cathedral_TopDemonDoorLeft, Cathedral_TopDemonDoorRight, Cathedral_TopDemonDoorGround, Cathedral_TopDemonDoorCenterBell, Cathedral_OcypeteChest, //32
                Cathedral_PostBloodless, //33
                Cathedral_WallAcrossShortcut, Cathedral_WallBeforeTodd, Cathedral_BellsWall, //36

                Tower_FirstCelano, Tower_BeforeLibrary, Tower_MidElevatorLeft, Tower_AbovePaintingHall, Tower_DullaheadSpamRoom, Tower_ElevatorTopLeft, //6
                Tower_InsideElevatorMiddle, Tower_ElevatorTopRight, Tower_RightAttic, Tower_BigGearRoom, Tower_AboveValac, Tower_GearAdventure, //12
                Tower_WhirligigLower, Tower_LowerTowerWolfman, Tower_LowerTowerBackBottom, Tower_LowerTowerExit, Tower_WhirligigUpper, Tower_LowerTowerTopLeft, //18
                Tower_UpperTowerSoftlockTrap, Tower_FrogsAndCandles2, Tower_UpperTowerFirstDeadend, Tower_FrogsAndCandles1, Tower_UpperTowerTopExit, //23
                Tower_UpperTowerTopLeft, Tower_UpperTowerTopperLeft, Tower_UpperTowerWolfman, //26
                Tower_BromideChest, Tower_AegisPlateChest, Tower_BelowBromide, //29
                Tower_DellaheadSpamWall, Tower_BigGearRoomWall, Tower_BeforeValacWall, //32

                Libre_GussianTraps, Libre_VrukielChest, Libre_RulshaRoom, Libre_UnderOD1, Libre_UnderOD2, Libre_AndrealphusChest, //6
                Libre_Grinder, Libre_AboveChairMimic, Libre_BehindDragon, Libre_AnnoyingInvert, Libre_AboveMimic, //11
                Libre_BehindOtherDragon, Libre_PastOtherChair, Libre_CeilingRoom, Libre_BehindBookcase, //15
                Libre_DoubleDemonWall, Libre_BehindDragonWall, Libre_LargeRoomLeftWall, //18

                Train_HiddenCarLeft, Train_HiddenCarRight, Train_CarJunction, Train_LuxuryCar, Train_NearLever, Train_WallAfterTrain, //6

                Hall_AboveSave, Hall_BloodBringer, Hall_AxeOutsider, Hall_Archdemon, //4
                Hall_Smallhub, Hall_RightofHub, Hall_LeftofHub, Hall_BottomLeftofHub, Hall_ChristosPainting, //9
                Hall_Before8bit1, Hall_Before8bit2, Hall_Before8bit3, Hall_Before8bit4, Hall_Before8bit5, //14
                Hall_GebelStaircaseTop, Hall_GebelStaircaseBottom, Hall_GebelCeilingCorner, //17
                Hall_Reward8bit, Hall_HiddenRoom, //19
                Hall_FirstroomWall, Hall_TitaniaWall, //21

                UG_BuerSideRoom, UG_NearWaterfallWall, UG_WaterfallRight, UG_WaterfallLeft, UG_WaterfallTop, UG_BigSinkerLeft, UG_BigSinkerRight, //7
                UG_DemonAboveShovelWall, UG_BigRoomShovel, UG_BigRoomCandle, UG_BigRoomCenterLeft, UG_BigRoomTopLeft, UG_DemonRightofBigRoom, UG_AboveBigRoom, UG_SingleSinker, //15
                UG_BermudaTriangleSinkerLeft, UG_BermudaTriangleSinkerTopRight, UG_BermudaTriangleSinkerBotRight, //18
                UG_SinkerTrioTop, UG_SinkerTrioMid, UG_SinkerTrioBottom, //21
                UG_PoisonToadRoom, UG_Batsman, UG_RideLeft, UG_RideRight, UG_FirstForneusSinker, UG_FirstForneusAboveWater, UG_EyeballSlideRoom, //28
                UG_FishPond, UG_HorseSinkerItem, UG_HorseSinkerChest, UG_WhiteShardRoom, UG_AcrossWaterfallRoom, UG_RightBottomPastWaterfall, //34
                UG_VeryOverCat, UG_OverCatTop, UG_OverCatBottom, UG_Cat, UG_UnderCat, UG_AcrossCat, //40
                UG_ShiftLeverWall, UG_WaterfallWall, UG_ShovelKnightWall, UG_WellEntranceWall, UG_RideWall, UG_WallBelowEyeballSlide, UG_TopClamRoomWall, UG_InfernoInvertWall, //48
                UG_SmallEyeRoom, UG_DeseemaSinker, UG_ClamTop, UG_ClamSinker, UG_BuerArmorWall, //53

                Desert_DogBurried, Desert_ZeparBurried, Desert_SmallStonePass, Desert_VulshaPuzzle, Desert_OverAmeRight, Desert_OverAmeLeft, //6
                Desert_LargeStonePass, Desert_LeftPathBottom, Desert_LeftPathTop, Desert_DeadendDragon, Desert_SoftlockTrap, //11
                Desert_AmySinkhole, Desert_AccelDupeChest, Desert_Cuby, Desert_ChestbyWall, Desert_SoftlockBigRoom, Desert_ZeparVisible, Desert_AlfredStash, //18
                Desert_DragonWall, Desert_WallNearChest, //20

                Sorcery_FirstRoom, Sorcery_PoisonToads, Sorcery_ArcaneCat, Sorcery_ArcaneCandle, //4
                Sorcery_AfterBathinTop, Sorcery_AfterBathinBottom, Sorcery_SecretFloorLeft, Sorcery_SecretFloorRight, //8

                Secret_BigRoom, Secret_BigChair, Secret_VerySpiky, Secret_TrapsRoom, Secret_Lamashtus, Secret_CowWall, //6

                Oriental_UnderBridge, Oriental_FirstGusian, Oriental_ArchmazeCow, Oriental_ArchmazeTopLeft, //4
                Oriental_AboveMimicRoom, Oriental_GaapSave, Oriental_Gusians, //7
                Oriental_AboveStoneNose, Oriental_BeforeZ2, Oriental_Swordsman, Oriental_RoomAboveStoneNose, Oriental_ArchmazeBottomLeft, //12
                Oriental_BeforeCarpenterWall, Oriental_StoneNose, //14

                Fire_BigLavaTopRight, Fire_BigLavaTopLeft, Fire_AfterDragon, Fire_SecretLavaRoom, Fire_RoomNearBugs, //5
                Fire_AboveOrobos, Fire_PostOrobosTopRight, Fire_PostOrobosTopLeft, Fire_UnderBridge, Fire_LastChanceFire, //10
                Fire_EarlyWall, Fire_LateWall, //12

                Den_Wolfman, Den_ChariotBuer, Den_GardenTopLeft, //3
                Den_GardenBeforeChasm, Den_GardenFrogAlcove, Den_GardenTopRight, Den_GardenAboveDoor, Den_GardenBottomRight, //8
                Den_GiantToadStair, Den_GiantRightStair, Den_AbyssalDragon, //11
                Den_BelowValefar, Den_BelowValefar2, //13
                Den_LowerGardenTopLeft, Den_LowerGardenTopRight, Den_LowerGardenAboveDoor, Den_CannonMorteStair, Den_CannonMorteDeadend, //18
                Den_LeftStairTop, Den_LeftStairUnderneath, Den_LeftStairBeforeRace, //21
                Den_WolfmanWall, Den_LowerGardenWall, Den_CannonWall, //24

                Ice_EntryBottom, Ice_EntryRight, Ice_Stair, Ice_TeleportRight, Ice_TeleportLeft, Ice_BelowDemonLord, //6
                Ice_ReflectorChest, Ice_GAxeOutsider, Ice_BeforeGremory, Ice_BelowGremory, Ice_GussianCannon, Ice_PartyRoom, //12
                Ice_TeleportWall, Ice_GremoryWall, Ice_BaelWall, //15

                Carpenter1, Carpenter2, AboveValac, DshiftBeforeValac //4
            };

            return ListOfAllChests;

        }

       
    }
}
