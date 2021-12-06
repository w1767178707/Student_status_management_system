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
    public partial class register : Form
    {
        public static string un;
        public static string right;
        public register()
        {
            InitializeComponent();
            if (show.Checked)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
            MySqlConnection conn = Connection();
            string sql2 = "CREATE TABLE IF NOT EXISTS major( mno varchar(10) NOT NULL PRIMARY KEY,mname varchar(10),mexplain varchar(100))";
            string sql3 = "CREATE TABLE IF NOT EXISTS course(cno varchar(10) NOT NULL PRIMARY KEY,ccredit varchar(10),cname varchar(10),cexplain varchar(100))";
            string sql4 = "CREATE TABLE IF NOT EXISTS users(username varchar(20) primary key,password varchar(20),userright smallint)";
            string sql5 = "CREATE TABLE IF NOT EXISTS class(classno varchar(10)  NOT NULL PRIMARY KEY, classname varchar(10),classcount varchar(10),classexplain varchar(100),teacher varchar(10),mno varchar(10),FOREIGN KEY(mno) REFERENCES major(mno))";
            string sql6 = "CREATE TABLE IF NOT EXISTS student( sno varchar(10) NOT NULL PRIMARY KEY,sname varchar(10), ssex varchar(10),sage varchar(10),sexplain varchar(100),classno varchar(10),FOREIGN KEY(classno) REFERENCES class(classno))";
            string sql7 = "CREATE TABLE IF NOT EXISTS choose( cno varchar(10) not null,sno varchar(10) not null,grade varchar(10),PRIMARY KEY(cno, sno),FOREIGN KEY(cno) REFERENCES course(cno),FOREIGN KEY(sno) REFERENCES student(sno))";
            string sql9 = "CREATE TABLE IF NOT EXISTS money(sno varchar(10) not null,  needmoney varchar(10), PRIMARY KEY(sno),FOREIGN KEY(sno) REFERENCES student(sno))";
            string sql8 = "INSERT IGNORE INTO users VALUES('admin','admin',1);";
            MySqlCommand com1 = execute(sql2, conn);
            com1.ExecuteNonQuery();
            MySqlCommand com2 = execute(sql3, conn);
            com2.ExecuteNonQuery();
            MySqlCommand com3 = execute(sql4, conn);
            com3.ExecuteNonQuery();
            MySqlCommand com4 = execute(sql5, conn);
            com4.ExecuteNonQuery();
            MySqlCommand com5 = execute(sql6, conn);
            com5.ExecuteNonQuery();
            MySqlCommand com6 = execute(sql7, conn);
            com6.ExecuteNonQuery();
            MySqlCommand com7 = execute(sql8, conn);
            com7.ExecuteNonQuery();
            MySqlCommand com8 = execute(sql9, conn);
            disconnection(conn);
        }

        

        private void button_login_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            if (username.Text == "")
            {
                MessageBox.Show("用户名不能为空", "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (password.Text == "")
            {
                MessageBox.Show("密码不能为空", "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string username = textBox_username.Text;
                string password = textBox_password.Text;
                string sql = "SELECT COUNT(*) FROM users WHERE username='" + username + "' AND password = '" + password + "'; ";
                MySqlCommand com = execute(sql, conn);
                if (Convert.ToInt32(com.ExecuteScalar()) == 0)
                {
                    MessageBox.Show("用户名或者密码错误，请重新输入", "用户登录", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MySqlConnection mySqlConnection = Connection();
                    string sqlx = "select userright from users where username='" + username + "' AND password = '" + password + "'; ";
                    MySqlCommand comx = execute(sqlx, mySqlConnection);
                    MySqlDataReader dr = comx.ExecuteReader();
                    dr.Read();
                    right = dr["userright"].ToString();
                    un = textBox_username.Text;
                    Menu stu = new Menu();
                    stu.Show();
                    this.Hide();
                    disconnection(conn);
                }
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            sign si = new sign();
            this.Hide();
            si.Show();
        }

        private void register_Load(object sender, EventArgs e)
        {
            
        }

        private void link_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            if (show.Checked)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<char> keyCode = new List<char>
           {
               'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0','.',',','!','@',(char)8};
            if (!keyCode.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<char> keyCode = new List<char>
           {
               'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0','.',',','!','@',(char)8};
            if (!keyCode.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
