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
    // 声明委托
    public delegate void DelBindDgv();
    public partial class FrmUserManager : Form
    {
        DelBindDgv delBindDgv;
        public FrmUserManager()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUserManager_Load(object sender, EventArgs e)
        {
            BindCbx();
            //var a = UserAppraisalBases.GetListJoinAppraisal();
            // 获取文本
            BindDgv();
            delBindDgv = BindDgv;
        }

        private void BindDgv()
        {
            dgvUserAppraisa.AutoGenerateColumns = false;
            string userName = UserNa.Text.Trim();
            int baseTypeId = (int)comBase.SelectedValue;
            bool isStop = ChkisStop.Checked;
            List<UserAppraisalBases> userAppraisalBases = UserAppraisalBases.GetListJoinAppraisal();
            if (baseTypeId == 0)
            {
                dgvUserAppraisa.DataSource = userAppraisalBases.FindAll(m => m.UserName.Contains(userName) && m.IsDel == isStop);
            }
            else
            {
                dgvUserAppraisa.DataSource = userAppraisalBases.FindAll(m => m.UserName.Contains(userName) && m.IsDel == isStop && m.BaseTypeId == baseTypeId);
            }
        }

        /// <summary>
        /// 下拉显示
        /// </summary>
        private void BindCbx()
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            //appraisalBases.Add(new AppraisalBases
            //{
            //    Id = 0,
            //    BaseType = "查询所有",
            //    AppraisalBase = 0,
            //    IsDel = false
            //});
            //IEnumerable<AppraisalBases> appraisalBases1 = AppraisalBases.ListAll();
            //appraisalBases.AddRange(appraisalBases1);
            // 单向绑定
            appraisalBases = AppraisalBases.ListAll();
            appraisalBases.Insert(0, new AppraisalBases
            {
                Id = 0,
                BaseType = "查询所有",
                AppraisalBase = 0,
                IsDel = false

            });
            comBase.DataSource = appraisalBases;
            comBase.DisplayMember = "BaseType";
            comBase.ValueMember = "Id";
            //comBase.Text = "查询所有";
            //comBase.Items.Add("查询所有");
            //foreach (var appraisalBase in appraisalBases)
            //{
            //    comBase.Items.Add(appraisalBase.BaseType);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindDgv();
        }

        private void dgvUserAppraisa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                NewUser.Visible = true;
                Edituser.Visible = false;
                Startuser.Visible = false;
                Stopuser.Visible = false;
            }
        }

        private void dgvUserAppraisa_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 鼠标右键
            if (e.Button==MouseButtons.Right)
            {
                // 判断选中行
                if (e.RowIndex>-1)
                {
                    dgvUserAppraisa.Rows[e.RowIndex].Selected = true;
                    NewUser.Visible = true;
                    Edituser.Visible = true;

                    bool isDel=(bool)dgvUserAppraisa.SelectedRows[0].Cells["IsDel"].Value;
                    if (isDel)
                    {
                        Startuser.Visible = true;
                    }
                    else
                    {
                        Stopuser.Visible = true;
                    }
                    
                }
            }
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewUser_Click(object sender, EventArgs e)
        {
            FrmSetUser frmSetUser = new FrmSetUser(delBindDgv);
            frmSetUser.ShowDialog();
            BindDgv();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edituser_Click(object sender, EventArgs e)
        {
            int id =(int)dgvUserAppraisa.SelectedRows[0].Cells["Id"].Value;
            FrmSetUser frmSetUser = new FrmSetUser(delBindDgv, id);
            frmSetUser.ShowDialog();
        }
    }
}
