namespace PingBoot
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
            this.output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.address1 = new System.Windows.Forms.TextBox();
            this.address2 = new System.Windows.Forms.TextBox();
            this.address3 = new System.Windows.Forms.TextBox();
            this.intervalNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.autoStart = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Location = new System.Drawing.Point(265, 12);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(187, 153);
            this.output.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(62, 48);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(197, 20);
            this.address1.TabIndex = 2;
            this.address1.Text = "192.168.1.1";
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(62, 74);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(197, 20);
            this.address2.TabIndex = 3;
            this.address2.Text = "www.google.co.uk";
            // 
            // address3
            // 
            this.address3.Location = new System.Drawing.Point(62, 100);
            this.address3.Name = "address3";
            this.address3.Size = new System.Drawing.Size(197, 20);
            this.address3.TabIndex = 4;
            this.address3.Text = "www.bbc.co.uk";
            // 
            // intervalNumber
            // 
            this.intervalNumber.Location = new System.Drawing.Point(142, 17);
            this.intervalNumber.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.intervalNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalNumber.Name = "intervalNumber";
            this.intervalNumber.Size = new System.Drawing.Size(117, 20);
            this.intervalNumber.TabIndex = 1;
            this.intervalNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Interval (minutes):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ping 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ping 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ping 2:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 152);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 101;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "By CplSyx";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Location = new System.Drawing.Point(62, 126);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(112, 17);
            this.autoStart.TabIndex = 102;
            this.autoStart.Text = "Autostart on load?";
            this.autoStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 174);
            this.Controls.Add(this.autoStart);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalNumber);
            this.Controls.Add(this.address3);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingBoot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.TextBox address3;
        private System.Windows.Forms.NumericUpDown intervalNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox autoStart;
    }
}

