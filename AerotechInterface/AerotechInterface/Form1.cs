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
    public partial class MacroGenerator : Form
    {
        //The list containing the actual Macro Commands
        public List<double[]> macro = new List<double[]>();

        //variable to store the current macroline
        public double[] macroLine = new  double[6];

        /// <summary>
        /// initialises this form
        /// </summary>
        public MacroGenerator()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Button to control linear axis movement while firing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_LAxesLaser_Click(object sender, EventArgs e)
        {
            //initialises linear axes with laser controls form
            LAxesControlsLaser LAxesControlsLaser = new LAxesControlsLaser(this);

            //shows the form
            LAxesControlsLaser.ShowDialog();
        }
    }
}
