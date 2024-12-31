namespace TestingEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            panel1.ForeColor = Color.Cornsilk;
        }
    }
}
