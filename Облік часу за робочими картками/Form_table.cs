using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Облік_часу_за_робочими_картками
{
    public partial class Form_table : Form
    {
        public Form_table()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_department FD = new Form_department();
            FD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_equipment FQ = new Form_equipment();
            FQ.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_worker FW = new Form_worker();
            FW.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_working_house FWH = new Form_working_house();
            FWH.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_order FO = new Form_order();
            FO.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_customer FC = new Form_customer();
            FC.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_worker_order FWO = new Form_worker_order();
            FWO.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Form_user_cards FUC = new Form_user_cards();
            //FUC.Show();
        }
    }
}
