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
    public partial class Lottory : Form
    {
        public int[] arr = new int[7];   // an array for the user inputs
        public int[] resultarr = new int[7];    //an array for the seven random numbers created
        public int result;        //used for the random value
        public int inputNum;    //'Lotto rad' user input
        public int AntalDrag;   //'Antal dragningar' user input
        private int isInt;
        
        Random random = new Random();
        public Lottory()
        {
            InitializeComponent();
        }

        private void LottoRad1_TextChanged(object sender, EventArgs e)
        {
            try
            {
  

                inputNum = int.Parse(LottoRad1.Text);   //puts the input into a int variable

                for (int ctr = 0; ctr <= 6; ctr++)      //checks if the input already exists
                {
                    if (inputNum == arr[ctr])
                    {
                        MessageBox.Show("Input already exists!");   //pushes out an error message box to notify the user and empties the input afterwards
                        LottoRad1.Text = String.Empty;
                    }

                }
                if (inputNum >= 1 && inputNum <= 35)    //checks if the the given input is between the correct interval
                {
                    arr[0] = inputNum;                  //Input is put in the array as the first element
                }else
                {
                    MessageBox.Show("Invalid Input!");  //shows an error box if wrong input has been given, such as negative inputs, decimal numbers or numbers outside the interval
                    LottoRad1.Text = String.Empty;
                   
                }

                
            }
            catch
            {
                if (!String.IsNullOrEmpty(LottoRad1.Text))      //helps avoid double messagebox popup-windows
                {
                    MessageBox.Show("Not an Integer!");    //catches errors such as string inputs. In which case it clears the text box.
                    LottoRad1.Text = String.Empty;

                }

            }

        }

        private void LottoRad2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inputNum = int.Parse(LottoRad2.Text);
 

                for (int ctr = 0; ctr <= 6; ctr++)
                {
                    if (inputNum == arr[ctr])
                    {
                        MessageBox.Show("Input already exists!");
                        LottoRad2.Text = String.Empty;
                    }

                }
                if (inputNum >= 1 && inputNum <= 35)
                {
                    arr[1] = inputNum;              //input is put as the second element

                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                    LottoRad2.Text = String.Empty;
                }
            }
            catch
            {
                if (!String.IsNullOrEmpty(LottoRad2.Text))      //helps avoid double messagebox popup-windows
                {
                    MessageBox.Show("Not an Integer!");    //catches errors such as string inputs. In which case it clears the text box.
                    LottoRad2.Text = String.Empty;

                }
            }
        }

        private void LottoRad3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inputNum = int.Parse(LottoRad3.Text);

                for (int ctr = 0; ctr <= 6; ctr++)
                {
                    if (inputNum == arr[ctr])
                    {
                        MessageBox.Show("Input already exists!");
                        LottoRad3.Text = String.Empty;
                    }

                }
                if (inputNum >= 1 && inputNum <= 35)
                {
                    arr[2] = inputNum;      //input is put as the thirs element

                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                    LottoRad3.Text = String.Empty;
                }
            }
            catch
            {
                if (!String.IsNullOrEmpty(LottoRad3.Text))      //helps avoid double messagebox popup-windows
                {
                    MessageBox.Show("Not an Integer!");    //catches errors such as string inputs. In which case it clears the text box.
                    LottoRad3.Text = String.Empty;

                }
            }
        }

        private void LottoRad4_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                inputNum = int.Parse(LottoRad4.Text);

                for (int ctr = 0; ctr <= 6; ctr++)
                {
                    if (inputNum == arr[ctr])
                    {
                        MessageBox.Show("Input already exists!");
                        LottoRad4.Text = String.Empty;
                    }

                }

                if (inputNum >= 1 && inputNum <= 35)
                {   
                    arr[3] = inputNum;      //input is put as the fourth element

                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                    LottoRad4.Text = String.Empty;
                }
            }
            catch
            {
                if (!String.IsNullOrEmpty(LottoRad4.Text))      //helps avoid double messagebox popup-windows
                {
                    MessageBox.Show("Not an Integer!");    //catches errors such as string inputs. In which case it clears the text box.
                    LottoRad4.Text = String.Empty;

                }
            }
        }

        private void LottoRad5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                inputNum = int.Parse(LottoRad5.Text);

                for (int ctr = 0; ctr <= 6; ctr++)
                {
                    if (inputNum == arr[ctr])
                    {
                        MessageBox.Show("Input already exists!");
                        LottoRad5.Text = String.Empty;
                    }

                }
                if (inputNum >= 1 && inputNum <= 35)
                {
                     arr[4] = inputNum;     //input is put as the fifth element
                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                    LottoRad5.Text = String.Empty;
                }

            }
            catch
            {
                if (!String.IsNullOrEmpty(LottoRad5.Text))      //helps avoid double messagebox popup-windows
                {
                    MessageBox.Show("Not an Integer!");    //catches errors such as string inputs. In which case it clears the text box.
                    LottoRad5.Text = String.Empty;

                }
            }
        }

        private void LottoRad6_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                inputNum = int.Parse(LottoRad6.Text);

                for (int ctr = 0; ctr <= 6; ctr++)
                {
                    if (inputNum == arr[ctr])
                    {
                        MessageBox.Show("Input already exists!");
                        LottoRad6.Text = String.Empty;
                    }

                }
                if (inputNum >= 1 && inputNum <= 35)
                {
                    arr[5] = inputNum;      //input is put as the sixth element

                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                    LottoRad6.Text = String.Empty;
                }

            }
            catch
            {
                if (!String.IsNullOrEmpty(LottoRad6.Text))      //helps avoid double messagebox popup-windows
                {
                    MessageBox.Show("Not an Integer!");    //catches errors such as string inputs. In which case it clears the text box.
                    LottoRad6.Text = String.Empty;

                }
            }
        }

        private void LottoRad7_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                inputNum = int.Parse(LottoRad7.Text);
                for (int ctr = 0; ctr <= 6; ctr++)
                {
                    if (inputNum == arr[ctr])
                    {
                        MessageBox.Show("Input already exists!");
                        LottoRad7.Text = String.Empty;
                    }

                }
                if (inputNum >= 1 && inputNum <= 35)
                {
                    arr[6] = inputNum;      //input is put as the seventh element
                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                    LottoRad7.Text = String.Empty;
                }
            }
            catch
            {
                if (!String.IsNullOrEmpty(LottoRad7.Text))      //helps avoid double messagebox popup-windows
                {
                    MessageBox.Show("Not an Integer!");    //catches errors such as string inputs. In which case it clears the text box.
                    LottoRad7.Text = String.Empty;

                }
            }
        }

        private void AntalDragtextBox_TextChanged(object sender, EventArgs e)
        {

            if (AntalDragtextBox.Text != String.Empty)      //if the 'antal dragningar' text box isn't empty
            {
                try
                {
                    AntalDrag = int.Parse(AntalDragtextBox.Text);       //saves the input as an integer
                }
                catch
                {
                    MessageBox.Show("Antal Dragningar is invalid");     //catches any invalid inputs, such as texts, negative or decimal and input that exceeds the max in value.
                    AntalDragtextBox.Text = String.Empty;
                }

            }

            
        }

        private void StartLotto_Click(object sender, EventArgs e)
        {
             int Five = 0;  // a local variable used to count the amount of 5 identical values
             int six = 0;   // a local variable used to count the amount of 6 identical values
            int seven = 0;  // a local variable used to count the amount of 7 identical values
            if (LottoRad1.Text != String.Empty && LottoRad2.Text != String.Empty &&
                LottoRad3.Text != String.Empty && LottoRad4.Text != String.Empty &&
                LottoRad5.Text != String.Empty && LottoRad6.Text != String.Empty &&
                LottoRad7.Text != String.Empty && AntalDragningar.Text != String.Empty)         //checks if all the input fields are not empty
            {
                for (int i = 0; i <= AntalDrag; i++)    //loop that is run as many times as the given 'Antal dragningar'
                {
                    int count = 0;
                    for (int ctr = 0; ctr <= 6; ctr++)
                    {
                        result = random.Next(1, 36);    //gets a random value between 1 and 35
                        if (resultarr.Contains(result)) //checks if value already exists
                        {
                            while (resultarr.Contains(result))  //as long as the value exists in the array
                            {
                                result = random.Next(1, 36);      //get a new value
                            }

                            resultarr[ctr] = result;        //if all is good so far, save the new value in the array
                        }
                        else
                        {
                            resultarr[ctr] = result;        //if the value doesn't already exist, save it in the array
                        }
                    }
                    for (int j = 0; j <= 6; j++)        //a loop used to count how many times a number in the input array is also found in random array
                    {
                        for (int k = 0; k <= 6; k++)
                        {
                            if (arr[j] == resultarr[k])
                            {
                                count = count + 1;         //everytime a number matches, count is increased by one
                            }

                        }

                    }

                    if (count == 5)         //if there are 5 identicals
                    {
                        Five = Five + 1;    //increses counter by 1
                    }
                    if (count == 6)         //6 identicals
                    {
                        six = six + 1;      //increses counter by 1
                    }
                    if (count == 7)         //seven identicals
                    {
                        seven = seven + 1;  //increses counter by 1
                    }


                }
                //writes out the following once the loop is done
                FemRättTextBox.Text = $"{Five}";    //amount of 5 identicals 
                SexRättTextBox.Text = $"{six}";     //amount of 6 identicals
                SjuRättTextBox.Text = $"{seven}";   //amount of 7 identicals
            }
            else
            {
                MessageBox.Show("All inputs must be given!");   //shows an error box incase all the text boxes hasn't been filled
            }

        }
    }
}
