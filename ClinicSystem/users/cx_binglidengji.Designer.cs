namespace ClinicSystem.users
{
    partial class cx_binglidengji
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
            this.btn_searh = new System.Windows.Forms.Button();
            this.lbbinglibianhao = new System.Windows.Forms.Label();
            this.lbbingrenxingming = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv_bingli = new System.Windows.Forms.DataGridView();
            this.txt_yiliaozhenghao = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bingli)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_searh);
            this.groupBox1.Controls.Add(this.lbbinglibianhao);
            this.groupBox1.Controls.Add(this.lbbingrenxingming);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_yiliaozhenghao);
            this.groupBox1.Location = new System.Drawing.Point(32, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(809, 64);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // btn_searh
            // 
            this.btn_searh.Location = new System.Drawing.Point(537, 14);
            this.btn_searh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_searh.Name = "btn_searh";
            this.btn_searh.Size = new System.Drawing.Size(100, 29);
            this.btn_searh.TabIndex = 11;
            this.btn_searh.Text = "查找";
            this.btn_searh.UseVisualStyleBackColor = true;
            this.btn_searh.Click += new System.EventHandler(this.btn_searh_Click);
            // 
            // lbbinglibianhao
            // 
            this.lbbinglibianhao.AutoSize = true;
            this.lbbinglibianhao.Location = new System.Drawing.Point(17, 21);
            this.lbbinglibianhao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbinglibianhao.Name = "lbbinglibianhao";
            this.lbbinglibianhao.Size = new System.Drawing.Size(67, 15);
            this.lbbinglibianhao.TabIndex = 101;
            this.lbbinglibianhao.Text = "病历编号";
            // 
            // lbbingrenxingming
            // 
            this.lbbingrenxingming.AutoSize = true;
            this.lbbingrenxingming.Location = new System.Drawing.Point(237, 21);
            this.lbbingrenxingming.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbingrenxingming.Name = "lbbingrenxingming";
            this.lbbingrenxingming.Size = new System.Drawing.Size(67, 15);
            this.lbbingrenxingming.TabIndex = 102;
            this.lbbingrenxingming.Text = "医疗证号";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(96, 16);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 25);
            this.txt_id.TabIndex = 201;
            // 
            // dgv_bingli
            // 
            this.dgv_bingli.AllowUserToAddRows = false;
            this.dgv_bingli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bingli.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_bingli.Location = new System.Drawing.Point(32, 104);
            this.dgv_bingli.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_bingli.Name = "dgv_bingli";
            this.dgv_bingli.ReadOnly = true;
            this.dgv_bingli.RowTemplate.Height = 23;
            this.dgv_bingli.Size = new System.Drawing.Size(809, 144);
            this.dgv_bingli.TabIndex = 40;
            // 
            // txt_yiliaozhenghao
            // 
            this.txt_yiliaozhenghao.Location = new System.Drawing.Point(316, 16);
            this.txt_yiliaozhenghao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yiliaozhenghao.Name = "txt_yiliaozhenghao";
            this.txt_yiliaozhenghao.Size = new System.Drawing.Size(132, 25);
            this.txt_yiliaozhenghao.TabIndex = 202;
            // 
            // cx_binglidengji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 444);
            this.Controls.Add(this.dgv_bingli);
            this.Controls.Add(this.groupBox1);
            this.Name = "cx_binglidengji";
            this.Text = "cx_binglidengji";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bingli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_searh;
        private System.Windows.Forms.Label lbbinglibianhao;
        private System.Windows.Forms.Label lbbingrenxingming;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_yiliaozhenghao;
        private System.Windows.Forms.DataGridView dgv_bingli;
    }
}