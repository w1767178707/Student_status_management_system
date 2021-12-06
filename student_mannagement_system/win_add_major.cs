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
    public partial class win_add_major : Form
    {
        public win_add_major()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            if(textBox_mno.Text=="")
            {
                MessageBox.Show("专业编号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(textBox_mname.Text=="")
            {
                MessageBox.Show("专业名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string mno = textBox_mno.Text;
                string mname = textBox_mname.Text;
                string describe = textBox_describe.Text;
                string sql1 = "select * from major where mno='" + mno + "' and mname='" + mname + "' and mexplain='" + describe + "';";
                string sql2 = "insert into major values('" + mno + "','" + mname + "','" + describe + "');";
                MySqlCommand com1 = execute(sql1, conn);
                if (Convert.ToInt32(com1.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("此专业已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MySqlCommand com2 = execute(sql2, conn);
                    com2.ExecuteNonQuery();
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    disconnection(conn);
                    this.Hide();
                    Menu win1 = new Menu();
                    win1.Show();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu me = new Menu();
            me.Show();
        }

        private void win_add_major_Load(object sender, EventArgs e)
        {

        }
    }
}
