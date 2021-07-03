using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebApplication1.Common
{
    public class Mysqlhelper
    {
        
        //DataTable dt;
        //MySqlConnection conn;  //操作数据库使用的对象
        //MySqlCommand cmd; //运行sql数据

        //获取数据和存储数据的两个方法
        //首先先下载包


        //获取数据的方法
        public static DataTable ExecuteTable(string sql)
        {
            //连接数据库的工作,open连接仓库
            String connetStr = "server=localhost;port=3306;user=root;password=123456; database=manage_demo;";
            MySqlConnection conn = new MySqlConnection(connetStr);
            conn.Open();
            //执行sql语句管家工作
            //查询表，包含所输的值都添加
            //sql = "select* from user_inform";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            
            //执行推车的功能
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //放在卡车里
            DataSet ds = new DataSet();
            //将推车的东西装入卡车
            adapter.Fill(ds);
            //返回索引第一个的表值
            return ds.Tables[0]; 
        }
    }
}
