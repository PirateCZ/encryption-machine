namespace Cipher_App
{
    partial class EncryptMachineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encryptionTypeSelector = new System.Windows.Forms.ComboBox();
            this.encryptMachineLabel = new System.Windows.Forms.Label();
            this.encryptionSelectLabel = new System.Windows.Forms.Label();
            this.textToEncryptBox = new System.Windows.Forms.TextBox();
            this.textToEncryptLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.caesarShiftLabel = new System.Windows.Forms.Label();
            this.caesarShift = new System.Windows.Forms.NumericUpDown();
            this.ASCKeyTextBox = new System.Windows.Forms.TextBox();
            this.ASCLabel = new System.Windows.Forms.Label();
            this.ASCKeyRandomizerButton = new System.Windows.Forms.Button();
            this.ASCLetterCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caesarShift)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptionTypeSelector
            // 
            this.encryptionTypeSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptionTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptionTypeSelector.FormattingEnabled = true;
            this.encryptionTypeSelector.ItemHeight = 16;
            this.encryptionTypeSelector.Items.AddRange(new object[] {
            "Caesar Cipher",
            "Monoalphabetic Substitution Cipher",
            "Atbash Cipher",
            "RSA",
            "Enigma"});
            this.encryptionTypeSelector.Location = new System.Drawing.Point(340, 140);
            this.encryptionTypeSelector.MaximumSize = new System.Drawing.Size(120, 0);
            this.encryptionTypeSelector.Name = "encryptionTypeSelector";
            this.encryptionTypeSelector.Size = new System.Drawing.Size(120, 24);
            this.encryptionTypeSelector.TabIndex = 0;
            this.encryptionTypeSelector.SelectedIndexChanged += new System.EventHandler(this.encryptionTypeSelector_SelectedIndexChanged);
            // 
            // encryptMachineLabel
            // 
            this.encryptMachineLabel.AutoSize = true;
            this.encryptMachineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encryptMachineLabel.Location = new System.Drawing.Point(242, 42);
            this.encryptMachineLabel.MinimumSize = new System.Drawing.Size(340, 50);
            this.encryptMachineLabel.Name = "encryptMachineLabel";
            this.encryptMachineLabel.Size = new System.Drawing.Size(340, 50);
            this.encryptMachineLabel.TabIndex = 1;
            this.encryptMachineLabel.Text = "Encrypt Machine";
            // 
            // encryptionSelectLabel
            // 
            this.encryptionSelectLabel.AutoSize = true;
            this.encryptionSelectLabel.Location = new System.Drawing.Point(340, 120);
            this.encryptionSelectLabel.Name = "encryptionSelectLabel";
            this.encryptionSelectLabel.Size = new System.Drawing.Size(122, 17);
            this.encryptionSelectLabel.TabIndex = 2;
            this.encryptionSelectLabel.Text = "Select Encryption ";
            // 
            // textToEncryptBox
            // 
            this.textToEncryptBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textToEncryptBox.Location = new System.Drawing.Point(340, 200);
            this.textToEncryptBox.Name = "textToEncryptBox";
            this.textToEncryptBox.Size = new System.Drawing.Size(120, 23);
            this.textToEncryptBox.TabIndex = 3;
            // 
            // textToEncryptLabel
            // 
            this.textToEncryptLabel.AutoSize = true;
            this.textToEncryptLabel.Location = new System.Drawing.Point(340, 178);
            this.textToEncryptLabel.Name = "textToEncryptLabel";
            this.textToEncryptLabel.Size = new System.Drawing.Size(72, 17);
            this.textToEncryptLabel.TabIndex = 4;
            this.textToEncryptLabel.Text = "Your text: ";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.outputLabel.Location = new System.Drawing.Point(242, 443);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(316, 46);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Your output here";
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Checked = true;
            this.encryptRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptRadioButton.Location = new System.Drawing.Point(340, 299);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(77, 21);
            this.encryptRadioButton.TabIndex = 6;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "Encrypt";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptRadioButton.Location = new System.Drawing.Point(340, 326);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(78, 21);
            this.decryptRadioButton.TabIndex = 7;
            this.decryptRadioButton.Text = "Decrypt";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(340, 372);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(520, 147);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(40, 17);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Error";
            this.errorLabel.Visible = false;
            // 
            // caesarShiftLabel
            // 
            this.caesarShiftLabel.AutoSize = true;
            this.caesarShiftLabel.Location = new System.Drawing.Point(515, 206);
            this.caesarShiftLabel.Name = "caesarShiftLabel";
            this.caesarShiftLabel.Size = new System.Drawing.Size(77, 17);
            this.caesarShiftLabel.TabIndex = 10;
            this.caesarShiftLabel.Text = "Select shift";
            this.caesarShiftLabel.Visible = false;
            // 
            // caesarShift
            // 
            this.caesarShift.Location = new System.Drawing.Point(518, 226);
            this.caesarShift.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.caesarShift.Name = "caesarShift";
            this.caesarShift.Size = new System.Drawing.Size(120, 23);
            this.caesarShift.TabIndex = 11;
            this.caesarShift.Visible = false;
            // 
            // ASCKeyTextBox
            // 
            this.ASCKeyTextBox.Location = new System.Drawing.Point(518, 276);
            this.ASCKeyTextBox.Name = "ASCKeyTextBox";
            this.ASCKeyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ASCKeyTextBox.Size = new System.Drawing.Size(204, 23);
            this.ASCKeyTextBox.TabIndex = 12;
            this.ASCKeyTextBox.Visible = false;
            this.ASCKeyTextBox.TextChanged += new System.EventHandler(this.ASCKeyTextBox_TextChanged);
            // 
            // ASCLabel
            // 
            this.ASCLabel.AutoSize = true;
            this.ASCLabel.Location = new System.Drawing.Point(518, 256);
            this.ASCLabel.Name = "ASCLabel";
            this.ASCLabel.Size = new System.Drawing.Size(73, 17);
            this.ASCLabel.TabIndex = 13;
            this.ASCLabel.Text = "Select key";
            this.ASCLabel.Visible = false;
            // 
            // ASCKeyRandomizerButton
            // 
            this.ASCKeyRandomizerButton.Location = new System.Drawing.Point(729, 275);
            this.ASCKeyRandomizerButton.Name = "ASCKeyRandomizerButton";
            this.ASCKeyRandomizerButton.Size = new System.Drawing.Size(25, 25);
            this.ASCKeyRandomizerButton.TabIndex = 14;
            this.ASCKeyRandomizerButton.Text = "R";
            this.ASCKeyRandomizerButton.UseVisualStyleBackColor = true;
            this.ASCKeyRandomizerButton.Visible = false;
            this.ASCKeyRandomizerButton.Click += new System.EventHandler(this.ASCKeyRandomizerButton_Click);
            // 
            // ASCLetterCounter
            // 
            this.ASCLetterCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ASCLetterCounter.AutoSize = true;
            this.ASCLetterCounter.Location = new System.Drawing.Point(686, 256);
            this.ASCLetterCounter.Name = "ASCLetterCounter";
            this.ASCLetterCounter.Size = new System.Drawing.Size(36, 17);
            this.ASCLetterCounter.TabIndex = 15;
            this.ASCLetterCounter.Text = "0/26";
            this.ASCLetterCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ASCLetterCounter.Visible = false;
            // 
            // EncryptMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.ASCLetterCounter);
            this.Controls.Add(this.ASCKeyRandomizerButton);
            this.Controls.Add(this.ASCLabel);
            this.Controls.Add(this.ASCKeyTextBox);
            this.Controls.Add(this.caesarShift);
            this.Controls.Add(this.caesarShiftLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.decryptRadioButton);
            this.Controls.Add(this.encryptRadioButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.textToEncryptLabel);
            this.Controls.Add(this.textToEncryptBox);
            this.Controls.Add(this.encryptionSelectLabel);
            this.Controls.Add(this.encryptMachineLabel);
            this.Controls.Add(this.encryptionTypeSelector);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EncryptMachineForm";
            this.Text = "Encrypt Machine";
            ((System.ComponentModel.ISupportInitialize)(this.caesarShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox encryptionTypeSelector;
        private System.Windows.Forms.Label encryptMachineLabel;
        private System.Windows.Forms.Label encryptionSelectLabel;
        private System.Windows.Forms.TextBox textToEncryptBox;
        private System.Windows.Forms.Label textToEncryptLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label caesarShiftLabel;
        private System.Windows.Forms.NumericUpDown caesarShift;
        private System.Windows.Forms.TextBox ASCKeyTextBox;
        private System.Windows.Forms.Label ASCLabel;
        private System.Windows.Forms.Button ASCKeyRandomizerButton;
        private System.Windows.Forms.Label ASCLetterCounter;
    }
}

