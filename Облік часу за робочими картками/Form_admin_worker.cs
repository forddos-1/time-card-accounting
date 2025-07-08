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
    public partial class Form_admin_worker : Form
    {
        public Form_admin_worker()
        {
            InitializeComponent();
        }

        private void workerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_admin_worker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.entry_cards_KRBDDataSet.Worker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { this.workerBindingSource.Filter = "id_worker ='" + textBox9.Text + "'"; }
            if (radioButton2.Checked) { this.workerBindingSource.Filter = "name_worker ='" + textBox9.Text + "'"; }
            if (radioButton3.Checked) { this.workerBindingSource.Filter = "surname_worker ='" + textBox9.Text + "'"; }
            if (radioButton4.Checked) { this.workerBindingSource.Filter = "patronymic_worker ='" + textBox9.Text + "'"; }
            if (radioButton5.Checked) { this.workerBindingSource.Filter = "phone_worker ='" + textBox9.Text + "'"; }
            if (radioButton6.Checked) { this.workerBindingSource.Filter = "date_of_birth ='" + textBox9.Text + "'"; }
            if (radioButton7.Checked) { this.workerBindingSource.Filter = "address_worker ='" + textBox9.Text + "'"; }
            if (radioButton8.Checked) { this.workerBindingSource.Filter = "card_number ='" + textBox9.Text + "'"; }
            if (radioButton9.Checked) { this.workerBindingSource.Filter = "id_departament ='" + textBox9.Text + "'"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.workerBindingSource.Filter = "";
            textBox9.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(workerDataGridView.Size.Width + 10, workerDataGridView.Size.Height + 10);
            workerDataGridView.DrawToBitmap(bmp, workerDataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_admin_worker_cards FAWC = new Form_admin_worker_cards(textBox4.Text);
            FAWC.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не забудьте надати користувачу права доступу!!!");
        }
    }
}
