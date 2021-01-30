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

        // create all of the savewarps as a savewarproom class.
        public static SaveWarpRoom shipsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Ship Save 1",
            Linenumber = 1710,
            Roomtype = "s",
        };
        public static SaveWarpRoom shipsavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Ship Save 1",
            Linenumber = 1769,
            Roomtype = "s",
        };
        public static SaveWarpRoom shipsavethree = new SaveWarpRoom()
        {
            Friendlyname = "Ship Save 3",
            Linenumber = 1828,
            Roomtype = "s",
        };
        public static SaveWarpRoom shipwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Ship Warp 1",
            Linenumber = 1887,
            Roomtype = "w",
        };

        public static SaveWarpRoom townsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Town Save 1",
            Linenumber = 2871,
            Roomtype = "s",
        };
        public static SaveWarpRoom townwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Town Warp 1",
            Linenumber = 2930,
            Roomtype = "w",
        };

        public static SaveWarpRoom entsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Entrance Save 1",
            Linenumber = 4640,
            Roomtype = "s",
        };
        public static SaveWarpRoom entsavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Entrance Save 2",
            Linenumber = 4699,
            Roomtype = "s",
        };
        public static SaveWarpRoom entwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Entrance Warp 1",
            Linenumber = 4758,
            Roomtype = "w",
        };

        public static SaveWarpRoom gardensaveone = new SaveWarpRoom()
        {
            Friendlyname = "Garden Save 1",
            Linenumber = 6491,
            Roomtype = "s",
        };

        public static SaveWarpRoom gardenwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Garden Warp 1",
            Linenumber = 6550,
            Roomtype = "w",
        };

        public static SaveWarpRoom cathedralsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Cathedral Save 1",
            Linenumber = 8565,
            Roomtype = "s",
        };
        public static SaveWarpRoom cathedrealsavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Cathedral Save 2",
            Linenumber = 8624,
            Roomtype = "s",
        };
        public static SaveWarpRoom cathedralsavethree = new SaveWarpRoom()
        {
            Friendlyname = "Cathedral Save 3",
            Linenumber = 8683,
            Roomtype = "s",
        };
        public static SaveWarpRoom cathedralwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Cathedral Warp 1",
            Linenumber = 7418,
            Roomtype = "w",
        };

        public static SaveWarpRoom hallsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Hall Save 1",
            Linenumber = 10558,
            Roomtype = "s",
        };
        public static SaveWarpRoom hallsavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Hall Save 2",
            Linenumber = 10617,
            Roomtype = "s",
        };
        public static SaveWarpRoom hallwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Hall Warp 1",
            Linenumber = 10676,
            Roomtype = "w",
        };

        public static SaveWarpRoom libresaveone = new SaveWarpRoom()
        {
            Friendlyname = "Libre Save 1",
            Linenumber = 13762,
            Roomtype = "s",
        };
        public static SaveWarpRoom libresavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Libre Save 2",
            Linenumber = 13821,
            Roomtype = "s",
        };
        public static SaveWarpRoom librewarpone = new SaveWarpRoom()
        {
            Friendlyname = "Libre Warp 1",
            Linenumber = 13880,
            Roomtype = "w",
        };

        public static SaveWarpRoom towersaveone = new SaveWarpRoom()
        {
            Friendlyname = "Tower Save 1",
            Linenumber = 15438,
            Roomtype = "s",
        };
        public static SaveWarpRoom towersavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Tower Save 2",
            Linenumber = 15497,
            Roomtype = "s",
        };
        public static SaveWarpRoom towerwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Tower Warp 1",
            Linenumber = 15556,
            Roomtype = "w",
        };

        public static SaveWarpRoom densaveone = new SaveWarpRoom()
        {
            Friendlyname = "Den Save 1",
            Linenumber = 17518,
            Roomtype = "s",
        };

        public static SaveWarpRoom undergroundsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Underground Save 1",
            Linenumber = 21304,
            Roomtype = "s",
        };
        public static SaveWarpRoom undergroundsavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Underground Save 2",
            Linenumber = 21363,
            Roomtype = "s",
        };
        public static SaveWarpRoom undergroundsavethree = new SaveWarpRoom()
        {
            Friendlyname = "Underground Save 3",
            Linenumber = 21422,
            Roomtype = "s",
        };
        public static SaveWarpRoom undergroundsavefour = new SaveWarpRoom()
        {
            Friendlyname = "Underground Save 4",
            Linenumber = 21481,
            Roomtype = "s",
        };
        public static SaveWarpRoom undergroundwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Underground Warp 1",
            Linenumber = 21540,
            Roomtype = "w",
        };
        public static SaveWarpRoom undergroundwarptwo = new SaveWarpRoom()
        {
            Friendlyname = "Underground Warp 2",
            Linenumber = 21599,
            Roomtype = "w",
        };

        public static SaveWarpRoom desertsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Desert Save 1",
            Linenumber = 23907,
            Roomtype = "s",
        };
        public static SaveWarpRoom desertwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Desert Warp 1",
            Linenumber = 23966,
            Roomtype = "w",
        };

        public static SaveWarpRoom sorcerysaveone = new SaveWarpRoom()
        {
            Friendlyname = "Sorcery Lab Save 1",
            Linenumber = 24652,
            Roomtype = "s",
        };
        public static SaveWarpRoom sorcerywarpone = new SaveWarpRoom()
        {
            Friendlyname = "Sorcery Lab Warp 1",
            Linenumber = 24711,
            Roomtype = "w",
        };

        public static SaveWarpRoom secretsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Secret Lab Save 1",
            Linenumber = 25526,
            Roomtype = "s",
        };
        public static SaveWarpRoom secretwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Secret Lab Warp 1",
            Linenumber = 25585,
            Roomtype = "w",
        };

        public static SaveWarpRoom orientalsaveone = new SaveWarpRoom()
        {
            Friendlyname = "Oriental Save 1",
            Linenumber = 26971,
            Roomtype = "s",
        };
        public static SaveWarpRoom orientalwarpone = new SaveWarpRoom()
        {
            Friendlyname = "Oriental Lab Warp 1",
            Linenumber = 27030,
            Roomtype = "w",
        };

        public static SaveWarpRoom infernosaveone = new SaveWarpRoom()
        {
            Friendlyname = "Inferno Save 1",
            Linenumber = 28269,
            Roomtype = "s",
        };
        public static SaveWarpRoom infernowarpone = new SaveWarpRoom()
        {
            Friendlyname = "Inferno Warp 1",
            Linenumber = 28328,
            Roomtype = "w",
        };

        public static SaveWarpRoom icesaveone = new SaveWarpRoom()
        {
            Friendlyname = "Ice Save 1",
            Linenumber = 29736,
            Roomtype = "s",
        };
        public static SaveWarpRoom icesavetwo = new SaveWarpRoom()
        {
            Friendlyname = "Ice Save 2",
            Linenumber = 29795,
            Roomtype = "s",
        };
        public static SaveWarpRoom icewarpone = new SaveWarpRoom()
        {
            Friendlyname = "Ice Warp 1",
            Linenumber = 29854,
            Roomtype = "w",
        };

        public static List<SaveWarpRoom> allsavewarps = new List<SaveWarpRoom>
        {
            shipsaveone, shipsavetwo, shipsavethree, shipwarpone,
            townsaveone, townwarpone,
            entsaveone, entsavetwo, entwarpone,
            gardensaveone, gardenwarpone,
            cathedralsaveone, cathedrealsavetwo, cathedralsavethree, cathedralwarpone,
            hallsaveone, hallsavetwo, hallwarpone,
            libresaveone, libresavetwo, librewarpone,
            towersaveone, towersavetwo, towerwarpone,
            densaveone,
            undergroundsaveone, undergroundsavetwo, undergroundsavethree, undergroundsavefour, undergroundwarpone, undergroundwarptwo,
            desertsaveone, desertwarpone,
            sorcerysaveone, sorcerywarpone,
            secretsaveone, secretwarpone,
            orientalsaveone, orientalwarpone,
            infernosaveone, infernowarpone,
            icesaveone, icesavetwo, icewarpone,
        };


        //used for gui button selection
        public static int modeselection = 1;

        //new version of write shuffle
        //expects a list of savewarprooms that has already been modified.
        //also expects the json file to write to and the spoiler log.
        public static void WriteShuffle(List<SaveWarpRoom> roomss, string[] roomLine, List<string> spoilerarray)
        {
            for (int i = 0; i < roomss.Count(); i++)
            {
                if (roomss[i].Roomtype == "w")
                {
                    roomLine[roomss[i].Linenumber] = "      \"RoomType\": \"ERoomType::" + "Warp" + "\",";
                }
                else if (roomss[i].Roomtype == "s")
                {
                    roomLine[roomss[i].Linenumber] = "      \"RoomType\": \"ERoomType::" + "Save" + "\",";
                }
                else if (roomss[i].Roomtype == "l")
                {
                    roomLine[roomss[i].Linenumber] = "      \"RoomType\": \"ERoomType::" + "Load" + "\",";
                }
                else
                { } //do nothing

                spoilerarray.Add(roomss[i].Friendlyname + " - " + roomss[i].Roomtype);
            }
        }

        //takes the game mode, a list of all savewarps, and a list of the values you want written
        public static void ApplyNewRooms (int gamemode , List<SaveWarpRoom> savewarps ,  List<string> newvalues)
        {
            if (gamemode == 1 || gamemode == 3)  //gamemode 1 & 3 guarantee safety savewarps
            {
                //find the 5 rooms we do not want to change and simply move them to the back of the list.
                SaveWarpRoom temphold = new SaveWarpRoom();

                int myindex = savewarps.FindIndex(p => p.Friendlyname == "Town Save 1");
                temphold = savewarps[myindex];
                savewarps.RemoveAt(myindex);
                savewarps.Add(temphold);

                myindex = savewarps.FindIndex(p => p.Friendlyname == "Town Warp 1");
                temphold = savewarps[myindex];
                savewarps.RemoveAt(myindex);
                savewarps.Add(temphold);

                myindex = savewarps.FindIndex(p => p.Friendlyname == "Underground Warp 1");
                temphold = savewarps[myindex];
                savewarps.RemoveAt(myindex);
                savewarps.Add(temphold);

                myindex = savewarps.FindIndex(p => p.Friendlyname == "Underground Warp 2");
                temphold = savewarps[myindex];
                savewarps.RemoveAt(myindex);
                savewarps.Add(temphold);

                myindex = savewarps.FindIndex(p => p.Friendlyname == "Desert Save 1");
                temphold = savewarps[myindex];
                temphold.Roomtype = "w";     //and also make sure this turns into a warp
                savewarps.RemoveAt(myindex);
                savewarps.Add(temphold);
            }
            else
            {
                //do nothing or throw exception
            }

            //now write the room types into each room
            for (int i = 0; i < newvalues.Count(); i++)
            {
                savewarps[i].Roomtype = newvalues[i];
            }
        }

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
            //manual fix for alfred warp
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
