using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Exercise2
{
    static class Player
    {
        public static void Play(Note[] notes)
        {
            foreach (var note in notes)
            {
                if (note.Pause == true)
                {
                    Thread.Sleep(note.Duration);
                } else
                {
                    //Console.Beep(note.Frequency, note.Duration);
                    Console.Beep(500, 2000); //  На таких настройках слышно.
                }
            }
        }
    }
}
