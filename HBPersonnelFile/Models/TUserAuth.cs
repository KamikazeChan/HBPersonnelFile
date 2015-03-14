using System;
using System.Data;
using System.Collections.Generic;
namespace Model
{
    /// <summary>
    /// 用户的权限, 采用key-value方式, UserID-MenuIDs, 其中MenuIDs是以逗号分隔菜单ID
    /// </summary>
    public partial class TUserAuth
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string MenuIDs { get; set; }

        public List<TUserAuth> ConvertToList(DataTable dt)
        {
            var lst = new List<TUserAuth>();
            foreach (DataRow dr in dt.Rows)
            {
                var i = new TUserAuth()
                {
                    ID = int.Parse(dr["ID"].ToString()),
                    UserID = int.Parse(dr["UserID"].ToString()),
                    MenuIDs = dr["MenuIDs"].ToString(),
                };
                lst.Add(i);
            };
            return lst;
        }
    }
}
