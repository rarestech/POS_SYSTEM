using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_System.BLL
{
   public class UserBLL
    {
        public int id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string EMail { get; set; }

        public String UserName { get; set; }

        public string Password { get; set; }

        public string Contact { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public string UserType { get; set; }

        public DateTime Added_Date { get; set; }

        public int Added_By { get; set; }
    }
    
}
