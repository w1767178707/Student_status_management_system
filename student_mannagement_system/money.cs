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
    public partial class Addmoney : Form
    {
        public Addmoney()
        {
            InitializeComponent();
        }

        private void sno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addmoney_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            MySqlCommand st = new MySqlCommand("select sno from student", conn);
            MySqlDataReader reader1 = st.ExecuteReader();
            sno.Items.Clear();
            while (reader1.Read())
            {
                sno.Items.Add((string)reader1[0]);
            }
            reader1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            if (sno.Text == "")
            {
                MessageBox.Show("学号不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (needmoney.Text == "")
            {
                MessageBox.Show("欠款金额不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string snoo = sno.Text;
                string needmoney1 = needmoney.Text;
                string moneyexplain1 = moneyexplain.Text;
                MySqlCommand comm = new MySqlCommand();
                string sql2 = "insert into money set sno='" + snoo + "',needmoney='" + needmoney1 + "',moneyexplain='" + moneyexplain1 + "'";
                MySqlCommand com2 = new MySqlCommand(sql2, conn);
                com2.ExecuteNonQuery();
                MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                disconnection(conn);
                
            }
        }
    }
}
