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
    public partial class FrmUserAppraisal : Form
    {
        public FrmUserAppraisal()
        {
            InitializeComponent();
        }
        Action bindDgv;
        private void FrmUserAppraisal_Load(object sender, EventArgs e)
        {
            SetCol();
            // 获取需要扩展的表
            bindDgvUserappraisal();
            bindDgv =bindDgvUserappraisal;
        }

        private void bindDgvUserappraisal()
        {
            DataTable dtUser = UserAppraisalBases.GetDtJoinAppraisal();
            // 获取系数表集合
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();
            // 填充
            foreach (var item in appraisalCoefficients)
            {
                //添加系数名
                dtUser.Columns.Add(new DataColumn
                {
                    ColumnName = "AppraisalType" + item.Id
                });
                // 添加系数值
                dtUser.Columns.Add(new DataColumn
                {
                    ColumnName = "AppRaisalCoefficient" + item.Id
                });
                // 添加计算方式
                dtUser.Columns.Add(new DataColumn
                {
                    ColumnName = "CalculationMethod" + item.Id
                });
            }

            // 考核年度
            dtUser.Columns.Add(new DataColumn
            {
                ColumnName = "AssessmentYear"
            });
            // 添加实发年终奖
            dtUser.Columns.Add(new DataColumn
            {
                ColumnName = "YearBonus"
            });
            // dtUser 填充数据
            List<UserAppraisalCoefficients> userAppraisalCoefficients = UserAppraisalCoefficients.ListAll();
            for (int i = 0; i < dtUser.Rows.Count; i++)
            {
                var uacFilter = userAppraisalCoefficients.FindAll
                    (m => m.UserId == (int)dtUser.Rows[i]["Id"] && m.AssessmentYear == cbxYear.Text);
                // 系数计算的数组，存放每个考核类型的总系数
                double[] yearbonusArray = new double[uacFilter.Count];
                for (int j = 0; j < uacFilter.Count; j++)
                {
                    // 获取AppraisalType对应的dtUser的ColumnName的值
                    // 获取考核次数
                    string appraisalTypeKey = "AppraisalType" + uacFilter[j].CoefficientId;
                    int appraisalTypeCountValue = uacFilter[j].Count;
                    // 获取考核系数
                    string appraisalCoefficientKey = "AppRaisalCoefficient" + uacFilter[j].CoefficientId;
                    int appraisalCoefficientValue = Convert.ToInt32(uacFilter[j].AppraisalCoefficient);
                    //获取计算方式
                    string calculationMethodKey = "CalculationMethod" + uacFilter[j].CoefficientId;
                    int calculationMethodValue = Convert.ToInt32(uacFilter[j].CalculationMethod);

                    //绑定 dtUser值
                    dtUser.Rows[i][appraisalTypeKey] = appraisalTypeCountValue;
                    dtUser.Rows[i][appraisalCoefficientKey] = appraisalCoefficientValue;
                    dtUser.Rows[i][calculationMethodKey] = calculationMethodValue;
                    yearbonusArray[j] = appraisalCoefficientValue * appraisalTypeCountValue * calculationMethodValue;
                }
                dtUser.Rows[i]["AssessmentYear"] = cbxYear.Text;
                // 结算实发年终奖
                double yearbonusAll = 0;
                for (int j = 0; j < yearbonusArray.Length; j++)
                {
                    yearbonusAll += yearbonusArray[j];
                }
                // 计算实发年终奖
                double yearBonus = (1 + yearbonusAll) * Convert.ToDouble(dtUser.Rows[i]["AppraisalBase"]);
                // 加入年终奖扣成负数则为0
                dtUser.Rows[i]["YearBonus"] = yearBonus < 0 ? 0 : yearBonus;
            }
            dgvUserAppraisal.AutoGenerateColumns = false;
            dgvUserAppraisal.DataSource = dtUser;
        }

        private void SetCol()
        {
            List<AppraisalCoefficients> appraisalCoefficients = AppraisalCoefficients.ListAll();

            List<DataGridViewTextBoxColumn> dataGridViewTextBoxColumns = new List<DataGridViewTextBoxColumn>();
            foreach (var appraisalCoefficient in appraisalCoefficients)
            {
                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = appraisalCoefficient.AppraisalType,
                    Name = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppraisalType" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Width = 88
                });
                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "系数",
                    Name = "AppRaisalCoefficient" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "AppRaisalCoefficient" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Visible = false,
                    Width = 88
                });
                dataGridViewTextBoxColumns.Add(new DataGridViewTextBoxColumn
                {
                    HeaderText = "计算方式",
                    Name = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    DataPropertyName = "CalculationMethod" + appraisalCoefficient.Id.ToString(),
                    ReadOnly = true,
                    Visible = false,
                    Width = 88
                });
            }
            dgvUserAppraisal.Columns.AddRange(dataGridViewTextBoxColumns.ToArray());
            dgvUserAppraisal.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "考核年度",
                Name = "AssessmentYear",
                DataPropertyName = "AssessmentYear",
                ReadOnly = true,
                Width = 166
            });
            dgvUserAppraisal.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "实发年终奖",
                Name = "YearBonus",
                DataPropertyName = "YearBonus",
                ReadOnly = true,
                Width = 166
            });
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvUserAppraisal_MouseDown(object sender, MouseEventArgs e)
        {
            tsmEdit.Visible = false;
        }

        private void dgvUserAppraisal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                if (e.RowIndex>1)
                {
                    dgvUserAppraisal.ClearSelection();
                    dgvUserAppraisal.Rows[e.RowIndex].Selected = true;
                }
            }
            tsmEdit.Visible = true;
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            // 传递id 和年份
            string year = cbxYear.Text;
            // 强制转换 后面的值必须自己知道是int的类型
            int userId=(int)dgvUserAppraisal.SelectedRows[0].Cells["Id"].Value;
            FrmUserAppraisalEdit frmUserAppraisalEdit = new FrmUserAppraisalEdit(userId, year, bindDgv);
            frmUserAppraisalEdit.ShowDialog();
        }
    }
}
