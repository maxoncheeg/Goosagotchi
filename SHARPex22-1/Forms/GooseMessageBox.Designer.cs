
namespace Goosagotchi.Forms
{
    partial class GooseMessageBox
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
            this.labelDOL = new System.Windows.Forms.Label();
            this.labelDOLPage = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLocalization = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDOL
            // 
            this.labelDOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.labelDOL.Font = new System.Drawing.Font("Cascadia Code Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOL.ForeColor = System.Drawing.Color.Yellow;
            this.labelDOL.Location = new System.Drawing.Point(12, 284);
            this.labelDOL.Name = "labelDOL";
            this.labelDOL.Size = new System.Drawing.Size(468, 72);
            this.labelDOL.TabIndex = 16;
            this.labelDOL.Text = "Days: 10, Hours: 9";
            this.labelDOL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDOL.MouseLeave += new System.EventHandler(this.labelDOL_MouseLeave);
            this.labelDOL.MouseHover += new System.EventHandler(this.labelDOL_MouseHover);
            // 
            // labelDOLPage
            // 
            this.labelDOLPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(100)))));
            this.labelDOLPage.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOLPage.ForeColor = System.Drawing.Color.Yellow;
            this.labelDOLPage.Location = new System.Drawing.Point(12, 226);
            this.labelDOLPage.Name = "labelDOLPage";
            this.labelDOLPage.Size = new System.Drawing.Size(468, 58);
            this.labelDOLPage.TabIndex = 15;
            this.labelDOLPage.Text = "DURATION OF LIFE";
            this.labelDOLPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDOLPage.MouseLeave += new System.EventHandler(this.labelDOLPage_MouseLeave);
            this.labelDOLPage.MouseHover += new System.EventHandler(this.labelDOLPage_MouseHover);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Yellow;
            this.buttonExit.Location = new System.Drawing.Point(12, 359);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(468, 79);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            this.buttonExit.MouseHover += new System.EventHandler(this.buttonExit_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Goosagotchi.Properties.Resources.gameover;
            this.pictureBox1.Location = new System.Drawing.Point(12, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 120);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Goosagotchi.Properties.Resources.LogoReal;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(468, 85);
            this.pictureBoxLogo.TabIndex = 17;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLocalization
            // 
            this.labelLocalization.AutoSize = true;
            this.labelLocalization.BackColor = System.Drawing.Color.White;
            this.labelLocalization.Font = new System.Drawing.Font("Cascadia Code Light", 12F);
            this.labelLocalization.Location = new System.Drawing.Point(-3, 429);
            this.labelLocalization.Name = "labelLocalization";
            this.labelLocalization.Size = new System.Drawing.Size(109, 21);
            this.labelLocalization.TabIndex = 20;
            this.labelLocalization.Text = "Локализация";
            this.labelLocalization.Visible = false;
            // 
            // GooseMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.labelLocalization);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelDOL);
            this.Controls.Add(this.labelDOLPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GooseMessageBox";
            this.Text = "GooseMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDOL;
        private System.Windows.Forms.Label labelDOLPage;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelLocalization;
    }
}