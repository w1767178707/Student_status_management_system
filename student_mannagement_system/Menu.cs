using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using static student_mannagement_system.register;


namespace student_mannagement_system
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            if (right == "1")
                toolStripStatusLabel1.Text = "用户名：" + un + "    身份：" + "管理员";
            else
            {
                toolStripStatusLabel1.Text = "用户名：" + un + "    身份：" + "普通用户";
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void add_major_Click(object sender, EventArgs e)
        {
            if (right == "1") 
            {
                win_add_major win = new win_add_major();
                win.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void browser_major_Click(object sender, EventArgs e)
        {
            win_browser_major win2 = new win_browser_major();
            win2.Show();
        }

        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (right == "1") 
            {
                AddClass ac = new AddClass();
                ac.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void 班级浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseClass bc = new BrowseClass();
            bc.Show();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (right == "1")
            {
                AddStudent ass = new AddStudent();
                ass.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void 浏览学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseStudent bs = new BrowseStudent();
            bs.Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (right == "1")
            {
                AddCourse ac = new AddCourse();
                ac.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void 课程浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseCourse browseCourse = new BrowseCourse();
            browseCourse.Show();
        }

        private void 系统管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (right == "1")
            {
                AddScore addScore = new AddScore();
                addScore.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void 成绩浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowseScore browseScore = new BrowseScore();
            browseScore.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(right=="1")
            {
                Addmoney addmoney = new Addmoney();
                addmoney.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 浏览缴费信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browsemoney browsemoney = new Browsemoney();
            browsemoney.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
