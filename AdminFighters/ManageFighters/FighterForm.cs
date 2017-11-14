using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManageFighters
{
    public partial class FighterForm : Form
    {
        public FighterForm()
        {
            InitializeComponent();
        }

        private void buttonChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            labelNameFile.Text = openFileDialog1.SafeFileName;
        }

    }
}
