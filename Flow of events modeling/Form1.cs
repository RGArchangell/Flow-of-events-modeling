using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_of_events_modeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random();

        private double lambda1 = 0;
        private double lambda2 = 0;

        private double N = 10;
        private double T = 10;

        private double t1 = 0;
        private double t2 = 0;

        private double tau1 = 0;
        private double tau2 = 0;

        private List<double> flow = new List<double>();

        private void startButton_Click(object sender, EventArgs e)
        {
            lambda1 = (double) lambda1UpDown.Value;
            lambda2 = (double) lambda2UpDown.Value;

            if (timer.Enabled)
            {
                timer.Stop();
                startButton.Text = "Start";
            }
            else
            {
                timer.Start();
                startButton.Text = "Pause";
            }
        }

        private void modelButton_Click(object sender, EventArgs e)
        {
            N = (double) nUpDown.Value;
            T = (double) tUpDown.Value;

            List<double> truef = new List<double>();

            for (int i = 0; i < flow.Count; i++)
            {
                double x = random.NextDouble() * (flow.Max() - T/2);
                truef.Add(countInRange(flow, flow.Count, x - T / 2, x + T / 2));
                truef[i] /= N;
            }

            List<double> theor = new List<double>();
            double slambda = lambda1 + lambda2;

            for (int i = 0; i < flow.Count; i++)
            {
                double f = factorial(i);
                theor.Add((Math.Pow(slambda * T, i) / f) * Math.Exp(-1 * slambda * T));
                theor[i] /= N;
            }

            double sum = 0;
            for (int i = 0; i < flow.Count; i++)
            {
                sum += (theor[i] - truef[i]);
            }

            double MAE = sum / N;
            errorLabel.Text = "Error: " + MAE;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tau1 <= 0)
            {
                double t_new = t1 + (-1 * (Math.Log(random.NextDouble()) / lambda1));
                tau1 = t_new - t1;
                t1 += tau1;
                flow.Add(t1);
                flow1Text.Text += "BRUH! \n";
            }
            else
                tau1 -= 1;

            if (tau2 <= 0)
            {
                double t_new = t2 + (-1 * (Math.Log(random.NextDouble()) / lambda2));
                tau2 = t_new - t2;
                t2 += tau2;
                flow.Add(t2);
                flow2Text.Text += "BRUH! \n";
            }
            else
                tau2 -= 1;
        }

        private int countInRange(List<double> l, int n, double x, double y)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (l[i] >= x && l[i] <= y)
                    count++;
            }
            return count;
        }

        private double factorial(double x)
        {
            double f = 1;
            for (int i = 2; i <= x; i++)
            {
                f *= i;
            }

            return f;
        }
    }
}
