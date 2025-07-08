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
    public partial class Form_admin_customer : Form
    {
        public Form_admin_customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_admin_customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Оrder_". При необходимости она может быть перемещена или удалена.
            this.оrder_TableAdapter.Fill(this.entry_cards_KRBDDataSet.Оrder_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.entry_cards_KRBDDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { this.customerBindingSource.Filter = "id_customer ='" + textBox7.Text + "'"; }
            if (radioButton2.Checked) { this.customerBindingSource.Filter = "id_order ='" + textBox8.Text + "'"; }
            if (radioButton3.Checked) { this.customerBindingSource.Filter = "name_customer ='" + textBox9.Text + "'"; }
            if (radioButton4.Checked) { this.customerBindingSource.Filter = "surname_customer ='" + textBox10.Text + "'"; }
            if (radioButton5.Checked) { this.customerBindingSource.Filter = "patronymic_customer ='" + textBox11.Text + "'"; }
            if (radioButton6.Checked) { this.customerBindingSource.Filter = "phone_customer ='" + textBox12.Text + "'"; }
            if (radioButton7.Checked) { this.customerBindingSource.Filter = "address_customer ='" + textBox13.Text + "'"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.customerBindingSource.Filter = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(customerDataGridView.Size.Width + 10, customerDataGridView.Size.Height + 10);
            customerDataGridView.DrawToBitmap(bmp,customerDataGridView.Bounds);
            e.Graphics.DrawImage(bmp,0,0);
        }
    }
}
