namespace AdoNetCustomer_1
{
    partial class FrmMap
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
            this.btnCityForm = new System.Windows.Forms.Button();
            this.btnCustomerForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCityForm
            // 
            this.btnCityForm.Location = new System.Drawing.Point(39, 38);
            this.btnCityForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCityForm.Name = "btnCityForm";
            this.btnCityForm.Size = new System.Drawing.Size(231, 34);
            this.btnCityForm.TabIndex = 0;
            this.btnCityForm.Text = "City Operations";
            this.btnCityForm.UseVisualStyleBackColor = true;
            this.btnCityForm.Click += new System.EventHandler(this.btnCityForm_Click);
            // 
            // btnCustomerForm
            // 
            this.btnCustomerForm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerForm.Location = new System.Drawing.Point(39, 97);
            this.btnCustomerForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerForm.Name = "btnCustomerForm";
            this.btnCustomerForm.Size = new System.Drawing.Size(231, 34);
            this.btnCustomerForm.TabIndex = 1;
            this.btnCustomerForm.Text = "Customer Transactions";
            this.btnCustomerForm.UseVisualStyleBackColor = true;
            this.btnCustomerForm.Click += new System.EventHandler(this.btnCustomerForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(39, 155);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Sign Out";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(306, 239);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomerForm);
            this.Controls.Add(this.btnCityForm);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCityForm;
        private System.Windows.Forms.Button btnCustomerForm;
        private System.Windows.Forms.Button btnExit;
    }
}