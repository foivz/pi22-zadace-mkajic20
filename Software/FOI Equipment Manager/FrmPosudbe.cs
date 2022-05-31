using DBLayer;
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
    

    public partial class FrmPosudbe : Form
    {
        public string searchPosudbe { get; set; }
        public FrmPosudbe()
        {
            InitializeComponent();
            DB.SetConfiguration("mkajic20_DB","mkajic20", "*KG*DzU#");
        }

        private void FrmPosudbe_Load(object sender, EventArgs e)
        {
            PrikaziPosudbe();
        }

        private void PrikaziPosudbe()
        {
            var posudbe = ReposPosudbe.GetPosudbe();
            dgvPosudbe.DataSource = posudbe;

            dgvPosudbe.Columns["IdPosudbe"].DisplayIndex = 0;
            dgvPosudbe.Columns["Posudio"].DisplayIndex = 1;
            dgvPosudbe.Columns["DatumVrijeme"].DisplayIndex = 2;
            dgvPosudbe.Columns["Razlog"].DisplayIndex = 3;
            dgvPosudbe.Columns["PosudenaOprema"].DisplayIndex = 4;
        }

        private void PrikaziPosudbu(string search)
        {
            var posudbe = ReposSearch.SearchPosudbe(search);
            dgvSearch.DataSource = posudbe;

            dgvSearch.Columns["IdPosudbe"].DisplayIndex = 0;
            dgvSearch.Columns["Posudio"].DisplayIndex = 1;
            dgvSearch.Columns["DatumVrijeme"].DisplayIndex = 2;
            dgvSearch.Columns["Razlog"].DisplayIndex = 3;
            dgvSearch.Columns["PosudenaOprema"].DisplayIndex = 4;

        }

        private void dgvPosudbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdatePosudba_Click(object sender, EventArgs e)
        {
            Posudba selectedPosudba = dgvPosudbe.CurrentRow.DataBoundItem as Posudba;  
            if(selectedPosudba != null)
            {
                UpdatePosudba updatePosudba = new UpdatePosudba(selectedPosudba);
                Hide();
                updatePosudba.ShowDialog();
                Close();
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsert insertPosudba = new frmInsert();
            Hide();
            insertPosudba.ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Posudba selectedPosudba = dgvPosudbe.CurrentRow.DataBoundItem as Posudba;
            if (selectedPosudba != null)
            {
                ReposDelete reposDelete = new ReposDelete();
                reposDelete.DeletePosudba(selectedPosudba.IdPosudbe);
            }
            FrmPosudbe frmPosudbe = new FrmPosudbe();
            Hide();
            frmPosudbe.ShowDialog();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchPosudbe = txtSearch.Text;
            if(searchPosudbe != null)
            {
                PrikaziPosudbu(searchPosudbe);
            }
        }
    }
}
