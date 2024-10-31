namespace AMPasswordGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainFormMenu = new MenuStrip();
            mainFormMenuFile = new ToolStripMenuItem();
            mainFormMenuDefault = new ToolStripMenuItem();
            mainFormMenuSeparator1 = new ToolStripSeparator();
            mainFormMenuExit = new ToolStripMenuItem();
            mainFormMenuHelp = new ToolStripMenuItem();
            mainFormMenuAbout = new ToolStripMenuItem();
            groupNumChars = new GroupBox();
            buttonSet12 = new Button();
            buttonSet8 = new Button();
            buttonSet4 = new Button();
            numChars = new NumericUpDown();
            groupCharTypes = new GroupBox();
            spChar = new CheckBox();
            digit = new CheckBox();
            charLow = new CheckBox();
            charUp = new CheckBox();
            groupPassword = new GroupBox();
            buttonGenPassword = new Button();
            passwordString = new TextBox();
            mainFormMenu.SuspendLayout();
            groupNumChars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numChars).BeginInit();
            groupCharTypes.SuspendLayout();
            groupPassword.SuspendLayout();
            SuspendLayout();
            // 
            // mainFormMenu
            // 
            mainFormMenu.Items.AddRange(new ToolStripItem[] { mainFormMenuFile, mainFormMenuHelp });
            mainFormMenu.Location = new Point(0, 0);
            mainFormMenu.Name = "mainFormMenu";
            mainFormMenu.Size = new Size(334, 24);
            mainFormMenu.TabIndex = 0;
            mainFormMenu.Text = "menuStrip1";
            // 
            // mainFormMenuFile
            // 
            mainFormMenuFile.DropDownItems.AddRange(new ToolStripItem[] { mainFormMenuDefault, mainFormMenuSeparator1, mainFormMenuExit });
            mainFormMenuFile.Name = "mainFormMenuFile";
            mainFormMenuFile.Size = new Size(48, 20);
            mainFormMenuFile.Text = "Файл";
            // 
            // mainFormMenuDefault
            // 
            mainFormMenuDefault.Name = "mainFormMenuDefault";
            mainFormMenuDefault.Size = new Size(224, 22);
            mainFormMenuDefault.Text = "Параметры по умолчанию";
            // 
            // mainFormMenuSeparator1
            // 
            mainFormMenuSeparator1.Name = "mainFormMenuSeparator1";
            mainFormMenuSeparator1.Size = new Size(221, 6);
            // 
            // mainFormMenuExit
            // 
            mainFormMenuExit.Name = "mainFormMenuExit";
            mainFormMenuExit.Size = new Size(224, 22);
            mainFormMenuExit.Text = "Выход";
            mainFormMenuExit.Click += mainFormMenuExit_Click;
            // 
            // mainFormMenuHelp
            // 
            mainFormMenuHelp.DropDownItems.AddRange(new ToolStripItem[] { mainFormMenuAbout });
            mainFormMenuHelp.Name = "mainFormMenuHelp";
            mainFormMenuHelp.Size = new Size(65, 20);
            mainFormMenuHelp.Text = "Справка";
            // 
            // mainFormMenuAbout
            // 
            mainFormMenuAbout.Name = "mainFormMenuAbout";
            mainFormMenuAbout.Size = new Size(149, 22);
            mainFormMenuAbout.Text = "О программе";
            // 
            // groupNumChars
            // 
            groupNumChars.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupNumChars.Controls.Add(buttonSet12);
            groupNumChars.Controls.Add(buttonSet8);
            groupNumChars.Controls.Add(buttonSet4);
            groupNumChars.Controls.Add(numChars);
            groupNumChars.Location = new Point(12, 40);
            groupNumChars.Name = "groupNumChars";
            groupNumChars.Size = new Size(310, 115);
            groupNumChars.TabIndex = 1;
            groupNumChars.TabStop = false;
            groupNumChars.Text = "Количество символов";
            // 
            // buttonSet12
            // 
            buttonSet12.Location = new Point(229, 73);
            buttonSet12.Name = "buttonSet12";
            buttonSet12.Size = new Size(75, 23);
            buttonSet12.TabIndex = 3;
            buttonSet12.Text = "12";
            buttonSet12.UseVisualStyleBackColor = true;
            buttonSet12.Click += buttonSet12_Click;
            // 
            // buttonSet8
            // 
            buttonSet8.Location = new Point(116, 73);
            buttonSet8.Name = "buttonSet8";
            buttonSet8.Size = new Size(75, 23);
            buttonSet8.TabIndex = 2;
            buttonSet8.Text = "8";
            buttonSet8.UseVisualStyleBackColor = true;
            buttonSet8.Click += buttonSet8_Click;
            // 
            // buttonSet4
            // 
            buttonSet4.Location = new Point(6, 73);
            buttonSet4.Name = "buttonSet4";
            buttonSet4.Size = new Size(75, 23);
            buttonSet4.TabIndex = 1;
            buttonSet4.Text = "4";
            buttonSet4.UseVisualStyleBackColor = true;
            buttonSet4.Click += buttonSet4_Click;
            // 
            // numChars
            // 
            numChars.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numChars.Location = new Point(6, 35);
            numChars.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numChars.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numChars.Name = "numChars";
            numChars.Size = new Size(298, 23);
            numChars.TabIndex = 0;
            numChars.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // groupCharTypes
            // 
            groupCharTypes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupCharTypes.Controls.Add(spChar);
            groupCharTypes.Controls.Add(digit);
            groupCharTypes.Controls.Add(charLow);
            groupCharTypes.Controls.Add(charUp);
            groupCharTypes.Location = new Point(12, 181);
            groupCharTypes.Name = "groupCharTypes";
            groupCharTypes.Size = new Size(310, 186);
            groupCharTypes.TabIndex = 2;
            groupCharTypes.TabStop = false;
            groupCharTypes.Text = "Типы символов";
            // 
            // spChar
            // 
            spChar.AutoSize = true;
            spChar.Checked = true;
            spChar.CheckState = CheckState.Checked;
            spChar.Location = new Point(20, 152);
            spChar.Name = "spChar";
            spChar.Size = new Size(156, 19);
            spChar.TabIndex = 3;
            spChar.Text = "Специальные символы";
            spChar.UseVisualStyleBackColor = true;
            // 
            // digit
            // 
            digit.AutoSize = true;
            digit.Checked = true;
            digit.CheckState = CheckState.Checked;
            digit.Location = new Point(20, 110);
            digit.Name = "digit";
            digit.Size = new Size(67, 19);
            digit.TabIndex = 2;
            digit.Text = "Цифры";
            digit.UseVisualStyleBackColor = true;
            // 
            // charLow
            // 
            charLow.AutoSize = true;
            charLow.Checked = true;
            charLow.CheckState = CheckState.Checked;
            charLow.Location = new Point(20, 72);
            charLow.Name = "charLow";
            charLow.Size = new Size(161, 19);
            charLow.TabIndex = 1;
            charLow.Text = "Буквы (нижний регистр)";
            charLow.UseVisualStyleBackColor = true;
            // 
            // charUp
            // 
            charUp.AutoSize = true;
            charUp.Checked = true;
            charUp.CheckState = CheckState.Checked;
            charUp.Location = new Point(20, 35);
            charUp.Name = "charUp";
            charUp.Size = new Size(163, 19);
            charUp.TabIndex = 0;
            charUp.Text = "Буквы (верхний регистр)";
            charUp.UseVisualStyleBackColor = true;
            // 
            // groupPassword
            // 
            groupPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupPassword.Controls.Add(buttonGenPassword);
            groupPassword.Controls.Add(passwordString);
            groupPassword.Location = new Point(12, 392);
            groupPassword.Name = "groupPassword";
            groupPassword.Size = new Size(310, 127);
            groupPassword.TabIndex = 3;
            groupPassword.TabStop = false;
            groupPassword.Text = "Пароль";
            // 
            // buttonGenPassword
            // 
            buttonGenPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonGenPassword.Location = new Point(6, 81);
            buttonGenPassword.Name = "buttonGenPassword";
            buttonGenPassword.Size = new Size(298, 31);
            buttonGenPassword.TabIndex = 1;
            buttonGenPassword.Text = "Сгенерировать";
            buttonGenPassword.UseVisualStyleBackColor = true;
            buttonGenPassword.Click += buttonGenPassword_Click;
            // 
            // passwordString
            // 
            passwordString.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordString.Location = new Point(6, 37);
            passwordString.Name = "passwordString";
            passwordString.ReadOnly = true;
            passwordString.Size = new Size(298, 23);
            passwordString.TabIndex = 0;
            passwordString.Text = "Здесь будет Ваш пароль...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 531);
            Controls.Add(groupPassword);
            Controls.Add(groupCharTypes);
            Controls.Add(groupNumChars);
            Controls.Add(mainFormMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainFormMenu;
            Name = "MainForm";
            Text = "AMPasswordGenerator";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            mainFormMenu.ResumeLayout(false);
            mainFormMenu.PerformLayout();
            groupNumChars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numChars).EndInit();
            groupCharTypes.ResumeLayout(false);
            groupCharTypes.PerformLayout();
            groupPassword.ResumeLayout(false);
            groupPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainFormMenu;
        private ToolStripMenuItem mainFormMenuFile;
        private ToolStripMenuItem mainFormMenuDefault;
        private ToolStripSeparator mainFormMenuSeparator1;
        private ToolStripMenuItem mainFormMenuExit;
        private ToolStripMenuItem mainFormMenuHelp;
        private ToolStripMenuItem mainFormMenuAbout;
        private GroupBox groupNumChars;
        private Button buttonSet12;
        private Button buttonSet8;
        private Button buttonSet4;
        private NumericUpDown numChars;
        private GroupBox groupCharTypes;
        private CheckBox spChar;
        private CheckBox digit;
        private CheckBox charLow;
        private CheckBox charUp;
        private GroupBox groupPassword;
        private Button buttonGenPassword;
        private TextBox passwordString;
    }
}
