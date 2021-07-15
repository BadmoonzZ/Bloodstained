using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class Globals
    {
        public static bool shuffleShardsOn = false;
        public static bool shullfeSaveWarpOn = false;
        public static bool shuffleChestOn = false;
        public static bool shuffleShopOn = false;
        public static bool shuffleCraftOn = false;
        public static bool shuffleDropsOn = false;
        public static bool shuffleQuestsOn = false;

        public static bool nerfCharge = false;
        public static bool earlyAccel = false;
        public static bool earlyWeapon = false;
        public static bool chaosDamage = false;

        public static bool writeSpoilerLog = true;

        public static int seednumber;

        public static void Initilize()
        {
            shuffleShardsOn = true;
            shullfeSaveWarpOn = true;
            shuffleChestOn = true;
            shuffleShopOn = true;
            shuffleCraftOn = true;
            shuffleDropsOn = true;
            shuffleQuestsOn = true;
        }
    }
}
