namespace ProductionManagementSystem
{
    partial class AddEmployee
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEmployeeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.peselMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.peselLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.depLabel = new System.Windows.Forms.Label();
            this.depComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmployeeLabel
            // 
            this.addEmployeeLabel.AutoSize = true;
            this.addEmployeeLabel.Location = new System.Drawing.Point(26, 42);
            this.addEmployeeLabel.Name = "addEmployeeLabel";
            this.addEmployeeLabel.Size = new System.Drawing.Size(202, 15);
            this.addEmployeeLabel.TabIndex = 0;
            this.addEmployeeLabel.Text = "Wprowadź dane nowego pracownika";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(130, 60);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 2;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(130, 147);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 23);
            this.addressBox.TabIndex = 2;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(130, 176);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 23);
            this.dateBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(130, 89);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 23);
            this.surnameBox.TabIndex = 2;
            // 
            // peselMaskedBox
            // 
            this.peselMaskedBox.Location = new System.Drawing.Point(130, 118);
            this.peselMaskedBox.Mask = "00000000000";
            this.peselMaskedBox.Name = "peselMaskedBox";
            this.peselMaskedBox.Size = new System.Drawing.Size(100, 23);
            this.peselMaskedBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(30, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Imię";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(26, 93);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(57, 15);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.Location = new System.Drawing.Point(26, 122);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(38, 15);
            this.peselLabel.TabIndex = 6;
            this.peselLabel.Text = "PESEL";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(26, 150);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(37, 15);
            this.adressLabel.TabIndex = 7;
            this.adressLabel.Text = "Adres";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(26, 179);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(86, 15);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Data urodzenia";
            // 
            // depLabel
            // 
            this.depLabel.AutoSize = true;
            this.depLabel.Location = new System.Drawing.Point(280, 101);
            this.depLabel.Name = "depLabel";
            this.depLabel.Size = new System.Drawing.Size(76, 15);
            this.depLabel.TabIndex = 9;
            this.depLabel.Text = "Wybierz dział";
            // 
            // depComboBox
            // 
            this.depComboBox.FormattingEnabled = true;
            this.depComboBox.Location = new System.Drawing.Point(280, 119);
            this.depComboBox.Name = "depComboBox";
            this.depComboBox.Size = new System.Drawing.Size(129, 23);
            this.depComboBox.TabIndex = 10;
            this.depComboBox.Text = "Rozwiń by wybrać...";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(280, 42);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(117, 15);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Wybierz uprawnienia";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(280, 60);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(129, 23);
            this.typeComboBox.TabIndex = 12;
            this.typeComboBox.Text = "Rozwiń by wybrać...";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(182, 242);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(127, 23);
            this.confirmButton.TabIndex = 13;
            this.confirmButton.Text = "Potwierdź i dodaj";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(182, 271);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(127, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.depComboBox);
            this.Controls.Add(this.depLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.peselLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.peselMaskedBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addEmployeeLabel);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(505, 311);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addEmployeeLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.MaskedTextBox peselMaskedBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Label depLabel;
        private System.Windows.Forms.ComboBox depComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button clearButton;
    }
}
