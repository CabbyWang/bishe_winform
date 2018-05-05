using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class parent_main : Form
    {
        private int childFormNumber = 0;
        public static Label lb_op;

        public parent_main()
        {
            //current_Window = this;
            lb_op = lb_user;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tm_修改密码_Click(object sender, EventArgs e)
        {
            changePassword cp = new changePassword();
            cp.Show();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void parent_main_Load(object sender, EventArgs e)
        {
            
        }

        private void tm_医生信息查询_Click(object sender, EventArgs e)
        {
            cx_yishengxinxi cx = new cx_yishengxinxi();
            cx.Show();
        }

        private void tm_添加医生_Click(object sender, EventArgs e)
        {
            tj_yishengxinxi tj = new tj_yishengxinxi();
            tj.Show();
        }

        private void tm_用户信息查询_Click(object sender, EventArgs e)
        {
            cx_yonghuxinxi cx = new cx_yonghuxinxi();
            cx.Show();
        }

        private void tm_科室信息查询_Click(object sender, EventArgs e)
        {
            cx_keshixinxi cx = new cx_keshixinxi();
            cx.Show();
        }

        private void tm_科室信息添加_Click(object sender, EventArgs e)
        {
            tj_keshixinxi tj = new tj_keshixinxi();
            tj.Show();
        }

        private void tm_用户信息添加_Click(object sender, EventArgs e)
        {
            tj_yonghuxinxi tj = new tj_yonghuxinxi();
            tj.Show();
        }

        private void tm_挂号登记_Click(object sender, EventArgs e)
        {
            guahaoxinxidengji fm = new guahaoxinxidengji();
            fm.ShowDialog();
        }

        private void tm_门诊挂号_Click(object sender, EventArgs e)
        {
            menzhenguahao fm = new menzhenguahao();
            fm.ShowDialog();
        }

        private void tm_处方开具_Click(object sender, EventArgs e)
        {
            chufangkaiji cfkj = new chufangkaiji();
            cfkj.ShowDialog();
        }

        private void tm_退号_Click(object sender, EventArgs e)
        {

        }

        private void tm_挂号信息查询_Click(object sender, EventArgs e)
        {
            cx_guahaoxinxi cx = new cx_guahaoxinxi();
            cx.ShowDialog();
        }

        private void tm_退出_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tm_病历书写_Click(object sender, EventArgs e)
        {
            binglishuxie sx = new binglishuxie();
            sx.ShowDialog();
        }

        private void tm_门诊收费_Click(object sender, EventArgs e)
        {
            menzhenshoufei sf = new menzhenshoufei();
            sf.Show();
        }
    }
}
