using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_Random_Numbers_Forum
{
    public partial class Form1 : Form
    {
        int Minimum;
        int Maximum;
        double Answer;
        //Random rand1 = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            string Type = Integer;
            Random rand1 = new Random();
            Minimum = Convert.ToInt32(TxtMaximum.Text);
            Maximum = Convert.ToInt32(TxtMaximum.Text);
            Answer = rand1.Next(Minimum,Maximum);
            LblAnswer.Text = ($"Random {Type}: {Answer}");

        }
    }
}
