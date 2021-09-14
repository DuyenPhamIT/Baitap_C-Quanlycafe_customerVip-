
namespace BaiTap
{
    partial class addOrderDetail
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.rchNote = new System.Windows.Forms.RichTextBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(599, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 82;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 81;
            this.btnAdd.Text = "Xóa";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(316, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(166, 339);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 78;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // rchNote
            // 
            this.rchNote.Location = new System.Drawing.Point(178, 232);
            this.rchNote.Name = "rchNote";
            this.rchNote.Size = new System.Drawing.Size(630, 101);
            this.rchNote.TabIndex = 77;
            this.rchNote.Text = "";
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(178, 83);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(243, 21);
            this.cboProduct.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "NodeCustom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Khuyễn mãi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Order Detail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Mã order";
            // 
            // cboId
            // 
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(178, 26);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(121, 21);
            this.cboId.TabIndex = 84;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 529);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.Size = new System.Drawing.Size(878, 212);
            this.dgvOrderDetail.TabIndex = 85;
            this.dgvOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellContentClick);
            this.dgvOrderDetail.Click += new System.EventHandler(this.dgvOrderDetail_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(554, 83);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 88;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cboSize.Location = new System.Drawing.Point(178, 135);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 89;
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(178, 186);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(275, 20);
            this.txtDis.TabIndex = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboProduct);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.rchNote);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(0, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 378);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order sản phẩm";
            // 
            // addOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.label1);
            this.Name = "addOrderDetail";
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.addOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RichTextBox rchNote;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}