namespace SoundStream
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.isSupported = new System.Windows.Forms.Button();
            this.checkLabel = new System.Windows.Forms.Label();
            this.recordTenWAVButton = new System.Windows.Forms.Button();
            this.recordTenWAVLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.isSupported, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.recordTenWAVButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.recordTenWAVLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // isSupported
            // 
            this.isSupported.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isSupported.Location = new System.Drawing.Point(390, 3);
            this.isSupported.Name = "isSupported";
            this.isSupported.Size = new System.Drawing.Size(92, 20);
            this.isSupported.TabIndex = 0;
            this.isSupported.Text = "Check WASAPI";
            this.isSupported.UseVisualStyleBackColor = true;
            this.isSupported.Click += new System.EventHandler(this.isSupported_Click);
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkLabel.Location = new System.Drawing.Point(245, 0);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(139, 26);
            this.checkLabel.TabIndex = 1;
            this.checkLabel.Text = "Click check";
            this.checkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recordTenWAVButton
            // 
            this.recordTenWAVButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordTenWAVButton.Location = new System.Drawing.Point(390, 29);
            this.recordTenWAVButton.Name = "recordTenWAVButton";
            this.recordTenWAVButton.Size = new System.Drawing.Size(92, 20);
            this.recordTenWAVButton.TabIndex = 2;
            this.recordTenWAVButton.Text = "Record 10s";
            this.recordTenWAVButton.UseVisualStyleBackColor = true;
            this.recordTenWAVButton.Click += new System.EventHandler(this.recordTenWAVButton_Click);
            // 
            // recordTenWAVLabel
            // 
            this.recordTenWAVLabel.AutoSize = true;
            this.recordTenWAVLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordTenWAVLabel.Location = new System.Drawing.Point(245, 26);
            this.recordTenWAVLabel.Name = "recordTenWAVLabel";
            this.recordTenWAVLabel.Size = new System.Drawing.Size(139, 26);
            this.recordTenWAVLabel.TabIndex = 3;
            this.recordTenWAVLabel.Text = "Ready";
            this.recordTenWAVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button isSupported;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.Button recordTenWAVButton;
        private System.Windows.Forms.Label recordTenWAVLabel;
    }
}

