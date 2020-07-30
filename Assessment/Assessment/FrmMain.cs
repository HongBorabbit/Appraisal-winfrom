using Assessment.Common;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
          Form form= FormFactory.CreateFrom("FrmUserManager");
            //frmUserManager = new FrmUserManager();
            //frmUserManager.MdiParent = this;
            //frmUserManager.Parent = splitContainer1.Panel2;
            //frmUserManager.Show();
           // Form form = FormFactory.CreateFrom();
            form.MdiParent = this;
            form.Parent = splitContainer1.Panel2;
            form.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 选中
            foreach (TreeNode node in trvMenu.Nodes)
            {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;
            }
            e.Node.BackColor = SystemColors.Highlight;
            e.Node.ForeColor = Color.White;
            // 判断点击弹出窗体
            Form form = FormFactory.CreateFrom(e.Node.Tag.ToString());
            form.MdiParent = this;
            form.Parent = splitContainer1.Panel2;
            form.Show();
        }
    }
}
