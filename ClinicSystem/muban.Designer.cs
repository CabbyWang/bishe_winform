namespace ClinicSystem
{
    partial class muban
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
            this.rb_public = new System.Windows.Forms.RadioButton();
            this.rb_private = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv_muban = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_mingxi = new System.Windows.Forms.DataGridView();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muban)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mingxi)).BeginInit();
            this.SuspendLayout();
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
            this.rb_public.CheckedChanged += new System.EventHandler(this.rb_public_CheckedChanged);
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
            this.rb_private.CheckedChanged += new System.EventHandler(this.rb_private_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_public);
            this.groupBox1.Controls.Add(this.rb_private);
            this.groupBox1.Location = new System.Drawing.Point(48, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模板类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "模板名称:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(471, 63);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(168, 25);
            this.txt_name.TabIndex = 4;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // dgv_muban
            // 
            this.dgv_muban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muban.Location = new System.Drawing.Point(33, 24);
            this.dgv_muban.Name = "dgv_muban";
            this.dgv_muban.RowTemplate.Height = 27;
            this.dgv_muban.Size = new System.Drawing.Size(825, 179);
            this.dgv_muban.TabIndex = 5;
            this.dgv_muban.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_muban_CellContentDoubleClick);
            this.dgv_muban.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_muban_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_muban);
            this.groupBox2.Location = new System.Drawing.Point(48, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 210);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "处方模板";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_mingxi);
            this.groupBox3.Location = new System.Drawing.Point(48, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 241);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "处方信息";
            // 
            // dgv_mingxi
            // 
            this.dgv_mingxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mingxi.Location = new System.Drawing.Point(33, 24);
            this.dgv_mingxi.Name = "dgv_mingxi";
            this.dgv_mingxi.RowTemplate.Height = 27;
            this.dgv_mingxi.Size = new System.Drawing.Size(825, 211);
            this.dgv_mingxi.TabIndex = 0;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(719, 582);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 40);
            this.btn_apply.TabIndex = 8;
            this.btn_apply.Text = "调用模板";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(840, 582);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 40);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // muban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 634);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "muban";
            this.Text = "处方模板";
            this.Load += new System.EventHandler(this.muban_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muban)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mingxi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_public;
        private System.Windows.Forms.RadioButton rb_private;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.DataGridView dgv_muban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_mingxi;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancel;
    }
}