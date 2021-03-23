using Microsoft.SqlServer.Server;
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
    public partial class Calculator : Form
    {
        public int[] InputArray = new int[2];
        public int calcResult = 0;
        public int Trigger = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        //since all the number button clicks are almost identical. I will just comment in one of these button clicks inorder to avoid repetitiveness
        private void oneButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)   //checks if it's the first number to be pressed. Pressing any of the operation buttons changes this variable to 1.
            {
                try
                {
                    if (InputArray[0] == 0) //empties the text box if the first number pressed is zero. this is used to avoid writing multiple zeros before a number.
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "1";          //reads the number input from the text box, which is either a single 1 or several of them.
                    InputArray[0] = int.Parse(NumberInput.Text);        //saves the input at the begning of the array

                }
                catch                       //only possible error theat could occur is the int value exceeding its max value, which is handled by a try catch. 
                {
                    MessageBox.Show("Error! Input exceeds Max value!"); 
                    NumberInput.Text = String.Empty;

                }

            }
            else        //if it's not the first number to be pressed/clicked
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "1";
                    InputArray[1] = int.Parse(NumberInput.Text);        //the input is saved as the second element of the array

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "2";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
            else
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "2";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "3";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
            else
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "3";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "4";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
            else
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "4";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;
                }

            }
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "5";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
            else
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "5";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "6";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;
                }

            }
            else
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "6";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "7";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
            else
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "7";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;
                }

            }
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "8";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
            else
            {
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "8";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "9";
                    InputArray[0] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }

            }
            else
            {
                try
                {
                   if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "9";
                    InputArray[1] = int.Parse(NumberInput.Text);

                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;

                }
 
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {

            if (calcResult == 0)
            {
                try
                {
                    if (InputArray[0] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "0";
                    InputArray[0] = int.Parse(NumberInput.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;
                }

            }else{
                try
                {
                    if (InputArray[1] == 0)
                    {
                        NumberInput.Text = String.Empty;

                    }
                    NumberInput.Text = NumberInput.Text + "0";
                    InputArray[1] = int.Parse(NumberInput.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Input exceeds Max value!");
                    NumberInput.Text = String.Empty;
                }

            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            PreviousInput.Text = $"{InputArray[0]}";  //shows the first element on another text box
            NumberInput.Text = String.Empty;
            calcResult = 1;         //is used to determine if a number input should be saved as the first or second element in the array
            Trigger = 1;            //a global variable that triggers the calculations once the Equal sign is pressed. 1 is for addition

            
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            PreviousInput.Text = $"{InputArray[0]}";    
            NumberInput.Text = String.Empty;
            calcResult = 1;
            Trigger = 2;    //2 is subtraction
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            PreviousInput.Text = $"{InputArray[0]}";
            NumberInput.Text = String.Empty;
            calcResult = 1;
            Trigger = 3;    //3 is for multiplication
            
        }

        private void DevisionButton_Click(object sender, EventArgs e)
        {
            PreviousInput.Text = $"{InputArray[0]}";    
            NumberInput.Text = String.Empty;
            calcResult = 1;
            Trigger = 4;        //4 is for division
        }

        private void CButton_Click(object sender, EventArgs e)      //Resets everything when pressed
        {
            PreviousInput.Text = String.Empty;
            calcResult = 0;
            InputArray[0] = 0;
            InputArray[1] = 0;
            NumberInput.Text = String.Empty;

        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            switch (Trigger)
            {
                case 1:             // if trigger = 1, that means addition
                    InputArray[0] = InputArray[0] + InputArray[1];
                    textShow(InputArray[0]);
                    break;
                case 2:         // trigger = 2 means subtraction
                    InputArray[0] = InputArray[0] - InputArray[1];
                    textShow(InputArray[0]);
                    break;
                case 3:         //trigger = 3 means multiplication
                    InputArray[0] = InputArray[0] * InputArray[1];
                    textShow(InputArray[0]);
                    break;
                case 4:
                    if(InputArray[1] == 0){         //gives out an error box if the user tries to devide by zero
                        MessageBox.Show("Du får inte dela med 0!");
                        InputArray[0] = 0;          //resets the array
                        InputArray[1] = 0;
                        NumberInput.Text = String.Empty;    //empties the text box
                        break;
                    }
                    else
                    {
                        double temp1 = Convert.ToDouble(InputArray[0]);     //converts the elements to double before calculation so that decimal quotients can also be shown on the text box
                        double temp2 = Convert.ToDouble(InputArray[1]);
                        double temp3 = temp1 / temp2;                   //devides the two elements
                        NumberInput.Text = $"{temp3}";                  //writes it out on the text box
                        break;
                    }

                default:
                    NumberInput.Text = String.Empty;        //empties the text box by default.
                    break;
            }
        }

        private void textShow(int i) {      // a small class used to write data on the text box
            NumberInput.Text = $"{i}";
        }

    }
}
