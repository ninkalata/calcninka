using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorsimple
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 16)
            {
                _errorProvider.SetError(textBox1, "length should less than 4!");
            }

            else
            {
                _errorProvider.Clear();
            }
            //if (textBox1.Text.Length > 16)
            //{
            //    MessageBox.Show("Can Enter only two Characters in this Textbox.", "Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            //{
            //    // MessageBox.Show("Please enter only numbers.");

            //    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            //}
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }
        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        private void bdot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void badd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }
        private void bdiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }
        private void bequal_Click(object sender, EventArgs e)
        {


            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "x^y")
            {

                textBox1.Text = Convert.ToString(Convert.ToDouble(FirstNumber) % Convert.ToDouble(textBox1.Text));
                // Result = System.Math.Pow(Convert.ToDouble(FirstNumber), Convert.ToDouble(SecondNumber));
                //textBox1.Text = Convert.ToString(Result);
                // FirstNumber = Result;
            }

            if (Operation == "%")
            {

                Result = (Convert.ToDouble(FirstNumber) % Convert.ToDouble(SecondNumber));
                // Result = (Convert.ToDouble(FirstNumber) % Convert.ToDouble(SecondNumber));
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "nPr")
            {
                int varn, var2, var3; //variable declaration 
                varn = factorial(Convert.ToInt32(FirstNumber)); //calling factorial function 
                var2 = factorial(Convert.ToInt32(FirstNumber) - Convert.ToInt32(SecondNumber));
                textBox1.Text = Convert.ToString(varn / var2); //storing or showing result of factorial variables 
            }
            if (Operation == "nCr")
            {
                int varn, var2, var3;
                varn = factorial(Convert.ToInt32(FirstNumber));
                var2 = factorial(Convert.ToInt32(FirstNumber) - Convert.ToInt32(textBox1.Text));
                var3 = factorial(Convert.ToInt32(textBox1.Text));
                textBox1.Text = Convert.ToString(varn / (var3 * var2));
            }


        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void bsquare_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "x2";
            FirstNumber = (FirstNumber * FirstNumber);
            textBox1.Text = Convert.ToString(FirstNumber);
            FirstNumber = FirstNumber;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void n3_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            n1.ForeColor = Color.Red;
            n1.Font = new Font(n1.Font, FontStyle.Bold);
            n1.BackColor = Color.Aqua;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }


        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {


            //if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            //{
            //    //_errorProvider.SetError(textBox1, "length should less than 4!");

            //}
            //else
            //{
            //    _errorProvider.Clear();
            //}
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue < 48 || e.KeyValue > 57)
                e.SuppressKeyPress = true;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void bcube_Click(object sender, EventArgs e)
        {
            double Result;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "x3";
            Result = (FirstNumber * FirstNumber * FirstNumber);
            textBox1.Text = Convert.ToString(Result);
            FirstNumber = Result;
        }

        private void badsub_Click(object sender, EventArgs e)

        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-Convert.ToInt32(textBox1.Text));

        }

        private void bexp_Click(object sender, EventArgs e)
        {
            double Result;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+/-";
            Result = (1.0 / FirstNumber);
            textBox1.Text = Convert.ToString(Result);
            FirstNumber = System.Math.Round(Result);
        }

        private void bpow_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "x^y";

        }

        private void bMOD_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "%";
        }

        private void bper_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "nPr";
        }

        private void bac_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Text = "0";
        }
        private int factorial(int x)
        {
            int i = 1; //initialization values of i to 1
            for (int s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }

        private void bPi_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592654";
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text)));
        }

        private void blog_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text)));

        }

        private void bfac_Click(object sender, EventArgs e)
        {
            int var1 = 1;
            for (int i = 1; i <= Convert.ToInt16(textBox1.Text); i++)
            {
                var1 = var1 * i;
            }
            textBox1.Text = Convert.ToString(var1);
        }

        private void backspace_Click(object sender, EventArgs e)
        {

        }

        private void bncr_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "nCr";
        }

        private void bradian_Click(object sender, EventArgs e)
        {
           // textBox1.Text = Convert.ToString(System.Math.(Convert.ToDouble(textBox1.Text)));

        }

        private void History_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bhistory_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }
    }
}
