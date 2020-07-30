using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assessment.Common
{
    public class SqlHelper
    {
        public static string Constr { get; set; }
        //读取数据
        public static DataTable ExecuteTable(string cmdText)
        {
            using (SqlConnection con = new SqlConnection(Constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdText, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText,params SqlParameter[] sqlParameters)
        {
            using (SqlConnection con = new SqlConnection(Constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdText, con);
                // params 参数
                cmd.Parameters.AddRange(sqlParameters);
                int rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    throw new Exception("数据库执行错误");
                }
                return rows;
            }
        }
    }
}
