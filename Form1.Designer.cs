namespace GoFish
{
    public partial class Form1
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
        public void InitializeComponent()
        {
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboCardRequest = new System.Windows.Forms.ComboBox();
            this.txtP1Points = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c4 = new System.Windows.Forms.Label();
            this.c3 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(286, 123);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Go";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // cboCardRequest
            // 
            this.cboCardRequest.FormattingEnabled = true;
            this.cboCardRequest.Location = new System.Drawing.Point(238, 82);
            this.cboCardRequest.Name = "cboCardRequest";
            this.cboCardRequest.Size = new System.Drawing.Size(121, 21);
            this.cboCardRequest.TabIndex = 25;
            // 
            // txtP1Points
            // 
            this.txtP1Points.Location = new System.Drawing.Point(67, 59);
            this.txtP1Points.Name = "txtP1Points";
            this.txtP1Points.ReadOnly = true;
            this.txtP1Points.Size = new System.Drawing.Size(36, 20);
            this.txtP1Points.TabIndex = 24;
            this.txtP1Points.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Do you have any...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c4);
            this.groupBox1.Controls.Add(this.c3);
            this.groupBox1.Controls.Add(this.c1);
            this.groupBox1.Controls.Add(this.c2);
            this.groupBox1.Location = new System.Drawing.Point(25, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hand";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(136, 35);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(35, 13);
            this.c4.TabIndex = 7;
            this.c4.Text = "label8";
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(95, 35);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(35, 13);
            this.c3.TabIndex = 5;
            this.c3.Text = "label1";
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(13, 35);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(35, 13);
            this.c1.TabIndex = 1;
            this.c1.Text = "label2";
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(54, 35);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(35, 13);
            this.c2.TabIndex = 3;
            this.c2.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Points:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Do you have any...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboCardRequest);
            this.Controls.Add(this.txtP1Points);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Player 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //public Form2 form2;
        Form2 frm = new Form2();
        public System.Windows.Forms.Button btnSubmit; //public
        public System.Windows.Forms.ComboBox cboCardRequest; //public
        public System.Windows.Forms.TextBox txtP1Points;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label c4;
        public System.Windows.Forms.Label c3;
        public System.Windows.Forms.Label c1;
        public System.Windows.Forms.Label c2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

