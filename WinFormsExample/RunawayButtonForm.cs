namespace WinFormsExample
{
    public partial class RunawayButtonForm : Form
    {
        Random rnd = new Random();

        public RunawayButtonForm()
        {
            InitializeComponent();
        }

        private void btnRunaway_MouseEnter(object sender, EventArgs e)
        {
            int xPos = rnd.Next(0, this.Size.Width - btnRunaway.Width);
            int yPos = rnd.Next(0, this.Size.Height - btnRunaway.Height);

            btnRunaway.Location = new Point(xPos, yPos);
        }
    }
}
