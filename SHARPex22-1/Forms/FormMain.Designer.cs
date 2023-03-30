
namespace Goosagotchi.Forms
{
    partial class FormMain
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTimeToComplete = new System.Windows.Forms.Label();
            this.progressBarComplete = new System.Windows.Forms.ProgressBar();
            this.labelStatusPage = new System.Windows.Forms.Label();
            this.labelActions = new System.Windows.Forms.Label();
            this.labelMistakesPage = new System.Windows.Forms.Label();
            this.labelMistakes = new System.Windows.Forms.Label();
            this.labelLocalization = new System.Windows.Forms.Label();
            this.buttonHeal = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonWalk = new System.Windows.Forms.Button();
            this.buttonEat = new System.Windows.Forms.Button();
            this.pictureBoxGoose = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.labelStatus.Font = new System.Drawing.Font("Cascadia Code Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Yellow;
            this.labelStatus.Location = new System.Drawing.Point(25, 317);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(230, 192);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "I feel good";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.MouseLeave += new System.EventHandler(this.labelStatus_MouseLeave);
            this.labelStatus.MouseHover += new System.EventHandler(this.labelStatus_MouseHover);
            // 
            // labelTimeToComplete
            // 
            this.labelTimeToComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.labelTimeToComplete.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeToComplete.ForeColor = System.Drawing.Color.Yellow;
            this.labelTimeToComplete.Location = new System.Drawing.Point(14, 9);
            this.labelTimeToComplete.Name = "labelTimeToComplete";
            this.labelTimeToComplete.Size = new System.Drawing.Size(784, 72);
            this.labelTimeToComplete.TabIndex = 5;
            this.labelTimeToComplete.Text = "TIME TO COMPLETE";
            this.labelTimeToComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimeToComplete.MouseLeave += new System.EventHandler(this.labelTimeToComplete_MouseLeave);
            this.labelTimeToComplete.MouseHover += new System.EventHandler(this.labelTimeToComplete_MouseHover);
            // 
            // progressBarComplete
            // 
            this.progressBarComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progressBarComplete.ForeColor = System.Drawing.Color.Black;
            this.progressBarComplete.Location = new System.Drawing.Point(14, 58);
            this.progressBarComplete.Name = "progressBarComplete";
            this.progressBarComplete.Size = new System.Drawing.Size(784, 23);
            this.progressBarComplete.TabIndex = 6;
            this.progressBarComplete.Value = 34;
            // 
            // labelStatusPage
            // 
            this.labelStatusPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.labelStatusPage.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusPage.ForeColor = System.Drawing.Color.Yellow;
            this.labelStatusPage.Location = new System.Drawing.Point(25, 259);
            this.labelStatusPage.Name = "labelStatusPage";
            this.labelStatusPage.Size = new System.Drawing.Size(230, 58);
            this.labelStatusPage.TabIndex = 11;
            this.labelStatusPage.Text = "STATUS";
            this.labelStatusPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatusPage.MouseLeave += new System.EventHandler(this.labelStatusPage_MouseLeave);
            this.labelStatusPage.MouseHover += new System.EventHandler(this.labelStatusPage_MouseHover);
            // 
            // labelActions
            // 
            this.labelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.labelActions.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActions.ForeColor = System.Drawing.Color.Yellow;
            this.labelActions.Location = new System.Drawing.Point(14, 102);
            this.labelActions.Name = "labelActions";
            this.labelActions.Size = new System.Drawing.Size(784, 31);
            this.labelActions.TabIndex = 12;
            this.labelActions.Text = "ACTIONS";
            this.labelActions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelActions.MouseLeave += new System.EventHandler(this.labelActions_MouseLeave);
            this.labelActions.MouseHover += new System.EventHandler(this.labelActions_MouseHover);
            // 
            // labelMistakesPage
            // 
            this.labelMistakesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.labelMistakesPage.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMistakesPage.ForeColor = System.Drawing.Color.Yellow;
            this.labelMistakesPage.Location = new System.Drawing.Point(555, 259);
            this.labelMistakesPage.Name = "labelMistakesPage";
            this.labelMistakesPage.Size = new System.Drawing.Size(230, 58);
            this.labelMistakesPage.TabIndex = 13;
            this.labelMistakesPage.Text = "MISTAKES";
            this.labelMistakesPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMistakesPage.MouseLeave += new System.EventHandler(this.labelMistakesPage_MouseLeave);
            this.labelMistakesPage.MouseHover += new System.EventHandler(this.labelMistakesPage_MouseHover);
            // 
            // labelMistakes
            // 
            this.labelMistakes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.labelMistakes.Font = new System.Drawing.Font("Cascadia Code Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMistakes.ForeColor = System.Drawing.Color.Yellow;
            this.labelMistakes.Location = new System.Drawing.Point(555, 317);
            this.labelMistakes.Name = "labelMistakes";
            this.labelMistakes.Size = new System.Drawing.Size(230, 192);
            this.labelMistakes.TabIndex = 14;
            this.labelMistakes.Text = "0 OF 3";
            this.labelMistakes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMistakes.MouseLeave += new System.EventHandler(this.labelMistakes_MouseLeave);
            this.labelMistakes.MouseHover += new System.EventHandler(this.labelMistakes_MouseHover);
            // 
            // labelLocalization
            // 
            this.labelLocalization.AutoSize = true;
            this.labelLocalization.BackColor = System.Drawing.Color.White;
            this.labelLocalization.Font = new System.Drawing.Font("Cascadia Code Light", 12F);
            this.labelLocalization.Location = new System.Drawing.Point(-2, 602);
            this.labelLocalization.Name = "labelLocalization";
            this.labelLocalization.Size = new System.Drawing.Size(109, 21);
            this.labelLocalization.TabIndex = 15;
            this.labelLocalization.Text = "Локализация";
            this.labelLocalization.Visible = false;
            // 
            // buttonHeal
            // 
            this.buttonHeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonHeal.BackgroundImage = global::Goosagotchi.Properties.Resources.buttonHeal3;
            this.buttonHeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHeal.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHeal.ForeColor = System.Drawing.Color.Yellow;
            this.buttonHeal.Location = new System.Drawing.Point(646, 136);
            this.buttonHeal.Name = "buttonHeal";
            this.buttonHeal.Size = new System.Drawing.Size(152, 88);
            this.buttonHeal.TabIndex = 10;
            this.buttonHeal.Text = "Heal";
            this.buttonHeal.UseVisualStyleBackColor = false;
            this.buttonHeal.Click += new System.EventHandler(this.buttonHeal_Click);
            this.buttonHeal.MouseLeave += new System.EventHandler(this.buttonHeal_MouseLeave);
            this.buttonHeal.MouseHover += new System.EventHandler(this.buttonHeal_MouseHover);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonPlay.BackgroundImage = global::Goosagotchi.Properties.Resources.buttonPlay;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Yellow;
            this.buttonPlay.Location = new System.Drawing.Point(488, 136);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(152, 88);
            this.buttonPlay.TabIndex = 9;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.buttonPlay_MouseLeave);
            this.buttonPlay.MouseHover += new System.EventHandler(this.buttonPlay_MouseHover);
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonSleep.BackgroundImage = global::Goosagotchi.Properties.Resources.buttonSleep;
            this.buttonSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSleep.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSleep.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSleep.Location = new System.Drawing.Point(330, 136);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(152, 88);
            this.buttonSleep.TabIndex = 8;
            this.buttonSleep.Text = "Put to bed";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            this.buttonSleep.MouseLeave += new System.EventHandler(this.buttonSleep_MouseLeave);
            this.buttonSleep.MouseHover += new System.EventHandler(this.buttonSleep_MouseHover);
            // 
            // buttonWalk
            // 
            this.buttonWalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonWalk.BackgroundImage = global::Goosagotchi.Properties.Resources.buttonWalk1;
            this.buttonWalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWalk.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWalk.ForeColor = System.Drawing.Color.Yellow;
            this.buttonWalk.Location = new System.Drawing.Point(172, 136);
            this.buttonWalk.Name = "buttonWalk";
            this.buttonWalk.Size = new System.Drawing.Size(152, 88);
            this.buttonWalk.TabIndex = 7;
            this.buttonWalk.Text = "Take a walk";
            this.buttonWalk.UseVisualStyleBackColor = false;
            this.buttonWalk.Click += new System.EventHandler(this.buttonWalk_Click);
            this.buttonWalk.MouseLeave += new System.EventHandler(this.buttonWalk_MouseLeave);
            this.buttonWalk.MouseHover += new System.EventHandler(this.buttonWalk_MouseHover);
            // 
            // buttonEat
            // 
            this.buttonEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonEat.BackgroundImage = global::Goosagotchi.Properties.Resources.buttonFeed2;
            this.buttonEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEat.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEat.ForeColor = System.Drawing.Color.Yellow;
            this.buttonEat.Location = new System.Drawing.Point(14, 136);
            this.buttonEat.Name = "buttonEat";
            this.buttonEat.Size = new System.Drawing.Size(152, 88);
            this.buttonEat.TabIndex = 4;
            this.buttonEat.Text = "Feed";
            this.buttonEat.UseVisualStyleBackColor = false;
            this.buttonEat.Click += new System.EventHandler(this.buttonEat_Click);
            this.buttonEat.MouseLeave += new System.EventHandler(this.buttonEat_MouseLeave);
            this.buttonEat.MouseHover += new System.EventHandler(this.buttonEat_MouseHover);
            // 
            // pictureBoxGoose
            // 
            this.pictureBoxGoose.Image = global::Goosagotchi.Properties.Resources.Normal;
            this.pictureBoxGoose.Location = new System.Drawing.Point(279, 259);
            this.pictureBoxGoose.Name = "pictureBoxGoose";
            this.pictureBoxGoose.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxGoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGoose.TabIndex = 3;
            this.pictureBoxGoose.TabStop = false;
            this.pictureBoxGoose.MouseLeave += new System.EventHandler(this.pictureBoxGoose_MouseLeave);
            this.pictureBoxGoose.MouseHover += new System.EventHandler(this.pictureBoxGoose_MouseHover);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Goosagotchi.Properties.Resources.LogoReal;
            this.pictureBoxLogo.Location = new System.Drawing.Point(172, 526);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(468, 85);
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseLeave += new System.EventHandler(this.pictureBoxLogo_MouseLeave);
            this.pictureBoxLogo.MouseHover += new System.EventHandler(this.pictureBoxLogo_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(810, 623);
            this.Controls.Add(this.labelLocalization);
            this.Controls.Add(this.labelMistakes);
            this.Controls.Add(this.labelMistakesPage);
            this.Controls.Add(this.labelStatusPage);
            this.Controls.Add(this.buttonHeal);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonWalk);
            this.Controls.Add(this.progressBarComplete);
            this.Controls.Add(this.labelTimeToComplete);
            this.Controls.Add(this.buttonEat);
            this.Controls.Add(this.pictureBoxGoose);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelActions);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "Goosagochi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGoose;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonEat;
        private System.Windows.Forms.Label labelTimeToComplete;
        private System.Windows.Forms.ProgressBar progressBarComplete;
        private System.Windows.Forms.Button buttonWalk;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonHeal;
        private System.Windows.Forms.Label labelStatusPage;
        private System.Windows.Forms.Label labelActions;
        private System.Windows.Forms.Label labelMistakesPage;
        private System.Windows.Forms.Label labelMistakes;
        private System.Windows.Forms.Label labelLocalization;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}