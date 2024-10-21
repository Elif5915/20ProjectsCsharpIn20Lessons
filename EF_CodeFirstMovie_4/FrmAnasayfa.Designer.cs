
namespace EF_CodeFirstMovie_4
{
    partial class FrmAnasayfa
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
            this.btnFilmler = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilmler
            // 
            this.btnFilmler.Location = new System.Drawing.Point(95, 41);
            this.btnFilmler.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFilmler.Name = "btnFilmler";
            this.btnFilmler.Size = new System.Drawing.Size(316, 35);
            this.btnFilmler.TabIndex = 0;
            this.btnFilmler.Text = "Filmler ";
            this.btnFilmler.UseVisualStyleBackColor = true;
            this.btnFilmler.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(95, 109);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(5);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(316, 35);
            this.btnKategori.TabIndex = 1;
            this.btnKategori.Text = "Kategori İşlemleri";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(95, 182);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(316, 35);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(499, 288);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnFilmler);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmler;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnCikis;
    }
}