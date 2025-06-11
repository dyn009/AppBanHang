using AppBanHang.Views.Controls.UIControl;

namespace AppBanHang.Views.Controls
{
    partial class ProductsOrderControl
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
            lblCanccel = new Label();
            lblTotal = new Label();
            lblQality = new Label();
            lblPrice = new Label();
            lblName = new Label();
            rbM = new RadioButton();
            rbL = new RadioButton();
            panel1 = new Panel();
            buttonControl2 = new ButtonControl();
            panel2 = new Panel();
            buttonControl1 = new ButtonControl();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblCanccel
            // 
            lblCanccel.BackColor = Color.FromArgb(255, 0, 4);
            lblCanccel.BorderStyle = BorderStyle.FixedSingle;
            lblCanccel.FlatStyle = FlatStyle.Flat;
            lblCanccel.Font = new Font("Times New Roman", 11.25F);
            lblCanccel.ForeColor = SystemColors.ActiveCaptionText;
            lblCanccel.Location = new Point(507, 0);
            lblCanccel.Margin = new Padding(0);
            lblCanccel.Name = "lblCanccel";
            lblCanccel.Size = new Size(53, 46);
            lblCanccel.TabIndex = 2;
            lblCanccel.Text = "X";
            lblCanccel.TextAlign = ContentAlignment.MiddleCenter;
            lblCanccel.Click += lblCanccel_Click;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.FlatStyle = FlatStyle.Flat;
            lblTotal.Font = new Font("Times New Roman", 11.25F);
            lblTotal.ForeColor = SystemColors.ActiveCaptionText;
            lblTotal.Location = new Point(414, 0);
            lblTotal.Margin = new Padding(0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(93, 46);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQality
            // 
            lblQality.BorderStyle = BorderStyle.FixedSingle;
            lblQality.FlatStyle = FlatStyle.Flat;
            lblQality.Font = new Font("Times New Roman", 11.25F);
            lblQality.ForeColor = SystemColors.ActiveCaptionText;
            lblQality.Location = new Point(271, 0);
            lblQality.Margin = new Padding(0);
            lblQality.Name = "lblQality";
            lblQality.Size = new Size(60, 46);
            lblQality.TabIndex = 5;
            lblQality.Text = "Quality";
            lblQality.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.FlatStyle = FlatStyle.Flat;
            lblPrice.Font = new Font("Times New Roman", 11.25F);
            lblPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblPrice.Location = new Point(209, 0);
            lblPrice.Margin = new Padding(0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(62, 46);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Font = new Font("Times New Roman", 11.25F);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(0, 0);
            lblName.Margin = new Padding(0);
            lblName.Name = "lblName";
            lblName.Size = new Size(147, 46);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbM
            // 
            rbM.AutoSize = true;
            rbM.Checked = true;
            rbM.FlatStyle = FlatStyle.Flat;
            rbM.Font = new Font("Times New Roman", 11.25F);
            rbM.ForeColor = SystemColors.ActiveCaptionText;
            rbM.Location = new Point(3, 0);
            rbM.Name = "rbM";
            rbM.Size = new Size(38, 21);
            rbM.TabIndex = 9;
            rbM.TabStop = true;
            rbM.Text = "M";
            rbM.UseVisualStyleBackColor = true;
            rbM.CheckedChanged += rbM_CheckedChanged;
            // 
            // rbL
            // 
            rbL.AutoSize = true;
            rbL.FlatStyle = FlatStyle.Flat;
            rbL.Font = new Font("Times New Roman", 11.25F);
            rbL.ForeColor = SystemColors.ActiveCaptionText;
            rbL.Location = new Point(3, 23);
            rbL.Name = "rbL";
            rbL.Size = new Size(34, 21);
            rbL.TabIndex = 9;
            rbL.Text = "L";
            rbL.UseVisualStyleBackColor = true;
            rbL.CheckedChanged += rbL_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(rbL);
            panel1.Controls.Add(rbM);
            panel1.Location = new Point(147, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(62, 46);
            panel1.TabIndex = 12;
            // 
            // buttonControl2
            // 
            buttonControl2.BackColor = Color.White;
            buttonControl2.BackgroundColor = Color.White;
            buttonControl2.BorderColor = Color.PaleVioletRed;
            buttonControl2.BorderRadius = 0;
            buttonControl2.BorderSize = 0;
            buttonControl2.FlatAppearance.BorderSize = 0;
            buttonControl2.FlatStyle = FlatStyle.Flat;
            buttonControl2.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonControl2.ForeColor = Color.Black;
            buttonControl2.Location = new Point(1, -4);
            buttonControl2.Name = "buttonControl2";
            buttonControl2.Size = new Size(40, 48);
            buttonControl2.TabIndex = 13;
            buttonControl2.Text = "-";
            buttonControl2.TextColor = Color.Black;
            buttonControl2.UseVisualStyleBackColor = false;
            buttonControl2.Click += buttonControl2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(41, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(1, 30);
            panel2.TabIndex = 14;
            // 
            // buttonControl1
            // 
            buttonControl1.BackColor = Color.White;
            buttonControl1.BackgroundColor = Color.White;
            buttonControl1.BorderColor = Color.PaleVioletRed;
            buttonControl1.BorderRadius = 0;
            buttonControl1.BorderSize = 0;
            buttonControl1.FlatAppearance.BorderSize = 0;
            buttonControl1.FlatStyle = FlatStyle.Flat;
            buttonControl1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonControl1.ForeColor = Color.Black;
            buttonControl1.Location = new Point(42, 0);
            buttonControl1.Name = "buttonControl1";
            buttonControl1.Size = new Size(39, 46);
            buttonControl1.TabIndex = 13;
            buttonControl1.Text = "+";
            buttonControl1.TextColor = Color.Black;
            buttonControl1.UseVisualStyleBackColor = false;
            buttonControl1.Click += buttonControl1_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(buttonControl2);
            panel3.Controls.Add(buttonControl1);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(331, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(83, 46);
            panel3.TabIndex = 15;
            // 
            // ProductsOrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lblCanccel);
            Controls.Add(lblTotal);
            Controls.Add(lblQality);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Margin = new Padding(0);
            Name = "ProductsOrderControl";
            Size = new Size(561, 46);
            Load += ProductsOrderControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblCanccel;
        private Label lblTotal;
        private Label lblQality;
        private Label lblPrice;
        private Label lblName;
        private RadioButton rbM;
        private RadioButton rbL;
        private Panel panel1;
        private ButtonControl buttonControl2;
        private Panel panel2;
        private ButtonControl buttonControl1;
        private Panel panel3;
    }
}
