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
    public partial class AngularAxesControl : Form
    {

        //initialises a variable to access MacroGenerator
        public MacroGenerator macroGenerator;
        public Process process = new Process();
        public bool laserCheck = false;

        public AngularAxesControl(MacroGenerator formObject)
        {
            InitializeComponent();
            macroGenerator = formObject;
        }

        private void button_AxesConfirm_Click(object sender, EventArgs e)
        {
            int insertAtIndex = -1;
            //Checks whether the user has selected the number of shots they will use (if they have slected laser)
            if (checkBoxLaser.Checked && numericUpDownLaser.Value == 0)
            {
                MessageBox.Show("Please Enter A Number of Shots", "Error");
            }
            //checks if the user has unticked all the position options
            else if (checkBoxStart.Checked == false && checkBoxEnd.Checked == false && checkBoxIndex.Checked == false)
            {
                MessageBox.Show("Please select a position for entry", "Error");
            }
            //checks if the user has unticked all of the movement type options
            else if (checkBoxInc.Checked == false && checkBoxGlo.Checked == false && checkBoxAbs.Checked == false)
            {
                MessageBox.Show("Please select a motion type", "Error");
            }
            else
            {
                //adds the x, y and z data
                macroGenerator.macroLine[0] = (double)numericUpDownSAngle.Value;
                macroGenerator.macroLine[1] = (double)numericUpDownIAngle.Value;
                macroGenerator.macroLine[2] = (double)numericUpDownRadius.Value;

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

                //sets to angular motion
                macroGenerator.macroLine[7] = 1;

                //Adds where in the list macro should be added
                if (checkBoxStart.Checked == true) { insertAtIndex = 0; }
                if (checkBoxEnd.Checked == true) { insertAtIndex = -1; }
                if (checkBoxIndex.Checked == true) { insertAtIndex = (int)numericUpDownIndex.Value; }

                //runs the process to add the data to the macro lists (both internal and display
                process.addToLists(macroGenerator, insertAtIndex);

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
            bool checkd = checkBoxInc.Checked;
            checkBoxAbs.Checked = false;
            checkBoxGlo.Checked = false;
            button_AxesConfirm.Enabled = true;
            checkBoxInc.Checked = checkd;
        }

        /// <summary>
        /// auto unchecks the other options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxAbs_CheckedChanged(object sender, EventArgs e)
        {
            bool checkd = checkBoxAbs.Checked;
            checkBoxInc.Checked = false;
            checkBoxGlo.Checked = false;
            button_AxesConfirm.Enabled = true;
            checkBoxAbs.Checked = checkd;
        }

        /// <summary>
        /// auto unchecks the other options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxGlo_CheckedChanged(object sender, EventArgs e)
        {
            bool checkd = checkBoxGlo.Checked;
            checkBoxAbs.Checked = false;
            checkBoxInc.Checked = false;
            button_AxesConfirm.Enabled = true;
            checkBoxGlo.Checked = checkd;
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

        private void checkBoxStart_CheckedChanged(object sender, EventArgs e)
        {
            bool checkd = checkBoxStart.Checked;
            numericUpDownIndex.Enabled = false;
            numericUpDownIndex.Value = 0;
            checkBoxEnd.Checked = false;
            checkBoxIndex.Checked = false;
            checkBoxStart.Checked = checkd;
        }

        private void checkBoxEnd_CheckedChanged(object sender, EventArgs e)
        {
            bool checkd = checkBoxEnd.Checked;
            numericUpDownIndex.Enabled = false;
            numericUpDownIndex.Value = 0;
            checkBoxStart.Checked = false;
            checkBoxIndex.Checked = false;
            checkBoxEnd.Checked = checkd;
        }

        private void checkBoxIndex_CheckedChanged(object sender, EventArgs e)
        {
            bool checkd = checkBoxIndex.Checked;
            numericUpDownIndex.Enabled = true;
            checkBoxStart.Checked = false;
            checkBoxEnd.Checked = false;
            checkBoxIndex.Checked = checkd;
        }

        private void numericUpDownIndex_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownIndex.Value > (macroGenerator.listBoxMacro.Items.Count - 1))
            {
                numericUpDownIndex.Value = (macroGenerator.listBoxMacro.Items.Count);
            }
        }
    }
}
