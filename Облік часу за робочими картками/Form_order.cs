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
    public partial class Form_order : Form
    {
        public Form_order()
        {
            InitializeComponent();
        }

        private void оrder_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оrder_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Оrder_". При необходимости она может быть перемещена или удалена.
            this.оrder_TableAdapter.Fill(this.entry_cards_KRBDDataSet.Оrder_);

        }
    }
}
