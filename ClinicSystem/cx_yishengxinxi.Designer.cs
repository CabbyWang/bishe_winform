namespace ClinicSystem
{
    partial class cx_yishengxinxi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbyishengxingming = new System.Windows.Forms.Label();
            this.lbzhuzhikemu = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_yishengxinxi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhicheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.labelyishengxingming = new System.Windows.Forms.Label();
            this.txt_name2 = new System.Windows.Forms.TextBox();
            this.labelxingbie = new System.Windows.Forms.Label();
            this.cb_sex2 = new System.Windows.Forms.ComboBox();
            this.labelzhicheng = new System.Windows.Forms.Label();
            this.txt_zhicheng = new System.Windows.Forms.TextBox();
            this.labelzhuzhikemu = new System.Windows.Forms.Label();
            this.labelshenfenzheng = new System.Windows.Forms.Label();
            this.txt_ID_number = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_department2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yishengxinxi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_sex);
            this.groupBox1.Controls.Add(this.cb_department);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbyishengxingming);
            this.groupBox1.Controls.Add(this.lbzhuzhikemu);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(909, 55);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // cb_sex
            // 
            this.cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Location = new System.Drawing.Point(498, 20);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(72, 23);
            this.cb_sex.TabIndex = 208;
            // 
            // cb_department
            // 
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(284, 20);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(121, 23);
            this.cb_department.TabIndex = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 205;
            this.label1.Text = "性别";
            // 
            // lbyishengxingming
            // 
            this.lbyishengxingming.AutoSize = true;
            this.lbyishengxingming.Location = new System.Drawing.Point(17, 21);
            this.lbyishengxingming.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbyishengxingming.Name = "lbyishengxingming";
            this.lbyishengxingming.Size = new System.Drawing.Size(67, 15);
            this.lbyishengxingming.TabIndex = 101;
            this.lbyishengxingming.Text = "医生姓名";
            // 
            // lbzhuzhikemu
            // 
            this.lbzhuzhikemu.AutoSize = true;
            this.lbzhuzhikemu.Location = new System.Drawing.Point(232, 23);
            this.lbzhuzhikemu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbzhuzhikemu.Name = "lbzhuzhikemu";
            this.lbzhuzhikemu.Size = new System.Drawing.Size(45, 15);
            this.lbzhuzhikemu.TabIndex = 104;
            this.lbzhuzhikemu.Text = " 科室";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(92, 18);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 25);
            this.txt_name.TabIndex = 201;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(651, 18);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 29);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "查找";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_yishengxinxi);
            this.groupBox2.Location = new System.Drawing.Point(13, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(400, 430);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "医生信息";
            // 
            // dgv_yishengxinxi
            // 
            this.dgv_yishengxinxi.AllowUserToAddRows = false;
            this.dgv_yishengxinxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yishengxinxi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.sex,
            this.zhicheng,
            this.department,
            this.ID_number,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_yishengxinxi.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_yishengxinxi.Location = new System.Drawing.Point(6, 21);
            this.dgv_yishengxinxi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_yishengxinxi.Name = "dgv_yishengxinxi";
            this.dgv_yishengxinxi.ReadOnly = true;
            this.dgv_yishengxinxi.RowTemplate.Height = 23;
            this.dgv_yishengxinxi.Size = new System.Drawing.Size(394, 409);
            this.dgv_yishengxinxi.TabIndex = 0;
            this.dgv_yishengxinxi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_yishengxinxi_CellClick);
            this.dgv_yishengxinxi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_yishengxinxi_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // zhicheng
            // 
            this.zhicheng.DataPropertyName = "zhicheng";
            this.zhicheng.HeaderText = "职称";
            this.zhicheng.Name = "zhicheng";
            this.zhicheng.ReadOnly = true;
            // 
            // department
            // 
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "科室";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // ID_number
            // 
            this.ID_number.DataPropertyName = "ID_number";
            this.ID_number.HeaderText = "身份证号";
            this.ID_number.Name = "ID_number";
            this.ID_number.ReadOnly = true;
            this.ID_number.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "password";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "role";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "createtime";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_department2);
            this.groupBox3.Controls.Add(this.btn_reset);
            this.groupBox3.Controls.Add(this.labelyishengxingming);
            this.groupBox3.Controls.Add(this.txt_name2);
            this.groupBox3.Controls.Add(this.labelxingbie);
            this.groupBox3.Controls.Add(this.cb_sex2);
            this.groupBox3.Controls.Add(this.labelzhicheng);
            this.groupBox3.Controls.Add(this.txt_zhicheng);
            this.groupBox3.Controls.Add(this.labelzhuzhikemu);
            this.groupBox3.Controls.Add(this.labelshenfenzheng);
            this.groupBox3.Controls.Add(this.txt_ID_number);
            this.groupBox3.Location = new System.Drawing.Point(421, 76);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(501, 297);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "医生信息";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(403, 168);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 26);
            this.btn_reset.TabIndex = 64;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // labelyishengxingming
            // 
            this.labelyishengxingming.AutoSize = true;
            this.labelyishengxingming.Location = new System.Drawing.Point(26, 56);
            this.labelyishengxingming.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelyishengxingming.Name = "labelyishengxingming";
            this.labelyishengxingming.Size = new System.Drawing.Size(67, 15);
            this.labelyishengxingming.TabIndex = 55;
            this.labelyishengxingming.Text = "医生姓名";
            // 
            // txt_name2
            // 
            this.txt_name2.Location = new System.Drawing.Point(118, 50);
            this.txt_name2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name2.Name = "txt_name2";
            this.txt_name2.Size = new System.Drawing.Size(185, 25);
            this.txt_name2.TabIndex = 45;
            // 
            // labelxingbie
            // 
            this.labelxingbie.AutoSize = true;
            this.labelxingbie.Location = new System.Drawing.Point(314, 55);
            this.labelxingbie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelxingbie.Name = "labelxingbie";
            this.labelxingbie.Size = new System.Drawing.Size(37, 15);
            this.labelxingbie.TabIndex = 57;
            this.labelxingbie.Text = "性别";
            // 
            // cb_sex2
            // 
            this.cb_sex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex2.Location = new System.Drawing.Point(369, 53);
            this.cb_sex2.Margin = new System.Windows.Forms.Padding(4);
            this.cb_sex2.Name = "cb_sex2";
            this.cb_sex2.Size = new System.Drawing.Size(75, 23);
            this.cb_sex2.TabIndex = 47;
            // 
            // labelzhicheng
            // 
            this.labelzhicheng.AutoSize = true;
            this.labelzhicheng.Location = new System.Drawing.Point(34, 114);
            this.labelzhicheng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelzhicheng.Name = "labelzhicheng";
            this.labelzhicheng.Size = new System.Drawing.Size(37, 15);
            this.labelzhicheng.TabIndex = 59;
            this.labelzhicheng.Text = "职称";
            // 
            // txt_zhicheng
            // 
            this.txt_zhicheng.Location = new System.Drawing.Point(118, 106);
            this.txt_zhicheng.Margin = new System.Windows.Forms.Padding(4);
            this.txt_zhicheng.Name = "txt_zhicheng";
            this.txt_zhicheng.Size = new System.Drawing.Size(185, 25);
            this.txt_zhicheng.TabIndex = 49;
            // 
            // labelzhuzhikemu
            // 
            this.labelzhuzhikemu.AutoSize = true;
            this.labelzhuzhikemu.Location = new System.Drawing.Point(314, 110);
            this.labelzhuzhikemu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelzhuzhikemu.Name = "labelzhuzhikemu";
            this.labelzhuzhikemu.Size = new System.Drawing.Size(37, 15);
            this.labelzhuzhikemu.TabIndex = 61;
            this.labelzhuzhikemu.Text = "科室";
            // 
            // labelshenfenzheng
            // 
            this.labelshenfenzheng.AutoSize = true;
            this.labelshenfenzheng.Location = new System.Drawing.Point(28, 173);
            this.labelshenfenzheng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelshenfenzheng.Name = "labelshenfenzheng";
            this.labelshenfenzheng.Size = new System.Drawing.Size(52, 15);
            this.labelshenfenzheng.TabIndex = 63;
            this.labelshenfenzheng.Text = "身份证";
            // 
            // txt_ID_number
            // 
            this.txt_ID_number.Location = new System.Drawing.Point(118, 168);
            this.txt_ID_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID_number.Name = "txt_ID_number";
            this.txt_ID_number.Size = new System.Drawing.Size(253, 25);
            this.txt_ID_number.TabIndex = 53;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_cancel);
            this.groupBox4.Controls.Add(this.btn_delete);
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.Controls.Add(this.btn_add);
            this.groupBox4.Location = new System.Drawing.Point(421, 425);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(512, 70);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "操作";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(387, 25);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "退出";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(259, 25);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 29);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(123, 25);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 29);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(4, 25);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 29);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_department2
            // 
            this.cb_department2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department2.FormattingEnabled = true;
            this.cb_department2.Location = new System.Drawing.Point(369, 106);
            this.cb_department2.Name = "cb_department2";
            this.cb_department2.Size = new System.Drawing.Size(121, 23);
            this.cb_department2.TabIndex = 65;
            // 
            // cx_yishengxinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 529);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "cx_yishengxinxi";
            this.Text = "cx_yishengxinxi";
            this.Load += new System.EventHandler(this.cx_yishengxinxi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yishengxinxi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbyishengxingming;
        private System.Windows.Forms.Label lbzhuzhikemu;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelyishengxingming;
        private System.Windows.Forms.TextBox txt_name2;
        private System.Windows.Forms.Label labelxingbie;
        private System.Windows.Forms.ComboBox cb_sex2;
        private System.Windows.Forms.Label labelzhicheng;
        private System.Windows.Forms.TextBox txt_zhicheng;
        private System.Windows.Forms.Label labelzhuzhikemu;
        private System.Windows.Forms.Label labelshenfenzheng;
        private System.Windows.Forms.TextBox txt_ID_number;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridView dgv_yishengxinxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhicheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cb_department2;
    }
}