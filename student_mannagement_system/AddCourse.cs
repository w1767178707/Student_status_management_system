using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static student_mannagement_system.link_db;
using System.Configuration;

namespace student_mannagement_system
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (cno.Text == "")
            {
                MessageBox.Show("课程编号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (cname.Text == "")
            {
                MessageBox.Show("课程名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (ccredit.Text == "")
            {
                MessageBox.Show("课程学分不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string courseid = cno.Text;
                string credit = ccredit.Text;
                string coursename = cname.Text;
                string shuoming = cexplain.Text;
                string sql = "select count(*) from course where cno='" + courseid + "'";
                MySqlConnection conn = Connection();
                MySqlCommand com = new MySqlCommand(sql, conn);
                if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("此课程已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string sql2 = "insert into course set cno='" + courseid + "',ccredit='" + credit + "',cname='" + coursename + "',cexplain='" + shuoming + "'";
                    MySqlCommand com2 = execute(sql2, conn);
                    com2.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                }

            }
        }

        private void ac_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
