using System;
using System.Data;
using System.Collections.Generic;
using HBPersonnelFile;
namespace Model
{
    public class Tyg员工
    {
        public int ID { get; set; }
        public string X姓名 { get; set; }
        public string X性别 { get; set; }
        public string Z帐号 { get; set; }
        public string M密码 { get; set; }
        public string Y员工类型 { get; set; }
        public string Z状态 { get; set; }
        public string B部门 { get; set; }
        public string D电话 { get; set; }
        public string R入职日期 { get; set; }
        public string L离职日期 { get; set; }
        public int C出生年份 { get; set; }
        public int C出生月份 { get; set; }
        public int N年假 { get; set; }
        public int S剩余年假 { get; set; }
        public double S社保 { get; set; }
        public double G公积金 { get; set; }
        public double G工会费 { get; set; }
        public double T特困基金 { get; set; }
        public int P排序 { get; set; }

        public List<Tyg员工> ConvertToList(DataTable dt)
        {
            var lst = new List<Tyg员工>();
            foreach (DataRow dr in dt.Rows)
            {
                var i = new Tyg员工()
                {
                    ID = int.Parse(dr["ID"].ToString()),
                    X姓名 = dr["X姓名"].ToString(),
                    X性别 = dr["X性别"].ToString(),
                    Z帐号 = dr["Z帐号"].ToString(),
                    M密码 = dr["M密码"].ToString(),
                    Y员工类型 = dr["Y员工类型"].ToString(),
                    Z状态 = dr["Z状态"].ToString(),
                    B部门 = dr["B部门"].ToString(),
                    D电话 = dr["D电话"].ToString(),
                    R入职日期 = dr["R入职日期"].ToString(),
                    L离职日期 = dr["L离职日期"].ToString(),
                    C出生年份 = int.Parse(dr["C出生年份"].ToString()),
                    C出生月份 = int.Parse(dr["C出生月份"].ToString()),
                    N年假 = int.Parse(dr["N年假"].ToString()),
                    S剩余年假 = int.Parse(dr["S剩余年假"].ToString()),
                    S社保 = double.Parse(dr["S社保"].ToString()),
                    G公积金 = double.Parse(dr["G公积金"].ToString()),
                    G工会费 = double.Parse(dr["G工会费"].ToString()),
                    T特困基金 = double.Parse(dr["T特困基金"].ToString()),
                    P排序 = int.Parse(dr["P排序"].ToString()),
                };
                lst.Add(i);
            };
            return lst;
        }

        public List<Tyg员工> FindEmployeeByName(string name)
        {
            var sql =string.Format( "select * from Tyg员工  where X姓名='{0}'",name);
            return ConvertToList(RemoteServer.GetTable(sql));
        }
    }
}

