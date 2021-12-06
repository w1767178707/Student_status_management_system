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
    public partial class Browsemoney : Form
    {
        public static string t1, t2, t3;
        public static string snooo;
        public Browsemoney()
        {
            InitializeComponent();
        }

        private void Browsemoney_Load(object sender, EventArgs e)
        {
            string sql = "select * from view1";
            MySqlConnection conn = Connection();
            MySqlCommand cmd = execute(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ListViewItem lt = new ListViewItem();
                lt.Text = dr["sno"].ToString();
                lt.SubItems.Add(dr["sname"].ToString());
                lt.SubItems.Add(dr["needmoney"].ToString());
                lt.SubItems.Add(dr["moneyexplain"].ToString());
                listView1.Items.Add(lt);
            }
            dr.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if ((listView1.SelectedItems.Count > 0) && (right == "1"))
            {
                MySqlConnection conn = Connection();
                string sql1 = "delete from money where sno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlCommand comt = execute(sql1, conn);
                comt.ExecuteNonQuery();
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
            this.Close();
        }

        private void modified_Click(object sender, EventArgs e)
        {
            if ((listView1.SelectedItems.Count > 0) && (right == "1"))
            {
                string sql2 = "select * from money where sno='" + listView1.FocusedItem.SubItems[0].Text + "'";
                MySqlConnection conn = Connection();
                MySqlCommand cmdd = execute(sql2, conn);
                MySqlDataReader reader = cmdd.ExecuteReader();
                while (reader.Read())
                {
                    t1 = (string)reader[0];
                    t2 = (string)reader[1];
                    t3 = (string)reader[2];
                }
                reader.Close();
                updatemoney stu = new updatemoney();
                stu.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem lv in listView1.Items)
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
    }
}
