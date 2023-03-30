using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Goosagotchi.Classes;

namespace Goosagotchi.Forms
{
    public partial class FormMain : Form
    {
        private Goosagochi _goosagochi;
        public FormMain()
        {
            InitializeComponent();

            _goosagochi = Goosagochi.Create();
            _goosagochi.FormUpdater += UpdateForm;
            buttonHeal.Enabled = false;

            progressBarComplete.Value = 0;
        }

        private void UpdateForm(object sender, EventArgs args)
        {
            try
            {
                if (sender is Goosagochi)
                {
                    if (_goosagochi.IsGameOver) _goosagochi.GameOver(this);

                    if (pictureBoxGoose.Image != Properties.Resources.Bite)
                        pictureBoxGoose.Image =
                           (Image)Properties.Resources.ResourceManager.GetObject(_goosagochi.UnrealGoose.Status.ToString());//интересная штуковина

                    labelMistakes.Text = $"{_goosagochi.MistakesCounter} OF 3";

                    if (_goosagochi.MistakesCounter == 3 && _goosagochi.UnrealGoose.Status == GooseStatus.Heal) buttonHeal.Enabled = true;

                    if (_goosagochi.IsTimerActive && progressBarComplete.Value == 0)
                    {
                        progressBarComplete.Maximum = _goosagochi.ProgressBarValue;
                        progressBarComplete.Value = _goosagochi.ProgressBarValue;



                        Thread thread = new Thread(ThreadTick) { IsBackground = true };
                        thread.Start();
                    }

                    if (args is GooseMesage)
                        labelStatus.Text = (args as GooseMesage).Message;
                }
            }
            catch
            { /*Недопустимая операция в нескольких потоках: попытка доступа
                         * к элементу управления 'labelStatus ну и ко всем остальным' 
                         * не из того потока, в котором он был создан
                         * 
                         * я не знаю, что делать в этой ситуации, при ctrl+f5 все нормально работает
                         * но при запуске через пуск, вылетает эта ошибка, так что
                                         приворюсь, что этого нету)
                */
            }
        }

        private void buttonHeal_Click(object sender, EventArgs e) =>
            _goosagochi.CheckStatusSatisfaction(GooseStatus.Heal);
        
        private void buttonWalk_Click(object sender, EventArgs e) =>
            _goosagochi.CheckStatusSatisfaction(GooseStatus.Walk);

        private void buttonSleep_Click(object sender, EventArgs e) =>
            _goosagochi.CheckStatusSatisfaction(GooseStatus.Sleep);

        private void buttonPlay_Click(object sender, EventArgs e) =>
            _goosagochi.CheckStatusSatisfaction(GooseStatus.Play);

        private void buttonEat_Click(object sender, EventArgs e) =>
            _goosagochi.CheckStatusSatisfaction(GooseStatus.Eat);

        private void ThreadTick()
        {
            while (progressBarComplete.Value > 0)
            {
                if (!_goosagochi.IsTimerActive)
                {
                    buttonHeal.Enabled = false;
                    progressBarComplete.Value = 0;
                    return;
                }

                progressBarComplete.Value--;
            }

            buttonHeal.Enabled = false;
            _goosagochi.IsTimerActive = false;
            _goosagochi.IsProgressBarComplete();
        }
    }
}
