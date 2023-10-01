namespace WinFormAge
{
    public partial class Form1 : Form
    {
        private object console;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int current = DateTime.Today.Year - DateTimePicker.Value.Year;

             textBox1.Text = current.ToString()+ ' ' + "ans";
            
        }
    }
}