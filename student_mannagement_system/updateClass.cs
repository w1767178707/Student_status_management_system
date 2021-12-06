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
using static student_mannagement_system.BrowseClass;

namespace student_mannagement_system
{
    public partial class updateClass : Form
    {
        public updateClass()
        {
            InitializeComponent();
            MySqlConnection conn = Connection();
            MySqlCommand st = execute("select mname from major", conn);
            MySqlDataReader reader1 = st.ExecuteReader();
            major.Items.Clear();
            while (reader1.Read())
            {
                major.Items.Add((string)reader1[0]);
            }
            reader1.Close();
            label7.Text = a;
        }

        private void config_Click(object sender, EventArgs e)
        {
            string banjiId = label7.Text;
            string banjiName = classname.Text;
            string banzhur = teacher.Text;
            string renshu = classcount.Text;
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
            MySqlCommand comt = execute(sql, conn);
            MySqlDataReader reader = comt.ExecuteReader();
            while (reader.Read())
            {
                zhuanyeId = (string)reader[0];
            }
            reader.Close();
            string shuoming = classexplain.Text;
            string sql2 = "update class set classname='" + banjiName + "',classcount='" + renshu + "',teacher='" + banzhur + "',classexplain='" + shuoming + "',mno='" + zhuanyeId + "' where classno='" + banjiId + "'";
            MySqlCommand com2 = execute(sql2, conn);
            com2.ExecuteNonQuery();
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateClass_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
