namespace ProductionManagementSystem
{
    partial class DepartmentManagerMainPanel
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
            this.myDepartmentLabel = new System.Windows.Forms.Label();
            this.partsPerMonthLabel = new System.Windows.Forms.Label();
            this.partsPerDayLabel = new System.Windows.Forms.Label();
            this.partsPerEmpLabel = new System.Windows.Forms.Label();
            this.partsPerMonthCountLabel = new System.Windows.Forms.Label();
            this.myDepartmentNameLabel = new System.Windows.Forms.Label();
            this.partsPerDayCountLabel = new System.Windows.Forms.Label();
            this.partsPerEmpCountLabel = new System.Windows.Forms.Label();
            this.currentDayStatusLabel = new System.Windows.Forms.Label();
            this.partsProducedLabel = new System.Windows.Forms.Label();
            this.partsProducedCountLabel = new System.Windows.Forms.Label();
            this.currentStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.departmentStatisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.currentStatusGroupBox.SuspendLayout();
            this.departmentStatisticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDepartmentLabel
            // 
            this.myDepartmentLabel.AutoSize = true;
            this.myDepartmentLabel.Location = new System.Drawing.Point(10, 47);
            this.myDepartmentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myDepartmentLabel.Name = "myDepartmentLabel";
            this.myDepartmentLabel.Size = new System.Drawing.Size(89, 25);
            this.myDepartmentLabel.TabIndex = 1;
            this.myDepartmentLabel.Text = "Mój dział:";
            // 
            // partsPerMonthLabel
            // 
            this.partsPerMonthLabel.AutoSize = true;
            this.partsPerMonthLabel.Location = new System.Drawing.Point(9, 88);
            this.partsPerMonthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsPerMonthLabel.Name = "partsPerMonthLabel";
            this.partsPerMonthLabel.Size = new System.Drawing.Size(189, 25);
            this.partsPerMonthLabel.TabIndex = 1;
            this.partsPerMonthLabel.Text = "Ilość części na miesiąc:";
            // 
            // partsPerDayLabel
            // 
            this.partsPerDayLabel.AutoSize = true;
            this.partsPerDayLabel.Location = new System.Drawing.Point(9, 128);
            this.partsPerDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsPerDayLabel.Name = "partsPerDayLabel";
            this.partsPerDayLabel.Size = new System.Drawing.Size(173, 25);
            this.partsPerDayLabel.TabIndex = 1;
            this.partsPerDayLabel.Text = "Ilość części na dzień:";
            // 
            // partsPerEmpLabel
            // 
            this.partsPerEmpLabel.AutoSize = true;
            this.partsPerEmpLabel.Location = new System.Drawing.Point(9, 172);
            this.partsPerEmpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsPerEmpLabel.Name = "partsPerEmpLabel";
            this.partsPerEmpLabel.Size = new System.Drawing.Size(221, 25);
            this.partsPerEmpLabel.TabIndex = 1;
            this.partsPerEmpLabel.Text = "Ilość części na pracownika:";
            // 
            // partsPerMonthCountLabel
            // 
            this.partsPerMonthCountLabel.AutoSize = true;
            this.partsPerMonthCountLabel.Location = new System.Drawing.Point(199, 88);
            this.partsPerMonthCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsPerMonthCountLabel.Name = "partsPerMonthCountLabel";
            this.partsPerMonthCountLabel.Size = new System.Drawing.Size(71, 25);
            this.partsPerMonthCountLabel.TabIndex = 2;
            this.partsPerMonthCountLabel.Text = "<ilość>";
            // 
            // myDepartmentNameLabel
            // 
            this.myDepartmentNameLabel.AutoSize = true;
            this.myDepartmentNameLabel.Location = new System.Drawing.Point(103, 47);
            this.myDepartmentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.myDepartmentNameLabel.Name = "myDepartmentNameLabel";
            this.myDepartmentNameLabel.Size = new System.Drawing.Size(73, 25);
            this.myDepartmentNameLabel.TabIndex = 2;
            this.myDepartmentNameLabel.Text = "<dział>";
            // 
            // partsPerDayCountLabel
            // 
            this.partsPerDayCountLabel.AutoSize = true;
            this.partsPerDayCountLabel.Location = new System.Drawing.Point(181, 128);
            this.partsPerDayCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsPerDayCountLabel.Name = "partsPerDayCountLabel";
            this.partsPerDayCountLabel.Size = new System.Drawing.Size(71, 25);
            this.partsPerDayCountLabel.TabIndex = 2;
            this.partsPerDayCountLabel.Text = "<ilość>";
            // 
            // partsPerEmpCountLabel
            // 
            this.partsPerEmpCountLabel.AutoSize = true;
            this.partsPerEmpCountLabel.Location = new System.Drawing.Point(220, 172);
            this.partsPerEmpCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsPerEmpCountLabel.Name = "partsPerEmpCountLabel";
            this.partsPerEmpCountLabel.Size = new System.Drawing.Size(71, 25);
            this.partsPerEmpCountLabel.TabIndex = 2;
            this.partsPerEmpCountLabel.Text = "<ilość>";
            // 
            // currentDayStatusLabel
            // 
            this.currentDayStatusLabel.AutoSize = true;
            this.currentDayStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentDayStatusLabel.Location = new System.Drawing.Point(9, 32);
            this.currentDayStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentDayStatusLabel.Name = "currentDayStatusLabel";
            this.currentDayStatusLabel.Size = new System.Drawing.Size(261, 30);
            this.currentDayStatusLabel.TabIndex = 3;
            this.currentDayStatusLabel.Text = "Stan na dzień dzisiejszy:";
            // 
            // partsProducedLabel
            // 
            this.partsProducedLabel.AutoSize = true;
            this.partsProducedLabel.Location = new System.Drawing.Point(9, 88);
            this.partsProducedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsProducedLabel.Name = "partsProducedLabel";
            this.partsProducedLabel.Size = new System.Drawing.Size(204, 25);
            this.partsProducedLabel.TabIndex = 4;
            this.partsProducedLabel.Text = "Wyprodukowano części:";
            // 
            // partsProducedCountLabel
            // 
            this.partsProducedCountLabel.AutoSize = true;
            this.partsProducedCountLabel.Location = new System.Drawing.Point(210, 88);
            this.partsProducedCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsProducedCountLabel.Name = "partsProducedCountLabel";
            this.partsProducedCountLabel.Size = new System.Drawing.Size(71, 25);
            this.partsProducedCountLabel.TabIndex = 5;
            this.partsProducedCountLabel.Text = "<ilość>";
            // 
            // currentStatusGroupBox
            // 
            this.currentStatusGroupBox.Controls.Add(this.currentDayStatusLabel);
            this.currentStatusGroupBox.Controls.Add(this.partsProducedCountLabel);
            this.currentStatusGroupBox.Controls.Add(this.partsProducedLabel);
            this.currentStatusGroupBox.Location = new System.Drawing.Point(387, 295);
            this.currentStatusGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentStatusGroupBox.Name = "currentStatusGroupBox";
            this.currentStatusGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentStatusGroupBox.Size = new System.Drawing.Size(286, 230);
            this.currentStatusGroupBox.TabIndex = 6;
            this.currentStatusGroupBox.TabStop = false;
            // 
            // departmentStatisticsGroupBox
            // 
            this.departmentStatisticsGroupBox.Controls.Add(this.myDepartmentLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.myDepartmentNameLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerEmpCountLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerEmpLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerMonthLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerDayCountLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerMonthCountLabel);
            this.departmentStatisticsGroupBox.Controls.Add(this.partsPerDayLabel);
            this.departmentStatisticsGroupBox.Location = new System.Drawing.Point(47, 295);
            this.departmentStatisticsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentStatisticsGroupBox.Name = "departmentStatisticsGroupBox";
            this.departmentStatisticsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.departmentStatisticsGroupBox.Size = new System.Drawing.Size(331, 238);
            this.departmentStatisticsGroupBox.TabIndex = 7;
            this.departmentStatisticsGroupBox.TabStop = false;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.AllowUserToDeleteRows = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(39, 43);
            this.employeesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.ReadOnly = true;
            this.employeesDataGridView.RowHeadersWidth = 62;
            this.employeesDataGridView.Size = new System.Drawing.Size(634, 227);
            this.employeesDataGridView.TabIndex = 0;
            this.employeesDataGridView.Text = "dataGridView1";
            // 
            // DepartmentManagerMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.departmentStatisticsGroupBox);
            this.Controls.Add(this.currentStatusGroupBox);
            this.Controls.Add(this.employeesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DepartmentManagerMainPanel";
            this.Size = new System.Drawing.Size(719, 572);
            this.currentStatusGroupBox.ResumeLayout(false);
            this.currentStatusGroupBox.PerformLayout();
            this.departmentStatisticsGroupBox.ResumeLayout(false);
            this.departmentStatisticsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Label myDepartmentLabel;
        private System.Windows.Forms.Label partsPerMonthLabel;
        private System.Windows.Forms.Label partsPerDayLabel;
        private System.Windows.Forms.Label partsPerEmpLabel;
        private System.Windows.Forms.Label partsPerMonthCountLabel;
        private System.Windows.Forms.Label myDepartmentNameLabel;
        private System.Windows.Forms.Label partsPerDayCountLabel;
        private System.Windows.Forms.Label partsPerEmpCountLabel;
        private System.Windows.Forms.Label currentDayStatusLabel;
        private System.Windows.Forms.Label partsProducedLabel;
        private System.Windows.Forms.Label partsProducedCountLabel;
        private System.Windows.Forms.GroupBox currentStatusGroupBox;
        private System.Windows.Forms.GroupBox departmentStatisticsGroupBox;
    }
}
