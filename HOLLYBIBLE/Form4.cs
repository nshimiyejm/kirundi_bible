using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Drawing.Printing;
namespace HOLLYBIBLE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private string Path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.ExecutablePath).ToString()).ToString()).ToString();
        private string langue = "francais";
        private string req;
        private string req1;
        private string req2;
        public string folder = "V_Fra";
        int start = 0;
        int indexOfSearchText = 0;
        private void eNSEIGNEMENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {try {
            Form3 frt = new Form3();
            frt.Show();}	catch {}
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        	try {
            Form3 frt = new Form3();
            frt.Show();}	catch {}
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
        	try {
            livres();
            id();
//            comboBox1.Text = "Genese";
toolStripStatusLabel1.Text ="";}
        		catch {}
        }

        private void id()
        {
        	try {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select theme from Notes";
            cmd.Connection = con;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            listBox3.Items.Clear();
            while (dr.Read())
            {

                listBox3.Items.Add(dr.GetValue(0));
            }

            con.Close();
        	}	catch {}

        }

        private void livres()
        {
            try
            {


                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");

                OleDbCommand cmd = con.CreateCommand();
                OleDbCommand cmd1 = con.CreateCommand();
                OleDbCommand cmd2 = con.CreateCommand();
                if (langue == "francais")
                {


                    req2 = "SELECT V_Fra FROM livres ";
                    req = "SELECT V_Fra FROM livres where Testaments= 1";
                    req1 = "SELECT V_Fra FROM livres where Testaments= 2";


                }

                else if (langue == "anglais")
                {
                    req2 = "SELECT V_Ang FROM livres ";
                    req = "SELECT V_Ang FROM livres where Testaments= 1";
                    req1 = "SELECT V_Ang FROM livres where Testaments= 2";
                }

                else if (langue == "kirundi")
                {
                    req2 = "SELECT V_Kir FROM livres ";
                    req = "SELECT V_Kir FROM livres where Testaments= 1";
                    req1 = "SELECT V_Kir FROM livres where Testaments= 2";
                }

                cmd.CommandText = req;
                cmd1.CommandText = req1;
                cmd2.CommandText = req2;

                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader(); ;
                listBox1.Items.Clear();

                comboBox1.Text = "";
                while (dr.Read())
                {

                    listBox1.Items.Add(dr.GetValue(0));

                }



                OleDbDataReader dr1 = cmd1.ExecuteReader(); ;
                listBox2.Items.Clear();
                //comboBox1.Items.Clear();
                //comboBox1.Text = "";
                while (dr1.Read())
                {

                    listBox2.Items.Add(dr1.GetValue(0));
                   
                }



                OleDbDataReader dr2 = cmd2.ExecuteReader(); ;
                //listBox2.Items.Clear();
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                while (dr2.Read())
                {

                    
                    comboBox1.Items.Add(dr2.GetString(0));
                }




             }
             catch
            { }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                comboBox1.Text = Convert.ToString(listBox1.SelectedItem);
            }
            catch
            { }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                comboBox1.Text = Convert.ToString(listBox2.SelectedItem);
            }
            catch
            { }
        }

        private void aNGLAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                langue = "anglais";
                fICHIERToolStripMenuItem.Text = "Exit";
                //lISTEDESLIVRESToolStripMenuItem.Text = "Books";
                oPTIONToolStripMenuItem.Text = "Tools";
                eNSEIGNEMENTSToolStripMenuItem.Text = "Teachings";
                groupBox3.Text = "Police";
                groupBox4.Text = "Books";
                livres();
                groupBox1.Text = "Chapters";
                label2.Text = "Old Testament";
                label1.Text = "New Testament ";
                
                button5 .Text ="Delete";
                toolStripMenuItem2.Text = "Language";
                checkBox1.Text = "Audio";
                button1.Text = "Save";
                button2.Text = "Update";
                label5.Text = "Message";
                label3.Text = "Date";
                label4.Text = "Theme";
                button3.Text = "color";
                button4.Text = "print";
                comboBox1.Text = "Genesis";
                groupBox5.Text = "Color";
                groupBox6.Text = "Print";
                groupBox2.Text = "Search";
               
            }
            catch
            { }

        }

        private void kIRUNDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                langue = "kirundi";
                fICHIERToolStripMenuItem.Text = "Gusohoka";
                //lISTEDESLIVRESToolStripMenuItem.Text = "Ibitabo";
                oPTIONToolStripMenuItem.Text = "Ubuhinga";
                eNSEIGNEMENTSToolStripMenuItem.Text = "Inyigisho";
                toolStripMenuItem2.Text = "Ururimi";
                groupBox4.Text = "Ibitabo";
                livres();
                label2.Text = "Isezerano rya Kera";
                label1.Text = "Isezerano Risha";
                groupBox2.Text = "Kurondera";
                groupBox1.Text = "Ibigabane";
                checkBox1.Text = "Ijwi";
                button1.Text = "Gushingura";
                button2.Text = "Guhindura";
                comboBox1.Text = "Itanguriro";
