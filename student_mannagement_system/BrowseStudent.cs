using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static student_mannagement_system.link_db;
using static student_mannagement_system.register;

namespace student_mannagement_system
{
    public partial class BrowseStudent : Form
    {
        public static string x;
        public BrowseStudent()
        {
            InitializeComponent();
            listView1.Items.Clear();
            MySqlConnection conn = Connection();
            string sql = "select * from student";
            MySqlCommand com = execute(sql, conn);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["sno"].ToString();
                lt.SubItems.Add(dr["sname"].ToString());
                lt.SubItems.Add(dr["sage"].ToString());
                lt.SubItems.Add(dr["ssex"].ToString());
                lt.SubItems.Add(dr["classno"].ToString());
                lt.SubItems.Add(dr["sphone"].ToString());
                lt.SubItems.Add(dr["sexplain"].ToString());
                listView1.Items.Add(lt);
            }
            disconnection(conn);
        }

        private void BrowseStudent_Load(object sender, EventArgs e)
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

        private void delete_Click(object sender, EventArgs e)
        {
            if ((listView1.SelectedItems.Count > 0) && (right == "1")) 
            {
                string sql1 = "delete from choose where sno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlConnection conn = Connection();
                MySqlCommand cmdt = new MySqlCommand(sql1, conn);
                cmdt.ExecuteNonQuery();
                string sql = "DELETE FROM student WHERE sno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                string sql2 = "delete from money where sno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            if(right=="1")
            {
                x = listView1.FocusedItem.SubItems[0].Text;
                UpdateStudent stu = new UpdateStudent();
                stu.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string studentid = sno.Text;
            string sql = "select * from student where sno='" + studentid + "'";
            MySqlConnection conn = Connection();
            MySqlCommand com = execute(sql, conn);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["sno"].ToString();
                lt.SubItems.Add(dr["sname"].ToString());
                lt.SubItems.Add(dr["sage"].ToString());
                lt.SubItems.Add(dr["ssex"].ToString());
                lt.SubItems.Add(dr["classno"].ToString());
                lt.SubItems.Add(dr["sphone"].ToString());
                lt.SubItems.Add(dr["sexplain"].ToString());
                listView1.Items.Add(lt);
            }
            disconnection(conn);
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("不存在此学生", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
