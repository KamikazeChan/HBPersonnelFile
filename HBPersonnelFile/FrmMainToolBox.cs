using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HBPersonnelFile
{
    public partial class FrmMainToolBox : DockContent
    {
        Form Mfrm;

        public FrmMainToolBox()
        {
            InitializeComponent();
        }

        public FrmMainToolBox(Form ParentForm): this()
        {
            Mfrm = ParentForm;
        }
    }
}
