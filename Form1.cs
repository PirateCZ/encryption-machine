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
        public EncryptMachineForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // well first we have to asing variables 
            //then we either encrypt or decrypt
            //then we show ouptut very simple reasoning 

            if (encryptionTypeSelector.Text == "" || textToEncryptBox.Text == "")
            {
                errorLabel.Text = "Select values";
                errorLabel.Show();
            } else errorLabel.Hide();

            machine.SetVariables(
                encryptionTypeSelector.Text, textToEncryptBox.Text,

                (int)caesarShift.Value

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


            if (encryptionTypeSelector.Text == "Caesar Cipher")
            {
                caesarShift.Show();
                caesarShiftLabel.Show();
            }
        }
    }
}
