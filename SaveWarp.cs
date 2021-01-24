using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class SaveWarp
    {
        //this is a list of line numbers that each save or warp is on the PB_DT_RoomMaster.json.
        //these ints may need to be updated with every patch.  the rest of the functionality should remain.
        static int shipsave1 = 1710;
        static int shipsave2 = 1769;
        static int shipsave3 = 1828;
        static int shipwarp1 = 1887;
        static int townsave = 2871;  //town
        static int townwarp = 2930;  //town
        static int entsave1 = 4640;
        static int entsave2 = 4699;
        static int entwarp1 = 4758;
        static int gardensave1 = 6491;
        static int gardenwarp1 = 6550;
        static int cathedralsave1 = 8565;
        static int cathedralsave2 = 8624;
        static int cathedralsave3 = 8683;
        static int cathedralwarp1 = 7418;
        static int hallsave1 = 10558;
        static int hallsave2 = 10617;
        static int hallwarp1 = 10676;
        static int librasave1 = 13762;
        static int librasave2 = 13821;
        static int librawarp1 = 13880;
        static int towersave1 = 15438;
        static int towersave2 = 15497;
        static int towerwarp1 = 15556;
        static int densave1 = 17518;
        static int undergroundsave1 = 21304;
        static int undergroundsave2 = 21363;
        static int undergroundsave3 = 21422;
        static int undergroundsave4 = 21481;
        static int undergroundwarp1 = 21540; //might also be softlock
        static int undergroundwarp2 = 21599; //softlock
        static int desertsave1 = 23907; //softlock
        static int desertwarp1 = 23966;
        static int sorcerylabsave = 24652;
        static int sorcerylabwarp = 24711;
        static int secretlabsave = 25526;
        static int secretlabwarp = 25585;
        static int orientalsave = 26971;
        static int orientalwarp = 27030;
        static int infernosave = 28269;
        static int infernowarp = 28328;
        static int icesave1 = 29736;
        static int icesave2 = 29795;
        static int icewarp1 = 29854;

        //generates a list of safe saves and warps.  this is the default option and similiar to vanilla with the exception that Alfred is no longer a softlock.
        public static List<int> safeSaveWarps = new List<int>
            {
                shipsave1, shipsave2, shipsave3, shipwarp1,
                entsave1, entsave2, entwarp1,
                gardensave1, gardenwarp1,
                cathedralsave1, cathedralsave2, cathedralsave3, cathedralwarp1,
                hallsave1, hallsave2, hallwarp1,
                librasave1, librasave2, librawarp1,
                towersave1, towersave2, towerwarp1,
                densave1,
                undergroundsave1, undergroundsave2, undergroundsave3, undergroundsave4,
                desertwarp1,
                sorcerylabsave, sorcerylabwarp,
                secretlabsave, secretlabwarp,
                orientalsave, orientalwarp,
                infernosave, infernowarp,
                icesave1, icesave2, icewarp1
            };

        //generates a list of save warps.  could have softlocks. town could have no warp or save.
        public static List<int> unsafeSaveWarps = new List<int>
            {
                shipsave1, shipsave2, shipsave3, shipwarp1,
                townsave, townwarp,
                entsave1, entsave2, entwarp1,
                gardensave1, gardenwarp1,
                cathedralsave1, cathedralsave2, cathedralsave3, cathedralwarp1,
                hallsave1, hallsave2, hallwarp1,
                librasave1, librasave2, librawarp1,
                towersave1, towersave2, towerwarp1,
                densave1,
                undergroundsave1, undergroundsave2, undergroundsave3, undergroundsave4, undergroundwarp1, undergroundwarp2,
                desertwarp1, desertsave1,
                sorcerylabsave, sorcerylabwarp,
                secretlabsave, secretlabwarp,
                orientalsave, orientalwarp,
                infernosave, infernowarp,
                icesave1, icesave2, icewarp1
            };

        //used for gui button selection
        public static int modeselection = 1;

        //takes a list of save and warps you want to use. for example safeSaveWarps
        //takes a list of how many saves and warps you want, default can be created using Buildroomshelperlist()
        //requires the file we are writing too.
        //also requires the spoiler log.
        public static void WriteShuffling(List<int> linenumsavewarps, List<string> savewarpslist , string[] roomLine , List<string> spoilerarray)
        {
            //should add error collection check here.
            for (int i = 0; i < linenumsavewarps.Count(); i++)
            {
                if (savewarpslist[i] == "w")
                    roomLine[linenumsavewarps[i]] = "      \"RoomType\": \"ERoomType::" + "Warp" + "\",";
                else if (savewarpslist[i] == "s")
                    roomLine[linenumsavewarps[i]] = "      \"RoomType\": \"ERoomType::" + "Save" + "\",";
                else if (savewarpslist[i] == "l")
                    roomLine[linenumsavewarps[i]] = "      \"RoomType\": \"ERoomType::" + "Load" + "\",";
                else
                { }//do nothing

                switch(i){
                    case 0:
                        spoilerarray.Add("Ship1" + " - " + savewarpslist[i]);
                        break;
                    case 1:
                        spoilerarray.Add("Ship2" + " - " + savewarpslist[i]);
                        break;
                    case 2:
                        spoilerarray.Add("Ship3" + " - " + savewarpslist[i]);
                        break;
                    case 3:
                        spoilerarray.Add("Ship4" + " - " + savewarpslist[i]);
                        break;
                    default:
                        spoilerarray.Add("" + " - " + savewarpslist[i]);
                        break;
                }
            }
        }

        // for the safe list: 13warp , 26save , +5 unshuffled
        public static int roomswarpcount = 13;
        public static int roomssavecount = 26;
        public static int roomsloadcount = 0;

        //takes 3 intigers, the number of warps, saves, and blanks you wish to place, then returns a list
        public static List<string> Buildroomshelperlist(int warp, int save, int load)
        {
            List<string> roomshelperlist = new List<string>();

            //build a list of amount of saves warps
            for (int i = 0; i < roomswarpcount; i++)
            {
                roomshelperlist.Add("w");
            }
            for (int i = 0; i < roomssavecount; i++)
            {
                roomshelperlist.Add("s");
            }
            for (int i = 0; i < roomsloadcount; i++)
            {
                roomshelperlist.Add("l");
            }

            return roomshelperlist;
        }

    }
}
