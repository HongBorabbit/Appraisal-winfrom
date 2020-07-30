using Assessment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment
{
    public partial class FrmBaseManager : Form
    {
        public FrmBaseManager()
        {
            InitializeComponent();
        }

        private void FrmBaseManager_Load(object sender, EventArgs e)
        {
            dgvBase.DataSource = AppraisalBases.ListAll();
        }

        private void dgvBase_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            AppraisalBases appraisalBases=(AppraisalBases)dgvBase.Rows[e.RowIndex].DataBoundItem;
        }
    }
}
