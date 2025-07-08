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
    public partial class Form_equipment : Form
    {
        public Form_equipment()
        {
            InitializeComponent();
        }

        private void equipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_equipment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Equipment". При необходимости она может быть перемещена или удалена.
            this.equipmentTableAdapter.Fill(this.entry_cards_KRBDDataSet.Equipment);

        }
    }
}
