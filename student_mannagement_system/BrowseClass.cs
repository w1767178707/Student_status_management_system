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
    public partial class BrowseClass : Form
    {
        public static string a;
        public BrowseClass()
        {
            InitializeComponent();
            listView1.Items.Clear();
            MySqlConnection conn = Connection();
            string sql = "select * from class";
            MySqlCommand com = execute(sql, conn);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["classno"].ToString();
                lt.SubItems.Add(dr["classname"].ToString());
                lt.SubItems.Add(dr["classcount"].ToString());
                lt.SubItems.Add(dr["teacher"].ToString());
                lt.SubItems.Add(dr["mno"].ToString());
                lt.SubItems.Add(dr["classexplain"].ToString());
                listView1.Items.Add(lt);
            }
            disconnection(conn);
        }

        private void search_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string x = classno.Text;
            string sql = "select * from class where classno='" + x + "';";
            MySqlConnection conn = Connection();
            MySqlCommand cmd = execute(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["classno"].ToString();
                lt.SubItems.Add(dr["classname"].ToString());
                lt.SubItems.Add(dr["classcount"].ToString());
                lt.SubItems.Add(dr["teacher"].ToString());
                lt.SubItems.Add(dr["mno"].ToString());
                lt.SubItems.Add(dr["classexplain"].ToString());
                listView1.Items.Add(lt);
            }
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("不存在此班级", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                string sql3 = "DELETE FROM student WHERE  student.classno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand comdt = execute(sql3, conn);
                comdt.ExecuteNonQuery();
                string sql = "DELETE FROM class WHERE classno='" +  listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand cmd = execute(sql, conn);
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
                a = listView1.FocusedItem.SubItems[0].Text;
                updateClass stu = new updateClass();
                stu.Show();
                this.Hide();
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BrowseClass_Load(object sender, EventArgs e)
        {

        }
    }
}
