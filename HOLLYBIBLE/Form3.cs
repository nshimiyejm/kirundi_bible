using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace HOLLYBIBLE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string Path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).ToString()).ToString()).ToString();
    
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/bibiliya.rtf");
            richTextBox1.Rtf = myText;  
        	}	catch {}
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Ubutatu.rtf");
            richTextBox1.Rtf = myText;}	
        	catch {}
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Umuntu.rtf");
            richTextBox1.Rtf = myText;
        	}
        	catch {}
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Kristo n-ico yakoze.rtf");
            richTextBox1.Rtf = myText;}
        		catch {}
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Ubuntu.rtf");
            richTextBox1.Rtf = myText;}
        		catch {}
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Imana.rtf");
            richTextBox1.Rtf = myText;}	catch {}
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Ishengero.rtf");
            richTextBox1.Rtf = myText;}	catch {}
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Guhimbaza.rtf");
            richTextBox1.Rtf = myText;}	catch {}
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Gushinga intahe.rtf");
            richTextBox1.Rtf = myText;}
        		catch {}
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Kunywana kw-Abera.rtf");
            richTextBox1.Rtf = myText;}
        		catch {}
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try{
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Gusenga.rtf");
            richTextBox1.Rtf = myText;}
        		catch {}
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        	try {
            String myText = File.ReadAllText("" + Path + "/Resources/Enseignement/Mpwemu Yera.rtf");
            richTextBox1.Rtf = myText;}	catch {}
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
