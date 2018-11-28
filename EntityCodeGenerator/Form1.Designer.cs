namespace EntityCodeGenerator
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
            this.txtConnectionStr = new System.Windows.Forms.TextBox();
            this.lblConnectionStr = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIncludeTables = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.lblNameSpace = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CbbSystem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionStr
            // 
            this.txtConnectionStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionStr.Location = new System.Drawing.Point(87, 115);
            this.txtConnectionStr.Name = "txtConnectionStr";
            this.txtConnectionStr.Size = new System.Drawing.Size(635, 20);
            this.txtConnectionStr.TabIndex = 0;
            this.txtConnectionStr.Text = "Server=121.40.206.55;Database=test;UID=sa;PWD=sa;";
            this.txtConnectionStr.TextChanged += new System.EventHandler(this.txtConnectionStr_TextChanged);
            // 
            // lblConnectionStr
            // 
            this.lblConnectionStr.AutoSize = true;
            this.lblConnectionStr.Location = new System.Drawing.Point(13, 121);
            this.lblConnectionStr.Name = "lblConnectionStr";
            this.lblConnectionStr.Size = new System.Drawing.Size(67, 13);
            this.lblConnectionStr.TabIndex = 1;
            this.lblConnectionStr.Text = "连接字符串";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(580, 152);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(67, 25);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconect
            // 
            this.btnDisconect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconect.Enabled = false;
            this.btnDisconect.Location = new System.Drawing.Point(653, 152);
            this.btnDisconect.Name = "btnDisconect";
            this.btnDisconect.Size = new System.Drawing.Size(67, 25);
            this.btnDisconect.TabIndex = 2;
            this.btnDisconect.Text = "断开";
            this.btnDisconect.UseVisualStyleBackColor = true;
            this.btnDisconect.Click += new System.EventHandler(this.btnDisconect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtIncludeTables);
            this.groupBox1.Controls.Add(this.BtnTest);
            this.groupBox1.Controls.Add(this.txtNameSpace);
            this.groupBox1.Controls.Add(this.lblNameSpace);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 302);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "选择表";
            // 
            // TxtIncludeTables
            // 
            this.TxtIncludeTables.Location = new System.Drawing.Point(81, 85);
            this.TxtIncludeTables.Multiline = true;
            this.TxtIncludeTables.Name = "TxtIncludeTables";
            this.TxtIncludeTables.Size = new System.Drawing.Size(236, 85);
            this.TxtIncludeTables.TabIndex = 8;
            this.TxtIncludeTables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIncludeTables_KeyPress);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(478, 107);
            this.BtnTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(56, 20);
            this.BtnTest.TabIndex = 6;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(80, 45);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(200, 20);
            this.txtNameSpace.TabIndex = 5;
            this.txtNameSpace.Text = "Daheng88.Model";
            // 
            // lblNameSpace
            // 
            this.lblNameSpace.AutoSize = true;
            this.lblNameSpace.Location = new System.Drawing.Point(6, 48);
            this.lblNameSpace.Name = "lblNameSpace";
            this.lblNameSpace.Size = new System.Drawing.Size(55, 13);
            this.lblNameSpace.TabIndex = 4;
            this.lblNameSpace.Text = "命名空间";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(80, 191);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 25);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "生成实体类";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // CbbSystem
            // 
            this.CbbSystem.FormattingEnabled = true;
            this.CbbSystem.Location = new System.Drawing.Point(87, 37);
            this.CbbSystem.Name = "CbbSystem";
            this.CbbSystem.Size = new System.Drawing.Size(121, 21);
            this.CbbSystem.TabIndex = 10;
            this.CbbSystem.SelectedIndexChanged += new System.EventHandler(this.CbbSystem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 499);
            this.Controls.Add(this.CbbSystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisconect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConnectionStr);
            this.Controls.Add(this.txtConnectionStr);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实体类生成";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionStr;
        private System.Windows.Forms.Label lblConnectionStr;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label lblNameSpace;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIncludeTables;
        private System.Windows.Forms.ComboBox CbbSystem;
        private System.Windows.Forms.Label label2;
    }
}

