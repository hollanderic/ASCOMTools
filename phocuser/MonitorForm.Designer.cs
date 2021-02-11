namespace ASCOM.phocuser
{
    partial class MonitorForm
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
            this.PositionLabel = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(12, 19);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(56, 13);
            this.PositionLabel.TabIndex = 0;
            this.PositionLabel.Text = "Position:";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(70, 19);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(13, 13);
            this.Position.TabIndex = 1;
            this.Position.Text = "0";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(404, 263);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // MonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 298);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.PositionLabel);
            this.Name = "MonitorForm";
            this.Text = "Phocuser Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Position;
        internal System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button OkBtn;
    }
}