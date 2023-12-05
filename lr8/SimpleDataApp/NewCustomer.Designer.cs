
namespace SimpleDataApp
{
    partial class NewCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(363, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление учетной записи";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(204, 81);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(132, 22);
            this.txtCustomerID.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(151, 31);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(185, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Идентификатор клиета:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя заказчика:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpOrderDate);
            this.groupBox2.Controls.Add(this.numOrderAmount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(363, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание заказа";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(151, 73);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(185, 22);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(151, 30);
            this.numOrderAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(187, 22);
            this.numOrderAmount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата заказа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сумма заказа:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(403, 110);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(204, 28);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Создать учетную запись";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(439, 240);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(168, 28);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Разместить заказ";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(335, 303);
            this.btnAddAnotherAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(272, 28);
            this.btnAddAnotherAccount.TabIndex = 4;
            this.btnAddAnotherAccount.Text = "Добавить другую учетную запись";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            this.btnAddAnotherAccount.Click += new System.EventHandler(this.btnAddAnotherAccount_Click);
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(112, 303);
            this.btnAddFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(100, 28);
            this.btnAddFinish.TabIndex = 5;
            this.btnAddFinish.Text = "Готово";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            this.btnAddFinish.Click += new System.EventHandler(this.btnAddFinish_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 343);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewCustomer";
            this.Text = "Новая учетная запись и заказ";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddAnotherAccount;
        private System.Windows.Forms.Button btnAddFinish;
    }
}