using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apka2
{
    public partial class Okno1 : Form
    {
        public Okno1()
        {
            InitializeComponent();
        }
        bool singen = false; //test
        bool cosgen = false;
        double dx=0.01, xmin= -6.2, xmax= 6.2;
        double FresnelCOS(double x)
        {
            double x2 = x * x;
            double x3 = x * x2;
            double x4 = -x2 * x2;
            double xn = 1.0;
            double Sn = 1.0;
            double Sm1 = 0.0;
            double term;
            double factorial = 1.0;
            int y = 0;

            if (x == 0.0) return 0.0;

            while (System.Math.Abs(Sn - Sm1) > Double.Epsilon * System.Math.Abs(Sm1))
            {
                Sm1 = Sn;
                y += 1;
                factorial *= (double)(y + y);
                factorial *= (double)(y + y - 1);
                xn *= x4;
                term = xn / factorial;
                term /= (double)(y + y + y + y + 1);
                Sn += term;
            }
            return x * Sn;
        }

        double FresnelSIN(double x)
        {
            double x2 = x * x;
            double x3 = x * x2;
            double x4 = -x2 * x2;
            double xn = 1.0;
            double Sn = 1.0;
            double Sm1 = 0.0;
            double term;
            double factorial = 1.0;

            int y = 0;

            if (x == 0.0) return 0.0;

            Sn /= 3.0;
            while (System.Math.Abs(Sn - Sm1) > Double.Epsilon * System.Math.Abs(Sm1))
            {
                Sm1 = Sn;
                y += 1;
                factorial *= (double)(y + y);
                factorial *= (double)(y + y + 1);
                xn *= x4;
                term = xn / factorial;
                term /= (double)(y + y + y + y + 3);
                Sn += term;
            }
            return x3 * Sn;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void bGenerujSinus_Click(object sender, EventArgs e)
        {
            string str;
            updatex();
            if (!singen)
            {
                richTextBox1.Text = "";
                for (double xx = xmin; xx < xmax; xx += dx)
                {
                    chart1.Series[0].Points.AddXY(xx, FresnelSIN(xx));
                    str = System.Convert.ToString(xx) + " " + System.Convert.ToString(FresnelSIN(xx)) + "\n";
                    richTextBox1.Text += str;
                }
                MessageBox.Show("Sinus zostal wygenerowany.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                singen = true;
                bSave.Text = "Zapisz wygenerowaną serię (sinus)";
            }
            else
            {
                MessageBox.Show("Sinus zostal juz wygenerowany wcześniej.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bGenerujCosinus_Click(object sender, EventArgs e)
        {
            string str;
            updatex();
            if (!cosgen)
            {
                richTextBox1.Text = "";
                for (double xx = xmin;  xx <  xmax; xx += dx)
                {
                    chart1.Series[1].Points.AddXY(xx, FresnelCOS(xx));
                    str = System.Convert.ToString(xx) + " " + System.Convert.ToString(FresnelCOS(xx)) + "\n";
                    richTextBox1.Text += str;
                }
                MessageBox.Show("Cosinus zostal wygenerowany.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cosgen = true;
                bSave.Text = "Zapisz wygenerowaną serię (cosinus)";
            }
            else
            {
                MessageBox.Show("Cosinus zostal juz wygenerowany wcześniej.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void updatex()
        {
            xmin = System.Convert.ToDouble(tXmin.Text.Replace(',', '.'));
            xmax = System.Convert.ToDouble(tXmax.Text.Replace(',', '.'));
            dx = System.Convert.ToDouble(tDx.Text.Replace(',', '.'));
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            richTextBox1.Text = "";
            singen = false;
            cosgen = false;
        }

        private void tXmax_TextChanged(object sender, EventArgs e)
        {

        }

        private void tXmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tDx_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
