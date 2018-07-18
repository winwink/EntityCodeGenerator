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
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.lblNameSpace = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnGenerateOne = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConnectionStr
            // 
            this.txtConnectionStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConnectionStr.Location = new System.Drawing.Point(116, 14);
            this.txtConnectionStr.Margin = new System.Windows.Forms.Padding(4);
            this.txtConnectionStr.Name = "txtConnectionStr";
            this.txtConnectionStr.Size = new System.Drawing.Size(709, 25);
            this.txtConnectionStr.TabIndex = 0;
            this.txtConnectionStr.Text = "Server=121.40.206.55;Database=test;UID=sa;PWD=sa;";
            this.txtConnectionStr.TextChanged += new System.EventHandler(this.txtConnectionStr_TextChanged);
            // 
            // lblConnectionStr
            // 
            this.lblConnectionStr.AutoSize = true;
            this.lblConnectionStr.Location = new System.Drawing.Point(17, 21);
            this.lblConnectionStr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectionStr.Name = "lblConnectionStr";
            this.lblConnectionStr.Size = new System.Drawing.Size(82, 15);
            this.lblConnectionStr.TabIndex = 1;
            this.lblConnectionStr.Text = "连接字符串";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(637, 56);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconect
            // 
            this.btnDisconect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisconect.Enabled = false;
            this.btnDisconect.Location = new System.Drawing.Point(735, 56);
            this.btnDisconect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconect.Name = "btnDisconect";
            this.btnDisconect.Size = new System.Drawing.Size(89, 29);
            this.btnDisconect.TabIndex = 2;
            this.btnDisconect.Text = "断开";
            this.btnDisconect.UseVisualStyleBackColor = true;
            this.btnDisconect.Click += new System.EventHandler(this.btnDisconect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGenerateOne);
            this.groupBox1.Controls.Add(this.BtnTest);
            this.groupBox1.Controls.Add(this.txtNameSpace);
            this.groupBox1.Controls.Add(this.lblNameSpace);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(843, 349);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(85, 52);
            this.txtNameSpace.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(265, 25);
            this.txtNameSpace.TabIndex = 5;
            this.txtNameSpace.Text = "Daheng88.Model";
            // 
            // lblNameSpace
            // 
            this.lblNameSpace.AutoSize = true;
            this.lblNameSpace.Location = new System.Drawing.Point(83, 21);
            this.lblNameSpace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameSpace.Name = "lblNameSpace";
            this.lblNameSpace.Size = new System.Drawing.Size(67, 15);
            this.lblNameSpace.TabIndex = 4;
            this.lblNameSpace.Text = "命名空间";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(81, 89);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 29);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "生成实体类";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(637, 124);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 6;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnGenerateOne
            // 
            this.BtnGenerateOne.Location = new System.Drawing.Point(81, 141);
            this.BtnGenerateOne.Name = "BtnGenerateOne";
            this.BtnGenerateOne.Size = new System.Drawing.Size(130, 30);
            this.BtnGenerateOne.TabIndex = 7;
            this.BtnGenerateOne.Text = "生成1个试试";
            this.BtnGenerateOne.UseVisualStyleBackColor = true;
            this.BtnGenerateOne.Click += new System.EventHandler(this.BtnGenerateOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisconect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConnectionStr);
            this.Controls.Add(this.txtConnectionStr);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button BtnGenerateOne;
    }
}

