using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class ramenButtonFunction
    {
        /*public void btn1(int dineLoc, int qty)
        {
            try
            {
                string productName = "";
                int productPrice = 0;
                string productID = "r1";

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName = reader["name"].ToString();
                                productPrice = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }

                    // 2. Check if product already exists in the ordertable
                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product already in order table — update quantity
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + 1;
                            int newSubtotal = productPrice * newQty;

                            string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", newQty);
                                updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Product not in ordertable — insert new
                            string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productID", productID);
                                insertCmd.Parameters.AddWithValue("@name", productName);
                                insertCmd.Parameters.AddWithValue("@price", productPrice);
                                insertCmd.Parameters.AddWithValue("@qty", qty);
                                insertCmd.Parameters.AddWithValue("@sub", productPrice * qty);
                                insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void btn2(int dineLoc, int qty)
        {
            try
            {
                string productName = "";
                int productPrice = 0;
                string productID = "r2";

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName = reader["name"].ToString();
                                productPrice = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }

                    // 2. Check if product already exists in the ordertable
                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product already in order table — update quantity
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + 1;
                            int newSubtotal = productPrice * newQty;

                            string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", newQty);
                                updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Product not in ordertable — insert new
                            string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productID", productID);
                                insertCmd.Parameters.AddWithValue("@name", productName);
                                insertCmd.Parameters.AddWithValue("@price", productPrice);
                                insertCmd.Parameters.AddWithValue("@qty", qty);
                                insertCmd.Parameters.AddWithValue("@sub", productPrice * qty);
                                insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void btn3(int dineLoc, int qty)
        {
            try
            {
                string productName = "";
                int productPrice = 0;
                string productID = "r3";

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName = reader["name"].ToString();
                                productPrice = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }

                    // 2. Check if product already exists in the ordertable
                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product already in order table — update quantity
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + 1;
                            int newSubtotal = productPrice * newQty;

                            string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", newQty);
                                updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Product not in ordertable — insert new
                            string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productID", productID);
                                insertCmd.Parameters.AddWithValue("@name", productName);
                                insertCmd.Parameters.AddWithValue("@price", productPrice);
                                insertCmd.Parameters.AddWithValue("@qty", qty);
                                insertCmd.Parameters.AddWithValue("@sub", productPrice * qty);
                                insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void btn4(int dineLoc, int qty)
        {
            try
            {
                string productName = "";
                int productPrice = 0;
                string productID = "r4";

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName = reader["name"].ToString();
                                productPrice = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }

                    // 2. Check if product already exists in the ordertable
                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product already in order table — update quantity
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + 1;
                            int newSubtotal = productPrice * newQty;

                            string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", newQty);
                                updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Product not in ordertable — insert new
                            string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productID", productID);
                                insertCmd.Parameters.AddWithValue("@name", productName);
                                insertCmd.Parameters.AddWithValue("@price", productPrice);
                                insertCmd.Parameters.AddWithValue("@qty", qty);
                                insertCmd.Parameters.AddWithValue("@sub", productPrice * qty);
                                insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void btn5(int dineLoc, int qty)
        {
            try
            {
                string productName = "";
                int productPrice = 0;
                string productID = "r5";

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName = reader["name"].ToString();
                                productPrice = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }

                    // 2. Check if product already exists in the ordertable
                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product already in order table — update quantity
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + 1;
                            int newSubtotal = productPrice * newQty;

                            string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", newQty);
                                updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Product not in ordertable — insert new
                            string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productID", productID);
                                insertCmd.Parameters.AddWithValue("@name", productName);
                                insertCmd.Parameters.AddWithValue("@price", productPrice);
                                insertCmd.Parameters.AddWithValue("@qty", qty);
                                insertCmd.Parameters.AddWithValue("@sub", productPrice * qty);
                                insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void btn6(int dineLoc, int qty)
        {
            try
            {
                string productName = "";
                int productPrice = 0;
                string productID = "r6";

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName = reader["name"].ToString();
                                productPrice = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }

                    // 2. Check if product already exists in the ordertable
                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product already in order table — update quantity
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + 1;
                            int newSubtotal = productPrice * newQty;

                            string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", newQty);
                                updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Product not in ordertable — insert new
                            string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productID", productID);
                                insertCmd.Parameters.AddWithValue("@name", productName);
                                insertCmd.Parameters.AddWithValue("@price", productPrice);
                                insertCmd.Parameters.AddWithValue("@qty", qty);
                                insertCmd.Parameters.AddWithValue("@sub", productPrice * qty);
                                insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void btn7(int dineLoc, int qty)
        {
            try
            {
                string productName = "";
                int productPrice = 0;
                string productID = "r7";

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName = reader["name"].ToString();
                                productPrice = Convert.ToInt32(reader["price"]);
                            }
                            else
                            {
                                MessageBox.Show("Product not found.");
                                return;
                            }
                        }
                    }

                    // 2. Check if product already exists in the ordertable
                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productID);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Product already in order table — update quantity
                            int currentQty = Convert.ToInt32(result);
                            int newQty = currentQty + 1;
                            int newSubtotal = productPrice * newQty;

                            string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                            using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@qty", newQty);
                                updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Product not in ordertable — insert new
                            string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@productID", productID);
                                insertCmd.Parameters.AddWithValue("@name", productName);
                                insertCmd.Parameters.AddWithValue("@price", productPrice);
                                insertCmd.Parameters.AddWithValue("@qty", qty);
                                insertCmd.Parameters.AddWithValue("@sub", productPrice * qty);
                                insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }*/
    }
}
