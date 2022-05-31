namespace FOI_Equipment_Manager
{
    partial class UpdatePosudba
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPosudio = new System.Windows.Forms.TextBox();
            this.txtDatumVrijeme = new System.Windows.Forms.TextBox();
            this.txtRazlog = new System.Windows.Forms.TextBox();
            this.txtPosudenaOprema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 48);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(191, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPosudio
            // 
            this.txtPosudio.Location = new System.Drawing.Point(191, 27);
            this.txtPosudio.Name = "txtPosudio";
            this.txtPosudio.Size = new System.Drawing.Size(310, 22);
            this.txtPosudio.TabIndex = 3;
            this.txtPosudio.TextChanged += new System.EventHandler(this.txtPosudio_TextChanged);
            // 
            // txtDatumVrijeme
            // 
            this.txtDatumVrijeme.Location = new System.Drawing.Point(191, 69);
            this.txtDatumVrijeme.Name = "txtDatumVrijeme";
            this.txtDatumVrijeme.Size = new System.Drawing.Size(310, 22);
            this.txtDatumVrijeme.TabIndex = 4;
            // 
            // txtRazlog
            // 
            this.txtRazlog.Location = new System.Drawing.Point(191, 110);
            this.txtRazlog.Name = "txtRazlog";
            this.txtRazlog.Size = new System.Drawing.Size(310, 22);
            this.txtRazlog.TabIndex = 5;
            // 
            // txtPosudenaOprema
            // 
            this.txtPosudenaOprema.Location = new System.Drawing.Point(191, 157);
            this.txtPosudenaOprema.Name = "txtPosudenaOprema";
            this.txtPosudenaOprema.Size = new System.Drawing.Size(310, 22);
            this.txtPosudenaOprema.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Posudio/la opremu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum i vrijeme posudbe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Razlog posudbe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Posuđena oprema:";
            // 
            // UpdatePosudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 297);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosudenaOprema);
            this.Controls.Add(this.txtRazlog);
            this.Controls.Add(this.txtDatumVrijeme);
            this.Controls.Add(this.txtPosudio);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "UpdatePosudba";
            this.Text = "UpdatePosudba";
            this.Load += new System.EventHandler(this.UpdatePosudba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPosudio;
        private System.Windows.Forms.TextBox txtDatumVrijeme;
        private System.Windows.Forms.TextBox txtRazlog;
        private System.Windows.Forms.TextBox txtPosudenaOprema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}