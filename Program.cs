using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace textcopier2
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the inital bool values for settings
            Globals.Initilize();

            //launch the UI
            Application.Run(new UserInterface());


        }


    }

}
