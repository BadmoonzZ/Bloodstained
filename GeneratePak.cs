using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace textcopier2
{
    class GeneratePak
    {
        public static void Generate(string recordseednumber, string dropfile, string craftfile, string shopfile, string questfile, string roomsfile, string UIfile, string shardmasterfile , string enemydmgfile)
        {
            //Initilize.  Create directories and remove old files.
            new FileInfo("Edits\\item\\file.txt").Directory.Create();  //this creates the directories if they don't exist.
            new FileInfo("Edits\\enemy\\file.txt").Directory.Create();  //this creates the directories if they don't exist.

            //if it exists, get rid of the old .bin file.
            string desttemp = "Edits\\PB_DT_DropMaster.bin";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }

            //if it exists, get rid of the old .json file
            desttemp = "Edits\\" + dropfile;
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }

            //if it exists, get rid of the old .uasset file in the pak folder
            desttemp = "PakContents\\BloodstainedRotN\\Content\\Core\\DataTable\\PB_DT_DropMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }

            //take the json file and move it into our edits folder
            desttemp = "Edits\\" + dropfile;
            File.Move(dropfile, desttemp); //possible crash if user wants to make a shop only rando or something weird.

            
            desttemp = "Edits\\PB_DT_CraftMaster.bin";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "PakContents\\BloodstainedRotN\\Content\\Core\\DataTable\\PB_DT_CraftMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "Edits\\" + craftfile;
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            if (Globals.shuffleCraftOn == true)
            {
                File.Move(craftfile, desttemp);
            }

            desttemp = "Edits\\PB_DT_QuestMaster.bin";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "PakContents\\BloodstainedRotN\\Content\\Core\\DataTable\\PB_DT_QuestMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "Edits\\" + questfile;
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
            if (Globals.shuffleQuestsOn == true)
            {
                File.Move(questfile, desttemp);
            }

            desttemp = "Edits\\item\\PB_DT_ItemMaster.bin";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "PakContents\\BloodstainedRotN\\Content\\Core\\DataTable\\item\\PB_DT_ItemMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "Edits\\item\\" + shopfile;
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
            if (Globals.shuffleShopOn == true)
            {
                File.Move(shopfile, desttemp);
            }

            desttemp = "Edits\\PB_DT_ShardMaster.bin";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "PakContents\\BloodstainedRotN\\Content\\Core\\DataTable\\PB_DT_ShardMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "Edits\\" + shardmasterfile;
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            if (Globals.nerfCharge == true)
            {
                File.Move(shardmasterfile, desttemp);
            }

            //*****
            desttemp = "Edits\\enemy\\PB_DT_CharacterParameterMaster.bin";
            if (File.Exists(desttemp))
            {
                File.Delete(desttemp);
                Debug.Write("deleted bin");
            }
            else { Debug.Write("did NOT delete bin"); }

            desttemp = "PakContents\\BloodstainedRotN\\Content\\Core\\DataTable\\enemy\\PB_DT_CharacterParameterMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp);
                Debug.Write("deleted uasset");
            }
            else { Debug.Write("did NOT delete uasset" ); }

            desttemp = "Edits\\enemy\\" + enemydmgfile;
            if (File.Exists(desttemp))
            { File.Delete(desttemp);
                Debug.Write("deleted json");
            }
            else { Debug.Write("did NOT delete json"); }

            if (Globals.chaosDamage == true)
            {
                File.Move(enemydmgfile, desttemp);
            }
            //*******

            //next we want to call the batch files to start the coversion to a pak.

            //step 1. convert our jsons to bins
            Process jsontoBin = new Process();
            jsontoBin.StartInfo.FileName = "Tools\\Uasset2Json.exe";
            jsontoBin.StartInfo.Arguments = " -tobin -force -newentries .\\Edits";
            jsontoBin.Start();
            jsontoBin.WaitForExit();

            
            //step 2. move bins and rename them to uassets in the pak folder
            desttemp = @"PakContents\BloodstainedRotN\Content\Core\DataTable\PB_DT_DropRateMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            File.Move(@"Edits\PB_DT_DropRateMaster.bin", desttemp);

            

            if (Globals.shuffleCraftOn == true)
            {
                desttemp = @"PakContents\BloodstainedRotN\Content\Core\DataTable\PB_DT_CraftMaster.uasset";
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
                File.Move(@"Edits\PB_DT_CraftMaster.bin", desttemp);
            }

            if (Globals.shuffleQuestsOn == true)
            {
                desttemp = @"PakContents\BloodstainedRotN\Content\Core\DataTable\PB_DT_QuestMaster.uasset";
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
                File.Move(@"Edits\PB_DT_QuestMaster.bin", desttemp);
            }

            if (Globals.shuffleShopOn == true)
            {
                desttemp = @"PakContents\BloodstainedRotN\Content\Core\DataTable\item\PB_DT_ItemMaster.uasset";
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
                File.Move(@"Edits\item\PB_DT_ItemMaster.bin", desttemp);
            }

            if (Globals.nerfCharge == true)
            {
                desttemp = @"PakContents\BloodstainedRotN\Content\Core\DataTable\PB_DT_ShardMaster.uasset";
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
                File.Move(@"Edits\PB_DT_ShardMaster.bin", desttemp);
            }

            if (Globals.chaosDamage == true)
            {
                desttemp = @"PakContents\BloodstainedRotN\Content\Core\DataTable\enemy\PB_DT_CharacterParameterMaster.uasset";
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
                File.Move(@"Edits\enemy\PB_DT_CharacterParameterMaster.bin", desttemp);
            }


            //For some reason, force new entreies breaks roommaster. need seperate routine.
            desttemp = "Edits\\PB_DT_RoomMaster.bin";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            desttemp = "PakContents\\BloodstainedRotN\\Content\\Core\\DataTable\\PB_DT_RoomMaster.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }

            desttemp = "Edits\\" + roomsfile;
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }

            if (Globals.shullfeSaveWarpOn == true)
            {
                 File.Move(roomsfile, desttemp);

                jsontoBin.StartInfo.FileName = "Tools\\Uasset2Json.exe";
                jsontoBin.StartInfo.Arguments = @" -tobin .\\Edits\PB_DT_RoomMaster.json";
                jsontoBin.Start();
                jsontoBin.WaitForExit();

                desttemp = @"PakContents\BloodstainedRotN\Content\Core\DataTable\PB_DT_RoomMaster.uasset";
                if (File.Exists(desttemp))
                { File.Delete(desttemp); }
                 File.Move(@"Edits\PB_DT_RoomMaster.bin", desttemp);
            }

            //keep UI editing seperate too.
            desttemp = "Edits\\ui\\" + UIfile;
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            File.Move(UIfile, desttemp);

            jsontoBin.StartInfo.FileName = "Tools\\Uasset2Json.exe";
            jsontoBin.StartInfo.Arguments = @" -tobin .\Edits\ui\PBSystemStringTable.json";
            jsontoBin.Start();
            jsontoBin.WaitForExit();

            desttemp = @"PakContents\BloodstainedRotN\Content\L10N\en\Core\StringTable\PBSystemStringTable.uasset";
            if (File.Exists(desttemp))
            { File.Delete(desttemp); }
            File.Move(@"Edits\ui\PBSystemStringTable.bin", desttemp);

            

            //step 3.  run UnrealPak to create the .pak file.
            Process createPak = new Process();
            createPak.StartInfo.FileName = "Tools\\UnrealPak-Without-Compression.bat";
            createPak.StartInfo.Arguments = "..\\PakContents";
            createPak.Start();
            createPak.WaitForExit();

            //step 4.  rename the pak to identify the flags and seed number.
            File.Move("PakContents.pak", "Output\\" + recordseednumber + "_Rando.pak");
        }
    }
}
