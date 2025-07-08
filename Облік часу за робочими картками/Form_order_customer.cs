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
    public partial class Form_order_customer : Form
    {
        public Form_order_customer()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string wd = listBox1.GetItemText(listBox1.SelectedItem);
            var conn = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
            conn.Open();
           
            SqlDataAdapter sda = new SqlDataAdapter("select Customer.name_customer as 'Ім*я', Customer.surname_customer as 'Прізвище', Customer.patronymic_customer as 'По-батькові' from Customer inner join [dbo].[Оrder_] on Customer.id_order = [dbo].[Оrder_].id_order where ([dbo].[Оrder_].name_order = '" + wd + "')", conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
            SqlDataAdapter sda1 = new SqlDataAdapter("select Worker.name_worker as 'Ім*я', Worker.surname_worker as 'Призвище', Worker.patronymic_worker as 'По-батькові',	Worker.card_number as 'Номер картки' from Worker inner join Worker_order on Worker.id_worker = Worker_order.id_worker inner join [dbo].[Оrder_] on Worker_order.id_order = [dbo].[Оrder_].id_order where ([dbo].[Оrder_].name_order =  '" + wd + "')", conn);
            SqlCommandBuilder scb1 = new SqlCommandBuilder(sda1);

            DataSet ds1 = new DataSet();
            sda1.Fill(ds1);

            dataGridView2.DataSource = ds1.Tables[0];

            SqlDataAdapter sda2 = new SqlDataAdapter("select Equipment.name_equipment from Equipment inner join Worker_order on Equipment.id_equipment = Worker_order.id_equipment inner join [dbo].[Оrder_] on Worker_order.id_order = [dbo].[Оrder_].id_order where ([dbo].[Оrder_].name_order = '" + wd + "')", conn);
            SqlCommandBuilder scb2 = new SqlCommandBuilder(sda2);

            DataSet ds2 = new DataSet();
            sda2.Fill(ds2);

            dataGridView3.DataSource = ds2.Tables[0];
        }

        private void Form_order_customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Оrder_". При необходимости она может быть перемещена или удалена.
            this.оrder_TableAdapter.Fill(this.entry_cards_KRBDDataSet.Оrder_);

        }
    }
}
