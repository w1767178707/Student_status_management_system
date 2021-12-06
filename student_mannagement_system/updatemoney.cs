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

namespace student_mannagement_system
{
    public partial class updatemoney : Form
    {
        public updatemoney()
        {
            InitializeComponent();
            cno.Text = Browsemoney.t1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string courseid = cno.Text;
            string credit = ccredit.Text;
            string shuoming = cexplain.Text;
            MySqlConnection conn = Connection();
            string sql2 = "update money set needmoney='" + credit + "',moneyexplain='" + shuoming + "' where sno ='" + cno.Text + "'";
            MySqlCommand com2 = execute(sql2, conn);
            com2.ExecuteNonQuery();
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updatemoney_Load(object sender, EventArgs e)
        {

        }
    }
}
