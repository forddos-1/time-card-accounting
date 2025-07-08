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
    public partial class Form_admin_worker_order : Form
    {
        public Form_admin_worker_order()
        {
            InitializeComponent();
        }

        private void worker_orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.worker_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_admin_worker_order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Working_hours". При необходимости она может быть перемещена или удалена.
            this.working_hoursTableAdapter.Fill(this.entry_cards_KRBDDataSet.Working_hours);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Equipment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Оrder_". При необходимости она может быть перемещена или удалена.
            this.оrder_TableAdapter.Fill(this.entry_cards_KRBDDataSet.Оrder_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.entry_cards_KRBDDataSet.Worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Worker_order". При необходимости она может быть перемещена или удалена.
            this.worker_orderTableAdapter.Fill(this.entry_cards_KRBDDataSet.Worker_order);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { this.worker_orderBindingSource.Filter = "id_WO ='" + textBox6.Text + "'"; }
            if (radioButton2.Checked) { this.worker_orderBindingSource.Filter = "id_worker ='" + textBox7.Text + "'"; }
            if (radioButton3.Checked) { this.worker_orderBindingSource.Filter = "id_order ='" + textBox8.Text + "'"; }
            if (radioButton4.Checked) { this.worker_orderBindingSource.Filter = "id_equipment ='" + textBox9.Text + "'"; }
            if (radioButton5.Checked) { this.worker_orderBindingSource.Filter = "rate_WO ='" + textBox10.Text + "'"; }
            if (radioButton6.Checked) { this.worker_orderBindingSource.Filter = "id_working_hours ='" + textBox11.Text + "'"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.worker_orderBindingSource.Filter = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(worker_orderDataGridView.Size.Width + 10, worker_orderDataGridView.Size.Height + 10);
            worker_orderDataGridView.DrawToBitmap(bmp, worker_orderDataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
