namespace JP_Surplus
{
    partial class Edit
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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            txtPdName = new TextBox();
            label1 = new Label();
            txtInchh = new Label();
            txtInch = new TextBox();
            txtPricee = new Label();
            txtPrice = new TextBox();
            txtQty = new Label();
            txtQuantity = new TextBox();
            txtDesc = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 274);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(22, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            btnEdit.Location = new Point(130, 310);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtPdName
            // 
            txtPdName.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtPdName.Location = new Point(731, 46);
            txtPdName.Name = "txtPdName";
            txtPdName.Size = new Size(159, 25);
            txtPdName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            label1.Location = new Point(606, 49);
            label1.Name = "label1";
            label1.Size = new Size(108, 17);
            label1.TabIndex = 4;
            label1.Text = "Product Name:";
            label1.Click += label1_Click;
            // 
            // txtInchh
            // 
            txtInchh.AutoSize = true;
            txtInchh.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtInchh.Location = new Point(611, 103);
            txtInchh.Name = "txtInchh";
            txtInchh.Size = new Size(96, 17);
            txtInchh.TabIndex = 6;
            txtInchh.Text = "Product Inch:";
            // 
            // txtInch
            // 
            txtInch.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtInch.Location = new Point(731, 100);
            txtInch.Name = "txtInch";
            txtInch.Size = new Size(159, 25);
            txtInch.TabIndex = 5;
            // 
            // txtPricee
            // 
            txtPricee.AutoSize = true;
            txtPricee.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtPricee.Location = new Point(605, 155);
            txtPricee.Name = "txtPricee";
            txtPricee.Size = new Size(102, 17);
            txtPricee.TabIndex = 8;
            txtPricee.Text = "Product Price:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtPrice.Location = new Point(731, 152);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(159, 25);
            txtPrice.TabIndex = 7;
            // 
            // txtQty
            // 
            txtQty.AutoSize = true;
            txtQty.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtQty.Location = new Point(582, 202);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(125, 17);
            txtQty.TabIndex = 10;
            txtQty.Text = "Product Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtQuantity.Location = new Point(731, 202);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(159, 25);
            txtQuantity.TabIndex = 9;
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtDesc.Location = new Point(731, 249);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(159, 25);
            txtDesc.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(568, 249);
            label2.Name = "label2";
            label2.Size = new Size(146, 17);
            label2.TabIndex = 12;
            label2.Text = "Product Description:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            button1.Location = new Point(836, 310);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 13;
            button1.Text = "Main Page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 362);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtDesc);
            Controls.Add(txtQty);
            Controls.Add(txtQuantity);
            Controls.Add(txtPricee);
            Controls.Add(txtPrice);
            Controls.Add(txtInchh);
            Controls.Add(txtInch);
            Controls.Add(label1);
            Controls.Add(txtPdName);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDIT";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtPdName;
        private Label label1;
        private Label txtInchh;
        private TextBox txtInch;
        private Label txtPricee;
        private TextBox txtPrice;
        private Label txtQty;
        private TextBox txtQuantity;
        private TextBox txtDesc;
        private Label label2;
        private Button button1;
    }
}