using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        bool y0Active = false;
        bool y2Active = false;
        bool y1Active = false;
        bool y3Active = false;
        String R = "";
        String S = "";
        String Q = "";

        private void button2_Click(object sender, EventArgs e)
        {
            y0Active = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            y2Active = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y1Active = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y3Active = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            R = comboBox4.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String A = comboBox4.Text;
            String notA = "";
            
            for (int i = 0; i < comboBox4.Text.Length; i++)
                {
                    if(A[i] == '0') {
                    notA += String.Concat("1");
                    }else if(A[i] == '1'){
                    notA += String.Concat("0");
                }
                }
            R = notA;
            comboBox6.Text = R;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String B = comboBox3.Text;
            String notB = "";
            for (int i = 0; i < comboBox3.Text.Length; i++)
            {
                if (B[i] == '0')
                {
                    notB += String.Concat("1");
                }
                else if (B[i] == '1')
                {
                    notB += String.Concat("0");
                }
            }
            S = notB;
            comboBox6.Text = S;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            S = comboBox3.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String res = "";
            String reverseRes = "";
            int n = 0;
            for (int i = R.Length - 1; i >= 0; i--)
            {
                if(R[i] == '0' && S[i] == '0')
                {
                    if (i == R.Length - 1 && n > 0)
                    {
                        res += String.Concat("0");
                    }
                    else if (R[i + 1] == '1' && S[i + 1] == '1')
                    {
                        res += String.Concat("1");
                    }
                    else if (R[i + 1] == '1' && S[i + 1] == '0' && res[n-1] == '0' || R[i + 1] == '0' && S[i + 1] == '1' && res[n-1] == '0')
                    {
                        res += String.Concat("1");
                    }
                    else res += String.Concat("0");
                }else if (R[i] == '1' && S[i] == '0')
                {
                    if (i == R.Length - 1)
                    {
                        res += String.Concat("1");
                    }
                    else if  (R[i + 1] == '1' && S[i + 1] == '1')
                    {
                        res += String.Concat("0");
                    }
                    else if (R[i + 1] == '1' && S[i + 1] == '0' && res[n-1] == '0' || R[i + 1] == '0' && S[i + 1] == '1' && res[n-1] == '0')
                    {
                        res += String.Concat("0");
                    }
                    else res += String.Concat("1");
                }else if (R[i] == '0' && S[i] == '1')
                {
                    if (i == R.Length - 1)
                    {
                        res += String.Concat("1");
                    }
                    else if (R[i + 1] == '1' && S[i + 1] == '1')
                    {
                        res += String.Concat("0");
                    }
                    else if (R[i + 1] == '1' && S[i + 1] == '0' && res[n-1] == '0' || R[i + 1] == '0' && S[i + 1] == '1' && res[n-1] == '0')
                    {
                        res += String.Concat("0");
                    }
                    else res += String.Concat("1");
                }
                else if(R[i] == '1' && S[i] == '1')
                {
                    if (i == R.Length - 1)
                    {
                        res += String.Concat("0");
                    }
                    else if (R[i + 1] == '1' && S[i + 1] == '1')
                    {
                        res += String.Concat("1");
                    }
                    else if (R[i + 1] == '1' && S[i + 1] == '0' && res[n-1] == '0' || R[i + 1] == '0' && S[i + 1] == '1' && res[n-1] == '0')
                    {
                        res += String.Concat("1");
                    }
                    else res += String.Concat("0");
                }
                n++;
            }

            for (int i = res.Length - 1; i >= 0; i--){
                reverseRes += String.Concat(res[i]);
            }
            comboBox6.Text = reverseRes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button33_Click(object sender, EventArgs e)
        {
            if (y0Active && y2Active)
            {
                comboBox4.Text = comboBox1.Text;
            }
            if(y1Active && y3Active)
            {
                comboBox3.Text = comboBox2.Text;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            y0Active = false;
            y2Active = false;
            y1Active = false;
            y3Active = false;
            comboBox4.Text = "";
            comboBox3.Text = "";
        }
    }
}
