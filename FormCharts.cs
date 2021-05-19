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
    public partial class FormCharts : Form
    {
        public FormCharts()
        {
            InitializeComponent();
        }

        SqlConnection eldb = new SqlConnection("Data Source=.;Initial Catalog=electiondb;Integrated Security=True");

        private void FormCharts_Load(object sender, EventArgs e)
        {            
            eldb.Open();
            SqlCommand getData = new SqlCommand("select state from Table_State_Votes ", eldb);
            SqlDataReader rd = getData.ExecuteReader();
            while (rd.Read())
            {
                comboBoxSelectState.Items.Add(rd[0]);
            }

            eldb.Close();

            eldb.Open();

            SqlCommand getVoteData = new SqlCommand("select SUM(XPARTY),SUM(YPARTY),SUM(TPARTY),SUM(APARTY),SUM(CPARTY),SUM(INVALID) from Table_State_Votes", eldb);
            SqlDataReader rd2 = getVoteData.ExecuteReader();
            while (rd2.Read())
            {
                chartVote.Series["Partys"].Points.AddXY("X PARTY", rd2[0]);
                chartVote.Series["Partys"].Points.AddXY("Y PARTY", rd2[1]);
                chartVote.Series["Partys"].Points.AddXY("T PARTY", rd2[2]);
                chartVote.Series["Partys"].Points.AddXY("A PARTY", rd2[3]);
                chartVote.Series["Partys"].Points.AddXY("C PARTY", rd2[4]);
                chartVote.Series["Partys"].Points.AddXY("INVALID VOTES", rd2[5]);
            }
            eldb.Close();

        }

        private void comboBoxSelectState_SelectedIndexChanged(object sender, EventArgs e)
        {
            eldb.Open();
            SqlCommand getDataForBar = new SqlCommand("select * from Table_State_Votes where state=@S1", eldb);
            getDataForBar.Parameters.AddWithValue("@S1", comboBoxSelectState.Text);
            SqlDataReader rd = getDataForBar.ExecuteReader();

            while (rd.Read())
            {               

                progressBarXP.Maximum = 1000;

                progressBarXP.Value = int.Parse(rd[2].ToString());
                progressBarYP.Value = int.Parse(rd[3].ToString());
                progressBarAP.Value = int.Parse(rd[4].ToString());
                progressBarTP.Value = int.Parse(rd[5].ToString());
                progressBarCP.Value = int.Parse(rd[6].ToString());
                progressBarInvalid.Value = int.Parse(rd[7].ToString());

                labelXP.Text = rd[2].ToString();
                labelYP.Text = rd[3].ToString();
                labelAP.Text = rd[4].ToString();
                labelTP.Text = rd[5].ToString();
                labelCP.Text = rd[6].ToString();
                labelInvalid.Text = rd[7].ToString();

            }

            eldb.Close();

        }
    }
}
