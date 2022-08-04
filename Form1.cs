using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources; //added to use images from the resource

namespace War
{
    public partial class Form1 : Form
    {
        private bool[] fillDeck = new bool[52]; //fill the deck with 52 cards

        private Random rand = new Random(); //initialize a random value

        private int myWins, hisWins;
        private int myCard, hisCard; //initialize cards
        private int myValue, hisValue; //initialize card values
        private int myPoints, hisPoints; //initialize the points
        private PictureBox[] selectCards; ////initialize card images

        public Form1()
        {
            InitializeComponent();
            myWins = hisWins = 0;
            myCard = hisCard = -1; //cards get a value of -1 so they don't start at some value that is defined
            myValue = hisValue = 0; //values are zero at the beginning
            myPoints = hisPoints = 0; //points are zero at the beginning
            btAgain.Visible = false; //we can't use the button to repeat if we haven't even started

            selectCards = new PictureBox[52]; //we assign images to cards
            ResourceManager rm = War.Properties.Resources.ResourceManager; //we take them from resources
            for (int i = 0; i < 52; ++i) //we assign to each card
            {
                selectCards[i] = new PictureBox();
                selectCards[i].Image = (Image)rm.GetObject("_" + (i + 1).ToString());
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("War is a game in which two players receive the same number of cards.\nBoth players draw cards and compare them.\nIf the first player's card has a higher value then it is put aside together with the second player's card, in case the cards are of equal value each player puts his side card.\nThe ace ranks as the strongest card, then all other cards in order from king to two.\nThe winner is the player with the most cards on the side when both players have used up all the cards in their decks.");
        }

        private void btDraw_Click(object sender, EventArgs e) //here we see what happens when we press the button to draw cards
        {
            btShuffle.Visible = false; //it is no longer available to us to shuffle the cards when we have already started to play
            //get separate cards
            do
            {
                //takes a value from 0 to 52
                myCard = rand.Next(52);
            }
            while (fillDeck[myCard]); //until it gets a non-false bool value

            pbMyCard.Image = new Bitmap(selectCards[myCard].Image); //we display a specific card image
            fillDeck[myCard] = true; //states that the card has already been taken
            myValue = (myCard % 13) + 2; //the value of the card is the remainder divided by 13 because each type of card has 13 cards, we add two more because we are working in 13 field and the value of the last card is 14
            //we do the same for the computer
            do
            {
                hisCard = rand.Next(52);
            }
            while (fillDeck[hisCard]);

            pbHisCard.Image = new Bitmap(selectCards[hisCard].Image);
            fillDeck[hisCard] = true;
            hisValue = (hisCard % 13) + 2;

            //divide the points
            if (myValue > hisValue)
                myPoints += 2;
            else if (myValue < hisValue)
                hisPoints += 2;
            else
            {
                myPoints++;
                hisPoints++;
            }

            //test whose victory
            if ((myPoints + hisPoints) >= 52)
            {
                pbDeck1.Image = null;
                pbDeck2.Image = null;
                if (myPoints > hisPoints)
                {
                    lbResult.Text = "The first player wins!";
                    myWins++;
                }
                else if (hisPoints > myPoints)
                {
                    lbResult.Text = "The other player won!";
                    hisWins++;
                }
                else
                    lbResult.Text = "A draw!";
                btAgain.Visible = true;
                btDraw.Visible = false;

            }
            //display points
            lbPoints1.Text = Convert.ToString(myPoints);
            lbPoints2.Text = Convert.ToString(hisPoints);
        }

        private void btAgain_Click(object sender, EventArgs e) //here everything is being adjusted again for the next match
        {
            myCard = hisCard = -1;
            myValue = hisValue = 0;
            myPoints = hisPoints = 0;
            for (int i = 0; i < 52; ++i)
                fillDeck[i] = false;
            lbResult.Text = null;
            lbPoints1.Text = null;
            lbPoints2.Text = null;
            pbDeck1.Image = War.Properties.Resources.yellow_back;
            pbDeck2.Image = War.Properties.Resources.red_back;
            pbMyCard.Image = pbHisCard.Image = null;
            btDraw.Visible = true;
            btAgain.Visible = false;
            btShuffle.Visible = true;
        }

        private void btShuffle_Click(object sender, EventArgs e) //this is where the first card is shuffled
        {
            btShuffle.Visible = true;
            do
            {
                myCard = rand.Next(52);
            }
            while (fillDeck[myCard]);

            do
            {
                hisCard = rand.Next(52);
            }
            while (fillDeck[hisCard]);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //the number of wins is displayed here after exiting the application
        {
            MessageBox.Show("Results!\n\nThe number of wins of the first player: " + myWins + "\n\nNumber of wins by the other player: " + hisWins + "\n");
            Application.Exit();
        }

    }
}
