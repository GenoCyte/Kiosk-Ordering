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
            btn.btn1(dineLoc);
            totalOrderShow();
        }

        private void ramenBtn2_Click(object sender, EventArgs e)
        {
            btn.btn2(dineLoc);
            totalOrderShow();
        }

        private void ramenBtn3_Click(object sender, EventArgs e)
        {
            btn.btn3(dineLoc);
            totalOrderShow();
        }

        private void ramenBtn4_Click(object sender, EventArgs e)
        {
            btn.btn4(dineLoc);
            totalOrderShow();
        }

        private void ramenBtn5_Click(object sender, EventArgs e)
        {
            btn.btn5(dineLoc);
            totalOrderShow();
        }

        private void ramenBtn6_Click(object sender, EventArgs e)
        {
            btn.btn6(dineLoc);
            totalOrderShow();
        }

        private void ramenBtn7_Click(object sender, EventArgs e)
        {
            btn.btn7(dineLoc);
            totalOrderShow();
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
    }
}
