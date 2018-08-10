using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using POS_System.GeterSetter;
using System.Data.SqlServerCe;
namespace POS_System.DAL
{
    class CategoriesDAL
    {
        static string myconnstrng = Program.CS;// ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlCeConnection con = new SqlCeConnection(myconnstrng);
            try
            {
                SqlCeCommand cmd = new SqlCeCommand("Select * from tbl_categories", con);
                SqlCeDataAdapter sqlDataAdapter = new SqlCeDataAdapter(cmd);
                con.Open();
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Mymessage mymessage = new Mymessage(ex.Message);
                mymessage.Show();
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion

        #region Insertion Method
        public bool Insert(CategoryBLL c)
        {
            bool isSuccess = false;
            SqlCeConnection con = new SqlCeConnection(myconnstrng);
            try
            {
                string com = "INSERT INTO tbl_categories (title,description,added_date,added_by) VALUES (@title,@description,@added_date,@added_by)";
                SqlCeCommand cmd = new SqlCeCommand(com, con);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

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
                Mymessage mymessage = new Mymessage(ex.Message);
                mymessage.Show();
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }
        #endregion

        #region update Method
        public bool update(CategoryBLL c)
        {

            //Creating Boolean variable and set its default value to false
            bool isSuccess = false;

            //Creating SQL Connection
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //Query to Update Category
                string sql = "UPDATE tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //SQl Command to Pass the Value on Sql Query
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //Passing Value using cmd
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                //Open DAtabase Connection
                conn.Open();

                //Create Int Variable to execute query
                int rows = cmd.ExecuteNonQuery();

                //if the query is successfully executed then the value will be grater than zero 
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
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

        #region Delete Method
        public bool Delete(CategoryBLL c)
        {
            //Create a Boolean variable and set its value to false
            bool isSuccess = false;

            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //SQL Query to Delete from Database
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                SqlCeCommand cmd = new SqlCeCommand(sql, conn);
                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@id", c.id);

                //Open SqlConnection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executd successfully then the value of rows will be greater than zero else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Faied to Execute Query
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

        #region Search
        public DataTable Search(String keywords)
        {
            DataTable dt = new DataTable();
            SqlCeConnection con = new SqlCeConnection(myconnstrng);
            try
            {
                string comm="Select * from tbl_categories where id like '%"+keywords+ "%' OR title like '%" + keywords + "%' OR description like '%" + keywords + "%'";
                SqlCeCommand cmd = new SqlCeCommand(comm, con);
                SqlCeDataAdapter sqlDataAdapter = new SqlCeDataAdapter(cmd);
                con.Open();
                sqlDataAdapter.Fill(dt);
            }catch(Exception ex)
            {
                Mymessage mymessage = new Mymessage(ex.Message);
                mymessage.Show();
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
    }
}
