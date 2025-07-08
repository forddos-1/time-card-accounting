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
    public partial class Form_card : Form
    {
        public Form_card()
        {
            InitializeComponent();
        }

        private void Form_card_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Department);

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.GetItemText(comboBox1.SelectedItem);
            var conn = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Worker.name_worker as 'Ім*я', Worker.surname_worker as 'Прізвище', Worker.patronymic_worker as 'По-батькові', Worker.card_number as 'Номер картки' from Worker inner join Department on Worker.id_departament = Department.id_department where (Department.name_department = '" + name + "')", conn);
            SqlCommandBuilder cb = new SqlCommandBuilder(sda);

            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
