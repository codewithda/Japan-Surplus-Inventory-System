using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JP_Surplus
{
    public partial class Save2 : Form
    {
        static readonly string server = "127.0.0.1";
        static readonly string user = "root";
        static readonly string password = "";
        static readonly string database = "testingstudio";
        public static string connectionString = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";

        public Save2()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Inch", "Inch");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("Description", "Description");

            // Attach KeyPress events to the quantity, inch, price, name, and description text boxes
            txtQuantity.KeyPress += new KeyPressEventHandler(txtQuantity_KeyPress);
            txtInch.KeyPress += new KeyPressEventHandler(txtInch_KeyPress);
            txtPrice.KeyPress += new KeyPressEventHandler(txtPrice_KeyPress);
            txtName.KeyPress += new KeyPressEventHandler(txtName_KeyPress);
            txtDescription.KeyPress += new KeyPressEventHandler(txtDescription_KeyPress);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers for Quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtInch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers for Inch.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers for Price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters for Name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only letters for Description.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtName.Text, txtInch.Text, txtPrice.Text, txtQuantity.Text, txtDescription.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit2 f = new Edit2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveDataToDatabase();
        }

        private void SaveDataToDatabase()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Skip the last row which is the new row for adding data
                        if (!row.IsNewRow)
                        {
                            string name = row.Cells["Name"].Value.ToString();
                            int inch = Convert.ToInt32(row.Cells["Inch"].Value);
                            int price = Convert.ToInt32(row.Cells["Price"].Value);
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            string description = row.Cells["Description"].Value.ToString();

                            string query = "INSERT INTO testing_product (pro_name, pro_inch, pro_price, pro_quantity, pro_description) VALUES (@Name, @Inch, @Price, @Quantity, @Description)";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Name", name);
                            command.Parameters.AddWithValue("@Inch", inch);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.Parameters.AddWithValue("@Description", description);
                            command.ExecuteNonQuery();
                        }
                    }
                    connection.Close();
                }
                MessageBox.Show("The data is saved!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack Trace:");
                Console.WriteLine(e.StackTrace);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Do nothing
        }
    }
}
