namespace BohdanDZ1
{
    public partial class Form1 : Form
    {
        int number;
        string message;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            message = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            try
            {
                number = Int32.Parse(message);
                success = true;
            }
            catch
            {
                MessageBox.Show("Ви ввели текст! Будь ласка введiть число!");
            }
            if (success == true)
            {
                MessageBox.Show("Ви ввели число: " + number);
                success = false;
            }
        }
    }
}