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
        double Num1, Num2, Num3, Num4;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void suma_Click(object sender, EventArgs e)
        {
            double Suma;
            Num1 = Convert.ToDouble(TB1.Text);
            Num2 = Convert.ToDouble(TB2.Text);
            Num3 = Convert.ToDouble(TB3.Text);
            Num4 = Convert.ToDouble(TB4.Text);
            Suma = Num1 * Num3 + Num2 * Num4;
            MessageBox.Show("Las necesidades totales de combustible son de " +Suma +" litros");
        }
    }
}
