using MySql.Data.MySqlClient; 
using System.Data;
/*
ini-import yung nampespaces para mag work with 
MySQL database connections at data table. LINE 1-2
*/

/*
partial class na nag rerepresent 
ng main form ng application. LINE 12-14
*/
namespace JP_Surplus
{
    public partial class Form1 : Form
    {
        //private field "connectionString" is declared par mag store 
        //yung connection string para sa MySQL database. initialize yun with a value na 
        //retrieved from some source. probably another class "Add"
        private readonly string connectionString = Add.connectionString;
        /*
        constructor ng form1 class. initializes the form components 
        tapos cinacall yung LoadData() method to load data sa form
        */
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save2 save2 = new Save2();
            save2.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Edit2 edit2 = new Edit2();
            edit2.Show();

            this.Hide();
        }


        public void LoadData()
        {
            //this retrieves the connection string from some 
            //external source a class named "Add" at inassign sa "connectionString" variable
            string connectionString = Add.connectionString;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    /*after ma open yung db connection, it prepares SQL query string para ma select lahat ng records
                    from the "testing_product" table. Tapos creates new instance ng "MySqlCommand" class with 
                    query at connection. itong command is used para i-execute yung sql query sa db
                    LINE 69-71
                    */
                    connection.Open();
                    string query = "SELECT * FROM testing_product";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        /*
                        sa loob ng "using" block, it creates new instance ng "MySqlDataAdapter" class kasama command. 
                        Itong adapter is used para ma fill yung "DataTable" with data retrieved from the database using the 
                        "Fill" method. Tapos it sets yung "DataSource" property ng "DataGridView" control named "dataGridView1" 
                        to fill the "DataTable" effectively displaying the retrieved data in the DataGridView
                        */
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

        private void button4_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"SELECT * FROM testing_product 
                             WHERE pro_name LIKE @searchText 
                             OR pro_inch LIKE @searchText 
                             OR pro_quantity = @searchTextNumeric 
                             OR pro_price = @searchTextNumeric 
                             OR pro_description LIKE @searchText ";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                            if (decimal.TryParse(searchText, out decimal searchTextNumeric))
                            {
                                command.Parameters.AddWithValue("@searchTextNumeric", searchTextNumeric);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@searchTextNumeric", DBNull.Value);
                            }

                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Check if any rows were returned
                                if (dataTable.Rows.Count == 0)
                                {
                                    MessageBox.Show("Item not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                dataGridView1.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

