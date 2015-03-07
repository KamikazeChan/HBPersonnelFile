using System;
using System.Data;
using System.Collections.Generic;
namespace Model
{
    public class Tcd菜单
    {
        public int ID { get; set; }
        public int TypeOrder { get; set; }
        public string NType { get; set; }
        public string FuncName { get; set; }
        public int SOrder { get; set; }
        public string FormName { get; set; }
        public bool Display { get; set; }

        public List<Tcd菜单> ConvertToList(DataTable dt)
        {
            var lst = new List<Tcd菜单>();
            foreach (DataRow dr in dt.Rows)
            {
                var i = new Tcd菜单()
                {
                    ID = int.Parse(dr["ID"].ToString()),
                    TypeOrder = int.Parse(dr["TypeOrder"].ToString()),
                    NType = dr["NType"].ToString(),
                    FuncName = dr["FuncName"].ToString(),
                    SOrder = int.Parse(dr["SOrder"].ToString()),
                    FormName = dr["FormName"].ToString(),
                    Display = bool.Parse(dr["Display"].ToString()),
                };
                lst.Add(i);
            };
            return lst;
        }
    }
}
