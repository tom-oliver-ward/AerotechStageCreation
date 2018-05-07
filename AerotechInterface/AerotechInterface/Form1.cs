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
        //0 = x
        //1 = y
        //2 = z
        //3 = number of shots
        //4 = repitition rate
        //5 = Speed
        //6 = movement mode where 0 is incremental, 1 is Global and 2 is absolute
        public List<double[]> macro = new List<double[]>();

        //variable to store the current macroline
        public double[] macroLine = new  double[7];
        
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
        private void button_LMotion_Click(object sender, EventArgs e)
        {
            //initialises linear axes with laser controls form
            LAxesControlsLaser LAxesControlsLaser = new LAxesControlsLaser(this);

            //shows the form
            LAxesControlsLaser.ShowDialog();
        }
    }
}
