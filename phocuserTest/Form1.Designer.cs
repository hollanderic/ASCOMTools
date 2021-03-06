﻿namespace ASCOM.phocuser
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
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelDriverId = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Button();
            this.DebugOut = new System.Windows.Forms.ListBox();
            this.SetPosition = new System.Windows.Forms.Button();
            this.PositionBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PositionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(412, 12);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(96, 28);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(412, 48);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 28);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelDriverId
            // 
            this.labelDriverId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDriverId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ASCOM.phocuser.Properties.Settings.Default, "DriverId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDriverId.Location = new System.Drawing.Point(16, 49);
            this.labelDriverId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDriverId.Name = "labelDriverId";
            this.labelDriverId.Size = new System.Drawing.Size(387, 25);
            this.labelDriverId.TabIndex = 2;
            this.labelDriverId.Text = global::ASCOM.phocuser.Properties.Settings.Default.DriverId;
            this.labelDriverId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Position
            // 
            this.Position.Location = new System.Drawing.Point(29, 111);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(98, 23);
            this.Position.TabIndex = 3;
            this.Position.Text = "GetPosition";
            this.Position.UseVisualStyleBackColor = true;
            this.Position.Click += new System.EventHandler(this.Position_Click);
            // 
            // DebugOut
            // 
            this.DebugOut.FormattingEnabled = true;
            this.DebugOut.ItemHeight = 16;
            this.DebugOut.Location = new System.Drawing.Point(29, 141);
            this.DebugOut.Name = "DebugOut";
            this.DebugOut.Size = new System.Drawing.Size(479, 164);
            this.DebugOut.TabIndex = 4;
            // 
            // SetPosition
            // 
            this.SetPosition.Location = new System.Drawing.Point(248, 111);
            this.SetPosition.Name = "SetPosition";
            this.SetPosition.Size = new System.Drawing.Size(75, 23);
            this.SetPosition.TabIndex = 5;
            this.SetPosition.Text = "SetPosition";
            this.SetPosition.UseVisualStyleBackColor = true;
            this.SetPosition.Click += new System.EventHandler(this.SetPosition_Click);
            // 
            // PositionBox
            // 
            this.PositionBox.Location = new System.Drawing.Point(340, 111);
            this.PositionBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(120, 22);
            this.PositionBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 322);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.SetPosition);
            this.Controls.Add(this.DebugOut);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.labelDriverId);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonChoose);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "TEMPLATEDEVICETYPE Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PositionBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelDriverId;
        private System.Windows.Forms.Button Position;
        private System.Windows.Forms.ListBox DebugOut;
        private System.Windows.Forms.Button SetPosition;
        private System.Windows.Forms.NumericUpDown PositionBox;
    }
}

