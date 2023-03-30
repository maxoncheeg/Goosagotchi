using System;

namespace Goosagotchi.Classes
{
    public enum GooseStatus
    {
        Normal,
        Play,
        Walk,
        Sleep,
        Eat,
        Heal
    }

    public class Goose
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; } = DateTime.Now;
        public GooseStatus Status { get; set; } = GooseStatus.Normal;

        public static string StatusTranslation(GooseStatus status)
        {
            switch (status)
            {
                case GooseStatus.Normal: return "Мне хорошо";
                case GooseStatus.Play: return "Я хочу играть!";
                case GooseStatus.Walk: return "Эх, сейчас бы погулять...";
                case GooseStatus.Sleep: return "Ух, как же хочется спать...";
                case GooseStatus.Eat: return "Я хочу есть!";
                case GooseStatus.Heal: return "ВРАЧА! ВРАЧА!";
                default:return "...ошибка локализации...";
            }
        }
    }
}
