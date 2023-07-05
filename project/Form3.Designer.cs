
namespace project
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProductsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showProductsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsersFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsersReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProductsFormToolStripMenuItem,
            this.showProductsReportToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // showProductsFormToolStripMenuItem
            // 
            this.showProductsFormToolStripMenuItem.Name = "showProductsFormToolStripMenuItem";
            this.showProductsFormToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showProductsFormToolStripMenuItem.Text = "Show Products Form";
            this.showProductsFormToolStripMenuItem.Click += new System.EventHandler(this.showProductsFormToolStripMenuItem_Click);
            // 
            // showProductsReportToolStripMenuItem
            // 
            this.showProductsReportToolStripMenuItem.Name = "showProductsReportToolStripMenuItem";
            this.showProductsReportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showProductsReportToolStripMenuItem.Text = "Show Products Report";
            this.showProductsReportToolStripMenuItem.Click += new System.EventHandler(this.showProductsReportToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUsersFormToolStripMenuItem,
            this.showUsersReportToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // showUsersFormToolStripMenuItem
            // 
            this.showUsersFormToolStripMenuItem.Name = "showUsersFormToolStripMenuItem";
            this.showUsersFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showUsersFormToolStripMenuItem.Text = "Show Users Form";
            this.showUsersFormToolStripMenuItem.Click += new System.EventHandler(this.showUsersFormToolStripMenuItem_Click);
            // 
            // showUsersReportToolStripMenuItem
            // 
            this.showUsersReportToolStripMenuItem.Name = "showUsersReportToolStripMenuItem";
            this.showUsersReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showUsersReportToolStripMenuItem.Text = "Show Users Report";
            this.showUsersReportToolStripMenuItem.Click += new System.EventHandler(this.showUsersReportToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProductsFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUsersFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showProductsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUsersReportToolStripMenuItem;
    }
}