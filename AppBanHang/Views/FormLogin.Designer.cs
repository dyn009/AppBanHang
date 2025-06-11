namespace AppBanHang
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtPassword = new TextBox();
            btnLogin = new Button();
            txtAccount = new TextBox();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(834, 443);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(420, 71);
            txtPassword.TabIndex = 0;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseWaitCursor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGreen;
            btnLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Red;
            btnLogin.Location = new Point(834, 529);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(420, 71);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.UseWaitCursor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(834, 354);
            txtAccount.Multiline = true;
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(420, 71);
            txtAccount.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\HP\\OneDrive\\Máy tính\\All\\C#\\Project\\AppBanHang\\AppBanHang\\Acset\\Image\\SBX_WWF_827х900_EN.jpg 1.png";
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(646, 900);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(723, 386);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1440, 900);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtAccount);
            Controls.Add(txtPassword);
            ForeColor = Color.White;
            IsMdiContainer = true;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = SystemColors.Control;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnLogin;
        private TextBox txtAccount;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
