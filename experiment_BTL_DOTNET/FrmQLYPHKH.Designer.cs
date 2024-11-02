
namespace experiment_BTL_DOTNET
{
    partial class FrmQLYPHKH
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxBL = new System.Windows.Forms.RichTextBox();
            this.cBoxDgia = new System.Windows.Forms.ComboBox();
            this.tBoxMaXe = new System.Windows.Forms.TextBox();
            this.tBoxMKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxMaPhanHoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Bình luận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Đánh giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã khách hàng:";
            // 
            // tBoxBL
            // 
            this.tBoxBL.Location = new System.Drawing.Point(481, 75);
            this.tBoxBL.Name = "tBoxBL";
            this.tBoxBL.ReadOnly = true;
            this.tBoxBL.Size = new System.Drawing.Size(362, 135);
            this.tBoxBL.TabIndex = 17;
            this.tBoxBL.Text = "";
            // 
            // cBoxDgia
            // 
            this.cBoxDgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDgia.Enabled = false;
            this.cBoxDgia.FormattingEnabled = true;
            this.cBoxDgia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxDgia.Location = new System.Drawing.Point(134, 186);
            this.cBoxDgia.Name = "cBoxDgia";
            this.cBoxDgia.Size = new System.Drawing.Size(232, 24);
            this.cBoxDgia.TabIndex = 16;
            // 
            // tBoxMaXe
            // 
            this.tBoxMaXe.Location = new System.Drawing.Point(134, 148);
            this.tBoxMaXe.Name = "tBoxMaXe";
            this.tBoxMaXe.ReadOnly = true;
            this.tBoxMaXe.Size = new System.Drawing.Size(232, 22);
            this.tBoxMaXe.TabIndex = 15;
            // 
            // tBoxMKH
            // 
            this.tBoxMKH.Location = new System.Drawing.Point(134, 112);
            this.tBoxMKH.Name = "tBoxMKH";
            this.tBoxMKH.ReadOnly = true;
            this.tBoxMKH.Size = new System.Drawing.Size(232, 22);
            this.tBoxMKH.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "PHẢN HỒI KHÁCH HÀNG";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 214);
            this.dataGridView1.TabIndex = 22;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(753, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 52);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa phản hồi";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(753, 282);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 52);
            this.btnReload.TabIndex = 24;
            this.btnReload.Text = "Tải lại dữ liệu";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã phản hồi:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tBoxMaPhanHoi
            // 
            this.tBoxMaPhanHoi.Location = new System.Drawing.Point(134, 75);
            this.tBoxMaPhanHoi.Name = "tBoxMaPhanHoi";
            this.tBoxMaPhanHoi.ReadOnly = true;
            this.tBoxMaPhanHoi.Size = new System.Drawing.Size(232, 22);
            this.tBoxMaPhanHoi.TabIndex = 25;
            // 
            // FrmQLYPHKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxMaPhanHoi);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxBL);
            this.Controls.Add(this.cBoxDgia);
            this.Controls.Add(this.tBoxMaXe);
            this.Controls.Add(this.tBoxMKH);
            this.Controls.Add(this.label1);
            this.Name = "FrmQLYPHKH";
            this.Text = "FrmQLYPHKH";
            this.Load += new System.EventHandler(this.FrmQLYPHKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tBoxBL;
        private System.Windows.Forms.ComboBox cBoxDgia;
        private System.Windows.Forms.TextBox tBoxMaXe;
        private System.Windows.Forms.TextBox tBoxMKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxMaPhanHoi;
    }
}