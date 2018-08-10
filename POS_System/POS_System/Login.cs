using POS_System.DAL;
using POS_System.GeterSetter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
namespace POS_System
{
    public partial class Login : Form
    {
        static string myconnstrng =Program.CS ;//ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public static string loggedInUser;
        public Login()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             l.username = txtUserName.Text.Trim();
             l.password = txtPassword.Text.Trim();
             l.user_type = cmbUsertype.Text.Trim();

             bool issuccess = dal.loginCheck(l);
             if (issuccess == true)
             {
             Mymessage msg=   new Mymessage("Logged In Successfull!");
                 msg.Show();
                loggedInUser = txtUserName.Text;
                if (cmbUsertype.Text.Trim() == "admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    
                }
                else
                {
                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
                    
                }
             }
             else
             {
               Mymessage mymessage=  new Mymessage("Login Failed");
                 mymessage.Show();
             }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!CheckDataBaseExist())
            {
                Mymessage mymessage = new Mymessage("Database Connection Error");
                mymessage.Show();
            }
            else
            {
                Mymessage mymessage = new Mymessage("Database Connection Successfull");
                mymessage.Show();
            }
            txtUserName.Focus();
        }
        public bool CheckDataBaseExist()
        {
            SqlCeConnection connection = new SqlCeConnection(myconnstrng);
            try
            {
                connection.Open();
                return true;
            }
            catch(Exception ex)
            {
                Mymessage mymessage = new Mymessage(ex.Message);
                mymessage.Show();
                return false;
            }
        }
        public void GenerateDatabase()
        {
            List<string> cmds= new List<string>();
            if (File.Exists(Application.StartupPath + "\\Database.sql"))
            {
                TextReader tr = new StreamReader(Application.StartupPath + "\\Database.sql");
                string line = "";
                string cmd = "";
                while ((line = tr.ReadLine()) != null)
                {
                    if (line.Trim().ToUpper() == "GO")
                    {
                        cmds.Add(cmd);
                        cmd = "";
                    }
                    else
                    {
                        cmd += line + "\r\n";
                    }
                }
                if (cmd.Length > 0)
                {
                    cmds.Add(cmd);
                    cmd = "";
                }
                tr.Close();
            }
            if (cmds.Count > 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = new SqlConnection(myconnstrng);
                command.CommandType = System.Data.CommandType.Text;
                command.Connection.Open();
                for(int i = 0; i < cmds.Count; i++)
                {
                    command.CommandText = cmds[i];
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();


        }
    }
}
