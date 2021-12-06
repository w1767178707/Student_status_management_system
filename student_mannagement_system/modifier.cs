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
using static student_mannagement_system.win_browser_major;

namespace student_mannagement_system
{
    public partial class modifier : Form
    {
        public modifier()
        {
            InitializeComponent();
            label2.Text = zybh;
        }

        private void modifier_Load(object sender, EventArgs e)
        {

        }

        private void confi_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            string newt2 = mo_mname.Text;
            string newt3 = mo_describe.Text;
            string sql = "UPDATE major SET  mname = '" + newt2 + "', mexplain = '" + newt3 + "' WHERE mno = '" + label2.Text + "'";
            MySqlCommand com = execute(sql, conn);
            com.ExecuteNonQuery();
            MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            win_browser_major ww = new win_browser_major();
            ww.Show();
        }

        private void button_canc_Click(object sender, EventArgs e)
        {
            this.Hide();
            win_browser_major ww = new win_browser_major();
            ww.Show();
        }
    }
}
