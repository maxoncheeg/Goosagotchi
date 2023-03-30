using System;
using System.Drawing;
using System.Windows.Forms;

namespace Goosagotchi.Forms
{
    public partial class FormWalkGame : Form
    {
        private int _goosePosition;
        private int _wall1Position;
        private int _wall2Position;
        private int _speed;
        private Random _random;

        private FormWalkGame()
        {
            InitializeComponent();
            _goosePosition = 3;
            _wall2Position = 2;
            _wall1Position = 1;

            _speed = 4;

            _random = new Random();

            timerSubwaySurf.Start();
        }

        public static DialogResult TakeAWalk()
        {
            FormWalkGame game = new FormWalkGame();

            return game.ShowDialog();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (--_goosePosition == 1) buttonUp.Enabled = false;
            else if (_goosePosition == 2) buttonDown.Enabled = true;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (++_goosePosition == 3) buttonDown.Enabled = false;
            else if (_goosePosition == 2) buttonUp.Enabled = true;
        }

        private void timerSubwaySurf_Tick(object sender, EventArgs e)
        {
            if (--progressBarRun.Value == 0)
            {
                timerSubwaySurf.Stop();
                DialogResult = DialogResult.OK;

                this.Close();
            }

            if (progressBarRun.Value % 100 == 0) _speed++;

            switch (_goosePosition)
            {
                case 1:
                    pictureBoxGoose.Location = new Point(110, 40);
                    break;
                case 2:
                    pictureBoxGoose.Location = new Point(110, 170);
                    break;
                case 3:
                    pictureBoxGoose.Location = new Point(110, 300);
                    break;
                default:
                    break;
            }

            pictureBoxWall1.Location = new Point(pictureBoxWall1.Location.X - _speed, pictureBoxWall1.Location.Y);
            pictureBoxWall2.Location = new Point(pictureBoxWall2.Location.X - _speed, pictureBoxWall2.Location.Y);

            if(pictureBoxWall1.Location.X >= pictureBoxGoose.Location.X && pictureBoxWall1.Location.X <= pictureBoxGoose.Location.X + 99 && _wall1Position == _goosePosition
                || pictureBoxWall2.Location.X >= pictureBoxGoose.Location.X && pictureBoxWall2.Location.X <= pictureBoxGoose.Location.X + 99 && _wall2Position == _goosePosition)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }

            if(pictureBoxWall1.Location.X <= -100)
                switch (_wall1Position = _random.Next(1,4))
                {
                    case 1:
                        pictureBoxWall1.Location = new Point(800, 40);
                        break;
                    case 2:
                        pictureBoxWall1.Location = new Point(800, 170);
                        break;
                    case 3:
                        pictureBoxWall1.Location = new Point(800, 300);
                        break;
                }

            if (pictureBoxWall2.Location.X <= -100)
                switch (_wall2Position = _random.Next(1, 4))
                {
                    case 1:
                        pictureBoxWall2.Location = new Point(800, 40);
                        break;
                    case 2:
                        pictureBoxWall2.Location = new Point(800, 170);
                        break;
                    case 3:
                        pictureBoxWall2.Location = new Point(800, 300);
                        break;
                }
        }
    }
}