//                label1.Text = "Ubutumwa";
                label3.Text = "Itariki";
//                label2.Text = "Icivugo";
                button3.Text = "Ibara";
                label5.Text = "Ubutumwa";
                label4.Text = "Icivugo";
                groupBox3.Text = "Ubunini";
                groupBox5.Text = "Ibara";
                groupBox6.Text = "Gusohora";
                button4.Text = "Gusohora";
              
                button5 .Text ="Guhanagura";
            }
            catch
            { }
        }

        private void fRANCAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                langue = "francais";
                livres();

                fICHIERToolStripMenuItem.Text = "Quitter";
                //lISTEDESLIVRESToolStripMenuItem.Text = "Livres";
                oPTIONToolStripMenuItem.Text = "Outils";
                eNSEIGNEMENTSToolStripMenuItem.Text = "Enseignements";
                comboBox1.Text = "Genese";
                groupBox4.Text = "Livres";
                toolStripMenuItem2.Text = "Langues";
                label2.Text = "Ancien Testament";
                label1.Text = "Nouveau Testament";
                //           groupBox5.Text = "Testaments";
                groupBox1.Text = "Chapitres";
                checkBox1.Text = "Audio";
                button1.Text = "Enregistrer";
                button2.Text = "Modifier";
                groupBox2.Text = "Recherche";
                label5.Text = "Message";
                label3.Text = "Date";
                label4.Text = "Theme";
button5 .Text ="Supprimer";
//                imprimerToolStripMenuItem.Text = "Imprimer";
            }
            catch
            { }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        	try{
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from Notes where theme ='" + listBox3.Text + "' ";
            cmd.Connection = con;
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
textBox3.Text=(dr .GetString(1));
dateTimePicker1.Value    =Convert.ToDateTime  (dr.GetDateTime(2));
textBox2.Text = (dr .GetString(3));          
            }

            con.Close();}
        		catch {}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( (textBox3 .Text =="")  || ( textBox2 .Text =="") )
            	{
            		 if (langue =="francais"){
                
               MessageBox.Show("Veuillez Completer tous les champs","ERREUR",MessageBoxButtons .OK ,MessageBoxIcon.Error  );
                }else if (langue=="kirundi"){
                
                  MessageBox.Show("Banza wuzuze utwo twumba","IKOSA",MessageBoxButtons .OK ,MessageBoxIcon.Error   );
              
                }else{
                  MessageBox.Show("please fill the fields","ERROR",MessageBoxButtons .OK ,MessageBoxIcon.Error  );
              
                
                }
            		
            		
            		
            	}else{
        	
        	
        	
        	
        	try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "update notes set theme='" + textBox3.Text + "',date_theme='" + dateTimePicker1.Text + "',Message='" + textBox2.Text + "' where theme='" +listBox3.Text   + "'  ";
                cmd.ExecuteNonQuery();
                 if (langue =="francais"){
                
                MessageBox.Show("Modification reussie","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
                }else if (langue=="kirundi"){
                
                  MessageBox.Show("Vyahindutse","Menya",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                }else{
                  MessageBox.Show("Updated","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                
                }
                vider();
                id();
            }
            catch
            { }}
        }
        private void vider(){
        textBox2 .Text ="";
        textBox3 .Text ="";
        listBox3 .Text ="";
        
        
        }
        
        
        public string test;

        private void testaments() {


            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Testaments FROM livres where V_Fra='" + comboBox1.Text + "' or  V_Ang='" + comboBox1.Text + "' or  V_Kir='" + comboBox1.Text + "'";
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader(); ;

                while (dr.Read())
                {
                    string tes = Convert.ToString(dr.GetValue(0));
                    Int32 vers = Convert.ToInt32(tes);
                    if (vers == 1)
                    {

                        test = "AT";
                    }
                    else
                    {
                        test = "NT";
                    }

                }
            }
            catch
            { }
        }
        private void lecture()
        {

            testaments();

            try
            {
                if (checkBox1.Checked == true)
                {

                    string folder = "V_Fra";
                    if (langue == "francais")
                    {
                        folder = "V_Fra";
                        //MessageBox.Show(folder);
                    }

                    else if (langue == "anglais")
                    {
                        folder = "V_Ang";
                        //MessageBox.Show(folder);
                    }

                    else if (langue == "kirundi")
                    {
                        folder = "V_Kir";

                    }

 if (File .Exists ("" + Path + "/Resources/" + folder + "/" + test + "/AUDIO/" + comboBox1.Text + "/" + comboBox2.Text + ".mp3")){
          
                    axWindowsMediaPlayer1.URL = "" + Path + "/Resources/" + folder + "/" + test + "/AUDIO/" + comboBox1.Text + "/" + comboBox2.Text + ".mp3";
                    }else {
                    	
                    axWindowsMediaPlayer1 .URL ="";
                     axWindowsMediaPlayer1.close();
                     checkBox1 .Checked =false ;
                    }
                    
                    
                    
                }
                else
                {
 axWindowsMediaPlayer1 .URL ="";
                    axWindowsMediaPlayer1.close();
                     checkBox1 .Checked =false ;
                }
            }
            catch
            { }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT nbre_chapitres FROM livres where V_Fra='" + comboBox1.Text + "' or  V_Ang='" + comboBox1.Text + "' or  V_Kir='" + comboBox1.Text + "'";
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader(); ;

                while (dr.Read())
                {
                    string tes = Convert.ToString(dr.GetValue(0));
                    Int32 vers = Convert.ToInt32(tes);
                    Int32 i = 0;
                    comboBox2.Items.Clear();
                    comboBox2.Text = "1";
                    while (i < vers)
                    {
                        i = i + 1;
                        comboBox2.Items.Add(i);

                    }
                    lecturetext();
                    lecture();
                    toolStripStatusLabel1.Text = comboBox1.Text + comboBox2.Text + ":";
                }
            }
            catch
            { }
