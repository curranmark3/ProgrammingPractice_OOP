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
        }

        static void DisplayPlayList(List<Song> pl)
        {

        }
    }
}
