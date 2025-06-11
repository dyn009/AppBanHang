using AppBanHang.Views.Controls.UIControl;

namespace AppBanHang.Views.Controls
{
    partial class SellingControl
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
            pnListOrder = new Panel();
            btnAddOrderInShop = new ButtonControl();
            btnAddOrderBring = new ButtonControl();
            flpListOrder = new FlowLayoutPanel();
            label1 = new Label();
            loOrder = new SplitContainer();
            btnToPay = new ButtonControl();
            productOrder = new Panel();
            flpProductOrder = new FlowLayoutPanel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lstProducts = new AntdUI.In.FlowLayoutPanel();
            lvProducts = new ListView();
            clName = new ColumnHeader();
            clPrice = new ColumnHeader();
            label2 = new Label();
            lblChoses = new Label();
            btnPayInQr = new ButtonControl();
            btnPayInMoney = new ButtonControl();
            label14 = new Label();
            cbDiscount = new ComboBox();
            cbTable = new ComboBox();
            lblTime = new Label();
            label22 = new Label();
            lblDiscount = new Label();
            lblService = new Label();
            label18 = new Label();
            lblVAT = new Label();
            lblTotal = new Label();
            lblIntoMoney = new Label();
            lblDate = new Label();
            label13 = new Label();
            label20 = new Label();
            txtCustomerCode = new CustomControls.RJControls.RJTextBox();
            label19 = new Label();
            label17 = new Label();
            label21 = new Label();
            label16 = new Label();
            label15 = new Label();
            label12 = new Label();
            label11 = new Label();
            lvBill = new ListView();
            clBillName = new ColumnHeader();
            clBillSize = new ColumnHeader();
            clBillPrice = new ColumnHeader();
            clBillQuality = new ColumnHeader();
            clBillTotal = new ColumnHeader();
            lblIdInvoice = new Label();
            lblId = new Label();
            lblPay = new Label();
            pnListOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loOrder).BeginInit();
            loOrder.Panel1.SuspendLayout();
            loOrder.Panel2.SuspendLayout();
            loOrder.SuspendLayout();
            productOrder.SuspendLayout();
            SuspendLayout();
            // 
            // pnListOrder
            // 
            pnListOrder.AutoScroll = true;
            pnListOrder.BackColor = Color.White;
            pnListOrder.Controls.Add(btnAddOrderInShop);
            pnListOrder.Controls.Add(btnAddOrderBring);
            pnListOrder.Controls.Add(flpListOrder);
            pnListOrder.Controls.Add(label1);
            pnListOrder.Dock = DockStyle.Left;
            pnListOrder.Location = new Point(0, 0);
            pnListOrder.Name = "pnListOrder";
            pnListOrder.Size = new Size(537, 941);
            pnListOrder.TabIndex = 0;
            // 
            // btnAddOrderInShop
            // 
            btnAddOrderInShop.BackColor = Color.FromArgb(11, 14, 183);
            btnAddOrderInShop.BackgroundColor = Color.FromArgb(11, 14, 183);
            btnAddOrderInShop.BorderColor = Color.PaleVioletRed;
            btnAddOrderInShop.BorderRadius = 5;
            btnAddOrderInShop.BorderSize = 0;
            btnAddOrderInShop.FlatAppearance.BorderSize = 0;
            btnAddOrderInShop.FlatStyle = FlatStyle.Flat;
            btnAddOrderInShop.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddOrderInShop.ForeColor = Color.White;
            btnAddOrderInShop.Location = new Point(31, 805);
            btnAddOrderInShop.Name = "btnAddOrderInShop";
            btnAddOrderInShop.Size = new Size(233, 91);
            btnAddOrderInShop.TabIndex = 2;
            btnAddOrderInShop.Text = "Add Order At The Shop";
            btnAddOrderInShop.TextColor = Color.White;
            btnAddOrderInShop.UseVisualStyleBackColor = false;
            btnAddOrderInShop.Click += btnAddOrderInShop_Click;
            // 
            // btnAddOrderBring
            // 
            btnAddOrderBring.BackColor = Color.FromArgb(11, 183, 131);
            btnAddOrderBring.BackgroundColor = Color.FromArgb(11, 183, 131);
            btnAddOrderBring.BorderColor = Color.PaleVioletRed;
            btnAddOrderBring.BorderRadius = 5;
            btnAddOrderBring.BorderSize = 0;
            btnAddOrderBring.FlatAppearance.BorderSize = 0;
            btnAddOrderBring.FlatStyle = FlatStyle.Flat;
            btnAddOrderBring.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddOrderBring.ForeColor = Color.White;
            btnAddOrderBring.Location = new Point(282, 805);
            btnAddOrderBring.Name = "btnAddOrderBring";
            btnAddOrderBring.Size = new Size(233, 91);
            btnAddOrderBring.TabIndex = 2;
            btnAddOrderBring.Text = "Add Order Bring";
            btnAddOrderBring.TextColor = Color.White;
            btnAddOrderBring.UseVisualStyleBackColor = false;
            btnAddOrderBring.Click += btnAddOrderBring_Click;
            // 
            // flpListOrder
            // 
            flpListOrder.AutoScroll = true;
            flpListOrder.Location = new Point(31, 59);
            flpListOrder.Name = "flpListOrder";
            flpListOrder.Size = new Size(484, 632);
            flpListOrder.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 0;
            label1.Text = "List  Order";
            // 
            // loOrder
            // 
            loOrder.BackColor = SystemColors.Control;
            loOrder.Dock = DockStyle.Right;
            loOrder.Location = new Point(539, 0);
            loOrder.Name = "loOrder";
            // 
            // loOrder.Panel1
            // 
            loOrder.Panel1.BackColor = Color.White;
            loOrder.Panel1.Controls.Add(btnToPay);
            loOrder.Panel1.Controls.Add(productOrder);
            loOrder.Panel1.Controls.Add(lstProducts);
            loOrder.Panel1.Controls.Add(lvProducts);
            loOrder.Panel1.Controls.Add(label2);
            loOrder.Panel1.Controls.Add(lblChoses);
            // 
            // loOrder.Panel2
            // 
            loOrder.Panel2.BackColor = Color.White;
            loOrder.Panel2.Controls.Add(btnPayInQr);
            loOrder.Panel2.Controls.Add(btnPayInMoney);
            loOrder.Panel2.Controls.Add(label14);
            loOrder.Panel2.Controls.Add(cbDiscount);
            loOrder.Panel2.Controls.Add(cbTable);
            loOrder.Panel2.Controls.Add(lblTime);
            loOrder.Panel2.Controls.Add(label22);
            loOrder.Panel2.Controls.Add(lblDiscount);
            loOrder.Panel2.Controls.Add(lblService);
            loOrder.Panel2.Controls.Add(label18);
            loOrder.Panel2.Controls.Add(lblVAT);
            loOrder.Panel2.Controls.Add(lblTotal);
            loOrder.Panel2.Controls.Add(lblIntoMoney);
            loOrder.Panel2.Controls.Add(lblDate);
            loOrder.Panel2.Controls.Add(label13);
            loOrder.Panel2.Controls.Add(label20);
            loOrder.Panel2.Controls.Add(txtCustomerCode);
            loOrder.Panel2.Controls.Add(label19);
            loOrder.Panel2.Controls.Add(label17);
            loOrder.Panel2.Controls.Add(label21);
            loOrder.Panel2.Controls.Add(label16);
            loOrder.Panel2.Controls.Add(label15);
            loOrder.Panel2.Controls.Add(label12);
            loOrder.Panel2.Controls.Add(label11);
            loOrder.Panel2.Controls.Add(lvBill);
            loOrder.Panel2.Controls.Add(lblIdInvoice);
            loOrder.Panel2.Controls.Add(lblId);
            loOrder.Panel2.Controls.Add(lblPay);
            loOrder.Size = new Size(1023, 941);
            loOrder.SplitterDistance = 625;
            loOrder.SplitterWidth = 5;
            loOrder.TabIndex = 1;
            loOrder.Visible = false;
            // 
            // btnToPay
            // 
            btnToPay.BackColor = Color.FromArgb(255, 107, 1);
            btnToPay.BackgroundColor = Color.FromArgb(255, 107, 1);
            btnToPay.BorderColor = Color.PaleVioletRed;
            btnToPay.BorderRadius = 5;
            btnToPay.BorderSize = 0;
            btnToPay.FlatAppearance.BorderSize = 0;
            btnToPay.FlatStyle = FlatStyle.Flat;
            btnToPay.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToPay.ForeColor = Color.White;
            btnToPay.Location = new Point(176, 833);
            btnToPay.Name = "btnToPay";
            btnToPay.Size = new Size(268, 63);
            btnToPay.TabIndex = 7;
            btnToPay.Text = "To Pay";
            btnToPay.TextColor = Color.White;
            btnToPay.UseVisualStyleBackColor = false;
            btnToPay.Click += btnToPay_Click;
            // 
            // productOrder
            // 
            productOrder.Controls.Add(flpProductOrder);
            productOrder.Controls.Add(label10);
            productOrder.Controls.Add(label9);
            productOrder.Controls.Add(label8);
            productOrder.Controls.Add(label7);
            productOrder.Controls.Add(label6);
            productOrder.Controls.Add(label5);
            productOrder.Controls.Add(label4);
            productOrder.Controls.Add(label3);
            productOrder.Location = new Point(30, 452);
            productOrder.Name = "productOrder";
            productOrder.Size = new Size(579, 271);
            productOrder.TabIndex = 6;
            productOrder.Visible = false;
            // 
            // flpProductOrder
            // 
            flpProductOrder.AutoScroll = true;
            flpProductOrder.Location = new Point(0, 107);
            flpProductOrder.Margin = new Padding(0);
            flpProductOrder.Name = "flpProductOrder";
            flpProductOrder.Size = new Size(579, 161);
            flpProductOrder.TabIndex = 2;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(507, 39);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(53, 68);
            label10.TabIndex = 1;
            label10.Text = "X";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(414, 39);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(93, 68);
            label9.TabIndex = 1;
            label9.Text = "Total";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(331, 39);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(83, 68);
            label8.TabIndex = 1;
            label8.Text = "Up/Down";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(271, 39);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(60, 68);
            label7.TabIndex = 1;
            label7.Text = "Quality";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(209, 39);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(62, 68);
            label6.TabIndex = 1;
            label6.Text = "Price";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(147, 39);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(62, 68);
            label5.TabIndex = 1;
            label5.Text = "Size";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 39);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(147, 68);
            label4.TabIndex = 1;
            label4.Text = "Name";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 0;
            label3.Text = "Products Order";
            // 
            // lstProducts
            // 
            lstProducts.Location = new Point(30, 81);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(563, 100);
            lstProducts.TabIndex = 5;
            // 
            // lvProducts
            // 
            lvProducts.Columns.AddRange(new ColumnHeader[] { clName, clPrice });
            lvProducts.FullRowSelect = true;
            lvProducts.GridLines = true;
            lvProducts.Location = new Point(97, 210);
            lvProducts.MultiSelect = false;
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(443, 178);
            lvProducts.TabIndex = 4;
            lvProducts.UseCompatibleStateImageBehavior = false;
            lvProducts.View = View.Details;
            lvProducts.Visible = false;
            lvProducts.DoubleClick += lvProducts_DoubleClick;
            // 
            // clName
            // 
            clName.Text = "Name";
            clName.Width = 299;
            // 
            // clPrice
            // 
            clPrice.Text = "Price";
            clPrice.TextAlign = HorizontalAlignment.Center;
            clPrice.Width = 140;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 59);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 0;
            label2.Text = "Menu";
            // 
            // lblChoses
            // 
            lblChoses.AutoSize = true;
            lblChoses.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChoses.Location = new Point(30, 23);
            lblChoses.Name = "lblChoses";
            lblChoses.Size = new Size(63, 24);
            lblChoses.TabIndex = 0;
            lblChoses.Text = "Order";
            // 
            // btnPayInQr
            // 
            btnPayInQr.BackColor = Color.FromArgb(215, 6, 10);
            btnPayInQr.BackgroundColor = Color.FromArgb(215, 6, 10);
            btnPayInQr.BorderColor = Color.PaleVioletRed;
            btnPayInQr.BorderRadius = 5;
            btnPayInQr.BorderSize = 0;
            btnPayInQr.FlatAppearance.BorderSize = 0;
            btnPayInQr.FlatStyle = FlatStyle.Flat;
            btnPayInQr.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayInQr.ForeColor = Color.White;
            btnPayInQr.Location = new Point(65, 830);
            btnPayInQr.Name = "btnPayInQr";
            btnPayInQr.Size = new Size(268, 63);
            btnPayInQr.TabIndex = 7;
            btnPayInQr.Text = "Pay In QR";
            btnPayInQr.TextColor = Color.White;
            btnPayInQr.UseVisualStyleBackColor = false;
            btnPayInQr.Click += btnToPay_Click;
            // 
            // btnPayInMoney
            // 
            btnPayInMoney.BackColor = Color.FromArgb(215, 6, 10);
            btnPayInMoney.BackgroundColor = Color.FromArgb(215, 6, 10);
            btnPayInMoney.BorderColor = Color.PaleVioletRed;
            btnPayInMoney.BorderRadius = 5;
            btnPayInMoney.BorderSize = 0;
            btnPayInMoney.FlatAppearance.BorderSize = 0;
            btnPayInMoney.FlatStyle = FlatStyle.Flat;
            btnPayInMoney.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayInMoney.ForeColor = Color.White;
            btnPayInMoney.Location = new Point(65, 716);
            btnPayInMoney.Name = "btnPayInMoney";
            btnPayInMoney.Size = new Size(268, 63);
            btnPayInMoney.TabIndex = 7;
            btnPayInMoney.Text = "Pay In Money";
            btnPayInMoney.TextColor = Color.White;
            btnPayInMoney.UseVisualStyleBackColor = false;
            btnPayInMoney.Click += btnPayInMoney_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F);
            label14.Location = new Point(259, 352);
            label14.Name = "label14";
            label14.Size = new Size(41, 19);
            label14.TabIndex = 3;
            label14.Text = "Time:";
            // 
            // cbDiscount
            // 
            cbDiscount.FormattingEnabled = true;
            cbDiscount.Items.AddRange(new object[] { "5%", "10%", "20%", "30%", "40%", "50%", "60%", "70%" });
            cbDiscount.Location = new Point(107, 531);
            cbDiscount.Name = "cbDiscount";
            cbDiscount.Size = new Size(59, 23);
            cbDiscount.TabIndex = 5;
            cbDiscount.SelectedIndexChanged += cbDiscount_SelectedIndexChanged;
            // 
            // cbTable
            // 
            cbTable.FormattingEnabled = true;
            cbTable.Items.AddRange(new object[] { "Table 1", "Table 2", "Table 3", "Table 4" });
            cbTable.Location = new Point(23, 374);
            cbTable.Name = "cbTable";
            cbTable.Size = new Size(112, 23);
            cbTable.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.BorderStyle = BorderStyle.FixedSingle;
            lblTime.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(264, 374);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(112, 23);
            lblTime.TabIndex = 3;
            lblTime.Text = "07:12 AM";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(107, 485);
            label22.Name = "label22";
            label22.Size = new Size(59, 30);
            label22.TabIndex = 3;
            label22.Text = "1%";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDiscount
            // 
            lblDiscount.BorderStyle = BorderStyle.FixedSingle;
            lblDiscount.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(165, 524);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(211, 30);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "100000 Đ";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblService
            // 
            lblService.BorderStyle = BorderStyle.FixedSingle;
            lblService.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblService.Location = new Point(165, 485);
            lblService.Name = "lblService";
            lblService.Size = new Size(211, 30);
            lblService.TabIndex = 3;
            lblService.Text = "100000 Đ";
            lblService.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(107, 446);
            label18.Name = "label18";
            label18.Size = new Size(59, 30);
            label18.TabIndex = 3;
            label18.Text = "5%";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVAT
            // 
            lblVAT.BorderStyle = BorderStyle.FixedSingle;
            lblVAT.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVAT.Location = new Point(165, 446);
            lblVAT.Name = "lblVAT";
            lblVAT.Size = new Size(211, 30);
            lblVAT.TabIndex = 3;
            lblVAT.Text = "100000 Đ";
            lblVAT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(107, 561);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(269, 30);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "100000 Đ";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIntoMoney
            // 
            lblIntoMoney.BorderStyle = BorderStyle.FixedSingle;
            lblIntoMoney.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntoMoney.Location = new Point(107, 407);
            lblIntoMoney.Name = "lblIntoMoney";
            lblIntoMoney.Size = new Size(269, 30);
            lblIntoMoney.TabIndex = 3;
            lblIntoMoney.Text = "100000 Đ";
            lblIntoMoney.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDate
            // 
            lblDate.BorderStyle = BorderStyle.FixedSingle;
            lblDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(143, 374);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(112, 23);
            lblDate.TabIndex = 3;
            lblDate.Text = "11/02/2025";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F);
            label13.Location = new Point(138, 352);
            label13.Name = "label13";
            label13.Size = new Size(41, 19);
            label13.TabIndex = 3;
            label13.Text = "Date:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Times New Roman", 12F);
            label20.ForeColor = Color.FromArgb(47, 42, 192);
            label20.Location = new Point(18, 530);
            label20.Name = "label20";
            label20.Size = new Size(65, 19);
            label20.TabIndex = 3;
            label20.Text = "Discount:";
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.BackColor = SystemColors.Window;
            txtCustomerCode.BorderColor = Color.Black;
            txtCustomerCode.BorderFocusColor = Color.FromArgb(64, 64, 64);
            txtCustomerCode.BorderRadius = 0;
            txtCustomerCode.BorderSize = 1;
            txtCustomerCode.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerCode.ForeColor = Color.FromArgb(64, 64, 64);
            txtCustomerCode.Location = new Point(134, 312);
            txtCustomerCode.Margin = new Padding(4);
            txtCustomerCode.Multiline = false;
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.Padding = new Padding(10, 7, 10, 7);
            txtCustomerCode.PasswordChar = false;
            txtCustomerCode.PlaceholderColor = Color.DarkGray;
            txtCustomerCode.PlaceholderText = "";
            txtCustomerCode.Size = new Size(242, 31);
            txtCustomerCode.TabIndex = 4;
            txtCustomerCode.Texts = "";
            txtCustomerCode.UnderlinedStyle = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Times New Roman", 12F);
            label19.Location = new Point(18, 491);
            label19.Name = "label19";
            label19.Size = new Size(79, 19);
            label19.TabIndex = 3;
            label19.Text = "Service tax:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 12F);
            label17.Location = new Point(18, 452);
            label17.Name = "label17";
            label17.Size = new Size(61, 19);
            label17.TabIndex = 3;
            label17.Text = "VAT tax:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Times New Roman", 12F);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(18, 567);
            label21.Name = "label21";
            label21.Size = new Size(42, 19);
            label21.TabIndex = 3;
            label21.Text = "Total:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F);
            label16.Location = new Point(18, 413);
            label16.Name = "label16";
            label16.Size = new Size(83, 19);
            label16.TabIndex = 3;
            label16.Text = "Into Money:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(18, 411);
            label15.Name = "label15";
            label15.Size = new Size(51, 19);
            label15.TabIndex = 3;
            label15.Text = "Table:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F);
            label12.Location = new Point(18, 352);
            label12.Name = "label12";
            label12.Size = new Size(45, 19);
            label12.TabIndex = 3;
            label12.Text = "Table:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F);
            label11.Location = new Point(18, 319);
            label11.Name = "label11";
            label11.Size = new Size(109, 19);
            label11.TabIndex = 3;
            label11.Text = "Customer Code:";
            // 
            // lvBill
            // 
            lvBill.Columns.AddRange(new ColumnHeader[] { clBillName, clBillSize, clBillPrice, clBillQuality, clBillTotal });
            lvBill.GridLines = true;
            lvBill.Location = new Point(18, 98);
            lvBill.Name = "lvBill";
            lvBill.Size = new Size(358, 170);
            lvBill.TabIndex = 2;
            lvBill.UseCompatibleStateImageBehavior = false;
            lvBill.View = View.Details;
            // 
            // clBillName
            // 
            clBillName.Text = "Name";
            clBillName.Width = 100;
            // 
            // clBillSize
            // 
            clBillSize.Text = "Size";
            clBillSize.TextAlign = HorizontalAlignment.Center;
            // 
            // clBillPrice
            // 
            clBillPrice.Text = "Price";
            clBillPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // clBillQuality
            // 
            clBillQuality.Text = "Quality";
            clBillQuality.TextAlign = HorizontalAlignment.Center;
            // 
            // clBillTotal
            // 
            clBillTotal.Text = "Total";
            clBillTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // lblIdInvoice
            // 
            lblIdInvoice.AutoSize = true;
            lblIdInvoice.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdInvoice.Location = new Point(83, 55);
            lblIdInvoice.Name = "lblIdInvoice";
            lblIdInvoice.Size = new Size(32, 24);
            lblIdInvoice.TabIndex = 1;
            lblIdInvoice.Text = "#1";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(18, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(69, 19);
            lblId.TabIndex = 1;
            lblId.Text = "Bill Code:";
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPay.Location = new Point(30, 23);
            lblPay.Name = "lblPay";
            lblPay.Size = new Size(45, 24);
            lblPay.TabIndex = 0;
            lblPay.Text = "Pay";
            // 
            // SellingControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(loOrder);
            Controls.Add(pnListOrder);
            Name = "SellingControl";
            Size = new Size(1562, 941);
            pnListOrder.ResumeLayout(false);
            pnListOrder.PerformLayout();
            loOrder.Panel1.ResumeLayout(false);
            loOrder.Panel1.PerformLayout();
            loOrder.Panel2.ResumeLayout(false);
            loOrder.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loOrder).EndInit();
            loOrder.ResumeLayout(false);
            productOrder.ResumeLayout(false);
            productOrder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnListOrder;
        private Label label1;
        private FlowLayoutPanel flpListOrder;
        private SplitContainer loOrder;
        private Label lblChoses;
        private Label lblPay;
        private Label label2;
        private ButtonControl btnAddOrderBring;
        private ButtonControl btnAddOrderInShop;
        private ListView lvProducts;
        private ColumnHeader clName;
        private ColumnHeader clPrice;
        private AntdUI.In.FlowLayoutPanel lstProducts;
        private Panel productOrder;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private FlowLayoutPanel flpProductOrder;
        private ButtonControl btnToPay;
        private Label lblId;
        private ListView lvBill;
        private Label lblIdInvoice;
        private ColumnHeader clBillName;
        private ColumnHeader clBillSize;
        private ColumnHeader clBillPrice;
        private ColumnHeader clBillQuality;
        private ColumnHeader clBillTotal;
        private Label label11;
        private CustomControls.RJControls.RJTextBox txtCustomerCode;
        private Label label12;
        private ComboBox cbTable;
        private Label label13;
        private Label label14;
        private Label lblDate;
        private Label lblTime;
        private Label lblIntoMoney;
        private Label label16;
        private Label label15;
        private Label label22;
        private Label lblService;
        private Label label18;
        private Label lblVAT;
        private Label label20;
        private Label label19;
        private Label label17;
        private ComboBox cbDiscount;
        private Label lblDiscount;
        private ButtonControl btnPayInQr;
        private ButtonControl btnPayInMoney;
        private Label lblTotal;
        private Label label21;
    }
}
