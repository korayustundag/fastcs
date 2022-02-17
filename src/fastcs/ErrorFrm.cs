using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastcs
{
    public partial class ErrorFrm : Form
    {
        public ErrorFrm()
        {
            InitializeComponent();
        }
        public string ErrorMessage { get; set; }
        private void ErrorFrm_Load(object sender, EventArgs e)
        {
            errMsgBox1.Text = ErrorMessage;
        }
    }
}
