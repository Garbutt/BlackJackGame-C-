namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int age = int.Parse(txtAge.Text);

            

           
             if(chkAgree.Checked == false & age < 18)
            {
                MessageBox.Show("You are underage and have not agreed to the terms and conditions");
            }

           else if (chkAgree.Checked == false)
            {
                MessageBox.Show("You did not agree to the terms and conditions");
            }


            else if (age < 18)
            {
                MessageBox.Show("You cannot play, you are underage");
            }



        }
    }
}