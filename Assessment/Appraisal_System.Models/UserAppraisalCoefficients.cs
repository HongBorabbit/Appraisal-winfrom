using Appraisal_System.Utility;
using Assessment.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appraisal_System.Models
{
   public class UserAppraisalCoefficients
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoefficientId { get; set; }
        public int Count { get; set; }
        public string AssessmentYear { get; set; }
        public string AppraisalType { get; set; }
        public string AppraisalCoefficient { get; set; }
        public string CalculationMethod { get; set; }
        public bool IsDel { get; set; }

        /// <summary>
        /// 获取数据
        /// </summary>
        public static List<UserAppraisalCoefficients> ListAll()
        {
            List<UserAppraisalCoefficients> userAppraisalCoefficients = new List<UserAppraisalCoefficients>();
            DataTable dt = SqlHelper.ExecuteTable("SELECT ua.*,a.AppraisalType,a.AppraisalCoefficient,a.CalculationMethod FROM  UserAppraisals ua LEFT JOIN AppraisalCoefficients a on ua.CoefficientId = a.Id");
            foreach (DataRow dr in dt.Rows)
            {
                userAppraisalCoefficients.Add(dr.DataRowToModel<UserAppraisalCoefficients>());
            }
            return userAppraisalCoefficients;
        }
    }
}
