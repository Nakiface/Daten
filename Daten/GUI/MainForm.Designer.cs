﻿namespace Daten
{
    partial class MainForm
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
            this.labelShowDataSource = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonShowVoter = new System.Windows.Forms.Button();
            this.buttonSourceData = new System.Windows.Forms.Button();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(510, 340);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // dataGridViewSecond
            // 
            this.dataGridViewSecond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewSecond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSecond.Location = new System.Drawing.Point(528, 123);
            this.dataGridViewSecond.Name = "dataGridViewSecond";
            this.dataGridViewSecond.RowHeadersWidth = 51;
            this.dataGridViewSecond.RowTemplate.Height = 24;
            this.dataGridViewSecond.Size = new System.Drawing.Size(382, 340);
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
            // labelShowDataSource
            // 
            this.labelShowDataSource.AutoSize = true;
            this.labelShowDataSource.Location = new System.Drawing.Point(12, 85);
            this.labelShowDataSource.Name = "labelShowDataSource";
            this.labelShowDataSource.Size = new System.Drawing.Size(133, 17);
            this.labelShowDataSource.TabIndex = 4;
            this.labelShowDataSource.Text = "Rohdaten Anzeigen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Notwendige Stimmen";
            // 
            // ButtonShowVoter
            // 
            this.ButtonShowVoter.BackgroundImage = global::Daten.Properties.Resources.Voter;
            this.ButtonShowVoter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonShowVoter.Location = new System.Drawing.Point(195, 47);
            this.ButtonShowVoter.Name = "ButtonShowVoter";
            this.ButtonShowVoter.Size = new System.Drawing.Size(75, 35);
            this.ButtonShowVoter.TabIndex = 7;
            this.ButtonShowVoter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonShowVoter.UseVisualStyleBackColor = true;
            this.ButtonShowVoter.Click += new System.EventHandler(this.ButtonShowVoter_Click);
            // 
            // buttonSourceData
            // 
            this.buttonSourceData.BackgroundImage = global::Daten.Properties.Resources.DataSource;
            this.buttonSourceData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSourceData.Location = new System.Drawing.Point(36, 47);
            this.buttonSourceData.Name = "buttonSourceData";
            this.buttonSourceData.Size = new System.Drawing.Size(75, 35);
            this.buttonSourceData.TabIndex = 3;
            this.buttonSourceData.UseVisualStyleBackColor = true;
            this.buttonSourceData.Click += new System.EventHandler(this.buttonSourceData_Click);
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.Location = new System.Drawing.Point(917, 123);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(179, 340);
            this.pieChart1.TabIndex = 9;
            this.pieChart1.Text = "pieChart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1108, 471);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonShowVoter);
            this.Controls.Add(this.labelShowDataSource);
            this.Controls.Add(this.buttonSourceData);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.dataGridViewSecond);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridView dataGridViewSecond;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonSourceData;
        private System.Windows.Forms.Label labelShowDataSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ButtonShowVoter;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}

