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


namespace TabloSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlbaglantisi = new SqlConnection(@"Data Source=DEVRAN-PC\SQLEXPRESS;Initial Catalog=TabloSorgulama;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute TabloSorguProcedur ", sqlbaglantisi);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        // Odev yeni bir satıs işlemini C# formunda yapın (valununmber display nunmber)
        // ama comboboxlarda secilerrk 
    }
}
