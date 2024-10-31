using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace JP_Surplus
{
    public partial class View : Form
    {
        private decimal totalAmount;

        public View()
        {
            InitializeComponent();
            LoadData();

            comboBox1.Items.Add("GCASH");
            comboBox1.Items.Add("COD");
            comboBox1.Items.Add("PAYMAYA");
            comboBox1.SelectedIndex = 0;
        }

        private void LoadData()
        {
            string connectionString = Class1.connection_string;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM testing_product";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Enter quantity:", "Quantity", ""), out quantity))
            {
                if (quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string productName = selectedRow.Cells["pro_name"].Value.ToString();
                    decimal price = Convert.ToDecimal(selectedRow.Cells["pro_price"].Value);
                    int currentQuantity = Convert.ToInt32(selectedRow.Cells["pro_quantity"].Value);

                    if (currentQuantity < quantity)
                    {
                        MessageBox.Show("Not enough quantity available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string connectionString = Class1.connection_string;
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            string updateQuery = "UPDATE testing_product SET pro_quantity = pro_quantity - @Quantity WHERE pro_name = @ProductName";
                            using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                            {
                                command.Parameters.AddWithValue("@Quantity", quantity);
                                command.Parameters.AddWithValue("@ProductName", productName);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating quantity: " + ex.Message);
                        return;
                    }

                    LoadData();
                    dataGridView2.Rows.Add(productName, price * quantity, quantity);
                }
                else
                {
                    MessageBox.Show("Please select a product to add to the cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void btnClearCart_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            // Check if textBox2 has input
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter the amount received in the appropriate field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells[1].Value);
                    }
                }

                textBox1.Text = total.ToString();
                totalAmount = total;

                int first = int.Parse(textBox1.Text);
                int second = int.Parse(textBox2.Text);
                int sub = second - first;

                textBox3.Text = sub.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating the total: " + ex.Message);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("Receipt:");
            receipt.AppendLine("---------");

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string productName = row.Cells[0].Value.ToString();
                    string productTotal = row.Cells[1].Value.ToString();
                    string productQuantity = row.Cells[2].Value.ToString();

                    receipt.AppendLine($"{productName} - {productQuantity} x ₱{productTotal}");
                }
            }

            receipt.AppendLine("---------");
            receipt.AppendLine($"Total: ₱{totalAmount}");

            // Add selected payment mode to the receipt
            string paymentMode = comboBox1.SelectedItem.ToString();
            receipt.AppendLine("---------");
            receipt.AppendLine($"Payment Mode: {paymentMode}");

            MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit2 edit2 = new Edit2();
            edit2.Show();
            this.Hide();
        }

        private void View_Load(object sender, EventArgs e)
        {
            // Initialization code, if any
        }

        private void btnReceipt_Click_1(object sender, EventArgs e)
        {
            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("Receipt:");
            receipt.AppendLine("---------");

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string productName = row.Cells[0].Value.ToString();
                    string productTotal = row.Cells[1].Value.ToString();
                    string productQuantity = row.Cells[2].Value.ToString();

                    receipt.AppendLine($"{productName} - {productQuantity} x ₱{productTotal}");
                }
            }

            receipt.AppendLine("---------");
            receipt.AppendLine($"Total: ₱{totalAmount}");

            // Add selected payment mode to the receipt
            string paymentMode = comboBox1.SelectedItem.ToString();
            receipt.AppendLine("---------");
            receipt.AppendLine($"Payment Mode: {paymentMode}");

            MessageBox.Show(receipt.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