//           
        }
        private void lecturetext()
        {
        	try{
            testaments();

            string folder = "V_Fra";
            if (langue == "francais")
            {
                folder = "V_Fra";
                
            }

            else if (langue == "anglais")
            {
                folder = "V_Ang";
               
            }

            else if (langue == "kirundi")
            {
                folder = "V_Kir";
                
            }

            if (File .Exists ("" + Path + "/Resources/" + folder + "/" + test + "/TXT/" + comboBox1.Text + "/" + comboBox2.Text + ".rtf")){
            String myText = File.ReadAllText("" + Path + "/Resources/" + folder + "/" + test + "/TXT/" + comboBox1.Text + "/" + comboBox2.Text + ".rtf");
            rtb.Clear();

            rtb.Rtf = myText;
            rtb .SelectAll ();
   rtb .SelectionFont =         new Font("BELL MT", 12, FontStyle.Regular);
   
   rtb .DeselectAll ();
            }
            else 
            	
            	
            {
             rtb.Clear();
            }
            
        	}	catch {}

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        	try {
        		lecture();}
        		catch {}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                lecturetext();
                lecture();
                //toolStripStatusLabel3.Text = comboBox2.Text;


            }
            catch
            { }
            toolStripStatusLabel1.Text = comboBox1.Text + comboBox2.Text + ":";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            	
            	if( (textBox3 .Text =="")  || ( textBox2 .Text =="") )
            	{
            		 if (langue =="francais"){
                
               MessageBox.Show("Veuillez Completer tous les champs","ERREUR",MessageBoxButtons .OK ,MessageBoxIcon.Error  );
                }else if (langue=="kirundi"){
                
                  MessageBox.Show("Banza wuzuze utwo twumba","IKOSA",MessageBoxButtons .OK ,MessageBoxIcon.Error   );
              
                }else{
                  MessageBox.Show("please fill the fields","ERROR",MessageBoxButtons .OK ,MessageBoxIcon.Error  );
              
                
                }
            		
            		
            		
            	}else{

                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");
                con.Open();
                OleDbCommand cmd1 = con.CreateCommand();
                cmd1.CommandText = "select count(*) from notes where theme='"+listBox3 .Text +"'";
                int res= Convert .ToInt16 (  cmd1.ExecuteScalar ());
                con.Close ();
             if (res ==0){
                
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into notes (theme,date_theme,Message)values ('" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                if (langue =="francais"){
                
                MessageBox.Show("Enregistrement reussi","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
                }else if (langue=="kirundi"){
                
                  MessageBox.Show("Vyashinguwe","Menya",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                }else{
                  MessageBox.Show("Saved","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                
                }
                vider();
                id();
             }else
             {
              MessageBox.Show("le theme existe deja","INFO",MessageBoxButtons .OK ,MessageBoxIcon.Exclamation    );
vider();
             }
            	}
                
            }
            catch
            { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        	try{
            start = 0;
            indexOfSearchText = 0;

            rtb.SelectAll();
            rtb.SelectionColor = Color.Black;
            rtb.DeselectAll();
            for (int i = 0; i < 100; i = i + 1)
            {
                code();

            }}	catch {}
        }
        private void code()
        {
        	try{
            int startindex = 0;

            if (txtSearch.Text.Length > 0)
                startindex = FindMyText(txtSearch.Text.Trim(), start, rtb.Text.Length);

            // If string was found in the RichTextBox, highlight it
            if (startindex >= 0)
            {
                // Set the highlight color as red
                rtb.SelectionColor = Color.Red;

                // Find the end index. End Index = number of characters in textbox
                int endindex = txtSearch.Text.Length;
                // Highlight the search string
                rtb.Select(startindex, endindex);
                // mark the start position after the position of
                // last search string

                start = startindex + endindex;
            }}
	catch {}
        }
        public int FindMyText(string txtToSearch, int searchStart, int searchEnd)
        {
        	 

            // Set the return value to -1 by default.
            int retVal = -1;

            // A valid starting index should be specified.
            // if indexOfSearchText = -1, the end of search
            if (searchStart >= 0 && indexOfSearchText >= 0)
            {
                // A valid ending index
                if (searchEnd > searchStart || searchEnd == -1)
                {
                    // Find the position of search string in RichTextBox
                    indexOfSearchText = rtb.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None);
                    // Determine whether the text was found in richTextBox1.
                    if (indexOfSearchText != -1)
                    {
                        // Return the index to the specified search text.
                        retVal = indexOfSearchText;
                    }
                }
            }
            return retVal;
        	
        }
        

        private void rtb_TextChanged(object sender, EventArgs e)
        {
        	
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        	try{
            rtb.SelectionFont = new Font(  comboBox3.Text  , Convert.ToInt16(comboBox4.Text), FontStyle.Regular);
        	}	catch {}
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {try{
            rtb.SelectionFont = new Font(comboBox3.Text, Convert.ToInt16(comboBox4.Text), FontStyle.Regular);
        	}	catch {}
        }
        //Boolean t = false;
        private void label6_Click(object sender, EventArgs e)
        {
        	try{
            button3.BackColor = Color.Green;
            rtb.SelectionFont = new Font(comboBox3.Text, Convert.ToInt16(comboBox4.Text), FontStyle.Bold);
            if (button3.BackColor == Color.Green)
            {


                rtb.SelectionFont = new Font(comboBox3.Text, Convert.ToInt16(comboBox4.Text), FontStyle.Bold);

            }
            else
            {

                rtb.SelectionFont = new Font(comboBox3.Text, Convert.ToInt16(comboBox4.Text), FontStyle.Regular);
                button3.BackColor = Color.White;
            }
        	}	catch {}
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void imprDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }
       




        
        private void button4_Click(object sender, EventArgs e)
        {
        	try{
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }}	catch {}
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
        	try {
            e.Graphics.DrawString(rtb.Text, new Font("Bell MT", 8, FontStyle.Bold), Brushes.Black,0,0);
        	}	catch {}
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        	try {
        	colorDialog1 .ShowDialog ();
        		rtb .SelectionColor = colorDialog1.Color ;
        		rtb.SaveFile (   Path + "/Resources/" + folder + "/" + test + "/TXT/" + comboBox1.Text + "/" + comboBox2.Text + ".rtf",RichTextBoxStreamType .RichText);
        	}	catch {}
        
        }

        
        void Button5Click(object sender, EventArgs e)
        {
        	try {
        	if (listBox3 .Text ==""){
        		  if (langue =="francais"){
                
             MessageBox .Show ("Suppression Impossible","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information  );

                }else if (langue=="kirundi"){
                
                  MessageBox.Show("Ntavyo guhanagura","Menya",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                }else{
                  MessageBox.Show("No item to delete","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                
                }
        		}else{
         
        	OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " + Path + "/Resources/BIBLE.mdb");
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "delete from notes where theme='" +listBox3.Text   + "'  ";
                cmd.ExecuteNonQuery();
                if (langue =="francais"){
                
                MessageBox.Show("Suppression reussie","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
                }else if (langue=="kirundi"){
                
                  MessageBox.Show("Vyahanaguritse","Menya",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                }else{
                  MessageBox.Show("Deleted","INFO",MessageBoxButtons .OK ,MessageBoxIcon .Information   );
              
                
                }
        		}
                vider();
                id();
        	}	catch {}
        }
        
        void FICHIERToolStripMenuItemClick(object sender, EventArgs e)
        {
        	try {
        		Application .Exit ();}	catch {}
        }
        
        void Button6Click(object sender, EventArgs e)
        {
        	rtb .Copy ();
        }
    }
}
