namespace ClinicSystem.users
{
    partial class parent_users
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tm_个人中心 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_修改密码 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_个人资料 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_ghdj = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_挂号登记查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_病历登记 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_病历登记查询 = new System.Windows.Forms.ToolStripMenuItem();
            this.购买记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_关于 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_注销 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_个人中心,
            this.tm_ghdj,
            this.tm_病历登记,
            this.购买记录ToolStripMenuItem,
            this.tm_关于,
            this.tm_注销});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tm_个人中心
            // 
            this.tm_个人中心.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_修改密码,
            this.tm_个人资料});
            this.tm_个人中心.Name = "tm_个人中心";
            this.tm_个人中心.Size = new System.Drawing.Size(81, 24);
            this.tm_个人中心.Text = "个人中心";
            // 
            // tm_修改密码
            // 
            this.tm_修改密码.Name = "tm_修改密码";
            this.tm_修改密码.Size = new System.Drawing.Size(181, 26);
            this.tm_修改密码.Text = "修改密码";
            // 
            // tm_个人资料
            // 
            this.tm_个人资料.Name = "tm_个人资料";
            this.tm_个人资料.Size = new System.Drawing.Size(181, 26);
            this.tm_个人资料.Text = "个人资料";
            // 
            // tm_ghdj
            // 
            this.tm_ghdj.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_挂号登记查询});
            this.tm_ghdj.Name = "tm_ghdj";
            this.tm_ghdj.Size = new System.Drawing.Size(81, 24);
            this.tm_ghdj.Text = "历史挂号";
            // 
            // tm_挂号登记查询
            // 
            this.tm_挂号登记查询.Name = "tm_挂号登记查询";
            this.tm_挂号登记查询.Size = new System.Drawing.Size(181, 26);
            this.tm_挂号登记查询.Text = "挂号登记查询";
            this.tm_挂号登记查询.Click += new System.EventHandler(this.tm_挂号登记查询_Click);
            // 
            // tm_病历登记
            // 
            this.tm_病历登记.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tm_病历登记查询});
            this.tm_病历登记.Name = "tm_病历登记";
            this.tm_病历登记.Size = new System.Drawing.Size(81, 24);
            this.tm_病历登记.Text = "历史病历";
            // 
            // tm_病历登记查询
            // 
            this.tm_病历登记查询.Name = "tm_病历登记查询";
            this.tm_病历登记查询.Size = new System.Drawing.Size(181, 26);
            this.tm_病历登记查询.Text = "病历登记查询";
            this.tm_病历登记查询.Click += new System.EventHandler(this.tm_病历登记查询_Click);
            // 
            // 购买记录ToolStripMenuItem
            // 
            this.购买记录ToolStripMenuItem.Name = "购买记录ToolStripMenuItem";
            this.购买记录ToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // tm_关于
            // 
            this.tm_关于.Name = "tm_关于";
            this.tm_关于.Size = new System.Drawing.Size(51, 24);
            this.tm_关于.Text = "关于";
            this.tm_关于.Click += new System.EventHandler(this.tm_关于_Click);
            // 
            // tm_注销
            // 
            this.tm_注销.Name = "tm_注销";
            this.tm_注销.Size = new System.Drawing.Size(51, 24);
            this.tm_注销.Text = "注销";
            this.tm_注销.Click += new System.EventHandler(this.tm_注销_Click);
            // 
            // parent_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 523);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "parent_users";
            this.Text = "parent_users";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tm_个人中心;
        private System.Windows.Forms.ToolStripMenuItem tm_修改密码;
        private System.Windows.Forms.ToolStripMenuItem tm_个人资料;
        private System.Windows.Forms.ToolStripMenuItem tm_ghdj;
        private System.Windows.Forms.ToolStripMenuItem tm_挂号登记查询;
        private System.Windows.Forms.ToolStripMenuItem tm_病历登记;
        private System.Windows.Forms.ToolStripMenuItem tm_病历登记查询;
        private System.Windows.Forms.ToolStripMenuItem 购买记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tm_关于;
        private System.Windows.Forms.ToolStripMenuItem tm_注销;
    }
}



