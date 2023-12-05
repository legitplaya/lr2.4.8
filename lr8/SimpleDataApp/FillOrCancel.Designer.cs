
namespace SimpleDataApp
{
    partial class FillOrCancel
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
            this.dvgCustomerOrders = new System.Windows.Forms.DataGridView();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomerOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCustomerOrders
            // 
            this.dvgCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomerOrders.Location = new System.Drawing.Point(12, 181);
            this.dvgCustomerOrders.Name = "dvgCustomerOrders";
            this.dvgCustomerOrders.RowHeadersWidth = 51;
            this.dvgCustomerOrders.RowTemplate.Height = 24;
            this.dvgCustomerOrders.Size = new System.Drawing.Size(606, 192);
            this.dvgCustomerOrders.TabIndex = 0;
            this.dvgCustomerOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(294, 54);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 22);
            this.txtOrderID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Идентификатор заказа: ";
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.Location = new System.Drawing.Point(400, 51);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Size = new System.Drawing.Size(137, 34);
            this.btnFindByOrderID.TabIndex = 3;
            this.btnFindByOrderID.Text = "найти заказ";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "При заполнении заказа укажите дату";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Location = new System.Drawing.Point(383, 111);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFillDate.TabIndex = 5;
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.Location = new System.Drawing.Point(521, 414);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Size = new System.Drawing.Size(97, 29);
            this.btnFinishUpdates.TabIndex = 6;
            this.btnFinishUpdates.Text = "Готово";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.Location = new System.Drawing.Point(232, 414);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Size = new System.Drawing.Size(145, 29);
            this.btnFillOrder.TabIndex = 7;
            this.btnFillOrder.Text = "Заполнить заказ";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(58, 414);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(136, 29);
            this.btnCancelOrder.TabIndex = 8;
            this.btnCancelOrder.Text = "Отменить заказ";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // FillOrCancel
            // 
            this.ClientSize = new System.Drawing.Size(786, 473);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFindByOrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.dvgCustomerOrders);
            this.Name = "FillOrCancel";
            this.Load += new System.EventHandler(this.FillOrCancel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomerOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.DataGridView dvgCustomerOrders;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFindByOrderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.Button btnFinishUpdates;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnCancelOrder;
    }
}