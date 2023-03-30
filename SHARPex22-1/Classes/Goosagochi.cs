using Goosagotchi.Forms;
using System;
using System.Media;

namespace Goosagotchi.Classes
{
    class Goosagochi
    {
        private int _hourCounter;
        private System.Timers.Timer _timer;
        private Random _random;
        private SoundPlayer _soundPlayer;

        public event EventHandler FormUpdater;

        public int MistakesCounter { get; set; }
        public int ProgressBarValue { get; set; }
        public bool IsTimerActive { get; set; }
        public bool IsGameOver { get; set; }
        public Goose UnrealGoose { get; private set; }      

        private Goosagochi()
        {
            _timer = new System.Timers.Timer();
            _timer.Elapsed += TimerTick;
            _timer.Interval = 2000;
            _soundPlayer = new SoundPlayer("Correct.wav");
            _random = new Random();
            _hourCounter = 0;//Если хотите хардкорный режим, поставьте здесь больше 120

            UnrealGoose = new Goose() { Name = "Bob" };
            MistakesCounter = 0;
            IsTimerActive = false;
            IsGameOver = false;

            _timer.Start();
        }

        public static Goosagochi Create() => new Goosagochi();

        private void TimerTick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(MistakesCounter >= 3)
            {
                UnrealGoose.Status = GooseStatus.Heal;
                ProgressBarValue = 4000;

                IsTimerActive = true;
            }

            if (_random.Next(0, 100) > (_hourCounter >= 120 ? 35 : 75) && UnrealGoose.Status == GooseStatus.Normal)
            {//после 5 дней начинается хардкор режим
                switch (_random.Next(0, 5))
                {
                    case 0:
                        UnrealGoose.Status = GooseStatus.Play;
                        ProgressBarValue = _hourCounter >= 120 ? 4500 : 10000;
                        break;
                    case 1:
                        UnrealGoose.Status = GooseStatus.Sleep;
                        ProgressBarValue = _hourCounter >= 120 ? 4500 : 9000;
                        break;
                    case 2:
                        UnrealGoose.Status = GooseStatus.Walk;
                        ProgressBarValue = _hourCounter >= 120 ? 3999 : 10000;
                        break;
                    case 3:
                        UnrealGoose.Status = GooseStatus.Eat;
                        ProgressBarValue = _hourCounter >= 120 ? 3700 : 9000;
                        break;
                    default:
                        UnrealGoose.Status = GooseStatus.Play;
                        ProgressBarValue = _hourCounter >= 120 ? 4000 : 10000;
                        break;
                }

                IsTimerActive = true;
            }

            UpdateForm();
            _hourCounter++;
        }

        public void CheckStatusSatisfaction(GooseStatus status)
        {
            IsTimerActive = false;

            if (MistakesCounter == 3 && UnrealGoose.Status != GooseStatus.Heal) return;//чтобы просто так не тыкали

            if (UnrealGoose.Status == status)
            {
                _soundPlayer.SoundLocation = "Correct.wav";

                if (status == GooseStatus.Play)
                {
                    _timer.Stop();

                    if (FormStoneGame.Play() == System.Windows.Forms.DialogResult.OK)
                        _soundPlayer.Play();
                    else
                    {
                        _soundPlayer.SoundLocation = "Incorrect.wav";
                        _soundPlayer.Play();

                        MistakesCounter++;
                    }

                    _timer.Start();
                }
                else if (status == GooseStatus.Walk)
                {
                    _timer.Stop();

                    if (FormWalkGame.TakeAWalk() == System.Windows.Forms.DialogResult.OK)
                        _soundPlayer.Play();
                    else
                    {
                        _soundPlayer.SoundLocation = "Incorrect.wav";
                        _soundPlayer.Play();

                        MistakesCounter++;
                    }

                    _timer.Start();
                }
                else
                {
                    if(status == GooseStatus.Heal) MistakesCounter = 0;
                    _soundPlayer.Play();
                }
            }
            else
            {
                _soundPlayer.SoundLocation = "Incorrect.wav";
                _soundPlayer.Play();

                MistakesCounter++;

                if (UnrealGoose.Status == GooseStatus.Heal)
                {
                    IsGameOver = true;
                }
            }

            UnrealGoose.Status = GooseStatus.Normal;

            UpdateForm();
        }

        public void IsProgressBarComplete()
        {
            _soundPlayer.SoundLocation = "Incorrect.wav";
            _soundPlayer.Play();

            if (UnrealGoose.Status == GooseStatus.Heal)
            {
                IsGameOver = true;
                UpdateForm();
            }

            IsTimerActive = false;
            MistakesCounter++;
            UnrealGoose.Status = GooseStatus.Normal;

            UpdateForm();
        }

        public void GameOver(FormMain form)
        {
            _timer.Stop();

            GooseMessageBox.GameOver(_hourCounter);
            form.Close();
        }

        private void UpdateForm() 
        {
            if (FormUpdater != null) 
                FormUpdater(this, GooseMesage.FromGooseStatus(UnrealGoose.Status));
        }      
    }
}
