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
        double Part;
        //Random rand1 = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInteger_Click(object sender, EventArgs e)
        {
            int Minimum;
            int Maximum;

            string Type = "Integer";
            Random rand1 = new Random();
            if (Int32.TryParse(TxtMinimum.Text, out Minimum))
            {
                if (Int32.TryParse(TxtMaximum.Text, out Maximum))
                {
                    Answer = rand1.Next(Minimum, Maximum);
                    LblAnswer.Text = ($"Random {Type}: {Answer}");

                }
                else
                    LblAnswer.Text = "Error";
            }


            else
                LblAnswer.Text = "Error";

            //Maximum = Convert.ToInt32(TxtMaximum.Text);
            //Answer = rand1.Next(Minimum,Maximum);
            //LblAnswer.Text = ($"Random {Type}: {Answer}");

        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            Double Minimum;
            Double Maximum;
            string Type = "Double";
            Random rand1 = new Random();
            Minimum = Convert.ToDouble(TxtMinimum.Text);
            Maximum = Convert.ToDouble(TxtMaximum.Text);
            Part = rand1.NextDouble();
            Answer = rand1.NextDouble() * (Maximum - Minimum) + Minimum;
            LblAnswer.Text = ($"Random {Type}: {Answer}");
        }
    }
}
