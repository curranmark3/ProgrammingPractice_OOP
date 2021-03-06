﻿using System.Collections.Generic;

namespace lab9
{
    public class SortPlaylist : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            int returnVal = string.Compare(x.Artist, y.Artist);

            if (returnVal == 0)
            {
                returnVal = string.Compare(x.Title, y.Title);
            }

            return returnVal;
        }
    }

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

        //Methods
        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {Genre}");
        }
    }
    public enum genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
}
