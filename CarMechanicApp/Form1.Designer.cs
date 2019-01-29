namespace CarMechanicApp
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZlecenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainFormSplitter = new System.Windows.Forms.Splitter();
            this.mainFormTabControl = new System.Windows.Forms.TabControl();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.vehiclesTabPage = new System.Windows.Forms.TabPage();
            this.serviceOrdersTabPage = new System.Windows.Forms.TabPage();
            this.addServiceOrderButton = new System.Windows.Forms.Button();
            this.showServiceOrdersButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainFormTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(671, 30);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZlecenieToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 26);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // dodajZlecenieToolStripMenuItem
            // 
            this.dodajZlecenieToolStripMenuItem.Name = "dodajZlecenieToolStripMenuItem";
            this.dodajZlecenieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajZlecenieToolStripMenuItem.Text = "Dodaj zlecenie";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 30);
            this.panel2.TabIndex = 2;
            // 
            // mainFormSplitter
            // 
            this.mainFormSplitter.Location = new System.Drawing.Point(0, 30);
            this.mainFormSplitter.Name = "mainFormSplitter";
            this.mainFormSplitter.Size = new System.Drawing.Size(110, 262);
            this.mainFormSplitter.TabIndex = 3;
            this.mainFormSplitter.TabStop = false;
            // 
            // mainFormTabControl
            // 
            this.mainFormTabControl.Controls.Add(this.CustomersTabPage);
            this.mainFormTabControl.Controls.Add(this.vehiclesTabPage);
            this.mainFormTabControl.Controls.Add(this.serviceOrdersTabPage);
            this.mainFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTabControl.Location = new System.Drawing.Point(110, 30);
            this.mainFormTabControl.Name = "mainFormTabControl";
            this.mainFormTabControl.SelectedIndex = 0;
            this.mainFormTabControl.Size = new System.Drawing.Size(561, 262);
            this.mainFormTabControl.TabIndex = 4;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(553, 236);
            this.CustomersTabPage.TabIndex = 0;
            this.CustomersTabPage.Text = "Klienci";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // vehiclesTabPage
            // 
            this.vehiclesTabPage.Location = new System.Drawing.Point(4, 22);
            this.vehiclesTabPage.Name = "vehiclesTabPage";
            this.vehiclesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vehiclesTabPage.Size = new System.Drawing.Size(553, 236);
            this.vehiclesTabPage.TabIndex = 1;
            this.vehiclesTabPage.Text = "Pojazdy";
            this.vehiclesTabPage.UseVisualStyleBackColor = true;
            // 
            // serviceOrdersTabPage
            // 
            this.serviceOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.serviceOrdersTabPage.Name = "serviceOrdersTabPage";
            this.serviceOrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.serviceOrdersTabPage.Size = new System.Drawing.Size(553, 236);
            this.serviceOrdersTabPage.TabIndex = 2;
            this.serviceOrdersTabPage.Text = "Zlecenia serwisowe";
            this.serviceOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // addServiceOrderButton
            // 
            this.addServiceOrderButton.Location = new System.Drawing.Point(12, 36);
            this.addServiceOrderButton.Name = "addServiceOrderButton";
            this.addServiceOrderButton.Size = new System.Drawing.Size(92, 71);
            this.addServiceOrderButton.TabIndex = 5;
            this.addServiceOrderButton.Text = "Dodaj zlecenie serwisowe";
            this.addServiceOrderButton.UseVisualStyleBackColor = true;
            // 
            // showServiceOrdersButton
            // 
            this.showServiceOrdersButton.Location = new System.Drawing.Point(12, 113);
            this.showServiceOrdersButton.Name = "showServiceOrdersButton";
            this.showServiceOrdersButton.Size = new System.Drawing.Size(92, 71);
            this.showServiceOrdersButton.TabIndex = 6;
            this.showServiceOrdersButton.Text = "Wyświetl zlecenia serwisowe";
            this.showServiceOrdersButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 292);
            this.Controls.Add(this.showServiceOrdersButton);
            this.Controls.Add(this.addServiceOrderButton);
            this.Controls.Add(this.mainFormTabControl);
            this.Controls.Add(this.mainFormSplitter);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarMechanicApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainFormTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZlecenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter mainFormSplitter;
        private System.Windows.Forms.TabControl mainFormTabControl;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private System.Windows.Forms.TabPage vehiclesTabPage;
        private System.Windows.Forms.TabPage serviceOrdersTabPage;
        private System.Windows.Forms.Button addServiceOrderButton;
        private System.Windows.Forms.Button showServiceOrdersButton;
    }
}

