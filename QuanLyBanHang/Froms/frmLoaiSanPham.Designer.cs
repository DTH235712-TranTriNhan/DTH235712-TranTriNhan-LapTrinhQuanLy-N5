namespace QuanLyBanHang.Froms
{
    partial class frmLoaiSanPham
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
            label3 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtTenLoai = new Label();
            textBox1 = new TextBox();
            btnThem = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 122);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 10;
            label3.Text = "Danh sách loại sản phẩm";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(5, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 298);
            panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(787, 298);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 43;
            // 
            // TenLoai
            // 
            TenLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên loại sản phẩm";
            TenLoai.Name = "TenLoai";
            TenLoai.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Thông tin loại sản phẩm";
            // 
            // txtTenLoai
            // 
            txtTenLoai.AutoSize = true;
            txtTenLoai.Location = new Point(39, 41);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(121, 15);
            txtTenLoai.TabIndex = 1;
            txtTenLoai.Text = "Tên loại sản phẩm (*):\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(583, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(163, 67);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += this.button1_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(567, 67);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(83, 30);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += this.button2_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(461, 67);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(83, 30);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += this.button3_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(665, 67);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(83, 30);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button4_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(261, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 30);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += this.button5_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(361, 67);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 30);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += this.button6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtTenLoai);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 108);
            panel1.TabIndex = 11;
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Name = "frmLoaiSanPham";
            Text = "Loại Sản Phẩm";
            Load += this.frmLoaiSanPham_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private Label label1;
        private Label txtTenLoai;
        private TextBox textBox1;
        private Button btnThem;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Panel panel1;
    }
}