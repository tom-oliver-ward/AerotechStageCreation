using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerotechInterface
{
    public partial class LAxesControlsLaser : Form
    {
        //initialises a variable to access MacroGenerator
        public MacroGenerator macroGenerator;
        public Process process = new Process();

        public bool laserCheck = false;
        
        protected internal LAxesControlsLaser(MacroGenerator formObject)
        {
            //assigns macroGenerator to the MacroGenerator class
            macroGenerator = formObject;
            InitializeComponent();
        }

        /// <summary>
        /// Feeds back variables into the overall macro list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AxesConfirm_Click(object sender, EventArgs e)
        {
            //Checks whether the user has selected the number of shots they will use (if they have slected laser)
            if (checkBoxLaser.Checked && numericUpDownLaser.Value==0)
            {
                MessageBox.Show("Please Enter A Number of Shots", "Error");
            }
            else
            {
                //adds the x, y and z data
                macroGenerator.macroLine[0] = (double)numericUpDownX.Value;
                macroGenerator.macroLine[1] = (double)numericUpDownY.Value;
                macroGenerator.macroLine[2] = (double)numericUpDownZ.Value;

                //checks if the user wants to use the laser
                if (checkBoxLaser.Checked == true)
                {
                    //Adds laser and rep rate data - sets speed to zero
                    macroGenerator.macroLine[3] = (double)numericUpDownLaser.Value;
                    macroGenerator.macroLine[4] = (double)numericUpDownRep.Value;
                    macroGenerator.macroLine[5] = 0;
                }
                else
                {
                    //Adds speed, sets laser and rep to zero
                    macroGenerator.macroLine[3] = 0;
                    macroGenerator.macroLine[4] = 0;
                    macroGenerator.macroLine[5] = (double)numericUpDownSpeed.Value;
                }
                
                //Adds movement type with zero for incremental, 1 for absolute, 2 for global
                if (checkBoxInc.Checked == true) { macroGenerator.macroLine[6] = 0; }
                if (checkBoxAbs.Checked == true) { macroGenerator.macroLine[6] = 1; }
                if (checkBoxGlo.Checked == true) { macroGenerator.macroLine[6] = 2; }

                //runs the process to add the data to the macro lists (both internal and display
                process.addToLists(macroGenerator);

                //closes form
                this.Close();
            }


            
        }

        /// <summary>
        /// auto unchecks the other options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxInc_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBoxAbs.Checked = false;
            checkBoxGlo.Checked = false;
            button_AxesConfirm.Enabled = true;
        }

        /// <summary>
        /// auto unchecks the other options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxAbs_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBoxInc.Checked = false;
            checkBoxGlo.Checked = false;
            button_AxesConfirm.Enabled = true;
        }

        /// <summary>
        /// auto unchecks the other options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxGlo_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBoxAbs.Checked = false;
            checkBoxInc.Checked = false;
            button_AxesConfirm.Enabled = true;
        }

        /// <summary>
        /// autoflips options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxLaser_CheckedChanged(object sender, EventArgs e)
        {
            laserCheck = !laserCheck;
            numericUpDownRep.Enabled = laserCheck;
            numericUpDownSpeed.Enabled = !laserCheck;
        }
    }
}
