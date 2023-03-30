using System;

namespace Goosagotchi.Classes
{
    class GooseMesage : EventArgs
    {
        public string Message { get; private set; }

        private GooseMesage() { }

        public static GooseMesage FromGooseStatus(GooseStatus status) {
            GooseMesage message = new GooseMesage();

            switch (status)
            {
                case GooseStatus.Normal:
                    message.Message = "I feel good";
                    break;
                case GooseStatus.Play:
                    message.Message = "I want to play!";
                    break;
                case GooseStatus.Walk:
                    message.Message = "Eh.., I would like to take a walk now...";
                    break;
                case GooseStatus.Sleep:
                    message.Message = "Wow, I'm so sleepy...";
                    break;
                case GooseStatus.Eat:
                    message.Message = "I'm hungry!";
                    break;
                case GooseStatus.Heal:
                    message.Message = "A DOCTOR! A DOCTOR!";
                    break;
                default:
                    message.Message = "I feel good";
                    break;
            }

            return message;
        }
    }
}
