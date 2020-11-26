namespace lab9
{
    public class Song
    {
        //Properties

        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public genre Genre { get; set; }

        //Constructors
        public Song(string title, string artist, double dur, genre gen)
        {
            Title = title;
            Artist = artist;
            Duration = dur;
            Genre = gen;
        }
        public Song(string title, string artist) : this(title, artist, 0, genre.Other) { }
        public Song() : this("Unknown", "Unknown") { }
    }
    public enum genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
}
