﻿namespace ClinicSystem
{
    partial class chufangkaiji
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
            this.label14 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ID_number = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.txt_guahaobianhao2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_guahaobianhao = new System.Windows.Forms.TextBox();
            this.btn_muban = new System.Windows.Forms.Button();
            this.yaopinmingcheng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yaopinguige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shuliang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danciyongliang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meiricishu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yongyaofangshi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chufangmingxi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dgv_chufangmingxi.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(382, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 30);
            this.label14.TabIndex = 33;
            this.label14.Text = "处方开具";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(756, 567);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 29);
            this.btn_cancel.TabIndex = 30;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(648, 567);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 29);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "开处方";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_name);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txt_ID_number);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(22, 114);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(916, 67);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "患者基本信息";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(541, 31);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(149, 25);
            this.txt_name.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(495, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "姓名";
            // 
            // txt_ID_number
            // 
            this.txt_ID_number.Enabled = false;
            this.txt_ID_number.Location = new System.Drawing.Point(139, 31);
            this.txt_ID_number.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ID_number.Name = "txt_ID_number";
            this.txt_ID_number.Size = new System.Drawing.Size(316, 25);
            this.txt_ID_number.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "患者身份证号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_chufangmingxi);
            this.groupBox2.Location = new System.Drawing.Point(22, 380);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(924, 156);
            this.groupBox2.TabIndex = 25;
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
            this.groupBox1.Controls.Add(this.txt_guahaobianhao2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(916, 168);
            this.groupBox1.TabIndex = 24;
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
            this.cb_yaopinguige.Location = new System.Drawing.Point(93, 71);
            this.cb_yaopinguige.Name = "cb_yaopinguige";
            this.cb_yaopinguige.Size = new System.Drawing.Size(157, 23);
            this.cb_yaopinguige.TabIndex = 17;
            // 
            // cb_yaopinmingcheng
            // 
            this.cb_yaopinmingcheng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_yaopinmingcheng.FormattingEnabled = true;
            this.cb_yaopinmingcheng.Location = new System.Drawing.Point(677, 22);
            this.cb_yaopinmingcheng.Name = "cb_yaopinmingcheng";
            this.cb_yaopinmingcheng.Size = new System.Drawing.Size(157, 23);
            this.cb_yaopinmingcheng.TabIndex = 16;
            this.cb_yaopinmingcheng.TextChanged += new System.EventHandler(this.cb_yaopinmingcheng_TextChanged);
            // 
            // txt_yaopinshuliang
            // 
            this.txt_yaopinshuliang.Location = new System.Drawing.Point(395, 120);
            this.txt_yaopinshuliang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yaopinshuliang.Name = "txt_yaopinshuliang";
            this.txt_yaopinshuliang.Size = new System.Drawing.Size(157, 25);
            this.txt_yaopinshuliang.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 130);
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
            this.cb_yongyaofangshi.Location = new System.Drawing.Point(93, 120);
            this.cb_yongyaofangshi.Margin = new System.Windows.Forms.Padding(4);
            this.cb_yongyaofangshi.Name = "cb_yongyaofangshi";
            this.cb_yongyaofangshi.Size = new System.Drawing.Size(157, 23);
            this.cb_yongyaofangshi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "用药方式";
            // 
            // txt_meiricishu
            // 
            this.txt_meiricishu.Location = new System.Drawing.Point(677, 70);
            this.txt_meiricishu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_meiricishu.Name = "txt_meiricishu";
            this.txt_meiricishu.Size = new System.Drawing.Size(157, 25);
            this.txt_meiricishu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "每日次数";
            // 
            // txt_danciyongliang
            // 
            this.txt_danciyongliang.Location = new System.Drawing.Point(395, 74);
            this.txt_danciyongliang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_danciyongliang.Name = "txt_danciyongliang";
            this.txt_danciyongliang.Size = new System.Drawing.Size(157, 25);
            this.txt_danciyongliang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "单次用量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "药品规格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "药品名称";
            // 
            // txt_guahaobianhao2
            // 
            this.txt_guahaobianhao2.Enabled = false;
            this.txt_guahaobianhao2.Location = new System.Drawing.Point(395, 22);
            this.txt_guahaobianhao2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guahaobianhao2.Name = "txt_guahaobianhao2";
            this.txt_guahaobianhao2.Size = new System.Drawing.Size(157, 25);
            this.txt_guahaobianhao2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "挂号编号";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(93, 22);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(157, 25);
            this.txt_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "处方号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "挂号编号";
            // 
            // txt_guahaobianhao
            // 
            this.txt_guahaobianhao.Location = new System.Drawing.Point(185, 72);
            this.txt_guahaobianhao.Name = "txt_guahaobianhao";
            this.txt_guahaobianhao.Size = new System.Drawing.Size(100, 25);
            this.txt_guahaobianhao.TabIndex = 35;
            this.txt_guahaobianhao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_guahaobianhao_KeyPress);
            this.txt_guahaobianhao.Leave += new System.EventHandler(this.txt_guahaobianhao_Leave);
            // 
            // btn_muban
            // 
            this.btn_muban.Location = new System.Drawing.Point(540, 567);
            this.btn_muban.Margin = new System.Windows.Forms.Padding(4);
            this.btn_muban.Name = "btn_muban";
            this.btn_muban.Size = new System.Drawing.Size(100, 29);
            this.btn_muban.TabIndex = 36;
            this.btn_muban.Text = "处方模板";
            this.btn_muban.UseVisualStyleBackColor = true;
            this.btn_muban.Click += new System.EventHandler(this.btn_muban_Click);
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
            // chufangkaiji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 619);
            this.Controls.Add(this.btn_muban);
            this.Controls.Add(this.txt_guahaobianhao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "chufangkaiji";
            this.Text = "chufangkaiji";
            this.Load += new System.EventHandler(this.chufangkaiji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chufangmingxi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ID_number;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox txt_guahaobianhao2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_guahaobianhao;
        private System.Windows.Forms.ComboBox cb_yaopinguige;
        private System.Windows.Forms.ComboBox cb_yaopinmingcheng;
        private System.Windows.Forms.Button btn_addmingxi;
        private System.Windows.Forms.Button btn_muban;
        private System.Windows.Forms.DataGridView dgv_chufangmingxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaopinmingcheng;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaopinguige;
        private System.Windows.Forms.DataGridViewTextBoxColumn shuliang;
        private System.Windows.Forms.DataGridViewTextBoxColumn danciyongliang;
        private System.Windows.Forms.DataGridViewTextBoxColumn meiricishu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yongyaofangshi;
    }
}