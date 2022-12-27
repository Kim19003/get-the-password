using System.Collections.ObjectModel;
using System.Security.Cryptography;
using Helpers.Extensions;
using DataTransfer = Windows.ApplicationModel.DataTransfer;

namespace GetThePassword
{
    public partial class Form1 : Form
    {
        const char passwordChar = '*';

        readonly string defaultSpecialCharacters = "!\"#$%&'()*+,-./";
        readonly string allSpecialCharacters = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`";

        readonly int[] numbersASCIICodes = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        readonly int[] upperLettersASCIICodes = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        readonly int[] lowerLettersASCIICodes = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        // readonly int[] specialCharactersASCIICodes = { '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`' };

        readonly RandomNumberGenerator random = RandomNumberGenerator.Create();

        readonly ReadOnlyCollection<int> readyPasswordLengths = new(new List<int>() { 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768 });

        public Form1()
        {
            InitializeComponent();

            MaximizeBox = false;

            passwordTextBox.PasswordChar = passwordChar;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.AllowUpperLetters = allowUpperLettersCheckBox.Checked;
            Properties.Settings.Default.AllowNumbers = allowNumbersCheckBox.Checked;
            Properties.Settings.Default.IncludeSymbols = specialCharactersTextBox.Text.Trim();
            Properties.Settings.Default.PasswordLength = !string.IsNullOrEmpty(lengthTextBox.Text) ? int.Parse(lengthTextBox.Text) : 0;

            Properties.Settings.Default.Save();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Location = new Point(Properties.Settings.Default.Location.X, Properties.Settings.Default.Location.Y);
            allowUpperLettersCheckBox.Checked = Properties.Settings.Default.AllowUpperLetters;
            allowNumbersCheckBox.Checked = Properties.Settings.Default.AllowNumbers;
            specialCharactersTextBox.Text = Properties.Settings.Default.IncludeSymbols;
            lengthTextBox.Text = Properties.Settings.Default.PasswordLength.ToString();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = passwordChar;
            }
        }

        private void copyPasswordButton_Click(object sender, EventArgs e)
        {
            DataTransfer.DataPackage dataPackage = new();
            dataPackage.SetText(passwordTextBox.Text);

            DataTransfer.Clipboard.SetContentWithOptions(dataPackage, new()
            {
                IsAllowedInHistory = false
            });
        }

        private void createPasswordButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lengthTextBox.Text))
            {
                Cursor.Current = Cursors.WaitCursor;

                passwordTextBox.Text = "";

                char[] insertedSpecialCharacters = !string.IsNullOrEmpty(specialCharactersTextBox.Text.Trim()) ? specialCharactersTextBox.Text.Trim().ToCharArray() : Array.Empty<char>();

                int passwordLength = int.Parse(lengthTextBox.Text);

                for (int i = 0; i < passwordLength; i++)
                {
                    while (true)
                    {
                        int randomASCIICode = random.Next(0, 127);

                        if (allowNumbersCheckBox.Checked && numbersASCIICodes.Contains(randomASCIICode) ||
                            allowUpperLettersCheckBox.Checked && upperLettersASCIICodes.Contains(randomASCIICode) ||
                            insertedSpecialCharacters.Length > 0 && insertedSpecialCharacters.Select(c => (int)c).Contains(randomASCIICode) ||
                            lowerLettersASCIICodes.Contains(randomASCIICode))
                        {
                            passwordTextBox.Text += (char)randomASCIICode;

                            break;
                        }
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void lengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void resetSpecialCharactersButton_Click(object sender, EventArgs e)
        {
            specialCharactersTextBox.Text = defaultSpecialCharacters;
        }

        private void selectAllSpecialCharactersButton_Click(object sender, EventArgs e)
        {
            specialCharactersTextBox.Text = allSpecialCharacters;
        }

        private void lengthPlusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lengthTextBox.Text))
            {
                int passwordLength = int.Parse(lengthTextBox.Text);

                if (!readyPasswordLengths.Contains(passwordLength))
                {
                    passwordLength = readyPasswordLengths.GetNextClosest(passwordLength);
                }
                else
                {
                    passwordLength = readyPasswordLengths.GetNextClosest(passwordLength * 2 - 1);
                }

                lengthTextBox.Text = passwordLength.ToString();
            }
        }

        private void lengthMinusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lengthTextBox.Text))
            {
                int passwordLength = int.Parse(lengthTextBox.Text);

                if (!readyPasswordLengths.Contains(passwordLength))
                {
                    passwordLength = readyPasswordLengths.GetPreviousClosest(passwordLength);
                }
                else
                {
                    passwordLength = readyPasswordLengths.GetPreviousClosest(passwordLength / 2 + 1);
                }

                lengthTextBox.Text = passwordLength.ToString();
            }
        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lengthTextBox.Text))
            {
                lengthTextBox.Text = int.Parse(lengthTextBox.Text) > 0 ? lengthTextBox.Text : 0.ToString();
            }
        }
    }
}