using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace HBPersonnelFile
{
    //界面上一些常用操作
    class WinUI
    {
        public static void SetHeaderText(DataGridView dgv)
        {
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (c.HeaderText.Length == 1) return;//有ID列就只删除1次
                c.HeaderText = c.HeaderText.Remove(0, 1);
            }
        }
        public static void SetHeaderText2(DataGridView dgv)
        {
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                if (c.HeaderText.Length < 2) return;//有ID列就只删除1次
                c.HeaderText = c.HeaderText.Remove(0, 2);
            }
        }

        public static void FormatGrid(DataGridView dgv)
        {
            SetHeaderText(dgv);
            //SetRowNum(dgv);
            dgv.Columns["ID"].Visible = false;
        }

        public static void SetRowNum(DataGridView dgv)
        {
            dgv.RowPostPaint += (s, e) =>
            {
                using (SolidBrush b = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 6);
                }
            };
        }

        public static void DisableSote(DataGridView dgv)
        {
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        /// <summary>
        /// 获取数据表到下拉框里,数据表第一列是名称，第二列是值。
        /// </summary>
        /// <param name="cbox">下拉框名称</param>
        /// <param name="dt_temp">数据表名称，数据表第一列是名称，第二列是值。</param>
        public static void DTtoComboBox(ComboBox cbox, DataTable dt_temp)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Rows.Add("", "---请选择---");

            for (int i = 0; i < dt_temp.Rows.Count; ++i)
            {
                //0为名称 1为值
                dt.Rows.Add(dt_temp.Rows[i][1].ToString().Trim(), dt_temp.Rows[i][0].ToString().Trim());
            }

            cbox.DataSource = dt;
            cbox.DisplayMember = "NAME";
            cbox.ValueMember = "ID";
            //dt.Clear();
            
        }

        //public static void SetReadOnly(DataGridView dgv)
        //{
        //    foreach (DataGridViewColumn c in dgv.Columns)
        //    {
        //        c.ReadOnly = true;
        //    }
        //}

  











    }

    static class FSCBExtensions
    {
        public static void SetDoubleBuffered(this DataGridView dgv, bool b)
        {

            var dgvType = dgv.GetType();

            var pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);

            pi.SetValue(dgv, b, null);

        }


    }
}
