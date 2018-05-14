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
        public Process process = new Process();
        //The list containing the actual Macro Commands
        //0 = x or start angle
        //1 = y or included angle
        //2 = z or radius
        //3 = number of shots
        //4 = repitition rate
        //5 = Speed
        //6 = movement mode where 0 is incremental, 1 is Global and 2 is absolute
        //7 = linear (0) or angular (1)
        public List<double[]> macro = new List<double[]>();

        //variable to store the current macroline
        public double[] macroLine = new  double[8];
        public int selected;

        
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

        /// <summary>
        /// controls what happens when the list is clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMacro_MouseClick(object sender, MouseEventArgs e)
        {
            //checks the string isn't empty
            if (this.listBoxMacro.SelectedItem == null) return;

            //displays the selected item in the box on the side
            textBoxArrayPos.Text = listBoxMacro.SelectedIndex.ToString();
            Application.DoEvents();
            listBoxMacro.DoDragDrop(listBoxMacro.Text, DragDropEffects.Copy |  DragDropEffects.Move);
        }

        private void listBoxMacro_DragDrop(object sender, DragEventArgs e)
        {
            //Point point = listBoxMacro.PointToClient(new Point(e.X, e.Y));
            //int index = this.listBoxMacro.IndexFromPoint(point);
            //if (index < 0) index = this.listBoxMacro.Items.Count - 1;
            //object data = e.Data.GetData(typeof(DateTime));
            //this.listBoxMacro.Items.Remove(data);
            //this.listBoxMacro.Items.Insert(index, data);
        }

        private void listBoxMacro_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        
         /// <summary>
    /// Moves item up in list
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void buttonMUp_Click(object sender, EventArgs e)
        {
            //checks item is selected
            if (this.listBoxMacro.SelectedItem == null) return;
            //sets new index to be the one below
            int newIndex = listBoxMacro.SelectedIndex - 1;
            //moves the item
            process.moveListItem(this, newIndex);
        }

        /// <summary>
        /// Moves item down in list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMDown_Click(object sender, EventArgs e)
        {
            //checks item is selected
            if (this.listBoxMacro.SelectedItem == null) return;
            //sets new index to be the one above
            int newIndex = listBoxMacro.SelectedIndex + 1;
            //moves the item
            process.moveListItem(this, newIndex);            
        }

        private void button_AMotion_Click(object sender, EventArgs e)
        {
            AngularAxesControl aAxesControlLaser = new AngularAxesControl(this);
            aAxesControlLaser.ShowDialog();
        }

        private void buttonConvertA_Click(object sender, EventArgs e)
        {
            FileAndProgress fileandprogress=new FileAndProgress(this);
            fileandprogress.ShowDialog();
        }




    }
}
