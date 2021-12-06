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
    public partial class sign : Form
    {
        public sign()
        {
            InitializeComponent();
            if (this.show.Checked) 
            {
                stextBox_password.PasswordChar = '\0';
                stextBox_againpassword.PasswordChar = '\0';
            }
            else
            {
                stextBox_password.PasswordChar = '*';
                stextBox_againpassword.PasswordChar = '*';
            }
        }

        private void reg_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = Connection();
            if (stextBox_username.Text == "")
            {
                MessageBox.Show("用户名不能为空", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (stextBox_password.Text == "")
            {
                MessageBox.Show("密码不能为空", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (stextBox_againpassword.Text == "")
            {
                MessageBox.Show("请再次输入密码", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (stextBox_password.Text != stextBox_againpassword.Text)
            {
                MessageBox.Show("两次密码输入不一致", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string username = stextBox_username.Text;
                string password = stextBox_password.Text;
                string sql = "insert into users values('" + username + "','" + password + "',0)";
                MySqlCommand com = execute(sql, conn);
                com.ExecuteNonQuery();
                MessageBox.Show("注册成功", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                register stu = new register();
                stu.Show();
                disconnection(conn);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            register stu = new register();
            stu.Show();
        }

        private void sign_Load(object sender, EventArgs e)
        {

        }

        private void stextBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void stextBox_againpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void stextBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<char> keyCode = new List<char>
           {
               'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0','.',',','!','@',(char)8};
            if (!keyCode.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stextBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<char> keyCode = new List<char>
           {
               'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0','.',',','!','@',(char)8};
            if (!keyCode.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void stextBox_againpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<char> keyCode = new List<char>
           {
               'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0','.',',','!','@',(char)8};
            if (!keyCode.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (this.show.Checked)
            {
                stextBox_password.PasswordChar = '\0';
                stextBox_againpassword.PasswordChar = '\0';
            }
            else
            {
                stextBox_password.PasswordChar = '*';
                stextBox_againpassword.PasswordChar = '*';
            }
        }
    }
}
