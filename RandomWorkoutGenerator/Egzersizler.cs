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

namespace RandomWorkoutGenerator
{
    public partial class Egzersizler : Form
    {
        Form1 frm = new Form1();
        private string line;

        public Egzersizler()
        {
            InitializeComponent();
        }

        private void Egzersizler_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();           
            frm.Show();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asd");
        }
    }
}
