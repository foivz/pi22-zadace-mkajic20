namespace FOI_Equipment_Manager
{
    partial class frmInsert
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
            this.unosPosudbaId = new System.Windows.Forms.NumericUpDown();
            this.txtPosudio = new System.Windows.Forms.TextBox();
            this.txtDatumVrijeme = new System.Windows.Forms.TextBox();
            this.txtRazlog = new System.Windows.Forms.TextBox();
            this.txtPosudenaOprema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unosPosudbaId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(371, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 43);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // unosPosudbaId
            // 
            this.unosPosudbaId.Location = new System.Drawing.Point(233, 26);
            this.unosPosudbaId.Name = "unosPosudbaId";
            this.unosPosudbaId.Size = new System.Drawing.Size(276, 22);
            this.unosPosudbaId.TabIndex = 1;
            // 
            // txtPosudio
            // 
            this.txtPosudio.Location = new System.Drawing.Point(233, 67);
            this.txtPosudio.Name = "txtPosudio";
            this.txtPosudio.Size = new System.Drawing.Size(276, 22);
            this.txtPosudio.TabIndex = 2;
            // 
            // txtDatumVrijeme
            // 
            this.txtDatumVrijeme.Location = new System.Drawing.Point(233, 109);
            this.txtDatumVrijeme.Name = "txtDatumVrijeme";
            this.txtDatumVrijeme.Size = new System.Drawing.Size(276, 22);
            this.txtDatumVrijeme.TabIndex = 3;
            // 
            // txtRazlog
            // 
            this.txtRazlog.Location = new System.Drawing.Point(233, 152);
            this.txtRazlog.Name = "txtRazlog";
            this.txtRazlog.Size = new System.Drawing.Size(276, 22);
            this.txtRazlog.TabIndex = 4;
            // 
            // txtPosudenaOprema
            // 
            this.txtPosudenaOprema.Location = new System.Drawing.Point(233, 194);
            this.txtPosudenaOprema.Name = "txtPosudenaOprema";
            this.txtPosudenaOprema.Size = new System.Drawing.Size(276, 22);
            this.txtPosudenaOprema.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID posudbe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum i vrijeme posudbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Posudio/la opremu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Razlog posudbe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Posuđena oprema:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 43);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 310);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosudenaOprema);
            this.Controls.Add(this.txtRazlog);
            this.Controls.Add(this.txtDatumVrijeme);
            this.Controls.Add(this.txtPosudio);
            this.Controls.Add(this.unosPosudbaId);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmInsert";
            this.Text = "Unos posudbe";
            this.Load += new System.EventHandler(this.frmInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unosPosudbaId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown unosPosudbaId;
        private System.Windows.Forms.TextBox txtPosudio;
        private System.Windows.Forms.TextBox txtDatumVrijeme;
        private System.Windows.Forms.TextBox txtRazlog;
        private System.Windows.Forms.TextBox txtPosudenaOprema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}