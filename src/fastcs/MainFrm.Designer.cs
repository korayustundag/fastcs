namespace fastcs
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssemInf = new System.Windows.Forms.Button();
            this.codeBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.codeBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C# Code";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(787, 465);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(120, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Compile and Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtOutputName
            // 
            this.txtOutputName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputName.Location = new System.Drawing.Point(670, 465);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.Size = new System.Drawing.Size(111, 23);
            this.txtOutputName.TabIndex = 2;
            this.txtOutputName.Text = "App.exe";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(581, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Name:";
            // 
            // btnAssemInf
            // 
            this.btnAssemInf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAssemInf.Location = new System.Drawing.Point(12, 465);
            this.btnAssemInf.Name = "btnAssemInf";
            this.btnAssemInf.Size = new System.Drawing.Size(124, 23);
            this.btnAssemInf.TabIndex = 4;
            this.btnAssemInf.Text = "Assembly Info";
            this.btnAssemInf.UseVisualStyleBackColor = true;
            this.btnAssemInf.Click += new System.EventHandler(this.btnAssemInf_Click);
            // 
            // codeBox1
            // 
            this.codeBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.codeBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.codeBox1.AutoScrollMinSize = new System.Drawing.Size(452, 252);
            this.codeBox1.BackBrush = null;
            this.codeBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.codeBox1.CharHeight = 18;
            this.codeBox1.CharWidth = 9;
            this.codeBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.codeBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeBox1.Font = new System.Drawing.Font("Consolas", 12F);
            this.codeBox1.IsReplaceMode = false;
            this.codeBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.codeBox1.LeftBracket = '(';
            this.codeBox1.LeftBracket2 = '{';
            this.codeBox1.Location = new System.Drawing.Point(3, 19);
            this.codeBox1.Name = "codeBox1";
            this.codeBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.codeBox1.RightBracket = ')';
            this.codeBox1.RightBracket2 = '}';
            this.codeBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.codeBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("codeBox1.ServiceColors")));
            this.codeBox1.Size = new System.Drawing.Size(889, 425);
            this.codeBox1.TabIndex = 0;
            this.codeBox1.Text = resources.GetString("codeBox1.Text");
            this.codeBox1.Zoom = 100;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 500);
            this.Controls.Add(this.btnAssemInf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = global::fastcs.Properties.Resources.cs_icon;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainFrm";
            this.Text = "Fast C# Compiler";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOutputName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssemInf;
        private FastColoredTextBoxNS.FastColoredTextBox codeBox1;
    }
}

