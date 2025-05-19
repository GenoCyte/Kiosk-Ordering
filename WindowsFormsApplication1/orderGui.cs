using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class orderGui : UserControl
    {
        public event Action OnSwitchToStart;
        public event Action OnSwitchToReview;
        public event Action OnSwitchToTy;
        ramenButtonFunction btn = new ramenButtonFunction();
        checkOut co = new checkOut();
        private dinetakePanel dtPanel;
        public int dineLoc = 0;
        private string selectedProductId = "";
        int currentQuantity = 1;

        public orderGui(dinetakePanel dt)
        {
            InitializeComponent();
            dtPanel = dt;

            dineLoc = dtPanel.dineLoc;
            if (dineLoc == 1)
            {
                dineLocLabel.Text = "Dine-In";
            }
            else
            {
                dineLocLabel.Text = "Take-Out";
            }
            LoadRamenButtons();
            changePanel.Hide();
            totalOrderShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSwitchToStart?.Invoke();
        }

        private void ramenBtn_Click(object sender, EventArgs e)
        {
            ramenPanel.Show();
        }
        private void dndBtn_Click(object sender, EventArgs e)
        {
            ramenPanel.Hide();
        }

        private void LoadRamenButtons()
        {
            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
            string query = "SELECT productId, picture FROM ramen_product";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productId = reader["productId"].ToString();
                            Image productImg;

                            // Load image from database
                            if (reader["picture"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])reader["picture"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    productImg = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                productImg = Properties.Resources.PlaceHolder;
                            }

                            // Create PictureBox
                            PictureBox pic = new PictureBox();
                            pic.Size = new Size(105, 105);
                            pic.SizeMode = PictureBoxSizeMode.Zoom;
                            pic.Image = productImg;
                            pic.Margin = new Padding(10);
                            pic.Cursor = Cursors.Hand;
                            pic.Tag = productId;
                            pic.Click += RamenButton_Click;

                            // Add to the panel
                            ramenPanel.Controls.Add(pic);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load ramen buttons: " + ex.Message);
            }
        }

        private void RamenButton_Click(object sender, EventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;
            if (clickedPic != null && clickedPic.Tag != null)
            {
                selectedProductId = clickedPic.Tag.ToString();
                changePanel.Show();
                changeQuantity(selectedProductId);
            }
        }

        private void RamenButton_Function()
        {
            string productId = selectedProductId;
            try
            {
                string productName = "";
                int productPrice = 0;

                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // 1. Get product info
                    string productQuery = "SELECT name, price FROM ramen_product WHERE productID = @ProductID";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
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

                    string checkOrderQuery = "SELECT quantity FROM ordertable WHERE productID = @ProductID";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkOrderQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ProductID", productId);
                        TimeSpan time = DateTime.Now.TimeOfDay;

                        using (MySqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int currentQty = Convert.ToInt32(reader["quantity"]);
                                int newQty = currentQty + currentQuantity;
                                int newSubtotal = productPrice * newQty;

                                reader.Close(); // Must close reader before executing another command on the same connection

                                string updateQuery = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE productID = @ProductID";
                                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@qty", newQty);
                                    updateCmd.Parameters.AddWithValue("@sub", newSubtotal);
                                    updateCmd.Parameters.AddWithValue("@ProductID", productId);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                reader.Close(); // Must close reader before executing another command
                                string insertQuery = "INSERT INTO ordertable (productID, product, price, quantity, subTotal, dine_loc) VALUES (@productID, @name, @price, @qty, @sub, @dine)";
                                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@productID", productId);
                                    insertCmd.Parameters.AddWithValue("@name", productName);
                                    insertCmd.Parameters.AddWithValue("@price", productPrice);
                                    insertCmd.Parameters.AddWithValue("@qty", currentQuantity);
                                    insertCmd.Parameters.AddWithValue("@sub", productPrice * currentQuantity);
                                    insertCmd.Parameters.AddWithValue("@dine", dineLoc);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void changeQuantity(string productId)
        {
            selectedProductId = productId;
            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"
                    SELECT name, price, picture
                    FROM ramen_product
                    WHERE productId = @productId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productId", productId);
                conn.Open();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string product = reader["name"].ToString();
                        decimal price = Convert.ToDecimal(reader["price"]);

                        if (reader["picture"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["picture"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                productImage.Image = Image.FromStream(ms);
                                productImage.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        else
                        {
                            productImage.Image = Properties.Resources.PlaceHolder;
                        }

                        productName.Text = product;
                        productPrice.Text = "₱" + price.ToString("F2");
                        qty.Text = currentQuantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
            }
        }

        private void totalOrderShow() {
            try {
                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string productQuery = "SELECT * FROM ordertable";
                    using (MySqlCommand cmd = new MySqlCommand(productQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            noOrdersPanel.Hide();
                            totalOrderPanel.Show();
                        }
                        else {
                            totalOrderPanel.Hide();
                            noOrdersPanel.Show();
                        }
                    }
                }
            }
            catch (Exception e) {
                MessageBox.Show("Error: " + e.Message);
            }
            changeTotalOrder();
        }

        private void changeTotalOrder() {
            totalOrderPanel.SuspendLayout();
            try
            {
                string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    int totalItem = 0;
                    int total = 0;

                    string query = "SELECT quantity, subTotal FROM ordertable";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) {
                        int quantity = Convert.ToInt32(reader["quantity"]);
                        int subTotal = Convert.ToInt32(reader["subTotal"]);

                        totalItem += quantity;
                        total += subTotal;
                    }
                    totalPriceLabel.Text = Convert.ToString("₱" + total);
                    totalItemLabel.Text = Convert.ToString(totalItem);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void viewOrder_Click(object sender, EventArgs e)
        {
            OnSwitchToReview?.Invoke();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this order?","Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                co.DeleteOrderTable();
                OnSwitchToStart?.Invoke();
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            co.GetItems();
            co.CheckOut();
            co.DeleteOrderTable();
            OnSwitchToTy?.Invoke();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            currentQuantity++;
            qty.Text = currentQuantity.ToString();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (currentQuantity > 1)
                currentQuantity--;
            qty.Text = currentQuantity.ToString();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            RamenButton_Function();
            totalOrderShow();
            changePanel.Hide();
            currentQuantity = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changePanel.Hide();
        }

        private void changePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
