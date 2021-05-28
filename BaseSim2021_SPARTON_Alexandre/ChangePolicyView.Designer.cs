
namespace BaseSim2021
{
    partial class ChangePolicyView
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.ValueNameLabel = new System.Windows.Forms.Label();
            this.GoldCostLabel = new System.Windows.Forms.Label();
            this.GloryCostLabel = new System.Windows.Forms.Label();
            this.GloryRemainderLabel = new System.Windows.Forms.Label();
            this.GoldRemainderLabel = new System.Windows.Forms.Label();
            this.ValueChanger = new System.Windows.Forms.NumericUpDown();
            this.ValueDescriptionLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LinksViewButton = new System.Windows.Forms.Button();
            this.HistoryViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValueChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmButton.Location = new System.Drawing.Point(50, 366);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Ok";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(299, 366);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Annuler";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Location = new System.Drawing.Point(107, 240);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(48, 13);
            this.MinValueLabel.TabIndex = 2;
            this.MinValueLabel.Text = "Minimum";
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(107, 183);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(51, 13);
            this.MaxValueLabel.TabIndex = 3;
            this.MaxValueLabel.Text = "Maximum";
            // 
            // ValueNameLabel
            // 
            this.ValueNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ValueNameLabel.Name = "ValueNameLabel";
            this.ValueNameLabel.Size = new System.Drawing.Size(410, 13);
            this.ValueNameLabel.TabIndex = 4;
            this.ValueNameLabel.Text = "Name";
            this.ValueNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoldCostLabel
            // 
            this.GoldCostLabel.AutoSize = true;
            this.GoldCostLabel.Location = new System.Drawing.Point(47, 105);
            this.GoldCostLabel.Name = "GoldCostLabel";
            this.GoldCostLabel.Size = new System.Drawing.Size(50, 13);
            this.GoldCostLabel.TabIndex = 6;
            this.GoldCostLabel.Text = "GoldCost";
            // 
            // GloryCostLabel
            // 
            this.GloryCostLabel.AutoSize = true;
            this.GloryCostLabel.Location = new System.Drawing.Point(47, 151);
            this.GloryCostLabel.Name = "GloryCostLabel";
            this.GloryCostLabel.Size = new System.Drawing.Size(52, 13);
            this.GloryCostLabel.TabIndex = 7;
            this.GloryCostLabel.Text = "GloryCost";
            // 
            // GloryRemainderLabel
            // 
            this.GloryRemainderLabel.AutoSize = true;
            this.GloryRemainderLabel.Location = new System.Drawing.Point(222, 151);
            this.GloryRemainderLabel.Name = "GloryRemainderLabel";
            this.GloryRemainderLabel.Size = new System.Drawing.Size(79, 13);
            this.GloryRemainderLabel.TabIndex = 9;
            this.GloryRemainderLabel.Text = "Impact on glory";
            // 
            // GoldRemainderLabel
            // 
            this.GoldRemainderLabel.AutoSize = true;
            this.GoldRemainderLabel.Location = new System.Drawing.Point(222, 105);
            this.GoldRemainderLabel.Name = "GoldRemainderLabel";
            this.GoldRemainderLabel.Size = new System.Drawing.Size(77, 13);
            this.GoldRemainderLabel.TabIndex = 8;
            this.GoldRemainderLabel.Text = "Impact on gold";
            // 
            // ValueChanger
            // 
            this.ValueChanger.Location = new System.Drawing.Point(110, 208);
            this.ValueChanger.Name = "ValueChanger";
            this.ValueChanger.Size = new System.Drawing.Size(187, 20);
            this.ValueChanger.TabIndex = 10;
            this.ValueChanger.ValueChanged += new System.EventHandler(this.ValueChanger_ValueChanged);
            // 
            // ValueDescriptionLabel
            // 
            this.ValueDescriptionLabel.Location = new System.Drawing.Point(12, 22);
            this.ValueDescriptionLabel.Name = "ValueDescriptionLabel";
            this.ValueDescriptionLabel.Size = new System.Drawing.Size(410, 83);
            this.ValueDescriptionLabel.TabIndex = 5;
            this.ValueDescriptionLabel.Text = "Description";
            this.ValueDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(50, 268);
            this.ProgressBar.MarqueeAnimationSpeed = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(324, 23);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 11;
            // 
            // LinksViewButton
            // 
            this.LinksViewButton.Location = new System.Drawing.Point(75, 320);
            this.LinksViewButton.Name = "LinksViewButton";
            this.LinksViewButton.Size = new System.Drawing.Size(120, 25);
            this.LinksViewButton.TabIndex = 12;
            this.LinksViewButton.Text = "Valeus liées";
            this.LinksViewButton.UseVisualStyleBackColor = true;
            this.LinksViewButton.Click += new System.EventHandler(this.LinksViewButton_Click);
            // 
            // HistoryViewButton
            // 
            this.HistoryViewButton.Location = new System.Drawing.Point(225, 320);
            this.HistoryViewButton.Name = "HistoryViewButton";
            this.HistoryViewButton.Size = new System.Drawing.Size(120, 25);
            this.HistoryViewButton.TabIndex = 13;
            this.HistoryViewButton.Text = "Historique";
            this.HistoryViewButton.UseVisualStyleBackColor = true;
            this.HistoryViewButton.Click += new System.EventHandler(this.HistoryViewButton_Click);
            // 
            // ChangePolicyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 401);
            this.Controls.Add(this.HistoryViewButton);
            this.Controls.Add(this.LinksViewButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ValueChanger);
            this.Controls.Add(this.GloryRemainderLabel);
            this.Controls.Add(this.GoldRemainderLabel);
            this.Controls.Add(this.GloryCostLabel);
            this.Controls.Add(this.GoldCostLabel);
            this.Controls.Add(this.ValueDescriptionLabel);
            this.Controls.Add(this.ValueNameLabel);
            this.Controls.Add(this.MaxValueLabel);
            this.Controls.Add(this.MinValueLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Name = "ChangePolicyView";
            this.Text = "ChangePolicyView";
            ((System.ComponentModel.ISupportInitialize)(this.ValueChanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.Label ValueNameLabel;
        private System.Windows.Forms.Label GoldCostLabel;
        private System.Windows.Forms.Label GloryCostLabel;
        private System.Windows.Forms.Label GloryRemainderLabel;
        private System.Windows.Forms.Label GoldRemainderLabel;
        private System.Windows.Forms.NumericUpDown ValueChanger;
        private System.Windows.Forms.Label ValueDescriptionLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button LinksViewButton;
        private System.Windows.Forms.Button HistoryViewButton;
    }
}