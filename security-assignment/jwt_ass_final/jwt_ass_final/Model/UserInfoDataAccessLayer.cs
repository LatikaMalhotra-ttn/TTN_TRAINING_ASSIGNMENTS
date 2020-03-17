using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace jwt_ass_final.Model
{
    public class UserInfoDataAccessLayer
    {
        string constr = @"Data Source=.;database=jwt_ass;User id=SA;password=Programmer@4; Connection Timeout=15; Connection Lifetime=0; Min Pool Size=0; Max Pool Size=100; Pooling=True";
        public UserModel GetLoginUser(UserModel login)
        {
            var userInfo = new UserModel();
            using (SqlConnection con = new SqlConnection(constr))
            {
                
                    //will join 2 tables n fetch the data from database and store them in respective fields
                    string sql = string.Format(@"SELECT a.*,b.RoleName from UserInfo a                                
                                               inner join UserRole b on a.RoleId=b.RoleId
                                               Where LoginId='{0}' and UserPass='{1}'", login.LoginId, login.Password);

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = System.Data.CommandType.Text;
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        userInfo.UserId = Convert.ToInt32(rd["UserId"]);
                        userInfo.UserName = rd["UserName"].ToString();
                        userInfo.LoginId = rd["LoginId"].ToString();
                        userInfo.Password = rd["UserPass"].ToString();
                        userInfo.Email = rd["Email"].ToString();
                        userInfo.RoleName = rd["RoleName"].ToString();
                    }
                    return userInfo;
                
            }
        }
    }
}
