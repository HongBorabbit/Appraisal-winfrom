using Appraisal_System.Models;
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
    public partial class FrmSetUser : Form
    {
        private DelBindDgv _delBindDgv;
        public FrmSetUser(DelBindDgv delBindDgv)
        {
            InitializeComponent();
            _delBindDgv = delBindDgv;
        }
        public Users _user;
        public FrmSetUser(DelBindDgv delBindDgv,int userId):this(delBindDgv)
        {
            _user = Users.ListAll().Find(m => m.Id == userId);
         
        }
        private void FrmSetUser_Load(object sender, EventArgs e)
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();
            appraisalBases = AppraisalBases.ListAll();
            comBase.DataSource = appraisalBases;
            comBase.DisplayMember = "BaseType";
            comBase.ValueMember = "Id";

            tName.Text = _user.UserName;
            comBase.SelectedValue = _user.BaseTypeId;
            comsex.Text = _user.Sex;
            chkIsStop.Checked = _user.IsDel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = tName.Text.Trim();
            int BaseTypeId = (int)comBase.SelectedValue;
            string sex = comsex.Text;
            bool isDel = chkIsStop.Checked;
            if (_user==null)
            {
            Users users = new Users
            {
                UserName = username,
                BaseTypeId = BaseTypeId,
                PassWord = "111",
                IsDel = isDel,
                Sex = sex
            };
            Users.Insert(users);
            MessageBox.Show("添加成功！");

            }
            else
            {
                _user.UserName = username;
                _user.BaseTypeId = BaseTypeId;
                _user.IsDel = isDel;
                _user.Sex = sex;
                Users.Update(_user);
                MessageBox.Show("修改成功！");
            }
            _delBindDgv();
            // this.Close();
        }
    }
}
