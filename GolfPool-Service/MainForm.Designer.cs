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
            this.btnScrapeTournament = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnGetTournamentList = new System.Windows.Forms.Button();
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScrapeTournament
            // 
            this.btnScrapeTournament.Location = new System.Drawing.Point(438, 10);
            this.btnScrapeTournament.Name = "btnScrapeTournament";
            this.btnScrapeTournament.Size = new System.Drawing.Size(145, 23);
            this.btnScrapeTournament.TabIndex = 3;
            this.btnScrapeTournament.Text = "Get Tournament Results";
            this.btnScrapeTournament.UseVisualStyleBackColor = true;
            this.btnScrapeTournament.Click += new System.EventHandler(this.btnScrapeTournament_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btnGetTournamentList
            // 
            this.btnGetTournamentList.Location = new System.Drawing.Point(12, 12);
            this.btnGetTournamentList.Name = "btnGetTournamentList";
            this.btnGetTournamentList.Size = new System.Drawing.Size(134, 23);
            this.btnGetTournamentList.TabIndex = 5;
            this.btnGetTournamentList.Text = "Refresh Tournament List";
            this.btnGetTournamentList.UseVisualStyleBackColor = true;
            this.btnGetTournamentList.Click += new System.EventHandler(this.btnGetTournamentList_Click);
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Location = new System.Drawing.Point(12, 41);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.Size = new System.Drawing.Size(571, 430);
            this.resultsGridView.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "No";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Yes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Are the above results correct?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultsGridView);
            this.Controls.Add(this.btnGetTournamentList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnScrapeTournament);
            this.Name = "MainForm";
            this.Text = "GolfPool-Service";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScrapeTournament;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnGetTournamentList;
        private System.Windows.Forms.DataGridView resultsGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;

    }
}

