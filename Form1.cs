using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            Form2 emlakForm = new Form2();
            this.Hide();
            emlakForm.ShowDialog();
            this.Close();
        }
    }
}
