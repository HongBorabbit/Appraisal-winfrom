namespace Assessment
{
    partial class FrmUserAppraisal
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
            this.a = new System.Windows.Forms.GroupBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUserAppraisal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppraisalBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsUserAppraisal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).BeginInit();
            this.cmsUserAppraisal.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.cbxYear);
            this.a.Controls.Add(this.label1);
            this.a.Location = new System.Drawing.Point(12, 12);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(560, 97);
            this.a.TabIndex = 0;
            this.a.TabStop = false;
            this.a.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbxYear
            // 
            this.cbxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(424, 39);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 20);
            this.cbxYear.TabIndex = 1;
            this.cbxYear.Text = "2020";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年份";
            // 
            // dgvUserAppraisal
            // 
            this.dgvUserAppraisal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserAppraisal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAppraisal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.Sex,
            this.BaseType,
            this.AppraisalBase});
            this.dgvUserAppraisal.ContextMenuStrip = this.cmsUserAppraisal;
            this.dgvUserAppraisal.Location = new System.Drawing.Point(12, 115);
            this.dgvUserAppraisal.MultiSelect = false;
            this.dgvUserAppraisal.Name = "dgvUserAppraisal";
            this.dgvUserAppraisal.RowTemplate.Height = 23;
            this.dgvUserAppraisal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAppraisal.Size = new System.Drawing.Size(559, 230);
            this.dgvUserAppraisal.TabIndex = 1;
            this.dgvUserAppraisal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserAppraisal_CellMouseDown);
            this.dgvUserAppraisal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvUserAppraisal_MouseDown);
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
            this.BaseType.HeaderText = "身份";
            this.BaseType.Name = "BaseType";
            // 
            // AppraisalBase
            // 
            this.AppraisalBase.DataPropertyName = "AppraisalBase";
            this.AppraisalBase.HeaderText = "年终将基数";
            this.AppraisalBase.Name = "AppraisalBase";
            // 
            // cmsUserAppraisal
            // 
            this.cmsUserAppraisal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit});
            this.cmsUserAppraisal.Name = "cmsUserAppraisal";
            this.cmsUserAppraisal.Size = new System.Drawing.Size(125, 26);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(124, 22);
            this.tsmEdit.Text = "编辑考核";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // FrmUserAppraisal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 358);
            this.Controls.Add(this.dgvUserAppraisal);
            this.Controls.Add(this.a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserAppraisal";
            this.Text = "FrmUserAppraisal";
            this.Load += new System.EventHandler(this.FrmUserAppraisal_Load);
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAppraisal)).EndInit();
            this.cmsUserAppraisal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUserAppraisal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppraisalBase;
        private System.Windows.Forms.ContextMenuStrip cmsUserAppraisal;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
    }
}