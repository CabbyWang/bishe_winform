namespace ClinicSystem
{
    partial class cx_keshixinxi
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
            this.lbkeshimingcheng = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kszr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.dgv_keshixinxi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keshixinxi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_kszr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbkeshimingcheng);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(29, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(568, 112);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // lbkeshimingcheng
            // 
            this.lbkeshimingcheng.AutoSize = true;
            this.lbkeshimingcheng.Location = new System.Drawing.Point(23, 27);
            this.lbkeshimingcheng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbkeshimingcheng.Name = "lbkeshimingcheng";
            this.lbkeshimingcheng.Size = new System.Drawing.Size(67, 15);
            this.lbkeshimingcheng.TabIndex = 101;
            this.lbkeshimingcheng.Text = "科室名称";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(98, 24);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(185, 25);
            this.txt_name.TabIndex = 201;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(398, 72);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 29);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "查找";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 202;
            this.label1.Text = "科室主任";
            // 
            // txt_kszr
            // 
            this.txt_kszr.Location = new System.Drawing.Point(398, 24);
            this.txt_kszr.Name = "txt_kszr";
            this.txt_kszr.Size = new System.Drawing.Size(100, 25);
            this.txt_kszr.TabIndex = 203;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 204;
            this.label2.Text = "科室位置";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(98, 72);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(185, 25);
            this.txt_address.TabIndex = 205;
            // 
            // dgv_keshixinxi
            // 
            this.dgv_keshixinxi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_keshixinxi.Location = new System.Drawing.Point(29, 181);
            this.dgv_keshixinxi.Name = "dgv_keshixinxi";
            this.dgv_keshixinxi.RowTemplate.Height = 27;
            this.dgv_keshixinxi.Size = new System.Drawing.Size(568, 219);
            this.dgv_keshixinxi.TabIndex = 39;
            // 
            // cx_keshixinxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 432);
            this.Controls.Add(this.dgv_keshixinxi);
            this.Controls.Add(this.groupBox1);
            this.Name = "cx_keshixinxi";
            this.Text = "科室信息";
            this.Load += new System.EventHandler(this.cx_keshixinxi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keshixinxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kszr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbkeshimingcheng;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_keshixinxi;
    }
}