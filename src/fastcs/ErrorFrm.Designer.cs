﻿namespace fastcs
{
    partial class ErrorFrm
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
            this.errMsgBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // errMsgBox1
            // 
            this.errMsgBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errMsgBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgBox1.Location = new System.Drawing.Point(0, 0);
            this.errMsgBox1.Name = "errMsgBox1";
            this.errMsgBox1.ReadOnly = true;
            this.errMsgBox1.Size = new System.Drawing.Size(848, 166);
            this.errMsgBox1.TabIndex = 0;
            this.errMsgBox1.Text = "";
            // 
            // ErrorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 166);
            this.Controls.Add(this.errMsgBox1);
            this.MinimizeBox = false;
            this.Name = "ErrorFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler Error - Fast C# Compiler";
            this.Load += new System.EventHandler(this.ErrorFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox errMsgBox1;
    }
}