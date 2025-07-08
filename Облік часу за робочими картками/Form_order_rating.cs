using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Облік_часу_за_робочими_картками
{
    public partial class Form_order_rating : Form
    {
        public Form_order_rating()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select name_order, (select count(*) from Customer where Customer.id_order = [dbo].[Оrder_].id_order) as 'kil' from [dbo].[Оrder_]", conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
