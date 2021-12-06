using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static student_mannagement_system.link_db;

namespace student_mannagement_system
{
    public partial class UpdateCourse : Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
            cno.Text = BrowseCourse.t1;
            ccredit.Text = BrowseCourse.t2;
            cname.Text = BrowseCourse.t3;
            cexplain.Text = BrowseCourse.t4;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateCourse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseid = cno.Text;
            string credit = ccredit.Text;
            string coursename = cname.Text;
            string shuoming = cexplain.Text;
            MySqlConnection conn = Connection();
            string sql2 = "update  Course set ccredit='" + credit + "',cname='" + coursename + "',cexplain='" + shuoming + "' where cno='" + courseid + "'";
            MySqlCommand com2 = execute(sql2, conn);
            com2.ExecuteNonQuery();
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
