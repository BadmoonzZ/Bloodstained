using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textcopier2
{
    class SaveWarpRoom
    {

        //create a class for RoomWarp
        //has an int for the line number above
        //has a string for an easy refrence name
        //has a value for if it is a warp save or load
        //we can then create a list of RoomWarps with which know their line number, type, and name.

        public int Linenumber { get; set; }
        public string Friendlyname { get; set; }
        public string Roomtype { get; set; }

        public SaveWarpRoom()
        {
            Roomtype = "s";
        }
    }
}
