namespace multisLauncher
{
    partial class MultisLauncherMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultisLauncherMain));
            this.PlayButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.LSButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LauncherTabs = new System.Windows.Forms.TabControl();
            this.MPTab = new System.Windows.Forms.TabPage();
            this.NewsTab = new System.Windows.Forms.TabPage();
            this.MediaTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LauncherTabs.SuspendLayout();
            this.MPTab.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(65, 3);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(220, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            // 
            // LSButton
            // 
            this.LSButton.Location = new System.Drawing.Point(376, 3);
            this.LSButton.Name = "LSButton";
            this.LSButton.Size = new System.Drawing.Size(75, 23);
            this.LSButton.TabIndex = 2;
            this.LSButton.Text = "Login Server";
            this.LSButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(527, 3);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(676, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LauncherTabs
            // 
            this.LauncherTabs.Controls.Add(this.MPTab);
            this.LauncherTabs.Controls.Add(this.NewsTab);
            this.LauncherTabs.Controls.Add(this.MediaTab);
            this.LauncherTabs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LauncherTabs.Location = new System.Drawing.Point(0, 32);
            this.LauncherTabs.Name = "LauncherTabs";
            this.LauncherTabs.SelectedIndex = 0;
            this.LauncherTabs.Size = new System.Drawing.Size(799, 501);
            this.LauncherTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.LauncherTabs.TabIndex = 3;
            // 
            // MPTab
            // 
            this.MPTab.Controls.Add(this.splitContainer1);
            this.MPTab.Location = new System.Drawing.Point(4, 22);
            this.MPTab.Name = "MPTab";
            this.MPTab.Padding = new System.Windows.Forms.Padding(3);
            this.MPTab.Size = new System.Drawing.Size(791, 475);
            this.MPTab.TabIndex = 0;
            this.MPTab.Text = "ModPacks";
            this.MPTab.UseVisualStyleBackColor = true;
            // 
            // NewsTab
            // 
            this.NewsTab.Location = new System.Drawing.Point(4, 22);
            this.NewsTab.Name = "NewsTab";
            this.NewsTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewsTab.Size = new System.Drawing.Size(791, 475);
            this.NewsTab.TabIndex = 1;
            this.NewsTab.Text = "News";
            this.NewsTab.UseVisualStyleBackColor = true;
            // 
            // MediaTab
            // 
            this.MediaTab.Location = new System.Drawing.Point(4, 22);
            this.MediaTab.Name = "MediaTab";
            this.MediaTab.Size = new System.Drawing.Size(791, 475);
            this.MediaTab.TabIndex = 2;
            this.MediaTab.Text = "Media";
            this.MediaTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(785, 469);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // MultisLauncherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 531);
            this.Controls.Add(this.LauncherTabs);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.LSButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.PlayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultisLauncherMain";
            this.Text = "MultisLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LauncherTabs.ResumeLayout(false);
            this.MPTab.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button LSButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TabControl LauncherTabs;
        private System.Windows.Forms.TabPage MPTab;
        private System.Windows.Forms.TabPage NewsTab;
        private System.Windows.Forms.TabPage MediaTab;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}

