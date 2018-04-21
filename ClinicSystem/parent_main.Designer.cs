namespace ClinicSystem
{
    partial class parent_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.tm_系统维护 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_修改密码 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_医生信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_医生信息查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_添加医生 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_用户信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_用户信息查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_用户信息添加 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_科室信息 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_科室信息查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_科室信息添加 = new System.Windows.Forms.ToolStripMenuItem();
            this.门诊挂号 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_挂号登记 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_门诊挂号 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_退号 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_挂号信息查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_医生站 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_处方开具 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_病历书写 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_组套管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_收费 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_门诊收费登记 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_门诊收费查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_划价收费 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_退费 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_日结 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_关于 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_注销 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lb_user = new System.Windows.Forms.Label();
            this.menuStrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_系统维护,
            this.tm_医生信息,
            this.tm_用户信息,
            this.tm_科室信息,
            this.门诊挂号,
            this.tm_医生站,
            this.tm_收费,
            this.tm_关于,
            this.tm_注销});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(843, 28);
            this.menuStrip_main.TabIndex = 4;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // tm_系统维护
            // 
            this.tm_系统维护.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_修改密码});
            this.tm_系统维护.Name = "tm_系统维护";
            this.tm_系统维护.Size = new System.Drawing.Size(81, 24);
            this.tm_系统维护.Text = "系统维护";
            // 
            // tm_修改密码
            // 
            this.tm_修改密码.Name = "tm_修改密码";
            this.tm_修改密码.Size = new System.Drawing.Size(144, 26);
            this.tm_修改密码.Text = "修改密码";
            this.tm_修改密码.Click += new System.EventHandler(this.tm_修改密码_Click);
            // 
            // tm_医生信息
            // 
            this.tm_医生信息.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_医生信息查询,
            this.tm_添加医生});
            this.tm_医生信息.Name = "tm_医生信息";
            this.tm_医生信息.Size = new System.Drawing.Size(81, 24);
            this.tm_医生信息.Text = "医生信息";
            // 
            // tm_医生信息查询
            // 
            this.tm_医生信息查询.Name = "tm_医生信息查询";
            this.tm_医生信息查询.Size = new System.Drawing.Size(181, 26);
            this.tm_医生信息查询.Text = "医生信息查询";
            this.tm_医生信息查询.Click += new System.EventHandler(this.tm_医生信息查询_Click);
            // 
            // tm_添加医生
            // 
            this.tm_添加医生.Name = "tm_添加医生";
            this.tm_添加医生.Size = new System.Drawing.Size(181, 26);
            this.tm_添加医生.Text = "医生信息添加";
            this.tm_添加医生.Click += new System.EventHandler(this.tm_添加医生_Click);
            // 
            // tm_用户信息
            // 
            this.tm_用户信息.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_用户信息查询,
            this.tm_用户信息添加});
            this.tm_用户信息.Name = "tm_用户信息";
            this.tm_用户信息.Size = new System.Drawing.Size(81, 24);
            this.tm_用户信息.Text = "用户信息";
            // 
            // tm_用户信息查询
            // 
            this.tm_用户信息查询.Name = "tm_用户信息查询";
            this.tm_用户信息查询.Size = new System.Drawing.Size(181, 26);
            this.tm_用户信息查询.Text = "用户信息查询";
            this.tm_用户信息查询.Click += new System.EventHandler(this.tm_用户信息查询_Click);
            // 
            // tm_用户信息添加
            // 
            this.tm_用户信息添加.Name = "tm_用户信息添加";
            this.tm_用户信息添加.Size = new System.Drawing.Size(181, 26);
            this.tm_用户信息添加.Text = "用户信息添加";
            this.tm_用户信息添加.Click += new System.EventHandler(this.tm_用户信息添加_Click);
            // 
            // tm_科室信息
            // 
            this.tm_科室信息.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_科室信息查询,
            this.tm_科室信息添加});
            this.tm_科室信息.Name = "tm_科室信息";
            this.tm_科室信息.Size = new System.Drawing.Size(81, 24);
            this.tm_科室信息.Text = "科室信息";
            // 
            // tm_科室信息查询
            // 
            this.tm_科室信息查询.Name = "tm_科室信息查询";
            this.tm_科室信息查询.Size = new System.Drawing.Size(181, 26);
            this.tm_科室信息查询.Text = "科室信息查询";
            this.tm_科室信息查询.Click += new System.EventHandler(this.tm_科室信息查询_Click);
            // 
            // tm_科室信息添加
            // 
            this.tm_科室信息添加.Name = "tm_科室信息添加";
            this.tm_科室信息添加.Size = new System.Drawing.Size(181, 26);
            this.tm_科室信息添加.Text = "科室信息添加";
            this.tm_科室信息添加.Click += new System.EventHandler(this.tm_科室信息添加_Click);
            // 
            // 门诊挂号
            // 
            this.门诊挂号.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_挂号登记,
            this.tm_门诊挂号,
            this.tm_退号,
            this.tm_挂号信息查询});
            this.门诊挂号.Name = "门诊挂号";
            this.门诊挂号.Size = new System.Drawing.Size(81, 24);
            this.门诊挂号.Text = "门诊挂号";
            // 
            // tm_挂号登记
            // 
            this.tm_挂号登记.Name = "tm_挂号登记";
            this.tm_挂号登记.Size = new System.Drawing.Size(181, 26);
            this.tm_挂号登记.Text = "挂号登记";
            this.tm_挂号登记.Click += new System.EventHandler(this.tm_挂号登记_Click);
            // 
            // tm_门诊挂号
            // 
            this.tm_门诊挂号.Name = "tm_门诊挂号";
            this.tm_门诊挂号.Size = new System.Drawing.Size(181, 26);
            this.tm_门诊挂号.Text = "门诊挂号";
            this.tm_门诊挂号.Click += new System.EventHandler(this.tm_门诊挂号_Click);
            // 
            // tm_退号
            // 
            this.tm_退号.Name = "tm_退号";
            this.tm_退号.Size = new System.Drawing.Size(181, 26);
            this.tm_退号.Text = "退号";
            // 
            // tm_挂号信息查询
            // 
            this.tm_挂号信息查询.Name = "tm_挂号信息查询";
            this.tm_挂号信息查询.Size = new System.Drawing.Size(181, 26);
            this.tm_挂号信息查询.Text = "挂号信息查询";
            // 
            // tm_医生站
            // 
            this.tm_医生站.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_处方开具,
            this.tm_病历书写,
            this.tm_组套管理});
            this.tm_医生站.Name = "tm_医生站";
            this.tm_医生站.Size = new System.Drawing.Size(66, 24);
            this.tm_医生站.Text = "医生站";
            // 
            // tm_处方开具
            // 
            this.tm_处方开具.Name = "tm_处方开具";
            this.tm_处方开具.Size = new System.Drawing.Size(144, 26);
            this.tm_处方开具.Text = "处方开具";
            // 
            // tm_病历书写
            // 
            this.tm_病历书写.Name = "tm_病历书写";
            this.tm_病历书写.Size = new System.Drawing.Size(144, 26);
            this.tm_病历书写.Text = "病历书写";
            // 
            // tm_组套管理
            // 
            this.tm_组套管理.Name = "tm_组套管理";
            this.tm_组套管理.Size = new System.Drawing.Size(144, 26);
            this.tm_组套管理.Text = "组套管理";
            // 
            // tm_收费
            // 
            this.tm_收费.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_门诊收费登记,
            this.tm_门诊收费查询,
            this.tm_划价收费,
            this.tm_退费,
            this.tm_日结});
            this.tm_收费.Name = "tm_收费";
            this.tm_收费.Size = new System.Drawing.Size(51, 24);
            this.tm_收费.Text = "收费";
            // 
            // tm_门诊收费登记
            // 
            this.tm_门诊收费登记.Name = "tm_门诊收费登记";
            this.tm_门诊收费登记.Size = new System.Drawing.Size(174, 26);
            this.tm_门诊收费登记.Text = "门诊收费登记";
            // 
            // tm_门诊收费查询
            // 
            this.tm_门诊收费查询.Name = "tm_门诊收费查询";
            this.tm_门诊收费查询.Size = new System.Drawing.Size(174, 26);
            this.tm_门诊收费查询.Text = "门诊收费查询";
            // 
            // tm_划价收费
            // 
            this.tm_划价收费.Name = "tm_划价收费";
            this.tm_划价收费.Size = new System.Drawing.Size(174, 26);
            this.tm_划价收费.Text = "划价收费";
            // 
            // tm_退费
            // 
            this.tm_退费.Name = "tm_退费";
            this.tm_退费.Size = new System.Drawing.Size(174, 26);
            this.tm_退费.Text = "退费";
            // 
            // tm_日结
            // 
            this.tm_日结.Name = "tm_日结";
            this.tm_日结.Size = new System.Drawing.Size(174, 26);
            this.tm_日结.Text = "日结";
            // 
            // tm_关于
            // 
            this.tm_关于.Name = "tm_关于";
            this.tm_关于.Size = new System.Drawing.Size(51, 24);
            this.tm_关于.Text = "关于";
            // 
            // tm_注销
            // 
            this.tm_注销.Name = "tm_注销";
            this.tm_注销.Size = new System.Drawing.Size(51, 24);
            this.tm_注销.Text = "注销";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前用户:";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(148, 507);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(0, 15);
            this.lb_user.TabIndex = 6;
            // 
            // parent_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 523);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip_main);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "parent_main";
            this.Text = "parent_main";
            this.Load += new System.EventHandler(this.parent_main_Load);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem tm_系统维护;
        private System.Windows.Forms.ToolStripMenuItem tm_修改密码;
        private System.Windows.Forms.ToolStripMenuItem tm_医生信息;
        private System.Windows.Forms.ToolStripMenuItem tm_医生信息查询;
        private System.Windows.Forms.ToolStripMenuItem tm_添加医生;
        private System.Windows.Forms.ToolStripMenuItem tm_用户信息;
        private System.Windows.Forms.ToolStripMenuItem tm_用户信息查询;
        private System.Windows.Forms.ToolStripMenuItem tm_用户信息添加;
        private System.Windows.Forms.ToolStripMenuItem tm_科室信息;
        private System.Windows.Forms.ToolStripMenuItem tm_科室信息查询;
        private System.Windows.Forms.ToolStripMenuItem tm_科室信息添加;
        private System.Windows.Forms.ToolStripMenuItem 门诊挂号;
        private System.Windows.Forms.ToolStripMenuItem tm_挂号登记;
        private System.Windows.Forms.ToolStripMenuItem tm_门诊挂号;
        private System.Windows.Forms.ToolStripMenuItem tm_退号;
        private System.Windows.Forms.ToolStripMenuItem tm_挂号信息查询;
        private System.Windows.Forms.ToolStripMenuItem tm_医生站;
        private System.Windows.Forms.ToolStripMenuItem tm_处方开具;
        private System.Windows.Forms.ToolStripMenuItem tm_病历书写;
        private System.Windows.Forms.ToolStripMenuItem tm_组套管理;
        private System.Windows.Forms.ToolStripMenuItem tm_收费;
        private System.Windows.Forms.ToolStripMenuItem tm_门诊收费登记;
        private System.Windows.Forms.ToolStripMenuItem tm_门诊收费查询;
        private System.Windows.Forms.ToolStripMenuItem tm_划价收费;
        private System.Windows.Forms.ToolStripMenuItem tm_退费;
        private System.Windows.Forms.ToolStripMenuItem tm_日结;
        private System.Windows.Forms.ToolStripMenuItem tm_关于;
        private System.Windows.Forms.ToolStripMenuItem tm_注销;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label lb_user;
    }
}



