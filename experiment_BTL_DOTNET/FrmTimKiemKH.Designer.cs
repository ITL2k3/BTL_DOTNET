
namespace experiment_BTL_DOTNET
{
    partial class FrmTimKiemKH
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
            this.optEmail = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tBoxTKH = new System.Windows.Forms.TextBox();
            this.tBoxMKH = new System.Windows.Forms.TextBox();
            this.optSDT = new System.Windows.Forms.RadioButton();
            this.optTenKH = new System.Windows.Forms.RadioButton();
            this.optNhapMKH = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxSDT = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // optEmail
            // 
            this.optEmail.AutoSize = true;
            this.optEmail.Location = new System.Drawing.Point(29, 164);
            this.optEmail.Name = "optEmail";
            this.optEmail.Size = new System.Drawing.Size(100, 21);
            this.optEmail.TabIndex = 23;
            this.optEmail.TabStop = true;
            this.optEmail.Text = "Nhập email";
            this.optEmail.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 189);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(465, 83);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 48);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tBoxTKH
            // 
            this.tBoxTKH.Location = new System.Drawing.Point(199, 113);
            this.tBoxTKH.Name = "tBoxTKH";
            this.tBoxTKH.Size = new System.Drawing.Size(236, 22);
            this.tBoxTKH.TabIndex = 18;
            // 
            // tBoxMKH
            // 
            this.tBoxMKH.Location = new System.Drawing.Point(199, 85);
            this.tBoxMKH.Name = "tBoxMKH";
            this.tBoxMKH.Size = new System.Drawing.Size(236, 22);
            this.tBoxMKH.TabIndex = 17;
            // 
            // optSDT
            // 
            this.optSDT.AutoSize = true;
            this.optSDT.Location = new System.Drawing.Point(29, 137);
            this.optSDT.Name = "optSDT";
            this.optSDT.Size = new System.Drawing.Size(148, 21);
            this.optSDT.TabIndex = 16;
            this.optSDT.TabStop = true;
            this.optSDT.Text = "Nhập số điện thoại";
            this.optSDT.UseVisualStyleBackColor = true;
            // 
            // optTenKH
            // 
            this.optTenKH.AutoSize = true;
            this.optTenKH.Location = new System.Drawing.Point(29, 110);
            this.optTenKH.Name = "optTenKH";
            this.optTenKH.Size = new System.Drawing.Size(165, 21);
            this.optTenKH.TabIndex = 15;
            this.optTenKH.TabStop = true;
            this.optTenKH.Text = "Nhập tên khách hàng";
            this.optTenKH.UseVisualStyleBackColor = true;
            // 
            // optNhapMKH
            // 
            this.optNhapMKH.AutoSize = true;
            this.optNhapMKH.Location = new System.Drawing.Point(29, 84);
            this.optNhapMKH.Name = "optNhapMKH";
            this.optNhapMKH.Size = new System.Drawing.Size(164, 21);
            this.optNhapMKH.TabIndex = 14;
            this.optNhapMKH.TabStop = true;
            this.optNhapMKH.Text = "Nhập mã khách hàng";
            this.optNhapMKH.UseVisualStyleBackColor = true;
            this.optNhapMKH.CheckedChanged += new System.EventHandler(this.optNhapMKH_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "TÌM KIẾM THÔNG TIN KHÁCH HÀNG";
            // 
            // tBoxSDT
            // 
            this.tBoxSDT.Location = new System.Drawing.Point(199, 141);
            this.tBoxSDT.Name = "tBoxSDT";
            this.tBoxSDT.Size = new System.Drawing.Size(236, 22);
            this.tBoxSDT.TabIndex = 24;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(199, 169);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(236, 22);
            this.tBoxEmail.TabIndex = 25;
            this.tBoxEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmTimKiemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 409);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxSDT);
            this.Controls.Add(this.optEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tBoxTKH);
            this.Controls.Add(this.tBoxMKH);
            this.Controls.Add(this.optSDT);
            this.Controls.Add(this.optTenKH);
            this.Controls.Add(this.optNhapMKH);
            this.Controls.Add(this.label2);
            this.Name = "FrmTimKiemKH";
            this.Text = "FrmTimKiemKH";
            this.Load += new System.EventHandler(this.FrmTimKiemKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tBoxTKH;
        private System.Windows.Forms.TextBox tBoxMKH;
        private System.Windows.Forms.RadioButton optSDT;
        private System.Windows.Forms.RadioButton optTenKH;
        private System.Windows.Forms.RadioButton optNhapMKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxSDT;
        private System.Windows.Forms.TextBox tBoxEmail;
    }
}