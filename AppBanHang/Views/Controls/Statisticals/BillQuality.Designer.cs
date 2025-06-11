using AppBanHang.Views.Controls.UIControl;

namespace AppBanHang.Views.Controls.Statisticals
{
    partial class BillQuality
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
            txtIdBill = new AntdUI.Label();
            txtTime = new AntdUI.Label();
            txtIntoMoney = new AntdUI.Label();
            panel1 = new AntdUI.Panel();
            btnShow = new ButtonControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtIdBill
            // 
            txtIdBill.BackColor = Color.White;
            txtIdBill.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdBill.Location = new Point(0, 0);
            txtIdBill.Name = "txtIdBill";
            txtIdBill.Size = new Size(182, 49);
            txtIdBill.TabIndex = 0;
            txtIdBill.Text = "Id Bill";
            txtIdBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTime
            // 
            txtTime.BackColor = Color.White;
            txtTime.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(182, 0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(182, 49);
            txtTime.TabIndex = 0;
            txtTime.Text = "Time";
            txtTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIntoMoney
            // 
            txtIntoMoney.BackColor = Color.White;
            txtIntoMoney.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIntoMoney.Location = new Point(364, 0);
            txtIntoMoney.Name = "txtIntoMoney";
            txtIntoMoney.Size = new Size(182, 49);
            txtIntoMoney.TabIndex = 0;
            txtIntoMoney.Text = "IntoMoney";
            txtIntoMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            panel1.Controls.Add(btnShow);
            panel1.Location = new Point(546, 0);
            panel1.Name = "panel1";
            panel1.Radius = 0;
            panel1.Size = new Size(182, 49);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.FromArgb(240, 253, 244);
            btnShow.BackgroundColor = Color.FromArgb(240, 253, 244);
            btnShow.BorderColor = Color.FromArgb(0, 229, 143);
            btnShow.BorderRadius = 8;
            btnShow.BorderSize = 1;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.ForeColor = Color.FromArgb(0, 229, 143);
            btnShow.Location = new Point(61, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(60, 24);
            btnShow.TabIndex = 0;
            btnShow.Text = "Xem";
            btnShow.TextColor = Color.FromArgb(0, 229, 143);
            btnShow.UseVisualStyleBackColor = false;
            // 
            // BillQuality
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 246);
            Controls.Add(panel1);
            Controls.Add(txtIntoMoney);
            Controls.Add(txtTime);
            Controls.Add(txtIdBill);
            Name = "BillQuality";
            Padding = new Padding(0, 0, 0, 5);
            Size = new Size(728, 50);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label txtIdBill;
        private AntdUI.Label txtTime;
        private AntdUI.Label txtIntoMoney;
        private AntdUI.Panel panel1;
        private ButtonControl btnShow;
    }
}
