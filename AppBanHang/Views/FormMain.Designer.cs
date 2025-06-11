namespace AppBanHang.Views
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            pnMenu = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnSales = new FontAwesome.Sharp.IconButton();
            btnCustomers = new FontAwesome.Sharp.IconButton();
            btnStaffs = new FontAwesome.Sharp.IconButton();
            btnBills = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnStatistical = new FontAwesome.Sharp.IconButton();
            btnSelling = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            lblHeader = new Label();
            pnShow = new Panel();
            panel1.SuspendLayout();
            pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pnMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Lavender;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 1131);
            panel1.TabIndex = 0;
            // 
            // pnMenu
            // 
            pnMenu.Controls.Add(btnLogout);
            pnMenu.Controls.Add(btnSales);
            pnMenu.Controls.Add(btnCustomers);
            pnMenu.Controls.Add(btnStaffs);
            pnMenu.Controls.Add(btnBills);
            pnMenu.Controls.Add(btnProduct);
            pnMenu.Controls.Add(btnStatistical);
            pnMenu.Controls.Add(btnSelling);
            pnMenu.Controls.Add(btnHome);
            pnMenu.Location = new Point(46, 155);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(252, 698);
            pnMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.AccessibleRole = AccessibleRole.None;
            btnLogout.BackColor = Color.White;
            btnLogout.BackgroundImageLayout = ImageLayout.Center;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DimGray;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.DimGray;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 616);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(252, 77);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseMnemonic = false;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSales
            // 
            btnSales.AccessibleRole = AccessibleRole.None;
            btnSales.BackColor = Color.White;
            btnSales.BackgroundImageLayout = ImageLayout.Center;
            btnSales.Dock = DockStyle.Top;
            btnSales.FlatAppearance.BorderColor = Color.White;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.DimGray;
            btnSales.IconChar = FontAwesome.Sharp.IconChar.Salesforce;
            btnSales.IconColor = Color.DimGray;
            btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(0, 539);
            btnSales.Margin = new Padding(0);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(252, 77);
            btnSales.TabIndex = 7;
            btnSales.Text = "Sales";
            btnSales.TextAlign = ContentAlignment.MiddleLeft;
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseMnemonic = false;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.AccessibleRole = AccessibleRole.None;
            btnCustomers.BackColor = Color.White;
            btnCustomers.BackgroundImageLayout = ImageLayout.Center;
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatAppearance.BorderColor = Color.White;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.DimGray;
            btnCustomers.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            btnCustomers.IconColor = Color.DimGray;
            btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 462);
            btnCustomers.Margin = new Padding(0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(252, 77);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomers.UseMnemonic = false;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnStaffs
            // 
            btnStaffs.AccessibleRole = AccessibleRole.None;
            btnStaffs.BackColor = Color.White;
            btnStaffs.BackgroundImageLayout = ImageLayout.Center;
            btnStaffs.Dock = DockStyle.Top;
            btnStaffs.FlatAppearance.BorderColor = Color.White;
            btnStaffs.FlatStyle = FlatStyle.Flat;
            btnStaffs.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffs.ForeColor = Color.DimGray;
            btnStaffs.IconChar = FontAwesome.Sharp.IconChar.Male;
            btnStaffs.IconColor = Color.DimGray;
            btnStaffs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStaffs.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaffs.Location = new Point(0, 385);
            btnStaffs.Margin = new Padding(0);
            btnStaffs.Name = "btnStaffs";
            btnStaffs.RightToLeft = RightToLeft.No;
            btnStaffs.Size = new Size(252, 77);
            btnStaffs.TabIndex = 5;
            btnStaffs.Text = "Staffs";
            btnStaffs.TextAlign = ContentAlignment.MiddleLeft;
            btnStaffs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStaffs.UseMnemonic = false;
            btnStaffs.UseVisualStyleBackColor = false;
            btnStaffs.Click += btnStaffs_Click;
            // 
            // btnBills
            // 
            btnBills.AccessibleRole = AccessibleRole.None;
            btnBills.BackColor = Color.White;
            btnBills.BackgroundImageLayout = ImageLayout.Center;
            btnBills.Dock = DockStyle.Top;
            btnBills.FlatAppearance.BorderColor = Color.White;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBills.ForeColor = Color.DimGray;
            btnBills.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            btnBills.IconColor = Color.DimGray;
            btnBills.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBills.ImageAlign = ContentAlignment.MiddleLeft;
            btnBills.Location = new Point(0, 308);
            btnBills.Margin = new Padding(0);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(252, 77);
            btnBills.TabIndex = 4;
            btnBills.Text = "Bills";
            btnBills.TextAlign = ContentAlignment.MiddleLeft;
            btnBills.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBills.UseMnemonic = false;
            btnBills.UseVisualStyleBackColor = false;
            btnBills.Click += btnBills_Click;
            // 
            // btnProduct
            // 
            btnProduct.AccessibleRole = AccessibleRole.None;
            btnProduct.BackColor = Color.White;
            btnProduct.BackgroundImageLayout = ImageLayout.Center;
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderColor = Color.White;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.DimGray;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            btnProduct.IconColor = Color.DimGray;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 231);
            btnProduct.Margin = new Padding(0);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(252, 77);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Products";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseMnemonic = false;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnStatistical
            // 
            btnStatistical.AccessibleRole = AccessibleRole.None;
            btnStatistical.BackColor = Color.White;
            btnStatistical.BackgroundImageLayout = ImageLayout.Center;
            btnStatistical.Dock = DockStyle.Top;
            btnStatistical.FlatAppearance.BorderColor = Color.White;
            btnStatistical.FlatStyle = FlatStyle.Flat;
            btnStatistical.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatistical.ForeColor = Color.DimGray;
            btnStatistical.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnStatistical.IconColor = Color.DimGray;
            btnStatistical.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStatistical.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistical.Location = new Point(0, 154);
            btnStatistical.Margin = new Padding(0);
            btnStatistical.Name = "btnStatistical";
            btnStatistical.Size = new Size(252, 77);
            btnStatistical.TabIndex = 2;
            btnStatistical.Text = "Statisticals";
            btnStatistical.TextAlign = ContentAlignment.MiddleLeft;
            btnStatistical.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistical.UseMnemonic = false;
            btnStatistical.UseVisualStyleBackColor = false;
            btnStatistical.Click += btnStatistical_Click;
            // 
            // btnSelling
            // 
            btnSelling.AccessibleRole = AccessibleRole.None;
            btnSelling.BackColor = Color.White;
            btnSelling.BackgroundImageLayout = ImageLayout.Center;
            btnSelling.Dock = DockStyle.Top;
            btnSelling.FlatAppearance.BorderColor = Color.White;
            btnSelling.FlatStyle = FlatStyle.Flat;
            btnSelling.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelling.ForeColor = Color.DimGray;
            btnSelling.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnSelling.IconColor = Color.DimGray;
            btnSelling.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSelling.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelling.Location = new Point(0, 77);
            btnSelling.Margin = new Padding(0);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(252, 77);
            btnSelling.TabIndex = 1;
            btnSelling.Text = "Selling";
            btnSelling.TextAlign = ContentAlignment.MiddleLeft;
            btnSelling.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelling.UseMnemonic = false;
            btnSelling.UseVisualStyleBackColor = false;
            btnSelling.Click += btnSelling_Click;
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = AccessibleRole.None;
            btnHome.BackColor = Color.White;
            btnHome.BackgroundImageLayout = ImageLayout.Center;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.DimGray;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.DimGray;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(252, 77);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseMnemonic = false;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(115, 57);
            label1.Name = "label1";
            label1.Size = new Size(121, 40);
            label1.TabIndex = 1;
            label1.Text = "LOGO";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\HP\\OneDrive\\Máy tính\\All\\C#\\Project\\AppBanHang\\AppBanHang\\Acset\\Image\\dummy logo.png";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(43, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(345, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1563, 100);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1276, 20);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(226, 60);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(1631, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 60);
            panel3.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.White;
            lblHeader.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(385, 29);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(110, 42);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Home";
            // 
            // pnShow
            // 
            pnShow.Dock = DockStyle.Right;
            pnShow.Location = new Point(337, 100);
            pnShow.Name = "pnShow";
            pnShow.Padding = new Padding(0, 5, 5, 5);
            pnShow.Size = new Size(1571, 1031);
            pnShow.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1908, 1131);
            Controls.Add(pnShow);
            Controls.Add(lblHeader);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormHome";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private FontAwesome.Sharp.IconButton btnStaffs;
        private FontAwesome.Sharp.IconButton btnBills;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnStatistical;
        private FontAwesome.Sharp.IconButton btnSelling;
        private Panel panel2;
        private Label lblHeader;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Panel pnShow;
    }
}