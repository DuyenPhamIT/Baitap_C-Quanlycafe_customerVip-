
namespace BaiTap
{
    partial class addOrders
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.rchOrder = new System.Windows.Forms.RichTextBox();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.dateRequire = new System.Windows.Forms.DateTimePicker();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(903, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 82;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(903, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "Lưu";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(903, 58);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 78;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // rchOrder
            // 
            this.rchOrder.Location = new System.Drawing.Point(147, 291);
            this.rchOrder.Name = "rchOrder";
            this.rchOrder.Size = new System.Drawing.Size(661, 116);
            this.rchOrder.TabIndex = 77;
            this.rchOrder.Text = "";
            // 
            // dateOrder
            // 
            this.dateOrder.CustomFormat = "HH:mm";
            this.dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOrder.Location = new System.Drawing.Point(147, 204);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(200, 20);
            this.dateOrder.TabIndex = 76;
            // 
            // dateRequire
            // 
            this.dateRequire.CustomFormat = " HH:mm";
            this.dateRequire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRequire.Location = new System.Drawing.Point(553, 204);
            this.dateRequire.Name = "dateRequire";
            this.dateRequire.Size = new System.Drawing.Size(255, 20);
            this.dateRequire.TabIndex = 75;
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(147, 144);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(393, 21);
            this.cboEmployee.TabIndex = 70;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(147, 90);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(358, 21);
            this.cboCustomer.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "NodeCustom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "RequireDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "OrderDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nhân viên order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Mã Order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Orders";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(255, 20);
            this.txtId.TabIndex = 83;
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(1, 506);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(1012, 148);
            this.dgvOrder.TabIndex = 84;
            this.dgvOrder.Click += new System.EventHandler(this.dgvOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rchOrder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.cboCustomer);
            this.groupBox1.Controls.Add(this.cboEmployee);
            this.groupBox1.Controls.Add(this.dateOrder);
            this.groupBox1.Controls.Add(this.dateRequire);
            this.groupBox1.Location = new System.Drawing.Point(1, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 434);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm/Sửa Orders";
            // 
            // addOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrder);
            this.Name = "addOrders";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.addOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RichTextBox rchOrder;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.DateTimePicker dateRequire;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}