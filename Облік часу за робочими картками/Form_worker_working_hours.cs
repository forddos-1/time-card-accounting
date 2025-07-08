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
    public partial class Form_worker_working_hours : Form
    {
        public Form_worker_working_hours()
        {
            InitializeComponent();
        }

        private void Form_worker_working_hours_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.entry_cards_KRBDDataSet.Worker);

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.GetItemText(comboBox1.SelectedItem);
            var conn = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
            conn.Open();

            SqlDataAdapter sda2 = new SqlDataAdapter("select Working_hours.card_number as 'Номер картки', Working_hours.id_worker as 'id_робітника' from Working_hours inner join Worker on Working_hours.id_worker = Worker.id_worker where (Worker.name_worker = '" + name + "')", conn);
            SqlCommandBuilder scb2 = new SqlCommandBuilder(sda2);

            DataSet ds2 = new DataSet();
            sda2.Fill(ds2);

            dataGridView1.DataSource = ds2.Tables[0];

            SqlDataAdapter sda = new SqlDataAdapter("select Working_hours.recording_date as 'Дата прибуття', Working_hours.recording_time as 'Час прибуття' from Working_hours inner join Worker on Working_hours.id_worker = Worker.id_worker where (Worker.name_worker = '" + name + "')", conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            
            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];

            SqlDataAdapter sda1 = new SqlDataAdapter("select Working_hours.exit_date as 'Дата завершення', Working_hours.exit_time as 'Час завершення' from Working_hours inner join Worker on Working_hours.id_worker = Worker.id_worker where (Worker.name_worker = '" + name + "')", conn);
            SqlCommandBuilder scb1 = new SqlCommandBuilder(sda1);

            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            dataGridView3.DataSource = ds1.Tables[0];
        }
    }
}
