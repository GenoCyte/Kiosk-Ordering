using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class dinetakePanel : UserControl
    {
        public int dineLoc;
        public event Action OnSwitchToOrder;

        public dinetakePanel()
        {
            InitializeComponent();
        }

        private void dineinBtn_Click(object sender, EventArgs e)
        {
            dineLoc = 1;
            OnSwitchToOrder?.Invoke();
        }

        private void takeoutBtn_Click(object sender, EventArgs e)
        {
            dineLoc = 2;
            OnSwitchToOrder?.Invoke();
        }
    }
}
