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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("X");
            comboBox1.Items.Add("Y");
            //comboBox1.Items.Add("Z");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("X");
            //comboBox1.Items.Add("Y");
            //comboBox1.Items.Add("Z");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Users/curne/OneDrive/Code/Bvaeo/Bvaeo v0.3.0INDEV/Bvaeo v0.3.0INDEV/XandYStats.exe");
            System.Threading.Thread.Sleep(5000);
            Form3 frm = new Form3();
            frm.Show();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}
