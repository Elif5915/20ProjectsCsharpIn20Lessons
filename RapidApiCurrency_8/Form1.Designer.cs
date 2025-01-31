namespace RapidApiCurrency_8
{
	partial class Form1
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
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblBirimTutar = new System.Windows.Forms.Label();
            this.txtBirimTutar = new System.Windows.Forms.TextBox();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbSterlin = new System.Windows.Forms.RadioButton();
            this.btnİslemYap = new System.Windows.Forms.Button();
            this.txtOdenecekTutar = new System.Windows.Forms.TextBox();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.lblSterlin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolar.Location = new System.Drawing.Point(52, 66);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(64, 22);
            this.lblDolar.TabIndex = 0;
            this.lblDolar.Text = "label1";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuro.Location = new System.Drawing.Point(236, 66);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(64, 22);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "label3";
            // 
            // lblBirimTutar
            // 
            this.lblBirimTutar.AutoSize = true;
            this.lblBirimTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimTutar.Location = new System.Drawing.Point(51, 219);
            this.lblBirimTutar.Name = "lblBirimTutar";
            this.lblBirimTutar.Size = new System.Drawing.Size(109, 22);
            this.lblBirimTutar.TabIndex = 4;
            this.lblBirimTutar.Text = "Birim Tutar";
            // 
            // txtBirimTutar
            // 
            this.txtBirimTutar.Location = new System.Drawing.Point(232, 219);
            this.txtBirimTutar.Name = "txtBirimTutar";
            this.txtBirimTutar.Size = new System.Drawing.Size(222, 22);
            this.txtBirimTutar.TabIndex = 5;
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbDolar.Location = new System.Drawing.Point(96, 130);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(79, 26);
            this.rdbDolar.TabIndex = 6;
            this.rdbDolar.TabStop = true;
            this.rdbDolar.Text = "Dolar";
            this.rdbDolar.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbEuro.Location = new System.Drawing.Point(220, 130);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(73, 26);
            this.rdbEuro.TabIndex = 7;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbSterlin
            // 
            this.rdbSterlin.AutoSize = true;
            this.rdbSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbSterlin.Location = new System.Drawing.Point(353, 130);
            this.rdbSterlin.Name = "rdbSterlin";
            this.rdbSterlin.Size = new System.Drawing.Size(89, 26);
            this.rdbSterlin.TabIndex = 8;
            this.rdbSterlin.TabStop = true;
            this.rdbSterlin.Text = "Sterlin";
            this.rdbSterlin.UseVisualStyleBackColor = true;
            // 
            // btnİslemYap
            // 
            this.btnİslemYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİslemYap.Location = new System.Drawing.Point(318, 303);
            this.btnİslemYap.Name = "btnİslemYap";
            this.btnİslemYap.Size = new System.Drawing.Size(136, 46);
            this.btnİslemYap.TabIndex = 9;
            this.btnİslemYap.Text = "İşlemi Yap";
            this.btnİslemYap.UseVisualStyleBackColor = true;
            this.btnİslemYap.Click += new System.EventHandler(this.btnİslemYap_Click);
            // 
            // txtOdenecekTutar
            // 
            this.txtOdenecekTutar.Location = new System.Drawing.Point(232, 255);
            this.txtOdenecekTutar.Name = "txtOdenecekTutar";
            this.txtOdenecekTutar.Size = new System.Drawing.Size(222, 22);
            this.txtOdenecekTutar.TabIndex = 11;
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(51, 255);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(154, 22);
            this.lblOdenecekTutar.TabIndex = 10;
            this.lblOdenecekTutar.Text = "Ödenecek Tutar";
            // 
            // lblSterlin
            // 
            this.lblSterlin.AutoSize = true;
            this.lblSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSterlin.Location = new System.Drawing.Point(418, 66);
            this.lblSterlin.Name = "lblSterlin";
            this.lblSterlin.Size = new System.Drawing.Size(64, 22);
            this.lblSterlin.TabIndex = 12;
            this.lblSterlin.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 416);
            this.Controls.Add(this.lblSterlin);
            this.Controls.Add(this.txtOdenecekTutar);
            this.Controls.Add(this.lblOdenecekTutar);
            this.Controls.Add(this.btnİslemYap);
            this.Controls.Add(this.rdbSterlin);
            this.Controls.Add(this.rdbEuro);
            this.Controls.Add(this.rdbDolar);
            this.Controls.Add(this.txtBirimTutar);
            this.Controls.Add(this.lblBirimTutar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapid API Döviz ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDolar;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.Label lblBirimTutar;
		private System.Windows.Forms.TextBox txtBirimTutar;
		private System.Windows.Forms.RadioButton rdbDolar;
		private System.Windows.Forms.RadioButton rdbEuro;
		private System.Windows.Forms.RadioButton rdbSterlin;
		private System.Windows.Forms.Button btnİslemYap;
		private System.Windows.Forms.TextBox txtOdenecekTutar;
		private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label lblSterlin;
    }
}

