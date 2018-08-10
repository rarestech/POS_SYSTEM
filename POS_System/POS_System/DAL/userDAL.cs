using POS_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
namespace POS_System.GeterSetter
{
    class UserDAL
    {


        static string myconnstrng = Program.CS;//ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

           #region Select Data From Data Base
           public DataTable select()
           {
               SqlCeConnection con = new SqlCeConnection(myconnstrng);
               DataTable dt = new DataTable();
               try
               {
                   string comm = "select * from tbl_users";
                   SqlCeCommand cmd = new SqlCeCommand(comm, con);
                   SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(cmd);
                   con.Open();
                   dataAdapter.Fill(dt);
               }
               catch (Exception ex)
               {
                   Mymessage myMessageBox = new Mymessage(ex.Message);
                   myMessageBox.Show();
               }
               finally
               {
                   con.Close();
               }
               return dt;
           }
           #endregion

           #region Insert Data In DataBase
           public bool Insert(UserBLL u)
           {
               bool isSuccess = false;
               SqlCeConnection con = new SqlCeConnection(myconnstrng);
               try
               {
                   string comm = "INSERT into tbl_users (first_name,last_name,email,username,password,contact,address,gender,user_type,added_date,added_by) VALUES (@first_name,@last_name,@email,@username,@password,@contact,@address,@gender,@user_type,@added_date,@added_by)";
                   SqlCeCommand cmd = new SqlCeCommand(comm, con);

                   cmd.Parameters.AddWithValue("@first_name", u.First_Name);
                   cmd.Parameters.AddWithValue("@last_name", u.Last_Name);
                   cmd.Parameters.AddWithValue("@email", u.EMail);
                   cmd.Parameters.AddWithValue("@username", u.UserName);
                   cmd.Parameters.AddWithValue("@password", u.Password);
                   cmd.Parameters.AddWithValue("@contact", u.Contact);
                   cmd.Parameters.AddWithValue("@address", u.Address);
                   cmd.Parameters.AddWithValue("@gender", u.Gender);
                   cmd.Parameters.AddWithValue("@user_type", u.UserType);
                   cmd.Parameters.AddWithValue("@added_date", u.Added_Date);
                   cmd.Parameters.AddWithValue("@added_by", u.Added_By);

                   con.Open();

                   int rows = cmd.ExecuteNonQuery();
                   if (rows > 0)
                   {
                       isSuccess = true;
                   }
                   else
                   {
                       isSuccess = false;
                   }
               }
               catch (Exception ex)
               {
                   Mymessage myMessageBox = new Mymessage(ex.Message);
                   myMessageBox.Show();
               }
               finally
               {
                   con.Close();
               }
               return isSuccess;
           }
           #endregion 

           #region Update Data in DataBase
           public bool Update(UserBLL u)
           {
               SqlCeConnection con = new SqlCeConnection(myconnstrng);
            bool isSuccess = false;
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_users SET first_name=@first_name, last_name=@last_name, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, user_type=@user_type, added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.First_Name);
                cmd.Parameters.AddWithValue("@last_name", u.Last_Name);
                cmd.Parameters.AddWithValue("@email", u.EMail);
                cmd.Parameters.AddWithValue("@username", u.UserName);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@contact", u.Contact);
                cmd.Parameters.AddWithValue("@address", u.Address);
                cmd.Parameters.AddWithValue("@gender", u.Gender);
                cmd.Parameters.AddWithValue("@user_type", u.UserType);
                cmd.Parameters.AddWithValue("@added_date", u.Added_Date);
                cmd.Parameters.AddWithValue("@added_by", u.Added_By);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Successfull
                    isSuccess = true;
                }
                else
                {
                    //Query Failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                Mymessage mymessage = new Mymessage(ex.Message);
                mymessage.Show();
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
           #endregion 

          #region Delete Data From DataBase
           public bool Delete(UserBLL u)
           {
               bool issuccess = false;
               SqlCeConnection con = new SqlCeConnection(myconnstrng);
               try
               {
                   string comm = "DELETE FROM tbl_users where id=@id";
                   SqlCeCommand cmd = new SqlCeCommand(comm, con);
                   cmd.Parameters.AddWithValue("@id", u.id);
                   con.Open();
                   int rows = cmd.ExecuteNonQuery();
                   if (rows > 0)
                   {
                       issuccess = true;
                   }
                   else
                   {
                       issuccess = false;
                   }
               }
               catch (Exception ex)
               {

                   Mymessage myMessageBox = new Mymessage(ex.Message);
                   myMessageBox.Show();
               }
               finally
               {
                   con.Close();
               }
               return issuccess;
           }
           #endregion  

           #region Search Data
           public DataTable Search(String keywords)
           {
               SqlCeConnection con = new SqlCeConnection(myconnstrng);
               DataTable dt = new DataTable();
               try
               {
                   string comm = "select * from tbl_users where id like '%"+keywords+ "%' OR first_name like '%" + keywords + "%' OR last_name like '%" + keywords + "%' OR username like '%" + keywords + "%'";
                   SqlCeCommand cmd = new SqlCeCommand(comm, con);
                   SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(cmd);
                   con.Open();
                   dataAdapter.Fill(dt);
               }
               catch (Exception ex)
               {
                   Mymessage myMessageBox = new Mymessage(ex.Message);
                   myMessageBox.Show();
               }
               finally
               {
                   con.Close();
               }
               return dt;
           }
           #endregion

           #region getting user Id from userName
           public UserBLL getIdFromUserName(string username)
           {
               UserBLL u = new UserBLL();
               SqlCeConnection con = new SqlCeConnection(myconnstrng);
               DataTable dt = new DataTable();
               try
               {
                   string query = "SELECT id from tbl_users WHERE username='" + username + "'";
                   SqlCeDataAdapter adapter = new SqlCeDataAdapter(query,con);
                   con.Open();
                   adapter.Fill(dt);
                   if (dt.Rows.Count > 0)
                   {
                       u.id = int.Parse(dt.Rows[0]["id"].ToString());
                   }

               }catch(Exception ex)
               {
                   Mymessage mymessage = new Mymessage(ex.Message);
               }
               finally
               {
                   con.Close();
               }
               return u;
           }
           #endregion 
    }
}
