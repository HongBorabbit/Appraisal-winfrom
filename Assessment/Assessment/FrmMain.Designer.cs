namespace Assessment
{
    partial class FrmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("用户管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("基数管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("系数管理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("人员绩效");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvMenu = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvMenu);
            this.splitContainer1.Size = new System.Drawing.Size(888, 510);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvMenu
            // 
            this.trvMenu.Font = new System.Drawing.Font("宋体", 13.75F);
            this.trvMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trvMenu.FullRowSelect = true;
            this.trvMenu.ItemHeight = 40;
            this.trvMenu.Location = new System.Drawing.Point(0, 3);
            this.trvMenu.Name = "trvMenu";
            treeNode1.Name = "uusermanage";
            treeNode1.Tag = "FrmUserManager";
            treeNode1.Text = "用户管理";
            treeNode2.Name = "tnBaseManager";
            treeNode2.Tag = "FrmBaseManager";
            treeNode2.Text = "基数管理";
            treeNode3.Name = "tnCoefficientManager";
            treeNode3.Text = "系数管理";
            treeNode4.Name = "tnUserAppraisal";
            treeNode4.Tag = "FrmUserAppraisal";
            treeNode4.Text = "人员绩效";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.trvMenu.ShowLines = false;
            this.trvMenu.Size = new System.Drawing.Size(159, 504);
            this.trvMenu.TabIndex = 0;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 510);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvMenu;
    }
}

