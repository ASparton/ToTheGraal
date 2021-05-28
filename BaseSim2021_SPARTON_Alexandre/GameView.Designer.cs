
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
            this.gloryLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.diffLabel = new System.Windows.Forms.Label();
            this.NextTurnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gloryLabel
            // 
            this.gloryLabel.BackColor = System.Drawing.Color.Tomato;
            this.gloryLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gloryLabel.Location = new System.Drawing.Point(550, 10);
            this.gloryLabel.Name = "gloryLabel";
            this.gloryLabel.Size = new System.Drawing.Size(300, 25);
            this.gloryLabel.TabIndex = 9;
            this.gloryLabel.Text = "Glory:";
            this.gloryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // moneyLabel
            // 
            this.moneyLabel.BackColor = System.Drawing.Color.Gold;
            this.moneyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyLabel.Location = new System.Drawing.Point(10, 10);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(300, 25);
            this.moneyLabel.TabIndex = 8;
            this.moneyLabel.Text = "Money:";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // turnLabel
            // 
            this.turnLabel.BackColor = System.Drawing.Color.Linen;
            this.turnLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnLabel.Location = new System.Drawing.Point(1254, 10);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(150, 25);
            this.turnLabel.TabIndex = 7;
            this.turnLabel.Text = "Turn:";
            this.turnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diffLabel
            // 
            this.diffLabel.BackColor = System.Drawing.Color.Linen;
            this.diffLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diffLabel.Location = new System.Drawing.Point(999, 10);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(150, 25);
            this.diffLabel.TabIndex = 6;
            this.diffLabel.Text = "Difficulty:";
            this.diffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NextTurnButton
            // 
            this.NextTurnButton.Location = new System.Drawing.Point(1493, 10);
            this.NextTurnButton.Name = "NextTurnButton";
            this.NextTurnButton.Size = new System.Drawing.Size(75, 25);
            this.NextTurnButton.TabIndex = 5;
            this.NextTurnButton.Text = "Next turn";
            this.NextTurnButton.UseVisualStyleBackColor = true;
            this.NextTurnButton.Click += new System.EventHandler(this.NextTurnButton_Click);
            // 
            // GameView
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.gloryLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.NextTurnButton);
            this.DoubleBuffered = true;
            this.Name = "GameView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameView_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameView_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gloryLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label diffLabel;
        private System.Windows.Forms.Button NextTurnButton;
    }
}

