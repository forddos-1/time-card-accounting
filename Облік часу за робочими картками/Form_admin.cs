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
    public partial class Form_admin : Form
    {
        public string time_start;
        public string date_start;
        public string time_stop;
        public string date_stop;
        public string number_cards;//

        public Form_admin(string cards)
        {
            InitializeComponent();
            time_start = DateTime.Now.ToLongTimeString();
            date_start = DateTime.Now.ToShortDateString();
            number_cards = cards;

        }

        private void Form_admin_Load(object sender, EventArgs e)
        {
            ////this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_admin_department FAD = new Form_admin_department();
            FAD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_admin_equipment FAE = new Form_admin_equipment();
            FAE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_admin_order FAO = new Form_admin_order();
            FAO.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_admin_customer FAC = new Form_admin_customer();
            FAC.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_admin_working_hours FAWH = new Form_admin_working_hours();
            FAWH.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_admin_worker_order FAWO = new Form_admin_worker_order();
            FAWO.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_admin_worker FAW = new Form_admin_worker();
            FAW.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_table FT = new Form_table();
            FT.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_worker_working_hours FWWH = new Form_worker_working_hours();
            FWWH.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_order_customer FOC = new Form_order_customer();
            FOC.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form_worker_department FWD1 = new Form_worker_department();
            FWD1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_card FC = new Form_card();
            FC.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form_department_order FDO = new Form_department_order();
            FDO.Show();
        }

        private void button14_Click(object sender, EventArgs e)
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

        private void button15_Click(object sender, EventArgs e)
        {
            // свернуть
            this.WindowState = FormWindowState.Minimized;
            // Развернуть
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form_worker_month wm = new Form_worker_month();
            wm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form_order_rating FOR = new Form_order_rating();
            FOR.Show();
        }

    }
}
