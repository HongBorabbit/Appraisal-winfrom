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
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Sex { get; set; }
        public int BaseTypeId { get; set; }
        public bool IsDel { get; set; }

        public static List<Users> ListAll()
        {
            DataTable dt = SqlHelper.ExecuteTable("SELECT u.Id,u.PassWord,u.BaseTypeId,u.UserName,u.Sex,u.IsDel FROM Users u");
            List<Users> users = new List<Users>();
            foreach (DataRow dr in dt.Rows)
            {
                users.Add(dr.DataRowToModel<Users>()); ;
            }
            return users;
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static int Insert(Users users)
        {
            // 参数化
          int row= SqlHelper.ExecuteNonQuery($"INSERT INTO Users(UserName,PassWord,Sex,BaseTypeId,IsDel) VALUES (@UserName,@PassWord,@Sex,@BaseTypeId,@IsDel)",
                new SqlParameter("@UserName", users.UserName),
                new SqlParameter("@PassWord", users.PassWord),
                new SqlParameter("@Sex", users.Sex),
                new SqlParameter("@BaseTypeId", users.BaseTypeId),
                new SqlParameter("@IsDel", users.IsDel)
                );
            return row;
        }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static int Update(Users users)
        {

           return SqlHelper.ExecuteNonQuery("UPDATE Users SET PassWord=@PassWord,BaseTypeId=@BaseTypeId,UserName=@UserName,Sex=@Sex,IsDel=@IsDel WHERE Id=@Id",
                    new SqlParameter("@Id",users.Id),
                    new SqlParameter("@PassWord", users.PassWord),
                    new SqlParameter("@BaseTypeId", users.BaseTypeId),
                    new SqlParameter("@UserName", users.UserName),
                    new SqlParameter("@Sex", users.Sex),
                    new SqlParameter("@IsDel", users.IsDel)
                    );
        }

    }
}
