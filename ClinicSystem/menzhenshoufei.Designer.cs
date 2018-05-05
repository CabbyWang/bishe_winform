namespace ClinicSystem
{
    partial class menzhenshoufei
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ptid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_yaopinxiangqing = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_zongjine = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yaopinxiangqing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_ptid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 66);
            this.panel1.TabIndex = 0;
            // 
            // txt_ptid
            // 
            this.txt_ptid.Location = new System.Drawing.Point(181, 19);
            this.txt_ptid.Name = "txt_ptid";
            this.txt_ptid.Size = new System.Drawing.Size(100, 25);
            this.txt_ptid.TabIndex = 1;
            this.txt_ptid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ptid_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入医疗证号:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(324, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = "门诊收费";
            // 
            // dgv_yaopinxiangqing
            // 
            this.dgv_yaopinxiangqing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yaopinxiangqing.Location = new System.Drawing.Point(60, 185);
            this.dgv_yaopinxiangqing.Name = "dgv_yaopinxiangqing";
            this.dgv_yaopinxiangqing.RowTemplate.Height = 27;
            this.dgv_yaopinxiangqing.Size = new System.Drawing.Size(744, 150);
            this.dgv_yaopinxiangqing.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "应收金额:";
            // 
            // lb_zongjine
            // 
            this.lb_zongjine.AutoSize = true;
            this.lb_zongjine.Location = new System.Drawing.Point(171, 395);
            this.lb_zongjine.Name = "lb_zongjine";
            this.lb_zongjine.Size = new System.Drawing.Size(0, 15);
            this.lb_zongjine.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "确认收费";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 39;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menzhenshoufei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 479);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_zongjine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_yaopinxiangqing);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Name = "menzhenshoufei";
            this.Text = "menzhenshoufei";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yaopinxiangqing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ptid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgv_yaopinxiangqing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_zongjine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}