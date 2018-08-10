using POS_System.GeterSetter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlServerCe;
namespace POS_System.DAL
{
    class loginDAL
    {
        static string myConnString = Program.CS;//ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(loginBLL l)
        {
            bool isSuccess = false;
            SqlCeConnection con = new SqlCeConnection(myConnString);

            try
            {
                string comm = "select * from tbl_users WHERE username=@username and password=@password and user_type=@user_type";
                SqlCeCommand cmd = new SqlCeCommand(comm, con);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);

                DataTable dt=new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                    

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                new Mymessage(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        
    }
}
