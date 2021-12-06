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
    public partial class test : Form
    {
        public static string Myuser, Mypass;
        public test()
        {
            InitializeComponent();
            if (show.Checked)
            {
                MySqlpassword.PasswordChar = '\0';
            }
            else
            {
                MySqlpassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myuser = MySqlUsername.Text;
            Mypass = MySqlpassword.Text;
            register fo = new register();
            fo.Show();
            this.Hide();
        }

        private void link_Click(object sender, EventArgs e)
        {
            MySqlConnection conn1 = new MySqlConnection("Data Source=localhost;Persist Security Info=yes; " +
                                                  "UserId=" + MySqlUsername.Text + ";" + " PWD=" + MySqlpassword.Text);
            conn1.Open();
            MySqlCommand cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS student_mannagement_system;", conn1);
            cmd.ExecuteNonQuery();
            conn1.Close();
            MessageBox.Show("必备环境已安装创建！");
        }

        private void MySqlUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void MySqlpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            {
                MySqlpassword.PasswordChar = '\0';
            }
            else
            {
                MySqlpassword.PasswordChar = '*';
            }
        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
