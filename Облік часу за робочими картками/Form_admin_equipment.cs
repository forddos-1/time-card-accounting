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
    public partial class Form_admin_equipment : Form
    {
        public Form_admin_equipment()
        {
            InitializeComponent();
        }

        private void equipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_admin_equipment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Equipment);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { this.equipmentBindingSource.Filter = "id_equipment ='" + textBox3.Text + "'";}
            if (radioButton2.Checked) { this.equipmentBindingSource.Filter = "name_equipment ='" + textBox4.Text + "'";}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.equipmentBindingSource.Filter = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(equipmentDataGridView.Size.Width + 10, equipmentDataGridView.Size.Height + 10);
            equipmentDataGridView.DrawToBitmap(bmp, equipmentDataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
