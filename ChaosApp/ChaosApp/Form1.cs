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

        private void button1_Click(object sender, EventArgs e)
        {
            Chaos.run();
        }

        private class Chaos
        {
            private double R;
            private int itLimit = 1000;

            private Chaos()// CON
            {

            }

            public void run() 
            { 
            
            }

        }// public class Chaos

        private private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}