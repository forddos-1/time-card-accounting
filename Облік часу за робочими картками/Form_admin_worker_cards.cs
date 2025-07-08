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
    public partial class Form_admin_worker_cards : Form
    {
        public string cart;
        public Form_admin_worker_cards(string cards)
        {
            InitializeComponent();
            label1.Text = cards;
            cart = cards;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox1.Text == textBox2.Text && comboBox1.Text != "")
            {
                string name = comboBox1.GetItemText(comboBox1.SelectedItem);
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("insert into users values('" + cart + "','" + textBox1.Text + "','" + comboBox1.Text + "')", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Користувача внесено до списку");
                this.Close();
            }
            else MessageBox.Show("Не вірно введений пароль!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
