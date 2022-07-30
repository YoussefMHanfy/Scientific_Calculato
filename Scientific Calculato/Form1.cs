using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculato
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 293;
            this.Height = 430;
            text_result.Width = 256;
        }
        //file list
        private void standerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 430;
            this.Width = 293;
            text_result.Width = 256;
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 575;
            this.Height = 430;
            text_result.Width = 537;
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;


        }



        private void tempertureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 475;
            this.Height = 430;
            
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox1.Location = new Point(0, 27);
        }
        private void multiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 385;
            this.Height = 410;
            text_result.Width = 537;
            
            groupBox4.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point(0, 27);

        }
        //area
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 310;
            this.Width = 425;
            groupBox4.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = true;
            groupBox5.Location = new Point(0, 27);




        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //end list
        

        //stander calculator

        double results = 0;
        string opperation = "";
        
        private void button_click(object sender, EventArgs e)
        {
            if (text_result.Text == "0")
                text_result.Text = "";
 
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!text_result.Text.Contains("."))
                    text_result.Text = text_result.Text + num.Text;

            }
            else
                text_result.Text = text_result.Text + num.Text; 
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            text_result.Text = "0";
                label1.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (text_result.Text.Length > 0)
            {
                text_result.Text = text_result.Text.Remove(text_result.Text.Length - 1, 1);
            }

            if (text_result.Text == "")
            {
                text_result.Text = "0";
            }
        }

       

        private void Arithmetic_operator(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            opperation = op.Text;
            results = Double.Parse(text_result.Text);
            label1.Text = text_result.Text + " " + opperation;
            text_result.Text = "";
            


        }

        private void button_equl_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                switch (opperation)
                {
                    case "+":
                        text_result.Text = (results + double.Parse(text_result.Text)).ToString();
                        break;
                    case "-":
                        text_result.Text = (results - double.Parse(text_result.Text)).ToString();
                        break;
                    case "*":
                        text_result.Text = (results * double.Parse(text_result.Text)).ToString();
                        break;
                    case "/":
                        text_result.Text = (results / double.Parse(text_result.Text)).ToString();
                        break;
                    case "Mod":
                        text_result.Text = (results % double.Parse(text_result.Text)).ToString();
                        break;
                    case "Exp":
                        double i = double.Parse(text_result.Text);
                        double q = (results);
                        for (int t = 0; t < i; t++)
                        {
                            q = q * 10;
                        }
                        text_result.Text = q.ToString();
                        break;

                    case "X^n":

                        text_result.Text = (pow(results, double.Parse(text_result.Text))).ToString();
                        break;
                    case "%":
                        double a;
                        a = results / double.Parse(text_result.Text) * (100);
                        text_result.Text = (a + "%").ToString();
                        break;


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //recursion
        static double pow(double a,double b)
        {
            if (b == 0)
                return 1;

            else
                return a * pow(a, b - 1);
        }
        //end
        //Scientific calculator
        private void button30_Click(object sender, EventArgs e)
        {
            text_result.Text = "3.1415926535879976323";

        }

        private void button29_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(text_result.Text);
            label1.Text = ("log" + "(" + (text_result.Text) + ")") ;
            ilog = Math.Log10(ilog);
            text_result.Text =(ilog).ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(text_result.Text);
            label1.Text = ("sqrt" + "(" + (text_result.Text) + ")");
            sq = Math.Sqrt(sq);
            text_result.Text = (sq) .ToString();
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qSinh = double.Parse(text_result.Text);
            label1.Text = ("sinh" + "(" + (text_result.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            text_result.Text =(qSinh) .ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double qSin = double.Parse(text_result.Text);
            label1.Text = ("sin" + "(" + (text_result.Text) + ")");
            qSin = qSin / 180.0 * (Math.PI);
            qSin = Math.Sin(qSin);
            text_result.Text = (qSin).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int a = int.Parse(text_result.Text);
            text_result.Text = (a).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qcosh = double.Parse(text_result.Text);
            label1.Text = ("cosh" + "(" + (text_result.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            text_result.Text =(qcosh).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double qcos = double.Parse(text_result.Text);
            label1.Text = ("cos" + "(" + (text_result.Text) + ")") .ToString();
            qcos = qcos / 180.0 * (Math.PI);
            qcos = Math.Cos(qcos);
            text_result.Text = (qcos) .ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double qtanh = double.Parse(text_result.Text);
            label1.Text = ("tanh" + "(" + (text_result.Text) + ")");
            qtanh = Math.Tanh(qtanh);
            text_result.Text = (qtanh).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double qtan = double.Parse(text_result.Text);
            label1.Text = ("tan" + "(" + (text_result.Text) + ")");
            qtan = qtan / 180.0 * (Math.PI);
            qtan = Math.Tan(qtan);
            text_result.Text = (qtan).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(text_result.Text);
            text_result.Text = System.Convert.ToString(a, 2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int a = int.Parse(text_result.Text);
            text_result.Text = System.Convert.ToString(a,16);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = int.Parse(text_result.Text);
            text_result.Text = System.Convert.ToString(a, 8);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(text_result.Text) * double.Parse(text_result.Text);
            text_result.Text = (a).ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            double a;
            a = 1.0 /( double.Parse(text_result.Text));
            text_result.Text =(a).ToString();
        }
        private void text_result_TextChanged(object sender, EventArgs e)
        {

        }
        private void button15_Click(object sender, EventArgs e)
        {
            double iln = double.Parse(text_result.Text);
            label1.Text = ("ln" + "(" + (text_result.Text) + ")");
            iln = Math.Log(iln);
            text_result.Text =(iln).ToString();
           
        }
        

        //end

        private void txtcovert_TextChanged(object sender, EventArgs e)
        {

        }
        //Temperature
        float icelsius, ifahrenheit, ikevin;
        char ioperation;
        private void button32_Click_1(object sender, EventArgs e)
        {
            txtconvert.Clear();
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            ioperation = 'C';
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            ioperation = 'F';
        }
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            ioperation = 'K';
        }
        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                switch (ioperation)
                {
                    case 'C':
                        icelsius = float.Parse(textBox1.Text);
                        txtconvert.Text = ((((9 * icelsius) / 5) + 32).ToString());
                        break;


                    case 'F':
                        ifahrenheit = float.Parse(textBox1.Text);
                        txtconvert.Text = ((((ifahrenheit - 32) * 5) / 9).ToString());
                        break;

                    case 'K':
                        ikevin = float.Parse(textBox1.Text);
                        txtconvert.Text = ((((9 - ikevin) / 5) + 32).ToString());
                        break;
                }
                label9.Text = "";
            }
            catch(Exception ex)

            {
                label9.Text= "Enter the Value";
            }
        }

        //end  

        //multiply

        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                int a;
                a = int.Parse((textBox3.Text));
                for (int i = 1; i < 13; i++)
                {
                    LbMltiply.Items.Add(i + " X " + a + " = " + a * i);
                }
                label8.Text = "";
            }
            catch (Exception ex)
            {
                label8.Text = "Enter The Number";
            }
        }
        private void button34_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            LbMltiply.Items.Clear();
        }
        //end

        //areas
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                circle c = new circle(double.Parse(txtRadius.Text));
                txtarea.Text = c.action().ToString();
                label7.Text = "";
            }
            catch ( Exception ex)
            {
                label7.Text = "Enter the value of Radius";
            }

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button37_Click(object sender, EventArgs e)
        {
            txtarea.Text = "";
            txthigh.Text = "";
            txtRadius.Text = "";
            
        }
        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                Sphare s = new Sphare(double.Parse(txtRadius.Text));
                txtarea.Text = s.action().ToString();
                label7.Text = "";
            }
            catch (Exception ex)
            {
                label7.Text = "Enter the value of Radius";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                cylinder cy = new cylinder(double.Parse(txtRadius.Text), double.Parse(txthigh.Text));
                txtarea.Text = cy.action().ToString();
                label7.Text = "";
            }
            catch (Exception ex)
            { 

                label7.Text = "Enter the value of High and Radius";
            }
        }
        //end

    }
}
