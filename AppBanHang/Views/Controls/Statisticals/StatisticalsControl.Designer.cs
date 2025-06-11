namespace AppBanHang.Views.Controls
{
    partial class StatisticalsControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            dgvBestSeller = new DataGridView();
            Stt = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            SellQuality = new DataGridViewTextBoxColumn();
            Revenue = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            panel1 = new Panel();
            label6 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            txtIntoMoney = new AntdUI.Label();
            txtTime = new AntdUI.Label();
            txtIdBill = new AntdUI.Label();
            flpBillQuality = new FlowLayoutPanel();
            cbBillsQuality = new ComboBox();
            label1 = new Label();
            cbBestSeller = new ComboBox();
            label2 = new Label();
            splitContainer3 = new SplitContainer();
            charRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label5 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            buttonControl1 = new AppBanHang.Views.Controls.UIControl.ButtonControl();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)charRevenue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvBestSeller
            // 
            dgvBestSeller.BackgroundColor = Color.White;
            dgvBestSeller.BorderStyle = BorderStyle.None;
            dgvBestSeller.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBestSeller.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBestSeller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBestSeller.ColumnHeadersHeight = 40;
            dgvBestSeller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBestSeller.Columns.AddRange(new DataGridViewColumn[] { Stt, Name, SellQuality, Revenue });
            dgvBestSeller.EnableHeadersVisualStyles = false;
            dgvBestSeller.GridColor = Color.White;
            dgvBestSeller.Location = new Point(24, 60);
            dgvBestSeller.MultiSelect = false;
            dgvBestSeller.Name = "dgvBestSeller";
            dgvBestSeller.ReadOnly = true;
            dgvBestSeller.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBestSeller.RowHeadersVisible = false;
            dgvBestSeller.RowHeadersWidth = 50;
            dgvBestSeller.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvBestSeller.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvBestSeller.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBestSeller.RowTemplate.Height = 40;
            dgvBestSeller.RowTemplate.ReadOnly = true;
            dgvBestSeller.ScrollBars = ScrollBars.None;
            dgvBestSeller.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBestSeller.Size = new Size(728, 429);
            dgvBestSeller.TabIndex = 2;
            // 
            // Stt
            // 
            Stt.HeaderText = "#";
            Stt.MinimumWidth = 8;
            Stt.Name = "Stt";
            Stt.ReadOnly = true;
            Stt.Width = 132;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 212;
            // 
            // SellQuality
            // 
            SellQuality.HeaderText = "Sell Quality";
            SellQuality.MinimumWidth = 8;
            SellQuality.Name = "SellQuality";
            SellQuality.ReadOnly = true;
            SellQuality.Width = 192;
            // 
            // Revenue
            // 
            Revenue.HeaderText = "Revenue";
            Revenue.MinimumWidth = 8;
            Revenue.Name = "Revenue";
            Revenue.ReadOnly = true;
            Revenue.Width = 192;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(1562, 941);
            splitContainer1.SplitterDistance = 519;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.White;
            splitContainer2.Panel1.Controls.Add(panel1);
            splitContainer2.Panel1.Controls.Add(flpBillQuality);
            splitContainer2.Panel1.Controls.Add(cbBillsQuality);
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.White;
            splitContainer2.Panel2.Controls.Add(dgvBestSeller);
            splitContainer2.Panel2.Controls.Add(cbBestSeller);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Size = new Size(1562, 519);
            splitContainer2.SplitterDistance = 776;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 242, 246);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtIntoMoney);
            panel1.Controls.Add(txtTime);
            panel1.Controls.Add(txtIdBill);
            panel1.Location = new Point(23, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 50);
            panel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 49);
            label6.TabIndex = 1;
            label6.Text = "ID";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(546, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 49);
            label7.TabIndex = 1;
            label7.Text = "Detail";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIntoMoney
            // 
            txtIntoMoney.BackColor = Color.White;
            txtIntoMoney.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIntoMoney.Location = new Point(364, 0);
            txtIntoMoney.Name = "txtIntoMoney";
            txtIntoMoney.Size = new Size(182, 49);
            txtIntoMoney.TabIndex = 1;
            txtIntoMoney.Text = "IntoMoney";
            txtIntoMoney.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTime
            // 
            txtTime.BackColor = Color.White;
            txtTime.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(182, 0);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(182, 49);
            txtTime.TabIndex = 2;
            txtTime.Text = "Time";
            txtTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIdBill
            // 
            txtIdBill.BackColor = Color.White;
            txtIdBill.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdBill.Location = new Point(0, 0);
            txtIdBill.Name = "txtIdBill";
            txtIdBill.Size = new Size(182, 49);
            txtIdBill.TabIndex = 3;
            txtIdBill.Text = "Id Bill";
            txtIdBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpBillQuality
            // 
            flpBillQuality.AutoScroll = true;
            flpBillQuality.Location = new Point(23, 111);
            flpBillQuality.Name = "flpBillQuality";
            flpBillQuality.Size = new Size(751, 378);
            flpBillQuality.TabIndex = 4;
            // 
            // cbBillsQuality
            // 
            cbBillsQuality.FormattingEnabled = true;
            cbBillsQuality.Items.AddRange(new object[] { "Theo ngày", "Theo tháng", "Theo năm" });
            cbBillsQuality.Location = new Point(129, 19);
            cbBillsQuality.Name = "cbBillsQuality";
            cbBillsQuality.Size = new Size(121, 23);
            cbBillsQuality.TabIndex = 1;
            cbBillsQuality.SelectedIndexChanged += cbBillsQuality_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 23);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "Bills Quality";
            // 
            // cbBestSeller
            // 
            cbBestSeller.FormattingEnabled = true;
            cbBestSeller.Items.AddRange(new object[] { "Theo tháng", "Theo năm" });
            cbBestSeller.Location = new Point(120, 19);
            cbBestSeller.Name = "cbBestSeller";
            cbBestSeller.Size = new Size(121, 23);
            cbBestSeller.TabIndex = 1;
            cbBestSeller.SelectedIndexChanged += cbBestSeller_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 23);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 0;
            label2.Text = "Best Seller";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.BackColor = Color.White;
            splitContainer3.Panel1.Controls.Add(charRevenue);
            splitContainer3.Panel1.Controls.Add(label5);
            splitContainer3.Panel1.Controls.Add(label3);
            splitContainer3.Panel1.Controls.Add(comboBox1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.BackColor = Color.White;
            splitContainer3.Panel2.Controls.Add(dataGridView1);
            splitContainer3.Panel2.Controls.Add(buttonControl1);
            splitContainer3.Panel2.Controls.Add(label4);
            splitContainer3.Size = new Size(1562, 418);
            splitContainer3.SplitterDistance = 776;
            splitContainer3.SplitterWidth = 5;
            splitContainer3.TabIndex = 0;
            // 
            // charRevenue
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            charRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            charRevenue.Legends.Add(legend1);
            charRevenue.Location = new Point(31, 101);
            charRevenue.Name = "charRevenue";
            charRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total";
            charRevenue.Series.Add(series1);
            charRevenue.Size = new Size(720, 300);
            charRevenue.TabIndex = 1;
            charRevenue.Text = "chart1";
            title1.Name = "Money";
            title2.Name = "Day";
            charRevenue.Titles.Add(title1);
            charRevenue.Titles.Add(title2);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 25);
            label5.Name = "label5";
            label5.Size = new Size(88, 24);
            label5.TabIndex = 0;
            label5.Text = "Revenue";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 64);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 0;
            label3.Text = "Bills Quality";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Theo ngày", "Theo tháng", "Theo năm" });
            comboBox1.Location = new Point(130, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 185);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 173);
            dataGridView1.TabIndex = 2;
            // 
            // buttonControl1
            // 
            buttonControl1.BackColor = Color.MediumSlateBlue;
            buttonControl1.BackgroundColor = Color.MediumSlateBlue;
            buttonControl1.BorderColor = Color.PaleVioletRed;
            buttonControl1.BorderRadius = 0;
            buttonControl1.BorderSize = 0;
            buttonControl1.FlatAppearance.BorderSize = 0;
            buttonControl1.FlatStyle = FlatStyle.Flat;
            buttonControl1.ForeColor = Color.White;
            buttonControl1.Location = new Point(31, 86);
            buttonControl1.Name = "buttonControl1";
            buttonControl1.Size = new Size(150, 40);
            buttonControl1.TabIndex = 1;
            buttonControl1.Text = "buttonControl1";
            buttonControl1.TextColor = Color.White;
            buttonControl1.UseVisualStyleBackColor = false;
            buttonControl1.Click += buttonControl1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 25);
            label4.Name = "label4";
            label4.Size = new Size(281, 24);
            label4.TabIndex = 0;
            label4.Text = "Compare revenue by formality";
            // 
            // StatisticalsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(splitContainer1);
            Size = new Size(1562, 941);
            ((System.ComponentModel.ISupportInitialize)dgvBestSeller).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)charRevenue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ComboBox cbBillsQuality;
        private Label label1;
        private SplitContainer splitContainer3;
        private ComboBox cbBestSeller;
        private Label label2;
        private Label label5;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private FlowLayoutPanel flpBillQuality;
        private Panel panel1;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Label txtIntoMoney;
        private AntdUI.Label txtTime;
        private AntdUI.Label txtIdBill;
        private DataGridView dgvBestSeller;
        private DataGridViewTextBoxColumn Stt;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn SellQuality;
        private DataGridViewTextBoxColumn Revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart charRevenue;
        private UIControl.ButtonControl buttonControl1;
        private DataGridView dataGridView1;
    }
}
