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

        private void listBoxMacro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMacro_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.listBoxMacro.SelectedItem == null) return;
            listBoxMacro.DoDragDrop(listBoxMacro.Text, DragDropEffects.Copy |  DragDropEffects.Move);
        }

        private void listBoxMacro_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBoxMacro.PointToClient(new Point(e.X, e.Y));
            int index = this.listBoxMacro.IndexFromPoint(point);
            if (index < 0) index = this.listBoxMacro.Items.Count - 1;
            object data = e.Data.GetData(typeof(DateTime));
            this.listBoxMacro.Items.Remove(data);
            this.listBoxMacro.Items.Insert(index, data);
        }

        private void listBoxMacro_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }




    }
}
