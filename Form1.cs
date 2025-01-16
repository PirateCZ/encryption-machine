using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher_App
{
    public partial class EncryptMachineForm : Form
    {
        EncryptMachine machine = new EncryptMachine();
        Random rnd = new Random();
        List<char> onlyOneAppearanceList; //error handling
        public EncryptMachineForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (encryptionTypeSelector.Text == "" || textToEncryptBox.Text == "")
            {
                errorLabel.Text = "Select values";
                errorLabel.Show();
                return;
            }

            //asc error handling
            else if (encryptionTypeSelector.Text == "Monoalphabetic Substitution Cipher")
            {
                if (ASCKeyTextBox.TextLength < 26)
                {
                    errorLabel.Text = "Key is too short";
                    errorLabel.Show();
                    return;
                }
                onlyOneAppearanceList = new List<char>();
                for(int i = 0; i < ASCKeyTextBox.TextLength; ++i)
                {
                    if (!onlyOneAppearanceList.Contains(ASCKeyTextBox.Text[i]))
                    {
                        onlyOneAppearanceList.Add(ASCKeyTextBox.Text[i]);
                        errorLabel.Hide();
                    }
                    else
                    {
                        errorLabel.Text = $"You have multiple letters in your key({ASCKeyTextBox.Text[i]})";
                        errorLabel.Show();
                        return;
                    }
                }
            }
            if (encryptionTypeSelector.Text == "Vigenère cipher")
            {
                if (vigenereKeyTextBox.TextLength < 2)
                {
                    errorLabel.Text = "Key must be longer than 2 characters";
                    errorLabel.Show();
                    return;
                }
                else errorLabel.Hide();
                }
            else errorLabel.Hide();


            machine.SetVariables(
                encryptionTypeSelector.Text, textToEncryptBox.Text,

                (int)caesarShift.Value,

                ASCKeyTextBox.Text,

                vigenereKeyTextBox.Text
            );

            if (!decryptRadioButton.Checked) 
                machine.Encrypt();
            else
                machine.Decrypt();
            
            machine.ShowWord(ref outputLabel);
        }

        private void encryptionTypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            caesarShift.Hide();
            caesarShiftLabel.Hide();

            ASCLabel.Hide();
            ASCLetterCounter.Hide();
            ASCKeyTextBox.Hide();
            ASCKeyRandomizerButton.Hide();

            vigenereKeyLabel.Hide();
            vigenereKeyTextBox.Hide();

            if (encryptionTypeSelector.Text == "Caesar Cipher")
            {
                caesarShift.Show();
                caesarShiftLabel.Show();
            }

            else if (encryptionTypeSelector.Text == "Monoalphabetic Substitution Cipher")
            {
                ASCLabel.Show();
                ASCLetterCounter.Show();
                ASCKeyTextBox.Show();
                ASCKeyRandomizerButton.Show();
            }
            else if (encryptionTypeSelector.Text == "Vigenère cipher")
            {
                vigenereKeyLabel.Show();
                vigenereKeyTextBox.Show();
            }
        }

        private void ASCKeyRandomizerButton_Click(object sender, EventArgs e)
        {

            char[] charArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < 100; i++){
                int index1 = rnd.Next(0, charArray.Length);
                int index2 = rnd.Next(0, charArray.Length);

                (charArray[index1], charArray[index2]) = (charArray[index2], charArray[index1]);
            }

            ASCKeyTextBox.Text = new string(charArray);

        }

        private void ASCKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ASCKeyTextBox.TextLength > 26)
            {
                ASCKeyTextBox.Text = ASCKeyTextBox.Text.Substring(0, 26);
            }
            ASCLetterCounter.Text = $"{ASCKeyTextBox.TextLength}/26";
            ASCKeyTextBox.Select(ASCKeyTextBox.TextLength, 0);
            ASCKeyTextBox.ScrollToCaret();
        }
    }
}
