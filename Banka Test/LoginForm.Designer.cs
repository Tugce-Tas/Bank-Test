namespace Banka_Test
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LinkKayit = new System.Windows.Forms.LinkLabel();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Location = new System.Drawing.Point(209, 97);
            this.MskHesapNo.Mask = "000000000";
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(164, 26);
            this.MskHesapNo.TabIndex = 1;
            this.MskHesapNo.ValidatingType = typeof(int);
            this.MskHesapNo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskHesapNo_MaskInputRejected);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(209, 225);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(163, 32);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LinkKayit
            // 
            this.LinkKayit.AutoSize = true;
            this.LinkKayit.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LinkKayit.Location = new System.Drawing.Point(254, 292);
            this.LinkKayit.Name = "LinkKayit";
            this.LinkKayit.Size = new System.Drawing.Size(56, 16);
            this.LinkKayit.TabIndex = 4;
            this.LinkKayit.TabStop = true;
            this.LinkKayit.Text = "Kayıt Ol";
            this.LinkKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkKayit_LinkClicked);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(208, 159);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(164, 26);
            this.TxtSifre.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 356);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.LinkKayit);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.MskHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LinkKayit;
        private System.Windows.Forms.TextBox TxtSifre;
    }
}

