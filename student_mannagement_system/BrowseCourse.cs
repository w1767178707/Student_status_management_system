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
using static student_mannagement_system.register;


namespace student_mannagement_system
{
    public partial class BrowseCourse : Form
    {
        public static string t1, t2, t3, t4;
        public BrowseCourse()
        {
            InitializeComponent();
            listView1.Items.Clear();
            MySqlConnection conn = Connection();
            string sql = "select * from course";
            MySqlCommand com = execute(sql, conn);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["cno"].ToString();
                lt.SubItems.Add(dr["ccredit"].ToString());
                lt.SubItems.Add(dr["cname"].ToString());
                lt.SubItems.Add(dr["cexplain"].ToString());
                listView1.Items.Add(lt);
            }
            disconnection(conn);
        }

        private void BrowseCourse_Load(object sender, EventArgs e)
        {

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

        private void modify_Click(object sender, EventArgs e)
        {
            if ((listView1.SelectedItems.Count > 0) && (right == "1")) 
            {
                string sql2 = "select * from Course where cno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlConnection conn = Connection();
                MySqlCommand cmdd = execute(sql2, conn);
                MySqlDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    t1 = (string)reader[0];
                    t2 = (string)reader[1];
                    t3 = (string)reader[2];
                    t4 = (string)reader[3];
                }
                reader.Close();
                UpdateCourse stu = new UpdateCourse();
                stu.Show(this);
                
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if ((listView1.SelectedItems.Count > 0) && (right == "1")) 
            {
                MySqlConnection conn = Connection();
                string sql1 = "delete from choose where cno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand comt = execute(sql1, conn);
                comt.ExecuteNonQuery();
                string sql = "DELETE FROM Course WHERE cno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand cmd = execute(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
