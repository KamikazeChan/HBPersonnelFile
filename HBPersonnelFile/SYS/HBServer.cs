using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace HBPersonnelFile
{
    //调用远程服务
    class RemoteServer
    {
        /// <summary>
        /// 获取DataTable
        /// </summary>
        /// <param name="sql">执行语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable GetTable(string sql)
        {
            
            //JXCClient
            using (JXCClient.JXCServiceClient svc = new JXCClient.JXCServiceClient())
            {
                DataTable dt =svc.GetTable(sql, User.UserID);
                return dt;
            }
          
        }
    

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">执行语句</param>
        /// <returns>返回影响行数</returns>
        public static int ExecSQL(string sql)
        {
            using (JXCClient.JXCServiceClient svc = new JXCClient.JXCServiceClient())
            {
                int count = svc.ExecSQL(sql, User.UserID);
                return count;
            }
        }

        /// <summary>
        /// 执行SQL语句,返回第一行第一列的值
        /// </summary>
        /// <param name="sql">执行语句</param>
        /// <returns>返回一个值</returns>
     
   
        public static T ExecScalar<T>(string sql)
        {
            //string sql2 = Secret_string.EncryptDES(sql);
            using (JXCClient.JXCServiceClient svc = new JXCClient.JXCServiceClient())
            {
                object result =svc.ExecuteScalar(sql,User.UserID);
                if (result != null)
                {
                    return (T)Convert.ChangeType(result, typeof(T)); ;
                }
                return default(T);
            }
          
        }

        /// <summary>
        /// 获取服务器时间
        /// </summary>
        /// <returns>返回DateTime</returns>
        public static DateTime GetServerTime(int uid)
        {
            using (JXCClient.JXCServiceClient svc = new JXCClient.JXCServiceClient())
            {
                return svc.GetServerTime(uid);
              
            }
        }
    }
}
