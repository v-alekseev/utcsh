using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        Utils utils = new Utils();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = utils.CalculateProgress(progressBar1.Value); 
            label1.Text = "Progress bar value = " + progressBar1.Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch(progressBar1.Style)
            {
                case ProgressBarStyle.Blocks:
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    break;
                case ProgressBarStyle.Continuous:
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    break; 
                case ProgressBarStyle.Marquee:
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    break;

            }
            label1.Text = "Progress bar style = " + progressBar1.Style.ToString() + " code " + (int)progressBar1.Style;

           
        }



    }
}
