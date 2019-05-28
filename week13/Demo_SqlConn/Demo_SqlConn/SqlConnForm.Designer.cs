namespace Demo_SqlConn
{
    partial class SqlConnForm
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
            this.txtBox_Srv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_Msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Start2 = new System.Windows.Forms.Button();
            this.sqlConn = new System.Data.SqlClient.SqlConnection();
            this.textBox_Config = new System.Windows.Forms.TextBox();
            this.btn_ReadConfig = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Stop2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_Srv
            // 
            this.txtBox_Srv.Location = new System.Drawing.Point(101, 26);
            this.txtBox_Srv.Name = "txtBox_Srv";
            this.txtBox_Srv.Size = new System.Drawing.Size(135, 21);
            this.txtBox_Srv.TabIndex = 1;
            this.txtBox_Srv.Text = "172.18.4.13";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据库服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "数据库登录名：";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(101, 65);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(135, 21);
            this.textBox_User.TabIndex = 3;
            this.textBox_User.Text = "xscjgl_sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "登录密码：";
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(347, 65);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(135, 21);
            this.textBox_Pwd.TabIndex = 4;
            this.textBox_Pwd.Text = "abcd@1234";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库名：";
            // 
            // textBox_DbName
            // 
            this.textBox_DbName.Location = new System.Drawing.Point(347, 26);
            this.textBox_DbName.Name = "textBox_DbName";
            this.textBox_DbName.Size = new System.Drawing.Size(135, 21);
            this.textBox_DbName.TabIndex = 2;
            this.textBox_DbName.Text = "xscj_db";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.txtBox_Srv);
            this.groupBox1.Controls.Add(this.btn_Start);
            this.groupBox1.Controls.Add(this.textBox_DbName);
            this.groupBox1.Controls.Add(this.textBox_User);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_Pwd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "代码拼接数据库连接信息：";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(101, 102);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(135, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "开始连接数据库";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(347, 102);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(135, 23);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "断开数据库连接";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusBar_Msg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 317);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "状态：";
            // 
            // statusBar_Msg
            // 
            this.statusBar_Msg.Name = "statusBar_Msg";
            this.statusBar_Msg.Size = new System.Drawing.Size(459, 17);
            this.statusBar_Msg.Spring = true;
            this.statusBar_Msg.Text = "数据库连接断开！";
            this.statusBar_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Start2
            // 
            this.btn_Start2.Location = new System.Drawing.Point(101, 106);
            this.btn_Start2.Name = "btn_Start2";
            this.btn_Start2.Size = new System.Drawing.Size(135, 23);
            this.btn_Start2.TabIndex = 12;
            this.btn_Start2.Text = "开始连接数据库";
            this.btn_Start2.UseVisualStyleBackColor = true;
            this.btn_Start2.Click += new System.EventHandler(this.btn_Start2_Click);
            // 
            // sqlConn
            // 
            this.sqlConn.FireInfoMessageEventOnUserErrors = false;
            this.sqlConn.StateChange += new System.Data.StateChangeEventHandler(this.sqlConn_StateChange);
            // 
            // textBox_Config
            // 
            this.textBox_Config.Enabled = false;
            this.textBox_Config.Location = new System.Drawing.Point(10, 46);
            this.textBox_Config.Multiline = true;
            this.textBox_Config.Name = "textBox_Config";
            this.textBox_Config.Size = new System.Drawing.Size(472, 46);
            this.textBox_Config.TabIndex = 13;
            this.textBox_Config.TextChanged += new System.EventHandler(this.textBox_Config_TextChanged);
            // 
            // btn_ReadConfig
            // 
            this.btn_ReadConfig.Location = new System.Drawing.Point(10, 17);
            this.btn_ReadConfig.Name = "btn_ReadConfig";
            this.btn_ReadConfig.Size = new System.Drawing.Size(87, 23);
            this.btn_ReadConfig.TabIndex = 14;
            this.btn_ReadConfig.Text = "读取配置";
            this.btn_ReadConfig.UseVisualStyleBackColor = true;
            this.btn_ReadConfig.Click += new System.EventHandler(this.btn_ReadConfig_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Stop2);
            this.groupBox2.Controls.Add(this.btn_ReadConfig);
            this.groupBox2.Controls.Add(this.btn_Start2);
            this.groupBox2.Controls.Add(this.textBox_Config);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 143);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "从App.config配置文件中读取数据库连接信息：";
            // 
            // btn_Stop2
            // 
            this.btn_Stop2.Location = new System.Drawing.Point(347, 106);
            this.btn_Stop2.Name = "btn_Stop2";
            this.btn_Stop2.Size = new System.Drawing.Size(135, 23);
            this.btn_Stop2.TabIndex = 15;
            this.btn_Stop2.Text = "断开数据库连接";
            this.btn_Stop2.UseVisualStyleBackColor = true;
            this.btn_Stop2.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // SqlConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SqlConnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库连接设置Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Data.SqlClient.SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection();
        private System.Data.SqlClient.SqlConnection sqlConn;
        private System.Windows.Forms.TextBox txtBox_Srv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Msg;
        private System.Windows.Forms.Button btn_Start2;
        private System.Windows.Forms.TextBox textBox_Config;
        private System.Windows.Forms.Button btn_ReadConfig;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Stop2;
    }
}

