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
            if (checkBoxLaser.Checked && numericUpDownLaser.Value==0)
            {
                MessageBox.Show("Please Enter A Number of Shots", "Error");
            }
            else
            {
                if (checkBox_X.Checked) { macroGenerator.macroLine[0] = (double)numericUpDownX.Value; }
                if (checkBoxY.Checked == true) { macroGenerator.macroLine[1] = (double)numericUpDownY.Value; }
                if (checkBoxZ.Checked == true) { macroGenerator.macroLine[2] = (double)numericUpDownZ.Value; }

                if (checkBoxLaser.Checked == true)
                {
                    macroGenerator.macroLine[3] = (double)numericUpDownLaser.Value;
                    macroGenerator.macroLine[4] = (double)numericUpDownRep.Value;
                    macroGenerator.macroLine[5] = 0;
                }
                else
                {
                    macroGenerator.macroLine[4] = 0;
                    macroGenerator.macroLine[5] = (double)numericUpDownSpeed.Value;
                }

                macroGenerator.macroLine[5] = (double)numericUpDownSpeed.Value;
                if (checkBoxInc.Checked == true) { macroGenerator.macroLine[6] = 0; }
                if (checkBoxAbs.Checked == true) { macroGenerator.macroLine[6] = 1; }
                if (checkBoxGlo.Checked == true) { macroGenerator.macroLine[6] = 2; }

                process.addToLists(macroGenerator);
                this.Close();
            }


            
        }

        private void checkBoxInc_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAbs.ThreeState = false;
            checkBoxGlo.ThreeState = false;
            button_AxesConfirm.Enabled = true;
        }

        private void checkBoxAbs_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxInc.ThreeState = false;
            checkBoxGlo.ThreeState = false;
            button_AxesConfirm.Enabled = true;
        }

        private void checkBoxGlo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAbs.ThreeState = false;
            checkBoxInc.ThreeState = false;
            button_AxesConfirm.Enabled = true;
        }

        private void checkBoxLaser_CheckedChanged(object sender, EventArgs e)
        {
            laserCheck = !laserCheck;
            numericUpDownRep.Enabled = laserCheck;
            numericUpDownSpeed.Enabled = !laserCheck;
        }
    }
}
