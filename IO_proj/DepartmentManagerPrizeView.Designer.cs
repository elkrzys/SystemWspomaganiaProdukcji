namespace ProductionManagementSystem
{
    partial class DepartmentManagerPrizeView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // employeeName
            // 
            this.employeeName.Frozen = true;
            this.employeeName.HeaderText = "Imie";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            // 
            // employeeSurname
            // 
            this.employeeSurname.Frozen = true;
            this.employeeSurname.HeaderText = "Nazwisko";
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.ReadOnly = true;
            // 
            // prize
            // 
            this.prize.HeaderText = "Nagroda";
            this.prize.Name = "prize";
            this.prize.ReadOnly = true;
            // 
            // DepartmentManagerPrizeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeName,
            this.employeeSurname,
            this.prize});
            this.dataGridView1.Location = new System.Drawing.Point(18, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 284);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentManagerPrizeView";
            this.Size = new System.Drawing.Size(503, 343);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prize;
    }
}
