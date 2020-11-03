using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string[] cardOptions = {"2", "3", "4", "5", "6", "7", "8",
        "9", "10", "J", "Q", "K", "A"};

            foreach (string option in cardOptions)
            {
                cboCardRequest.Items.Add(option);
            }
        }

    int score = 0;

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            //Application.Run(new Form2());
            ((Form1)frm1).label1.Text = cboCardRequest.Text;
            //here we need to add a check, see if chosen card is in hand
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = ((Form1)frm1).cboCardRequest.Text;

            if (label1.Text == c5.Text)
            {
                c5.Text = "";
                score++;
                ((Form1)frm1).txtP1Points.Text = score.ToString();
            }
            else if (label1.Text == c6.Text)
            {
                c6.Text = "";
                score++;
                ((Form1)frm1).txtP1Points.Text = score.ToString();
            }
            else if (label1.Text == c7.Text)
            {
                c7.Text = "";
                score++;
                ((Form1)frm1).txtP1Points.Text = score.ToString();
            }
            else if (label1.Text == c8.Text)
            {
                c8.Text = "";
                score++;
                ((Form1)frm1).txtP1Points.Text = score.ToString();
            }

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            ((Form1)frm1).label1.Text = cboCardRequest.Text;

        }
    }
}
