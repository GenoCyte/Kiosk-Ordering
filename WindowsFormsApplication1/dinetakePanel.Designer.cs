namespace WindowsFormsApplication1
{
    partial class dinetakePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dinetakePanel));
            this.label1 = new System.Windows.Forms.Label();
            this.dineinBtn = new System.Windows.Forms.Button();
            this.takeoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(209, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinning Location";
            // 
            // dineinBtn
            // 
            this.dineinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dineinBtn.BackgroundImage")));
            this.dineinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dineinBtn.Location = new System.Drawing.Point(54, 247);
            this.dineinBtn.Name = "dineinBtn";
            this.dineinBtn.Size = new System.Drawing.Size(256, 310);
            this.dineinBtn.TabIndex = 1;
            this.dineinBtn.UseVisualStyleBackColor = true;
            this.dineinBtn.Click += new System.EventHandler(this.dineinBtn_Click);
            // 
            // takeoutBtn
            // 
            this.takeoutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("takeoutBtn.BackgroundImage")));
            this.takeoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.takeoutBtn.Location = new System.Drawing.Point(373, 247);
            this.takeoutBtn.Name = "takeoutBtn";
            this.takeoutBtn.Size = new System.Drawing.Size(256, 310);
            this.takeoutBtn.TabIndex = 2;
            this.takeoutBtn.UseVisualStyleBackColor = true;
            this.takeoutBtn.Click += new System.EventHandler(this.takeoutBtn_Click);
            // 
            // dinetakePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.takeoutBtn);
            this.Controls.Add(this.dineinBtn);
            this.Controls.Add(this.label1);
            this.Name = "dinetakePanel";
            this.Size = new System.Drawing.Size(682, 745);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dineinBtn;
        private System.Windows.Forms.Button takeoutBtn;
    }
}
