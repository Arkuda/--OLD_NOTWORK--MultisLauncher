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
            this.LogBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(0, 0);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(522, 254);
            this.LogBox.TabIndex = 0;
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 254);
            this.Controls.Add(this.LogBox);
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LogBox;


        public void printMsg(string message)
        {
            LogBox.Items.Add("[MSG]:" + message);
        }
        public void printErr(string error)
        {
            LogBox.Items.Add("[ERROR]:" + error);
        }

        public void printText(string text)
        {
            LogBox.Items.Add(text);
        }

        public void printCustom(string index,string customText)
        {
            LogBox.Items.Add("["+index+"]:"+customText);
        }
    }
}