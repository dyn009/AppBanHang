using AppBanHang.Views.Controls.UIControl;

namespace AppBanHang.Views.Controls
{
    partial class InfoOrderControl
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
            lblOrder = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            label3 = new Label();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            btnDelivered = new ButtonControl();
            panel1 = new AntdUI.Panel();
            label1 = new Label();
            lblStatus = new Label();
            lblFormlity = new Label();
            lblTotal = new Label();
            lblTime = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrder.Location = new Point(71, 8);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(30, 22);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "#1";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(13, 34);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(80, 19);
            lbl1.TabIndex = 0;
            lbl1.Text = "Trạng Thái: ";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(13, 55);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(68, 19);
            lbl2.TabIndex = 0;
            lbl2.Text = "Tổng tiền:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(13, 74);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(93, 19);
            lbl3.TabIndex = 0;
            lbl3.Text = "Thời gian vào:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 96);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 0;
            label3.Text = "Hình thức:";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // btnDelivered
            // 
            btnDelivered.BackColor = Color.FromArgb(11, 183, 131);
            btnDelivered.BackgroundColor = Color.FromArgb(11, 183, 131);
            btnDelivered.BorderColor = Color.PaleVioletRed;
            btnDelivered.BorderRadius = 20;
            btnDelivered.BorderSize = 0;
            btnDelivered.CausesValidation = false;
            btnDelivered.FlatAppearance.BorderSize = 0;
            btnDelivered.FlatStyle = FlatStyle.Flat;
            btnDelivered.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelivered.ForeColor = Color.White;
            btnDelivered.Location = new Point(23, 122);
            btnDelivered.Name = "btnDelivered";
            btnDelivered.Size = new Size(177, 35);
            btnDelivered.TabIndex = 2;
            btnDelivered.Text = "Delivered";
            btnDelivered.TextColor = Color.White;
            btnDelivered.UseVisualStyleBackColor = false;
            btnDelivered.Click += btnDelivered_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderColor = Color.FromArgb(11, 183, 131);
            panel1.BorderWidth = 1F;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblOrder);
            panel1.Controls.Add(btnDelivered);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lbl1);
            panel1.Controls.Add(lblFormlity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lbl2);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lbl3);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Radius = 5;
            panel1.Size = new Size(224, 166);
            panel1.TabIndex = 3;
            panel1.Text = "panel1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 0;
            label1.Text = "Order";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(83, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 19);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Chưa giao";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFormlity
            // 
            lblFormlity.AutoSize = true;
            lblFormlity.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFormlity.Location = new Point(82, 96);
            lblFormlity.Name = "lblFormlity";
            lblFormlity.Size = new Size(61, 19);
            lblFormlity.TabIndex = 0;
            lblFormlity.Text = "Tại quán";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(75, 55);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(57, 19);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "120000";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(100, 74);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(71, 19);
            lblTime.TabIndex = 0;
            lblTime.Text = "11:20 AM";
            // 
            // InfoOrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "InfoOrderControl";
            Size = new Size(224, 166);
            Load += InfoOrderControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblOrder;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label label3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconButton btnOK;
        private ButtonControl btnDelivered;
        private AntdUI.Panel panel1;
        private Label lblStatus;
        private Label lblTotal;
        private Label lblFormlity;
        private Label lblTime;
        private Label label1;
    }
}
