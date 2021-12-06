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
using static student_mannagement_system.register;

namespace student_mannagement_system
{
    public partial class win_browser_major : Form
    {
        static public string zybh;
        public win_browser_major()
        {
            InitializeComponent();
            listView1.Items.Clear();
            MySqlConnection conn = Connection();
            string sql = "select * from major";
            MySqlCommand com = execute(sql, conn);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["mno"].ToString();
                lt.SubItems.Add(dr["mname"].ToString());
                lt.SubItems.Add(dr["mexplain"].ToString());
                listView1.Items.Add(lt);
            }
        }

        private void win_browser_major_Load(object sender, EventArgs e)
        {

        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (right == "1")
            {
                zybh = listView1.FocusedItem.SubItems[0].Text;
                modifier mo = new modifier();
                this.Hide();
                mo.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            if ((listView1.SelectedItems.Count > 0) && (right == "1")) 
            {
                string sql12 = "delete from choose where sno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand cmdt = new MySqlCommand(sql12, conn);
                cmdt.ExecuteNonQuery();
                string sql3 = "DELETE student FROM Student,Class WHERE  Student.classno=Class.classno AND Class.mno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand comdt = execute(sql3, conn);
                comdt.ExecuteNonQuery();
                string sql1 = "DELETE FROM Class WHERE class.mno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand comd = execute(sql1, conn);
                comd.ExecuteNonQuery();
                string sql = "DELETE FROM major WHERE mno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand cmd = execute(sql, conn);
                cmd.ExecuteNonQuery();
                string sql2 = "delete from money where sno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                win_browser_major b = new win_browser_major();
                b.Show();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in listView1.Items)
            {

                if (lv.Selected)
                {

                    lv.Checked = true;

                }
                else
                {
                    if (listView1.SelectedIndices.Count > 0)
                    {
                        if (lv.Checked)
                        {
                            lv.Checked = false;
                        }
                    }

                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ww = new Menu();
            ww.Show();
        }
    }
}
