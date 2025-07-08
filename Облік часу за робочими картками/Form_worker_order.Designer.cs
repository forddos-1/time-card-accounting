namespace Облік_часу_за_робочими_картками
{
    partial class Form_worker_order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_worker_order));
            this.entry_cards_KRBDDataSet = new Облік_часу_за_робочими_картками.entry_cards_KRBDDataSet();
            this.worker_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker_orderTableAdapter = new Облік_часу_за_робочими_картками.entry_cards_KRBDDataSetTableAdapters.Worker_orderTableAdapter();
            this.tableAdapterManager = new Облік_часу_за_робочими_картками.entry_cards_KRBDDataSetTableAdapters.TableAdapterManager();
            this.worker_orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.worker_orderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.entry_cards_KRBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_orderBindingNavigator)).BeginInit();
            this.worker_orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // entry_cards_KRBDDataSet
            // 
            this.entry_cards_KRBDDataSet.DataSetName = "entry_cards_KRBDDataSet";
            this.entry_cards_KRBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worker_orderBindingSource
            // 
            this.worker_orderBindingSource.DataMember = "Worker_order";
            this.worker_orderBindingSource.DataSource = this.entry_cards_KRBDDataSet;
            // 
            // worker_orderTableAdapter
            // 
            this.worker_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.EquipmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Облік_часу_за_робочими_картками.entry_cards_KRBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_cardsTableAdapter = null;
            this.tableAdapterManager.Worker_orderTableAdapter = this.worker_orderTableAdapter;
            this.tableAdapterManager.WorkerTableAdapter = null;
            this.tableAdapterManager.Working_hoursTableAdapter = null;
            this.tableAdapterManager.Оrder_TableAdapter = null;
            // 
            // worker_orderBindingNavigator
            // 
            this.worker_orderBindingNavigator.AddNewItem = null;
            this.worker_orderBindingNavigator.BindingSource = this.worker_orderBindingSource;
            this.worker_orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.worker_orderBindingNavigator.DeleteItem = null;
            this.worker_orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.worker_orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.worker_orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.worker_orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.worker_orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.worker_orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.worker_orderBindingNavigator.Name = "worker_orderBindingNavigator";
            this.worker_orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.worker_orderBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.worker_orderBindingNavigator.TabIndex = 0;
            this.worker_orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // worker_orderDataGridView
            // 
            this.worker_orderDataGridView.AutoGenerateColumns = false;
            this.worker_orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.worker_orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.worker_orderDataGridView.DataSource = this.worker_orderBindingSource;
            this.worker_orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worker_orderDataGridView.Location = new System.Drawing.Point(0, 25);
            this.worker_orderDataGridView.Name = "worker_orderDataGridView";
            this.worker_orderDataGridView.Size = new System.Drawing.Size(645, 339);
            this.worker_orderDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_WO";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_WO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_worker";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_worker";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_order";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_order";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_equipment";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_equipment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rate_WO";
            this.dataGridViewTextBoxColumn5.HeaderText = "rate_WO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_working_hours";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_working_hours";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // Form_worker_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 364);
            this.Controls.Add(this.worker_orderDataGridView);
            this.Controls.Add(this.worker_orderBindingNavigator);
            this.Name = "Form_worker_order";
            this.Text = "Робітник/замовленя";
            this.Load += new System.EventHandler(this.Form_worker_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entry_cards_KRBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker_orderBindingNavigator)).EndInit();
            this.worker_orderBindingNavigator.ResumeLayout(false);
            this.worker_orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker_orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private entry_cards_KRBDDataSet entry_cards_KRBDDataSet;
        private System.Windows.Forms.BindingSource worker_orderBindingSource;
        private entry_cards_KRBDDataSetTableAdapters.Worker_orderTableAdapter worker_orderTableAdapter;
        private entry_cards_KRBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator worker_orderBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView worker_orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}