namespace AdFileCleaner
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AdCount = new System.Windows.Forms.Label();
            this.AdList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAd = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(136, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "广告文件清理器";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Comment.Location = new System.Drawing.Point(154, 9);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(644, 34);
            this.Comment.TabIndex = 1;
            this.Comment.Text = "按照文件名和规定的通配符规则，扫描文件夹内疑似广告的文件，并全部删除，避免广告文件浪费硬盘空间，影响计算机\r\n使用体验。";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.line.Location = new System.Drawing.Point(-17, 43);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(833, 17);
            this.line.TabIndex = 2;
            this.line.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "----";
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderPath.Location = new System.Drawing.Point(134, 63);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(571, 23);
            this.FolderPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "需要处理的文件夹：";
            // 
            // SelectFolder
            // 
            this.SelectFolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectFolder.Location = new System.Drawing.Point(713, 63);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(75, 23);
            this.SelectFolder.TabIndex = 5;
            this.SelectFolder.Text = "选择";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "搜索到的疑似广告文件列表（如果误判，请右键删除列表中的误判项目）：";
            // 
            // AdCount
            // 
            this.AdCount.AutoSize = true;
            this.AdCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.AdCount.Location = new System.Drawing.Point(637, 89);
            this.AdCount.Name = "AdCount";
            this.AdCount.Size = new System.Drawing.Size(75, 17);
            this.AdCount.TabIndex = 7;
            this.AdCount.Text = "项目数量：0";
            // 
            // AdList
            // 
            this.AdList.ContextMenuStrip = this.contextMenuStrip1;
            this.AdList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AdList.FormattingEnabled = true;
            this.AdList.HorizontalScrollbar = true;
            this.AdList.ItemHeight = 17;
            this.AdList.Location = new System.Drawing.Point(16, 109);
            this.AdList.Name = "AdList";
            this.AdList.Size = new System.Drawing.Size(772, 327);
            this.AdList.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除项目ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 删除项目ToolStripMenuItem
            // 
            this.删除项目ToolStripMenuItem.Name = "删除项目ToolStripMenuItem";
            this.删除项目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除项目ToolStripMenuItem.Text = "删除项目";
            this.删除项目ToolStripMenuItem.Click += new System.EventHandler(this.删除项目ToolStripMenuItem_Click);
            // 
            // DeleteAd
            // 
            this.DeleteAd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteAd.ForeColor = System.Drawing.Color.Red;
            this.DeleteAd.Location = new System.Drawing.Point(16, 475);
            this.DeleteAd.Name = "DeleteAd";
            this.DeleteAd.Size = new System.Drawing.Size(772, 23);
            this.DeleteAd.TabIndex = 9;
            this.DeleteAd.Text = "删除！";
            this.DeleteAd.UseVisualStyleBackColor = true;
            this.DeleteAd.Click += new System.EventHandler(this.DeleteAd_Click);
            // 
            // Scan
            // 
            this.Scan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Scan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Scan.Location = new System.Drawing.Point(16, 442);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(772, 23);
            this.Scan.TabIndex = 11;
            this.Scan.Text = "扫描文件";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.DeleteAd);
            this.Controls.Add(this.AdList);
            this.Controls.Add(this.AdCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.line);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "广告文件清理器";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AdCount;
        private System.Windows.Forms.ListBox AdList;
        private System.Windows.Forms.Button DeleteAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除项目ToolStripMenuItem;
        private System.Windows.Forms.Button Scan;
    }
}

