namespace TIC_TAC_TOE
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HelpSubMenuPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.HelpsButton = new System.Windows.Forms.Button();
            this.SubMenuPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.GameButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.ToyPictureBox = new System.Windows.Forms.PictureBox();
            this.SideMenuPanel.SuspendLayout();
            this.HelpSubMenuPanel.SuspendLayout();
            this.SubMenuPanel.SuspendLayout();
            this.FooterPanel.SuspendLayout();
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.SideMenuPanel.Controls.Add(this.ExitButton);
            this.SideMenuPanel.Controls.Add(this.HelpSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.HelpsButton);
            this.SideMenuPanel.Controls.Add(this.SubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.GameButton);
            this.SideMenuPanel.Controls.Add(this.LogoPanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(250, 562);
            this.SideMenuPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.Image = global::TIC_TAC_TOE.Properties.Resources.application_exit_4;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(0, 517);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(250, 45);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "&Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HelpSubMenuPanel
            // 
            this.HelpSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.HelpSubMenuPanel.Controls.Add(this.button6);
            this.HelpSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpSubMenuPanel.Location = new System.Drawing.Point(0, 242);
            this.HelpSubMenuPanel.Name = "HelpSubMenuPanel";
            this.HelpSubMenuPanel.Size = new System.Drawing.Size(250, 47);
            this.HelpSubMenuPanel.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.LightGray;
            this.button6.Image = global::TIC_TAC_TOE.Properties.Resources.help_about;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "&About TIC TAC TOY";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // HelpsButton
            // 
            this.HelpsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpsButton.FlatAppearance.BorderSize = 0;
            this.HelpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.HelpsButton.Image = global::TIC_TAC_TOE.Properties.Resources.help_contents;
            this.HelpsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpsButton.Location = new System.Drawing.Point(0, 197);
            this.HelpsButton.Name = "HelpsButton";
            this.HelpsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.HelpsButton.Size = new System.Drawing.Size(250, 45);
            this.HelpsButton.TabIndex = 3;
            this.HelpsButton.Text = "&Help";
            this.HelpsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HelpsButton.UseVisualStyleBackColor = true;
            this.HelpsButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SubMenuPanel
            // 
            this.SubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.SubMenuPanel.Controls.Add(this.button2);
            this.SubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuPanel.Location = new System.Drawing.Point(0, 145);
            this.SubMenuPanel.Name = "SubMenuPanel";
            this.SubMenuPanel.Size = new System.Drawing.Size(250, 52);
            this.SubMenuPanel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Image = global::TIC_TAC_TOE.Properties.Resources.media_playback_start_6;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "&Start New Game";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameButton
            // 
            this.GameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameButton.FlatAppearance.BorderSize = 0;
            this.GameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.GameButton.Image = global::TIC_TAC_TOE.Properties.Resources.games_config_theme;
            this.GameButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GameButton.Location = new System.Drawing.Point(0, 100);
            this.GameButton.Name = "GameButton";
            this.GameButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.GameButton.Size = new System.Drawing.Size(250, 45);
            this.GameButton.TabIndex = 1;
            this.GameButton.Text = "Game";
            this.GameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GameButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GameButton.UseVisualStyleBackColor = true;
            this.GameButton.Click += new System.EventHandler(this.GameButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackgroundImage = global::TIC_TAC_TOE.Properties.Resources.preview_xl;
            this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(250, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.FooterPanel.Controls.Add(this.label1);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(250, 477);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(684, 85);
            this.FooterPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century751 SeBd BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Right reserved with Ashfaque Ali...";
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ContainerPanel.Controls.Add(this.ToyPictureBox);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(250, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(684, 477);
            this.ContainerPanel.TabIndex = 2;
            // 
            // ToyPictureBox
            // 
            this.ToyPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToyPictureBox.Image = global::TIC_TAC_TOE.Properties.Resources.images;
            this.ToyPictureBox.Location = new System.Drawing.Point(69, 88);
            this.ToyPictureBox.Name = "ToyPictureBox";
            this.ToyPictureBox.Size = new System.Drawing.Size(546, 301);
            this.ToyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToyPictureBox.TabIndex = 0;
            this.ToyPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.FooterPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ali TIC TAC TOE";
            this.SideMenuPanel.ResumeLayout(false);
            this.HelpSubMenuPanel.ResumeLayout(false);
            this.SubMenuPanel.ResumeLayout(false);
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.ContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel HelpSubMenuPanel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button HelpsButton;
        private System.Windows.Forms.Panel SubMenuPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GameButton;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.PictureBox ToyPictureBox;
        private System.Windows.Forms.Label label1;
    }
}

