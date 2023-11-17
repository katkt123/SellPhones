﻿namespace SellPhones.GUI.UserControls
{
    partial class TaiKhoanUC
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
            tabControl1 = new TabControl();
            tabPage_TK = new TabPage();
            button_Khoa = new Button();
            button_Search = new Button();
            textBox_Search = new TextBox();
            comboBox_Type = new ComboBox();
            panel2 = new Panel();
            button_Refresh = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox_MK = new TextBox();
            label2 = new Label();
            textBox_TK = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            Grid_TaiKhoan = new DataGridView();
            button_Sua = new Button();
            tabPage_Quyen = new TabPage();
            button_CapQuyen = new Button();
            comboBox_Quyen = new ComboBox();
            panel3 = new Panel();
            Grid_Quyen = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage_TK.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_TaiKhoan).BeginInit();
            tabPage_Quyen.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_Quyen).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_TK);
            tabControl1.Controls.Add(tabPage_Quyen);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(980, 500);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_TK
            // 
            tabPage_TK.Controls.Add(button_Khoa);
            tabPage_TK.Controls.Add(button_Search);
            tabPage_TK.Controls.Add(textBox_Search);
            tabPage_TK.Controls.Add(comboBox_Type);
            tabPage_TK.Controls.Add(panel2);
            tabPage_TK.Controls.Add(panel1);
            tabPage_TK.Controls.Add(button_Sua);
            tabPage_TK.Location = new Point(4, 29);
            tabPage_TK.Name = "tabPage_TK";
            tabPage_TK.Padding = new Padding(3);
            tabPage_TK.Size = new Size(972, 467);
            tabPage_TK.TabIndex = 0;
            tabPage_TK.Text = "Tài Khoản";
            tabPage_TK.UseVisualStyleBackColor = true;
            tabPage_TK.Click += tabPage_TK_Click;
            // 
            // button_Khoa
            // 
            button_Khoa.Location = new Point(815, 95);
            button_Khoa.Name = "button_Khoa";
            button_Khoa.Size = new Size(151, 70);
            button_Khoa.TabIndex = 15;
            button_Khoa.Text = "Khóa";
            button_Khoa.UseVisualStyleBackColor = true;
            button_Khoa.Click += button_Khoa_Click;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(640, 196);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(137, 29);
            button_Search.TabIndex = 14;
            button_Search.Text = "Tìm Kiếm";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // textBox_Search
            // 
            textBox_Search.Location = new Point(386, 197);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(246, 27);
            textBox_Search.TabIndex = 13;
            // 
            // comboBox_Type
            // 
            comboBox_Type.FormattingEnabled = true;
            comboBox_Type.Items.AddRange(new object[] { "Mã Tài Khoản", "Tên Tài Khoản" });
            comboBox_Type.Location = new Point(256, 197);
            comboBox_Type.Name = "comboBox_Type";
            comboBox_Type.Size = new Size(124, 28);
            comboBox_Type.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_Refresh);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_MK);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_TK);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 155);
            panel2.TabIndex = 2;
            // 
            // button_Refresh
            // 
            button_Refresh.Location = new Point(440, 100);
            button_Refresh.Name = "button_Refresh";
            button_Refresh.Size = new Size(39, 39);
            button_Refresh.TabIndex = 15;
            button_Refresh.UseVisualStyleBackColor = true;
            button_Refresh.Click += button_Refresh_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(440, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 27);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(440, 12);
            label3.Name = "label3";
            label3.Size = new Size(124, 22);
            label3.TabIndex = 11;
            label3.Text = "Mã Tài Khoản";
            // 
            // textBox_MK
            // 
            textBox_MK.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MK.Location = new Point(19, 116);
            textBox_MK.Name = "textBox_MK";
            textBox_MK.Size = new Size(334, 23);
            textBox_MK.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 91);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // textBox_TK
            // 
            textBox_TK.Location = new Point(19, 37);
            textBox_TK.Name = "textBox_TK";
            textBox_TK.Size = new Size(334, 27);
            textBox_TK.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 22);
            label1.TabIndex = 0;
            label1.Text = "Tên Tài Khoản";
            // 
            // panel1
            // 
            panel1.Controls.Add(Grid_TaiKhoan);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 246);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 218);
            panel1.TabIndex = 1;
            // 
            // Grid_TaiKhoan
            // 
            Grid_TaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_TaiKhoan.Dock = DockStyle.Fill;
            Grid_TaiKhoan.Location = new Point(0, 0);
            Grid_TaiKhoan.Name = "Grid_TaiKhoan";
            Grid_TaiKhoan.RowHeadersWidth = 51;
            Grid_TaiKhoan.RowTemplate.Height = 29;
            Grid_TaiKhoan.Size = new Size(966, 218);
            Grid_TaiKhoan.TabIndex = 0;
            Grid_TaiKhoan.CellClick += Grid_TaiKhoan_CellClick;
            Grid_TaiKhoan.CellContentClick += Grid_TaiKhoan_CellContentClick;
            Grid_TaiKhoan.SelectionChanged += Grid_TaiKhoan_SelectionChanged;
            // 
            // button_Sua
            // 
            button_Sua.Location = new Point(815, 14);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(151, 61);
            button_Sua.TabIndex = 10;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = true;
            button_Sua.Click += button_Sua_Click;
            // 
            // tabPage_Quyen
            // 
            tabPage_Quyen.Controls.Add(button_CapQuyen);
            tabPage_Quyen.Controls.Add(comboBox_Quyen);
            tabPage_Quyen.Controls.Add(panel3);
            tabPage_Quyen.Location = new Point(4, 29);
            tabPage_Quyen.Name = "tabPage_Quyen";
            tabPage_Quyen.Padding = new Padding(3);
            tabPage_Quyen.Size = new Size(972, 467);
            tabPage_Quyen.TabIndex = 1;
            tabPage_Quyen.Text = "Quyền";
            tabPage_Quyen.UseVisualStyleBackColor = true;
            // 
            // button_CapQuyen
            // 
            button_CapQuyen.Location = new Point(359, 68);
            button_CapQuyen.Name = "button_CapQuyen";
            button_CapQuyen.Size = new Size(238, 54);
            button_CapQuyen.TabIndex = 2;
            button_CapQuyen.Text = "Cấp Quyền";
            button_CapQuyen.UseVisualStyleBackColor = true;
            button_CapQuyen.Click += button_CapQuyen_Click;
            // 
            // comboBox_Quyen
            // 
            comboBox_Quyen.FormattingEnabled = true;
            comboBox_Quyen.Items.AddRange(new object[] { "Quản Lý", "Nhân Viên", "Khách Hàng", "Khóa" });
            comboBox_Quyen.Location = new Point(374, 22);
            comboBox_Quyen.Name = "comboBox_Quyen";
            comboBox_Quyen.Size = new Size(211, 28);
            comboBox_Quyen.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(Grid_Quyen);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(966, 308);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // Grid_Quyen
            // 
            Grid_Quyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_Quyen.Dock = DockStyle.Fill;
            Grid_Quyen.Location = new Point(0, 0);
            Grid_Quyen.Name = "Grid_Quyen";
            Grid_Quyen.RowHeadersWidth = 51;
            Grid_Quyen.RowTemplate.Height = 29;
            Grid_Quyen.Size = new Size(966, 308);
            Grid_Quyen.TabIndex = 0;
            Grid_Quyen.SelectionChanged += Grid_Quyen_SelectionChanged;
            // 
            // TaiKhoanUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "TaiKhoanUC";
            Size = new Size(980, 500);
            tabControl1.ResumeLayout(false);
            tabPage_TK.ResumeLayout(false);
            tabPage_TK.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_TaiKhoan).EndInit();
            tabPage_Quyen.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Grid_Quyen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_TK;
        private TabPage tabPage_Quyen;
        private Panel panel1;
        private DataGridView Grid_TaiKhoan;
        private Label label1;
        private Panel panel2;
        private Button button_Them;
        private TextBox textBox_MK;
        private Label label2;
        private TextBox textBox_TK;
        private Button button_Sua;
        private Button button_Search;
        private TextBox textBox_Search;
        private ComboBox comboBox_Type;
        private Button button_Refresh;
        private Panel panel3;
        private DataGridView Grid_Quyen;
        private Button button_CapQuyen;
        private ComboBox comboBox_Quyen;
        private TextBox textBox1;
        private Label label3;
        private Button button_Khoa;
    }
}
