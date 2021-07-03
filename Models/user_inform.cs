using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Common;

namespace WebApplication1.Models
{
    public class user_inform
    {
        public string User_number { get; set; }
        public int User_type { get; set; }
        public string Name { get; set; }
        public string Confirm_password { get; set; }
        public string Gender { get; set; }
        public string Residence { get; set; }
        public string Dorm { get; set; }
        public string Office { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Createtime { get; set; }
        

        public static List<user_inform> GetUserLists()
        {
            DataTable dt = Mysqlhelper.ExecuteTable("select * from user_inform");
            List<user_inform> users = new List<user_inform>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                users.Add(ToModel(dt.Rows[i]));
            }
            return users;
        }
        private static user_inform ToModel(DataRow dr)
        {
            user_inform user = new user_inform();
            user.User_number = dr["user_number"].ToString();
            user.User_type = (int)dr["user_type"];
            user.Name = dr["name"].ToString();
            user.Confirm_password = dr["confirm_password"].ToString();
            user.Gender = dr["gender"].ToString();
            user.Residence = dr["residence"].ToString();
            user.Dorm = dr["dorm"].ToString();
            user.Office = dr["office"].ToString();
            user.Mail = dr["mail"].ToString();
            user.Phone = dr["phone"].ToString();
            user.Createtime = dr["create_time"].ToString();
            return user;
        }

    }
}
