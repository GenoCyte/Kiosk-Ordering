using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class items
    {
        public int orderID = 0;
        public string productID = "";
        public string productName = "";
        public int productPrice = 0;
        public int quantity = 0;
        public int subTotal = 0;
        public int dineLoc = 0;
    }

    class checkOut
    {
        // List to store all items
        public List<items> orders = new List<items>();

        public void DeleteOrderTable()
        {
            try
            {
                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string query = "DELETE FROM ordertable";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        // Method to get items from the database and store in the orders list
        public void GetItems()
        {
            orders.Clear(); // Clear previous orders before adding new ones
            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT productID, product, quantity, subTotal, dine_loc FROM ordertable";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items order = new items();
                        order.productID = reader["productID"].ToString();
                        order.productName = reader["product"].ToString();
                        order.quantity = Convert.ToInt32(reader["quantity"]);
                        order.subTotal = Convert.ToInt32(reader["subTotal"]);
                        order.dineLoc = Convert.ToInt32(reader["dine_loc"]);

                        orders.Add(order); // Add the order to the list
                    }
                }
            }
        }

        public int FindAvailableID(int order_id)
        {
            List<int> usedIds = new List<int>();
            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT orderID FROM current_order";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usedIds.Add(reader.GetInt32(0));
                    }
                }
            }

            // Find the first missing number starting from 1
            int current = 1;
            HashSet<int> usedSet = new HashSet<int>(usedIds);

            while (usedSet.Contains(current))
            {
                current++;
            }

            return current;
        }

        // Method to insert the orders into another table (current_order)
        public void CheckOut()
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            items orderID = new items();
            int availableID = FindAvailableID(orderID.orderID);
            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                foreach (var order in orders) // Loop through the list of orders
                {
                    // Insert query
                    string insertQuery = "INSERT INTO current_order (orderID, productID, product, quantity, subTotal, dine_loc, time) VALUES (@orderID, @productID, @product, @quantity, @subTotal, @dine_loc, @time)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        // Adding parameters
                        cmd.Parameters.AddWithValue("@orderID", availableID);
                        cmd.Parameters.AddWithValue("@productID", order.productID);
                        cmd.Parameters.AddWithValue("@product", order.productName); // Correct field name
                        cmd.Parameters.AddWithValue("@quantity", order.quantity);
                        cmd.Parameters.AddWithValue("@subTotal", order.subTotal);
                        cmd.Parameters.AddWithValue("@dine_loc", order.dineLoc);
                        cmd.Parameters.AddWithValue("@time", currentTime);

                        // Execute the insert for each order in the list
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            ReceiptControl rc = new ReceiptControl(availableID);
            rc.ExportAsImage("C:\\Users\\Arlzer\\Documents\\receipt.png");
        }
    }
}
