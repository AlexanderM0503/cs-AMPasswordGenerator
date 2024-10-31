namespace AMPasswordGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void mainFormMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSet4_Click(object sender, EventArgs e)
        {
            numChars.Value = 4;
        }

        private void buttonSet8_Click(object sender, EventArgs e)
        {
            numChars.Value = 8;
        }

        private void buttonSet12_Click(object sender, EventArgs e)
        {
            numChars.Value = 12;
        }

        private void buttonGenPassword_Click(object sender, EventArgs e)
        {
            if (charUp.Checked | charLow.Checked | digit.Checked | spChar.Checked)
            {
                PasswordGenerator passwordGenerator = new PasswordGenerator();
                passwordString.Text = passwordGenerator.GetPasswordString(charUp.Checked, charLow.Checked, digit.Checked, spChar.Checked, Convert.ToInt32(numChars.Value));
            }
            else
            {
                passwordString.Text = "Не выбраны типы символов";
            }
        }
    }
}
