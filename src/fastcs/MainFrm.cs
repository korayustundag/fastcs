using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fastcs
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            Settings.Title = "Project";
            Settings.ProductName = "Project";
            Settings.Copyright = "Copyright ©  2022";
            Settings.FileVersion = "1.0.0.0";
            Settings.AssemblyVersion = "1.0.0.0";
        }

        public MainFrm(string arg)
        {
            InitializeComponent();
            Settings.Title = "Project";
            Settings.ProductName = "Project";
            Settings.Copyright = "Copyright ©  2022";
            Settings.FileVersion = "1.0.0.0";
            Settings.AssemblyVersion = "1.0.0.0";
            if (File.Exists(arg))
            {
                codeBox1.Text = File.ReadAllText(arg);
            }
        }

        AssemInfo inf = new AssemInfo();

        private void btnRun_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            string Output;
            if (!string.IsNullOrWhiteSpace(txtOutputName.Text))
            {
                Output = txtOutputName.Text;
            }
            else
            {
                Output = "App.exe";
            }
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.OutputAssembly = Output;
            var unit = new CodeCompileUnit();
            unit.AssemblyCustomAttributes.Add(inf.Description());
            unit.AssemblyCustomAttributes.Add(inf.FileVersion(Settings.FileVersion));
            unit.AssemblyCustomAttributes.Add(inf.Version(Settings.AssemblyVersion));
            unit.AssemblyCustomAttributes.Add(inf.Title(Settings.Title));
            unit.AssemblyCustomAttributes.Add(inf.Copyright(Settings.Copyright));
            unit.AssemblyCustomAttributes.Add(inf.ProductName(Settings.ProductName));
            var assemblyInfo = new StringWriter();
            codeProvider.GenerateCodeFromCompileUnit(unit, assemblyInfo, new CodeGeneratorOptions());
            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters,new string[] { codeBox1.Text ,assemblyInfo.ToString()});
            if (results.Errors.Count > 0)
            {
                string errMsg = "";
                foreach (CompilerError CompErr in results.Errors)
                {
                    errMsg += "------------------------------" + Environment.NewLine + "Line number " + CompErr.Line + Environment.NewLine + "Error Number: " + CompErr.ErrorNumber + Environment.NewLine + "Error Text: " + CompErr.ErrorText + Environment.NewLine;
                }
                MessageBox.Show("Compiler Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorFrm efm = new ErrorFrm();
                efm.ErrorMessage = errMsg.ToString();
                efm.ShowDialog();
            }
            else
            {
                try
                {
                    Process.Start(Output);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Run command error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAssemInf_Click(object sender, EventArgs e)
        {
            InfoFrm frm = new InfoFrm();
            frm.ShowDialog();
        }
    }
}
