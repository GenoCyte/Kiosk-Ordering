using System;

namespace WindowsFormsApplication1
{
    partial class ReceiptControl
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
            this.orderID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // orderID
            // 
            this.orderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderID.Location = new System.Drawing.Point(3, 24);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(525, 39);
            this.orderID.TabIndex = 0;
            this.orderID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please take this ticket to the counter";
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLabel.Location = new System.Drawing.Point(77, 171);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(36, 16);
            this.qtyLabel.TabIndex = 2;
            this.qtyLabel.Text = "QTY";
            this.qtyLabel.Click += new System.EventHandler(this.qtyLabel_Click);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(199, 171);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(40, 16);
            this.itemLabel.TabIndex = 3;
            this.itemLabel.Text = "ITEM";
            // 
            // itemPanel
            // 
            this.itemPanel.ColumnCount = 2;
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.06801F));
            this.itemPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.93199F));
            this.itemPanel.Location = new System.Drawing.Point(43, 210);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.RowCount = 2;
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.65854F));
            this.itemPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.34146F));
            this.itemPanel.Size = new System.Drawing.Size(397, 43);
            this.itemPanel.TabIndex = 4;
            // 
            // ReceiptControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderID);
            this.Name = "ReceiptControl";
            this.Size = new System.Drawing.Size(531, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.TableLayoutPanel itemPanel;
    }
}
