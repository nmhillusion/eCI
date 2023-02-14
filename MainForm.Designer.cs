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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.wantedPeopleTab.Controls.Add(this.textBox1);
            this.wantedPeopleTab.Controls.Add(this.button1);
            this.wantedPeopleTab.Location = new System.Drawing.Point(4, 22);
            this.wantedPeopleTab.Name = "wantedPeopleTab";
            this.wantedPeopleTab.Padding = new System.Windows.Forms.Padding(3);
            this.wantedPeopleTab.Size = new System.Drawing.Size(779, 386);
            this.wantedPeopleTab.TabIndex = 0;
            this.wantedPeopleTab.Text = "Wanted People";
            this.wantedPeopleTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crawl Wanted People";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(767, 20);
            this.textBox1.TabIndex = 3;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

