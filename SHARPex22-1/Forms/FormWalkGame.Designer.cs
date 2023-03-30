
namespace Goosagotchi.Forms
{
    partial class FormWalkGame
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
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxGoose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWall1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWall2 = new System.Windows.Forms.PictureBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.timerSubwaySurf = new System.Windows.Forms.Timer(this.components);
            this.progressBarRun = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUp.ForeColor = System.Drawing.Color.Yellow;
            this.buttonUp.Location = new System.Drawing.Point(245, 415);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(306, 68);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "/\\";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // pictureBoxGoose
            // 
            this.pictureBoxGoose.Image = global::Goosagotchi.Properties.Resources.Walk;
            this.pictureBoxGoose.Location = new System.Drawing.Point(110, 300);
            this.pictureBoxGoose.Name = "pictureBoxGoose";
            this.pictureBoxGoose.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxGoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGoose.TabIndex = 5;
            this.pictureBoxGoose.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Goosagotchi.Properties.Resources.floor;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 375);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxWall1
            // 
            this.pictureBoxWall1.Image = global::Goosagotchi.Properties.Resources.wall;
            this.pictureBoxWall1.Location = new System.Drawing.Point(725, 40);
            this.pictureBoxWall1.Name = "pictureBoxWall1";
            this.pictureBoxWall1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWall1.TabIndex = 8;
            this.pictureBoxWall1.TabStop = false;
            // 
            // pictureBoxWall2
            // 
            this.pictureBoxWall2.Image = global::Goosagotchi.Properties.Resources.wall;
            this.pictureBoxWall2.Location = new System.Drawing.Point(403, 170);
            this.pictureBoxWall2.Name = "pictureBoxWall2";
            this.pictureBoxWall2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWall2.TabIndex = 9;
            this.pictureBoxWall2.TabStop = false;
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonDown.Enabled = false;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDown.ForeColor = System.Drawing.Color.Yellow;
            this.buttonDown.Location = new System.Drawing.Point(245, 489);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(306, 68);
            this.buttonDown.TabIndex = 11;
            this.buttonDown.Text = "\\/";
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // timerSubwaySurf
            // 
            this.timerSubwaySurf.Interval = 1;
            this.timerSubwaySurf.Tick += new System.EventHandler(this.timerSubwaySurf_Tick);
            // 
            // progressBarRun
            // 
            this.progressBarRun.Location = new System.Drawing.Point(12, 5);
            this.progressBarRun.Maximum = 1500;
            this.progressBarRun.Name = "progressBarRun";
            this.progressBarRun.Size = new System.Drawing.Size(777, 23);
            this.progressBarRun.TabIndex = 12;
            this.progressBarRun.Value = 1500;
            // 
            // FormWalkGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.progressBarRun);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.pictureBoxWall2);
            this.Controls.Add(this.pictureBoxWall1);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.pictureBoxGoose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWalkGame";
            this.Text = "FormWalkGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWall2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.PictureBox pictureBoxGoose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxWall1;
        private System.Windows.Forms.PictureBox pictureBoxWall2;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Timer timerSubwaySurf;
        private System.Windows.Forms.ProgressBar progressBarRun;
    }
}