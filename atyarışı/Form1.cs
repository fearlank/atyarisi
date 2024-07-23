using System.Diagnostics.Eventing.Reader;

namespace atyarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1sol, at2sol, at3sol;

        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            at1sol = pictureBox1.Left;
            at2sol = pictureBox2.Left;
            at3sol = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayaç = Convert.ToInt32(label7.Text);
            sayaç++;
            label7.Text = sayaç.ToString();
            int at1genişlik = pictureBox1.Width;
            int at2genişlik = pictureBox2.Width;
            int at3genişlik = pictureBox3.Width;

            int bituzaklık = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rand.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rand.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rand.Next(5, 15);


            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "bir numaraları at önde";
            }
            else if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "iki numaralı at önde";
            }
            else label6.Text = "üç numaralı at önde";
             


            if (at1genişlik + pictureBox1.Left >= bituzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("birinci at kazandı");
            }
            else if (at2genişlik + pictureBox2.Left >= bituzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("2.at kazandı");
            }
            else if (at3genişlik + pictureBox3.Left >= bituzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. at kazandı");
            }
             

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
