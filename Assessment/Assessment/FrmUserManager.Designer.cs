namespace Assessment
{
    partial class FrmUserManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comBase = new System.Windows.Forms.ComboBox();
            this.ChkisStop = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUserAppraisa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsUserManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Edituser = new System.Windows.Forms.ToolStripMenuItem();
            this.Startuser = new System.Windows.Forms.ToolStripMenuItem();
            this.Stopuser = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisa)).BeginInit();
            this.cmsUserManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comBase);
            this.groupBox1.Controls.Add(this.ChkisStop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UserNa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(551, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "身份";
            // 
            // comBase
            // 
            this.comBase.FormattingEnabled = true;
            this.comBase.Location = new System.Drawing.Point(205, 27);
            this.comBase.Name = "comBase";
            this.comBase.Size = new System.Drawing.Size(121, 20);
            this.comBase.TabIndex = 5;
            // 
            // ChkisStop
            // 
            this.ChkisStop.AutoSize = true;
            this.ChkisStop.Location = new System.Drawing.Point(407, 29);
            this.ChkisStop.Name = "ChkisStop";
            this.ChkisStop.Size = new System.Drawing.Size(60, 16);
            this.ChkisStop.TabIndex = 4;
            this.ChkisStop.Text = "已停职";
            this.ChkisStop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // UserNa
            // 
            this.UserNa.Location = new System.Drawing.Point(55, 26);
            this.UserNa.Name = "UserNa";
            this.UserNa.Size = new System.Drawing.Size(76, 21);
            this.UserNa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // dgvUserAppraisa
            // 
            this.dgvUserAppraisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserAppraisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAppraisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Sex,
            this.BaseType,
            this.AppraisalBase,
            this.IsDel});
            this.dgvUserAppraisa.ContextMenuStrip = this.cmsUserManager;
            this.dgvUserAppraisa.Location = new System.Drawing.Point(-2, 91);
            this.dgvUserAppraisa.MultiSelect = false;
            this.dgvUserAppraisa.Name = "dgvUserAppraisa";
            this.dgvUserAppraisa.RowTemplate.Height = 23;
            this.dgvUserAppraisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAppraisa.Size = new System.Drawing.Size(638, 301);
            this.dgvUserAppraisa.TabIndex = 1;
            this.dgvUserAppraisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvUserAppraisa.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserAppraisa_CellMouseDown);
            this.dgvUserAppraisa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUserAppraisa_MouseDown);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "编号";
            this.Id.Name = "Id";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "用户名";
            this.UserName.Name = "UserName";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // BaseType
            // 
            this.BaseType.DataPropertyName = "BaseType";
            this.BaseType.HeaderText = "基数类型";
            this.BaseType.Name = "BaseType";
            // 
            // AppraisalBase
            // 
            this.AppraisalBase.DataPropertyName = "AppraisalBase";
            this.AppraisalBase.HeaderText = "基数";
            this.AppraisalBase.Name = "AppraisalBase";
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "是否停职";
            this.IsDel.Name = "IsDel";
            this.IsDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmsUserManager
            // 
            this.cmsUserManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewUser,
            this.Edituser,
            this.Startuser,
            this.Stopuser});
            this.cmsUserManager.Name = "cmsUserManager";
            this.cmsUserManager.Size = new System.Drawing.Size(181, 114);
            // 
            // NewUser
            // 
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(180, 22);
            this.NewUser.Text = "新建";
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // Edituser
            // 
            this.Edituser.Name = "Edituser";
            this.Edituser.Size = new System.Drawing.Size(180, 22);
            this.Edituser.Text = "编辑";
            this.Edituser.Click += new System.EventHandler(this.Edituser_Click);
            // 
            // Startuser
            // 
            this.Startuser.Name = "Startuser";
            this.Startuser.Size = new System.Drawing.Size(180, 22);
            this.Startuser.Text = "启用";
            // 
            // Stopuser
            // 
            this.Stopuser.Name = "Stopuser";
            this.Stopuser.Size = new System.Drawing.Size(180, 22);
            this.Stopuser.Text = "停用";
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(642, 379);
            this.Controls.Add(this.dgvUserAppraisa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserManager";
            this.Text = "FrmUserManager";
            this.Load += new System.EventHandler(this.FrmUserManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisa)).EndInit();
            this.cmsUserManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUserAppraisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBase;
        private System.Windows.Forms.CheckBox ChkisStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsUserManager;
        private System.Windows.Forms.ToolStripMenuItem NewUser;
        private System.Windows.Forms.ToolStripMenuItem Edituser;
        private System.Windows.Forms.ToolStripMenuItem Startuser;
        private System.Windows.Forms.ToolStripMenuItem Stopuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppraisalBase;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDel;
    }
}