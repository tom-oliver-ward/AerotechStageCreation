using System;


namespace AerotechInterface
{
    public class Process
    {
        internal void addToLists(MacroGenerator macroGenerator, int insertAtIndex)
        {
            //translates this into a readable version of the unput
            string macroOutput = translate(macroGenerator.macroLine);

            if (insertAtIndex==-1)
            {
                //adds the macroline to the macro generator list
                macroGenerator.macro.Add(macroGenerator.macroLine);
                //adds this to the displayed list
                macroGenerator.listBoxMacro.Items.Add(macroOutput);
            }
            else
            {
                //ads the macroline to the generator list at the specified index
                macroGenerator.macro.Insert(insertAtIndex, macroGenerator.macroLine);
                //adds this to displayed list
                macroGenerator.listBoxMacro.Items.Insert(insertAtIndex, macroOutput);
            }
            //clears macroline for the next input
            Array.Clear(macroGenerator.macroLine, 0, macroGenerator.macroLine.Length);
        }

        private string translate(double[] macroLine)
        {
            
            string macroOutput;                     //string to store the command in a readable way
            string movementType;                    //string to store movement type in string form
            string Output1;
            string Output2;
            string Output3;

            //finds movement type
            if (macroLine[6] == 0)
            {
                movementType = "Incremental";
            }
            else if (macroLine[6] == 1)
            {
                movementType = "Absolute";
            }
            else
            {
                movementType = "Global";
            }

            if(macroLine[7]==0)
            {            
                // inserts x, y & z data
                Output1 = string.Format("X:{0}µm", macroLine[0]);
                Output2 = string.Format("Y:{0}µm", macroLine[1]);
                Output3 = string.Format("Z:{0}µm", macroLine[2]);
            }
            else
            {
                Output1 = string.Format("Start:{0}°", macroLine[0]);
                Output2 = string.Format("Included:{0}°", macroLine[1]);
                Output3 = string.Format("r:{0}µm", macroLine[2]);
            }
            
            //tests whether shot is required or nor
            if (macroLine[3] == 0)
            {
                //inserts speed data
                string speed = string.Format("Speed:{0}µm/s", macroLine[5]);
                //spaces items correctly for columns
                macroOutput = string.Format("{0,-15}{1,-15}{2,-15}{3,-40}{4,-15}", Output1, Output2, Output3, speed, movementType);
            }
            else
            {
                ///inserts shots and repRate data
                string shots = string.Format("Shots:{0}", macroLine[3]);
                string repRate = string.Format("Rep Rate:{0}Hz", macroLine[4]);
                //spaces utems correctly for columns
                macroOutput = string.Format("{0,-15}{1,-15}{2,-15}{3,-20}{4,-20}{5,-15}", Output1, Output2, Output3, shots, repRate, movementType);
            }
            
            return macroOutput;
        }

        /// <summary>
        /// takes an input new position and moves the selected index to that position 
        /// </summary>
        /// <param name="macroGenerator"></param>
        /// <param name="newIndex"> new position</param>
        internal void moveListItem(MacroGenerator macroGenerator, int newIndex)
        {
            //produces two variables, to hold the values of the displayed list and of the data list at the specified index
            var item = macroGenerator.listBoxMacro.Items[macroGenerator.listBoxMacro.SelectedIndex];
            double[] itemM = macroGenerator.macro[macroGenerator.listBoxMacro.SelectedIndex];

            //removes the variable at that entry
            int remove = macroGenerator.listBoxMacro.SelectedIndex;
            macroGenerator.listBoxMacro.Items.RemoveAt(remove);
            macroGenerator.macro.RemoveAt(remove);

            //inserts at the new specified point
            macroGenerator.listBoxMacro.Items.Insert(newIndex, item);
            macroGenerator.macro.Insert(newIndex, itemM);
            
            //changes selection to the new entry
            macroGenerator.listBoxMacro.SetSelected(newIndex, true);
        }
    }
}