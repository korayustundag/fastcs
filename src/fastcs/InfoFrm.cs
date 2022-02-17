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
    public partial class InfoFrm : Form
    {
        public InfoFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Title = txtTitle.Text;
            Settings.ProductName = txtProductName.Text;
            Settings.Copyright = txtCopyright.Text;
            Settings.FileVersion = txtFileVersion.Text;
            Settings.AssemblyVersion = txtAssemblyVersion.Text;
            Close();
        }

        private void InfoFrm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = Settings.Title;
            txtProductName.Text = Settings.ProductName;
            txtCopyright.Text = Settings.Copyright;
            txtFileVersion.Text = Settings.FileVersion;
            txtAssemblyVersion.Text = Settings.AssemblyVersion;
        }
    }
}
