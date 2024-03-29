﻿using System;
namespace multisLauncher
{
    partial class LogWindow
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
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(560, 254);
            this.LogBox.TabIndex = 0;
            this.LogBox.Text = "";
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 254);
            this.Controls.Add(this.LogBox);
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.ResumeLayout(false);

        }

        #endregion



        public void printMsg(string message)
        {
            LogBox.Text +=  ("\n [MSG]:" + message);
        }
        public void printErr(string error)
        {
            LogBox.Text += ("\n[ERROR]:" + error);
        }

        public void printText(string text)
        {
            LogBox.Text += ("\n" + text);
        }

        public void printCustom(string index,string customText)
        {
            LogBox.Text += ("\n [" + index + "]:" + customText);
        }

        private System.Windows.Forms.RichTextBox LogBox;

    }
}