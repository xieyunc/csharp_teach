namespace Demo_Menu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Row = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Col = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_PageSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_FontSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(643, 379);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusBar_Row,
            this.statusBar_Col});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(643, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(468, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statusBar_Row
            // 
            this.statusBar_Row.AutoSize = false;
            this.statusBar_Row.Name = "statusBar_Row";
            this.statusBar_Row.Size = new System.Drawing.Size(80, 17);
            this.statusBar_Row.Text = "1 行";
            // 
            // statusBar_Col
            // 
            this.statusBar_Col.AutoSize = false;
            this.statusBar_Col.Name = "statusBar_Col";
            this.statusBar_Col.Size = new System.Drawing.Size(80, 17);
            this.statusBar_Col.Text = "1 列";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File,
            this.mi_Edit,
            this.mi_Format,
            this.mi_Status,
            this.mi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_File
            // 
            this.mi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_NewFile,
            this.mi_OpenFile,
            this.mi_SaveFile,
            this.mi_SaveAs,
            this.toolStripMenuItem1,
            this.mi_PageSet,
            this.mi_Print,
            this.toolStripSeparator1,
            this.mi_Exit});
            this.mi_File.Name = "mi_File";
            this.mi_File.Size = new System.Drawing.Size(58, 21);
            this.mi_File.Text = "文件(&F)";
            // 
            // mi_NewFile
            // 
            this.mi_NewFile.Name = "mi_NewFile";
            this.mi_NewFile.Size = new System.Drawing.Size(152, 22);
            this.mi_NewFile.Text = "新建(&N)";
            this.mi_NewFile.Click += new System.EventHandler(this.mi_NewFile_Click);
            // 
            // mi_OpenFile
            // 
            this.mi_OpenFile.Name = "mi_OpenFile";
            this.mi_OpenFile.Size = new System.Drawing.Size(152, 22);
            this.mi_OpenFile.Text = "打开(&O)";
            this.mi_OpenFile.Click += new System.EventHandler(this.mi_OpenFile_Click);
            // 
            // mi_SaveFile
            // 
            this.mi_SaveFile.Name = "mi_SaveFile";
            this.mi_SaveFile.Size = new System.Drawing.Size(152, 22);
            this.mi_SaveFile.Text = "保存(&S)";
            this.mi_SaveFile.Click += new System.EventHandler(this.mi_SaveFile_Click);
            // 
            // mi_SaveAs
            // 
            this.mi_SaveAs.Name = "mi_SaveAs";
            this.mi_SaveAs.Size = new System.Drawing.Size(152, 22);
            this.mi_SaveAs.Text = "另存为(&A)";
            this.mi_SaveAs.Click += new System.EventHandler(this.mi_SaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_PageSet
            // 
            this.mi_PageSet.Name = "mi_PageSet";
            this.mi_PageSet.Size = new System.Drawing.Size(152, 22);
            this.mi_PageSet.Text = "页面设置(&G)";
            // 
            // mi_Print
            // 
            this.mi_Print.Name = "mi_Print";
            this.mi_Print.Size = new System.Drawing.Size(152, 22);
            this.mi_Print.Text = "打印(&P)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.Size = new System.Drawing.Size(152, 22);
            this.mi_Exit.Text = "退出(&X)";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // mi_Edit
            // 
            this.mi_Edit.Name = "mi_Edit";
            this.mi_Edit.Size = new System.Drawing.Size(59, 21);
            this.mi_Edit.Text = "编辑(&E)";
            // 
            // mi_Format
            // 
            this.mi_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_FontSet});
            this.mi_Format.Name = "mi_Format";
            this.mi_Format.Size = new System.Drawing.Size(62, 21);
            this.mi_Format.Text = "格式(&O)";
            // 
            // mi_FontSet
            // 
            this.mi_FontSet.Name = "mi_FontSet";
            this.mi_FontSet.Size = new System.Drawing.Size(114, 22);
            this.mi_FontSet.Text = "字体(&F)";
            this.mi_FontSet.Click += new System.EventHandler(this.mi_FontSet_Click);
            // 
            // mi_Status
            // 
            this.mi_Status.Name = "mi_Status";
            this.mi_Status.Size = new System.Drawing.Size(61, 21);
            this.mi_Status.Text = "查看(&D)";
            // 
            // mi_Help
            // 
            this.mi_Help.Name = "mi_Help";
            this.mi_Help.Size = new System.Drawing.Size(61, 21);
            this.mi_Help.Text = "帮助(&H)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            this.saveFileDialog1.Title = "另存为";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            this.openFileDialog1.Title = "打开文件";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 404);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "小刀记事本程序";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Row;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Col;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_File;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit;
        private System.Windows.Forms.ToolStripMenuItem mi_Format;
        private System.Windows.Forms.ToolStripMenuItem mi_Status;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem mi_NewFile;
        private System.Windows.Forms.ToolStripMenuItem mi_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem mi_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem mi_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mi_PageSet;
        private System.Windows.Forms.ToolStripMenuItem mi_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mi_FontSet;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

