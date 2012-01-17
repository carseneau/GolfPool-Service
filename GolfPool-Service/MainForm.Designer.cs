namespace GolfPool_Service
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainFormErrorGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tournamentScrapingErrorGridView = new System.Windows.Forms.DataGridView();
            this.btnScrapeTournament = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGetTournamentList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormErrorGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentScrapingErrorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 128);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 374);
            this.dataGridView1.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(12, 144);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1226, 433);
            this.TabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1218, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Last Tournament Updated";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mainFormErrorGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1218, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "mainFormErrorTab";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mainFormErrorGridView
            // 
            this.mainFormErrorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainFormErrorGridView.Location = new System.Drawing.Point(6, 6);
            this.mainFormErrorGridView.Name = "mainFormErrorGridView";
            this.mainFormErrorGridView.Size = new System.Drawing.Size(1206, 395);
            this.mainFormErrorGridView.TabIndex = 0;
            this.mainFormErrorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.errorGridView_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tournamentScrapingErrorGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1218, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tournament Scraping Errors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tournamentScrapingErrorGridView
            // 
            this.tournamentScrapingErrorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tournamentScrapingErrorGridView.Location = new System.Drawing.Point(363, 79);
            this.tournamentScrapingErrorGridView.Name = "tournamentScrapingErrorGridView";
            this.tournamentScrapingErrorGridView.Size = new System.Drawing.Size(240, 150);
            this.tournamentScrapingErrorGridView.TabIndex = 0;
            this.tournamentScrapingErrorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tournamentScrapingErrorGridView_CellContentClick);
            // 
            // btnScrapeTournament
            // 
            this.btnScrapeTournament.Location = new System.Drawing.Point(1080, 12);
            this.btnScrapeTournament.Name = "btnScrapeTournament";
            this.btnScrapeTournament.Size = new System.Drawing.Size(154, 23);
            this.btnScrapeTournament.TabIndex = 3;
            this.btnScrapeTournament.Text = "Get Tournament Results";
            this.btnScrapeTournament.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(503, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btnGetTournamentList
            // 
            this.btnGetTournamentList.Location = new System.Drawing.Point(408, 12);
            this.btnGetTournamentList.Name = "btnGetTournamentList";
            this.btnGetTournamentList.Size = new System.Drawing.Size(157, 23);
            this.btnGetTournamentList.TabIndex = 5;
            this.btnGetTournamentList.Text = "Refresh Tournament List";
            this.btnGetTournamentList.UseVisualStyleBackColor = true;
            this.btnGetTournamentList.Click += new System.EventHandler(this.btnGetTournamentList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 589);
            this.Controls.Add(this.btnGetTournamentList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnScrapeTournament);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.StatusLabel);
            this.Name = "MainForm";
            this.Text = "GolfPool-Service";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormErrorGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tournamentScrapingErrorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnScrapeTournament;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGetTournamentList;
        private System.Windows.Forms.DataGridView mainFormErrorGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView tournamentScrapingErrorGridView;

    }
}

