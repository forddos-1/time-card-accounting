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
    public partial class Form_worker_order : Form
    {
        public Form_worker_order()
        {
            InitializeComponent();
        }

        private void worker_orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.worker_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_worker_order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Worker_order". При необходимости она может быть перемещена или удалена.
            this.worker_orderTableAdapter.Fill(this.entry_cards_KRBDDataSet.Worker_order);

        }
    }
}
