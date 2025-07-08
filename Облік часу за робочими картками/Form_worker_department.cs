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
    public partial class Form_worker_department : Form
    {
        public Form_worker_department()
        {
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string wd = listBox1.GetItemText(listBox1.SelectedItem);
            var conn = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
            conn.Open();
       
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Worker.name_worker as 'Ім*я', Worker.surname_worker as 'Прізвище', Worker.patronymic_worker as 'По-батькові', Worker.phone_worker as 'Телефон',Worker.card_number as 'номер картки' FROM Worker INNER JOIN Department ON Worker.id_departament = Department.id_department WHERE (Department.name_department = '"+wd+"')", conn);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);

            DataSet ds = new DataSet();
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Form_worker_department_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Department);

        }
    }
}
