using Goosagotchi.Classes;
using System;
using System.Drawing;

namespace Goosagotchi.Forms
{
    public partial class FormMain
    {
        private void pictureBoxLogo_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "Гусягочи";
        }

        private void pictureBoxLogo_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void buttonHeal_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "Вылечить";
        }

        private void buttonHeal_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }
        private void buttonPlay_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "Поиграть";
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void buttonSleep_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "Уложить спать";
        }

        private void buttonSleep_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void buttonWalk_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "Погулять";
        }

        private void buttonWalk_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void buttonEat_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "Покормить";
        }

        private void buttonEat_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelActions_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "ДЕЙСТВИЯ";
        }

        private void labelActions_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelTimeToComplete_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "ВРЕМЯ НА ВЫПОЛНЕНИЕ";
        }

        private void labelTimeToComplete_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelStatusPage_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "СТАТУС";
        }

        private void labelStatusPage_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelMistakesPage_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = "ОШИБКИ";
        }

        private void labelMistakesPage_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelMistakes_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = $"{_goosagochi.MistakesCounter} ИЗ 3";
        }

        private void labelMistakes_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void labelStatus_MouseHover(object sender, EventArgs e)
        {
            labelLocalization.Visible = true;
            labelLocalization.Text = Goose.StatusTranslation(_goosagochi.UnrealGoose.Status);
        }

        private void labelStatus_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";
        }

        private void pictureBoxGoose_MouseHover(object sender, EventArgs e)
        {
            pictureBoxGoose.Image = Properties.Resources.Bite;
            labelStatus.Text = "DON'T TOUCH ME!";

            labelLocalization.Visible = true;
            labelLocalization.Text = "НЕ ТРОГАЙ!";
        }

        private void pictureBoxGoose_MouseLeave(object sender, EventArgs e)
        {
            labelLocalization.Visible = false;
            labelLocalization.Text = "";

            pictureBoxGoose.Image =
                       (Image)Properties.Resources.ResourceManager.GetObject(_goosagochi.UnrealGoose.Status.ToString());
        }
    }
}
