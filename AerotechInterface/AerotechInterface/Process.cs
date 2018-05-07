using System;


namespace AerotechInterface
{
    public class Process
    {
        internal void addToLists(MacroGenerator macroGenerator)
        {
            macroGenerator.macro.Add(macroGenerator.macroLine);
            string macroOutput=translate(macroGenerator);
            macroGenerator.listBoxMacro.Items.Add(macroOutput);
            Array.Clear(macroGenerator.macroLine, 0, macroGenerator.macroLine.Length);
        }

        private string  translate(MacroGenerator macroGenerator)
        {
            int pad = 15;
            string macroOutput;
            string movementType;
            if (macroGenerator.macroLine[6] == 0)
            {
                movementType = "Incremental";
            }
            else if (macroGenerator.macroLine[6] == 1)
            {
                movementType = "Absolute";
            }
            else
            {
                movementType = "Global";
            }
            // use advanced options in string format to check spacing
            string xOutput = string.Format("X:{0}µm", macroGenerator.macroLine[0]);
            string yOutput = string.Format("Y:{0}µm", macroGenerator.macroLine[1]);
            string zOutput = string.Format("Z:{0}µm", macroGenerator.macroLine[2]);

            if (macroGenerator.macroLine[3]==0)
            {
                string speed = string.Format("Speed:{0}µm/s", macroGenerator.macroLine[5]);
                macroOutput = xOutput.PadRight(pad) + yOutput.PadRight(pad) +zOutput.PadRight(pad) + speed.PadRight(20) + " ".PadRight(30)
                    + movementType.PadRight(pad);
            }
            else
            {
                string shots = string.Format("Shots:{0}", macroGenerator.macroLine[3]);
                string repRate = string.Format("Rep Rate:{0}Hz", macroGenerator.macroLine[4]);
                macroOutput = xOutput.PadLeft(pad) + yOutput.PadLeft(pad) + zOutput.PadLeft(pad) + shots.PadLeft(30) + repRate.PadLeft(30)
                    + movementType.PadLeft(pad);
                //macroOutput = string.Format("X:{0}µm\tY:{1}µm\tZ:{2}µm\tShots:{3}\tRepRate:{4}Hz\t{5}",
                //macroGenerator.macroLine[0], macroGenerator.macroLine[1], macroGenerator.macroLine[2], macroGenerator.macroLine[3],
                //macroGenerator.macroLine[4], movementType);
            }        

            

            return macroOutput;
        }
    }
}