namespace PRL_testSP
{
    partial class Form1
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
            dtg_sp = new DataGridView();
            dtg_CTSP = new DataGridView();
            btn_ctsp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_masp = new TextBox();
            txt_tensp = new TextBox();
            txt_sl = new TextBox();
            txt_gia = new TextBox();
            cb_trangthai = new ComboBox();
            btn_addsp = new Button();
            btn_updatesp = new Button();
            rbtn_DB = new RadioButton();
            rbtn_hethang = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtg_sp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_CTSP).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_sp
            // 
            dtg_sp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sp.Location = new Point(600, 52);
            dtg_sp.Name = "dtg_sp";
            dtg_sp.RowHeadersWidth = 51;
            dtg_sp.Size = new Size(657, 230);
            dtg_sp.TabIndex = 0;
            dtg_sp.CellClick += dtg_sp_CellClick;
            // 
            // dtg_CTSP
            // 
            dtg_CTSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_CTSP.GridColor = SystemColors.ActiveCaptionText;
            dtg_CTSP.Location = new Point(12, 305);
            dtg_CTSP.Name = "dtg_CTSP";
            dtg_CTSP.RowHeadersWidth = 51;
            dtg_CTSP.Size = new Size(1245, 419);
            dtg_CTSP.TabIndex = 1;
            // 
            // btn_ctsp
            // 
            btn_ctsp.Location = new Point(394, 138);
            btn_ctsp.Name = "btn_ctsp";
            btn_ctsp.Size = new Size(94, 29);
            btn_ctsp.TabIndex = 2;
            btn_ctsp.Text = "CTSP";
            btn_ctsp.UseVisualStyleBackColor = true;
            btn_ctsp.Click += btn_ctsp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 59);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên Sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 111);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 159);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 9;
            label4.Text = "Giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 245);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Trạng thái";
            // 
            // txt_masp
            // 
            txt_masp.Location = new Point(132, 5);
            txt_masp.Name = "txt_masp";
            txt_masp.Size = new Size(151, 27);
            txt_masp.TabIndex = 11;
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(132, 52);
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(151, 27);
            txt_tensp.TabIndex = 12;
            // 
            // txt_sl
            // 
            txt_sl.Location = new Point(132, 104);
            txt_sl.Name = "txt_sl";
            txt_sl.Size = new Size(151, 27);
            txt_sl.TabIndex = 13;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(132, 159);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(151, 27);
            txt_gia.TabIndex = 14;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Items.AddRange(new object[] { "Đang bán", "Hết hàng", "Tất cả" });
            cb_trangthai.Location = new Point(1039, 18);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(151, 28);
            cb_trangthai.TabIndex = 15;
            cb_trangthai.SelectedIndexChanged += cb_trangthai_SelectedIndexChanged;
            // 
            // btn_addsp
            // 
            btn_addsp.Location = new Point(394, 26);
            btn_addsp.Name = "btn_addsp";
            btn_addsp.Size = new Size(94, 29);
            btn_addsp.TabIndex = 16;
            btn_addsp.Text = "Thêm";
            btn_addsp.UseVisualStyleBackColor = true;
            btn_addsp.Click += btn_addsp_Click;
            // 
            // btn_updatesp
            // 
            btn_updatesp.Location = new Point(394, 75);
            btn_updatesp.Name = "btn_updatesp";
            btn_updatesp.Size = new Size(94, 29);
            btn_updatesp.TabIndex = 17;
            btn_updatesp.Text = "Cập nhập";
            btn_updatesp.UseVisualStyleBackColor = true;
            btn_updatesp.Click += btn_updatesp_Click;
            // 
            // rbtn_DB
            // 
            rbtn_DB.AutoSize = true;
            rbtn_DB.Location = new Point(18, 26);
            rbtn_DB.Name = "rbtn_DB";
            rbtn_DB.Size = new Size(95, 24);
            rbtn_DB.TabIndex = 18;
            rbtn_DB.TabStop = true;
            rbtn_DB.Text = "Đang bán";
            rbtn_DB.UseVisualStyleBackColor = true;
            // 
            // rbtn_hethang
            // 
            rbtn_hethang.AutoSize = true;
            rbtn_hethang.Location = new Point(142, 26);
            rbtn_hethang.Name = "rbtn_hethang";
            rbtn_hethang.Size = new Size(91, 24);
            rbtn_hethang.TabIndex = 19;
            rbtn_hethang.TabStop = true;
            rbtn_hethang.Text = "Hết hàng";
            rbtn_hethang.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtn_hethang);
            groupBox1.Controls.Add(rbtn_DB);
            groupBox1.Location = new Point(132, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 60);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 736);
            Controls.Add(groupBox1);
            Controls.Add(btn_updatesp);
            Controls.Add(btn_addsp);
            Controls.Add(cb_trangthai);
            Controls.Add(txt_gia);
            Controls.Add(txt_sl);
            Controls.Add(txt_tensp);
            Controls.Add(txt_masp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_ctsp);
            Controls.Add(dtg_CTSP);
            Controls.Add(dtg_sp);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtg_sp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_CTSP).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_sp;
        private DataGridView dtg_CTSP;
        private Button btn_ctsp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_masp;
        private TextBox txt_tensp;
        private TextBox txt_sl;
        private TextBox txt_gia;
        private ComboBox cb_trangthai;
        private Button btn_addsp;
        private Button btn_updatesp;
        private RadioButton rbtn_DB;
        private RadioButton rbtn_hethang;
        private GroupBox groupBox1;
    }
}
