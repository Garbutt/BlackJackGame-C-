using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame

{
    public partial class Form2 : Form
    {

        private int cardValue;
        public Form2()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int Cards;
        private Random randomGen = new Random();
        Random rndCard = new Random();
        private int currentCardIndex = -1;
        private int playerTotal = 0;
        private int dealerTotal = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            int cardNumber;
            

            do
            {
                cardNumber = rndCard.Next(0, 51);
            } while (cardNumber == cardValue ||
                     (pictureBox3.Image != null && pictureBox4.Image != null && pictureBox5.Image != null));

            if (pictureBox3.Image == null)
            {
                pictureBox3.Image = imageList1.Images[cardNumber];
                pictureBox3.Visible = true;  // Make the PictureBox visible
                cardValue = cardNumber;
            }
            else if (pictureBox4.Image == null)
            {
                pictureBox4.Image = imageList1.Images[cardNumber];
                pictureBox4.Visible = true;  // Make the PictureBox visible
                cardValue = cardNumber;
            }
            else if (pictureBox5.Image == null)
            {
                pictureBox5.Image = imageList1.Images[cardNumber];
                pictureBox5.Visible = true;  // Make the PictureBox visible
                cardValue = cardNumber;
            }

            cardValue = calcCardValue(cardNumber);

            
        }
        private int calcCardValue(int number)
        {

            

#pragma warning disable format
            switch (number)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    cardValue = 11;
                    break;

                case 4:
                case 5:
                case 6:
                case 7:
                    cardValue = 2;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                    cardValue = 3;
                    break;

                  
               

               case 12:
               case 13:
               case 14:
               case 15:
                   cardValue = 4;
                    break;

             

              case 16:
                case 17:
                case 18:
                case 19:
                    cardValue = 5;
                    break;
                    

                

                case 20:
                case 21:
                case 22:
                case 23:
                    cardValue = 6;
                    break;



              case 24:
              case 25:
              case 26:
              case 27:
                      cardValue = 7;
                    break;

              case 28:
              case 29:
              case 30:
              case 31:
                    cardValue = 8;
                    break;

             case 32:
             case 33:
             case 34:
             case 35:
                 cardValue = 9;
                    break;

            case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                case 51:
                    cardValue = 10;
                        break;


                default:
                    cardValue = 0;
                    break;
            }


            return cardValue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Draw two cards for the player
            DrawPlayerCard(pictureBox1);
            DrawPlayerCard(pictureBox2);

            // Draw two cards for the dealer
            DrawDealerCard(pictureBox6);
            DrawDealerCard(pictureBox7);
        }

        private void DrawPlayerCard(PictureBox pictureBox)
        {
            int cardNumber, cardValue;

            do
            {
                cardNumber = rndCard.Next(0, 51);
            } while (cardNumber == currentCardIndex ||
                     (pictureBox3.Image != null && pictureBox4.Image != null && pictureBox5.Image != null));

            pictureBox.Image = imageList1.Images[cardNumber];
            pictureBox.Visible = true;  // Make the PictureBox visible
            currentCardIndex = cardNumber;

            cardValue = calcCardValue(cardNumber);
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            button3.Visible = false;
            button1.Visible = true;
            button2.Visible = true;

            playerTotal += cardValue;
        }

        private void DrawDealerCard(PictureBox pictureBox)
        {
            int dealerCardNumber, dealerCardValue;

            do
            {
                dealerCardNumber = rndCard.Next(0, 51);
                dealerCardValue = calcCardValue(dealerCardNumber);
            } while (dealerCardValue > 38 && dealerCardValue < 52); // Ensure the card value is between 8 and 10

            pictureBox.Image = imageList1.Images[dealerCardNumber];

            dealerTotal += dealerCardValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            determineWinner();
        }

       private void determineWinner()
        {
            if (playerTotal > 21)
            {
                MessageBox.Show("Player Bust! Dealer Wins!");
            }

            else if (dealerTotal > 21 || playerTotal > dealerTotal)
            {
                MessageBox.Show("Player Wins!");
            }

            else if (playerTotal < dealerTotal)
                MessageBox.Show("Dealer Wins!");

            else
            {
                MessageBox.Show("It's a Tie!");
            }
        }
    }
}

