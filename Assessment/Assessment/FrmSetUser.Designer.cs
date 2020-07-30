namespace Assessment
{
    partial class FrmSetUser
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
            this.tmsName = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmsSex = new System.Windows.Forms.Label();
            this.comsex = new System.Windows.Forms.ComboBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.chkIsStop = new System.Windows.Forms.CheckBox();
            this.comBase = new System.Windows.Forms.ComboBox();
            this.tmsName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmsName
            // 
            this.tmsName.Controls.Add(this.comBase);
            this.tmsName.Controls.Add(this.chkIsStop);
            this.tmsName.Controls.Add(this.tName);
            this.tmsName.Controls.Add(this.comsex);
            this.tmsName.Controls.Add(this.tmsSex);
            this.tmsName.Controls.Add(this.label2);
            this.tmsName.Controls.Add(this.label1);
            this.tmsName.Location = new System.Drawing.Point(12, 12);
            this.tmsName.Name = "tmsName";
            this.tmsName.Size = new System.Drawing.Size(522, 116);
            this.tmsName.TabIndex = 0;
            this.tmsName.TabStop = false;
            this.tmsName.Text = "填写信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(430, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "身份";
            // 
            // tmsSex
            // 
            this.tmsSex.AutoSize = true;
            this.tmsSex.Location = new System.Drawing.Point(37, 82);
            this.tmsSex.Name = "tmsSex";
            this.tmsSex.Size = new System.Drawing.Size(29, 12);
            this.tmsSex.TabIndex = 2;
            this.tmsSex.Text = "性别";
            // 
            // comsex
            // 
            this.comsex.FormattingEnabled = true;
            this.comsex.Location = new System.Drawing.Point(100, 79);
            this.comsex.Name = "comsex";
            this.comsex.Size = new System.Drawing.Size(121, 20);
            this.comsex.TabIndex = 3;
            this.comsex.Text = "男";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(100, 35);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(100, 21);
            this.tName.TabIndex = 4;
            // 
            // chkIsStop
            // 
            this.chkIsStop.AutoSize = true;
            this.chkIsStop.Location = new System.Drawing.Point(267, 84);
            this.chkIsStop.Name = "chkIsStop";
            this.chkIsStop.Size = new System.Drawing.Size(72, 16);
            this.chkIsStop.TabIndex = 6;
            this.chkIsStop.Text = "是否停用";
            this.chkIsStop.UseVisualStyleBackColor = true;
            // 
            // comBase
            // 
            this.comBase.FormattingEnabled = true;
            this.comBase.Location = new System.Drawing.Point(286, 32);
            this.comBase.Name = "comBase";
            this.comBase.Size = new System.Drawing.Size(121, 20);
            this.comBase.TabIndex = 7;
            // 
            // FrmSetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tmsName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSetUser";
            this.Text = "FrmSetUser";
            this.Load += new System.EventHandler(this.FrmSetUser_Load);
            this.tmsName.ResumeLayout(false);
            this.tmsName.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tmsName;
        private System.Windows.Forms.CheckBox chkIsStop;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.ComboBox comsex;
        private System.Windows.Forms.Label tmsSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comBase;
    }
}