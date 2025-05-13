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
    public partial class ReceiptControl : UserControl
    {
        int orderId;
        public ReceiptControl(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.BackColor = Color.White;
            DrawReceipt();
            Console.WriteLine("Reciept Created");
        }

        private void DrawReceipt()
        {
            string connStr = "Server=localhost;Database=pos_database;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"
            SELECT product, quantity 
            FROM ordertable";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Set up itemPanel as a TableLayoutPanel
                itemPanel.ColumnCount = 2;
                itemPanel.RowCount = 0;
                itemPanel.AutoSize = true;

                int rowIndex = 0;

                while (reader.Read())
                {
                    string productName = reader["product"].ToString();
                    int quantity = Convert.ToInt32(reader["quantity"]);

                    Label item = new Label();
                    item.Text = productName;
                    item.TextAlign = ContentAlignment.MiddleLeft;
                    item.Font = new Font("Segoe UI", 10);
                    item.Dock = DockStyle.Fill;

                    Label qty = new Label();
                    qty.Text = quantity.ToString();
                    qty.TextAlign = ContentAlignment.MiddleCenter;
                    qty.Font = new Font("Segoe UI", 10);
                    qty.Dock = DockStyle.Fill;

                    // Add a new row and then add the labels
                    itemPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    itemPanel.RowCount += 1;
                    itemPanel.Controls.Add(qty, 0, rowIndex);
                    itemPanel.Controls.Add(item, 1, rowIndex);

                    rowIndex++;
                }
            }

            orderID.Text = orderId.ToString();
            this.Controls.Add(orderID);
            this.Controls.Add(itemPanel);
        }


        public void ExportAsImage(string path)
        {
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                bmp.Save(path);
            }
        }

        private void qtyLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
