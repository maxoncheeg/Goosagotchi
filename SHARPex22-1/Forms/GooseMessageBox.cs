using System;
using System.Windows.Forms;

namespace Goosagotchi.Forms
{
    public partial class GooseMessageBox : Form
    {
        private int _hours;
        private int _days;

        private GooseMessageBox(int _hours)
        {
            InitializeComponent();

            this._hours = _hours;
            _days = 0;

            while(this._hours > 24)
            {
                this._hours -= 24;
                _days++;
            }

            string result = "";

            if (_days > 0) result += $"Days: {_days}, ";
            result += $"Hours: {this._hours}";

            labelDOL.Text = result;
        }

        public static DialogResult GameOver(int gameHours)
        {
            GooseMessageBox messageBox = new GooseMessageBox(gameHours);

            return messageBox.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "Выход";
            labelLocalization.Visible = true;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelDOL_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = $"Дни: {_days}, Часы: {_hours}";
            labelLocalization.Visible = true;
        }

        private void labelDOL_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelDOLPage_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "Длительность жизни";
            labelLocalization.Visible = true;
        }

        private void labelDOLPage_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Text = "Жизнь гуся окончена. Игра окончена";
            labelLocalization.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }
    }
}
