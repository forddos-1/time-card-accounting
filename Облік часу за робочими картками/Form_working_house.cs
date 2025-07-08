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
    public partial class Form_working_house : Form
    {
        public Form_working_house()
        {
            InitializeComponent();
        }

        private void working_hoursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.working_hoursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.entry_cards_KRBDDataSet);

        }

        private void Form_working_house_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "entry_cards_KRBDDataSet.Working_hours". При необходимости она может быть перемещена или удалена.
            this.working_hoursTableAdapter.Fill(this.entry_cards_KRBDDataSet.Working_hours);

        }
    }
}
