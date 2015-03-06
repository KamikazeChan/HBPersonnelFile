using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HBPersonnelFile
{
    public partial class MainForm : Form
    {
        public static Form sMainForm;
        private FrmMainToolBox FrmToolBox;

        public MainForm()
        {
            InitializeComponent();
            InitSystem();//初始化系统
        }

        private void InitSystem()
        {
            throw new NotImplementedException();
        }
    }
}
