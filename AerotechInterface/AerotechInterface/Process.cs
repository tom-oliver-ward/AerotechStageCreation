using System;


namespace AerotechInterface
{
    public class Process
    {
        internal void addToLists(MacroGenerator macroGenerator)
        {
            //adds the macroline to the macro generator list
            macroGenerator.macro.Add(macroGenerator.macroLine);

            //translates this into a readable version of the unput
            string macroOutput = translate(macroGenerator.macroLine);

            //adds this to the displayed list
            macroGenerator.listBoxMacro.Items.Add(macroOutput);

            //clears macroline for the next input
            Array.Clear(macroGenerator.macroLine, 0, macroGenerator.macroLine.Length);
        }

        private string translate(double[] macroLine)
        {
            
            string macroOutput;                     //string to store the command in a readable way
            string movementType;                    //string to store movement type in string form

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

            // inserts x, y & z data
            string xOutput = string.Format("X:{0}µm", macroLine[0]);
            string yOutput = string.Format("Y:{0}µm", macroLine[1]);
            string zOutput = string.Format("Z:{0}µm", macroLine[2]);

            //tests whether shot is required or nor
            if (macroLine[3] == 0)
            {
                //inserts speed data
                string speed = string.Format("Speed:{0}µm/s", macroLine[5]);
                //spaces items correctly for columns
                macroOutput = string.Format("{0,-15}{1,-15}{2,-15}{3,-40}{4,-15}", xOutput, yOutput, zOutput, speed, movementType);
            }
            else
            {
                ///inserts shots and repRate data
                string shots = string.Format("Shots:{0}", macroLine[3]);
                string repRate = string.Format("Rep Rate:{0}Hz", macroLine[4]);
                //spaces utems correctly for columns
                macroOutput = string.Format("{0,-15}{1,-15}{2,-15}{3,-20}{4,-20}{5,-15}", xOutput, yOutput, zOutput, shots, repRate, movementType);
            }
            
            return macroOutput;
        }
    }
}