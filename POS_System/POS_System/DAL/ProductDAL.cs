﻿using POS_System.GeterSetter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
namespace POS_System.DAL
{
    class ProductDAL
    {
        static string myconnstrng = Program.CS;//ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select method for Product Module
        public DataTable Select()
        {
            //Create Sql Connection to connect Databaes
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //Writing the Query to Select all the products from database
                String sql = "SELECT * FROM tbl_products";

                //Creating SQL Command to Execute Query
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //SQL Data Adapter to hold the value from database temporarily
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);

                //Open DAtabase Connection
                conn.Open();

                adapter.Fill(dt);
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

            return dt;
        }
        #endregion
        #region Method to Insert Product in database
        public bool Insert(ProductsBLL p)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for DAtabase
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //SQL Query to insert product into database
                String sql = "INSERT INTO tbl_products (name, category, description, rate, qty, added_date, added_by) VALUES (@name, @category, @description, @rate, @qty, @added_date, @added_by)";

                //Creating SQL Command to pass the values
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //Passign the values through parameters
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                //Opening the Database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Execute Query
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
        #region Method to Update Product in Database
        public bool Update(ProductsBLL p)
        {
            //create a boolean variable and set its initial value to false
            bool isSuccess = false;

            //Create SQL Connection for DAtabase
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in dAtabase
                String sql = "UPDATE tbl_products SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //Create SQL Cmmand to pass the value to query
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);
                //Passing the values using parameters and cmd
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                //Open the Database connection
                conn.Open();

                //Create Int Variable to check if the query is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then the value of rows will be greater than 0 else it will be less than zero
                if (rows > 0)
                {
                    //Query ExecutedSuccessfully
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
        #region Method to Delete Product from Database
        public bool Delete(ProductsBLL p)
        {
            //Create Boolean Variable and Set its default value to false
            bool isSuccess = false;

            //SQL Connection for DB connection
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //Write Query Product from DAtabase
                String sql = "DELETE FROM tbl_products WHERE id=@id";

                //Sql Command to Pass the Value
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@id", p.id);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query is executed successfullly then the value of rows will be greated than 0 else it will be less than 0
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
        #region SEARCH Method for Product Module
        public DataTable Search(string keywords)
        {
            //SQL Connection fro DB Connection
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);
            //Creating DAtaTable to hold value from dAtabase
            DataTable dt = new DataTable();

            try
            {
                //SQL query to search product
                string sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";
                //Sql Command to execute Query
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //SQL Data Adapter to hold the data from database temporarily
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                adapter.Fill(dt);
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

            return dt;
        }
        #endregion
        #region METHOD TO SEARCH PRODUCT IN TRANSACTION MODULE
        public ProductsBLL GetProductsForTransaction(string keyword)
        {
            //Create an object of productsBLL and return it
            ProductsBLL p = new ProductsBLL();
            //SqlConnection
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);
            //Datatable to store data temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write the Query to Get the detaisl
                string sql = "SELECT name, rate, qty FROM tbl_products WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                //Create Sql Data Adapter to Execute the query
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(sql, conn);

                //Open DAtabase Connection
                conn.Open();

                //Pass the value from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to productsBLL
                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                }
            }
            catch (Exception ex)
            {
                Mymessage mymessage = new Mymessage(ex.Message);
                mymessage.Show();
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return p;
        }
        #endregion
        #region METHOD TO GET PRODUCT ID BASED ON PRODUCT NAME
        public ProductsBLL GetProductIDFromName(string ProductName)
        {
            //First Create an Object of DeaCust BLL and REturn it
            ProductsBLL p = new ProductsBLL();

            //SQL Conection here
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);
            //Data TAble to Holdthe data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Get id based on Name
                string sql = "SELECT id FROM tbl_products WHERE name='" + ProductName + "'";
                //Create the SQL Data Adapter to Execute the Query
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(sql, conn);

                conn.Open();

                //Passing the CAlue from Adapter to DAtatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return p;
        }
        #endregion
        #region METHOD TO GET CURRENT QUantity from the Database based on Product ID
        public decimal GetProductQty(int ProductID)
        {
            //SQl Connection First
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);
            //Create a Decimal Variable and set its default value to 0
            decimal qty = 0;

            //Create Data Table to save the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write WQL Query to Get Quantity from Database
                string sql = "SELECT qty FROM tbl_products WHERE id = " + ProductID;

                //Cerate A SqlCommand
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                //Create a SQL Data Adapter to Execute the query
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);

                //open DAtabase Connection
                conn.Open();

                //PAss the calue from Data Adapter to DataTable
                adapter.Fill(dt);

                //Lets check if the datatable has value or not
                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                }
            }
            catch (Exception ex)
            {
                Mymessage mymessage = new Mymessage(ex.Message);
                mymessage.Show();
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return qty;
        }
        #endregion
        #region METHOD TO UPDATE QUANTITY
        public bool UpdateQuantity(int ProductID, decimal Qty)
        {
            //Create a Boolean Variable and Set its value to false
            bool success = false;

            //SQl Connection to Connect Database
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //Write the SQL Query to Update Qty
                string sql = "UPDATE tbl_products SET qty=@qty WHERE id=@id";

                //Create SQL Command to Pass the calue into Queyr
                SqlCeCommand cmd = new SqlCeCommand(sql, conn);
                //Passing the VAlue trhough parameters
                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);

                //Open Database Connection
                conn.Open();

                //Create Int Variable and Check whether the query is executed Successfully or not
                int rows = cmd.ExecuteNonQuery();
                //Lets check if the query is executed Successfully or not
                if (rows > 0)
                {
                    //Query Executed Successfully
                    success = true;
                }
                else
                {
                    //Failed to Execute Query
                    success = false;
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

            return success;
        }
        #endregion
        #region METHOD TO INCREASE PRODUCT
        public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
        {
            //Create a Boolean Variable and SEt its value to False
            bool success = false;

            //Create SQL Connection To Connect DAtabase
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //Get the Current Qty From dAtabase based on id
                decimal currentQty = GetProductQty(ProductID);

                //Increase the Current Quantity by the qty purchased from Dealer
                decimal NewQty = currentQty + IncreaseQty;

                //Update the Prudcty Quantity Now
                success = UpdateQuantity(ProductID, NewQty);
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
            return success;
        }
        #endregion
        #region METHOD TO DECREASE PRODUCT
        public bool DecreaseProduct(int ProductID, decimal Qty)
        {
            //Create Boolean Variable and SEt its Value to false
            bool success = false;

            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            try
            {
                //Get the Current product Quantity
                decimal currentQty = GetProductQty(ProductID);

                //Decrease the Product Quantity based on product sales
                decimal NewQty = currentQty - Qty;

                //Update Product in Database
                success = UpdateQuantity(ProductID, NewQty);
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
            return success;
        }
        #endregion
        #region DESPLAY PRODUCTS BASED ON CATEGORIES
        public DataTable DisplayProductsByCategory(string category)
        {
            //Sql Connection First
            SqlCeConnection conn = new SqlCeConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Display Product Based on CAtegory
                string sql = "SELECT * FROM tbl_products WHERE category='" + category + "'";

                SqlCeCommand cmd = new SqlCeCommand(sql, conn);

                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);

                //Open Database Connection Here
                conn.Open();

                adapter.Fill(dt);
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

            return dt;
        }
        #endregion
    }
}
