
namespace DapperNorthwind_5
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
			this.btnCategoryList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnCategoryAdd = new System.Windows.Forms.Button();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtCategoryDescription = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCategoryDelete = new System.Windows.Forms.Button();
			this.btnCategoryUpdate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblProductCount = new System.Windows.Forms.Label();
			this.lblCategoryCount = new System.Windows.Forms.Label();
			this.lblProductStok = new System.Windows.Forms.Label();
			this.lblPorductSeaTotal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCategoryList
			// 
			this.btnCategoryList.Location = new System.Drawing.Point(844, 199);
			this.btnCategoryList.Name = "btnCategoryList";
			this.btnCategoryList.Size = new System.Drawing.Size(132, 37);
			this.btnCategoryList.TabIndex = 0;
			this.btnCategoryList.Text = "Category List";
			this.btnCategoryList.UseVisualStyleBackColor = true;
			this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 254);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(964, 310);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnCategoryAdd
			// 
			this.btnCategoryAdd.Location = new System.Drawing.Point(353, 204);
			this.btnCategoryAdd.Name = "btnCategoryAdd";
			this.btnCategoryAdd.Size = new System.Drawing.Size(131, 32);
			this.btnCategoryAdd.TabIndex = 2;
			this.btnCategoryAdd.Text = "Category Add";
			this.btnCategoryAdd.UseVisualStyleBackColor = true;
			this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(201, 75);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(578, 22);
			this.txtCategoryName.TabIndex = 3;
			// 
			// txtCategoryDescription
			// 
			this.txtCategoryDescription.Location = new System.Drawing.Point(201, 116);
			this.txtCategoryDescription.Multiline = true;
			this.txtCategoryDescription.Name = "txtCategoryDescription";
			this.txtCategoryDescription.Size = new System.Drawing.Size(578, 66);
			this.txtCategoryDescription.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Category Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Category Name";
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(201, 31);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(578, 22);
			this.txtCategoryId.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Category Description";
			// 
			// btnCategoryDelete
			// 
			this.btnCategoryDelete.Location = new System.Drawing.Point(501, 204);
			this.btnCategoryDelete.Name = "btnCategoryDelete";
			this.btnCategoryDelete.Size = new System.Drawing.Size(131, 32);
			this.btnCategoryDelete.TabIndex = 9;
			this.btnCategoryDelete.Text = "Category Delete";
			this.btnCategoryDelete.UseVisualStyleBackColor = true;
			this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
			// 
			// btnCategoryUpdate
			// 
			this.btnCategoryUpdate.Location = new System.Drawing.Point(648, 204);
			this.btnCategoryUpdate.Name = "btnCategoryUpdate";
			this.btnCategoryUpdate.Size = new System.Drawing.Size(131, 32);
			this.btnCategoryUpdate.TabIndex = 10;
			this.btnCategoryUpdate.Text = "Category Update";
			this.btnCategoryUpdate.UseVisualStyleBackColor = true;
			this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.groupBox1.Controls.Add(this.lblPorductSeaTotal);
			this.groupBox1.Controls.Add(this.lblProductStok);
			this.groupBox1.Controls.Add(this.lblProductCount);
			this.groupBox1.Controls.Add(this.lblCategoryCount);
			this.groupBox1.Location = new System.Drawing.Point(995, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(353, 534);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dapper İstatistikler";
			// 
			// lblProductCount
			// 
			this.lblProductCount.AutoSize = true;
			this.lblProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductCount.Location = new System.Drawing.Point(23, 108);
			this.lblProductCount.Name = "lblProductCount";
			this.lblProductCount.Size = new System.Drawing.Size(60, 24);
			this.lblProductCount.TabIndex = 1;
			this.lblProductCount.Text = "label4";
			// 
			// lblCategoryCount
			// 
			this.lblCategoryCount.AutoSize = true;
			this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoryCount.Location = new System.Drawing.Point(23, 43);
			this.lblCategoryCount.Name = "lblCategoryCount";
			this.lblCategoryCount.Size = new System.Drawing.Size(60, 24);
			this.lblCategoryCount.TabIndex = 0;
			this.lblCategoryCount.Text = "label4";
			// 
			// lblProductStok
			// 
			this.lblProductStok.AutoSize = true;
			this.lblProductStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductStok.Location = new System.Drawing.Point(23, 174);
			this.lblProductStok.Name = "lblProductStok";
			this.lblProductStok.Size = new System.Drawing.Size(60, 24);
			this.lblProductStok.TabIndex = 2;
			this.lblProductStok.Text = "label4";
			// 
			// lblPorductSeaTotal
			// 
			this.lblPorductSeaTotal.AutoSize = true;
			this.lblPorductSeaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPorductSeaTotal.Location = new System.Drawing.Point(23, 246);
			this.lblPorductSeaTotal.Name = "lblPorductSeaTotal";
			this.lblPorductSeaTotal.Size = new System.Drawing.Size(60, 24);
			this.lblPorductSeaTotal.TabIndex = 3;
			this.lblPorductSeaTotal.Text = "label4";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1360, 576);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCategoryUpdate);
			this.Controls.Add(this.btnCategoryDelete);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCategoryDescription);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.btnCategoryAdd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategoryList);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCategoryList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnCategoryAdd;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtCategoryDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCategoryDelete;
		private System.Windows.Forms.Button btnCategoryUpdate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblCategoryCount;
		private System.Windows.Forms.Label lblProductCount;
		private System.Windows.Forms.Label lblProductStok;
		private System.Windows.Forms.Label lblPorductSeaTotal;
	}
}

