namespace WindowsFormsApp2
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirstSource = new System.Windows.Forms.Button();
            this.lblFirstSource = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txtBarcodeColumnName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPriceColumnName = new System.Windows.Forms.TextBox();
            this.txtMartBColumnName = new System.Windows.Forms.TextBox();
            this.lblSecondSource = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSecondSource = new System.Windows.Forms.Button();
            this.btnTezzDelivery = new System.Windows.Forms.Button();
            this.lblTezzDelivery = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel Data Replacing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Source File";
            // 
            // btnFirstSource
            // 
            this.btnFirstSource.BackColor = System.Drawing.Color.BlueViolet;
            this.btnFirstSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstSource.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstSource.Location = new System.Drawing.Point(351, 108);
            this.btnFirstSource.Name = "btnFirstSource";
            this.btnFirstSource.Size = new System.Drawing.Size(286, 48);
            this.btnFirstSource.TabIndex = 2;
            this.btnFirstSource.Text = "Browse Source";
            this.btnFirstSource.UseVisualStyleBackColor = false;
            this.btnFirstSource.Click += new System.EventHandler(this.btnFirstSource_Click);
            // 
            // lblFirstSource
            // 
            this.lblFirstSource.AutoSize = true;
            this.lblFirstSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstSource.Location = new System.Drawing.Point(348, 168);
            this.lblFirstSource.Name = "lblFirstSource";
            this.lblFirstSource.Size = new System.Drawing.Size(61, 16);
            this.lblFirstSource.TabIndex = 3;
            this.lblFirstSource.Text = "file name";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.Black;
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ForeColor = System.Drawing.Color.Transparent;
            this.btnReplace.Location = new System.Drawing.Point(343, 519);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(145, 48);
            this.btnReplace.TabIndex = 10;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Black;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Transparent;
            this.btnDownload.Location = new System.Drawing.Point(494, 519);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(143, 48);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm;*.xlsb;*.xltx;*.xlt;*.csv|All Files|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm;*.xlsb;*.xltx;*.xlt;*.csv|All Files|*.*";
            // 
            // txtBarcodeColumnName
            // 
            this.txtBarcodeColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeColumnName.Location = new System.Drawing.Point(643, 120);
            this.txtBarcodeColumnName.Name = "txtBarcodeColumnName";
            this.txtBarcodeColumnName.Size = new System.Drawing.Size(143, 26);
            this.txtBarcodeColumnName.TabIndex = 12;
            this.txtBarcodeColumnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtBarcodeColumnName, "Enter Matching Column Name\r\n");
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(644, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 48);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPriceColumnName
            // 
            this.txtPriceColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceColumnName.Location = new System.Drawing.Point(792, 120);
            this.txtPriceColumnName.Name = "txtPriceColumnName";
            this.txtPriceColumnName.Size = new System.Drawing.Size(138, 26);
            this.txtPriceColumnName.TabIndex = 16;
            this.txtPriceColumnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip2.SetToolTip(this.txtPriceColumnName, "Enter Replacing Column Name");
            // 
            // txtMartBColumnName
            // 
            this.txtMartBColumnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMartBColumnName.Location = new System.Drawing.Point(644, 222);
            this.txtMartBColumnName.Name = "txtMartBColumnName";
            this.txtMartBColumnName.Size = new System.Drawing.Size(143, 26);
            this.txtMartBColumnName.TabIndex = 20;
            this.txtMartBColumnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip3.SetToolTip(this.txtMartBColumnName, "Enter Compare Column Name");
            // 
            // lblSecondSource
            // 
            this.lblSecondSource.AutoSize = true;
            this.lblSecondSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondSource.Location = new System.Drawing.Point(348, 271);
            this.lblSecondSource.Name = "lblSecondSource";
            this.lblSecondSource.Size = new System.Drawing.Size(61, 16);
            this.lblSecondSource.TabIndex = 19;
            this.lblSecondSource.Text = "file name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select Matching File";
            // 
            // btnSecondSource
            // 
            this.btnSecondSource.BackColor = System.Drawing.Color.BlueViolet;
            this.btnSecondSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecondSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondSource.ForeColor = System.Drawing.Color.Transparent;
            this.btnSecondSource.Location = new System.Drawing.Point(352, 212);
            this.btnSecondSource.Name = "btnSecondSource";
            this.btnSecondSource.Size = new System.Drawing.Size(286, 48);
            this.btnSecondSource.TabIndex = 21;
            this.btnSecondSource.Text = "Browse Source";
            this.btnSecondSource.UseVisualStyleBackColor = false;
            this.btnSecondSource.Click += new System.EventHandler(this.btnSecondSource_Click_1);
            // 
            // btnTezzDelivery
            // 
            this.btnTezzDelivery.BackColor = System.Drawing.Color.BlueViolet;
            this.btnTezzDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTezzDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTezzDelivery.ForeColor = System.Drawing.Color.Transparent;
            this.btnTezzDelivery.Location = new System.Drawing.Point(352, 321);
            this.btnTezzDelivery.Name = "btnTezzDelivery";
            this.btnTezzDelivery.Size = new System.Drawing.Size(286, 48);
            this.btnTezzDelivery.TabIndex = 25;
            this.btnTezzDelivery.Text = "Browse Source";
            this.btnTezzDelivery.UseVisualStyleBackColor = false;
            this.btnTezzDelivery.Click += new System.EventHandler(this.btnTezzDelivery_Click_1);
            // 
            // lblTezzDelivery
            // 
            this.lblTezzDelivery.AutoSize = true;
            this.lblTezzDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTezzDelivery.Location = new System.Drawing.Point(348, 380);
            this.lblTezzDelivery.Name = "lblTezzDelivery";
            this.lblTezzDelivery.Size = new System.Drawing.Size(61, 16);
            this.lblTezzDelivery.TabIndex = 23;
            this.lblTezzDelivery.Text = "file name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Select Tezz Dilvery File";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Files|*.xlsx";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(198, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(696, 23);
            this.progressBar1.TabIndex = 26;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Matching Column";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Replacing Column";
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Comparison Column";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 590);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnTezzDelivery);
            this.Controls.Add(this.lblTezzDelivery);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSecondSource);
            this.Controls.Add(this.txtMartBColumnName);
            this.Controls.Add(this.lblSecondSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPriceColumnName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBarcodeColumnName);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lblFirstSource);
            this.Controls.Add(this.btnFirstSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFirstSource;
        private System.Windows.Forms.Label lblFirstSource;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtBarcodeColumnName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPriceColumnName;
        private System.Windows.Forms.TextBox txtMartBColumnName;
        private System.Windows.Forms.Label lblSecondSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSecondSource;
        private System.Windows.Forms.Button btnTezzDelivery;
        private System.Windows.Forms.Label lblTezzDelivery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

