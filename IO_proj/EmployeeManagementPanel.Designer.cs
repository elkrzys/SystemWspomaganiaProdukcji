namespace ProductionManagementSystem
{
    partial class EmployeeManagementPanel
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
            this.moveEmployeeLabel = new System.Windows.Forms.Label();
            this.removeEmployeeLabel = new System.Windows.Forms.Label();
            this.chooseEmployeeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.peselMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.peselLabel = new System.Windows.Forms.Label();
            this.confirmEmployeeButton = new System.Windows.Forms.Button();
            this.confirmedEmployeeLabel = new System.Windows.Forms.Label();
            this.employeeInfoLabel = new System.Windows.Forms.Label();
            this.depNameLabel = new System.Windows.Forms.Label();
            this.departmentNameLabel = new System.Windows.Forms.Label();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.depChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.moveEmployeeButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moveEmployeeLabel
            // 
            this.moveEmployeeLabel.AutoSize = true;
            this.moveEmployeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moveEmployeeLabel.Location = new System.Drawing.Point(49, 193);
            this.moveEmployeeLabel.Name = "moveEmployeeLabel";
            this.moveEmployeeLabel.Size = new System.Drawing.Size(143, 17);
            this.moveEmployeeLabel.TabIndex = 0;
            this.moveEmployeeLabel.Text = "Przenieś do innego działu";
            this.moveEmployeeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // removeEmployeeLabel
            // 
            this.removeEmployeeLabel.AutoSize = true;
            this.removeEmployeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeEmployeeLabel.Location = new System.Drawing.Point(313, 193);
            this.removeEmployeeLabel.Name = "removeEmployeeLabel";
            this.removeEmployeeLabel.Size = new System.Drawing.Size(91, 17);
            this.removeEmployeeLabel.TabIndex = 0;
            this.removeEmployeeLabel.Text = "Usuń z systemu";
            this.removeEmployeeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // chooseEmployeeLabel
            // 
            this.chooseEmployeeLabel.AutoSize = true;
            this.chooseEmployeeLabel.Location = new System.Drawing.Point(49, 16);
            this.chooseEmployeeLabel.Name = "chooseEmployeeLabel";
            this.chooseEmployeeLabel.Size = new System.Drawing.Size(131, 15);
            this.chooseEmployeeLabel.TabIndex = 1;
            this.chooseEmployeeLabel.Text = "Wpisz dane pracownika";
            this.chooseEmployeeLabel.Click += new System.EventHandler(this.chooseEmployeeLabel_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(101, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 2;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(101, 72);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 23);
            this.surnameBox.TabIndex = 3;
            // 
            // peselMaskedBox
            // 
            this.peselMaskedBox.Location = new System.Drawing.Point(101, 101);
            this.peselMaskedBox.Mask = "00000000000";
            this.peselMaskedBox.Name = "peselMaskedBox";
            this.peselMaskedBox.Size = new System.Drawing.Size(100, 23);
            this.peselMaskedBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(30, 15);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Imię";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(22, 75);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(57, 15);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // peselLabel
            // 
            this.peselLabel.AutoSize = true;
            this.peselLabel.Location = new System.Drawing.Point(22, 104);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(38, 15);
            this.peselLabel.TabIndex = 5;
            this.peselLabel.Text = "PESEL";
            // 
            // confirmEmployeeButton
            // 
            this.confirmEmployeeButton.Location = new System.Drawing.Point(121, 130);
            this.confirmEmployeeButton.Name = "confirmEmployeeButton";
            this.confirmEmployeeButton.Size = new System.Drawing.Size(59, 29);
            this.confirmEmployeeButton.TabIndex = 6;
            this.confirmEmployeeButton.Text = "Ok";
            this.confirmEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // confirmedEmployeeLabel
            // 
            this.confirmedEmployeeLabel.AutoSize = true;
            this.confirmedEmployeeLabel.Location = new System.Drawing.Point(220, 46);
            this.confirmedEmployeeLabel.Name = "confirmedEmployeeLabel";
            this.confirmedEmployeeLabel.Size = new System.Drawing.Size(263, 15);
            this.confirmedEmployeeLabel.TabIndex = 7;
            this.confirmedEmployeeLabel.Text = "Wprowadzone dane odpowiadają pracownikowi:";
            // 
            // employeeInfoLabel
            // 
            this.employeeInfoLabel.AutoSize = true;
            this.employeeInfoLabel.Location = new System.Drawing.Point(220, 75);
            this.employeeInfoLabel.Name = "employeeInfoLabel";
            this.employeeInfoLabel.Size = new System.Drawing.Size(201, 15);
            this.employeeInfoLabel.TabIndex = 8;
            this.employeeInfoLabel.Text = "<Imię><Nazwisko><Pesel><Adres>";
            // 
            // depNameLabel
            // 
            this.depNameLabel.AutoSize = true;
            this.depNameLabel.Location = new System.Drawing.Point(220, 104);
            this.depNameLabel.Name = "depNameLabel";
            this.depNameLabel.Size = new System.Drawing.Size(78, 15);
            this.depNameLabel.TabIndex = 9;
            this.depNameLabel.Text = "Obecny dział:";
            // 
            // departmentNameLabel
            // 
            this.departmentNameLabel.AutoSize = true;
            this.departmentNameLabel.Location = new System.Drawing.Point(304, 104);
            this.departmentNameLabel.Name = "departmentNameLabel";
            this.departmentNameLabel.Size = new System.Drawing.Size(47, 15);
            this.departmentNameLabel.TabIndex = 10;
            this.departmentNameLabel.Text = "<dział>";
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeEmployeeButton.Location = new System.Drawing.Point(291, 250);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(130, 23);
            this.removeEmployeeButton.TabIndex = 11;
            this.removeEmployeeButton.Text = "Usuń pracownika";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // depChoiceComboBox
            // 
            this.depChoiceComboBox.FormattingEnabled = true;
            this.depChoiceComboBox.Location = new System.Drawing.Point(55, 247);
            this.depChoiceComboBox.Name = "depChoiceComboBox";
            this.depChoiceComboBox.Size = new System.Drawing.Size(131, 23);
            this.depChoiceComboBox.TabIndex = 12;
            this.depChoiceComboBox.Text = "Wybierz nowy dział";
            // 
            // moveEmployeeButton
            // 
            this.moveEmployeeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.moveEmployeeButton.Location = new System.Drawing.Point(55, 279);
            this.moveEmployeeButton.Name = "moveEmployeeButton";
            this.moveEmployeeButton.Size = new System.Drawing.Size(130, 23);
            this.moveEmployeeButton.TabIndex = 11;
            this.moveEmployeeButton.Text = "Przenieś pracownika";
            this.moveEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.warningLabel.Location = new System.Drawing.Point(255, 276);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(208, 15);
            this.warningLabel.TabIndex = 13;
            this.warningLabel.Text = "Uwaga! Tej operacji nie można cofnąć.";
            // 
            // EmployeeManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.moveEmployeeButton);
            this.Controls.Add(this.depChoiceComboBox);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.departmentNameLabel);
            this.Controls.Add(this.depNameLabel);
            this.Controls.Add(this.employeeInfoLabel);
            this.Controls.Add(this.confirmedEmployeeLabel);
            this.Controls.Add(this.confirmEmployeeButton);
            this.Controls.Add(this.peselLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.peselMaskedBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.chooseEmployeeLabel);
            this.Controls.Add(this.removeEmployeeLabel);
            this.Controls.Add(this.moveEmployeeLabel);
            this.Name = "EmployeeManagementPanel";
            this.Size = new System.Drawing.Size(503, 343);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moveEmployeeLabel;
        private System.Windows.Forms.Label removeEmployeeLabel;
        private System.Windows.Forms.Label chooseEmployeeLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.MaskedTextBox peselMaskedBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Button confirmEmployeeButton;
        private System.Windows.Forms.Label confirmedEmployeeLabel;
        private System.Windows.Forms.Label employeeInfoLabel;
        private System.Windows.Forms.Label depNameLabel;
        private System.Windows.Forms.Label getDepartmentNameLabel;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.ComboBox depChoiceComboBox;
        private System.Windows.Forms.Button moveEmployeeButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label departmentNameLabel;
    }
}
