namespace WinFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(txtUserName.Text))
            {
                MessageBox.Show("Введіть ваше ім'я!", "Потрібне ім'я",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Вітаємо, {txtUserName.Text}!", "Вітаємо!",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnToRunawayBtn_Click(object sender, EventArgs e)
        {
            RunawayButtonForm form = new RunawayButtonForm();
            form.ShowDialog();
        }
    }
}
