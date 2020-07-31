using Appraisal_System.Models;
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
    public partial class FrmUserAppraisalEdit : Form
    {
        /// <summary>
        /// 获取编辑的用户id和 考核的年份
        /// </summary>
        private int _userId;
        private string _year;
        private Action _bindDgv;
        public FrmUserAppraisalEdit()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 赋值 this() 先执行当前窗体初始化再回到有参数方法
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="year"></param>
        public FrmUserAppraisalEdit(int userId, string year,Action bindDgv):this()
        {
            _userId = userId;
            _year = year;
            _bindDgv =bindDgv;
        }
        private void FrmUserAppraisalEdit_Load(object sender, EventArgs e)
        {
            CreateContorls();
            // 获取数据
            List<UserAppraisals> userAppraisals = UserAppraisals.ListByUserIdAndYear(_userId, _year);
            // 动态控件绑定数据
            foreach (var ua in userAppraisals)
            {
                // 获取flp控件内的控件
                var flCtrs = flp.Controls;
                foreach (Control flCtr in flCtrs)
                {
                    // 判断当前控件是否是 Panel控件
                    if (flCtr is Panel)
                    {
                        var plCtrs = flCtr.Controls;
                        foreach (var plCtr in plCtrs)
                        {
                            //判断当前控件
                            if (plCtr is TextBox)
                            {
                                // 截取刚才设置的txtAppraisalType_ 后面的 id
                                int acId = Convert.ToInt32(((TextBox)plCtr).Name.Split('_')[1]);
                                // 赋值textbox
                                //  string a = userAppraisals.Find(m => m.CoefficientId == acId).Count.ToString();
                                ((TextBox)plCtr).Text = userAppraisals.Find(m => m.CoefficientId == acId).Count.ToString();
                            }
                        }
                    }
                }
            }

        }


        /// <summary>
        /// 创建控件
        /// </summary>
        private void CreateContorls()
        {
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            // 动态控件
            foreach (var ac in appraisalCoefficients)
            {
                //添加pane1
                Panel panel = new Panel();
                // 自定义添加Label
                Label label = new Label
                {
                    Text = ac.AppraisalType,
                    Width = 60,
                    Location = new Point(0, 4)
                };
                // 添加文本框
                TextBox textBox = new TextBox
                {
                    Location = new Point(63, 0), //坐标
                    Width = 120,
                    Height = 26,
                    //设置一个name加id
                    Name = "txtAppraisalType_" + ac.Id
                };
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
                flp.Controls.Add(panel);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var flCtrs = flp.Controls;
            foreach (Control flCtr in flCtrs)
            {
                // 获取flp控件内的控件
                if (flCtr is Panel)
                {
                    var plCtrs = flCtr.Controls;
                    foreach (var plCtr in plCtrs)
                    {
                        if (plCtr is TextBox)
                        {
                            int acId = Convert.ToInt32(((TextBox)plCtr).Name.Split('_')[1]);
                            int count =Convert.ToInt32(((TextBox)plCtr).Text);
                            // 删除
                            UserAppraisals.Delete(_userId, _year, acId);
                            UserAppraisals userAppraisals = new UserAppraisals
                            {
                                UserId = _userId,
                                CoefficientId = acId,
                                AssessmentYear = _year,
                                Count = count,
                                IsDel=false
                            };
                            // 添加
                            UserAppraisals.Insert(userAppraisals);
                        }
                    }
                }  
            }
            MessageBox.Show("修改成功");
            _bindDgv();
            this.Close();
        }
    }
}
