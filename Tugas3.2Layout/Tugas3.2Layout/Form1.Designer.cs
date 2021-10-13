namespace Tugas3._2Layout
{
    partial class FrmTugas3_2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblPendidikan = new System.Windows.Forms.Label();
            this.lblPekerjaan = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.lstPekerjaan = new System.Windows.Forms.ListBox();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNama, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPendidikan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPekerjaan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNama, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPendidikan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lstPekerjaan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPesan1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPesan2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtPesan3, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 420);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(3, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(45, 17);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // lblPendidikan
            // 
            this.lblPendidikan.AutoSize = true;
            this.lblPendidikan.Location = new System.Drawing.Point(3, 40);
            this.lblPendidikan.Name = "lblPendidikan";
            this.lblPendidikan.Size = new System.Drawing.Size(78, 17);
            this.lblPendidikan.TabIndex = 1;
            this.lblPendidikan.Text = "Pendidikan";
            // 
            // lblPekerjaan
            // 
            this.lblPekerjaan.AutoSize = true;
            this.lblPekerjaan.Location = new System.Drawing.Point(3, 120);
            this.lblPekerjaan.Name = "lblPekerjaan";
            this.lblPekerjaan.Size = new System.Drawing.Size(72, 17);
            this.lblPekerjaan.TabIndex = 2;
            this.lblPekerjaan.Text = "Pekerjaan";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(87, 3);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(452, 22);
            this.txtNama.TabIndex = 3;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "PascaSarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(87, 43);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(452, 24);
            this.cmbPendidikan.TabIndex = 4;
            // 
            // lstPekerjaan
            // 
            this.lstPekerjaan.FormattingEnabled = true;
            this.lstPekerjaan.ItemHeight = 16;
            this.lstPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lstPekerjaan.Location = new System.Drawing.Point(87, 123);
            this.lstPekerjaan.Name = "lstPekerjaan";
            this.lstPekerjaan.Size = new System.Drawing.Size(452, 100);
            this.lstPekerjaan.TabIndex = 5;
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(87, 243);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(452, 22);
            this.txtPesan1.TabIndex = 6;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(87, 283);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(452, 22);
            this.txtPesan2.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(87, 363);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(452, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(87, 323);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(452, 22);
            this.txtPesan3.TabIndex = 9;
            // 
            // FrmTugas3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmTugas3_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tugas Latihan 3.2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblPendidikan;
        private System.Windows.Forms.Label lblPekerjaan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.ListBox lstPekerjaan;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPesan3;
    }
}

