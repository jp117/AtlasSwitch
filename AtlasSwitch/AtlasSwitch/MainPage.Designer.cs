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
            this.SearchQtsBtn = new System.Windows.Forms.Button();
            this.NewQtsBtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.Controls.Add(this.NewQtsBtn);
            this.LeftPanel.Controls.Add(this.SearchQtsBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(402, 1052);
            this.LeftPanel.TabIndex = 1;
            // 
            // SearchQtsBtn
            // 
            this.SearchQtsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.SearchQtsBtn.FlatAppearance.BorderSize = 0;
            this.SearchQtsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchQtsBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQtsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchQtsBtn.Location = new System.Drawing.Point(4, 3);
            this.SearchQtsBtn.Name = "SearchQtsBtn";
            this.SearchQtsBtn.Size = new System.Drawing.Size(398, 79);
            this.SearchQtsBtn.TabIndex = 0;
            this.SearchQtsBtn.Text = "Search/Edit Quotes";
            this.SearchQtsBtn.UseVisualStyleBackColor = false;
            // 
            // NewQtsBtn
            // 
            this.NewQtsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.NewQtsBtn.FlatAppearance.BorderSize = 0;
            this.NewQtsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewQtsBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQtsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewQtsBtn.Location = new System.Drawing.Point(4, 88);
            this.NewQtsBtn.Name = "NewQtsBtn";
            this.NewQtsBtn.Size = new System.Drawing.Size(398, 79);
            this.NewQtsBtn.TabIndex = 1;
            this.NewQtsBtn.Text = "New Quote";
            this.NewQtsBtn.UseVisualStyleBackColor = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1962, 1052);
            this.Controls.Add(this.LeftPanel);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainPage";
            this.Text = "AtlasSwitch";
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button SearchQtsBtn;
        private System.Windows.Forms.Button NewQtsBtn;
    }
}

