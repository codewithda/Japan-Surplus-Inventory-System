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
    public partial class Add : Form
    {
        public static readonly string connectionString = Class1.connection_string;

        private Form1 form1;
        public Add(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pdname = txtBoxName.Text;
            string pdinch = txtBoxInch.Text;
            string pdqty = txtBoxQty.Text;
            string pddesc = txtBoxDesc.Text;
            string pdprice = txtBoxPrice.Text;

            string connectionString = "server=127.0.0.1;user=root;database=testing_studio;password=";

            string mysqlconn = "INSERT INTO testing_product (pro_name, pro_inch, pro_price, pro_quantity, pro_description) " +
                   "VALUES (@pdname, @pdinch, @pdprice, @pdqty, @pddesc)";


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(mysqlconn, connection))
                    {

                        command.Parameters.AddWithValue("@pdname", pdname);
                        command.Parameters.AddWithValue("@pdinch", pdinch);
                        command.Parameters.AddWithValue("@pdprice", pdprice);

                        command.Parameters.AddWithValue("@pdqty", pdqty);
                        command.Parameters.AddWithValue("@pddesc", pddesc);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully!");

                            form1.LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add item.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
    }

