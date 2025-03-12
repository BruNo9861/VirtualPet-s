namespace aplicação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Remove a borda da janela
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X + 10, Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Olá, Mundo!";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
