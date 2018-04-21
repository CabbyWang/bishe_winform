using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class defaultWindow : ClinicSystem.parent_main
    {
        public defaultWindow()
        {
            InitializeComponent();
        }

        public defaultWindow(String op)
        {
            lb_op.Text = op;
        }
    }
}
