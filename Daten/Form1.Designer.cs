namespace Daten
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.dataGridViewSecond = new System.Windows.Forms.DataGridView();
            this.labelHeader = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelShowDataSource = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(676, 336);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // dataGridViewSecond
            // 
            this.dataGridViewSecond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecond.Location = new System.Drawing.Point(711, 123);
            this.dataGridViewSecond.Name = "dataGridViewSecond";
            this.dataGridViewSecond.RowHeadersWidth = 51;
            this.dataGridViewSecond.RowTemplate.Height = 24;
            this.dataGridViewSecond.Size = new System.Drawing.Size(299, 336);
            this.dataGridViewSecond.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(6, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(431, 33);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Daten zur Europawahl 2019 aus Berlin";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Daten.Properties.Resources.DataSource;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(36, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelShowDataSource
            // 
            this.labelShowDataSource.AutoSize = true;
            this.labelShowDataSource.Location = new System.Drawing.Point(12, 85);
            this.labelShowDataSource.Name = "labelShowDataSource";
            this.labelShowDataSource.Size = new System.Drawing.Size(133, 17);
            this.labelShowDataSource.TabIndex = 4;
            this.labelShowDataSource.Text = "Rohdaten Anzeigen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 471);
            this.Controls.Add(this.labelShowDataSource);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.dataGridViewSecond);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridView dataGridViewSecond;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelShowDataSource;
    }
}

