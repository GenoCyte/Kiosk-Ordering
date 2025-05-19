using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class reviewOrder : UserControl
    {
        public event Action OnSwitchToOrder;
        public event Action OnSwitchToTy;
        public reviewOrder()
        {
            InitializeComponent();
            LoadOrdersToPanel();
        }

        private void LoadOrdersToPanel()
        {
            orderPanel.SuspendLayout();
            orderPanel.Controls.Clear();

            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"
                    SELECT o.id, o.productID, o.product, o.price, o.quantity, o.subTotal, r.picture 
                    FROM ordertable o 
                    JOIN ramen_product r ON o.productID = r.productId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                int yPos = 10;
                decimal total = 0;

                // Remove ToolTip, no need for it now
                orderPanel.Padding = new Padding(10, 10, 10, 50);

                // Spacer at top
                Panel spacer1 = new Panel();
                spacer1.Size = new Size(1, 10);
                spacer1.Location = new Point(0, 0);
                orderPanel.Controls.Add(spacer1);

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["id"]);
                    string product = reader["product"].ToString();
                    decimal price = Convert.ToDecimal(reader["price"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    decimal subtotal = Convert.ToDecimal(reader["subTotal"]);

                    string itemText = $"X{quantity} {product} | {price}";

                    // === Wrapper panel for entire item row ===
                    Panel itemPanel = new Panel();
                    itemPanel.Size = new Size(orderPanel.Width - 40, 100); // Adjust height to fit picture
                    itemPanel.Location = new Point(10, yPos);
                    itemPanel.BorderStyle = BorderStyle.None;

                    // PictureBox (size updated to 100x100)
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(100, 100); // Updated size
                    pictureBox.Location = new Point(0, 0); // Adjusted to fit within the itemPanel
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    if (reader["picture"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])reader["picture"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox.Image = Properties.Resources.PlaceHolder;
                    }

                    // Label wrapper
                    Panel labelWrapper = new Panel();
                    labelWrapper.Size = new Size(300, 100); // Adjusted to match pictureBox size
                    labelWrapper.Location = new Point(110, 0); // Adjusted to accommodate pictureBox

                    Label lbl = new Label();
                    lbl.Text = itemText;
                    lbl.Dock = DockStyle.Fill;
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Font = new Font("Segoe UI", 10);
                    labelWrapper.Controls.Add(lbl);

                    // Buttons wrapper panel
                    Panel buttonWrapper = new Panel();
                    buttonWrapper.Size = new Size(160, 100); // Adjusted to match itemPanel size
                    buttonWrapper.Location = new Point(itemPanel.Width - 170, 0); // Adjusted to fit buttons

                    // Subtract Button
                    Button btnSubtract = new Button();
                    btnSubtract.Text = "-";
                    btnSubtract.Size = new Size(30, 25);
                    btnSubtract.Location = new Point(0, 37); // Adjusted to center vertically
                    btnSubtract.Tag = new Tuple<int, decimal, int>(orderId, price, quantity);
                    btnSubtract.Click += SubtractQuantity_Click;

                    // Add Button
                    Button btnAdd = new Button();
                    btnAdd.Text = "+";
                    btnAdd.Size = new Size(30, 25);
                    btnAdd.Location = new Point(40, 37); // Adjusted to center vertically
                    btnAdd.Tag = new Tuple<int, decimal, int>(orderId, price, quantity);
                    btnAdd.Click += AddQuantity_Click;

                    // Remove Button
                    Button btnRemove = new Button();
                    btnRemove.Text = "Remove";
                    btnRemove.Size = new Size(75, 25);
                    btnRemove.Location = new Point(80, 37); // Adjusted to center vertically
                    btnRemove.Tag = orderId;
                    btnRemove.Click += RemoveButton_Click;

                    // Add buttons to wrapper
                    buttonWrapper.Controls.Add(btnSubtract);
                    buttonWrapper.Controls.Add(btnAdd);
                    buttonWrapper.Controls.Add(btnRemove);

                    // Add all to itemPanel
                    itemPanel.Controls.Add(pictureBox);
                    itemPanel.Controls.Add(labelWrapper);
                    itemPanel.Controls.Add(buttonWrapper);

                    // Add item panel to main panel
                    orderPanel.Controls.Add(itemPanel);

                    yPos += 110; // Increase space between items to accommodate larger picture size
                    total += subtotal;
                }

                // Spacer at bottom
                Panel spacer2 = new Panel();
                spacer2.Size = new Size(1, 20);
                spacer2.Location = new Point(0, yPos);
                orderPanel.Controls.Add(spacer2);

                reader.Close();
                conn.Close();

                totalLabel.Text = $"Total:  ₱{total:N2}";
            }

            orderPanel.ResumeLayout();
        }

        private void AddQuantity_Click(object sender, EventArgs e)
        {
            var data = (Tuple<int, decimal, int>)((Button)sender).Tag;
            int id = data.Item1;
            decimal price = data.Item2;
            int quantity = data.Item3 + 1;
            decimal subtotal = price * quantity;

            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@sub", subtotal);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadOrdersToPanel();
        }

        private void SubtractQuantity_Click(object sender, EventArgs e)
        {
            var data = (Tuple<int, decimal, int>)((Button)sender).Tag;
            int id = data.Item1;
            decimal price = data.Item2;
            int quantity = data.Item3 - 1;

            // Option 2: Clamp to minimum 1
            if (quantity < 1) quantity = 1;

            decimal subtotal = price * quantity;

            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "UPDATE ordertable SET quantity = @qty, subTotal = @sub WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@sub", subtotal);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadOrdersToPanel();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Button removeBtn = sender as Button;
            int orderId = (int)removeBtn.Tag;

            var confirm = MessageBox.Show("Are you sure you want to remove this item?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            RemoveOrderItem(orderId);
        }

        private void RemoveOrderItem(int id)
        {
            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "DELETE FROM ordertable WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadOrdersToPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSwitchToOrder?.Invoke();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            checkOut co = new checkOut();
            //co.CheckOut();
            co.DeleteOrderTable();
            OnSwitchToTy?.Invoke();
        }

        private void orderPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
