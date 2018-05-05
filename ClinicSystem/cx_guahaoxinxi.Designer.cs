namespace ClinicSystem
{
    partial class cx_guahaoxinxi
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
            this.btn_search = new System.Windows.Forms.Button();
            this.lbguahaobianhao = new System.Windows.Forms.Label();
            this.医疗证号 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_yiliaozhenghao = new System.Windows.Forms.TextBox();
            this.dgv_guahaoxinxi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guahaoxinxi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_guahaoxinxi);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lbguahaobianhao);
            this.groupBox1.Controls.Add(this.医疗证号);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_yiliaozhenghao);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(785, 211);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(602, 17);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 29);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "查找";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbguahaobianhao
            // 
            this.lbguahaobianhao.AutoSize = true;
            this.lbguahaobianhao.Location = new System.Drawing.Point(17, 21);
            this.lbguahaobianhao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbguahaobianhao.Name = "lbguahaobianhao";
            this.lbguahaobianhao.Size = new System.Drawing.Size(67, 15);
            this.lbguahaobianhao.TabIndex = 101;
            this.lbguahaobianhao.Text = "挂号编号";
            // 
            // 医疗证号
            // 
            this.医疗证号.AutoSize = true;
            this.医疗证号.Location = new System.Drawing.Point(237, 21);
            this.医疗证号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.医疗证号.Name = "医疗证号";
            this.医疗证号.Size = new System.Drawing.Size(67, 15);
            this.医疗证号.TabIndex = 102;
            this.医疗证号.Text = "医疗证号";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(96, 16);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(132, 25);
            this.txt_id.TabIndex = 201;
            // 
            // txt_yiliaozhenghao
            // 
            this.txt_yiliaozhenghao.Location = new System.Drawing.Point(316, 16);
            this.txt_yiliaozhenghao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yiliaozhenghao.Name = "txt_yiliaozhenghao";
            this.txt_yiliaozhenghao.Size = new System.Drawing.Size(132, 25);
            this.txt_yiliaozhenghao.TabIndex = 202;
            // 
            // dgv_guahaoxinxi
            // 
            this.dgv_guahaoxinxi.AllowUserToAddRows = false;
            this.dgv_guahaoxinxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_guahaoxinxi.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_guahaoxinxi.Location = new System.Drawing.Point(8, 54);
            this.dgv_guahaoxinxi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_guahaoxinxi.Name = "dgv_guahaoxinxi";
            this.dgv_guahaoxinxi.ReadOnly = true;
            this.dgv_guahaoxinxi.RowTemplate.Height = 23;
            this.dgv_guahaoxinxi.Size = new System.Drawing.Size(750, 137);
            this.dgv_guahaoxinxi.TabIndex = 203;
            // 
            // cx_guahaoxinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 486);
            this.Controls.Add(this.groupBox1);
            this.Name = "cx_guahaoxinxi";
            this.Text = "cx_guahaoxinxi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_guahaoxinxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbguahaobianhao;
        private System.Windows.Forms.Label 医疗证号;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_yiliaozhenghao;
        private System.Windows.Forms.DataGridView dgv_guahaoxinxi;
    }
}