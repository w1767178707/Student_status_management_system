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
using System.Configuration;
using static student_mannagement_system.link_db;

namespace student_mannagement_system
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (classno.Text == "")
            {
                MessageBox.Show("班级编号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (classname.Text == "")
            {
                MessageBox.Show("班级名称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string banjiId = classno.Text;
                string banjiName = classname.Text;
                string banzhur = teacher.Text;
                string renshu = count.Text;
                string zhuanye = "";
                if (major.SelectedIndex != -1)
                {
                    zhuanye = major.SelectedItem.ToString();
                }
                else
                {
                    major.SelectedIndex = 0;
                }
                string zhuanyeId = "";
                string sql = "select mno from major where mname='" + zhuanye + "'";
                MySqlConnection conn = Connection();
                MySqlCommand comt = new MySqlCommand(sql, conn);
                MySqlDataReader reader = comt.ExecuteReader();
                while (reader.Read())
                {
                    zhuanyeId = (string)reader[0];
                }
                reader.Close();
                MySqlCommand comm = new MySqlCommand();
                string shuoming = explain.Text;
                string sql1 = "select count(*) from class where classno='" + banjiId + "'";
                MySqlCommand com = new MySqlCommand(sql1, conn);
                if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("此班级已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string sql2 = "insert into class set classno='" + banjiId + "',className='" + banjiName + "',classcount='" + renshu + "',teacher='" + banzhur + "',classexplain='" + shuoming + "',mno='" + zhuanyeId + "'";
                    MySqlCommand com2 = new MySqlCommand(sql2, conn);
                    com2.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    disconnection(conn);
                }
            }
        }

        private void ac_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            MySqlCommand st = new MySqlCommand("select mname from major", conn);
            MySqlDataReader reader1 = st.ExecuteReader();
            major.Items.Clear();
            while (reader1.Read())
            {
                major.Items.Add((string)reader1[0]);
            }
            reader1.Close();
        }

        private void explain_TextChanged(object sender, EventArgs e)
        {

        }

        private void major_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
