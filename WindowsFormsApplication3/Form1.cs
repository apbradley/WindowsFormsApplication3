using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{

    public partial class Form1 : Form
    {
        private int i = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.tbTextDisplay.Clear();
            i = 0;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            this.tbTextDisplay.Text += "Write " + i.ToString() + "\r\n";
            i++;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
