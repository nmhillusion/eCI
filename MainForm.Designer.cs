namespace eCI
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
            this.tabs_ = new System.Windows.Forms.TabControl();
            this.wantedPeopleTab = new System.Windows.Forms.TabPage();
            this.btnBrowseSavedFolder = new System.Windows.Forms.Button();
            this.lblProgressStatus = new System.Windows.Forms.Label();
            this.inpUrlOfWantedPeople = new System.Windows.Forms.TextBox();
            this.btnCrawlWantedPeople = new System.Windows.Forms.Button();
            this.inpSavedFilePath = new System.Windows.Forms.TextBox();
            this.tabs_.SuspendLayout();
            this.wantedPeopleTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs_
            // 
            this.tabs_.Controls.Add(this.wantedPeopleTab);
            this.tabs_.Location = new System.Drawing.Point(13, 13);
            this.tabs_.Name = "tabs_";
            this.tabs_.SelectedIndex = 0;
            this.tabs_.Size = new System.Drawing.Size(787, 412);
            this.tabs_.TabIndex = 1;
            // 
            // wantedPeopleTab
            // 
            this.wantedPeopleTab.Controls.Add(this.inpSavedFilePath);
            this.wantedPeopleTab.Controls.Add(this.btnBrowseSavedFolder);
            this.wantedPeopleTab.Controls.Add(this.lblProgressStatus);
            this.wantedPeopleTab.Controls.Add(this.inpUrlOfWantedPeople);
            this.wantedPeopleTab.Controls.Add(this.btnCrawlWantedPeople);
            this.wantedPeopleTab.Location = new System.Drawing.Point(4, 22);
            this.wantedPeopleTab.Name = "wantedPeopleTab";
            this.wantedPeopleTab.Padding = new System.Windows.Forms.Padding(3);
            this.wantedPeopleTab.Size = new System.Drawing.Size(779, 386);
            this.wantedPeopleTab.TabIndex = 0;
            this.wantedPeopleTab.Text = "Wanted People";
            this.wantedPeopleTab.UseVisualStyleBackColor = true;
            // 
            // btnBrowseSavedFolder
            // 
            this.btnBrowseSavedFolder.Location = new System.Drawing.Point(696, 42);
            this.btnBrowseSavedFolder.Name = "btnBrowseSavedFolder";
            this.btnBrowseSavedFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSavedFolder.TabIndex = 5;
            this.btnBrowseSavedFolder.Text = "Browse";
            this.btnBrowseSavedFolder.UseVisualStyleBackColor = true;
            this.btnBrowseSavedFolder.Click += new System.EventHandler(this.btnBrowseSavedFolder_Click);
            // 
            // lblProgressStatus
            // 
            this.lblProgressStatus.AutoSize = true;
            this.lblProgressStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressStatus.Location = new System.Drawing.Point(333, 169);
            this.lblProgressStatus.Name = "lblProgressStatus";
            this.lblProgressStatus.Size = new System.Drawing.Size(58, 31);
            this.lblProgressStatus.TabIndex = 4;
            this.lblProgressStatus.Text = "--/--";
            // 
            // inpUrlOfWantedPeople
            // 
            this.inpUrlOfWantedPeople.Location = new System.Drawing.Point(4, 7);
            this.inpUrlOfWantedPeople.Name = "inpUrlOfWantedPeople";
            this.inpUrlOfWantedPeople.Size = new System.Drawing.Size(767, 20);
            this.inpUrlOfWantedPeople.TabIndex = 3;
            // 
            // btnCrawlWantedPeople
            // 
            this.btnCrawlWantedPeople.Location = new System.Drawing.Point(637, 94);
            this.btnCrawlWantedPeople.Name = "btnCrawlWantedPeople";
            this.btnCrawlWantedPeople.Size = new System.Drawing.Size(134, 23);
            this.btnCrawlWantedPeople.TabIndex = 2;
            this.btnCrawlWantedPeople.Text = "Crawl Wanted People";
            this.btnCrawlWantedPeople.UseVisualStyleBackColor = true;
            this.btnCrawlWantedPeople.Click += new System.EventHandler(this.btnCrawlWantedPeople_Click);
            // 
            // inpSavedFilePath
            // 
            this.inpSavedFilePath.Location = new System.Drawing.Point(4, 44);
            this.inpSavedFilePath.Name = "inpSavedFilePath";
            this.inpSavedFilePath.Size = new System.Drawing.Size(686, 20);
            this.inpSavedFilePath.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs_);
            this.Name = "MainForm";
            this.Text = "eCI";
            this.tabs_.ResumeLayout(false);
            this.wantedPeopleTab.ResumeLayout(false);
            this.wantedPeopleTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs_;
        private System.Windows.Forms.TabPage wantedPeopleTab;
        private System.Windows.Forms.Button btnCrawlWantedPeople;
        private System.Windows.Forms.TextBox inpUrlOfWantedPeople;
        private System.Windows.Forms.Label lblProgressStatus;
        private System.Windows.Forms.Button btnBrowseSavedFolder;
        private System.Windows.Forms.TextBox inpSavedFilePath;
    }
}

