namespace Windows_Form_CheckBox_Kullanımı
{
	partial class Form1
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
			this.checkbox_cay = new System.Windows.Forms.CheckBox();
			this.checkbox_su = new System.Windows.Forms.CheckBox();
			this.checkbox_hamburger = new System.Windows.Forms.CheckBox();
			this.checkbox_pizza = new System.Windows.Forms.CheckBox();
			this.btn_hesapla = new System.Windows.Forms.Button();
			this.lbl_tutar = new System.Windows.Forms.Label();
			this.lbl_tutarsayisal = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// checkbox_cay
			// 
			this.checkbox_cay.AutoSize = true;
			this.checkbox_cay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.checkbox_cay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkbox_cay.Location = new System.Drawing.Point(31, 34);
			this.checkbox_cay.Name = "checkbox_cay";
			this.checkbox_cay.Size = new System.Drawing.Size(251, 59);
			this.checkbox_cay.TabIndex = 0;
			this.checkbox_cay.Text = "Çay 2 TL";
			this.checkbox_cay.UseVisualStyleBackColor = true;
			// 
			// checkbox_su
			// 
			this.checkbox_su.AutoSize = true;
			this.checkbox_su.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.checkbox_su.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkbox_su.Location = new System.Drawing.Point(31, 126);
			this.checkbox_su.Name = "checkbox_su";
			this.checkbox_su.Size = new System.Drawing.Size(224, 59);
			this.checkbox_su.TabIndex = 0;
			this.checkbox_su.Text = "Su 1 TL";
			this.checkbox_su.UseVisualStyleBackColor = true;
			// 
			// checkbox_hamburger
			// 
			this.checkbox_hamburger.AutoSize = true;
			this.checkbox_hamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.checkbox_hamburger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkbox_hamburger.Location = new System.Drawing.Point(31, 220);
			this.checkbox_hamburger.Name = "checkbox_hamburger";
			this.checkbox_hamburger.Size = new System.Drawing.Size(434, 59);
			this.checkbox_hamburger.TabIndex = 0;
			this.checkbox_hamburger.Text = "Hamburger 30 TL";
			this.checkbox_hamburger.UseVisualStyleBackColor = true;
			// 
			// checkbox_pizza
			// 
			this.checkbox_pizza.AutoSize = true;
			this.checkbox_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.checkbox_pizza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkbox_pizza.Location = new System.Drawing.Point(31, 314);
			this.checkbox_pizza.Name = "checkbox_pizza";
			this.checkbox_pizza.Size = new System.Drawing.Size(309, 59);
			this.checkbox_pizza.TabIndex = 0;
			this.checkbox_pizza.Text = "Pizza 50 TL";
			this.checkbox_pizza.UseVisualStyleBackColor = true;
			// 
			// btn_hesapla
			// 
			this.btn_hesapla.BackColor = System.Drawing.Color.DimGray;
			this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.btn_hesapla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_hesapla.Location = new System.Drawing.Point(31, 399);
			this.btn_hesapla.Name = "btn_hesapla";
			this.btn_hesapla.Size = new System.Drawing.Size(434, 105);
			this.btn_hesapla.TabIndex = 1;
			this.btn_hesapla.Text = "Hesapla";
			this.btn_hesapla.UseVisualStyleBackColor = false;
			this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
			// 
			// lbl_tutar
			// 
			this.lbl_tutar.AutoSize = true;
			this.lbl_tutar.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tutar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl_tutar.Location = new System.Drawing.Point(490, 44);
			this.lbl_tutar.Name = "lbl_tutar";
			this.lbl_tutar.Size = new System.Drawing.Size(246, 71);
			this.lbl_tutar.TabIndex = 2;
			this.lbl_tutar.Text = "Tutar:";
			// 
			// lbl_tutarsayisal
			// 
			this.lbl_tutarsayisal.AutoSize = true;
			this.lbl_tutarsayisal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.lbl_tutarsayisal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl_tutarsayisal.Location = new System.Drawing.Point(683, 44);
			this.lbl_tutarsayisal.Name = "lbl_tutarsayisal";
			this.lbl_tutarsayisal.Size = new System.Drawing.Size(0, 69);
			this.lbl_tutarsayisal.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1345, 856);
			this.Controls.Add(this.lbl_tutarsayisal);
			this.Controls.Add(this.lbl_tutar);
			this.Controls.Add(this.btn_hesapla);
			this.Controls.Add(this.checkbox_pizza);
			this.Controls.Add(this.checkbox_hamburger);
			this.Controls.Add(this.checkbox_su);
			this.Controls.Add(this.checkbox_cay);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkbox_cay;
		private System.Windows.Forms.CheckBox checkbox_su;
		private System.Windows.Forms.CheckBox checkbox_hamburger;
		private System.Windows.Forms.CheckBox checkbox_pizza;
		private System.Windows.Forms.Button btn_hesapla;
		private System.Windows.Forms.Label lbl_tutar;
		private System.Windows.Forms.Label lbl_tutarsayisal;
	}
}

