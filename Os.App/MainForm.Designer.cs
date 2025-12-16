namespace Os.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            registerToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            userEmployeeToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            serviceToolStripMenuItem = new ToolStripMenuItem();
            statusToolStripMenuItem = new ToolStripMenuItem();
            deviceToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            newOsToolStripMenuItem = new ToolStripMenuItem();
            manageOsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem, userEmployeeToolStripMenuItem, productToolStripMenuItem, serviceToolStripMenuItem, statusToolStripMenuItem, deviceToolStripMenuItem });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(77, 24);
            registerToolStripMenuItem.Text = "Register";
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(193, 26);
            clientToolStripMenuItem.Text = "Client";
            // 
            // userEmployeeToolStripMenuItem
            // 
            userEmployeeToolStripMenuItem.Name = "userEmployeeToolStripMenuItem";
            userEmployeeToolStripMenuItem.Size = new Size(193, 26);
            userEmployeeToolStripMenuItem.Text = "User/Employee";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(193, 26);
            productToolStripMenuItem.Text = "Product";
            productToolStripMenuItem.Click += btnProduto_Click;
            // 
            // serviceToolStripMenuItem
            // 
            serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            serviceToolStripMenuItem.Size = new Size(193, 26);
            serviceToolStripMenuItem.Text = "Service";
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new Size(193, 26);
            statusToolStripMenuItem.Text = "Status";
            // 
            // deviceToolStripMenuItem
            // 
            deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            deviceToolStripMenuItem.Size = new Size(193, 26);
            deviceToolStripMenuItem.Text = "Device";
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newOsToolStripMenuItem, manageOsToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(96, 24);
            operationsToolStripMenuItem.Text = "Operations";
            // 
            // newOsToolStripMenuItem
            // 
            newOsToolStripMenuItem.Name = "newOsToolStripMenuItem";
            newOsToolStripMenuItem.Size = new Size(167, 26);
            newOsToolStripMenuItem.Text = "New Os";
            // 
            // manageOsToolStripMenuItem
            // 
            manageOsToolStripMenuItem.Name = "manageOsToolStripMenuItem";
            manageOsToolStripMenuItem.Size = new Size(167, 26);
            manageOsToolStripMenuItem.Text = "Manage Os";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(74, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(70, 24);
            systemToolStripMenuItem.Text = "System";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registerToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem, systemToolStripMenuItem });
            menuStrip1.Location = new Point(2, 36);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(796, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.LightSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = (Image)resources.GetObject("$this.Image");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OS System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem userEmployeeToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem serviceToolStripMenuItem;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem newOsToolStripMenuItem;
        private ToolStripMenuItem manageOsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem deviceToolStripMenuItem;
    }
}