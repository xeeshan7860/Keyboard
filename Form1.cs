using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoard
{
    public partial class Form1 : Form
    {
        int a=0;
        int c=0,s=0,n=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Caps Lock";
            this.label3.Text = "Num Lock";
            this.label4.Text = "Scroll Lock";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.button1.Text = "ESC";
            this.button2.Text = "F1";
            this.button3.Text = "F2";
            this.button4.Text = "F3";
            this.button5.Text = "F4";
            this.button6.Text = "F5";
            this.button7.Text = "F6";
            this.button8.Text = "F7";
            this.button9.Text = "F8";
            this.button10.Text = "F9";
            this.button11.Text = "F10";
            this.button12.Text = "F11";
            this.button13.Text = "F12";
            this.button14.Text = "Num Lock";
            this.button17.Text = "`"+Environment.NewLine+"`";
            this.button18.Text = "1" + Environment.NewLine + "!";
            this.button19.Text = "2" + Environment.NewLine + "@";
            this.button20.Text = "3" + Environment.NewLine + "#";
            this.button21.Text = "4" + Environment.NewLine + "$";
            this.button22.Text = "5" + Environment.NewLine + "%";
            this.button23.Text = "6" + Environment.NewLine + "^";
            this.button24.Text = "7" + Environment.NewLine + "&&";
            this.button25.Text = "8" + Environment.NewLine + "*";
            this.button26.Text = "9" + Environment.NewLine + "(";
            this.button27.Text = "0" + Environment.NewLine + ")";
            this.button28.Text = "-" + Environment.NewLine + "_";
            this.button29.Text = "+" + Environment.NewLine + "=";
            this.button31.Text = "BackSpace";
        }

        

        private void button14_Click(object sender, EventArgs e)
        {
            if (n == 1) 
            {
                this.button108.BackColor = Color.White;
                n = 0;
            }
            else if(n==0)
            {
                n = 1;
                this.button108.BackColor = Color.Red;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (s == 1) 
            {
                this.button109.BackColor = Color.White;
                s = 0;
            }
            else if(s==0)
            {
                s = 1;
                this.button109.BackColor = Color.Red;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "~";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "~";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "`";
            }

            else
            {
                this.textBox1.Text += "`";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "!";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "!";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "1";
            }

            else
            {
                this.textBox1.Text += "1";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "@";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "@";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "2";
            }

            else
            {
                this.textBox1.Text += "2";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "#";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "#";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "3";
            }

            else
            {
                this.textBox1.Text += "3";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "$";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "$";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "4";
            }

            else
            {
                this.textBox1.Text += "4";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "%";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "%";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "5";
            }

            else
            {
                this.textBox1.Text += "5";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "^";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "^";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "6";
            }

            else
            {
                this.textBox1.Text += "6";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "&";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "&";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "7";
            }

            else
            {
                this.textBox1.Text += "7";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "*";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "*";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "8";
            }

            else
            {
                this.textBox1.Text += "8";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "(";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "(";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "9";
            }

            else
            {
                this.textBox1.Text += "9";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += ")";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += ")";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "0";
            }

            else
            {
                this.textBox1.Text += "0";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "_";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "_";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "-";
            }

            else
            {
                this.textBox1.Text += "-";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "+";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "+";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "=";
            }

            else
            {
                this.textBox1.Text += "=";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "?";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "?";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "/";
            }

            else
            {
                this.textBox1.Text += "/";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int len;
            len = str.Length;
            textBox1.Text = "";
            for (int i = 0; i < len - 1; i++)
            {
                textBox1.Text = textBox1.Text + Convert.ToString(str[i]);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "\t";

        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "Q";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "Q";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "q";
            }
            
            else
            {
                this.textBox1.Text += "q";
            }
        }
        private void button34_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "W";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "W";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "w";
            }

            else
            {
                this.textBox1.Text += "w";
            }
        }
        
        private void button35_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "E";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "E";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "e";
            }

            else
            {
                this.textBox1.Text += "e";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "R";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "R";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "r";
            }

            else
            {
                this.textBox1.Text += "r";
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "T";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "T";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "t";
            }

            else
            {
                this.textBox1.Text += "t";
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "Y";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "Y";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "y";
            }

            else
            {
                this.textBox1.Text += "y";
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "U";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "U";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "u";
            }

            else
            {
                this.textBox1.Text += "u";
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "I";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "I";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "i";
            }

            else
            {
                this.textBox1.Text += "i";
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "O";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "O";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "o";
            }

            else
            {
                this.textBox1.Text += "o";
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "P";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "P";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "p";
            }

            else
            {
                this.textBox1.Text += "p";
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "{";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "{";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "[";
            }

            else
            {
                this.textBox1.Text += "[";
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "}";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "}";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "]";
            }

            else
            {
                this.textBox1.Text += "]";
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {

                this.textBox1.Text += "|";
                a = 0;
            }
            else
            {
                this.textBox1.Text += @"\";
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (c == 1) 
            {
                this.button107.BackColor = Color.White;
                c = 0;
            }
            else if(c==0)
            {
                c = 1;
                this.button107.BackColor = Color.Red;
            }
            
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "A";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "A";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "a";
            }

            else
            {
                this.textBox1.Text += "a";
            }
        }
        private void button48_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "S";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "S";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "s";
            }

            else
            {
                this.textBox1.Text += "s";
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "D";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "D";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "d";
            }

            else
            {
                this.textBox1.Text += "d";
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "F";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "F";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "f";
            }

            else
            {
                this.textBox1.Text += "f";
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "G";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "G";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "g";
            }

            else
            {
                this.textBox1.Text += "g";
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "H";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "H";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "h";
            }

            else
            {
                this.textBox1.Text += "h";
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "J";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "J";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "j";
            }

            else
            {
                this.textBox1.Text += "j";
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "K";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "K";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "k";
            }

            else
            {
                this.textBox1.Text += "k";
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "L";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "L";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "l";
            }

            else
            {
                this.textBox1.Text += "l";
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += ":";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += ":";
            }
            else if (a != 1)
            {
                this.textBox1.Text += ";";
            }

            else
            {
                this.textBox1.Text += ";";
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "\"";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "\"";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "'";
            }

            else
            {
                this.textBox1.Text += "'";
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            this.textBox1.Text+=Environment.NewLine;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "Z";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "Z";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "z";
            }

            else
            {
                this.textBox1.Text += "z";
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "X";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "X";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "x";
            }

            else
            {
                this.textBox1.Text += "x";
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "C";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "C";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "c";
            }

            else
            {
                this.textBox1.Text += "c";
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "V";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "V";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "v";
            }

            else
            {
                this.textBox1.Text += "v";
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "B";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "B";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "b";
            }

            else
            {
                this.textBox1.Text += "b";
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "N";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "N";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "n";
            }

            else
            {
                this.textBox1.Text += "n";
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "M";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "M";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "m";
            }

            else
            {
                this.textBox1.Text += "m";
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "<";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "<";
            }
            else if (a != 1)
            {
                this.textBox1.Text += ",";
            }

            else
            {
                this.textBox1.Text += "q,";
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += ">";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += ">";
            }
            else if (a != 1)
            {
                this.textBox1.Text += ".";
            }

            else
            {
                this.textBox1.Text += ".";
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {

                this.textBox1.Text += "?";
                a = 0;
            }
            else
            {
                this.textBox1.Text += "/";
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            a = 1;
        }

        private void button71_Click(object sender, EventArgs e)
        {

        }

        private void button72_Click(object sender, EventArgs e)
        {

        }

        private void button73_Click(object sender, EventArgs e)
        {

        }

        private void button74_Click(object sender, EventArgs e)
        {

        }

        private void button75_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += " ";
        }

        private void button76_Click(object sender, EventArgs e)
        {

        }

        private void button77_Click(object sender, EventArgs e)
        {

        }

        private void button78_Click(object sender, EventArgs e)
        {

        }

        private void button79_Click(object sender, EventArgs e)
        {

        }

        private void button80_Click(object sender, EventArgs e)
        {

        }

        private void button81_Click(object sender, EventArgs e)
        {

        }

        private void button82_Click(object sender, EventArgs e)
        {

        }

        private void button83_Click(object sender, EventArgs e)
        {
            
        }

        private void button84_Click(object sender, EventArgs e)
        {

        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "Q";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "Q";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "q";
            }

            else
            {
                this.textBox1.Text += "q";
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.textBox1.Text;
            this.label5.Text = "/";
            this.textBox1.Text = "";
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "/";
            }

            else
            {
                this.textBox1.Text += "/";
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.textBox1.Text;
            this.label5.Text = "*";
            this.textBox1.Text = "";
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "*";
            }

            else
            {
                this.textBox1.Text += "*";
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.textBox1.Text;
            this.label5.Text = "-";
            this.textBox1.Text = "";
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "-";
            }

            else
            {
                this.textBox1.Text += "-";
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.textBox1.Text;
            this.label5.Text = "+";
            this.textBox1.Text = "";
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "+";
            }

            else
            {
                this.textBox1.Text += "+";
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "7";
            }

            else
            {
                this.textBox1.Text += "7";
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "8";
            }

            else
            {
                this.textBox1.Text += "8";
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "9";
            }

            else
            {
                this.textBox1.Text += "9";
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "4";
            }

            else
            {
                this.textBox1.Text += "4";
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "5";
            }

            else
            {
                this.textBox1.Text += "5";
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "6";
            }

            else
            {
                this.textBox1.Text += "6";
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            int A, B, C;
            String OP;
            A = int.Parse(textBox1.Text);
            B = int.Parse(label2.Text);
            OP = this.label5.Text;
            if (OP == "+")
            {
                C = A + B;
                textBox1.Text =C.ToString();
            }
            else if (OP == "*")
            {
                C = A * B;
                textBox1.Text =C.ToString();
            }
            else if (OP == "-")
            {
                C = A - B;
                textBox1.Text =C.ToString();
            }
            else if (OP == "/")
            {
                C = A / B;
                textBox1.Text =C.ToString();
            }
            else if (OP == "%")
            {
                C = A % B;
                textBox1.Text =" "+C.ToString();
            }
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "=";
            }

            else
            {
                this.textBox1.Text += "=";
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "1";
            }

            else
            {
                this.textBox1.Text += "1";
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "2";
            }

            else
            {
                this.textBox1.Text += "2";
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "3";
            }

            else
            {
                this.textBox1.Text += "3";
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text += "";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += "0";
            }

            else
            {
                this.textBox1.Text += "0";
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                this.textBox1.Text +="";
                a = 0;
            }
            else if (c == 1)
            {
                this.textBox1.Text += "";
            }
            else if (a != 1)
            {
                this.textBox1.Text += ".";
            }

            else
            {
                this.textBox1.Text += ".";
            }
        }

        private void button102_Click(object sender, EventArgs e)
        {

        }

        private void button103_Click(object sender, EventArgs e)
        {

        }

        private void button104_Click(object sender, EventArgs e)
        {

        }

        private void button105_Click(object sender, EventArgs e)
        {

        }

        private void button106_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f1");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f6");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f10");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f11");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You pressed f12");
        }

        private void button103_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
 
        }

        private void button105_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button103_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }
        }


    }

}
