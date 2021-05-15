
namespace BaseSim2021
{
    partial class GameView
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.diffLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.gloryLabel = new System.Windows.Forms.Label();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MiddleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.IndicatorBox1 = new System.Windows.Forms.GroupBox();
            this.IndicatorBox2 = new System.Windows.Forms.GroupBox();
            this.GroupsBox = new System.Windows.Forms.GroupBox();
            this.MainStateBox = new System.Windows.Forms.GroupBox();
            this.NextTurnButton = new System.Windows.Forms.Button();
            this.PerksAndCrisesBox = new System.Windows.Forms.GroupBox();
            this.PoliciesBox = new System.Windows.Forms.GroupBox();
            this.MainLayout.SuspendLayout();
            this.MiddleLayout.SuspendLayout();
            this.MainStateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(1297, 223);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(298, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTextBox_KeyDown);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.HorizontalScrollbar = true;
            this.outputListBox.Location = new System.Drawing.Point(1297, 26);
            this.outputListBox.Margin = new System.Windows.Forms.Padding(2);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(298, 147);
            this.outputListBox.TabIndex = 1;
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.diffLabel.Location = new System.Drawing.Point(108, 20);
            this.diffLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(22, 13);
            this.diffLabel.TabIndex = 2;
            this.diffLabel.Text = "     ";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.turnLabel.Location = new System.Drawing.Point(17, 20);
            this.turnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(19, 13);
            this.turnLabel.TabIndex = 3;
            this.turnLabel.Text = "    ";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.moneyLabel.Location = new System.Drawing.Point(252, 20);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(16, 13);
            this.moneyLabel.TabIndex = 4;
            this.moneyLabel.Text = "   ";
            // 
            // gloryLabel
            // 
            this.gloryLabel.AutoSize = true;
            this.gloryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gloryLabel.Location = new System.Drawing.Point(416, 20);
            this.gloryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gloryLabel.Name = "gloryLabel";
            this.gloryLabel.Size = new System.Drawing.Size(16, 13);
            this.gloryLabel.TabIndex = 5;
            this.gloryLabel.Text = "   ";
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.Transparent;
            this.MainLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.MiddleLayout, 0, 2);
            this.MainLayout.Controls.Add(this.MainStateBox, 0, 0);
            this.MainLayout.Controls.Add(this.PerksAndCrisesBox, 0, 1);
            this.MainLayout.Controls.Add(this.PoliciesBox, 0, 3);
            this.MainLayout.Location = new System.Drawing.Point(12, 12);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.MainLayout.Size = new System.Drawing.Size(1580, 900);
            this.MainLayout.TabIndex = 6;
            // 
            // MiddleLayout
            // 
            this.MiddleLayout.ColumnCount = 3;
            this.MiddleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.MiddleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.MiddleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.MiddleLayout.Controls.Add(this.IndicatorBox1, 0, 0);
            this.MiddleLayout.Controls.Add(this.IndicatorBox2, 2, 0);
            this.MiddleLayout.Controls.Add(this.GroupsBox, 1, 0);
            this.MiddleLayout.Location = new System.Drawing.Point(3, 372);
            this.MiddleLayout.Name = "MiddleLayout";
            this.MiddleLayout.RowCount = 1;
            this.MiddleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MiddleLayout.Size = new System.Drawing.Size(1574, 219);
            this.MiddleLayout.TabIndex = 0;
            // 
            // IndicatorBox1
            // 
            this.IndicatorBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.IndicatorBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IndicatorBox1.Location = new System.Drawing.Point(3, 3);
            this.IndicatorBox1.Name = "IndicatorBox1";
            this.IndicatorBox1.Size = new System.Drawing.Size(518, 213);
            this.IndicatorBox1.TabIndex = 0;
            this.IndicatorBox1.TabStop = false;
            this.IndicatorBox1.Text = "Indicators";
            this.IndicatorBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.IndicatorBox1_Paint);
            // 
            // IndicatorBox2
            // 
            this.IndicatorBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.IndicatorBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IndicatorBox2.Location = new System.Drawing.Point(1051, 3);
            this.IndicatorBox2.Name = "IndicatorBox2";
            this.IndicatorBox2.Size = new System.Drawing.Size(520, 213);
            this.IndicatorBox2.TabIndex = 1;
            this.IndicatorBox2.TabStop = false;
            this.IndicatorBox2.Text = "Indicators";
            this.IndicatorBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.IndicatorBox2_Paint);
            // 
            // GroupsBox
            // 
            this.GroupsBox.BackColor = System.Drawing.Color.Snow;
            this.GroupsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GroupsBox.Location = new System.Drawing.Point(527, 3);
            this.GroupsBox.Name = "GroupsBox";
            this.GroupsBox.Size = new System.Drawing.Size(518, 213);
            this.GroupsBox.TabIndex = 2;
            this.GroupsBox.TabStop = false;
            this.GroupsBox.Text = "Groups";
            this.GroupsBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GroupsBox_Paint);
            // 
            // MainStateBox
            // 
            this.MainStateBox.Controls.Add(this.NextTurnButton);
            this.MainStateBox.Controls.Add(this.gloryLabel);
            this.MainStateBox.Controls.Add(this.turnLabel);
            this.MainStateBox.Controls.Add(this.moneyLabel);
            this.MainStateBox.Controls.Add(this.diffLabel);
            this.MainStateBox.Location = new System.Drawing.Point(3, 3);
            this.MainStateBox.Name = "MainStateBox";
            this.MainStateBox.Size = new System.Drawing.Size(1574, 57);
            this.MainStateBox.TabIndex = 1;
            this.MainStateBox.TabStop = false;
            // 
            // NextTurnButton
            // 
            this.NextTurnButton.Location = new System.Drawing.Point(1493, 19);
            this.NextTurnButton.Name = "NextTurnButton";
            this.NextTurnButton.Size = new System.Drawing.Size(75, 31);
            this.NextTurnButton.TabIndex = 1;
            this.NextTurnButton.Text = "Next turn";
            this.NextTurnButton.UseVisualStyleBackColor = true;
            this.NextTurnButton.Click += new System.EventHandler(this.NextTurnButton_Click);
            // 
            // PerksAndCrisesBox
            // 
            this.PerksAndCrisesBox.BackColor = System.Drawing.Color.Ivory;
            this.PerksAndCrisesBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PerksAndCrisesBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PerksAndCrisesBox.Location = new System.Drawing.Point(3, 66);
            this.PerksAndCrisesBox.Name = "PerksAndCrisesBox";
            this.PerksAndCrisesBox.Size = new System.Drawing.Size(1574, 300);
            this.PerksAndCrisesBox.TabIndex = 2;
            this.PerksAndCrisesBox.TabStop = false;
            this.PerksAndCrisesBox.Text = "Perks and Crises";
            this.PerksAndCrisesBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PerksAndCrisesBox_Paint);
            // 
            // PoliciesBox
            // 
            this.PoliciesBox.BackColor = System.Drawing.Color.Thistle;
            this.PoliciesBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PoliciesBox.Location = new System.Drawing.Point(3, 597);
            this.PoliciesBox.Name = "PoliciesBox";
            this.PoliciesBox.Size = new System.Drawing.Size(1574, 300);
            this.PoliciesBox.TabIndex = 3;
            this.PoliciesBox.TabStop = false;
            this.PoliciesBox.Text = "Policies";
            this.PoliciesBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PoliciesBox_Paint);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1629, 941);
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.inputTextBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameView";
            this.Text = "Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameView_Paint);
            this.MainLayout.ResumeLayout(false);
            this.MiddleLayout.ResumeLayout(false);
            this.MainStateBox.ResumeLayout(false);
            this.MainStateBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label gloryLabel;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel MiddleLayout;
        private System.Windows.Forms.Button NextTurnButton;
        private System.Windows.Forms.GroupBox MainStateBox;
        private System.Windows.Forms.GroupBox PerksAndCrisesBox;
        private System.Windows.Forms.GroupBox PoliciesBox;
        private System.Windows.Forms.GroupBox IndicatorBox1;
        private System.Windows.Forms.GroupBox IndicatorBox2;
        private System.Windows.Forms.GroupBox GroupsBox;
    }
}

