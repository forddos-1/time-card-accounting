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
    public partial class Form_admin_order : Form
    {
        public Form_admin_order()
        {
            InitializeComponent();
        }

        private void оrder_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оrder_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_admin_order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Оrder_". При необходимости она может быть перемещена или удалена.
            this.оrder_TableAdapter.Fill(this.entry_cards_KRBDDataSet.Оrder_);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { this.оrder_BindingSource.Filter = "id_order ='" + textBox6.Text + "'"; }
            if (radioButton2.Checked) { this.оrder_BindingSource.Filter = "name_order ='" + textBox7.Text + "'"; }
            if (radioButton3.Checked) { this.оrder_BindingSource.Filter = "quantity_order ='" + textBox8.Text + "'"; }
            if (radioButton4.Checked) { this.оrder_BindingSource.Filter = "price_order ='" + textBox9.Text + "'"; }
            if (radioButton5.Checked) { this.оrder_BindingSource.Filter = "start_date ='" + textBox10.Text + "'"; }
            if (radioButton6.Checked) { this.оrder_BindingSource.Filter = "end_date ='" + textBox11.Text + "'"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.оrder_BindingSource.Filter = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(оrder_DataGridView.Size.Width + 10, оrder_DataGridView.Size.Height + 10);
            оrder_DataGridView.DrawToBitmap(bmp, оrder_DataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
