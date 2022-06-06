namespace StarWarsForPoor
{
    partial class SpaceWinForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceWinForm));
            this.GameField = new System.Windows.Forms.PictureBox();
            this.AmmoLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).BeginInit();
            this.SuspendLayout();
            // 
            // GameField
            // 
            this.GameField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameField.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.GameField.Location = new System.Drawing.Point(1, 1);
            this.GameField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameField.Name = "GameField";
            this.GameField.Size = new System.Drawing.Size(1000, 500);
            this.GameField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameField.TabIndex = 0;
            this.GameField.TabStop = false;
            this.GameField.Click += new System.EventHandler(this.pictureBox1_Click);
            this.GameField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // AmmoLabel
            // 
            this.AmmoLabel.AutoSize = true;
            this.AmmoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AmmoLabel.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmmoLabel.Location = new System.Drawing.Point(1031, 25);
            this.AmmoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmmoLabel.Name = "AmmoLabel";
            this.AmmoLabel.Size = new System.Drawing.Size(87, 41);
            this.AmmoLabel.TabIndex = 4;
            this.AmmoLabel.Text = "Ammo";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HealthLabel.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealthLabel.Location = new System.Drawing.Point(1032, 94);
            this.HealthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(86, 41);
            this.HealthLabel.TabIndex = 5;
            this.HealthLabel.Text = "Health";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLabel.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(1032, 164);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(71, 41);
            this.ScoreLabel.TabIndex = 6;
            this.ScoreLabel.Text = "Score";
            // 
            // SpaceWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1208, 503);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.HealthLabel);
            this.Controls.Add(this.AmmoLabel);
            this.Controls.Add(this.GameField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SpaceWinForm";
            this.Text = "SpaceBattle";
            ((System.ComponentModel.ISupportInitialize)(this.GameField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameField;
        private System.Windows.Forms.Label AmmoLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label ScoreLabel;
    }
}

