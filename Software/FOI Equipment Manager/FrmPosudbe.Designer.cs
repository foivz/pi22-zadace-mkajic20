namespace FOI_Equipment_Manager
{
    partial class FrmPosudbe
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
            this.dgvPosudbe = new System.Windows.Forms.DataGridView();
            this.btnUpdatePosudba = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPosudbe
            // 
            this.dgvPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudbe.Location = new System.Drawing.Point(22, 27);
            this.dgvPosudbe.Name = "dgvPosudbe";
            this.dgvPosudbe.RowHeadersWidth = 51;
            this.dgvPosudbe.RowTemplate.Height = 24;
            this.dgvPosudbe.Size = new System.Drawing.Size(748, 256);
            this.dgvPosudbe.TabIndex = 0;
            this.dgvPosudbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosudbe_CellContentClick);
            // 
            // btnUpdatePosudba
            // 
            this.btnUpdatePosudba.Location = new System.Drawing.Point(610, 289);
            this.btnUpdatePosudba.Name = "btnUpdatePosudba";
            this.btnUpdatePosudba.Size = new System.Drawing.Size(160, 38);
            this.btnUpdatePosudba.TabIndex = 1;
            this.btnUpdatePosudba.Text = "Ažuriraj";
            this.btnUpdatePosudba.UseVisualStyleBackColor = true;
            this.btnUpdatePosudba.Click += new System.EventHandler(this.btnUpdatePosudba_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(444, 290);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 37);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Unesi";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Obriši";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(22, 332);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(748, 155);
            this.dgvSearch.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(22, 493);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 493);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdatePosudba);
            this.Controls.Add(this.dgvPosudbe);
            this.Name = "FrmPosudbe";
            this.Text = "Posudbe";
            this.Load += new System.EventHandler(this.FrmPosudbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPosudbe;
        private System.Windows.Forms.Button btnUpdatePosudba;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

