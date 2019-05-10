using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HOLLYBIBLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        	try {
        	
        	
            timer1.Interval = 500;
            timer1.Start();
        	}
        	catch {}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        	try{
            if (toolStripProgressBar1.Value == 100)
            {


                Form4 fO = new Form4();
                fO.Show();
                timer2.Stop();
                timer2.Enabled = false;
                this.Hide();

            }
            else
            {
                toolStripProgressBar1.Increment(1);
            }
        	}	catch {}
        }

        
        void ToolStripStatusLabel1Click(object sender, EventArgs e)
        {
        	
        }
    }
}
