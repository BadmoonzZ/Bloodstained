using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class ChestShuffle
    {

        //1. get a list of all chests exist in a normal game
        static List<TreasureChest> DefaultChestList = ChestRandomizer.CreateChestList();

        //2. get a list of all the ids in the seed 17791
        public static List<int> seed17791IDs = new List<int>
        {
            66 , 58, 225, 131, 97, 54, 233, 259, 65, 417, 69, 199, 187, 20, 398, 429, 340, 380, 183, 442, 72, 306, 446, 459, 112, 194, 287, 165, 154, 158, 548, 516, 531, 551, //ship
            /*19, */ 53, 87, //special village chests: village key, crafting materials, gebels glasses
            330, 226, 205, 89, 329, 118, 146, 244, 150, 114, //village
            217, 115, 136, 85, 101, 215, 94, 341, 60, 126, 159, 148, 367, 171, 362, 448, 127, 384, 387, 117, 460, 389, 235, 524, 521, //ent
            219, 245, 237, 491, 176, 93, 472, 132, 172, 82, 474, 100, 134, 189, 249, 181, 323, 338, 507, //garden
            63, 383, 106, 454, 218, 214, 317, 266, 352, 153, 209, 343, 386, 103, 56, 242, 358, 349, 428, 319, 170, 151, 121, 409, 81, 162, 152, 479, 179, 125, 129, 261, 80, 528, 545, 518, //cathedral
            432, 110, 138, 227, 302, 464, 74, 252, 297, 111, 157, 256, 449, 104, 436, 240, 180, 243, 135, 285, 369, 133, 494, 147, 265, 140, 178, 163, 137, 530, 505, 522, //tower
            334, 204, 142, 88, 86, 59, 473, 403, 223, 83, 385, 232, 160, 120, 288, 552, 529, 520, //libra
            207, 122, 278, 105, 416, 500, //train
            325, 193, 98, 404, 290, 267, 107, 284, 336, 475, 216, 99, 277, 263, 264, 228, 250, 435, 339, 536, 544, //hall

            258, 354, 90, 262, 350, 372, 480, 128, 231/*was 221*/, 108, 337, 75, 161, 289, 450, 299, 280, 305, 452, 433, 320, 316, 370, 272, 203, //underground1
            208, 478, 331, 458,
            335, 246,
            271, 357, 307, 201,
            109,
            360, 410, 413, 405, 549,
            527, 537, 504, 501,
            553, 539,
            534, 400,
            377, 332, 476, 510,

            //400, 377, 335, 246, 332, 476, 271, 357, 307, 201, 109, 360, 410, 413, /**/405/**/, 504, 527, 537, 510, 549, 501, 553, 539, 534,
            156, 190, 269, 314, 174, 270, 62, 365, 206, 407, 445, 119, 394, 465, 477, 439, 347, 431, 511, 514, //desert
            309, 298, 282, 462, 355, 79, 55, 113, //sorcery lab
            396, 734, 493, 470, 294, 533, //Torture
            /**/346/**/, 406, 211, 213, 274, 71, 182, 733, 167, 24, 87, 388, 513, 542, //Oriental . note chest 405 was labeled 346
            116, 68, 342, 423, 414, 322, 441, 95, 378, 188, 502, 502, //Fire
            301, 239, 359, 260, 102, 155, 457, 175, 363, 453, 312, 78, 492, 324, 73, 361, 251, 255, 415, 196, 141, 547, 526, 541, //Den
            192, 321, 356, 57, 91, 295, 92, 434, 123, 139, 451, 371, 517, 499, 509, //Ice
            253, 382, //carpenter
            397, 144 //other
        };

        public static List<int> seed17791IDs_v18 = new List<int>
        {
            53, 197, 272, 57, 397, 106, 127, 80, 61, 202, 340, 298, 187, 66, 422, 429, 144, 733, 475, 123, 60, 175, 200, 459, 171, 259, 416, 91, 227, 174, 524, 549, 533, 502, //Ship
            /*19,*/ 18, 87, //special village chests: village key, craft mats, gebels.
            179, 338, 288, 65, 228, 335, 92, 271, 277, 318, //Vilage
            97, 460, 261, 85, 111, 270, 119, 334, 105, 194, 491, 145, 278, 264, 474, 139, 83, 180, 289, 190, 121, 207, 297, 527, 505, //Entrance
            473, 74, 117, 357, 242, 162, 493, 132, 232, 90, 421, 78, 206, 55, 407, 244, 342, 77, 542, //Garden
            201, 274, 70, 361, 263, 176, 732, 82, 492, 130, 147, 250, 138, 129, 56, 103, 222, 109, 236, 291, 406, 122, 436, 282, 136, 455, 296, 178, 99, 118, 153, 306, 212, 548, 539, 116, //Cathedral
            196, 226, 355, 237, 299, 159, 441, 160, 321, 157, 224, 332, 322, 418, 258, 240, 266, 134, 734, 172, 403, 213, 183, 223, 166, 218, 24, 131, 262, 514, 521, 522, //Tower
            394, 410, 58, 225, 148, 120, 358, 341, 158, 352, 449, 383, 356, 59, 307, 513, 551, 552, //Libra
            387, 125, 389, 63, 182, 536, //Train
            470, 285, 186, 351, 167, 211, 126, 404, 336, 245, 479, 330, 140, 243, 137, 384, 235, 239, 88, 504, 518, //Hall
            209, 115, 462, 214, 290, 461, 467, 464, 408, 414, 370, 452, 314, 155, 303, 354, 350, 181, 100, 87, 415, 345, 301, 339, 392, 349, //Underground1
            98, 116, 399, 430, 67, 112, 246, 494, 413, 93, 343, 189, 69, 466, 317, 133, 302, 346, 553, 532, 511, 501, 530, 529, 541, 517, 534, //Underground2
            203, 233, 95, 424, 409, 113, 372, 73, 305, 465, 448, 215, 152, 309, 168, 230, 284, 310, 537, 500, //Desert
            457, 480, 267, 329, 388, 367, 433, 219, //Sorcery
            382, 360, 217, 327, 229, 531, //Torture
            68, 170, 204, 255, 128, 316, 75, 254, 208, 260, 205, 161, 526, 507, //Oriental
            373, 405, 295, 423, 193, 450, 146, 173, 280, 110, 510, 510/*marked as 510 also*/, //Fire
            281, 359, 431, 216, 81, 393, 265, 150, 257, 320, 71, 287, 154, 443, 313, 149, 427, 108, 453, 369, 371, 545, 528, 499, //Den
            311, 380, 325, 163, 454, 463, 107, 411, 400, 253, 451, 412, 547, 544, 520, //Ice
            283, 054/*carptenter2 unchecked*/, 472, 72, //Other

        };


        //give each chest in the list a new id for what's in seed 17791
        //the provided list should or could be randomized or even include new items.
        //we supply a new ChestID number for each chest.  It is assumed that the there will be 361 chests.
        //then we return a list of treasure chests with valid IDs.  (It will be up to another function to write them.)
        public static List<TreasureChest> ApplySeedID(List<TreasureChest> RandomizedChestList , List<int> seed17791IDs)
        {
            for (int i = 0; i < DefaultChestList.Count(); i++)
            {
                RandomizedChestList[i].ChestId = seed17791IDs[i];
            }

            return RandomizedChestList;
        }


        //find the 0th seedID  it is 53
        //write the recoded contents into the lines based off of id53
        //now loop for the 1th chest and 1th id.

        //x insert logic
        //6 logic check for zangetsuto (prob should be done before step 5)


        //takes a line number, a treasure chest, and a file to write the info to.
        public static void WriteTreasureChest(int linetowrite, TreasureChest treasurelisttowrite, string[] arr)
        {
            int l = linetowrite;

                arr[l - 2] = "      \"ShardId\": \"" + treasurelisttowrite.ShardID + "\",";
                arr[l - 1] = "      \"ShardRate\": " + treasurelisttowrite.ShardRate + ",";
                arr[l] = "      \"RareItemId\": \"" + treasurelisttowrite.RareItemId + "\",";
                arr[l + 1] = "      \"RareItemQuantity\": " + treasurelisttowrite.RareItemQuantity + ",";
                arr[l + 2] = "      \"RareItemRate\": " + treasurelisttowrite.RareItemRate + ",";
                arr[l + 3] = "      \"CommonItemId\": \"" + treasurelisttowrite.CommonItemId + "\",";
                arr[l + 4] = "      \"CommonItemQuantity\": " + treasurelisttowrite.CommonItemQuantity + ",";
                arr[l + 5] = "      \"CommonRate\": " + treasurelisttowrite.CommonItemRate + ",";
                arr[l + 6] = "      \"RareIngredientId\": \"" + treasurelisttowrite.RareIngreditentId + "\",";
                arr[l + 7] = "      \"RareIngredientQuantity\": " + treasurelisttowrite.RareIngreditentQuantity + ",";
                arr[l + 8] = "      \"RareIngredientRate\": " + treasurelisttowrite.RareIngredientRate + ",";
                arr[l + 9] = "      \"CommonIngredientId\": \"" + treasurelisttowrite.CommonIngredientId + "\",";
                arr[l + 10] = "      \"CommonIngredientQuantity\": " + treasurelisttowrite.CommonIngredientQuantity + ",";
                arr[l + 11] = "      \"CommonIngredientRate\": " + treasurelisttowrite.CommonIngredientRate + ",";
                arr[l + 12] = "      \"CoinType\": \"EDropCoin::" + treasurelisttowrite.CoinType + "\",";
                arr[l + 13] = "      \"CoinOverride\": " + treasurelisttowrite.CoinOverride + ",";
                arr[l + 14] = "      \"CoinRate\": " + treasurelisttowrite.CoinRate + ",";

        }

        //this function takes the ID of the treasure chest and returns a line number equivelent to the shardID of that block
        //you can than use this line number for writing the treasure chests.  it uses the formula below
        //
        //x - 53 = y
        //907 + 25 * y = ll
        //
        //because the json file is missing a lot of IDs we need to skip those.  that is the purpose of finding jjj
        //25*26*27*52*84*96*124*143*184*220*241*247*248*273*348*379*390*402*426*447*468*481*490*495*496*497*498*503*506*508*512*515*519*523*525*535*538*540*543*546*550*x700 dne
        public static int FindJsonWriteNumber(int treasureID)
        {
            int linesperchest = 26;
            int iii = (treasureID - 18) * linesperchest + 138;  //138 is the offset
            int jjj = 0;

            if (treasureID <= 24)
            { jjj = 0; }
            else if (treasureID <= 84)
            { jjj = 4; }
            else if (treasureID <= 96)
            { jjj = 5; }
            else if (treasureID <= 124)
            { jjj = 6; }
            else if (treasureID <= 143)
            { jjj = 7; }
            else if (treasureID <= 184)
            { jjj = 8; }
            else if (treasureID <= 220)
            { jjj = 9; }
            else if (treasureID <= 241)
            { jjj = 10; }
            else if (treasureID <= 247)
            { jjj = 11; }
            else if (treasureID <= 248)
            { jjj = 12; }
            else if (treasureID <= 273)
            { jjj = 13; }
            else if (treasureID <= 348)
            { jjj = 14; }
            else if (treasureID <= 379)
            { jjj = 15; }
            else if (treasureID <= 390)
            { jjj = 16; }
            else if (treasureID <= 402)
            { jjj = 17; }
            else if (treasureID <= 426)
            { jjj = 18; }
            else if (treasureID <= 447)
            { jjj = 19; }
            else if (treasureID <= 468)
            { jjj = 20; }
            else if (treasureID <= 481)
            { jjj = 21; }
            else if (treasureID <= 490)
            { jjj = 22; }
            else if (treasureID <= 495)
            { jjj = 23; }
            else if (treasureID <= 496)
            { jjj = 24; }
            else if (treasureID <= 497)
            { jjj = 25; }
            else if (treasureID <= 498)
            { jjj = 26; }
            else if (treasureID <= 503)
            { jjj = 27; }
            else if (treasureID <= 506)
            { jjj = 28; }
            else if (treasureID <= 508)
            { jjj = 29; }
            else if (treasureID <= 512)
            { jjj = 30; }
            else if (treasureID <= 515)
            { jjj = 31; }
            else if (treasureID <= 519)
            { jjj = 32; }
            else if (treasureID <= 523)
            { jjj = 33; }
            else if (treasureID <= 525)
            { jjj = 34; }
            else if (treasureID <= 535)
            { jjj = 35; }
            else if (treasureID <= 538)
            { jjj = 36; }
            else if (treasureID <= 540)
            { jjj = 37; }
            else if (treasureID <= 543)
            { jjj = 38; }
            else if (treasureID <= 546)
            { jjj = 39; }
            else if (treasureID <= 550)
            { jjj = 40; }
            else if (treasureID <= 560)
            { jjj = 41; }
            else if (treasureID <= 740)
            { jjj = 99; }

            iii = iii - jjj * linesperchest;

            return iii;
        }
    }
}
