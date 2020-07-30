using Assessment.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Models
{
   public class AppraisalBases
    {
        public int Id { get; set; }
        public string BaseType { get; set; }
        public int AppraisalBase { get; set; }
        public bool  IsDel{ get; set; }

        public static List<AppraisalBases> ListAll()
        {
            List<AppraisalBases> appraisalBases = new List<AppraisalBases>();          
            DataTable dt = SqlHelper.ExecuteTable("SELECT * FROM AppraisalBases");
            foreach (DataRow dr in dt.Rows)
            {
                appraisalBases.Add(ToModel(dr));
            }
            return appraisalBases;
        }
        private static AppraisalBases ToModel(DataRow dr)
        {
            AppraisalBases appraisalBases = new AppraisalBases();
            appraisalBases.Id = (int)dr["Id"];
            appraisalBases.BaseType = dr["BaseType"].ToString();
            appraisalBases.AppraisalBase = (int)dr["AppraisalBase"];
            appraisalBases.IsDel = (bool)dr["IsDel"];
            return appraisalBases;
        }
    }
}
