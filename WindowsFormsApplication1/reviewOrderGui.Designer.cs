namespace WindowsFormsApplication1
{
    partial class reviewOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reviewOrder));
            this.orderPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBtn = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderPanel
            // 
            this.orderPanel.AutoScroll = true;
            this.orderPanel.BackColor = System.Drawing.Color.White;
            this.orderPanel.Location = new System.Drawing.Point(22, 122);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(641, 504);
            this.orderPanel.TabIndex = 0;
            this.orderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.orderPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 122);
            this.panel2.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(427, 675);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(176, 37);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Proceed to Check Out";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.totalLabel.Location = new System.Drawing.Point(518, 642);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(57, 20);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reviewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.orderPanel);
            this.Name = "reviewOrder";
            this.Size = new System.Drawing.Size(682, 745);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button button1;
    }
}
