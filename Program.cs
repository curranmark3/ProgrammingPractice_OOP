using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Beautiful People", "Ed Sheeran", 3.15, genre.Pop);
            Song song2 = new Song("Ride It", "Regard", 3.37, genre.Dance);
            Song song3 = new Song("Dance Monkey", "Tones & I", 4.20, genre.Dance);
            Song song4 = new Song("Circles", "Post Malone", 3.25, genre.Pop);
            Song song5 = new Song("South of The Border", "Ed Sheeran", 4.26, genre.Other);

            List<Song> Playlist = new List<Song>();
            Playlist.Add(song1);
            Playlist.Add(song2);
            Playlist.Add(song3);
            Playlist.Add(song4);
            Playlist.Add(song5);

            DisplayPlayList(Playlist);

            Playlist.Sort(new SortPlaylist());
            
            Console.WriteLine("\nSorting the playlist by Artist, then Title\n");

            DisplayPlayList(Playlist);

            List<Song> shuffledPlaylist = Shuffle(Playlist);

            DisplayPlayList(shuffledPlaylist);
        }

        static List<Song> Shuffle(List<Song> shuffledPl)
        {
            Console.WriteLine("\nShuffling playlist . . .");

            Random rng = new Random();
            Song temp = new Song();
            int songNumber;

            for (int i = 0; i < shuffledPl.Count; i++)
            {
                songNumber = rng.Next(shuffledPl.Count);
                temp = shuffledPl.ElementAt(i);
                shuffledPl[i] = shuffledPl.ElementAt(songNumber);
                shuffledPl[songNumber] = temp;
            }


            return shuffledPl;
        }
        static void DisplayPlayList(List<Song> pl)
        {
            Console.WriteLine("{0,-20}{1,-25}{2,-10}{3,-10}", "Artist", "Song", "Duration", "Genre");

            foreach (Song song in pl)
            {
                Console.WriteLine($"{song.Artist, -20}{song.Title, -25}{song.Duration, -10}{song.Genre, -10}");
            }
        }
    }
}
