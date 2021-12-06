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


namespace student_mannagement_system
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
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

        private void add_Click(object sender, EventArgs e)
        {
            if (sno.Text == "")
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
                MySqlConnection conn = Connection();
                string classid = "";
                string sql = "select classno from Class where classname='" + banji + "'";
                MySqlCommand comt = new MySqlCommand(sql, conn);
                MySqlDataReader reader = comt.ExecuteReader();
                while (reader.Read())
                {
                    classid = (string)reader[0];
                }
                reader.Close();
                string miashu = sexplain.Text;
                string studentid = sno.Text;
                string studentname = sname.Text;
                string studentsex = ssex.SelectedItem.ToString();
                string sql1 = "select count(*) from student where sno='" + studentid + "'";
                MySqlCommand com = execute(sql1, conn);
                if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("此学生已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string sql2 = "insert into student set sno='" + studentid + "',sname='" + studentname + "',ssex='" + studentsex + "',sage='" + studentage + "',sexplain='" + miashu + "',classno='" + classid + "',sphone='" + sphone.Text + "',slocal='" + sloc.Text + "'";
                    MySqlCommand com2 = execute(sql2, conn);
                    com2.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                }
            }
        }
    }
}
