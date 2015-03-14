using System;
using System.Data;
using System.Collections.Generic;
using HBPersonnelFile;
using System.Text;
namespace Model
{

    /// <summary>
    /// 用户的权限, 采用key-value方式, UserID-MenuIDs, 其中MenuIDs是以逗号分隔菜单ID
    /// </summary>
    public partial class TUserAuth
    {
        //public List<TUserAuth> GetListByUserID(int userID)
        //{
        //    var sql = string.Format("select * from  Tqx权限菜单 where UserID={0}", userID);
        //    var dt = RemoteServer.GetTable(sql);
        //    return ConvertToList(dt);
        //}

        /// <summary>
        /// 返回用户的权限菜单(一般用在登陆时候读取权限)
        /// </summary>
        /// <param name="userID">用户ID</param>
        /// <returns></returns>
        public TUserAuth GetEntityByUserID(int userID)
        {
            var sql = string.Format("select * from  Tqx权限菜单 where UserID={0}", userID);
            var dt = RemoteServer.GetTable(sql);
            if (dt.Rows.Count < 1)
            {
                return null;
            }
            else
            {
                return ConvertToList(dt)[0];
            }
        }

        /// <summary>
        /// 将菜单树的ID添加到用户的菜单ID列表
        /// </summary>
        /// <param name="ids">要增加的ID列表</param>
        /// <returns>保存到数据库是否成功, 0表示失败, 1表示成功.</returns>
        public int MergeAndSave(List<int> ids)
        {
            //本地ID数组
            var strlst = MenuIDs.Split(',');
            List<int> local = new List<int>();
            foreach (var item in strlst)
            {
                if(item.Length>0)
                    local.Add(int.Parse(item));
            }
            //要增加的ID数组
            foreach (var i in ids)
            {
                if (!local.Contains(i))
                    local.Add(i);
            }
            //将ID数组转回字符串
            var sb = new StringBuilder();
            foreach (var i in local)
            {
                sb.Append("," + i.ToString());
            }
            var laststr = sb.ToString();
            if (laststr.Length > 0)
                laststr = laststr.Substring(1);
            MenuIDs = laststr;
            //保存到数据库
            return  Save();
        }
        public int Save()
        {
            var sql = "";
            if (ID>0)
            {
                sql =string.Format( "UPDATE Tqx权限菜单 SET MenuIDs ='{0}' where ID={1} ",this.MenuIDs,ID);
            }
            else
            {
                sql =string.Format("INSERT INTO Tqx权限菜单(UserID, MenuIDs) VALUES({0},'{1}')",this.UserID,MenuIDs);
            }
            return RemoteServer.ExecSQL(sql);
        }

        internal int DeleteAndSave(List<int> ids)
        {
            //本地ID数组
            var strlst = MenuIDs.Split(',');
            List<int> local = new List<int>();
            foreach (var item in strlst)
            {
                if (item.Length > 0)
                    local.Add(int.Parse(item));
            }
            //要增加的ID数组
            foreach (var i in ids)
            {
                local.Remove(i);
            }
            //将ID数组转回字符串
            var sb = new StringBuilder();
            foreach (var i in local)
            {
                sb.Append("," + i.ToString());
            }
            var laststr = sb.ToString();
            if (laststr.Length > 0)
                laststr = laststr.Substring(1);
            MenuIDs = laststr;
            //保存到数据库
            return Save();
        }
    }
}
