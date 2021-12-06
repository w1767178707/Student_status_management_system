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
using System.Configuration;
using static student_mannagement_system.register;

namespace student_mannagement_system
{
    public partial class BrowseScore : Form
    {
        public static string snoo, cnoo;
        public BrowseScore()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string studentid = sno.Text;
            string sql = "SELECT course.cno,student.sno,sname,cname,grade FROM choose,student,course WHERE choose.cno=course.cno AND choose.sno=student.sno AND student.sno='" + studentid + "'";
            listView1.Items.Clear();
            MySqlConnection conn = Connection();
            MySqlCommand com = execute(sql, conn);
            int x = com.ExecuteNonQuery();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["cno"].ToString();
                lt.SubItems.Add(dr["sno"].ToString());
                lt.SubItems.Add(dr["sname"].ToString());
                lt.SubItems.Add(dr["cname"].ToString());
                lt.SubItems.Add(dr["grade"].ToString());
                listView1.Items.Add(lt);
            }
            disconnection(conn);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Connection();
            if ((listView1.SelectedItems.Count > 0) && (right == "1")) 
            {
                string sql = "delete FROM choose WHERE choose.cno='" + listView1.FocusedItem.SubItems[0].Text + "' AND choose.sno='" + listView1.FocusedItem.SubItems[1].Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BrowseScore_Load(object sender, EventArgs e)
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
                snoo = listView1.FocusedItem.SubItems[1].Text;
                cnoo = listView1.FocusedItem.SubItems[0].Text;
                UpdateSocore stu = new UpdateSocore();
                stu.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
