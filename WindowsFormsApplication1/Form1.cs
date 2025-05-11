using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private dinetakePanel dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStartPanel();
        }

        private void LoadUserControl(UserControl uc)
        {
            mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
        }

        private void LoadStartPanel()
        {
            var start = new startGui();
            start.OnSwitchToDineTake += LoadDineTakePanel;
            LoadUserControl(start);
        }

        private void LoadDineTakePanel()
        {
            dt = new dinetakePanel();
            dt.OnSwitchToOrder += LoadOrderPanel;
            LoadUserControl(dt);
        }

        private void LoadOrderPanel()
        {
            var order = new orderGui(dt);
            order.OnSwitchToStart += LoadStartPanel;
            order.OnSwitchToReview += LoadReviewPanel;
            order.OnSwitchToTy += LoadTyPanel;
            LoadUserControl(order);
        }

        private void LoadReviewPanel()
        {
            var review = new reviewOrder();
            review.OnSwitchToOrder += LoadOrderPanel;
            review.OnSwitchToTy += LoadTyPanel;
            LoadUserControl(review);
        }

        private void LoadTyPanel()
        {
            var ty = new thankyouPanel();
            ty.OnSwitchToStart += LoadStartPanel;
            LoadUserControl(ty);
        }
    }
}
