﻿
namespace Lab_NetFramework
{
    partial class Form1
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
            this.controlDeUsuario11 = new Lab_NetFramework.ControlDeUsuario1();
            this.SuspendLayout();
            // 
            // controlDeUsuario11
            // 
            this.controlDeUsuario11.Location = new System.Drawing.Point(12, 12);
            this.controlDeUsuario11.Name = "controlDeUsuario11";
            this.controlDeUsuario11.Size = new System.Drawing.Size(317, 211);
            this.controlDeUsuario11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 245);
            this.Controls.Add(this.controlDeUsuario11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlDeUsuario1 controlDeUsuario11;
    }
}

