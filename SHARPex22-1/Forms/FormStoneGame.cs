using System;
using System.Windows.Forms;

namespace Goosagotchi.Forms
{
    public partial class FormStoneGame : Form
    {
        private int _answer;

        private FormStoneGame()
        {
            InitializeComponent();

            Random random = new Random();

            _answer = random.Next(0, 4);
            this.DialogResult = DialogResult.Cancel;
        }

        public static DialogResult Play()
        {
            FormStoneGame form = new FormStoneGame();

            return form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (_answer == 2) this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (_answer == 1) this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_answer == 0) this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (_answer == 3) this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void labelGame_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "ИГРА";
            labelLocalization.Visible = true;
        }

        private void labelGame_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Text = "";
            labelLocalization.Visible = false;
        }

        private void labelTask_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "Под каким камнем прячется гусь?";
            labelLocalization.Visible = true;
        }

        private void labelTask_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Text = "";
            labelLocalization.Visible = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "1";
            labelLocalization.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Text = "";
            labelLocalization.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "2";
            labelLocalization.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Text = "";
            labelLocalization.Visible = false;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "3";
            labelLocalization.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Text = "";
            labelLocalization.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "4";
            labelLocalization.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Text = "";
            labelLocalization.Visible = false;
        }
    }
}
