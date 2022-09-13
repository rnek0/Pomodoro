namespace Pomodoro
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tLayoutPanelBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnWorking = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.tLayoutPanelTime = new System.Windows.Forms.TableLayoutPanel();
            this.lblTime = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTasksFinished = new System.Windows.Forms.Label();
            this.timerPomodoro = new System.Windows.Forms.Timer(this.components);
            this.tLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tLayoutPanelBtns.SuspendLayout();
            this.tLayoutPanelTime.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLayoutPanel
            // 
            this.tLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tLayoutPanel.ColumnCount = 2;
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.tLayoutPanel.Controls.Add(this.tLayoutPanelBtns, 1, 1);
            this.tLayoutPanel.Controls.Add(this.tLayoutPanelTime, 1, 0);
            this.tLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tLayoutPanel.Name = "tLayoutPanel";
            this.tLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.tLayoutPanel.RowCount = 2;
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLayoutPanel.Size = new System.Drawing.Size(937, 527);
            this.tLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Pomodoro.Properties.Resources.TomateTransparent;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(80);
            this.pictureBox1.Name = "pictureBox1";
            this.tLayoutPanel.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(300, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tLayoutPanelBtns
            // 
            this.tLayoutPanelBtns.ColumnCount = 1;
            this.tLayoutPanelBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPanelBtns.Controls.Add(this.btnWorking, 0, 0);
            this.tLayoutPanelBtns.Controls.Add(this.btnRest, 0, 1);
            this.tLayoutPanelBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutPanelBtns.Location = new System.Drawing.Point(468, 263);
            this.tLayoutPanelBtns.Margin = new System.Windows.Forms.Padding(0);
            this.tLayoutPanelBtns.Name = "tLayoutPanelBtns";
            this.tLayoutPanelBtns.RowCount = 2;
            this.tLayoutPanelBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPanelBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPanelBtns.Size = new System.Drawing.Size(461, 256);
            this.tLayoutPanelBtns.TabIndex = 5;
            // 
            // btnWorking
            // 
            this.btnWorking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorking.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorking.ForeColor = System.Drawing.Color.White;
            this.btnWorking.Location = new System.Drawing.Point(20, 20);
            this.btnWorking.Margin = new System.Windows.Forms.Padding(20);
            this.btnWorking.Name = "btnWorking";
            this.btnWorking.Size = new System.Drawing.Size(421, 88);
            this.btnWorking.TabIndex = 1;
            this.btnWorking.Text = "TRAVAIL";
            this.btnWorking.UseVisualStyleBackColor = true;
            // 
            // btnRest
            // 
            this.btnRest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.Color.White;
            this.btnRest.Location = new System.Drawing.Point(20, 148);
            this.btnRest.Margin = new System.Windows.Forms.Padding(20);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(421, 88);
            this.btnRest.TabIndex = 2;
            this.btnRest.Text = "REPOS";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // tLayoutPanelTime
            // 
            this.tLayoutPanelTime.ColumnCount = 2;
            this.tLayoutPanelTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.96703F));
            this.tLayoutPanelTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.03297F));
            this.tLayoutPanelTime.Controls.Add(this.lblTime, 0, 1);
            this.tLayoutPanelTime.Controls.Add(this.panelSettings, 1, 0);
            this.tLayoutPanelTime.Controls.Add(this.lblTasksFinished, 0, 0);
            this.tLayoutPanelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutPanelTime.Location = new System.Drawing.Point(471, 11);
            this.tLayoutPanelTime.Name = "tLayoutPanelTime";
            this.tLayoutPanelTime.RowCount = 2;
            this.tLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.27711F));
            this.tLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.72289F));
            this.tLayoutPanelTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLayoutPanelTime.Size = new System.Drawing.Size(455, 249);
            this.tLayoutPanelTime.TabIndex = 6;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tLayoutPanelTime.SetColumnSpan(this.lblTime, 2);
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(20, 58);
            this.lblTime.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(415, 181);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelSettings.Controls.Add(this.btnSettings);
            this.panelSettings.Controls.Add(this.btnStop);
            this.panelSettings.Location = new System.Drawing.Point(332, 1);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(123, 46);
            this.panelSettings.TabIndex = 10;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSettings.BackgroundImage = global::Pomodoro.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(59, 1);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 45);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Tag = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStop.BackgroundImage = global::Pomodoro.Properties.Resources.reset;
            this.btnStop.Location = new System.Drawing.Point(2, 1);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 45);
            this.btnStop.TabIndex = 3;
            this.btnStop.Tag = "RESET";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblTasksFinished
            // 
            this.lblTasksFinished.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTasksFinished.AutoSize = true;
            this.lblTasksFinished.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasksFinished.ForeColor = System.Drawing.Color.White;
            this.lblTasksFinished.Location = new System.Drawing.Point(20, 14);
            this.lblTasksFinished.Margin = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.lblTasksFinished.Name = "lblTasksFinished";
            this.lblTasksFinished.Size = new System.Drawing.Size(111, 29);
            this.lblTasksFinished.TabIndex = 11;
            this.lblTasksFinished.Text = "sssssss";
            // 
            // timerPomodoro
            // 
            this.timerPomodoro.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(937, 527);
            this.Controls.Add(this.tLayoutPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.tLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tLayoutPanelBtns.ResumeLayout(false);
            this.tLayoutPanelTime.ResumeLayout(false);
            this.tLayoutPanelTime.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLayoutPanel;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tLayoutPanelBtns;
        private System.Windows.Forms.Button btnWorking;
        private System.Windows.Forms.Timer timerPomodoro;
        private System.Windows.Forms.TableLayoutPanel tLayoutPanelTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTasksFinished;
    }
}

