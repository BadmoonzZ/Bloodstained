using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class ChaosDamage
    {
        public static void AllEnemies(string[] enemystatfile, Random rndshard)
        {
            string[] enemystatsLine = enemystatfile;

            int MorteStr = 1266;
            int SeamaStr = 1367;
            int CannonMorteStr = 1468;
            int AelloStr = 1569;
            int GhostStr = 1670;
            int DullahammerStr = 1773;  //unused
            int GiantRatStr = 1975;
            int BoneMorteStr = 2177;
            int BatStr = 2278;
            int GiermundStr = 2379;
            int BloodGrinderKnightStr = 2480;
            int SabnockStr = 2581;
            int MocoweedStr = 2682;
            int ToadStr = 2783;

            int PlumeParmaStr = 2884;
            int BarbatosStr = 2985;
            int CarabosseStr = 3086;
            int SimianStr = 3187;
            int ZaganStr = 3288;
            int PoltergeistStr = 3389;
            int OrdogStr = 3490;
            int GargoyleStr = 3591;
            int KillerBarberStr = 3692;

            int DemonStr = 3793;
            int BuerStr = 3894;
            int NyabonStr = 4096;
            int ScytheMiteStr = 4197;
            int DullahammerHeadStr = 4298;
            int BuerArmorStr = 4500;
            int WolfmanStr = 4702;

            int ThunderElementalStr = 4904;
            int CarriageMorteStr = 5005;
            int DantalionStr = 5106;
            int RulshaStr = 5207;
            int DecarabiaStr = 5308;
            int ShovelArmorStr = 5409;
            int MaledictionStr = 5510;

            int CelanoStr = 5611;
            int ShieldOutsiderStr = 5712;
            int PuppyStr = 6926;
            int LiliStr = 6015;
            int AssassinStr = 6116;
            int DragonStr = 6217;
            int KunekuneStr = 6318;

            int PoisonToadStr = 6419;
            int SidheStr = 6520;
            int BomberMorteStr = 6621;
            int MimicStr = 6825;
            int LightElementalStr = 7027;
            int OcypeteStr = 7128;
            int CyhyraethStr = 7229;
            int ChairMimicStr = 7330;

            int LerajeStr = 7431;
            int BloodBringerStr = 7532;
            int LanceArmorStr = 7633;
            int TamakoStr = 7734;
            int TriwheelBuerStr = 7835;
            int GamiginStr = 7936;
            int TitaniaStr = 8037;

            int AxeOutsiderStr = 8138;
            int ScyllaStr = 8239;
            int ForneusStr = 8340;
            int DeeseamaStr = 8542;
            int WaterLeaperStr = 8643;
            int GlashtynStr = 8744;
            int SeekerStr = 8845;
            int ArchdemonStr = 8946;

            int AmyStr = 9047;
            int AllocerStr = 9148;
            int VulshaStr = 9249;
            int LivingFossilStr = 9451;
            int RockyStr = 9350;
            int DarkElementalStr = 9552;
            int LamashtuStr = 9653;
            int MacaronStr = 9754;

            int BloodBugStr = 9855;
            int FireElementalStr = 9956;
            int VolcanoMorteStr = 10057;
            int HellhoundStr = 10158;
            int ZeparStr = 10259;
            int DeathtrapStr = 10360;

            int GusianStr = 10461;
            int GaapStr = 10562;
            int HaagentiStr = 10663;
            int KamikazeStr = 10865;
            int NinjaStr = 10764;
            int ChariotBuerStr = 10966;

            int GiantMocoStr = 11067;
            int GiantBatStr = 11168;
            int GiantToadStr = 11269;
            int GiantCannonStr = 11370;
            int GiantMorteStr = 11473;
            int GiantBuerStr = 11574;

            int SilverWolfmanStr = 11776;
            int MarbasStr = 11978;
            int AbyssalGuardianStr = 12079;
            //int AbyssalBossStr = 12180;
            int IceElementalStr = 12382;
            int TracerStr = 12483;
            int GusianCannonStr = 12584;
            int GAxeOutsiderStr = 12685;

            int DemonLordStr = 12786;
            int EightbitzombieStr = 12887;
            int EightbitghostStr = 12988;
            int EightbitskullStr = 13089;


            int CarpenterStr = 13190;
            int RevenantStr = 13291;
            //rev2
            int MillionareStr = 13493;
            //mill2
            int VeparStr = 14000;  //might be only body
            int CraftworkStr = 14309;
            int AndreaStr = 14515;
            int ValacStr = 14721; //valacmanager?
            int BloodlessStr = 15447; //might not be umbrulla

            List<int> enemydamage = new List<int>
            {
                MorteStr, SeamaStr, GhostStr, CannonMorteStr, AelloStr, //5
                GiantRatStr, BoneMorteStr, BatStr, GiermundStr, BloodGrinderKnightStr, SabnockStr, MocoweedStr, ToadStr, //+8
                PlumeParmaStr, BarbatosStr, CarabosseStr, SimianStr, ZaganStr, PoltergeistStr, OrdogStr, GargoyleStr, KillerBarberStr, //+9
                DemonStr, BuerStr, NyabonStr, ScytheMiteStr, DullahammerHeadStr, BuerArmorStr, WolfmanStr, //+7
                ThunderElementalStr, CarriageMorteStr, DantalionStr, RulshaStr, DecarabiaStr, ShovelArmorStr, MaledictionStr, //+7
                CelanoStr, ShieldOutsiderStr, LiliStr, AssassinStr, DragonStr, KunekuneStr, PoisonToadStr, //+7
                SidheStr, BomberMorteStr, MimicStr, LightElementalStr, OcypeteStr, PuppyStr, CyhyraethStr, ChairMimicStr, //+8
                LerajeStr, BloodBringerStr, LanceArmorStr, TamakoStr, TriwheelBuerStr, GamiginStr, TitaniaStr, //+7
                AxeOutsiderStr, ScyllaStr, ForneusStr, DeeseamaStr, WaterLeaperStr, GlashtynStr, SeekerStr, ArchdemonStr, //+8
                AmyStr, AllocerStr, VulshaStr, LivingFossilStr, RockyStr, DarkElementalStr, LamashtuStr, MacaronStr, //+8
                BloodBugStr, FireElementalStr, VolcanoMorteStr, HellhoundStr, ZeparStr, DeathtrapStr, //+6
                GusianStr, GaapStr, HaagentiStr, KamikazeStr, NinjaStr, ChariotBuerStr, //+6
                GiantMocoStr, GiantBatStr, GiantToadStr, GiantCannonStr, GiantMorteStr, GiantBuerStr, //+6
                SilverWolfmanStr, MarbasStr, AbyssalGuardianStr, IceElementalStr, TracerStr, GusianCannonStr, GAxeOutsiderStr, //+7
                DemonLordStr, EightbitzombieStr, EightbitghostStr, EightbitskullStr //+4
            };

            int intensity = 3 * 100;
            int amounttochange = 11;

            //int enemiestomodify = enemydamage.Count;

            //take the list and shuffle it, then the first x enemies in the list will be intestified.
            enemydamage = enemydamage.OrderBy(i => rndshard.Next()).ToList();

            if (Globals.chaosDamage == true)
            {
                for (int i = 0; i < amounttochange; i++)
                {
                    enemystatsLine[enemydamage[i]] = "      \"STR\": " + intensity + ".0,";
                    enemystatsLine[enemydamage[i] + 1] = "      \"INT\": " + intensity + ".0,";
                }
            }

            List<int> shufflelevels = new List<int>
            {
                7, //extra.  it is dullahammer.
                4, 5, 5, 6, 6,
                7, 8, 7, 8, 9, 10, 9, 10,
                10, 11, 11, 12, 13, 14, 13, 12, 13,
                13, 14, 15, 14, 25, 16, 17,
                16, 17, 17, 18, 19, 20, 25,
                20, 21, 20, 23, 27, 71, 24,
                18, 19, 23, 24, 27, 28, 29, 26,
                27, 27, 28, 29, 29, 29, 29,
                30, 30, 30, 30, 31, 31, 31, 32,
                33, 33, 34, 35, 37, 36, 37, 38,
                36, 37, 37, 38, 38, 38,
                38, 39, 39, 39, 40, 40,
                40, 40, 40, 40, 40, 41,
                41, 42, 44, 44, 45, 46, 47,
                48, 44, 44, 44
            };
            shufflelevels = shufflelevels.OrderBy(i => rndshard.Next()).ToList();

            if (Globals.chaosLevel == true)
            {
                for (int i = 0; i < enemydamage.Count(); i++)
                {
                    enemystatsLine[enemydamage[i] - 12] = "      \"DefaultEnemyLevel\": " + shufflelevels[i] + ",";
                    enemystatsLine[enemydamage[i] - 11] = "      \"HardEnemyLevel\": " + shufflelevels[i] + ",";
                    enemystatsLine[enemydamage[i] - 10] = "      \"NightmareEnemyLevel\": " + shufflelevels[i] + ",";
                }
            }
        }
    }
}
