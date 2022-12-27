namespace GetThePassword
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.copyPasswordButton = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.createPasswordButton = new System.Windows.Forms.Button();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lengthMinusButton = new System.Windows.Forms.Button();
            this.lengthPlusButton = new System.Windows.Forms.Button();
            this.selectAllSpecialCharactersButton = new System.Windows.Forms.Button();
            this.resetSpecialCharactersButton = new System.Windows.Forms.Button();
            this.allowUpperLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.allowNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCharactersLabel = new System.Windows.Forms.Label();
            this.specialCharactersTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(21, 181);
            this.passwordTextBox.MaxLength = 32768;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(393, 26);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // copyPasswordButton
            // 
            this.copyPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.copyPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyPasswordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.copyPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyPasswordButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyPasswordButton.ForeColor = System.Drawing.Color.White;
            this.copyPasswordButton.Location = new System.Drawing.Point(296, 213);
            this.copyPasswordButton.Name = "copyPasswordButton";
            this.copyPasswordButton.Size = new System.Drawing.Size(118, 28);
            this.copyPasswordButton.TabIndex = 11;
            this.copyPasswordButton.Text = "Copy";
            this.copyPasswordButton.UseVisualStyleBackColor = false;
            this.copyPasswordButton.Click += new System.EventHandler(this.copyPasswordButton_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(226, 216);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(64, 23);
            this.showPasswordCheckBox.TabIndex = 10;
            this.showPasswordCheckBox.Text = "Show";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // createPasswordButton
            // 
            this.createPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.createPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPasswordButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.createPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPasswordButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createPasswordButton.ForeColor = System.Drawing.Color.White;
            this.createPasswordButton.Location = new System.Drawing.Point(21, 213);
            this.createPasswordButton.Name = "createPasswordButton";
            this.createPasswordButton.Size = new System.Drawing.Size(118, 28);
            this.createPasswordButton.TabIndex = 9;
            this.createPasswordButton.Text = "Create";
            this.createPasswordButton.UseVisualStyleBackColor = false;
            this.createPasswordButton.Click += new System.EventHandler(this.createPasswordButton_Click);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lengthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthTextBox.ForeColor = System.Drawing.Color.White;
            this.lengthTextBox.Location = new System.Drawing.Point(188, 120);
            this.lengthTextBox.MaxLength = 4;
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(47, 26);
            this.lengthTextBox.TabIndex = 5;
            this.lengthTextBox.Text = "16";
            this.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.lengthTextBox_TextChanged);
            this.lengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lengthTextBox_KeyPress);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthLabel.ForeColor = System.Drawing.Color.White;
            this.lengthLabel.Location = new System.Drawing.Point(29, 123);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(153, 19);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Password length:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lengthMinusButton);
            this.panel1.Controls.Add(this.lengthPlusButton);
            this.panel1.Controls.Add(this.selectAllSpecialCharactersButton);
            this.panel1.Controls.Add(this.resetSpecialCharactersButton);
            this.panel1.Controls.Add(this.allowUpperLettersCheckBox);
            this.panel1.Controls.Add(this.allowNumbersCheckBox);
            this.panel1.Controls.Add(this.specialCharactersLabel);
            this.panel1.Controls.Add(this.specialCharactersTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.lengthLabel);
            this.panel1.Controls.Add(this.copyPasswordButton);
            this.panel1.Controls.Add(this.lengthTextBox);
            this.panel1.Controls.Add(this.showPasswordCheckBox);
            this.panel1.Controls.Add(this.createPasswordButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 261);
            this.panel1.TabIndex = 6;
            // 
            // lengthMinusButton
            // 
            this.lengthMinusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lengthMinusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthMinusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.lengthMinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lengthMinusButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthMinusButton.ForeColor = System.Drawing.Color.White;
            this.lengthMinusButton.Location = new System.Drawing.Point(270, 120);
            this.lengthMinusButton.Name = "lengthMinusButton";
            this.lengthMinusButton.Size = new System.Drawing.Size(23, 26);
            this.lengthMinusButton.TabIndex = 7;
            this.lengthMinusButton.Text = "-";
            this.lengthMinusButton.UseVisualStyleBackColor = false;
            this.lengthMinusButton.Click += new System.EventHandler(this.lengthMinusButton_Click);
            // 
            // lengthPlusButton
            // 
            this.lengthPlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lengthPlusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lengthPlusButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.lengthPlusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lengthPlusButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lengthPlusButton.ForeColor = System.Drawing.Color.White;
            this.lengthPlusButton.Location = new System.Drawing.Point(241, 120);
            this.lengthPlusButton.Name = "lengthPlusButton";
            this.lengthPlusButton.Size = new System.Drawing.Size(23, 26);
            this.lengthPlusButton.TabIndex = 6;
            this.lengthPlusButton.Text = "+";
            this.lengthPlusButton.UseVisualStyleBackColor = false;
            this.lengthPlusButton.Click += new System.EventHandler(this.lengthPlusButton_Click);
            // 
            // selectAllSpecialCharactersButton
            // 
            this.selectAllSpecialCharactersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.selectAllSpecialCharactersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAllSpecialCharactersButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.selectAllSpecialCharactersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAllSpecialCharactersButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectAllSpecialCharactersButton.ForeColor = System.Drawing.Color.White;
            this.selectAllSpecialCharactersButton.Location = new System.Drawing.Point(494, 86);
            this.selectAllSpecialCharactersButton.Name = "selectAllSpecialCharactersButton";
            this.selectAllSpecialCharactersButton.Size = new System.Drawing.Size(68, 26);
            this.selectAllSpecialCharactersButton.TabIndex = 4;
            this.selectAllSpecialCharactersButton.Text = "All";
            this.selectAllSpecialCharactersButton.UseVisualStyleBackColor = false;
            this.selectAllSpecialCharactersButton.Click += new System.EventHandler(this.selectAllSpecialCharactersButton_Click);
            // 
            // resetSpecialCharactersButton
            // 
            this.resetSpecialCharactersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.resetSpecialCharactersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetSpecialCharactersButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.resetSpecialCharactersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetSpecialCharactersButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetSpecialCharactersButton.ForeColor = System.Drawing.Color.White;
            this.resetSpecialCharactersButton.Location = new System.Drawing.Point(420, 86);
            this.resetSpecialCharactersButton.Name = "resetSpecialCharactersButton";
            this.resetSpecialCharactersButton.Size = new System.Drawing.Size(68, 26);
            this.resetSpecialCharactersButton.TabIndex = 3;
            this.resetSpecialCharactersButton.Text = "Reset";
            this.resetSpecialCharactersButton.UseVisualStyleBackColor = false;
            this.resetSpecialCharactersButton.Click += new System.EventHandler(this.resetSpecialCharactersButton_Click);
            // 
            // allowUpperLettersCheckBox
            // 
            this.allowUpperLettersCheckBox.AutoSize = true;
            this.allowUpperLettersCheckBox.Checked = true;
            this.allowUpperLettersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowUpperLettersCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allowUpperLettersCheckBox.ForeColor = System.Drawing.Color.White;
            this.allowUpperLettersCheckBox.Location = new System.Drawing.Point(29, 21);
            this.allowUpperLettersCheckBox.Name = "allowUpperLettersCheckBox";
            this.allowUpperLettersCheckBox.Size = new System.Drawing.Size(199, 23);
            this.allowUpperLettersCheckBox.TabIndex = 0;
            this.allowUpperLettersCheckBox.Text = "Allow upper letters";
            this.allowUpperLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowNumbersCheckBox
            // 
            this.allowNumbersCheckBox.AutoSize = true;
            this.allowNumbersCheckBox.Checked = true;
            this.allowNumbersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowNumbersCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allowNumbersCheckBox.ForeColor = System.Drawing.Color.White;
            this.allowNumbersCheckBox.Location = new System.Drawing.Point(29, 55);
            this.allowNumbersCheckBox.Name = "allowNumbersCheckBox";
            this.allowNumbersCheckBox.Size = new System.Drawing.Size(145, 23);
            this.allowNumbersCheckBox.TabIndex = 1;
            this.allowNumbersCheckBox.Text = "Allow numbers";
            this.allowNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCharactersLabel
            // 
            this.specialCharactersLabel.AutoSize = true;
            this.specialCharactersLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialCharactersLabel.ForeColor = System.Drawing.Color.White;
            this.specialCharactersLabel.Location = new System.Drawing.Point(29, 89);
            this.specialCharactersLabel.Name = "specialCharactersLabel";
            this.specialCharactersLabel.Size = new System.Drawing.Size(153, 19);
            this.specialCharactersLabel.TabIndex = 7;
            this.specialCharactersLabel.Text = "Include symbols:";
            // 
            // specialCharactersTextBox
            // 
            this.specialCharactersTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.specialCharactersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.specialCharactersTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.specialCharactersTextBox.ForeColor = System.Drawing.Color.White;
            this.specialCharactersTextBox.Location = new System.Drawing.Point(188, 86);
            this.specialCharactersTextBox.MaxLength = 32;
            this.specialCharactersTextBox.Name = "specialCharactersTextBox";
            this.specialCharactersTextBox.Size = new System.Drawing.Size(226, 26);
            this.specialCharactersTextBox.TabIndex = 2;
            this.specialCharactersTextBox.Text = "!\"#$%&\'()*+,-./";
            this.specialCharactersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(603, 282);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GetThePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox passwordTextBox;
        private Button copyPasswordButton;
        private CheckBox showPasswordCheckBox;
        private Button createPasswordButton;
        private TextBox lengthTextBox;
        private Label lengthLabel;
        private Panel panel1;
        private TextBox specialCharactersTextBox;
        private Label specialCharactersLabel;
        private CheckBox allowUpperLettersCheckBox;
        private CheckBox allowNumbersCheckBox;
        private Button selectAllSpecialCharactersButton;
        private Button resetSpecialCharactersButton;
        private Button lengthMinusButton;
        private Button lengthPlusButton;
    }
}