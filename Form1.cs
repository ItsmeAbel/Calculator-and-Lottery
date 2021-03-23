using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLab2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LottoryButton_Click(object sender, EventArgs e)
        {
            Lottory form = new Lottory();
            form.Show();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Calculator form = new Calculator();
            form.Show();
        }
    }
}
