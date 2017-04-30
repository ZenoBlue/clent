using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MessageClient
{
    class DataBase
    {
        public bool flag = false;
        public static string result = null;
        #region
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回MySqlConnection对象</returns>
        public  MySqlConnection  getmysqlcon()
     {
            string constr = "server=localhost;User Id=root;password=;Database=info";
       
               
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
            // MySqlCommand mycmd = new MySqlCommand("insert into login_schema(usr_Name,usr_Password) values('adb','8ujdj')", mycon);
            // if (mycmd.ExecuteNonQuery() > 0)
            // {
            //     MessageBox.Show("ok");
            // }
            //mycon.Close();
                flag = true;
                return mycon;
              
            
    }
     #endregion 
     #region  执行MySqlCommand命令
      /// <summary>
     /// 执行MySqlCommand
     /// </summary>
     /// <param name="M_str_sqlstr">SQL语句</param>
     public void getmysqlcom(string M_str_sqlstr)
     {
         MySqlConnection mysqlcon = this.getmysqlcon();
         mysqlcon.Open();
         MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
         mysqlcom.ExecuteNonQuery();
         mysqlcom.Dispose();
         mysqlcon.Close();
         mysqlcon.Dispose();
     }
     #endregion
 
 #region  创建MySqlDataReader对象
     /// <summary>
     /// 创建一个MySqlDataReader对象
     /// </summary>
     /// <param name="M_str_sqlstr">SQL语句</param>
     /// <returns>返回MySqlDataReader对象</returns>
     public MySqlDataReader getmysqlread(string M_str_sqlstr)
     {
         MySqlConnection mysqlcon = this.getmysqlcon();
         MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            // mysqlcon.Open();
         MySqlDataReader  mysqlread = mysqlcom.ExecuteReader();
         return mysqlread;
     }
    }
}
#endregion
