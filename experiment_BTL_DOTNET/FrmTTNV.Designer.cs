
namespace experiment_BTL_DOTNET
{
    partial class FrmTTNV
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxMNV = new System.Windows.Forms.TextBox();
            this.tBoxHvT = new System.Windows.Forms.TextBox();
            this.tBoxVTCV = new System.Windows.Forms.TextBox();
            this.tBoxSDT = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.tBoxDS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxMNV
            // 
            this.tBoxMNV.Location = new System.Drawing.Point(125, 87);
            this.tBoxMNV.Name = "tBoxMNV";
            this.tBoxMNV.Size = new System.Drawing.Size(100, 22);
            this.tBoxMNV.TabIndex = 1;
            this.tBoxMNV.TextChanged += new System.EventHandler(this.tBoxMNV_TextChanged);
            // 
            // tBoxHvT
            // 
            this.tBoxHvT.Location = new System.Drawing.Point(125, 127);
            this.tBoxHvT.Name = "tBoxHvT";
            this.tBoxHvT.Size = new System.Drawing.Size(100, 22);
            this.tBoxHvT.TabIndex = 2;
            // 
            // tBoxVTCV
            // 
            this.tBoxVTCV.Location = new System.Drawing.Point(125, 164);
            this.tBoxVTCV.Name = "tBoxVTCV";
            this.tBoxVTCV.Size = new System.Drawing.Size(100, 22);
            this.tBoxVTCV.TabIndex = 3;
            // 
            // tBoxSDT
            // 
            this.tBoxSDT.Location = new System.Drawing.Point(344, 87);
            this.tBoxSDT.Name = "tBoxSDT";
            this.tBoxSDT.Size = new System.Drawing.Size(100, 22);
            this.tBoxSDT.TabIndex = 4;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(344, 127);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.tBoxEmail.TabIndex = 5;
            this.tBoxEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tBoxDS
            // 
            this.tBoxDS.Enabled = false;
            this.tBoxDS.Location = new System.Drawing.Point(344, 164);
            this.tBoxDS.Name = "tBoxDS";
            this.tBoxDS.Size = new System.Drawing.Size(100, 22);
            this.tBoxDS.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vị trí công việc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doanh số:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 222);
            this.dataGridView1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tài khoản được cấp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 54);
            this.button2.TabIndex = 15;
            this.button2.Text = "Tạo mới nhân viên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 54);
            this.button3.TabIndex = 16;
            this.button3.Text = "Thêm nhân viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(475, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 54);
            this.button4.TabIndex = 17;
            this.button4.Text = "Sửa thông tin nhân viên";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(475, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 54);
            this.button5.TabIndex = 18;
            this.button5.Text = "Xóa nhân viên";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(475, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 54);
            this.button6.TabIndex = 19;
            this.button6.Text = "Tải lại dữ liệu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxDS);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxSDT);
            this.Controls.Add(this.tBoxVTCV);
            this.Controls.Add(this.tBoxHvT);
            this.Controls.Add(this.tBoxMNV);
            this.Controls.Add(this.label1);
            this.Name = "FrmTTNV";
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.FrmTTNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMNV;
        private System.Windows.Forms.TextBox tBoxHvT;
        private System.Windows.Forms.TextBox tBoxVTCV;
        private System.Windows.Forms.TextBox tBoxSDT;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.TextBox tBoxDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}