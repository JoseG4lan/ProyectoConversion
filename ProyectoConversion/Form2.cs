using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoConversion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int n=1;

        private void conversionesTermomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void celsiusFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 1;
            label1.Text = "Ingresa temperatura en Celsius";
            label2.Text = "Su conversión a Fahrenheit es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void fahrenheitCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 2;
            label1.Text = "Ingresa temperatura en Fahrenheit";
            label2.Text = "Su conversión a Celsius es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void celsiusKelvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 3;
            label1.Text = "Ingresa temperatura en Celsius";
            label2.Text = "Su conversión a Kelvin es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void kelvinCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 4;
            label1.Text = "Ingresa temperatura en Kelvin";
            label2.Text = "Su conversión a Celsius es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void fahrenheitKelvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 5;
            label1.Text = "Ingresa temperatura en Fahrenheit";
            label2.Text = "Su conversión a Kelvin es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void kelvinFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 6;
            label1.Text = "Ingresa temperatura en Kelvin";
            label2.Text = "Su conversión a Fahrenheit es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void rankieCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 7;
            label1.Text = "Ingresa temperatura en Rankie";
            label2.Text = "Su conversión a Celsius es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void celsiusRankieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 8;
            label1.Text = "Ingresa temperatura en Celsius";
            label2.Text = "Su conversión a Rankiees:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void rankieFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 9;
            label1.Text = "Ingresa temperatura en Rankie";
            label2.Text = "Su conversión a Fahrenheit es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void fahrenheitRankieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 10;
            label1.Text = "Ingresa temperatura en Fahrenheit";
            label2.Text = "Su conversión a Rankie es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void kelvinRankieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 11;
            label1.Text = "Ingresa temperatura en Kelvin";
            label2.Text = "Su conversión a Rankie es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void rankieKelvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 12;
            label1.Text = "Ingresa temperatura en Rankie";
            label2.Text = "Su conversión a Kelvin es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void réamurCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 13;
            label1.Text = "Ingresa temperatura en Réamur";
            label2.Text = "Su conversión a Celsius es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void celsiusRéamurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 14;
            label1.Text = "Ingresa temperatura en Celsius";
            label2.Text = "Su conversión a Réamur es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void romerCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 15;
            label1.Text = "Ingresa temperatura en Romer";
            label2.Text = "Su conversión a Celsius es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void celsiusRomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 16;
            label1.Text = "Ingresa temperatura en Celsius";
            label2.Text = "Su conversión a Romer es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void newtonCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 17;
            label1.Text = "Ingresa temperatura en Newton";
            label2.Text = "Su conversión a Celsius es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void celsiusNewtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 18;
            label1.Text = "Ingresa temperatura en Celsius";
            label2.Text = "Su conversión a Newton es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void newtonKelvinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 19;
            label1.Text = "Ingresa temperatura en Newton";
            label2.Text = "Su conversión a Kelvin es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void kelvinNewtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = 20;
            label1.Text = "Ingresa temperatura en Kelvin";
            label2.Text = "Su conversión a Newton es:";
            label3.Text = "";
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n==1)
            {
                double c = double.Parse(textBox1.Text);
                label3.Text = ((c * 9 / 5) + 32).ToString("F2");
            }
            else if (n==2)
            {
                double f = Double.Parse(textBox1.Text);
                label3.Text = ((f  - 32) * 5 / 9).ToString("F2");
            }
            else if (n == 3)
            {
                double c = Double.Parse(textBox1.Text);
                label3.Text = (c + 273.15).ToString("F2");
            }
            else if (n == 4)
            {
                double k = Double.Parse(textBox1.Text);
                label3.Text = (k - 273.15).ToString("F2");
            }
            else if (n == 5)
            {
                double f = Double.Parse(textBox1.Text);
                label3.Text = ((f - 32) * 5 / 9 + 273.15).ToString("F2");
            }
            else if (n == 6)
            {
                double k = Double.Parse(textBox1.Text);
                label3.Text = ((k - 273.15) * 9 / 5 + 32).ToString("F2");
            }
            else if (n == 7)
            {
                double r = Double.Parse(textBox1.Text);
                label3.Text = ((r - 491.67) * 5 / 9).ToString("F2");
            }
            else if (n == 8)
            {
                double c = Double.Parse(textBox1.Text);
                label3.Text = ((c * 9 / 5) + 491.67).ToString("F2");
            }
            else if (n == 9)
            {
                double r = Double.Parse(textBox1.Text);
                label3.Text = (r - 459.67).ToString("F2");
            }
            else if (n == 10)
            {
                double f = Double.Parse(textBox1.Text);
                label3.Text = (f + 459.67).ToString("F2");
            }
            else if (n == 11)
            {
                double r = Double.Parse(textBox1.Text);
                label3.Text = (r * 5 / 9).ToString("F2");
            }
            else if (n == 12)
            {
                double k = Double.Parse(textBox1.Text);
                label3.Text = (k * 9 / 5).ToString("F2");
            }
            else if (n == 13)
            {
                double re = Double.Parse(textBox1.Text);
                label3.Text = (re * 5 / 4).ToString("F2");
            }
            else if (n == 14)
            {
                double c = Double.Parse(textBox1.Text);
                label3.Text = (c * 4 / 5).ToString("F2");
            }
            else if (n == 15)
            {
                double ro = Double.Parse(textBox1.Text);
                label3.Text = ((ro - 7.5) * 40 / 21).ToString("F2");
            }
            else if (n == 16)
            {
                double c = Double.Parse(textBox1.Text);
                label3.Text = ((c * 21 / 40) + 7.5).ToString("F2");
            }
            else if (n == 17)
            {
                double n = Double.Parse(textBox1.Text);
                label3.Text = (n * 100 / 33).ToString("F2");
            }
            else if (n == 18)
            {
                double c = Double.Parse(textBox1.Text);
                label3.Text = (c * 33 / 100).ToString("F2");
            }
            else if (n == 19)
            {
                double n = Double.Parse(textBox1.Text);
                label3.Text = ((n * 100 / 33) + 273.16).ToString("F2");
            }
            else if (n == 20)
            {
                double k = Double.Parse(textBox1.Text);
                label3.Text = ((k - 273.26) * 33 / 100).ToString("F2");
            }
        }
    }
}
