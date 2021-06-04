namespace IO_proj
{
    partial class FacilityManagerPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsListGridView = new System.Windows.Forms.DataGridView();
            this.employeeListGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depStatsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wyloguj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imię";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PESEL";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ilość części";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dział";
            this.Column5.Name = "Column5";
            // 
            // departmentsListGridView
            // 
            this.departmentsListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5});
            this.departmentsListGridView.Location = new System.Drawing.Point(18, 14);
            this.departmentsListGridView.Name = "departmentsListGridView";
            this.departmentsListGridView.RowHeadersVisible = false;
            this.departmentsListGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.departmentsListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.departmentsListGridView.Size = new System.Drawing.Size(120, 149);
            this.departmentsListGridView.TabIndex = 2;
            this.departmentsListGridView.Text = "dataGridView1";
            // 
            // employeeListGridView
            // 
            this.employeeListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.employeeListGridView.Location = new System.Drawing.Point(154, 14);
            this.employeeListGridView.Name = "employeeListGridView";
            this.employeeListGridView.RowHeadersVisible = false;
            this.employeeListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeListGridView.Size = new System.Drawing.Size(405, 149);
            this.employeeListGridView.TabIndex = 0;
            this.employeeListGridView.Text = "dataGridView1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 139);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // depStatsLabel
            // 
            this.depStatsLabel.AutoSize = true;
            this.depStatsLabel.Location = new System.Drawing.Point(18, 186);
            this.depStatsLabel.Name = "depStatsLabel";
            this.depStatsLabel.Size = new System.Drawing.Size(153, 15);
            this.depStatsLabel.TabIndex = 4;
            this.depStatsLabel.Text = "Statystyki wybranego działu";
            // 
            // FacilityManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.depStatsLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.departmentsListGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeListGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FacilityManagerPanel";
            this.Size = new System.Drawing.Size(578, 361);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView employeeListGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
       
        private System.Windows.Forms.DataGridView departmentsListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label depStatsLabel;
    }
}
