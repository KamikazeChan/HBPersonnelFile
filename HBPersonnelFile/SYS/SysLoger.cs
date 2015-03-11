using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBPersonnelFile
{
    public class SysLoger
    {
        public static void  Info(string content)
        {
            string sql = string.Format("InsertSyslog 'Info','{0}',{1}",content,User.UserID);
            Task.Factory.StartNew(() => { RemoteServer.ExecSQL(sql); });
        }
        public static void Debug(string content)
        {
            string sql = string.Format("InsertSyslog 'Debug','{0}',{1}", content, User.UserID);
            Task.Factory.StartNew(() => { RemoteServer.ExecSQL(sql); });
        }
        public static void Warn(string content)
        {
            string sql = string.Format("InsertSyslog 'Warn','{0}',{1}", content, User.UserID);
            Task.Factory.StartNew(() => { RemoteServer.ExecSQL(sql); });
        }
        public static void Error(string content)
        {
            string sql = string.Format("InsertSyslog 'Error','{0}',{1}", content, User.UserID);
            Task.Factory.StartNew(() => { RemoteServer.ExecSQL(sql); });
        }

        //public static void Fatal(string content)
        //{
        //    string sql = string.Format("InsertSyslog 'Fatal','{0}',{1}", content, User.UserID);
        //    Task.Factory.StartNew(() => { RemoteServer.ExecSQL(sql); });
        //}

    }
}
