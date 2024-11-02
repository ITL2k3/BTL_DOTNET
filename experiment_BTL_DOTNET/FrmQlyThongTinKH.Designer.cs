
namespace experiment_BTL_DOTNET
{
    partial class FrmQlyThongTinKH
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tBoxMKH = new System.Windows.Forms.TextBox();
            this.tBoxHvT = new System.Windows.Forms.TextBox();
            this.tBoxNS = new System.Windows.Forms.TextBox();
            this.tBoxSDT = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxDC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxLSMH = new System.Windows.Forms.RichTextBox();
            this.buttonTKH = new System.Windows.Forms.Button();
            this.btnSKH = new System.Windows.Forms.Button();
            this.btnTMKH = new System.Windows.Forms.Button();
            this.btnXKH = new System.Windows.Forms.Button();
            this.btnTKKH = new System.Windows.Forms.Button();
            this.cBoxGT = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 180);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(557, 223);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tBoxMKH
            // 
            this.tBoxMKH.Location = new System.Drawing.Point(136, 15);
            this.tBoxMKH.Name = "tBoxMKH";
            this.tBoxMKH.Size = new System.Drawing.Size(100, 22);
            this.tBoxMKH.TabIndex = 2;
            this.tBoxMKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBoxHvT
            // 
            this.tBoxHvT.Location = new System.Drawing.Point(136, 52);
            this.tBoxHvT.Name = "tBoxHvT";
            this.tBoxHvT.Size = new System.Drawing.Size(100, 22);
            this.tBoxHvT.TabIndex = 3;
            // 
            // tBoxNS
            // 
            this.tBoxNS.Location = new System.Drawing.Point(136, 95);
            this.tBoxNS.Name = "tBoxNS";
            this.tBoxNS.Size = new System.Drawing.Size(100, 22);
            this.tBoxNS.TabIndex = 4;
            // 
            // tBoxSDT
            // 
            this.tBoxSDT.Location = new System.Drawing.Point(368, 12);
            this.tBoxSDT.Name = "tBoxSDT";
            this.tBoxSDT.Size = new System.Drawing.Size(100, 22);
            this.tBoxSDT.TabIndex = 6;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(368, 52);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.tBoxEmail.TabIndex = 7;
            // 
            // tBoxDC
            // 
            this.tBoxDC.Location = new System.Drawing.Point(136, 134);
            this.tBoxDC.Name = "tBoxDC";
            this.tBoxDC.Size = new System.Drawing.Size(100, 22);
            this.tBoxDC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giới tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lịch sử mua hàng:";
            // 
            // tBoxLSMH
            // 
            this.tBoxLSMH.Location = new System.Drawing.Point(508, 32);
            this.tBoxLSMH.Name = "tBoxLSMH";
            this.tBoxLSMH.Size = new System.Drawing.Size(280, 124);
            this.tBoxLSMH.TabIndex = 18;
            this.tBoxLSMH.Text = "";
            // 
            // buttonTKH
            // 
            this.buttonTKH.Location = new System.Drawing.Point(605, 271);
            this.buttonTKH.Name = "buttonTKH";
            this.buttonTKH.Size = new System.Drawing.Size(150, 39);
            this.buttonTKH.TabIndex = 19;
            this.buttonTKH.Text = "Thêm khách hàng";
            this.buttonTKH.UseVisualStyleBackColor = true;
            this.buttonTKH.Click += new System.EventHandler(this.buttonTKH_Click);
            // 
            // btnSKH
            // 
            this.btnSKH.Location = new System.Drawing.Point(605, 316);
            this.btnSKH.Name = "btnSKH";
            this.btnSKH.Size = new System.Drawing.Size(150, 36);
            this.btnSKH.TabIndex = 20;
            this.btnSKH.Text = "Sửa khách hàng";
            this.btnSKH.UseVisualStyleBackColor = true;
            this.btnSKH.Click += new System.EventHandler(this.btnSKH_Click);
            // 
            // btnTMKH
            // 
            this.btnTMKH.Location = new System.Drawing.Point(605, 225);
            this.btnTMKH.Name = "btnTMKH";
            this.btnTMKH.Size = new System.Drawing.Size(150, 40);
            this.btnTMKH.TabIndex = 21;
            this.btnTMKH.Text = "Tạo mới khách hàng";
            this.btnTMKH.UseVisualStyleBackColor = true;
            this.btnTMKH.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXKH
            // 
            this.btnXKH.Location = new System.Drawing.Point(605, 361);
            this.btnXKH.Name = "btnXKH";
            this.btnXKH.Size = new System.Drawing.Size(150, 38);
            this.btnXKH.TabIndex = 22;
            this.btnXKH.Text = "Xóa khách hàng";
            this.btnXKH.UseVisualStyleBackColor = true;
            this.btnXKH.Click += new System.EventHandler(this.btnXKH_Click);
            // 
            // btnTKKH
            // 
            this.btnTKKH.Location = new System.Drawing.Point(605, 179);
            this.btnTKKH.Name = "btnTKKH";
            this.btnTKKH.Size = new System.Drawing.Size(150, 40);
            this.btnTKKH.TabIndex = 23;
            this.btnTKKH.Text = "Tìm kiếm khách hàng";
            this.btnTKKH.UseVisualStyleBackColor = true;
            this.btnTKKH.Click += new System.EventHandler(this.btnTKKH_Click);
            // 
            // cBoxGT
            // 
            this.cBoxGT.FormattingEnabled = true;
            this.cBoxGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cBoxGT.Location = new System.Drawing.Point(368, 89);
            this.cBoxGT.Name = "cBoxGT";
            this.cBoxGT.Size = new System.Drawing.Size(100, 24);
            this.cBoxGT.TabIndex = 24;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(272, 132);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(196, 27);
            this.btnReload.TabIndex = 25;
            this.btnReload.Text = "Tải lại bảng";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FrmQlyThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cBoxGT);
            this.Controls.Add(this.btnTKKH);
            this.Controls.Add(this.btnXKH);
            this.Controls.Add(this.btnTMKH);
            this.Controls.Add(this.btnSKH);
            this.Controls.Add(this.buttonTKH);
            this.Controls.Add(this.tBoxLSMH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxDC);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxSDT);
            this.Controls.Add(this.tBoxNS);
            this.Controls.Add(this.tBoxHvT);
            this.Controls.Add(this.tBoxMKH);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FrmQlyThongTinKH";
            this.Text = "FrmQlyThongTinKH";
            this.Load += new System.EventHandler(this.FrmQlyThongTinKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox tBoxMKH;
        private System.Windows.Forms.TextBox tBoxHvT;
        private System.Windows.Forms.TextBox tBoxNS;
        private System.Windows.Forms.TextBox tBoxSDT;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tBoxLSMH;
        private System.Windows.Forms.Button buttonTKH;
        private System.Windows.Forms.Button btnSKH;
        private System.Windows.Forms.Button btnTMKH;
        private System.Windows.Forms.Button btnXKH;
        private System.Windows.Forms.Button btnTKKH;
        private System.Windows.Forms.ComboBox cBoxGT;
        private System.Windows.Forms.Button btnReload;
    }
}