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
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        private void AddScore_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (sno.Text == "")
            {
                MessageBox.Show("学号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (cno.Text == "")
            {
                MessageBox.Show("课程号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (grade.Text == "")
            {
                MessageBox.Show("成绩不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MySqlConnection conn = Connection();
                string studentid = sno.Text;
                string courseid = cno.Text;
                string score =grade.Text;
                string sql1 = "SELECT COUNT(*) FROM choose WHERE sno='" + studentid + "' AND cno='" + courseid + "' ";
                string sql = "SELECT COUNT(*) FROM student WHERE sno = '" + studentid + "'";
                MySqlCommand com1 = new MySqlCommand(sql, conn);
                string sql3 = "SELECT COUNT(*) FROM course WHERE cno = '" + courseid + "'";
                MySqlCommand com2 = execute(sql3, conn);
                MySqlCommand com = execute(sql1, conn);
                if (Convert.ToInt32(com1.ExecuteScalar()) == 0)
                {
                    MessageBox.Show("不存在此学生，请先添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (Convert.ToInt32(com2.ExecuteScalar()) == 0)
                {
                    MessageBox.Show("不存在此课程，请先添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("此成绩已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string sql2 = "insert into choose set sno='" + studentid + "',cno='" + courseid + "',grade='" + score + "'";
                    MySqlCommand com3 = new MySqlCommand(sql2, conn);
                    com3.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
