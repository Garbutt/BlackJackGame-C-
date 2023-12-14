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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int cardNumber = random.Next(0, 51);
        }

       

        int number;

        int cards(int number)
        {

            int cardValue;

            switch (number)
            {
                case 0:
                    Image acec = imageList1.Images[0];
                    Image aced = imageList1.Images[1];
                    Image aceh = imageList1.Images[2];
                    Image aces = imageList1.Images[3];

                    cardValue =  11;
                    break;

                case 1:
                    Image twod = imageList1.Images[4];
                    Image twoc = imageList1.Images[5];
                    Image twoh = imageList1.Images[6];
                    Image twos = imageList1.Images[7];
                   
                    cardValue = 2;
                    break;

                case 2:
                    Image threed = imageList1.Images[8];
                    Image threec = imageList1.Images[9];
                    Image threeh = imageList1.Images[10];
                    Image threes = imageList1.Images[11];
                    
                    cardValue = 3;
                    break;

                case 3:
                    Image fourd = imageList1.Images[12];
                    Image fourc = imageList1.Images[13];
                    Image fourh = imageList1.Images[14];
                    Image fours = imageList1.Images[15];
                    cardValue = 4;
                    break;

                case 4:
                    Image fived = imageList1.Images[16];
                    Image fivec = imageList1.Images[17];
                    Image fiveh = imageList1.Images[18];
                    Image fives = imageList1.Images[19];
                    cardValue = 5;
                    break;

                case 5:
                    Image sixd = imageList1.Images[20];
                    Image sixc = imageList1.Images[21];
                    Image sixh = imageList1.Images[22];
                    Image sixs = imageList1.Images[23];
                    cardValue = 6;
                    break;

                case 6:
                    Image sevend = imageList1.Images[24];
                    Image sevendc = imageList1.Images[25];
                    Image sevendh = imageList1.Images[26];
                    Image sevends = imageList1.Images[27];
                    cardValue = 7;
                    break;

                case 7:
                    Image eightd = imageList1.Images[28];
                    Image eightc = imageList1.Images[29];
                    Image eighth = imageList1.Images[30];
                    Image eights = imageList1.Images[31];
                    cardValue = 8;
                    break;

                case 8:
                    Image nined = imageList1.Images[32];
                    Image ninec = imageList1.Images[33];
                    Image nineh = imageList1.Images[34];
                    Image nines = imageList1.Images[35];
                    cardValue = 9;
                    break;

                case 9:
                    Image tend = imageList1.Images[36];
                    Image tenc = imageList1.Images[37];
                    Image tenh = imageList1.Images[38];
                    Image tens = imageList1.Images[39];
                    cardValue = 10;
                    break;

                case 10:
                    Image jc = imageList1.Images[40];
                    Image jd = imageList1.Images[41];
                    Image jh = imageList1.Images[42];
                    Image js = imageList1.Images[43];
                    Image kc = imageList1.Images[44];
                    Image kd = imageList1.Images[45];
                    Image kh = imageList1.Images[46];
                    Image ks = imageList1.Images[47];
                    Image qc = imageList1.Images[48];
                    Image qd = imageList1.Images[49];
                    Image qh = imageList1.Images[50];
                    Image qs = imageList1.Images[51];
                    cardValue = 10;
                    break;
                    
            }
            return cardValue;
        }

    }
}

