namespace WhoIsCoolerScore
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NameTeam1 = new MetroFramework.Controls.MetroTextBox();
            this.NameTeam2 = new MetroFramework.Controls.MetroTextBox();
            this.ScoreTeam1 = new MetroFramework.Controls.MetroTextBox();
            this.ScoreTeam2 = new MetroFramework.Controls.MetroTextBox();
            this.LabelNameTeam1 = new MetroFramework.Controls.MetroLabel();
            this.LabelNameTeam2 = new MetroFramework.Controls.MetroLabel();
            this.LabelScoreTeam1 = new MetroFramework.Controls.MetroLabel();
            this.LabelScoreTeam2 = new MetroFramework.Controls.MetroLabel();
            this.ShowWindow = new MetroFramework.Controls.MetroButton();
            this.HideWindow = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTeam1
            // 
            this.NameTeam1.Location = new System.Drawing.Point(263, 72);
            this.NameTeam1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTeam1.Name = "NameTeam1";
            this.NameTeam1.Size = new System.Drawing.Size(153, 22);
            this.NameTeam1.Style = MetroFramework.MetroColorStyle.Purple;
            this.NameTeam1.TabIndex = 0;
            this.NameTeam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTeam1.UseStyleColors = true;
            // 
            // NameTeam2
            // 
            this.NameTeam2.Location = new System.Drawing.Point(263, 101);
            this.NameTeam2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTeam2.Name = "NameTeam2";
            this.NameTeam2.Size = new System.Drawing.Size(153, 22);
            this.NameTeam2.Style = MetroFramework.MetroColorStyle.Purple;
            this.NameTeam2.TabIndex = 1;
            this.NameTeam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTeam2.UseStyleColors = true;
            // 
            // ScoreTeam1
            // 
            this.ScoreTeam1.Location = new System.Drawing.Point(637, 72);
            this.ScoreTeam1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScoreTeam1.Name = "ScoreTeam1";
            this.ScoreTeam1.Size = new System.Drawing.Size(56, 22);
            this.ScoreTeam1.Style = MetroFramework.MetroColorStyle.Purple;
            this.ScoreTeam1.TabIndex = 2;
            this.ScoreTeam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreTeam1.UseStyleColors = true;
            // 
            // ScoreTeam2
            // 
            this.ScoreTeam2.Location = new System.Drawing.Point(637, 101);
            this.ScoreTeam2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScoreTeam2.Name = "ScoreTeam2";
            this.ScoreTeam2.Size = new System.Drawing.Size(56, 22);
            this.ScoreTeam2.Style = MetroFramework.MetroColorStyle.Purple;
            this.ScoreTeam2.TabIndex = 3;
            this.ScoreTeam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreTeam2.UseStyleColors = true;
            // 
            // LabelNameTeam1
            // 
            this.LabelNameTeam1.AutoSize = true;
            this.LabelNameTeam1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelNameTeam1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelNameTeam1.Location = new System.Drawing.Point(22, 69);
            this.LabelNameTeam1.Name = "LabelNameTeam1";
            this.LabelNameTeam1.Size = new System.Drawing.Size(236, 25);
            this.LabelNameTeam1.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelNameTeam1.TabIndex = 4;
            this.LabelNameTeam1.Text = "Название первой команды";
            this.LabelNameTeam1.UseStyleColors = true;
            // 
            // LabelNameTeam2
            // 
            this.LabelNameTeam2.AutoSize = true;
            this.LabelNameTeam2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelNameTeam2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelNameTeam2.Location = new System.Drawing.Point(22, 98);
            this.LabelNameTeam2.Name = "LabelNameTeam2";
            this.LabelNameTeam2.Size = new System.Drawing.Size(235, 25);
            this.LabelNameTeam2.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelNameTeam2.TabIndex = 5;
            this.LabelNameTeam2.Text = "Название второй команды";
            this.LabelNameTeam2.UseStyleColors = true;
            // 
            // LabelScoreTeam1
            // 
            this.LabelScoreTeam1.AutoSize = true;
            this.LabelScoreTeam1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelScoreTeam1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelScoreTeam1.Location = new System.Drawing.Point(422, 72);
            this.LabelScoreTeam1.Name = "LabelScoreTeam1";
            this.LabelScoreTeam1.Size = new System.Drawing.Size(201, 25);
            this.LabelScoreTeam1.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelScoreTeam1.TabIndex = 6;
            this.LabelScoreTeam1.Text = "Очки первой команды";
            this.LabelScoreTeam1.UseStyleColors = true;
            // 
            // LabelScoreTeam2
            // 
            this.LabelScoreTeam2.AutoSize = true;
            this.LabelScoreTeam2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LabelScoreTeam2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LabelScoreTeam2.Location = new System.Drawing.Point(423, 98);
            this.LabelScoreTeam2.Name = "LabelScoreTeam2";
            this.LabelScoreTeam2.Size = new System.Drawing.Size(200, 25);
            this.LabelScoreTeam2.Style = MetroFramework.MetroColorStyle.Blue;
            this.LabelScoreTeam2.TabIndex = 7;
            this.LabelScoreTeam2.Text = "Очки второй команды";
            this.LabelScoreTeam2.UseStyleColors = true;
            // 
            // ShowWindow
            // 
            this.ShowWindow.Highlight = true;
            this.ShowWindow.Location = new System.Drawing.Point(22, 147);
            this.ShowWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowWindow.Name = "ShowWindow";
            this.ShowWindow.Size = new System.Drawing.Size(184, 34);
            this.ShowWindow.Style = MetroFramework.MetroColorStyle.Blue;
            this.ShowWindow.TabIndex = 8;
            this.ShowWindow.Text = "Отобразить";
            this.ShowWindow.Click += new System.EventHandler(this.ShowWindow_Click);
            // 
            // HideWindow
            // 
            this.HideWindow.Highlight = true;
            this.HideWindow.Location = new System.Drawing.Point(232, 147);
            this.HideWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HideWindow.Name = "HideWindow";
            this.HideWindow.Size = new System.Drawing.Size(184, 34);
            this.HideWindow.Style = MetroFramework.MetroColorStyle.Blue;
            this.HideWindow.TabIndex = 9;
            this.HideWindow.Text = "Свернуть";
            this.HideWindow.Click += new System.EventHandler(this.HideWindow_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 215);
            this.Controls.Add(this.HideWindow);
            this.Controls.Add(this.ShowWindow);
            this.Controls.Add(this.LabelScoreTeam2);
            this.Controls.Add(this.LabelScoreTeam1);
            this.Controls.Add(this.LabelNameTeam2);
            this.Controls.Add(this.LabelNameTeam1);
            this.Controls.Add(this.ScoreTeam2);
            this.Controls.Add(this.ScoreTeam1);
            this.Controls.Add(this.NameTeam2);
            this.Controls.Add(this.NameTeam1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "WhoIsCooler MORSS by E1337";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox NameTeam1;
        private MetroFramework.Controls.MetroTextBox NameTeam2;
        private MetroFramework.Controls.MetroTextBox ScoreTeam1;
        private MetroFramework.Controls.MetroTextBox ScoreTeam2;
        private MetroFramework.Controls.MetroLabel LabelNameTeam1;
        private MetroFramework.Controls.MetroLabel LabelNameTeam2;
        private MetroFramework.Controls.MetroLabel LabelScoreTeam1;
        private MetroFramework.Controls.MetroLabel LabelScoreTeam2;
        private MetroFramework.Controls.MetroButton ShowWindow;
        private MetroFramework.Controls.MetroButton HideWindow;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

