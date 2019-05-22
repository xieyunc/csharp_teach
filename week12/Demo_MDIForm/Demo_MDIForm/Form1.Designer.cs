namespace Demo_MDIForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Window = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CloseWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_FillWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Fill_Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Fill_Vertcal = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CascadeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File,
            this.mi_Window,
            this.mi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_File
            // 
            this.mi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_NewFile,
            this.mi_CloseFile,
            this.toolStripMenuItem1,
            this.mi_Exit});
            this.mi_File.Name = "mi_File";
            this.mi_File.Size = new System.Drawing.Size(58, 21);
            this.mi_File.Text = "文件(&F)";
            // 
            // mi_NewFile
            // 
            this.mi_NewFile.Name = "mi_NewFile";
            this.mi_NewFile.Size = new System.Drawing.Size(161, 22);
            this.mi_NewFile.Text = "新建(&N)";
            // 
            // mi_CloseFile
            // 
            this.mi_CloseFile.Name = "mi_CloseFile";
            this.mi_CloseFile.Size = new System.Drawing.Size(161, 22);
            this.mi_CloseFile.Text = "关闭(&C)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mi_Exit.Size = new System.Drawing.Size(161, 22);
            this.mi_Exit.Text = "退出(&X)";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // mi_Window
            // 
            this.mi_Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_NewWindow,
            this.mi_CloseWindow,
            this.mi_FillWindow,
            this.mi_CascadeWindow});
            this.mi_Window.Name = "mi_Window";
            this.mi_Window.Size = new System.Drawing.Size(64, 21);
            this.mi_Window.Text = "窗口(&W)";
            // 
            // mi_NewWindow
            // 
            this.mi_NewWindow.Name = "mi_NewWindow";
            this.mi_NewWindow.Size = new System.Drawing.Size(152, 22);
            this.mi_NewWindow.Text = "新建窗口(&N)";
            this.mi_NewWindow.Click += new System.EventHandler(this.mi_NewWindow_Click);
            // 
            // mi_CloseWindow
            // 
            this.mi_CloseWindow.Name = "mi_CloseWindow";
            this.mi_CloseWindow.Size = new System.Drawing.Size(152, 22);
            this.mi_CloseWindow.Text = "关闭窗口(&C)";
            this.mi_CloseWindow.Click += new System.EventHandler(this.mi_CloseWindow_Click);
            // 
            // mi_FillWindow
            // 
            this.mi_FillWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Fill_Horizontal,
            this.mi_Fill_Vertcal});
            this.mi_FillWindow.Name = "mi_FillWindow";
            this.mi_FillWindow.Size = new System.Drawing.Size(152, 22);
            this.mi_FillWindow.Text = "平铺窗口(&T)";
            // 
            // mi_Fill_Horizontal
            // 
            this.mi_Fill_Horizontal.Name = "mi_Fill_Horizontal";
            this.mi_Fill_Horizontal.Size = new System.Drawing.Size(152, 22);
            this.mi_Fill_Horizontal.Text = "水平排列(&H)";
            this.mi_Fill_Horizontal.Click += new System.EventHandler(this.mi_Fill_Horizontal_Click);
            // 
            // mi_Fill_Vertcal
            // 
            this.mi_Fill_Vertcal.Name = "mi_Fill_Vertcal";
            this.mi_Fill_Vertcal.Size = new System.Drawing.Size(152, 22);
            this.mi_Fill_Vertcal.Text = "垂直排列(&V)";
            this.mi_Fill_Vertcal.Click += new System.EventHandler(this.mi_Fill_Vertcal_Click);
            // 
            // mi_CascadeWindow
            // 
            this.mi_CascadeWindow.Name = "mi_CascadeWindow";
            this.mi_CascadeWindow.Size = new System.Drawing.Size(152, 22);
            this.mi_CascadeWindow.Text = "叠放窗口(&S)";
            this.mi_CascadeWindow.Click += new System.EventHandler(this.mi_CascadeWindow_Click);
            // 
            // mi_Help
            // 
            this.mi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_About});
            this.mi_Help.Name = "mi_Help";
            this.mi_Help.Size = new System.Drawing.Size(61, 21);
            this.mi_Help.Text = "帮助(&H)";
            // 
            // mi_About
            // 
            this.mi_About.Name = "mi_About";
            this.mi_About.Size = new System.Drawing.Size(172, 22);
            this.mi_About.Text = "关于本程序(&A)……";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 361);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MDI窗口演示";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_File;
        private System.Windows.Forms.ToolStripMenuItem mi_NewFile;
        private System.Windows.Forms.ToolStripMenuItem mi_CloseFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.ToolStripMenuItem mi_Window;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem mi_About;
        private System.Windows.Forms.ToolStripMenuItem mi_NewWindow;
        private System.Windows.Forms.ToolStripMenuItem mi_CloseWindow;
        private System.Windows.Forms.ToolStripMenuItem mi_FillWindow;
        private System.Windows.Forms.ToolStripMenuItem mi_CascadeWindow;
        private System.Windows.Forms.ToolStripMenuItem mi_Fill_Horizontal;
        private System.Windows.Forms.ToolStripMenuItem mi_Fill_Vertcal;
    }
}

