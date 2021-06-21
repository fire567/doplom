using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALU1_diplom
{

    

    public partial class Form1 : Form
    {
        bool[] flags = new bool[33];

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < flags.Length; i++)
            {
                flags[i] = false;
            }
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox13.Enabled = false;
        }

        bool y0Active = false;
        bool y2Active = false;
        bool y1Active = false;
        bool y3Active = false;
        bool y4Active = false;
        bool y5Active = false;
        bool y6Active = false;
        bool y7Active = false;
        bool y8Active = false;
        bool y9Active = false;
        bool y10Active = false;
        bool y11Active = false;
        bool y12Active = false;
        bool y13Active = false;
        bool y32Active = false;
        bool y16Active = false;
        bool y17Active = false;
        bool y18Active = false;
        bool y19Active = false;
        bool y20Active = false;
        bool y24Active = false;
        bool y25Active = false;
        bool y26Active = false;
        bool y27Active = false;
        String DRActive = "";
        String DLActive = "";
        String Shina = "";
        String DRValue = "0";
        String DLValue = "0";
        String DRSActive = "";
        String DRSValue = "0";
        String DLSValue = "0";
        String DLSActive = "";
        String R = "00000000";
        String S = "00000000";
        String Q = "00000000";
        String F = "00000000";
        String C = "00000000";
        String D = "00000000";

        private void y25_Click(object sender, EventArgs e)
        {
            flags[25] = !flags[25];

            if (y25.BackColor == Color.LightCyan)
            {
                y25.BackColor = Color.Aqua;
            }
            else
            {
                y25.BackColor = Color.LightCyan;
            }
            y25Active = true;
        }

            

        private void y17_Click(object sender, EventArgs e)
        {
            flags[17] = !flags[17];

            if (y17.BackColor == Color.LightCyan)
            {
                y17.BackColor = Color.Aqua;
            }
            else
            {
                y17.BackColor = Color.LightCyan;
            }
            y17Active = true;
        }

        private void y16_Click(object sender, EventArgs e)
        {
            flags[16] = !flags[16];

            if (y16.BackColor == Color.LightCyan)
            {
                y16.BackColor = Color.Aqua;
            }
            else
            {
                y16.BackColor = Color.LightCyan;
            }
            y16Active = true;
        }

        private void y18_Click(object sender, EventArgs e)
        {
            flags[18] = !flags[18];

            if (y18.BackColor == Color.LightCyan)
            {
                y18.BackColor = Color.Aqua;
            }
            else
            {
                y18.BackColor = Color.LightCyan;
            }
            y18Active = true;
        }

        private void y27_Click(object sender, EventArgs e)
        {
            flags[27] = !flags[27];

            if (y27.BackColor == Color.LightCyan)
            {
                y27.BackColor = Color.Aqua;
            }
            else
            {
                y27.BackColor = Color.LightCyan;
            }
            y27Active = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(y1, "Shina:=Bx");
            t.SetToolTip(y0, "Shina:=Ax");
            t.SetToolTip(y2, "A:=Shina");
            t.SetToolTip(y3, "B:=Shina");
            t.SetToolTip(y4, "R:=A");
            t.SetToolTip(y5, "R:=~A");
            t.SetToolTip(y6, "S:=B");
            t.SetToolTip(y7, "S:=~B");
            t.SetToolTip(y8, "Q:=R + S");
            t.SetToolTip(y9, "Q:=R - S");
            t.SetToolTip(y10, "Q:=S - R");
            t.SetToolTip(y11, "Q:=R & S");
            t.SetToolTip(y12, "Q:=R v S");
            t.SetToolTip(y13, "Q:=R (+) S");
            t.SetToolTip(y14, "p0:=0");
            t.SetToolTip(y15, "p0:=1");
            t.SetToolTip(y16, " F:=Q");
            t.SetToolTip(y17, "F:=R1(F)");
            t.SetToolTip(y18, "F:=L1(F)");
            t.SetToolTip(y19, "F:=R1*(F)");
            t.SetToolTip(y20, "F:=L1*(F)");
            t.SetToolTip(y22, "Счетчик=0 ");
            t.SetToolTip(y23, "INC(Счетчик)");
            t.SetToolTip(y24, "C:=F");
            t.SetToolTip(y25, "D:=F");
            t.SetToolTip(y26, "Shina:=C");
            t.SetToolTip(y27, "Shina:=D");
            t.SetToolTip(y28, "DL:=0");
            t.SetToolTip(y29, "DL:=1");
            t.SetToolTip(y30, "DR:=0");
            t.SetToolTip(y31, "SDR:=1");
            t.SetToolTip(y32, "Q:=R");
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void y0_Click(object sender, EventArgs e)
        {
            flags[0] = !flags[0];

            if (y0.BackColor == Color.LightCyan)
            {
                y0.BackColor = Color.Aqua;
            }
            else
            {
                y0.BackColor = Color.LightCyan;
            }

            y0Active = true;
           
        }

        private void y1_Click(object sender, EventArgs e)
        {
            flags[1] = !flags[1];

            if (y1.BackColor == Color.LightCyan)
            {
                y1.BackColor = Color.Aqua;
            }
            else
            {
                y1.BackColor = Color.LightCyan;
            }

            y1Active = true;
        }

        private void y2_Click(object sender, EventArgs e)
        {
            flags[2] = !flags[2];

            if (y2.BackColor == Color.LightCyan)
            {
                y2.BackColor = Color.Aqua;
            }
            else
            {
                y2.BackColor = Color.LightCyan;
            }

            y2Active = true;
            
        }

        private void y3_Click(object sender, EventArgs e)
        {
            flags[3] = !flags[3];

            if (y3.BackColor == Color.LightCyan)
            {
                y3.BackColor = Color.Aqua;
            }
            else
            {
                y3.BackColor = Color.LightCyan;
            }
            y3Active = true;
        }

        private void y4_Click(object sender, EventArgs e)
        {
            flags[4] = !flags[4];

            if (y4.BackColor == Color.LightCyan)
            {
                y4.BackColor = Color.Aqua;
            }
            else
            {
                y4.BackColor = Color.LightCyan;
            }
            y4Active = true;
            
        }

        private void y5_Click(object sender, EventArgs e)
        {
            flags[5] = !flags[5];

            if (y5.BackColor == Color.LightCyan)
            {
                y5.BackColor = Color.Aqua;
            }
            else
            {
                y5.BackColor = Color.LightCyan;
            }
            y5Active = true;

            
        }

        private void y6_Click(object sender, EventArgs e)
        {
            flags[6] = !flags[6];

            if (y6.BackColor == Color.LightCyan)
            {
                y6.BackColor = Color.Aqua;
            }
            else
            {
                y26.BackColor = Color.LightCyan;
            }
            y6Active = true;
            
        }

        private void y7_Click(object sender, EventArgs e)
        {
            flags[7] = !flags[7];

            if (y7.BackColor == Color.LightCyan)
            {
                y7.BackColor = Color.Aqua;
            }
            else
            {
                y7.BackColor = Color.LightCyan;
            }
            y7Active = true;

            
        }

        private void y8_Click(object sender, EventArgs e)
        {
            flags[8] = !flags[8];

            if (y8.BackColor == Color.LightCyan)
            {
                y8.BackColor = Color.Aqua;
            }
            else
            {
                y8.BackColor = Color.LightCyan;
            }
            y8Active = true;

        }

        private void y9_Click(object sender, EventArgs e)
        {
            flags[9] = !flags[9];

            if (y9.BackColor == Color.LightCyan)
            {
                y9.BackColor = Color.Aqua;
            }
            else
            {
                y9.BackColor = Color.LightCyan;
            }
            y9Active = true;

        }

        private void y10_Click(object sender, EventArgs e)
        {
            flags[10] = !flags[10];

            if (y10.BackColor == Color.LightCyan)
            {
                y10.BackColor = Color.Aqua;
            }
            else
            {
                y10.BackColor = Color.LightCyan;
            }
            y10Active = true;
        }

        private void y11_Click(object sender, EventArgs e)
        {
            flags[11] = !flags[11];

            y11Active = true;
        }

        private void y12_Click(object sender, EventArgs e)
        {
            flags[12] = !flags[12];

            if (y12.BackColor == Color.LightCyan)
            {
                y12.BackColor = Color.Aqua;
            }
            else
            {
                y12.BackColor = Color.LightCyan;
            }
            y12Active = true;
        }

        private void y13_Click(object sender, EventArgs e)
        {
            flags[13] = !flags[13];

            if (y13.BackColor == Color.LightCyan)
            {
                y13.BackColor = Color.Aqua;
            }
            else
            {
                y13.BackColor = Color.LightCyan;
            }
            y13Active = true;
        }

        private void y14_Click(object sender, EventArgs e)
        {
            flags[14] = !flags[14];

            if (y14.BackColor == Color.LightCyan)
            {
                y14.BackColor = Color.Aqua;
            }
            else
            {
                y14.BackColor = Color.LightCyan;
            }
            textBox12.Text = "0";
        }

        private void y15_Click(object sender, EventArgs e)
        {
            flags[15] = !flags[15];

            if (y15.BackColor == Color.LightCyan)
            {
                y15.BackColor = Color.Aqua;
            }
            else
            {
                y15.BackColor = Color.LightCyan;
            }
            textBox12.Text = "1";
        }

        private void y19_Click(object sender, EventArgs e)
        {
            flags[19] = !flags[19];

            if (y19.BackColor == Color.LightCyan)
            {
                y19.BackColor = Color.Aqua;
            }
            else
            {
                y19.BackColor = Color.LightCyan;
            }
            y19Active = true;
        }

        private void y20_Click(object sender, EventArgs e)
        {
            flags[20] = !flags[20];

            if (y20.BackColor == Color.LightCyan)
            {
                y20.BackColor = Color.Aqua;
            }
            else
            {
                y20.BackColor = Color.LightCyan;
            }
            
        }

        private void y22_Click(object sender, EventArgs e)
        {
            flags[22] = !flags[22];

            if (y22.BackColor == Color.LightCyan)
            {
                y22.BackColor = Color.Aqua;
            }
            else
            {
                y22.BackColor = Color.LightCyan;
            }
        }

        private void y23_Click(object sender, EventArgs e)
        {
            flags[23] = !flags[23];

            if (y23.BackColor == Color.LightCyan)
            {
                y23.BackColor = Color.Aqua;
            }
            else
            {
                y23.BackColor = Color.LightCyan;
            }
        }

        private void y24_Click(object sender, EventArgs e)
        {
            flags[24] = !flags[24];

            if (y24.BackColor == Color.LightCyan)
            {
                y24.BackColor = Color.Aqua;
            }
            else
            {
                y24.BackColor = Color.LightCyan;
            }
            y24Active = true;
        }

        private void y26_Click(object sender, EventArgs e)
        {
            flags[26] = !flags[26];

            if (y26.BackColor == Color.LightCyan)
            {
                y26.BackColor = Color.Aqua;
            }
            else
            {
                y26.BackColor = Color.LightCyan;
            }
            y26Active = true;
        }

        private void y28_Click(object sender, EventArgs e)
        {
            flags[28] = !flags[28];

            if (y28.BackColor == Color.LightCyan)
            {
                y28.BackColor = Color.Aqua;
            }
            else
            {
                y28.BackColor = Color.LightCyan;
            }
            DRActive = "right";
            DRValue = "0";
        }

        private void y29_Click(object sender, EventArgs e)
        {
            flags[29] = !flags[29];

            if (y29.BackColor == Color.LightCyan)
            {
                y29.BackColor = Color.Aqua;
            }
            else
            {
                y29.BackColor = Color.LightCyan;
            }
            DRActive = "right";
            DRValue = "1";
        }

        private void y30_Click(object sender, EventArgs e)
        {
            flags[30] = !flags[30];

            if (y30.BackColor == Color.LightCyan)
            {
                y30.BackColor = Color.Aqua;
            }
            else
            {
                y30.BackColor = Color.LightCyan;
            }
            DLActive = "left";
            DLValue = "0";
        }

        private void y31_Click(object sender, EventArgs e)
        {
            flags[31] = !flags[31];

            if (y31.BackColor == Color.LightCyan)
            {
                y31.BackColor = Color.Aqua;
            }
            else
            {
                y31.BackColor = Color.LightCyan;
            }
            DLActive = "left";
            DLValue = "1";
        }

        private void y32_Click(object sender, EventArgs e)
        {
            flags[32] = !flags[32];

            if (y32.BackColor == Color.LightCyan)
            {
                y32.BackColor = Color.Aqua;
            }
            else
            {
                y32.BackColor = Color.LightCyan;
            }
            y32Active = true;
        }

        private void step_Click(object sender, EventArgs e)
        {
            do_state();
            if (comboBox1.Text != "")
            {
                //Sequence sequence = new Sequence();
                Biteness currentString = new Biteness();
                currentString.biteness = Convert.ToInt32(comboBox1.Text);
                bool[] steps = new bool[24];
                steps[0] = y0Active;
                steps[1] = y1Active;
                steps[2] = y2Active;
                steps[3] = y3Active;
                steps[4] = y4Active;
                steps[5] = y5Active;
                steps[6] = y6Active;
                steps[7] = y7Active;
                steps[8] = y8Active;
                steps[9] = y9Active;
                steps[10] = y10Active;
                steps[11] = y11Active;
                steps[12] = y12Active;
                steps[13] = y13Active;
                steps[14] = y32Active;
                steps[15] = y16Active;
                steps[16] = y17Active;
                steps[17] = y18Active;
                steps[18] = y19Active;
                steps[19] = y20Active;
                steps[20] = y24Active;
                steps[21] = y25Active;
                steps[22] = y26Active;
                steps[23] = y27Active;
                //sequence.sequenceArr(steps);
                for (int i = 0; i < steps.Length; i++)
                {
                    if(i == 0 && steps[i])
                    {
                        Shina = textBox1.Text;
                        y0Active = false;
                    }
                    if(i == 1 && steps[i])
                    {
                        textBox3.Text = Shina;
                        y1Active = false;
                    }
                    if (i == 2 && steps[i])
                    {
                        
                        Shina = textBox2.Text;
                        y2Active = false;
                    }
                    if (i == 3 && steps[i])
                    { 
                        textBox4.Text = Shina;
                        y3Active = false;
                    }
                    if (i == 4 && steps[i])
                    {
                        R = textBox3.Text;
                        
                        y4Active = false;
                    }
                    if (i == 5 && steps[i])
                    {
                        String A = textBox3.Text;
                        String notA = "";

                        for (int n = 0; n < textBox3.Text.Length; n++)
                        {
                            if (A[n] == '0')
                            {
                                notA += String.Concat("1");
                            }
                            else if (A[n] == '1')
                            {
                                notA += String.Concat("0");
                            }
                        }
                        R = notA;
                        
                        y5Active = false;
                    }
                    if (i == 6 && steps[i])
                    {
                        S = textBox4.Text;
                        
                        y6Active = false;
                    }
                    if (i == 7 && steps[i])
                    {
                        String B = textBox4.Text;
                        String notB = "";
                        for (int n = 0; n < textBox4.Text.Length; n++)
                        {
                            if (B[n] == '0')
                            {
                                notB += String.Concat("1");
                            }
                            else if (B[n] == '1')
                            {
                                notB += String.Concat("0");
                            }
                        }
                        S = notB;
                       
                        y7Active = false;
                    }
                    if (i == 8 && steps[i])
                    {
                        String res = "";
                        String reverseRes = "";
                        int n = 0;
                        for (int p = R.Length - 1; p >= 0; p--)
                        {
                            if (R[p] == '0' && S[p] == '0')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '0' && res[n - 1] == '0' || R[p + 1] == '0' && S[p + 1] == '1' && res[n - 1] == '0')
                                {
                                    res += String.Concat("1");
                                }
                                else res += String.Concat("0");
                            }
                            else if (R[p] == '1' && S[p] == '0')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '0' && res[n - 1] == '0' || R[p + 1] == '0' && S[p + 1] == '1' && res[n - 1] == '0')
                                {
                                    res += String.Concat("0");
                                }
                                else res += String.Concat("1");
                            }
                            else if (R[p] == '0' && S[p] == '1')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '0' && res[n - 1] == '0' || R[p + 1] == '0' && S[p + 1] == '1' && res[n - 1] == '0')
                                {
                                    res += String.Concat("0");
                                }
                                else res += String.Concat("1");
                            }
                            else if (R[p] == '1' && S[p] == '1')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '0' && res[n - 1] == '0' || R[p + 1] == '0' && S[p + 1] == '1' && res[n - 1] == '0')
                                {
                                    res += String.Concat("1");
                                }
                                else res += String.Concat("0");
                            }
                            n++;
                        }

                        for (int p = res.Length - 1; p >= 0; p--)
                        {
                            reverseRes += String.Concat(res[p]);
                        }
                        Q = reverseRes;
                        Console.WriteLine(Q);
                        y8Active = false;
                    }
                    if (i == 9 && steps[i])
                    {
                        String res = "";
                        String reverseRes = "";
                        int n = 0;
                        for (int p = R.Length - 1; p >= 0; p--)
                        {

                            if (R[p] == '0' && S[p] == '0')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else res += String.Concat("0");
                            }
                            else if (R[p] == '1' && S[p] == '0')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else res += String.Concat("1");
                            }
                            else if (R[p] == '1' && S[p] == '1')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else res += String.Concat("0");
                            }
                            else if (R[p] == '0' && S[p] == '1')
                            {
                                if (i == R.Length - 1)
                                {
                                    res += String.Concat("1");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '1' && S[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (R[p + 1] == '0' && S[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else res += String.Concat("1");
                            }
                            n++;
                        }


                        for (int p = res.Length - 1; p >= 0; p--)
                        {
                            reverseRes += String.Concat(res[p]);
                        }
                        Q = reverseRes;
                        Console.WriteLine(Q);
                        y9Active = false;
                    }
                    if (i == 10 && steps[i])
                    {

                        String res = "";
                        String reverseRes = "";
                        int n = 0;
                        for (int p = S.Length - 1; p >= 0; p--)
                        {

                            if (S[p] == '0' && R[p] == '0')
                            {
                                if (p == R.Length - 1)
                                {
                                    res += String.Concat("0");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (S[p + 1] == '1' && R[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else res += String.Concat("0");
                            }
                            else if (S[p] == '1' && R[p] == '0')
                            {
                                if (p == S.Length - 1)
                                {
                                    res += String.Concat("1");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (S[p + 1] == '1' && R[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else res += String.Concat("1");
                            }
                            else if (S[p] == '1' && R[p] == '1')
                            {
                                if (p == S.Length - 1)
                                {
                                    res += String.Concat("0");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (S[p + 1] == '1' && R[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("1");
                                }
                                else res += String.Concat("0");
                            }
                            else if (S[p] == '0' && R[p] == '1')
                            {
                                if (p == S.Length - 1)
                                {
                                    res += String.Concat("1");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (S[p + 1] == '1' && R[p + 1] == '1' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else if (S[p + 1] == '0' && R[p + 1] == '0' && res[n - 1] == '1')
                                {
                                    res += String.Concat("0");
                                }
                                else res += String.Concat("1");
                            }
                            n++;
                        }


                        for (int p = res.Length - 1; p >= 0; p--)
                        {
                            reverseRes += String.Concat(res[p]);
                        }
                        Q = reverseRes;
                       
                        y10Active = false;
                    }
                    if (i == 11 && steps[i])
                    {
                        if (y11.BackColor == Color.LightCyan)
                        {
                            y11.BackColor = Color.Aqua;
                        }
                        else
                        {
                            y11.BackColor = Color.LightCyan;
                        }
                        String res = "";
                        for (int n = 0; n < R.Length; n++)
                        {
                            if (R[n] == '1' && S[n] == '1')
                            {
                                res += String.Concat('1');
                            }
                            else res += String.Concat('0');
                        }
                        Q = res;
                        
                        y11Active = false;
                    }
                    if (i == 12 && steps[i])
                    {
                        String res = "";
                        for (int n = 0; n < R.Length; n++)
                        {
                            if (R[n] == '1' && S[n] == '1' || R[n] == '0' && S[n] == '1' || R[n] == '1' && S[n] == '0')
                            {
                                res += String.Concat('1');
                            }
                            else res += String.Concat('0');
                        }
                        Q = res;
                        
                        y12Active = false;
                    }
                    if (i == 13 && steps[i])
                    {
                        String res = "";
                        for (int n = 0; n < R.Length; n++)
                        {
                            if (R[n] == '1' && S[n] == '1' || R[n] == '0' && S[n] == '1' || R[n] == '1' && S[n] == '0')
                            {
                                res += String.Concat('1');
                            }
                            else res += String.Concat('0');
                        }
                        Q = res;
                        
                        y13Active = false;
                    }
                    if (i == 14 && steps[i])
                    {
                        Q = R;
                        y32Active = false;
                    }
                    if (i == 15 && steps[i])
                    {
                        F = Q;
                        y16Active = false;
                    }
                    if (i == 16 && steps[i])
                    {

                        DRActive = "right";
                        String res = "";
                        DRValue = Q[Q.Length - 1].ToString();
                        if (DLValue == "1")
                        {
                            res += String.Concat('1');
                        }
                        else res += String.Concat('0');

                        for (int n = 0; n < Q.Length - 1; n++)
                        {
                            res += String.Concat(Q[n]);
                        }
                        F = res;
                        y17Active = false;
                    }
                    if (i == 17 && steps[i])
                    {
                        DRActive = "right";
                        String res = "";
                        DRValue = Q[Q.Length - 1].ToString();
                        if (DLValue == "1")
                        {
                            res += String.Concat('1');
                        }
                        else res += String.Concat('0');

                        for (int n = 0; n < Q.Length - 1; n++)
                        {
                            res += String.Concat(Q[n]);
                        }
                        F = res;
                        y18Active = false;
                    }
                    if (i == 18 && steps[i])
                    {
                        DRActive = "right";
                        String res = "";
                        DRValue = Q[Q.Length - 1].ToString();
                        if (DLValue == "1")
                        {
                            res += String.Concat('1');
                        }
                        else res += String.Concat('0');

                        for (int n = 0; n < Q.Length - 1; n++)
                        {
                            res += String.Concat(Q[n]);
                        }
                        F = res;
                        y19Active = false;
                    }
                    if (i == 19 && steps[i])
                    {
                        String res = "";
                        DRSActive = "right";
                        DRSValue = Q[Q.Length - 1].ToString();

                        res += String.Concat(DRValue);


                        for (int n = 0; n < Q.Length - 1; n++)
                        {
                            res += String.Concat(Q[n]);
                        }
                        F = res;
                        y20Active = false;
                    }
                    if (i == 20 && steps[i])
                    {
                        C = F;
                        y24Active = false;
                    }
                    if (i == 21 && steps[i])
                    {
                        D = F;
                        y25Active = false;
                    }
                    if (i == 22 && steps[i])
                    {

                        Shina = C;
                        y26Active = false;
                    }
                    if (i == 23 && steps[i])
                    {
                        Shina = D;
                        y27Active = false;
                    }
                }

                if (DRActive == "right")
                {
                    textBox10.Text = DRValue;
                }
                if (DLActive == "left")
                {
                    textBox11.Text = DLValue;
                }
                textBox5.Text = C;
                textBox6.Text = D;
                }
                if (DRSActive == "right")
                {
                    textBox11.Text = DRSValue;
                }
                NumerulSystemChange changeSystem = new NumerulSystemChange();
                changeSystem.num = textBox5.Text;
                label22.Text = changeSystem.changeToDecimalSystem(changeSystem.num);

                changeSystem.num = textBox6.Text;
                label23.Text = changeSystem.changeToDecimalSystem(changeSystem.num);

        }

        private void drop_Click(object sender, EventArgs e)
        {
            y0Active = false;
            y2Active = false;
            y1Active = false;
            y3Active = false;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            DRValue = "0";
            DLValue = "0";
            DRSValue = "0";
            DLSValue = "0";
            R = "00000000";
            S = "00000000";
            Q = "00000000";
            F = "00000000";
            C = "00000000";
            D = "00000000";
        }


        private void do_state()
        {
            y0.BackColor = Color.LightCyan;
            y1.BackColor = Color.LightCyan;
            y2.BackColor = Color.LightCyan;
            y3.BackColor = Color.LightCyan;
            y4.BackColor = Color.LightCyan;
            y5.BackColor = Color.LightCyan;
            y6.BackColor = Color.LightCyan;
            y7.BackColor = Color.LightCyan;
            y8.BackColor = Color.LightCyan;
            y9.BackColor = Color.LightCyan;
            y10.BackColor = Color.LightCyan;
            y11.BackColor = Color.LightCyan;
            y12.BackColor = Color.LightCyan;
            y13.BackColor = Color.LightCyan;
            y14.BackColor = Color.LightCyan;
            y15.BackColor = Color.LightCyan;
            y16.BackColor = Color.LightCyan;
            y17.BackColor = Color.LightCyan;
            y18.BackColor = Color.LightCyan;
            y19.BackColor = Color.LightCyan;
            y20.BackColor = Color.LightCyan;
            y22.BackColor = Color.LightCyan;
            y23.BackColor = Color.LightCyan;
            y24.BackColor = Color.LightCyan;
            y25.BackColor = Color.LightCyan;
            y26.BackColor = Color.LightCyan;
            y27.BackColor = Color.LightCyan;
            y28.BackColor = Color.LightCyan;
            y29.BackColor = Color.LightCyan;
            y30.BackColor = Color.LightCyan;
            y31.BackColor = Color.LightCyan;
            y32.BackColor = Color.LightCyan;


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            String number = textBox5.Text;
            if (number.Length == 0)
                number = null;
            label22.Text = Convert.ToInt32(number, 2).ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            String number = textBox6.Text;
            if (number.Length == 0)
                number = null;
            label23.Text = Convert.ToInt32(number, 2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumerulSystemChange currentString = new NumerulSystemChange();
            currentString.decNum = Convert.ToInt32(textBox14.Text);
            textBox1.Text = currentString.changeToBinarySystem(currentString.decNum, R.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumerulSystemChange currentString = new NumerulSystemChange();
            currentString.decNum = Convert.ToInt32(textBox15.Text);
            textBox2.Text = currentString.changeToBinarySystem(currentString.decNum, R.Length);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                Biteness currentString = new Biteness();
                currentString.biteness = Convert.ToInt32(comboBox1.Text);
                currentString.changeStr = "";

                textBox1.Text = currentString.changedString(currentString.changeStr, currentString.biteness);
                textBox2.Text = currentString.changedString(currentString.changeStr, currentString.biteness);
                textBox3.Text = currentString.changedString(currentString.changeStr, currentString.biteness);
                textBox4.Text = currentString.changedString(currentString.changeStr, currentString.biteness);
                textBox5.Text = currentString.changedString(currentString.changeStr, currentString.biteness);
                textBox6.Text = currentString.changedString(currentString.changeStr, currentString.biteness);

                R = currentString.changedString(currentString.changeStr, currentString.biteness);
                S = currentString.changedString(currentString.changeStr, currentString.biteness);
                Q = currentString.changedString(currentString.changeStr, currentString.biteness);
                F = currentString.changedString(currentString.changeStr, currentString.biteness);
                C = currentString.changedString(currentString.changeStr, currentString.biteness);
                D = currentString.changedString(currentString.changeStr, currentString.biteness);
            }
        }

        
    }
}
