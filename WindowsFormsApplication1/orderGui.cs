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
            changePanel.Hide();
            ddPanel.Hide();
            totalOrderShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSwitchToStart?.Invoke();
        }

        private void ramenBtn_Click(object sender, EventArgs e)
        {
            ddPanel.Hide();
            ramenPanel.Show();
        }
        private void dndBtn_Click(object sender, EventArgs e)
        {
            ramenPanel.Hide();
            ddPanel.Show();
        }

        private void ramenBtn1_Click(object sender, EventArgs e)
        {
            changePanel.Show();
            changeQuantity("r1");
        }

        private void ramenBtn2_Click(object sender, EventArgs e)
        {
            changePanel.Show();
            changeQuantity("r2");
        }

        private void ramenBtn3_Click(object sender, EventArgs e)
        {
            changePanel.Show();
            changeQuantity("r3");
        }

        private void ramenBtn4_Click(object sender, EventArgs e)
        {
            changePanel.Show();
            changeQuantity("r4");
        }

        private void ramenBtn5_Click(object sender, EventArgs e)
        {
            changePanel.Show();
            changeQuantity("r5");
        }

        private void ramenBtn6_Click(object sender, EventArgs e)
        {
            changePanel.Show();
            changeQuantity("r6");
        }

        private void ramenBtn7_Click(object sender, EventArgs e)
        {
            changePanel.Show();
            changeQuantity("r7");
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
            switch (selectedProductId)
            {
                case "r1":
                    btn.btn1(dineLoc, currentQuantity);
                    break;
                case "r2":
                    btn.btn2(dineLoc, currentQuantity);
                    break;
                case "r3":
                    btn.btn3(dineLoc, currentQuantity);
                    break;
                case "r4":
                    btn.btn4(dineLoc, currentQuantity);
                    break;
                case "r5":
                    btn.btn5(dineLoc, currentQuantity);
                    break;
                case "r6":
                    btn.btn6(dineLoc, currentQuantity);
                    break;
                case "r7":
                    btn.btn7(dineLoc, currentQuantity);
                    break;
                default:
                    MessageBox.Show("Unknown product selected.");
                    return;
            }

            totalOrderShow();
            changePanel.Hide();
            currentQuantity = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changePanel.Hide();
        }
    }
}
