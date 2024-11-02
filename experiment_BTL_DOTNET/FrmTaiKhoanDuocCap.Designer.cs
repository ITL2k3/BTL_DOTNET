
namespace experiment_BTL_DOTNET
{
    partial class FrmTaiKhoanDuocCap
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
            this.tBoxTTK = new System.Windows.Forms.TextBox();
            this.tBoxMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản được cấp";
            // 
            // tBoxMNV
            // 
            this.tBoxMNV.Enabled = false;
            this.tBoxMNV.Location = new System.Drawing.Point(156, 58);
            this.tBoxMNV.Name = "tBoxMNV";
            this.tBoxMNV.Size = new System.Drawing.Size(128, 22);
            this.tBoxMNV.TabIndex = 1;
            // 
            // tBoxTTK
            // 
            this.tBoxTTK.Enabled = false;
            this.tBoxTTK.Location = new System.Drawing.Point(156, 96);
            this.tBoxTTK.Name = "tBoxTTK";
            this.tBoxTTK.Size = new System.Drawing.Size(128, 22);
            this.tBoxTTK.TabIndex = 2;
            this.tBoxTTK.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tBoxMK
            // 
            this.tBoxMK.Location = new System.Drawing.Point(156, 134);
            this.tBoxMK.Name = "tBoxMK";
            this.tBoxMK.Size = new System.Drawing.Size(128, 22);
            this.tBoxMK.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên tài khoản:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mật khẩu:";
            // 
            // btnDMK
            // 
            this.btnDMK.Location = new System.Drawing.Point(156, 173);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(128, 39);
            this.btnDMK.TabIndex = 7;
            this.btnDMK.Text = "Đổi mật khẩu";
            this.btnDMK.UseVisualStyleBackColor = true;
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // FrmTaiKhoanDuocCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 246);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxMK);
            this.Controls.Add(this.tBoxTTK);
            this.Controls.Add(this.tBoxMNV);
            this.Controls.Add(this.label1);
            this.Name = "FrmTaiKhoanDuocCap";
            this.Text = "Form tài khoản";
            this.Load += new System.EventHandler(this.FrmTaiKhoanDuocCap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxMNV;
        private System.Windows.Forms.TextBox tBoxTTK;
        private System.Windows.Forms.TextBox tBoxMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDMK;
    }
}