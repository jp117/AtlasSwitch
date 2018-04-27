namespace AtlasSwitch
{
    partial class MainPage
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.QtsBtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.Controls.Add(this.QtsBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(201, 547);
            this.LeftPanel.TabIndex = 1;
            // 
            // QtsBtn
            // 
            this.QtsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.QtsBtn.FlatAppearance.BorderSize = 0;
            this.QtsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QtsBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QtsBtn.Location = new System.Drawing.Point(2, 2);
            this.QtsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QtsBtn.Name = "QtsBtn";
            this.QtsBtn.Size = new System.Drawing.Size(199, 41);
            this.QtsBtn.TabIndex = 0;
            this.QtsBtn.Text = "Quotes";
            this.QtsBtn.UseVisualStyleBackColor = false;
            this.QtsBtn.Click += new System.EventHandler(this.QtsBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(981, 547);
            this.Controls.Add(this.LeftPanel);
            this.IsMdiContainer = true;
            this.Name = "MainPage";
            this.Text = "AtlasSwitch";
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button QtsBtn;
    }
}

