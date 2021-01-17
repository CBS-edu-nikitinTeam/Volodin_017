using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Note
    {
        public int Frequency { get; private set; }
        public int Duration { get; private set; }

        public bool Pause { get; private set; }

        public Note(int frequency, int duration, bool pause)
        {
            Frequency = frequency;
            Duration = duration;
            Pause = pause;
        }


        public static Note Do(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }

        public static Note Re(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 293,
                2 => 587,
                3 => 1174,
                4 => 2349,
                5 => 4698,
                _ => 293,
            };
            return new Note(frequency, duration, false);
        }

        public static Note Mi(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 329,
                2 => 659,
                3 => 1318,
                4 => 2637,
                5 => 5274,
                _ => 329,
            };
            return new Note(frequency, duration, false);
        }

        public static Note Fa(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 349,
                2 => 698,
                3 => 1396,
                4 => 2793,
                5 => 5587,
                _ => 349,
            };
            return new Note(frequency, duration, false);
        }

        public static Note Sol(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 392,
                2 => 783,
                3 => 1568,
                4 => 3136,
                5 => 6271,
                _ => 349,
            };
            return new Note(frequency, duration, false);
        }

        public static Note La(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 440,
                2 => 880,
                3 => 1760,
                4 => 3520,
                5 => 7040,
                _ => 440,
            };
            return new Note(frequency, duration, false);
        }

        public static Note Si(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 493,
                2 => 987,
                3 => 1975,
                4 => 3951,
                5 => 7902,
                _ => 493,
            };
            return new Note(frequency, duration, false);
        }
    }
}
