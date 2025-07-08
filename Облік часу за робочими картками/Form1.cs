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
    public partial class Form1 : Form
    {
        public string time_start;
        public string date_start;
        public string time_stop;
        public string date_stop;
        public string number_cards;

        public Form1(string cards)
        {
            InitializeComponent();
            time_start = DateTime.Now.ToLongTimeString();
            date_start = DateTime.Now.ToShortDateString();
            number_cards = cards;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_table FT = new Form_table();
            FT.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_order_rating FOR = new Form_order_rating();
            FOR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_worker_department FWD1 = new Form_worker_department();
            FWD1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_order_customer FOC = new Form_order_customer();
            FOC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_worker_working_hours FWWH = new Form_worker_working_hours();
            FWWH.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_card FC = new Form_card();
            FC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_department_order FDO = new Form_department_order();
            FDO.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_author FA = new Form_author();
            FA.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_worker_month wm = new Form_worker_month();
            wm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // свернуть
            this.WindowState = FormWindowState.Minimized;
            // Развернуть
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Бажаете закрити программу???", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) //Если нажал нет
            {

            }

            if (result == DialogResult.Yes) //Если нажал Да
            {
                time_stop = DateTime.Now.ToLongTimeString();
                date_stop = DateTime.Now.ToShortDateString();

                var conn = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
                conn.Open();

                SqlDataAdapter sda1 = new SqlDataAdapter("select Working_hours.id_worker from Working_hours inner join Worker on Working_hours.card_number = Worker.card_number where (Working_hours.card_number = '" + number_cards + "')", conn);

                SqlCommandBuilder scb1 = new SqlCommandBuilder(sda1);

                DataTable ds1 = new DataTable();
                sda1.Fill(ds1);

                int id = Convert.ToInt32(ds1.Rows[0][0].ToString());

                SqlDataAdapter sda = new SqlDataAdapter("insert into Working_hours values('" + id + "','" + number_cards + "','" + time_start + "','" + date_start + "','" + time_stop + "','" + date_stop + "')", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                Application.Exit();
            }
        }

    }
}
