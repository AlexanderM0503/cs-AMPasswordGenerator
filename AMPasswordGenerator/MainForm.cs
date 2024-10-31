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
            this.Location = new Point(Properties.Settings.Default.positionX, Properties.Settings.Default.positionY);
            this.Size = new Size(Properties.Settings.Default.width, Properties.Settings.Default.height);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.positionX = this.Location.X;
            Properties.Settings.Default.positionY = this.Location.Y;
            Properties.Settings.Default.width = this.Size.Width;
            Properties.Settings.Default.height = this.Size.Height;
            Properties.Settings.Default.Save();
        }

        private void mainFormMenuDefault_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.positionX = 25;
            Properties.Settings.Default.positionY = 25;
            Properties.Settings.Default.width = 350;
            Properties.Settings.Default.height = 570;
            Properties.Settings.Default.Save();

            this.Location = new Point(Properties.Settings.Default.positionX, Properties.Settings.Default.positionY);
            this.Size = new Size(Properties.Settings.Default.width, Properties.Settings.Default.height);
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
