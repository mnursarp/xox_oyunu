namespace xox_oyunu
{
    public partial class Form1 : Form
    {

        bool oyuncusirasi = true;
        private int[,] tahta = new int[3, 3];
        private int ilkoyuncu = 0;
        private int ikincioyuncu = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void kazanankontrol()
        {
            for (int r = 0; r < 3; r++)
            {
                if (tahta[r, 0] == 1 && tahta[r, 1] == 1 && tahta[r, 2] == 1)
                {
                    //MessageBox.Show("Oyuncu 1 kazandý");
                    label1.Text = "Oyuncu 1 Kazandý";
                    ilkoyuncu++;
                    label4.Text = ilkoyuncu.ToString();
                }
                if (tahta[r, 0] == 2 && tahta[r, 1] == 2 && tahta[r, 2] == 2)
                {
                    //MessageBox.Show("Oyuncu 2 kazandý");
                    label1.Text = "Oyuncu 2 Kazandý";
                    ikincioyuncu++;
                    label5.Text = ikincioyuncu.ToString();
                }

            }
            for (int c = 0; c < 3; c++)
            {
                if (tahta[0, c] == 1 && tahta[1, c] == 1 && tahta[2, c] == 1)
                {
                    label1.Text = "Oyuncu 1 Kazandý";
                    ilkoyuncu++;
                    label4.Text = ilkoyuncu.ToString();
                }
                if (tahta[0, c] == 2 && tahta[1, c] == 2 && tahta[2, c] == 2)
                {
                    label1.Text = "Oyuncu 2 Kazandý";
                    ikincioyuncu++;
                    label5.Text = ikincioyuncu.ToString();
                }

            }
            if (tahta[0, 0] == 1 && tahta[1, 1] == 1 && tahta[2, 2] == 1)
            {
                label1.Text = "Oyuncu 1 Kazandý";
                ilkoyuncu++;
                label4.Text = ilkoyuncu.ToString();
            }
            if (tahta[0, 0] == 2 && tahta[1, 1] == 2 && tahta[2, 2] == 2)
            {
                label1.Text = "Oyuncu 2 Kazandý";
                ikincioyuncu++;
                label5.Text = ikincioyuncu.ToString();
            }
            if (tahta[0, 2] == 1 && tahta[1, 1] == 1 && tahta[2, 0] == 1)
            {
                label1.Text = "Oyuncu 1 Kazandý";
                ilkoyuncu++;
                label4.Text = ilkoyuncu.ToString();
            }
            if (tahta[0, 2] == 2 && tahta[1, 1] == 2 && tahta[2, 0] == 2)
            {
                label1.Text = "Oyuncu 2 Kazandý";
                ikincioyuncu++;
                label5.Text = ikincioyuncu.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button1.Text = "X";
                button1.Enabled = false;
                oyuncusirasi = false;
                tahta[0, 0] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button1.Text = "O";
                button1.Enabled = false;
                oyuncusirasi = true;
                tahta[0, 0] = 2;
            }
            kazanankontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button2.Text = "X";
                button2.Enabled = false;
                oyuncusirasi = false;
                tahta[0, 1] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button2.Text = "O";
                button2.Enabled = false;
                oyuncusirasi = true;
                tahta[0, 1] = 2;
            }
            kazanankontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button3.Text = "X";
                button3.Enabled = false;
                oyuncusirasi = false;
                tahta[0, 2] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button3.Text = "O";
                button3.Enabled = false;
                oyuncusirasi = true;
                tahta[0, 2] = 2;
            }
            kazanankontrol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button4.Text = "X";
                button4.Enabled = false;
                oyuncusirasi = false;
                tahta[1, 0] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button4.Text = "O";
                button4.Enabled = false;
                oyuncusirasi = true;
                tahta[1, 0] = 2;
            }
            kazanankontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button5.Text = "X";
                button5.Enabled = false;
                oyuncusirasi = false;
                tahta[1, 1] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button5.Text = "O";
                button5.Enabled = false;
                oyuncusirasi = true;
                tahta[1, 1] = 2;
            }
            kazanankontrol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button6.Text = "X";
                button6.Enabled = false;
                oyuncusirasi = false;
                tahta[1, 2] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button6.Text = "O";
                button6.Enabled = false;
                oyuncusirasi = true;
                tahta[1, 2] = 2;
            }
            kazanankontrol();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button7.Text = "X";
                button7.Enabled = false;
                oyuncusirasi = false;
                tahta[2, 0] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button7.Text = "O";
                button7.Enabled = false;
                oyuncusirasi = true;
                tahta[2, 0] = 2;
            }
            kazanankontrol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button8.Text = "X";
                button8.Enabled = false;
                oyuncusirasi = false;
                tahta[2, 1] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button8.Text = "O";
                button8.Enabled = false;
                oyuncusirasi = true;
                tahta[2, 1] = 2;
            }
            kazanankontrol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (oyuncusirasi == true)
            {
                button9.Text = "X";
                button9.Enabled = false;
                oyuncusirasi = false;
                tahta[2, 2] = 1;
            }
            else if (oyuncusirasi == false)
            {
                button9.Text = "O";
                button9.Enabled = false;
                oyuncusirasi = true;
                tahta[2, 2] = 2;
            }
            kazanankontrol();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ilkoyuncu = 0;
            ikincioyuncu = 0;
            label4.Text = "";
            label5.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            oyuncusirasi = true;

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tahta[r, c] = 0;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}