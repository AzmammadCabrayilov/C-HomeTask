using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2.Models
{
    class Song
    {
        public Song()
        {

        }

        private string _SongName;
        private string _Genre;
        private Singer _Singer;
        private int[] Ratings = new int[0];


        public string SongName
        {
            get
            {
                return _SongName;
            }
            set
            {
                if (value.Length > 0 && value.Length < 100)
                {

                    _SongName = value;
                }
            }
        }

        public string Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                string[] genreProperties = { "Pop", "Rock", "Jazz", "Techno" };
                foreach (var item in genreProperties)
                {
                    if (item == value)
                    {
                        _Genre = value;
                    }
                }
                
            }
        }

        public Singer Singer
        {
            get
            {
                return _Singer;
            }
            set
            {
                _Singer = value;
            }
        }


        public Song(string songName, string genre , Singer singer)
        {
            SongName = songName;
            Genre = genre;
            Singer = singer;
        }

        public void AddRating(int rating)
        {
            if (rating >= 0 && rating <= 5)
            {
                Array.Resize(ref Ratings, Ratings.Length + 1);
                Ratings[Ratings.Length - 1] = rating;
            }
        }

        public double GetAverageRating()
        {
            return Math.Round(Ratings.Average(), 2);
        }

    }
}

