namespace JP_Surplus
{
    partial class Save2
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
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtInch = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 358);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 0, 44);
            button1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(564, 289);
            button1.Name = "button1";
            button1.Size = new Size(71, 33);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtPrice.Location = new Point(692, 139);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 25);
            txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtQuantity.Location = new Point(692, 187);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(193, 25);
            txtQuantity.TabIndex = 3;
            // 
            // txtInch
            // 
            txtInch.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtInch.Location = new Point(692, 88);
            txtInch.Name = "txtInch";
            txtInch.Size = new Size(193, 25);
            txtInch.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtName.Location = new Point(692, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 25);
            txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Bold);
            txtDescription.Location = new Point(692, 233);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(193, 25);
            txtDescription.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(221, 0, 44);
            button3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(564, 328);
            button3.Name = "button3";
            button3.Size = new Size(71, 33);
            button3.TabIndex = 8;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(221, 0, 44);
            button4.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(771, 366);
            button4.Name = "button4";
            button4.Size = new Size(114, 33);
            button4.TabIndex = 9;
            button4.Text = "Main Page";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(579, 236);
            label5.Name = "label5";
            label5.Size = new Size(110, 18);
            label5.TabIndex = 15;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(629, 142);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 14;
            label4.Text = "Price:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(601, 190);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 13;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(620, 91);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 12;
            label2.Text = "Inches:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(564, 44);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 11;
            label1.Text = "Product Name:";
            // 
            // Save2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 54);
            ClientSize = new Size(917, 430);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtInch);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Save2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Save2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtInch;
        private TextBox txtName;
        private TextBox txtDescription;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}