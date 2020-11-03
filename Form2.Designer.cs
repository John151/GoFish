namespace GoFish
{
    partial class Form2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboCardRequest = new System.Windows.Forms.ComboBox();
            this.txtP2Points = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c8 = new System.Windows.Forms.Label();
            this.c7 = new System.Windows.Forms.Label();
            this.c5 = new System.Windows.Forms.Label();
            this.c6 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(310, 125);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Go";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // cboCardRequest
            // 
            this.cboCardRequest.FormattingEnabled = true;
            this.cboCardRequest.Location = new System.Drawing.Point(262, 84);
            this.cboCardRequest.Name = "cboCardRequest";
            this.cboCardRequest.Size = new System.Drawing.Size(121, 21);
            this.cboCardRequest.TabIndex = 31;
            // 
            // txtP2Points
            // 
            this.txtP2Points.Location = new System.Drawing.Point(91, 68);
            this.txtP2Points.Name = "txtP2Points";
            this.txtP2Points.ReadOnly = true;
            this.txtP2Points.Size = new System.Drawing.Size(36, 20);
            this.txtP2Points.TabIndex = 30;
            this.txtP2Points.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Do you have any...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c8);
            this.groupBox1.Controls.Add(this.c7);
            this.groupBox1.Controls.Add(this.c5);
            this.groupBox1.Controls.Add(this.c6);
            this.groupBox1.Location = new System.Drawing.Point(49, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hand";
            // 
            // c8
            // 
            this.c8.AutoSize = true;
            this.c8.Location = new System.Drawing.Point(136, 35);
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(35, 13);
            this.c8.TabIndex = 7;
            this.c8.Text = "label8";
            // 
            // c7
            // 
            this.c7.AutoSize = true;
            this.c7.Location = new System.Drawing.Point(95, 35);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(35, 13);
            this.c7.TabIndex = 5;
            this.c7.Text = "label1";
            // 
            // c5
            // 
            this.c5.AutoSize = true;
            this.c5.Location = new System.Drawing.Point(13, 35);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(35, 13);
            this.c5.TabIndex = 1;
            this.c5.Text = "label2";
            // 
            // c6
            // 
            this.c6.AutoSize = true;
            this.c6.Location = new System.Drawing.Point(54, 35);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(35, 13);
            this.c6.TabIndex = 3;
            this.c6.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Points:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Do you have any...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboCardRequest);
            this.Controls.Add(this.txtP2Points);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnSubmit; //public
        public System.Windows.Forms.ComboBox cboCardRequest; //public
        private System.Windows.Forms.TextBox txtP2Points;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label c8;
        public System.Windows.Forms.Label c7;
        public System.Windows.Forms.Label c5;
        public System.Windows.Forms.Label c6;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1; //public
        public Form1 frm1; //public
        private System.Windows.Forms.Label label2;
    }
}       
