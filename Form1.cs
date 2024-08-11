using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdFileCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AdList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.AdList.KeyDown += new KeyEventHandler(FPDel_KeyDown);
        }
        private void fileCount()
        {
            AdCount.Text = "项目数量：" + AdList.Items.Count;
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)

        {
            if (e.Button == MouseButtons.Right)
            {

                int index = AdList.IndexFromPoint(e.Location);
                if (index >= 0)
                {
                    AdList.SelectedIndex = index;
                    this.contextMenuStrip1.Show(this.AdList, e.Location);
                }
            }


        }
        private void FPDel_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.AdList.Items.Remove(this.AdList.SelectedItem);
                fileCount();
            }
        }
        private void SelectFolder_Click(object sender, EventArgs e)
        {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "选择文件夹目录";  //提示的文字
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    FolderPath.Text = folder.SelectedPath;
                }
            
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            AdList.Items.Clear();
            FolderPath.Enabled = false;
            if (File.Exists(@"AdRules.txt"))

            {
                Application.DoEvents();
                string[] strArray = File.ReadAllLines(@"AdRules.txt");

                for (int i = 0; i < strArray.Length; i++)
                {
                    if (Directory.Exists(FolderPath.Text))
                    {
                        string[] files1 = Directory.GetFiles(FolderPath.Text, strArray[i], SearchOption.AllDirectories);
                        foreach (string file in files1)
                        {
                            AdList.Items.Add(file);
                        }
                        fileCount();
                        Application.DoEvents();

                    }
                    else
                    {
                        MessageBox.Show("无效路径。请检查文件夹是否正常。");

                    }
                }
                MessageBox.Show("文件夹扫描完毕，发现" + AdList.Items.Count + "个疑似广告文件，请检查列出的文件，确认无误后点击“删除！”。");
                FolderPath.Enabled = true;

            }
            else
            {
                MessageBox.Show("没有配置广告文件的规则。请先在此软件同级目录下创建AdRules.txt（使用UTF-8编码），并按照Windows通配符格式写入规则，每行一个。");
            }
            

        }

        private void 删除项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AdList.Items.Remove(this.AdList.SelectedItem);
            fileCount();
        }

        private void DeleteAd_Click(object sender, EventArgs e)
        {
            AdList.Enabled = false;
            string errs = "所有广告已经全部被删除！";
            try
            {
                for (int i = 0; i < AdList.Items.Count; i++)
                {
                    File.SetAttributes(AdList.Items[i].ToString(), FileAttributes.Normal);
                    File.Delete(AdList.Items[i].ToString());
                }
            }
            catch
            {
                errs = "广告文件删除完毕，有部分文件未删除成功，可能是因为文件被重复删除，或者文件具备系统属性而无法直接删除。";
            }
            MessageBox.Show(errs);
            AdList.Enabled = true;
        }
    }
}
