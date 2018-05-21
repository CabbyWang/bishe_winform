namespace ClinicSystem
{
    partial class tj_muban
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
            this.dgv_chufangmingxi = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addmingxi = new System.Windows.Forms.Button();
            this.cb_yaopinguige = new System.Windows.Forms.ComboBox();
            this.cb_yaopinmingcheng = new System.Windows.Forms.ComboBox();
            this.txt_yaopinshuliang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_yongyaofangshi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_meiricishu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_danciyongliang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_public = new System.Windows.Forms.RadioButton();
            this.rb_private = new System.Windows.Forms.RadioButton();
            this.yaopinmingcheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yaopinguige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shuliang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danciyongliang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meiricishu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yongyaofangshi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chufangmingxi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chufangmingxi
            // 
            this.dgv_chufangmingxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chufangmingxi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yaopinmingcheng,
            this.yaopinguige,
            this.shuliang,
            this.danciyongliang,
            this.meiricishu,
            this.yongyaofangshi});
            this.dgv_chufangmingxi.Location = new System.Drawing.Point(8, 22);
            this.dgv_chufangmingxi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_chufangmingxi.Name = "dgv_chufangmingxi";
            this.dgv_chufangmingxi.RowTemplate.Height = 23;
            this.dgv_chufangmingxi.Size = new System.Drawing.Size(908, 121);
            this.dgv_chufangmingxi.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(885, 494);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 41;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(751, 494);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 29);
            this.btn_add.TabIndex = 40;
            this.btn_add.Text = "添加模板";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_chufangmingxi);
            this.groupBox2.Location = new System.Drawing.Point(89, 308);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(924, 156);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "处方明细";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addmingxi);
            this.groupBox1.Controls.Add(this.cb_yaopinguige);
            this.groupBox1.Controls.Add(this.cb_yaopinmingcheng);
            this.groupBox1.Controls.Add(this.txt_yaopinshuliang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_yongyaofangshi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_meiricishu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_danciyongliang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(89, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(916, 168);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "处方基本信息";
            // 
            // btn_addmingxi
            // 
            this.btn_addmingxi.Location = new System.Drawing.Point(726, 120);
            this.btn_addmingxi.Name = "btn_addmingxi";
            this.btn_addmingxi.Size = new System.Drawing.Size(108, 29);
            this.btn_addmingxi.TabIndex = 18;
            this.btn_addmingxi.Text = "添加到明细";
            this.btn_addmingxi.UseVisualStyleBackColor = true;
            this.btn_addmingxi.Click += new System.EventHandler(this.btn_addmingxi_Click);
            // 
            // cb_yaopinguige
            // 
            this.cb_yaopinguige.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_yaopinguige.FormattingEnabled = true;
            this.cb_yaopinguige.Location = new System.Drawing.Point(388, 31);
            this.cb_yaopinguige.Name = "cb_yaopinguige";
            this.cb_yaopinguige.Size = new System.Drawing.Size(157, 23);
            this.cb_yaopinguige.TabIndex = 17;
            // 
            // cb_yaopinmingcheng
            // 
            this.cb_yaopinmingcheng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_yaopinmingcheng.FormattingEnabled = true;
            this.cb_yaopinmingcheng.Location = new System.Drawing.Point(99, 30);
            this.cb_yaopinmingcheng.Name = "cb_yaopinmingcheng";
            this.cb_yaopinmingcheng.Size = new System.Drawing.Size(157, 23);
            this.cb_yaopinmingcheng.TabIndex = 16;
            this.cb_yaopinmingcheng.SelectedIndexChanged += new System.EventHandler(this.cb_yaopinmingcheng_SelectedIndexChanged);
            // 
            // txt_yaopinshuliang
            // 
            this.txt_yaopinshuliang.Location = new System.Drawing.Point(678, 80);
            this.txt_yaopinshuliang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yaopinshuliang.Name = "txt_yaopinshuliang";
            this.txt_yaopinshuliang.Size = new System.Drawing.Size(157, 25);
            this.txt_yaopinshuliang.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "药品数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 13;
            // 
            // cb_yongyaofangshi
            // 
            this.cb_yongyaofangshi.FormattingEnabled = true;
            this.cb_yongyaofangshi.Items.AddRange(new object[] {
            "外敷",
            "口服"});
            this.cb_yongyaofangshi.Location = new System.Drawing.Point(388, 80);
            this.cb_yongyaofangshi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_yongyaofangshi.Name = "cb_yongyaofangshi";
            this.cb_yongyaofangshi.Size = new System.Drawing.Size(157, 23);
            this.cb_yongyaofangshi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "用药方式";
            // 
            // txt_meiricishu
            // 
            this.txt_meiricishu.Location = new System.Drawing.Point(98, 75);
            this.txt_meiricishu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_meiricishu.Name = "txt_meiricishu";
            this.txt_meiricishu.Size = new System.Drawing.Size(157, 25);
            this.txt_meiricishu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "每日次数";
            // 
            // txt_danciyongliang
            // 
            this.txt_danciyongliang.Location = new System.Drawing.Point(678, 30);
            this.txt_danciyongliang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_danciyongliang.Name = "txt_danciyongliang";
            this.txt_danciyongliang.Size = new System.Drawing.Size(157, 25);
            this.txt_danciyongliang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "单次用量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "药品规格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "药品名称";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(520, 62);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(168, 25);
            this.txt_name.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "模板名称:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_public);
            this.groupBox3.Controls.Add(this.rb_private);
            this.groupBox3.Location = new System.Drawing.Point(97, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 65);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "模板类型";
            // 
            // rb_public
            // 
            this.rb_public.AutoSize = true;
            this.rb_public.Location = new System.Drawing.Point(19, 32);
            this.rb_public.Name = "rb_public";
            this.rb_public.Size = new System.Drawing.Size(88, 19);
            this.rb_public.TabIndex = 0;
            this.rb_public.TabStop = true;
            this.rb_public.Text = "公共模板";
            this.rb_public.UseVisualStyleBackColor = true;
            // 
            // rb_private
            // 
            this.rb_private.AutoSize = true;
            this.rb_private.Location = new System.Drawing.Point(136, 32);
            this.rb_private.Name = "rb_private";
            this.rb_private.Size = new System.Drawing.Size(88, 19);
            this.rb_private.TabIndex = 1;
            this.rb_private.TabStop = true;
            this.rb_private.Text = "私有模板";
            this.rb_private.UseVisualStyleBackColor = true;
            // 
            // yaopinmingcheng
            // 
            this.yaopinmingcheng.DataPropertyName = "yaopinmingcheng";
            this.yaopinmingcheng.HeaderText = "药品名称";
            this.yaopinmingcheng.Name = "yaopinmingcheng";
            this.yaopinmingcheng.ReadOnly = true;
            // 
            // yaopinguige
            // 
            this.yaopinguige.DataPropertyName = "yaopinguige";
            this.yaopinguige.HeaderText = "药品规格";
            this.yaopinguige.Name = "yaopinguige";
            this.yaopinguige.ReadOnly = true;
            // 
            // shuliang
            // 
            this.shuliang.DataPropertyName = "shuliang";
            this.shuliang.HeaderText = "药品数量";
            this.shuliang.Name = "shuliang";
            this.shuliang.ReadOnly = true;
            // 
            // danciyongliang
            // 
            this.danciyongliang.DataPropertyName = "danciyongliang";
            this.danciyongliang.HeaderText = "单词用量";
            this.danciyongliang.Name = "danciyongliang";
            this.danciyongliang.ReadOnly = true;
            // 
            // meiricishu
            // 
            this.meiricishu.DataPropertyName = "meiricishu";
            this.meiricishu.HeaderText = "每日次数";
            this.meiricishu.Name = "meiricishu";
            this.meiricishu.ReadOnly = true;
            // 
            // yongyaofangshi
            // 
            this.yongyaofangshi.DataPropertyName = "yongyaofangshi";
            this.yongyaofangshi.HeaderText = "用药方式";
            this.yongyaofangshi.Name = "yongyaofangshi";
            this.yongyaofangshi.ReadOnly = true;
            // 
            // tj_muban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 555);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "tj_muban";
            this.Text = "tj_muban";
            this.Load += new System.EventHandler(this.tj_muban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chufangmingxi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addmingxi;
        private System.Windows.Forms.ComboBox cb_yaopinguige;
        private System.Windows.Forms.ComboBox cb_yaopinmingcheng;
        private System.Windows.Forms.TextBox txt_yaopinshuliang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_yongyaofangshi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_meiricishu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_danciyongliang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_public;
        private System.Windows.Forms.RadioButton rb_private;
        private System.Windows.Forms.DataGridView dgv_chufangmingxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaopinmingcheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaopinguige;
        private System.Windows.Forms.DataGridViewTextBoxColumn shuliang;
        private System.Windows.Forms.DataGridViewTextBoxColumn danciyongliang;
        private System.Windows.Forms.DataGridViewTextBoxColumn meiricishu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yongyaofangshi;
    }
}