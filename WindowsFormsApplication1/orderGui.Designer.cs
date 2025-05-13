namespace WindowsFormsApplication1
{
    partial class orderGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderGui));
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ramenBtn = new System.Windows.Forms.Button();
            this.dndBtn = new System.Windows.Forms.Button();
            this.orderHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.totalOrderPanel = new System.Windows.Forms.Panel();
            this.viewOrder = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalItemLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.noOrdersPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.ramenPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ramenBtn7 = new System.Windows.Forms.Button();
            this.ramenBtn4 = new System.Windows.Forms.Button();
            this.ramenBtn5 = new System.Windows.Forms.Button();
            this.ramenBtn6 = new System.Windows.Forms.Button();
            this.ramenBtn3 = new System.Windows.Forms.Button();
            this.ramenBtn2 = new System.Windows.Forms.Button();
            this.ramenBtn1 = new System.Windows.Forms.Button();
            this.ddPanel = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.dineLocLabel = new System.Windows.Forms.Label();
            this.changePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.qty = new System.Windows.Forms.Label();
            this.subBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.productPrice = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.orderHeader.SuspendLayout();
            this.totalOrderPanel.SuspendLayout();
            this.noOrdersPanel.SuspendLayout();
            this.ramenPanel.SuspendLayout();
            this.ddPanel.SuspendLayout();
            this.changePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bannerPanel.BackgroundImage")));
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(682, 115);
            this.bannerPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(162, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 300);
            this.label1.TabIndex = 2;
            // 
            // ramenBtn
            // 
            this.ramenBtn.Location = new System.Drawing.Point(32, 198);
            this.ramenBtn.Name = "ramenBtn";
            this.ramenBtn.Size = new System.Drawing.Size(100, 77);
            this.ramenBtn.TabIndex = 3;
            this.ramenBtn.Text = "RAMEN";
            this.ramenBtn.UseVisualStyleBackColor = true;
            this.ramenBtn.Click += new System.EventHandler(this.ramenBtn_Click);
            // 
            // dndBtn
            // 
            this.dndBtn.Location = new System.Drawing.Point(32, 306);
            this.dndBtn.Name = "dndBtn";
            this.dndBtn.Size = new System.Drawing.Size(100, 77);
            this.dndBtn.TabIndex = 4;
            this.dndBtn.Text = "DRINKS AND DESSERTS";
            this.dndBtn.UseVisualStyleBackColor = true;
            this.dndBtn.Click += new System.EventHandler(this.dndBtn_Click);
            // 
            // orderHeader
            // 
            this.orderHeader.BackColor = System.Drawing.Color.Red;
            this.orderHeader.Controls.Add(this.label2);
            this.orderHeader.Location = new System.Drawing.Point(0, 539);
            this.orderHeader.Name = "orderHeader";
            this.orderHeader.Size = new System.Drawing.Size(682, 30);
            this.orderHeader.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your Order";
            // 
            // totalOrderPanel
            // 
            this.totalOrderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOrderPanel.Controls.Add(this.viewOrder);
            this.totalOrderPanel.Controls.Add(this.totalPriceLabel);
            this.totalOrderPanel.Controls.Add(this.totalItemLabel);
            this.totalOrderPanel.Controls.Add(this.label7);
            this.totalOrderPanel.Controls.Add(this.label6);
            this.totalOrderPanel.Controls.Add(this.label5);
            this.totalOrderPanel.Location = new System.Drawing.Point(5, 573);
            this.totalOrderPanel.Name = "totalOrderPanel";
            this.totalOrderPanel.Size = new System.Drawing.Size(672, 100);
            this.totalOrderPanel.TabIndex = 6;
            // 
            // viewOrder
            // 
            this.viewOrder.AutoSize = true;
            this.viewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrder.Location = new System.Drawing.Point(523, 38);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(125, 20);
            this.viewOrder.TabIndex = 13;
            this.viewOrder.Text = "View Your Order";
            this.viewOrder.Click += new System.EventHandler(this.viewOrder_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(60, 38);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(29, 20);
            this.totalPriceLabel.TabIndex = 12;
            this.totalPriceLabel.Text = "₱0";
            // 
            // totalItemLabel
            // 
            this.totalItemLabel.AutoSize = true;
            this.totalItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemLabel.Location = new System.Drawing.Point(173, 38);
            this.totalItemLabel.Name = "totalItemLabel";
            this.totalItemLabel.Size = new System.Drawing.Size(18, 20);
            this.totalItemLabel.TabIndex = 11;
            this.totalItemLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(119, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 80);
            this.label7.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Items:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total:";
            // 
            // noOrdersPanel
            // 
            this.noOrdersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noOrdersPanel.Controls.Add(this.label11);
            this.noOrdersPanel.Location = new System.Drawing.Point(5, 573);
            this.noOrdersPanel.Name = "noOrdersPanel";
            this.noOrdersPanel.Size = new System.Drawing.Size(672, 100);
            this.noOrdersPanel.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(206, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Your Order Is Empty";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(76, 685);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(169, 37);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel Order";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Lime;
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(415, 685);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(169, 37);
            this.doneBtn.TabIndex = 8;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // ramenPanel
            // 
            this.ramenPanel.Controls.Add(this.label3);
            this.ramenPanel.Controls.Add(this.ramenBtn7);
            this.ramenPanel.Controls.Add(this.ramenBtn4);
            this.ramenPanel.Controls.Add(this.ramenBtn5);
            this.ramenPanel.Controls.Add(this.ramenBtn6);
            this.ramenPanel.Controls.Add(this.ramenBtn3);
            this.ramenPanel.Controls.Add(this.ramenBtn2);
            this.ramenPanel.Controls.Add(this.ramenBtn1);
            this.ramenPanel.Location = new System.Drawing.Point(183, 117);
            this.ramenPanel.Name = "ramenPanel";
            this.ramenPanel.Size = new System.Drawing.Size(485, 410);
            this.ramenPanel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ramen";
            // 
            // ramenBtn7
            // 
            this.ramenBtn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramenBtn7.BackgroundImage")));
            this.ramenBtn7.Location = new System.Drawing.Point(33, 304);
            this.ramenBtn7.Name = "ramenBtn7";
            this.ramenBtn7.Size = new System.Drawing.Size(100, 100);
            this.ramenBtn7.TabIndex = 16;
            this.ramenBtn7.UseVisualStyleBackColor = true;
            this.ramenBtn7.Click += new System.EventHandler(this.ramenBtn7_Click);
            // 
            // ramenBtn4
            // 
            this.ramenBtn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramenBtn4.BackgroundImage")));
            this.ramenBtn4.Location = new System.Drawing.Point(33, 178);
            this.ramenBtn4.Name = "ramenBtn4";
            this.ramenBtn4.Size = new System.Drawing.Size(100, 100);
            this.ramenBtn4.TabIndex = 15;
            this.ramenBtn4.UseVisualStyleBackColor = true;
            this.ramenBtn4.Click += new System.EventHandler(this.ramenBtn4_Click);
            // 
            // ramenBtn5
            // 
            this.ramenBtn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramenBtn5.BackgroundImage")));
            this.ramenBtn5.Location = new System.Drawing.Point(191, 178);
            this.ramenBtn5.Name = "ramenBtn5";
            this.ramenBtn5.Size = new System.Drawing.Size(100, 100);
            this.ramenBtn5.TabIndex = 14;
            this.ramenBtn5.UseVisualStyleBackColor = true;
            this.ramenBtn5.Click += new System.EventHandler(this.ramenBtn5_Click);
            // 
            // ramenBtn6
            // 
            this.ramenBtn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramenBtn6.BackgroundImage")));
            this.ramenBtn6.Location = new System.Drawing.Point(347, 178);
            this.ramenBtn6.Name = "ramenBtn6";
            this.ramenBtn6.Size = new System.Drawing.Size(100, 100);
            this.ramenBtn6.TabIndex = 13;
            this.ramenBtn6.UseVisualStyleBackColor = true;
            this.ramenBtn6.Click += new System.EventHandler(this.ramenBtn6_Click);
            // 
            // ramenBtn3
            // 
            this.ramenBtn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramenBtn3.BackgroundImage")));
            this.ramenBtn3.Location = new System.Drawing.Point(347, 53);
            this.ramenBtn3.Name = "ramenBtn3";
            this.ramenBtn3.Size = new System.Drawing.Size(100, 100);
            this.ramenBtn3.TabIndex = 12;
            this.ramenBtn3.UseVisualStyleBackColor = true;
            this.ramenBtn3.Click += new System.EventHandler(this.ramenBtn3_Click);
            // 
            // ramenBtn2
            // 
            this.ramenBtn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramenBtn2.BackgroundImage")));
            this.ramenBtn2.Location = new System.Drawing.Point(191, 53);
            this.ramenBtn2.Name = "ramenBtn2";
            this.ramenBtn2.Size = new System.Drawing.Size(100, 100);
            this.ramenBtn2.TabIndex = 11;
            this.ramenBtn2.UseVisualStyleBackColor = true;
            this.ramenBtn2.Click += new System.EventHandler(this.ramenBtn2_Click);
            // 
            // ramenBtn1
            // 
            this.ramenBtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramenBtn1.BackgroundImage")));
            this.ramenBtn1.Location = new System.Drawing.Point(33, 53);
            this.ramenBtn1.Name = "ramenBtn1";
            this.ramenBtn1.Size = new System.Drawing.Size(100, 100);
            this.ramenBtn1.TabIndex = 10;
            this.ramenBtn1.UseVisualStyleBackColor = true;
            this.ramenBtn1.Click += new System.EventHandler(this.ramenBtn1_Click);
            // 
            // ddPanel
            // 
            this.ddPanel.Controls.Add(this.button15);
            this.ddPanel.Controls.Add(this.button14);
            this.ddPanel.Controls.Add(this.button13);
            this.ddPanel.Controls.Add(this.button12);
            this.ddPanel.Controls.Add(this.button11);
            this.ddPanel.Controls.Add(this.button10);
            this.ddPanel.Controls.Add(this.button9);
            this.ddPanel.Controls.Add(this.label4);
            this.ddPanel.Controls.Add(this.button8);
            this.ddPanel.Location = new System.Drawing.Point(183, 116);
            this.ddPanel.Name = "ddPanel";
            this.ddPanel.Size = new System.Drawing.Size(485, 410);
            this.ddPanel.TabIndex = 10;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(191, 304);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 100);
            this.button15.TabIndex = 25;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(33, 304);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 100);
            this.button14.TabIndex = 24;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(347, 177);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 23;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(191, 178);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 22;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(33, 178);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 21;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(347, 53);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 100);
            this.button10.TabIndex = 20;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(191, 53);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 19;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Drinks and Desserts";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(33, 53);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dineLocLabel
            // 
            this.dineLocLabel.AutoSize = true;
            this.dineLocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineLocLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dineLocLabel.Location = new System.Drawing.Point(18, 131);
            this.dineLocLabel.Name = "dineLocLabel";
            this.dineLocLabel.Size = new System.Drawing.Size(38, 24);
            this.dineLocLabel.TabIndex = 11;
            this.dineLocLabel.Text = "zxz";
            // 
            // changePanel
            // 
            this.changePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changePanel.Controls.Add(this.button1);
            this.changePanel.Controls.Add(this.addItemBtn);
            this.changePanel.Controls.Add(this.qty);
            this.changePanel.Controls.Add(this.subBtn);
            this.changePanel.Controls.Add(this.addBtn);
            this.changePanel.Controls.Add(this.productPrice);
            this.changePanel.Controls.Add(this.productName);
            this.changePanel.Controls.Add(this.productImage);
            this.changePanel.Location = new System.Drawing.Point(0, 356);
            this.changePanel.Name = "changePanel";
            this.changePanel.Size = new System.Drawing.Size(682, 180);
            this.changePanel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(613, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 46);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.Red;
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addItemBtn.Location = new System.Drawing.Point(549, 108);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(90, 35);
            this.addItemBtn.TabIndex = 6;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // qty
            // 
            this.qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(229, 108);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(86, 35);
            this.qty.TabIndex = 5;
            this.qty.Text = "0";
            this.qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subBtn
            // 
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(191, 108);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(35, 35);
            this.subBtn.TabIndex = 4;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(321, 108);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(35, 35);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(186, 64);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(60, 24);
            this.productPrice.TabIndex = 2;
            this.productPrice.Text = "label8";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(186, 23);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(70, 25);
            this.productName.TabIndex = 1;
            this.productName.Text = "label8";
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(21, 23);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(130, 130);
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // orderGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changePanel);
            this.Controls.Add(this.dineLocLabel);
            this.Controls.Add(this.noOrdersPanel);
            this.Controls.Add(this.ddPanel);
            this.Controls.Add(this.ramenPanel);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.totalOrderPanel);
            this.Controls.Add(this.orderHeader);
            this.Controls.Add(this.dndBtn);
            this.Controls.Add(this.ramenBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bannerPanel);
            this.Name = "orderGui";
            this.Size = new System.Drawing.Size(682, 745);
            this.orderHeader.ResumeLayout(false);
            this.orderHeader.PerformLayout();
            this.totalOrderPanel.ResumeLayout(false);
            this.totalOrderPanel.PerformLayout();
            this.noOrdersPanel.ResumeLayout(false);
            this.noOrdersPanel.PerformLayout();
            this.ramenPanel.ResumeLayout(false);
            this.ramenPanel.PerformLayout();
            this.ddPanel.ResumeLayout(false);
            this.ddPanel.PerformLayout();
            this.changePanel.ResumeLayout(false);
            this.changePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ramenBtn;
        private System.Windows.Forms.Button dndBtn;
        private System.Windows.Forms.Panel orderHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel totalOrderPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Panel ramenPanel;
        private System.Windows.Forms.Button ramenBtn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ramenBtn7;
        private System.Windows.Forms.Button ramenBtn4;
        private System.Windows.Forms.Button ramenBtn5;
        private System.Windows.Forms.Button ramenBtn6;
        private System.Windows.Forms.Button ramenBtn3;
        private System.Windows.Forms.Button ramenBtn2;
        private System.Windows.Forms.Panel ddPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalItemLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label viewOrder;
        private System.Windows.Forms.Panel noOrdersPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dineLocLabel;
        private System.Windows.Forms.Panel changePanel;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label qty;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button button1;
    }
}
