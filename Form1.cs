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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (string option in cardOptions)
            {
                cboCardRequest.Items.Add(option);
            }

            Random rand = new Random();

            while (playerOneHand.Count() < 4)
            {
                decksize = deckOfCards.Count();
                cardIndex = rand.Next(0, decksize);
                card = deckOfCards[cardIndex];
                playerOneHand.Add(card);
                deckOfCards.RemoveAt(cardIndex);
            }
            while (playerTwoHand.Count() < 4)
            {
                int cardIndex = rand.Next(0, deckOfCards.Count());
                string card = deckOfCards[cardIndex];
                playerTwoHand.Add(card);
                deckOfCards.RemoveAt(cardIndex);

            }
            c1.Text = playerOneHand[0];
            c2.Text = playerOneHand[1];
            c3.Text = playerOneHand[2];
            c4.Text = playerOneHand[3];
            ((Form2)frm).c5.Text = playerTwoHand[0];
            ((Form2)frm).c6.Text = playerTwoHand[1];
            ((Form2)frm).c7.Text = playerTwoHand[2];
            ((Form2)frm).c8.Text = playerTwoHand[3];
        }
        List<string> deckOfCards = new List<string>
        {
          "2", "2", "2", "2", "3", "3", "3", "3",
          "4", "4", "4", "4", "5", "5", "5", "5",
          "6", "6", "6", "6", "7", "7", "7", "7",
          "8", "8", "8", "8", "9", "9", "9", "9",
          "10", "10", "10", "10", "J", "J", "J", "J",
          "Q", "Q", "Q", "Q", "K", "K", "K", "K",
          "A", "A", "A", "A"
        };

        string[] cardOptions = {"2", "3", "4", "5", "6", "7", "8",
        "9", "10", "J", "Q", "K", "A"};

        List<string> playerOneHand = new List<string>();
        List<string> playerTwoHand = new List<string>();

        int cardIndex;
        string card;
        int decksize;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            ((Form2)frm).label1.Text = cboCardRequest.Text;
            frm.frm1 = this;
            frm.Show();
        }
    }
}
