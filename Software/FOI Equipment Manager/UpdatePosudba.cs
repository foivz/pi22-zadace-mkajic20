using FOI_Equipment_Manager.Models;
using FOI_Equipment_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOI_Equipment_Manager
{
    
    public partial class UpdatePosudba : Form
    {
        public string unosPosudio { get; set; }
        public string unosDatum { get; set; }
        public string unosRazlog { get; set; }
        public string unosOprema { get; set; }

        private Posudba posudba;
        public Posudba SelectedPosudba { get => posudba; set => posudba = value; }
        public UpdatePosudba(Posudba selectedPosudba)
        {
            InitializeComponent();
            SelectedPosudba = selectedPosudba;  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmPosudbe frmPosudbe = new FrmPosudbe();
            Hide();
            frmPosudbe.ShowDialog();
            Close();
        }

        private void UpdatePosudba_Load(object sender, EventArgs e)
        {
            SetFormText();
        }

        private void SetFormText()
        {
            Text = SelectedPosudba.Posudio;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Id = SelectedPosudba.IdPosudbe;
            unosPosudio = txtPosudio.Text;
            unosDatum = txtDatumVrijeme.Text;
            unosRazlog = txtRazlog.Text;
            unosOprema = txtPosudenaOprema.Text;

            ReposUpdate reposUpdate = new ReposUpdate();
            reposUpdate.UpdatePosudba(Id, unosPosudio, unosDatum, unosRazlog, unosOprema);

            FrmPosudbe frmPosudbe = new FrmPosudbe();
            Hide();
            frmPosudbe.ShowDialog();
            Close();
        }

        private void txtPosudio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
