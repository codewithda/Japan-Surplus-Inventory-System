namespace JP_Surplus
{
    partial class View
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
            button1 = new Button();
            btnAddtoCart = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnClearCart = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonTotal = new Button();
            Amount = new Label();
            label2 = new Label();
            label3 = new Label();
            btnReceipt = new Button();
            btnEdit = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 349);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 0, 44);
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(843, 420);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 1;
            button1.Text = "Main Page";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddtoCart
            // 
            btnAddtoCart.BackColor = Color.FromArgb(221, 0, 44);
            btnAddtoCart.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddtoCart.ForeColor = SystemColors.ControlLightLight;
            btnAddtoCart.Location = new Point(601, 213);
            btnAddtoCart.Name = "btnAddtoCart";
            btnAddtoCart.Size = new Size(102, 49);
            btnAddtoCart.TabIndex = 2;
            btnAddtoCart.Text = "Add to Cart";
            btnAddtoCart.UseVisualStyleBackColor = false;
            btnAddtoCart.Click += btnAddtoCart_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4 });
            dataGridView2.Location = new Point(601, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(356, 150);
            dataGridView2.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "pdname";
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "price";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "quantity";
            Column4.Name = "Column4";
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(221, 0, 44);
            btnClearCart.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearCart.ForeColor = SystemColors.ControlLightLight;
            btnClearCart.Location = new Point(601, 281);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(102, 51);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(838, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(838, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(838, 268);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // buttonTotal
            // 
            buttonTotal.BackColor = Color.FromArgb(221, 0, 44);
            buttonTotal.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTotal.ForeColor = SystemColors.ControlLightLight;
            buttonTotal.Location = new Point(853, 339);
            buttonTotal.Name = "buttonTotal";
            buttonTotal.Size = new Size(75, 29);
            buttonTotal.TabIndex = 8;
            buttonTotal.Text = "Total";
            buttonTotal.UseVisualStyleBackColor = false;
            buttonTotal.Click += buttonTotal_Click;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount.ForeColor = SystemColors.ControlLightLight;
            Amount.Location = new Point(765, 213);
            Amount.Name = "Amount";
            Amount.Size = new Size(73, 18);
            Amount.TabIndex = 9;
            Amount.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(709, 242);
            label2.Name = "label2";
            label2.Size = new Size(130, 18);
            label2.TabIndex = 10;
            label2.Text = "total Payment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(768, 271);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 11;
            label3.Text = "Change:";
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.FromArgb(221, 0, 44);
            btnReceipt.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReceipt.ForeColor = SystemColors.ControlLightLight;
            btnReceipt.Location = new Point(822, 376);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(135, 29);
            btnReceipt.TabIndex = 12;
            btnReceipt.Text = "View receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(221, 0, 44);
            btnEdit.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(601, 355);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(793, 298);
            label1.Name = "label1";
            label1.Size = new Size(45, 18);
            label1.TabIndex = 14;
            label1.Text = "MOP:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(838, 298);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 24);
            comboBox1.TabIndex = 15;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 54);
            ClientSize = new Size(983, 468);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnEdit);
            Controls.Add(btnReceipt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Amount);
            Controls.Add(buttonTotal);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnClearCart);
            Controls.Add(dataGridView2);
            Controls.Add(btnAddtoCart);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btnAddtoCart;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnClearCart;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonTotal;
        private Label Amount;
        private Label label2;
        private Label label3;
        private Button btnReceipt;
        private Button btnEdit;
        private Label label1;
        private ComboBox comboBox1;
    }
}