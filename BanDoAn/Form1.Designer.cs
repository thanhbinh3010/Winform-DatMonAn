namespace BanDoAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayAD = new System.Windows.Forms.DateTimePicker();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày Ad:";
            // 
            // dtpNgayAD
            // 
            this.dtpNgayAD.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayAD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayAD.Location = new System.Drawing.Point(282, 27);
            this.dtpNgayAD.Name = "dtpNgayAD";
            this.dtpNgayAD.Size = new System.Drawing.Size(204, 30);
            this.dtpNgayAD.TabIndex = 10;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(578, 27);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(171, 32);
            this.btnTaoBaoCao.TabIndex = 11;
            this.btnTaoBaoCao.Text = "Tạo Báo Cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.DocumentMapWidth = 94;
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "BanDoAn.Report1.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(22, 131);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(997, 301);
            this.reportViewer3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 579);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.dtpNgayAD);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayAD;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}