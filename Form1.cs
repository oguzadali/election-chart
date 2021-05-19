using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace election_chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection eldb = new SqlConnection("Data Source=.;Initial Catalog=electiondb;Integrated Security=True");



        private void buttonEnterVote_Click(object sender, EventArgs e)
        {
            eldb.Open();
            SqlCommand commandSave = new SqlCommand("insert into Table_State_Votes (STATE,XPARTY,YPARTY,TPARTY,APARTY,CPARTY,INVALID) values(@S1,@P1,@P2,@P3,@P4,@P5,@PI)", eldb);
            commandSave.Parameters.AddWithValue("@S1", textBoxState.Text);
            commandSave.Parameters.AddWithValue("@P1", textBoxXP.Text);
            commandSave.Parameters.AddWithValue("@P2", textBoxYP.Text);
            commandSave.Parameters.AddWithValue("@P3", textBoxTP.Text);
            commandSave.Parameters.AddWithValue("@P4", textBoxAP.Text);
            commandSave.Parameters.AddWithValue("@P5", textBoxCP.Text);
            commandSave.Parameters.AddWithValue("@PI", textBoxInvalidVote.Text);
            commandSave.ExecuteNonQuery();

            MessageBox.Show("Vote data saved succesfully");

            eldb.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxState.Clear();
            textBoxXP.Clear();
            textBoxYP.Clear();
            textBoxTP.Clear();
            textBoxAP.Clear();
            textBoxCP.Clear();
            textBoxInvalidVote.Clear();

        }

        private void buttonCharts_Click(object sender, EventArgs e)
        {
            FormCharts frm = new FormCharts();
            frm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {                     
            this.Close();
        }

       
    }
}
