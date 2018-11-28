using EntityCodeGenerator.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EntityCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitSystem();
            //Init();
        }

        private void InitSystem()
        {
            CbbSystem.DataSource = new List<string>() { "Common", "RDCN", "RDSZ" };
        }

        private void SetSystem()
        {
            List<string> tables = new List<string>();
            switch (CbbSystem.Text)
            {
                case "Common":
                    txtConnectionStr.Text = "Server=localhost;Database=RDCN_CSWF_Data;Integrated Security=SSPI";
                    txtNameSpace.Text = "CSWF.CommonService";
                    Template.TemplateCommon.SvcSufferName = ".CommonSvc";
                    tables.AddRange(new List<string>() { "WF_ApprovalMatrix", "WF_ApprovalMatrixInstance", "WF_RoleUser", "WF_Role", "WF_ProcessInfo", "WF_ApprovalHistory", "WF_ProcessInstanceStatus",
                        "Common_Org_FunctionRegion", "Common_Org_BusinessLine", "Common_Org_BusinessArea", "Common_MailTemplate", "Common_MailRecord", "Common_ExportTemplate", "Common_Attachments", 
                        "Common_ExportFiles", "Common_Dictionary", "Common_Attachments_Config", "Common_Config", "WF_ProcessInstanceStatus_20180920", "Common_Employee_AdditionalUsers" });
                    TxtIncludeTables.Text = string.Join("\r\n",tables);
                    break;
                case "RDCN":
                    txtConnectionStr.Text = "Server=localhost;Database=RDCN_CSWF_Data;Integrated Security=SSPI";
                    txtNameSpace.Text = "CSWF.RDCN";
                    Template.TemplateCommon.SvcSufferName = ".RequestSvc";
                    tables.AddRange(new List<string>() { "Request_CarFleet" });
                    TxtIncludeTables.Text = string.Join("\r\n",tables);
                    break;
                case "RDSZ":
                    txtConnectionStr.Text = "Server=localhost;Database=RDSZ_CSWF_Data;Integrated Security=SSPI";
                    txtNameSpace.Text = "CSWF.RDSZ";
                    Template.TemplateCommon.SvcSufferName = ".RequestSvc";
                    tables.AddRange(new List<string>() { "Request_SHEBadge", "Request_SiteServiceCatering", "SHEBadge_AccessMatrix" });
                    TxtIncludeTables.Text = string.Join("\r\n",tables);
                    break;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtConnectionStr.Text.Trim();
                Match m = Regex.Match(str, @"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}");//检查是否字符串中有IP

                //if (!m.Success)
                //{
                //    MessageBox.Show("连接字符串缺少IP");
                //    return;
                //}
                DBHelper.ConnectionString = str;
                int Port = 1433;
                if (Regex.IsMatch(str, @"\,\d+"))
                {
                    Port = Convert.ToInt32(Regex.Match(str, @"\,(\d+)").Groups[1].Value);
                }
                if (DBHelper.TryConnect(m.ToString(), Port))
                {

                    btnConnect.Enabled = false;
                    btnDisconect.Enabled = true;
                    return;
                }
                MessageBox.Show("连接数据库失败.");
            }
            catch (Exception ex)
            {
                btnConnect.Enabled = true;
                btnDisconect.Enabled = false;
                MessageBox.Show(ex.Message);
            }
        }



        private void btnDisconect_Click(object sender, EventArgs e)
        {
            DBHelper.ConnectionString = string.Empty;
            btnConnect.Enabled = true;
            btnDisconect.Enabled = false;
            txtNameSpace.Text = string.Empty;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void Generate()
        {
            if (string.IsNullOrEmpty(this.txtNameSpace.Text.Trim()))
            {
                MessageBox.Show("命名空间不能为空.");
                return;
            }
            string connectionString = DBHelper.ConnectionString;
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                connectionString = txtConnectionStr.Text.Trim();
            }

            List<string> selectedTables = new List<string>();
            if (TxtIncludeTables.Text != "")
            {
                var array = TxtIncludeTables.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                selectedTables.AddRange(array);
            }

            EngineerCodeFirstHandler codeEngineer = new EngineerCodeFirstHandler();
            codeEngineer.CodeGenerator(connectionString, txtNameSpace.Text.Trim(), ShowMsg, selectedTables);
        }

        private void ShowMsg(string msgContent)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate { MessageBox.Show(msgContent); }));
            }
            else
            {

                var result = MessageBox.Show(msgContent + ", 是否打开所在文件夹", "确认", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Process.Start("Explorer.exe", Environment.CurrentDirectory);
                }
            }
        }

        public void GenerateFile(string path, string fileName, string content)
        {
            if (Directory.Exists(path))
            {
                string fullName = Path.Combine(path, fileName);
                using (StreamWriter writer = new StreamWriter(fullName, false))
                {
                    writer.WriteLine(content);
                    writer.Flush();
                }
            }
            else
            {
                MessageBox.Show("文件夹不存在");
            }
        }

        private void txtConnectionStr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save()
        {
            ConfigEntityCollection col = new ConfigEntityCollection();
            List<string> list = new List<string>() { "Common_Attachments_Config", "Common_Config", "Common_Dictionary" };
            for (int i = 0; i < list.Count; i++)
            {
                col.List.Add(new ConfigEntity(list[i]));
            }

            var result = col.ToXElement();
            col.Save();
        }

        private ConfigEntityCollection ConfigLoad()
        {
            ConfigEntityCollection col = new ConfigEntityCollection();
            col.Load();
            return col;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            ConfigLoad();
        }

        private void CbbSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSystem();
        }

        private void TxtIncludeTables_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x1')
            {
                ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }


    }
}
