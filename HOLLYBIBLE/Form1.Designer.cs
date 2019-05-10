namespace HOLLYBIBLE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.timer2 = new System.Windows.Forms.Timer(this.components);
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BackColor = System.Drawing.Color.Transparent;
        	this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(4, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(134, 24);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "HOLLY BIBLE";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.BackColor = System.Drawing.Color.Transparent;
        	this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.ForeColor = System.Drawing.Color.White;
        	this.label2.Location = new System.Drawing.Point(348, 9);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(145, 24);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "SAINTE BIBLE";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.BackColor = System.Drawing.Color.Transparent;
        	this.label3.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.ForeColor = System.Drawing.Color.White;
        	this.label3.Location = new System.Drawing.Point(168, 9);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(156, 24);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "BIBILIYA YERA";
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.toolStripStatusLabel1,
        	        	        	this.toolStripStatusLabel2,
        	        	        	this.toolStripProgressBar1});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 276);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(505, 22);
        	this.statusStrip1.TabIndex = 3;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(260, 17);
        	this.toolStripStatusLabel1.Text = "Copyright 2014 designed by Audry MASABO ";
        	this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1Click);
        	// 
        	// toolStripStatusLabel2
        	// 
        	this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        	this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 17);
        	this.toolStripStatusLabel2.Text = "        ";
        	// 
        	// toolStripProgressBar1
        	// 
        	this.toolStripProgressBar1.AutoSize = false;
        	this.toolStripProgressBar1.Name = "toolStripProgressBar1";
        	this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
        	// 
        	// timer1
        	// 
        	this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        	// 
        	// timer2
        	// 
        	this.timer2.Enabled = true;
        	this.timer2.Interval = 50;
        	this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackgroundImage = global::HOLLYBIBLE.Properties.Resources.bible_02;
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.ClientSize = new System.Drawing.Size(505, 298);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Load += new System.EventHandler(this.Form1_Load);
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer2;
    }
}

