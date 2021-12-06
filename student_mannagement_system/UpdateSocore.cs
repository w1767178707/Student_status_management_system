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
using static student_mannagement_system.BrowseScore;

namespace student_mannagement_system
{
    public partial class UpdateSocore : Form
    {
        public UpdateSocore()
        {
            InitializeComponent();
            sno.Text = snoo;
            cno.Text = cnoo;
        }

        private void back_Click(object sender, EventArgs e)
        {
            BrowseScore browseScore = new BrowseScore();
            browseScore.Show();
            this.Hide();
        }

        private void config_Click(object sender, EventArgs e)
        {
           
            MySqlConnection conn = Connection();
            string sql = "update choose set grade='" + grade.Text + "' where sno='" + snoo + "' and cno='" + cnoo + "'";
            MySqlCommand cmd = execute(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("修改成功！");
        }

        private void UpdateSocore_Load(object sender, EventArgs e)
        {

        }
    }
}
