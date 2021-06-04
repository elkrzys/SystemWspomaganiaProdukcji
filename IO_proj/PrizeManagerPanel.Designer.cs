namespace ProductionManagementSystem
{
    partial class PrizeManagerPanel
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prizeNameLabel = new System.Windows.Forms.Label();
            this.prizePointsLabel = new System.Windows.Forms.Label();
            this.prizeNameBox = new System.Windows.Forms.TextBox();
            this.addPrizeButton = new System.Windows.Forms.Button();
            this.pointsRequiredBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(21, 29);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(97, 15);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Przejrzyj nagrody";
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Location = new System.Drawing.Point(293, 29);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(149, 15);
            this.infoLabel2.TabIndex = 1;
            this.infoLabel2.Text = "Dodaj nagrody do systemu";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nazwa";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Punkty";
            this.Column2.Name = "Column2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(13, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 176);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // prizeNameLabel
            // 
            this.prizeNameLabel.AutoSize = true;
            this.prizeNameLabel.Location = new System.Drawing.Point(293, 67);
            this.prizeNameLabel.Name = "prizeNameLabel";
            this.prizeNameLabel.Size = new System.Drawing.Size(42, 15);
            this.prizeNameLabel.TabIndex = 3;
            this.prizeNameLabel.Text = "Nazwa";
            // 
            // prizePointsLabel
            // 
            this.prizePointsLabel.AutoSize = true;
            this.prizePointsLabel.Location = new System.Drawing.Point(293, 115);
            this.prizePointsLabel.Name = "prizePointsLabel";
            this.prizePointsLabel.Size = new System.Drawing.Size(107, 15);
            this.prizePointsLabel.TabIndex = 3;
            this.prizePointsLabel.Text = "Wymagane punkty";
            // 
            // prizeNameBox
            // 
            this.prizeNameBox.Location = new System.Drawing.Point(293, 85);
            this.prizeNameBox.Name = "prizeNameBox";
            this.prizeNameBox.Size = new System.Drawing.Size(100, 23);
            this.prizeNameBox.TabIndex = 4;
            // 
            // addPrizeButton
            // 
            this.addPrizeButton.Location = new System.Drawing.Point(337, 172);
            this.addPrizeButton.Name = "addPrizeButton";
            this.addPrizeButton.Size = new System.Drawing.Size(62, 28);
            this.addPrizeButton.TabIndex = 6;
            this.addPrizeButton.Text = "Dodaj";
            this.addPrizeButton.UseVisualStyleBackColor = true;
            // 
            // pointsRequiredBox
            // 
            this.pointsRequiredBox.Location = new System.Drawing.Point(293, 133);
            this.pointsRequiredBox.Name = "pointsRequiredBox";
            this.pointsRequiredBox.Size = new System.Drawing.Size(100, 23);
            this.pointsRequiredBox.TabIndex = 5;
            // 
            // AddPrizePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPrizeButton);
            this.Controls.Add(this.pointsRequiredBox);
            this.Controls.Add(this.prizeNameBox);
            this.Controls.Add(this.prizePointsLabel);
            this.Controls.Add(this.prizeNameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel);
            this.Name = "AddPrizePanel";
            this.Size = new System.Drawing.Size(477, 263);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label prizeNameLabel;
        private System.Windows.Forms.Label prizePointsLabel;
        private System.Windows.Forms.TextBox prizeNameBox;
        private System.Windows.Forms.Button addPrizeButton;
        private System.Windows.Forms.TextBox pointsRequiredBox;
    }
}
