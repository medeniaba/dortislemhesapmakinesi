namespace Arayüzlühesapmakinesi
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int s1, s2, cikarma;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);

            cikarma = s1 - s2;

            textBox4.Text = cikarma.ToString();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);

            toplam = s1 + s2;

            textBox4.Text = toplam.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double s1, s2, bölme;
            s1 = Double.Parse(textBox1.Text);
            s2 = Double.Parse(textBox2.Text);

            bölme = s1 / s2;

            textBox4.Text = bölme.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {


            int s1, s2, carpma;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);

            carpma = s1 * s2;

            textBox4.Text = carpma.ToString();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}