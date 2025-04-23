namespace GasPriceSimulation_15
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGasAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblFillingStatus = new System.Windows.Forms.Label();
            this.txtbxGasAmount = new System.Windows.Forms.TextBox();
            this.txtbxTotalAmount = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtbxBenzin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxMotorin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxLpg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbBenzin = new System.Windows.Forms.RadioButton();
            this.rdbMotorin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbLpg = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gas Price Simulation";
            // 
            // lblGasAmount
            // 
            this.lblGasAmount.AutoSize = true;
            this.lblGasAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGasAmount.Location = new System.Drawing.Point(26, 137);
            this.lblGasAmount.Name = "lblGasAmount";
            this.lblGasAmount.Size = new System.Drawing.Size(89, 17);
            this.lblGasAmount.TabIndex = 1;
            this.lblGasAmount.Text = "Yakıt Miktarı:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmount.Location = new System.Drawing.Point(26, 168);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(90, 17);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "Toplam Tutar:";
            // 
            // lblFillingStatus
            // 
            this.lblFillingStatus.AutoSize = true;
            this.lblFillingStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFillingStatus.Location = new System.Drawing.Point(26, 203);
            this.lblFillingStatus.Name = "lblFillingStatus";
            this.lblFillingStatus.Size = new System.Drawing.Size(105, 17);
            this.lblFillingStatus.TabIndex = 3;
            this.lblFillingStatus.Text = "Dolum Durumu:";
            // 
            // txtbxGasAmount
            // 
            this.txtbxGasAmount.Location = new System.Drawing.Point(150, 137);
            this.txtbxGasAmount.Name = "txtbxGasAmount";
            this.txtbxGasAmount.Size = new System.Drawing.Size(328, 20);
            this.txtbxGasAmount.TabIndex = 4;
            // 
            // txtbxTotalAmount
            // 
            this.txtbxTotalAmount.Location = new System.Drawing.Point(150, 168);
            this.txtbxTotalAmount.Name = "txtbxTotalAmount";
            this.txtbxTotalAmount.Size = new System.Drawing.Size(328, 20);
            this.txtbxTotalAmount.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(150, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(494, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnStart.Location = new System.Drawing.Point(526, 243);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 34);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "İşlemi Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxLpg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbxMotorin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbxBenzin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(650, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 159);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyatlar";
            // 
            // txtbxBenzin
            // 
            this.txtbxBenzin.Location = new System.Drawing.Point(103, 22);
            this.txtbxBenzin.Name = "txtbxBenzin";
            this.txtbxBenzin.ReadOnly = true;
            this.txtbxBenzin.Size = new System.Drawing.Size(166, 20);
            this.txtbxBenzin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Benzin:";
            // 
            // txtbxMotorin
            // 
            this.txtbxMotorin.Location = new System.Drawing.Point(103, 53);
            this.txtbxMotorin.Name = "txtbxMotorin";
            this.txtbxMotorin.ReadOnly = true;
            this.txtbxMotorin.Size = new System.Drawing.Size(166, 20);
            this.txtbxMotorin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motorin:";
            // 
            // txtbxLpg
            // 
            this.txtbxLpg.Location = new System.Drawing.Point(103, 85);
            this.txtbxLpg.Name = "txtbxLpg";
            this.txtbxLpg.ReadOnly = true;
            this.txtbxLpg.Size = new System.Drawing.Size(166, 20);
            this.txtbxLpg.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "LPG:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLpg);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rdbMotorin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rdbBenzin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(29, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 62);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yakıt Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Benzin";
            // 
            // rdbBenzin
            // 
            this.rdbBenzin.AutoSize = true;
            this.rdbBenzin.Location = new System.Drawing.Point(61, 26);
            this.rdbBenzin.Name = "rdbBenzin";
            this.rdbBenzin.Size = new System.Drawing.Size(85, 17);
            this.rdbBenzin.TabIndex = 3;
            this.rdbBenzin.TabStop = true;
            this.rdbBenzin.Text = "radioButton1";
            this.rdbBenzin.UseVisualStyleBackColor = true;
            // 
            // rdbMotorin
            // 
            this.rdbMotorin.AutoSize = true;
            this.rdbMotorin.Location = new System.Drawing.Point(207, 26);
            this.rdbMotorin.Name = "rdbMotorin";
            this.rdbMotorin.Size = new System.Drawing.Size(85, 17);
            this.rdbMotorin.TabIndex = 5;
            this.rdbMotorin.TabStop = true;
            this.rdbMotorin.Text = "radioButton2";
            this.rdbMotorin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(152, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Motorin";
            // 
            // rdbLpg
            // 
            this.rdbLpg.AutoSize = true;
            this.rdbLpg.Location = new System.Drawing.Point(346, 27);
            this.rdbLpg.Name = "rdbLpg";
            this.rdbLpg.Size = new System.Drawing.Size(85, 17);
            this.rdbLpg.TabIndex = 7;
            this.rdbLpg.TabStop = true;
            this.rdbLpg.Text = "radioButton3";
            this.rdbLpg.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(309, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "LPG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(967, 302);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtbxTotalAmount);
            this.Controls.Add(this.txtbxGasAmount);
            this.Controls.Add(this.lblFillingStatus);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblGasAmount);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGasAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblFillingStatus;
        private System.Windows.Forms.TextBox txtbxGasAmount;
        private System.Windows.Forms.TextBox txtbxTotalAmount;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxBenzin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxLpg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxMotorin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbLpg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbMotorin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbBenzin;
        private System.Windows.Forms.Label label5;
    }
}

