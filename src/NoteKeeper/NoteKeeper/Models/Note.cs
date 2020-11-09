using System;
using System.Collections.Generic;
using System.Text;

namespace NoteKeeper.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public NoteType NoteType { get; set; }

        public string Text { get; set; }
    }
}
