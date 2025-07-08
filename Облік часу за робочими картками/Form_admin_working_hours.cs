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
    public partial class Form_admin_working_hours : Form
    {
        public Form_admin_working_hours()
        {
            InitializeComponent();
        }

        private void working_hoursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.working_hoursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_admin_working_hours_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.entry_cards_KRBDDataSet.Worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Working_hours". При необходимости она может быть перемещена или удалена.
            this.working_hoursTableAdapter.Fill(this.entry_cards_KRBDDataSet.Working_hours);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { this.working_hoursBindingSource.Filter = "id_working_hours ='" + textBox7.Text + "'"; }
            if (radioButton2.Checked) { this.working_hoursBindingSource.Filter = "id_worker ='" + textBox8.Text + "'"; }
            if (radioButton3.Checked) { this.working_hoursBindingSource.Filter = "card_number ='" + textBox9.Text + "'"; }
            if (radioButton4.Checked) { this.working_hoursBindingSource.Filter = "recording_time ='" + textBox10.Text + "'"; }
            if (radioButton5.Checked) { this.working_hoursBindingSource.Filter = "recording_date ='" + textBox11.Text + "'"; }
            if (radioButton6.Checked) { this.working_hoursBindingSource.Filter = "exit_time ='" + textBox12.Text + "'"; }
            if (radioButton7.Checked) { this.working_hoursBindingSource.Filter = "exit_date ='" + textBox13.Text + "'"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.working_hoursBindingSource.Filter = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(working_hoursDataGridView.Size.Width + 10, working_hoursDataGridView.Size.Height + 10);
            working_hoursDataGridView.DrawToBitmap(bmp, working_hoursDataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
