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

namespace Contacts_App_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConStr = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Contacts.mdf\;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConStr);
            con.Open();
            string query = "Select * From People";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable DT= new DataTable();
            da.Fill(DT);
            DGV.DataSource = DT;
        }
    }
}
