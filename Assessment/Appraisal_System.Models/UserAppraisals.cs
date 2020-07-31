using Appraisal_System.Utility;
using Assessment.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appraisal_System.Models
{
   public  class UserAppraisals
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CoefficientId { get; set; }
        public int Count { get; set; }
        public string AssessmentYear { get; set; }
        public bool IsDel { get; set; }
        /// <summary>
        /// 根据用户id 和年份查询
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="year">年份</param>
        /// <returns></returns>
        public static List<UserAppraisals> ListByUserIdAndYear(int userId,string year)
        {
            List<UserAppraisals> userAppraisals = new List<UserAppraisals>();
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM UserAppraisals WHERE UserId =@UserId and AssessmentYear =@AssessmentYear",
                new SqlParameter("@UserId",userId),
                new SqlParameter("@AssessmentYear", year));
            foreach (DataRow dr in dt.Rows)
            {
                userAppraisals.Add(dr.DataRowToModel<UserAppraisals>());
            }
            return userAppraisals;
        }
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="userAppraisals">userAppraisals对象</param>
        public static void Insert(UserAppraisals userAppraisals)
        {
            SqlHelper.ExecuteNonQuery("INSERT INTO UserAppraisals (UserId,CoefficientId,Count,AssessmentYear,IsDel) VALUES (@UserId,@CoefficientId,@Count,@AssessmentYear,@IsDel)",
                new SqlParameter("@UserId",userAppraisals.UserId),
                new SqlParameter("@CoefficientId", userAppraisals.CoefficientId),
                new SqlParameter("@Count", userAppraisals.Count),
                new SqlParameter("@AssessmentYear", userAppraisals.AssessmentYear),
                new SqlParameter("@IsDel", userAppraisals.IsDel)
                );
        }
        /// <summary>
        /// 删除当前考核
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="AssessmentYear"></param>
        /// <param name="CoefficientId"></param>
        public static void Delete(int UserId,string AssessmentYear,int CoefficientId)
        {
            SqlHelper.ExecuteNonQuery("DELETE FROM UserAppraisals WHERE UserId=@UserId and AssessmentYear =@AssessmentYear and CoefficientId = @CoefficientId",
                new SqlParameter("@UserId",UserId),
                new SqlParameter("@AssessmentYear", AssessmentYear),
                new SqlParameter("@CoefficientId", CoefficientId)
                );
        }
    }
}
