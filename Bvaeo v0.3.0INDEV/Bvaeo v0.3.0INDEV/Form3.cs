using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bvaeo_v0._3._0INDEV
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Users/curne/OneDrive/Code/Bvaeo/Bvaeo v0.3.0INDEV/Bvaeo v0.3.0INDEV/XandYStats.exe");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
