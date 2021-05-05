using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            double integer = Convert.ToInt32(integerInput.Text);

            if(integer >= 0)
            {
                outputLabel1.Text = $"{integer} is a positive number";
            }
            else
            {
                outputLabel1.Text = $"{integer} is a negative number";
            }

            if(integer % 7 == 0)
            {
                outputLabel2.Text = $"{integer} is divisible by 7";
            }
            else
            {
                outputLabel2.Text = $"{integer} is not divisible by 7";
            }
        }
    }
}
