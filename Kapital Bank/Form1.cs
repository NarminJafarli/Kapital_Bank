namespace Kapital_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pin = { 1122,2211 };

            if (textBox1.Text == pin[0].ToString())
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                label8.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
