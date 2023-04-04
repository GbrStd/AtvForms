using System;
using System.Windows.Forms;

namespace ProjFormsAula03_04_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            float c = float.Parse(txtC.Text);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / 2.0 * a;
            double x2 = (-b - Math.Sqrt(delta)) / 2.0 * a;

            lblDelta.Text = "DELTA = " + delta;
            lblX1.Text = "X1 = " + x1;
            lblX2.Text = "X2 = " + x2;
        }

    }
}
