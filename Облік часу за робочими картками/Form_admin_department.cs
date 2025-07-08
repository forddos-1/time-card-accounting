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
    public partial class Form_admin_department : Form
    {
        public Form_admin_department()
        {
            InitializeComponent();
        }

        private void departmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_admin_department_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Department);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { this.departmentBindingSource.Filter = "id_department ='" + textBox4.Text + "'"; }
            if (radioButton2.Checked) { this.departmentBindingSource.Filter = "name_department ='" + textBox5.Text + "'"; }
            if (radioButton3.Checked) { this.departmentBindingSource.Filter = "address_department ='" + textBox6.Text + "'"; }
            if (radioButton4.Checked) { this.departmentBindingSource.Filter = "phone_department ='" + textBox7.Text + "'"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.departmentBindingSource.Filter = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(departmentDataGridView.Size.Width + 10, departmentDataGridView.Size.Height + 10);
            departmentDataGridView.DrawToBitmap(bmp, departmentDataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
