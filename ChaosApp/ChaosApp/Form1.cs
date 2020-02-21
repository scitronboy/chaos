using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChaosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void graphSingleRbtn_Click(object sender, EventArgs e)
        {
            Chaos chaos = new Chaos(this, Convert.ToDouble(this.RInput.Text));
            chaos.graphSingleR();
        }

        public class Chaos
        {

            Form1 form;
            double R;

            public Chaos(Form1 form, double R)// CON
            {
                this.form = form;
                this.R = R;
            }

            public void graphSingleR()
            {
                form.statusText.Text = "graphing R value " + this.R.ToString();
            }

        }// public class Chaos

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.statusText.Text = "ready";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}