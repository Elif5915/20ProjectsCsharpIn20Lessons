namespace MailRegister_16
{
    partial class FrmMailConfirm
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
            this.txtEmailActivation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompleteActivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailActivation
            // 
            this.txtEmailActivation.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailActivation.Location = new System.Drawing.Point(166, 33);
            this.txtEmailActivation.Name = "txtEmailActivation";
            this.txtEmailActivation.ReadOnly = true;
            this.txtEmailActivation.Size = new System.Drawing.Size(275, 25);
            this.txtEmailActivation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Adresi";
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificationCode.Location = new System.Drawing.Point(166, 74);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(275, 25);
            this.txtVerificationCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doğrulama Kodu";
            // 
            // btnCompleteActivation
            // 
            this.btnCompleteActivation.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCompleteActivation.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteActivation.Location = new System.Drawing.Point(264, 119);
            this.btnCompleteActivation.Name = "btnCompleteActivation";
            this.btnCompleteActivation.Size = new System.Drawing.Size(177, 34);
            this.btnCompleteActivation.TabIndex = 6;
            this.btnCompleteActivation.Text = "Aktivasyonu Tamamla";
            this.btnCompleteActivation.UseVisualStyleBackColor = false;
            this.btnCompleteActivation.Click += new System.EventHandler(this.btnCompleteActivation_Click);
            // 
            // FrmMailConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 188);
            this.Controls.Add(this.btnCompleteActivation);
            this.Controls.Add(this.txtVerificationCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailActivation);
            this.Controls.Add(this.label1);
            this.Name = "FrmMailConfirm";
            this.Text = "Mail Aktivasyon Formu";
            this.Load += new System.EventHandler(this.FrmMailConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailActivation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerificationCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompleteActivation;
    }
}