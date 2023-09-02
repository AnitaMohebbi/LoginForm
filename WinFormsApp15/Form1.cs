namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBox3.Text;
            if(!isvalid(userinput))
            {
                MessageBox.Show("your phone number is not valid!");
                textBox3.Clear();
            }
            else
            {
                string userinput2 = textBox4.Text;
                int n;
                bool isnumber = int.TryParse(userinput2, out n);
                if (isnumber==false)
                {
                    MessageBox.Show("use only 'number' for your NN");
                    textBox4.Clear();
                }
                else
                {
                    if(userinput.StartsWith("+"))
                    {
                        userinput = userinput.Remove(0, 2);
                        userinput = userinput.Replace('8', '0');
                        MessageBox.Show($"Fullname:{textBox1.Text},PhoneNumber:{userinput},NationalNumber:{textBox4.Text},Gender:{textBox5.Text}");
                    }
                    else
                    {
                        MessageBox.Show($"Fullname:{textBox1.Text},PhoneNumber:{textBox3.Text},NationalNumber:{textBox4.Text},Gender:{textBox5.Text}");
                    }
                }
            }
        }
        private bool isvalid(string input)
        {
            return input.Length >= 11;
        }
    }
}