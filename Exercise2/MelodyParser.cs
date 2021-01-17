using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            char[] array = melody.ToCharArray();
            Note[] notes = new Note[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                notes[i] = GetMelody(array[i]);
            }

            return notes;
        }

        private static Note GetMelody(char code)
        {
            return (code) switch
            {
                '1' => Note.Do(1, 500),
                '2' => Note.Re(1, 500),
                '3' => Note.Mi(1, 500),
                '4' => Note.Fa(1, 500),
                '5' => Note.Sol(1, 500),
                '6' => Note.La(1, 500),
                '7' => Note.Si(1, 500),
                '8' => Note.Do(2, 500),
                '9' => Note.Re(2, 500),
                '0' => Note.Mi(2, 500),
                _ => new Note(0, 500, true),
            };
        }
    }
}
