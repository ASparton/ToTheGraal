
namespace BaseSim2021
{
    partial class IndexedValueInfosView
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
            this.ValueNameLabel = new System.Windows.Forms.Label();
            this.ValueDescriptionLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.ValueActiveLabel = new System.Windows.Forms.Label();
            this.ActualValueLabel = new System.Windows.Forms.Label();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.MoneyImpactLabel = new System.Windows.Forms.Label();
            this.GloryImpactedLabel = new System.Windows.Forms.Label();
            this.LinksViewButton = new System.Windows.Forms.Button();
            this.HistoryViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValueNameLabel
            // 
            this.ValueNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ValueNameLabel.Name = "ValueNameLabel";
            this.ValueNameLabel.Size = new System.Drawing.Size(410, 23);
            this.ValueNameLabel.TabIndex = 0;
            this.ValueNameLabel.Text = "name";
            this.ValueNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValueDescriptionLabel
            // 
            this.ValueDescriptionLabel.Location = new System.Drawing.Point(12, 43);
            this.ValueDescriptionLabel.Name = "ValueDescriptionLabel";
            this.ValueDescriptionLabel.Size = new System.Drawing.Size(410, 46);
            this.ValueDescriptionLabel.TabIndex = 1;
            this.ValueDescriptionLabel.Text = "description";
            this.ValueDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(177, 268);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // ValueActiveLabel
            // 
            this.ValueActiveLabel.Location = new System.Drawing.Point(12, 242);
            this.ValueActiveLabel.Name = "ValueActiveLabel";
            this.ValueActiveLabel.Size = new System.Drawing.Size(410, 23);
            this.ValueActiveLabel.TabIndex = 3;
            this.ValueActiveLabel.Text = "active";
            this.ValueActiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActualValueLabel
            // 
            this.ActualValueLabel.Location = new System.Drawing.Point(127, 99);
            this.ActualValueLabel.Name = "ActualValueLabel";
            this.ActualValueLabel.Size = new System.Drawing.Size(176, 24);
            this.ActualValueLabel.TabIndex = 4;
            this.ActualValueLabel.Text = "valeur actuelle";
            this.ActualValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.Location = new System.Drawing.Point(12, 99);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(134, 24);
            this.MinValueLabel.TabIndex = 5;
            this.MinValueLabel.Text = "valeur min";
            this.MinValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.Location = new System.Drawing.Point(288, 99);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(134, 24);
            this.MaxValueLabel.TabIndex = 6;
            this.MaxValueLabel.Text = "valeur max";
            this.MaxValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MoneyImpactLabel
            // 
            this.MoneyImpactLabel.Location = new System.Drawing.Point(15, 159);
            this.MoneyImpactLabel.Name = "MoneyImpactLabel";
            this.MoneyImpactLabel.Size = new System.Drawing.Size(195, 23);
            this.MoneyImpactLabel.TabIndex = 7;
            this.MoneyImpactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GloryImpactedLabel
            // 
            this.GloryImpactedLabel.Location = new System.Drawing.Point(227, 159);
            this.GloryImpactedLabel.Name = "GloryImpactedLabel";
            this.GloryImpactedLabel.Size = new System.Drawing.Size(195, 23);
            this.GloryImpactedLabel.TabIndex = 8;
            this.GloryImpactedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LinksViewButton
            // 
            this.LinksViewButton.Location = new System.Drawing.Point(60, 199);
            this.LinksViewButton.Name = "LinksViewButton";
            this.LinksViewButton.Size = new System.Drawing.Size(120, 25);
            this.LinksViewButton.TabIndex = 9;
            this.LinksViewButton.Text = "Valeurs liées";
            this.LinksViewButton.UseVisualStyleBackColor = true;
            this.LinksViewButton.Click += new System.EventHandler(this.LinksViewButton_Click);
            // 
            // HistoryViewButton
            // 
            this.HistoryViewButton.Location = new System.Drawing.Point(240, 199);
            this.HistoryViewButton.Name = "HistoryViewButton";
            this.HistoryViewButton.Size = new System.Drawing.Size(120, 25);
            this.HistoryViewButton.TabIndex = 14;
            this.HistoryViewButton.Text = "Historique";
            this.HistoryViewButton.UseVisualStyleBackColor = true;
            this.HistoryViewButton.Click += new System.EventHandler(this.HistoryViewButton_Click);
            // 
            // IndexedValueInfosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 303);
            this.Controls.Add(this.HistoryViewButton);
            this.Controls.Add(this.LinksViewButton);
            this.Controls.Add(this.GloryImpactedLabel);
            this.Controls.Add(this.MoneyImpactLabel);
            this.Controls.Add(this.MaxValueLabel);
            this.Controls.Add(this.MinValueLabel);
            this.Controls.Add(this.ActualValueLabel);
            this.Controls.Add(this.ValueActiveLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ValueDescriptionLabel);
            this.Controls.Add(this.ValueNameLabel);
            this.Name = "IndexedValueInfosView";
            this.Text = "IndexedValueInfosView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ValueNameLabel;
        private System.Windows.Forms.Label ValueDescriptionLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label ValueActiveLabel;
        private System.Windows.Forms.Label ActualValueLabel;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.Label MoneyImpactLabel;
        private System.Windows.Forms.Label GloryImpactedLabel;
        private System.Windows.Forms.Button LinksViewButton;
        private System.Windows.Forms.Button HistoryViewButton;
    }
}