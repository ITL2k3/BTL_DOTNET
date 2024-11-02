
namespace experiment_BTL_DOTNET
{
    partial class FrmPHKH
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
            this.tBoxMKH = new System.Windows.Forms.TextBox();
            this.tBoxMaXe = new System.Windows.Forms.TextBox();
            this.cBoxDgia = new System.Windows.Forms.ComboBox();
            this.tBoxBL = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẢN HỒI KHÁCH HÀNG";
            // 
            // tBoxMKH
            // 
            this.tBoxMKH.Location = new System.Drawing.Point(125, 93);
            this.tBoxMKH.Name = "tBoxMKH";
            this.tBoxMKH.Size = new System.Drawing.Size(232, 22);
            this.tBoxMKH.TabIndex = 1;
            // 
            // tBoxMaXe
            // 
            this.tBoxMaXe.Location = new System.Drawing.Point(125, 134);
            this.tBoxMaXe.Name = "tBoxMaXe";
            this.tBoxMaXe.Size = new System.Drawing.Size(232, 22);
            this.tBoxMaXe.TabIndex = 2;
            this.tBoxMaXe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cBoxDgia
            // 
            this.cBoxDgia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDgia.FormattingEnabled = true;
            this.cBoxDgia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBoxDgia.Location = new System.Drawing.Point(125, 172);
            this.cBoxDgia.Name = "cBoxDgia";
            this.cBoxDgia.Size = new System.Drawing.Size(232, 24);
            this.cBoxDgia.TabIndex = 5;
            // 
            // tBoxBL
            // 
            this.tBoxBL.Location = new System.Drawing.Point(125, 215);
            this.tBoxBL.Name = "tBoxBL";
            this.tBoxBL.Size = new System.Drawing.Size(231, 214);
            this.tBoxBL.TabIndex = 6;
            this.tBoxBL.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã xe:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đánh giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bình luận:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(194, 441);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(162, 47);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Hoàn tất";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnTM
            // 
            this.btnTM.Location = new System.Drawing.Point(125, 441);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(63, 47);
            this.btnTM.TabIndex = 12;
            this.btnTM.Text = "Tạo mới";
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // FrmPHKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 500);
            this.Controls.Add(this.btnTM);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxBL);
            this.Controls.Add(this.cBoxDgia);
            this.Controls.Add(this.tBoxMaXe);
            this.Controls.Add(this.tBoxMKH);
            this.Controls.Add(this.label1);
            this.Name = "FrmPHKH";
            this.Text = "form phản hồi";
            this.Load += new System.EventHandler(this.FrmPHKH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMKH;
        private System.Windows.Forms.TextBox tBoxMaXe;
        private System.Windows.Forms.ComboBox cBoxDgia;
        private System.Windows.Forms.RichTextBox tBoxBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnTM;
    }
}