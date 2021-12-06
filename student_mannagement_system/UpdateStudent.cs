using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using static student_mannagement_system.link_db;
using static student_mannagement_system.BrowseStudent;

namespace student_mannagement_system
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
            label7.Text = x;
            MySqlConnection conn = Connection();
            MySqlCommand st = new MySqlCommand("select classname from class", conn);
            MySqlDataReader reader1 = st.ExecuteReader();
            classno.Items.Clear();
            while (reader1.Read())
            {
                classno.Items.Add((string)reader1[0]);
            }
            reader1.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {

        }

        private void config_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
                MessageBox.Show("学号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (sname.Text == "")
            {
                MessageBox.Show("学生姓名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string studentage = sage.Text;
                string banji = "";
                if (classno.SelectedIndex != -1)
                {
                    banji = classno.SelectedItem.ToString();
                }
                else
                {
                    classno.SelectedIndex = 0;
                }
                string classid = "";
                string sql = "select classno from Class where classname='" + banji + "'";
                MySqlConnection conn = Connection();
                MySqlCommand comt = new MySqlCommand(sql, conn);
                MySqlDataReader reader = comt.ExecuteReader();
                while (reader.Read())
                {
                    classid = (string)reader[0];
                }
                reader.Close();
                string miashu = sexplain.Text;
                string studentid = label7.Text;
                string studentname = sname.Text;
                string studentsex = ssex.SelectedItem.ToString();
                string sql1 = "select count(*) from student where sno='" + studentid + "'";
                string sql2 = "update student set sname='" + studentname + "',ssex='" + studentsex + "',sage='" + studentage + "',sexplain='" + miashu + "',classno='" + classid + "' where sno='" + studentid + "'";
                MySqlCommand com2 = execute(sql2, conn);
                com2.ExecuteNonQuery();
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
