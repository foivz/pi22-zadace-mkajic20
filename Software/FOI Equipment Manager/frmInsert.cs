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
    public partial class frmInsert : Form
    {
        public int unosIdPosudbe { get; set; }
        public string unosPosudio { get; set; }
        public string unosDatum { get; set; }
        public string unosRazlog { get; set; }
        public string unosOprema { get; set; }
        public frmInsert()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmPosudbe frmPosudbe = new FrmPosudbe();
            Hide();
            frmPosudbe.ShowDialog();
            Close();
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            unosIdPosudbe = (int)unosPosudbaId.Value;
            unosPosudio = txtPosudio.Text;
            unosDatum = txtDatumVrijeme.Text;
            unosRazlog = txtRazlog.Text;
            unosOprema = txtPosudenaOprema.Text;

            ReposInsert reposInsert = new ReposInsert();
            reposInsert.InsertPosudba(unosIdPosudbe, unosPosudio, unosDatum, unosRazlog, unosOprema);

            FrmPosudbe frmPosudbe = new FrmPosudbe();
            Hide();
            frmPosudbe.ShowDialog();
            Close();
        }
    }
}
