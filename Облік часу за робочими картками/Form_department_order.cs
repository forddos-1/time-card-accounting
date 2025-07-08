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
    public partial class Form_department_order : Form
    {
        public Form_department_order()
        {
            InitializeComponent();
        }

        private void Form_department_order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Department);

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            var conn = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select [dbo].[Оrder_].name_order as 'Замовлення', [dbo].[Оrder_].quantity_order as 'Кількість' from [dbo].[Оrder_] inner join Worker_order on [dbo].[Оrder_].id_order = Worker_order.id_order inner join Worker on Worker_order.id_worker = Worker.id_worker inner join Department on Worker.id_departament = Department.id_department where (Department.name_department = '" + name + "')", conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
