namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue=0;
        String operationPerformed="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            
                

            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed=button.Text;
            resultValue=Double.Parse(textBox_Result.Text);  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void clear(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;    
        }
    }
}