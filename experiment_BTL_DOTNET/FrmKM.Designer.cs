
namespace experiment_BTL_DOTNET
{
    partial class FrmKM
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
            this.tBoxMKM = new System.Windows.Forms.TextBox();
            this.tBoxTCT = new System.Windows.Forms.TextBox();
            this.tBoxTGAD = new System.Windows.Forms.TextBox();
            this.tBoxMoTa = new System.Windows.Forms.RichTextBox();
            this.tBoxDKAD = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khuyến mãi ";
            // 
            // tBoxMKM
            // 
            this.tBoxMKM.Location = new System.Drawing.Point(161, 85);
            this.tBoxMKM.Name = "tBoxMKM";
            this.tBoxMKM.ReadOnly = true;
            this.tBoxMKM.Size = new System.Drawing.Size(126, 22);
            this.tBoxMKM.TabIndex = 1;
            this.tBoxMKM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tBoxTCT
            // 
            this.tBoxTCT.Location = new System.Drawing.Point(161, 126);
            this.tBoxTCT.Name = "tBoxTCT";
            this.tBoxTCT.ReadOnly = true;
            this.tBoxTCT.Size = new System.Drawing.Size(126, 22);
            this.tBoxTCT.TabIndex = 2;
            this.tBoxTCT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tBoxTGAD
            // 
            this.tBoxTGAD.Location = new System.Drawing.Point(161, 165);
            this.tBoxTGAD.Name = "tBoxTGAD";
            this.tBoxTGAD.ReadOnly = true;
            this.tBoxTGAD.Size = new System.Drawing.Size(126, 22);
            this.tBoxTGAD.TabIndex = 3;
            this.tBoxTGAD.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tBoxMoTa
            // 
            this.tBoxMoTa.Location = new System.Drawing.Point(379, 88);
            this.tBoxMoTa.Name = "tBoxMoTa";
            this.tBoxMoTa.ReadOnly = true;
            this.tBoxMoTa.Size = new System.Drawing.Size(230, 104);
            this.tBoxMoTa.TabIndex = 4;
            this.tBoxMoTa.Text = "";
            // 
            // tBoxDKAD
            // 
            this.tBoxDKAD.Location = new System.Drawing.Point(785, 88);
            this.tBoxDKAD.Name = "tBoxDKAD";
            this.tBoxDKAD.ReadOnly = true;
            this.tBoxDKAD.Size = new System.Drawing.Size(230, 104);
            this.tBoxDKAD.TabIndex = 5;
            this.tBoxDKAD.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã khuyến mãi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên chương trình:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thời gian áp dụng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điều kiện áp dụng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 216);
            this.dataGridView1.TabIndex = 11;
            // 
            // FrmKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxDKAD);
            this.Controls.Add(this.tBoxMoTa);
            this.Controls.Add(this.tBoxTGAD);
            this.Controls.Add(this.tBoxTCT);
            this.Controls.Add(this.tBoxMKM);
            this.Controls.Add(this.label1);
            this.Name = "FrmKM";
            this.Text = "FrmKM";
            this.Load += new System.EventHandler(this.FrmKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMKM;
        private System.Windows.Forms.TextBox tBoxTCT;
        private System.Windows.Forms.TextBox tBoxTGAD;
        private System.Windows.Forms.RichTextBox tBoxMoTa;
        private System.Windows.Forms.RichTextBox tBoxDKAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}