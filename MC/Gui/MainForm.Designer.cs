namespace Gui
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
            this.components = new System.ComponentModel.Container();
            this.HostP = new System.Windows.Forms.Panel();
            this.HostContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBorderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canDragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HostContext.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostP
            // 
            this.HostP.ContextMenuStrip = this.HostContext;
            this.HostP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostP.Location = new System.Drawing.Point(0, 24);
            this.HostP.Name = "HostP";
            this.HostP.Size = new System.Drawing.Size(701, 501);
            this.HostP.TabIndex = 0;
            this.HostP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HostP_MouseMove);
            // 
            // HostContext
            // 
            this.HostContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newControlToolStripMenuItem});
            this.HostContext.Name = "HostContext";
            this.HostContext.Size = new System.Drawing.Size(142, 26);
            // 
            // newControlToolStripMenuItem
            // 
            this.newControlToolStripMenuItem.Name = "newControlToolStripMenuItem";
            this.newControlToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newControlToolStripMenuItem.Text = "New Control";
            this.newControlToolStripMenuItem.Click += new System.EventHandler(this.newControlToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPanelToolStripMenuItem,
            this.savePanelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPanelToolStripMenuItem
            // 
            this.loadPanelToolStripMenuItem.Name = "loadPanelToolStripMenuItem";
            this.loadPanelToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loadPanelToolStripMenuItem.Text = "Load Panel";
            this.loadPanelToolStripMenuItem.Click += new System.EventHandler(this.loadPanelToolStripMenuItem_Click);
            // 
            // savePanelToolStripMenuItem
            // 
            this.savePanelToolStripMenuItem.Name = "savePanelToolStripMenuItem";
            this.savePanelToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.savePanelToolStripMenuItem.Text = "Save Panel";
            this.savePanelToolStripMenuItem.Click += new System.EventHandler(this.savePanelToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBorderToolStripMenuItem,
            this.canDragToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showBorderToolStripMenuItem
            // 
            this.showBorderToolStripMenuItem.Checked = true;
            this.showBorderToolStripMenuItem.CheckOnClick = true;
            this.showBorderToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBorderToolStripMenuItem.Name = "showBorderToolStripMenuItem";
            this.showBorderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.showBorderToolStripMenuItem.Text = "Show Border";
            this.showBorderToolStripMenuItem.Click += new System.EventHandler(this.showBorderToolStripMenuItem_Click);
            // 
            // canDragToolStripMenuItem
            // 
            this.canDragToolStripMenuItem.Checked = true;
            this.canDragToolStripMenuItem.CheckOnClick = true;
            this.canDragToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.canDragToolStripMenuItem.Name = "canDragToolStripMenuItem";
            this.canDragToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.canDragToolStripMenuItem.Text = "Can Drag";
            this.canDragToolStripMenuItem.Click += new System.EventHandler(this.canDragToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 525);
            this.Controls.Add(this.HostP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Myvar Control";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.HostContext.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HostP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip HostContext;
        private System.Windows.Forms.ToolStripMenuItem newControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBorderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canDragToolStripMenuItem;
    }
}