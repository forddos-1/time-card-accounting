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
    public partial class Form_user_cards : Form
    {
        public int cod = 0;

        public Form_user_cards()
        {
            InitializeComponent();
        }

        private void Form_user_cards_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OCU0RDE;Initial Catalog=entry_cards_KRBD;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*),owner_user from users where login_user='" + textBox1.Text + "' and pass_user='"+ textBox2.Text +"'group by owner_user", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string log = Convert.ToString(dt.Rows.Count);
            if (textBox1.Text != "" && textBox2.Text != "" && log != "0")
            {
                string time = DateTime.Now.ToLongTimeString();
                string date = DateTime.Now.ToShortDateString();

                if (dt.Rows[0][0].ToString() == "1")
                {
                    string owner = dt.Rows[0][1].ToString();
                    if (owner == "admin     ")
                    {
                        for (int i = 0; i <= 100; i++)
                        {
                            if (i < 101)
                            {
                                progressBar1.Value = i;
                            }

                        }
                        MessageBox.Show(time, "Час з'явлення");
                        Form_admin fa = new Form_admin(textBox1.Text);
                        fa.Show();
                        this.Hide();
                    }
                    if (owner == "user      ")
                    {
                        for (int i = 0; i <= 100; i++)
                        {
                            if (i < 101)
                            {
                                progressBar1.Value = i;
                            }

                        }
                        MessageBox.Show(time, "Час з'явлення");
                        Form1 f = new Form1(textBox1.Text);
                        f.Show();
                        this.Hide();
                    }   
                }
                else
                {
                    progressBar1.Value = 0;
                    textBox2.Text = "";
                    MessageBox.Show("Полилка доступу!!! Перевите привельність ведення номеру картки і паролю", "ERROR");
                }
            }
            else MessageBox.Show("Полилка доступу!!! Перевите привельність ведення номеру картки і паролю", "ERROR ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
