using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerotechInterface
{
    public partial class FileAndProgress : Form
    {
        public FileAndProgress(MacroGenerator formObject)
        {
            InitializeComponent();
        }

        private void button_SelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                textBoxFolderPath.Text = fbd.SelectedPath;

            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(textBoxFolderPath.Text))
                {
                MessageBox.Show("Invalid Path, directory does not exist", "Error");
            }

            
        }
    }
}
