using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_Surplus
{
    public partial class Edit2 : Form
    {
        string radio;
        static readonly string server = "127.0.0.1";
        static readonly string user = "root";
        static readonly string password = "";
        static readonly string database = "testingstudio";
        public static string connectionString = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password='" + password + "'";
        DataGridView dataGridView;
        MySqlConnection connection = new MySqlConnection(connectionString);

        public Edit2()
        {
            InitializeComponent();
            // Initialize DataGridView
            dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill; // Fill the entire form with DataGridView
            dataGridView.ReadOnly = true; // Make DataGridView read-only
            this.Controls.Add(dataGridView);

            // Add columns to DataGridView
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Inch", "Inch");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("Quantity", "Quantity");
            dataGridView.Columns.Add("Description", "Description");

            // Load data when the form is loaded
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Check if a product ID is provided
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Please provide a product ID.");
                return;
            }

            // Determine the column to update based on the selected radio button
            string columnToUpdate = radio;
            int productId = int.Parse(txtProductID.Text);
            object newValue = null;
            try
            {
                // Get the new value from the text box or any other input control
                newValue = int.Parse(txtUpdateInput.Text);
            }
            catch (Exception ex)
            {
                newValue = txtUpdateInput.Text;
            }
            // Execute an SQL UPDATE statement to update the corresponding column in the database
            string query = $"UPDATE testing_product SET `{columnToUpdate}` = '" + newValue + "' WHERE pro_id = " + @productId;
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue(radio, newValue);
            // command.Parameters.AddWithValue("pro_id", productId); // Assuming product ID is an integer

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"Updated {rowsAffected} row(s) successfully.");
                LoadData(); // Reload the data in the DataGridView after updating
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadData()
        {
            string query = "SELECT * FROM testing_product";
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Retrieve data from the reader
                    // For example:
                    int primaryKey = reader.GetInt32(0);
                    string proName = reader.GetString(1);
                    int proInch = reader.GetInt32(2);
                    int proPrice = reader.GetInt32(3);
                    int proQuantity = reader.GetInt32(4);
                    string proDescription = reader.GetString(5);

                    // Add data to DataGridView or perform other operations
                    dataGridView.Rows.Add(primaryKey, proName, proInch, proPrice, proQuantity, proDescription);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radio = "pro_name";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radio = "pro_inch";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radio = "pro_price";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radio = "pro_quantity";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radio = "pro_description";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                int productId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);

                // Delete the row from the database
                string query = "DELETE FROM testing_product WHERE pro_id = @productId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@productId", productId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show($"Deleted {rowsAffected} row(s) successfully.");

                    // Remove the selected row from DataGridView
                    dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting row: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if product ID and quantity/price are provided
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtUpdateInput.Text))
            {
                MessageBox.Show("Please provide the product ID and the value to add.");
                return;
            }

            // Determine the column to update based on the selected radio button
            string columnToUpdate = radio;

            // Parse the product ID and value to add
            int productId, valueToAdd;
            if (!int.TryParse(txtProductID.Text, out productId) || !int.TryParse(txtUpdateInput.Text, out valueToAdd))
            {
                MessageBox.Show("Please provide valid numeric values for product ID and the value to add.");
                return;
            }

            // Get the current value from the database for the specific product
            string query = $"SELECT {columnToUpdate} FROM testing_product WHERE pro_id = @productId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@productId", productId);
            int currentValue = 0; // Default value
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    currentValue = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching current value from the database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            // Calculate the new value
            int newValue = currentValue + valueToAdd;

            // Update the column in the database for the specific product
            query = $"UPDATE testing_product SET {columnToUpdate} = @newValue WHERE pro_id = @productId";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@newValue", newValue);
            command.Parameters.AddWithValue("@productId", productId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"Updated {rowsAffected} row(s) successfully.");
                LoadData(); // Reload the data in the DataGridView after updating
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating value in the database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Check if product ID and quantity/price are provided
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtUpdateInput.Text))
            {
                MessageBox.Show("Please provide the product ID and the value to add.");
                return;
            }

            // Determine the column to update based on the selected radio button
            string columnToUpdate = radio;

            // Parse the product ID and value to add
            int productId, valueToAdd;
            if (!int.TryParse(txtProductID.Text, out productId) || !int.TryParse(txtUpdateInput.Text, out valueToAdd))
            {
                MessageBox.Show("Please provide valid numeric values for product ID and the value to add.");
                return;
            }

            // Get the current value from the database for the specific product
            string query = $"SELECT {columnToUpdate} FROM testing_product WHERE pro_id = @productId";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@productId", productId);
            int currentValue = 0; // Default value
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    currentValue = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching current value from the database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            // Calculate the new value
            int newValue = currentValue + valueToAdd;

            // Update the column in the database for the specific product
            query = $"UPDATE testing_product SET {columnToUpdate} = @newValue WHERE pro_id = @productId";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@newValue", newValue);
            command.Parameters.AddWithValue("@productId", productId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"Updated {rowsAffected} row(s) successfully.");
                LoadData(); // Reload the data in the DataGridView after updating
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating value in the database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
    }


