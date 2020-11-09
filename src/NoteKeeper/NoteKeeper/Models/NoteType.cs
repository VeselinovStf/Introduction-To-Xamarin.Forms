namespace NoteKeeper.Models
{
    public class NoteType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}